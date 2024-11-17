using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
namespace CSharpSorter
{
    internal class ShellSorter
    {
        public void Sort (int[] arr, Chart chart)
        {
            DataPointCollection points = chart.Series["Array"].Points;
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int j = i;
                    int temp = arr[i];

                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        points[j].YValues[0] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = temp;
                    points[j].YValues[0] = temp;
                    chart.Refresh();
                    Thread.Sleep(100);
                }
            }
        }
    }
}
