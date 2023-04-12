using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pickolorderer
{
    internal class PicHandler
    {
        BackgroundWorker worker;
        public Dictionary<Color, string> AveragedColors { get; set; } = new Dictionary<Color, string>();
        private int highestPercentageReached = 0;
        Pickolorderer mainWin;


        public PicHandler(List<string> fileList, Pickolorderer form)
        {
            this.mainWin = form;
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            worker.RunWorkerCompleted +=new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            worker.RunWorkerAsync(fileList);
            mainWin.sortColorsBtn.Enabled = false;
            mainWin.sortColorsBtn.Text = "Doin' Work";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            AveragedColors = (Dictionary<Color, string>)e.Result;

            ColorSorter sorter = new ColorSorter(AveragedColors);
            int pixelMargin = 74;
            int count = 0;
            int spacing = 10;
            foreach (HSLColor color in sorter.SortedHSLValues.Keys)
            {
                Console.WriteLine("HSL:" + color.H + " " + color.S + " " + color.L);
                Panel panel = new Panel();
                Color c = ColorSorter.calculateHSLtoRGB(color);
                Console.WriteLine("RGB:" + c.R + " " + c.G + " " + c.B);
                panel.BackColor = c;

                mainWin.orderedFileList.Items.Add(sorter.SortedHSLValues[color]);
                panel.Bounds = new Rectangle(10, spacing + count * pixelMargin, mainWin.resultPanel.Width - 10, 64);

                mainWin.resultPanel.Controls.Add(panel);
                count++;
            }
            mainWin.sortColorsBtn.Enabled = true;
            mainWin.sortColorsBtn.Text = "Sort";
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = GetAVGColorFromPics((List<string>)e.Argument, worker, e);
        }

        private void backgroundWorker1_ProgressChanged(object sender,ProgressChangedEventArgs e)
        {
            mainWin.progressBar1.Value = e.ProgressPercentage;
        }

        private Dictionary<Color, string> GetAVGColorFromPics(List<string> fileList, BackgroundWorker worker, DoWorkEventArgs e)
        {
            Dictionary<Color, string> filledList = new Dictionary<Color, string>();
            int count = 1;


            foreach (string image in fileList)
            {
                Bitmap bitmap = new Bitmap(image);

                int R = 0;
                int G = 0;
                int B = 0;

                int totalPixels = bitmap.Width * bitmap.Height;

                for(int i = 0; i< bitmap.Height; i++)
                {
                    for (int j = 0; j < bitmap.Width; j++)
                    {
                        R += bitmap.GetPixel(i, j).R;
                        G += bitmap.GetPixel(i, j).G;
                        B += bitmap.GetPixel(i, j).B;
                    }
                }

                R /= totalPixels;
                G /= totalPixels;
                B /= totalPixels;

                filledList.Add(Color.FromArgb(R, G, B), image);

                int percentComplete =
                    (int)((float)count / (float)fileList.Count * 100);
                if (percentComplete > highestPercentageReached)
                {
                    highestPercentageReached = percentComplete;
                    worker.ReportProgress(percentComplete);
                }
                count++;
            }

            return filledList;
        }
    }
}
