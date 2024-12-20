﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSharpSorter
{
    internal class InsertionSorter
    {
        public void Sort(int[] arr, Chart chart)
        {
            DataPointCollection points = chart.Series["Array"].Points;
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    points[j+ 1].YValues[0] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
                points[j + 1].YValues[0] = key;
                chart.Refresh();
                Thread.Sleep(100);
            }
        }
    }
}
