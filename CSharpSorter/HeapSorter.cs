using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSharpSorter
{
    internal class HeapSorter
    {
        private void Heapify(int[] arr, int size, int i, Chart chart)
        {
            DataPointCollection points = chart.Series["Array"].Points;
            int largest = i;

            int left = 2 * i + 1;

            int right = 2 * i + 2;

            if (left < size && arr[left] > arr[largest])
            {
                largest = left;
            }

            if (right < size && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                points[i].YValues[0] = arr[largest];
                arr[largest] = temp;
                points[largest].YValues[0] = temp;
                chart.Refresh();
                Thread.Sleep(100);
                Heapify(arr, size, largest, chart);
            }
        }

        public void Sort(int[] arr, Chart chart)
        {
            DataPointCollection points = chart.Series["Array"].Points;
            int size = arr.Length;
            for (int i = size / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, size, i, chart);
            }

            for (int i = size - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                points[0].YValues[0] = arr[i];
                arr[i] = temp;
                points[i].YValues[0] = temp;
                chart.Refresh();
                Thread.Sleep(100);
                Heapify(arr, i, 0, chart);
            }
        }
    }
}
