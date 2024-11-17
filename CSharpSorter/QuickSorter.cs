using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSharpSorter
{
    internal class QuickSorter
    {
        private int partition(int[] arr,
                         int low, int high, Chart chart)
        {
            int temp;
            int pivot = arr[high];
            DataPointCollection points = chart.Series["Array"].Points;
            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    points[i].YValues[0] = arr[j];
                    arr[j] = temp;
                    points[j].YValues[0] = temp;
                    chart.Refresh();
                    Thread.Sleep(100);
                }
            }
            temp = arr[i + 1];
            arr[i + 1] = arr[high];
            points[i + 1].YValues[0] = arr[high];
            arr[high] = temp;
            points[high].YValues[0] = temp;
            chart.Refresh();
            Thread.Sleep(100);
            return i + 1;
        }


        private void sortHelper(int[] arr, int low, int high, Chart chart)
        {
            if (low < high)
            {
                int part_index = partition(arr, low, high, chart);
                sortHelper(arr, low, part_index - 1, chart);
                sortHelper(arr, part_index + 1, high, chart);
            }
        }
        public void Sort(int[] arr, Chart chart)
        {
            sortHelper(arr,0, arr.Length - 1, chart);
        }
    }
}
