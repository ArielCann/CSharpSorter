using System;
using System.Windows.Forms.DataVisualization.Charting;
public class BubbleSorter
{
	public void Sort(int[] arr, Chart chart)
	{
        var size = arr.Length;
        bool swapRequired;
        DataPointCollection points = chart.Series["Array"].Points;
        for (int i = 0; i < size - 1; i++)
        {
            swapRequired = false;
            for (int j = 0; j < size - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    var temp = arr[j];
                    arr[j] = arr[j + 1];
                    points[j].YValues[0] = arr[j + 1];
                    arr[j + 1] = temp;
                    points[j + 1].YValues[0] = temp;
                    chart.Refresh();
                    Thread.Sleep(50);
                    swapRequired = true;
                }
            if (swapRequired == false)
                break;
        }
    }
}
