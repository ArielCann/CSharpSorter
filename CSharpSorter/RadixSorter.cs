using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSharpSorter
{
    class RadixSort
    {

        public void Sort(int[] arr, Chart chart)
        {
            int[] tempArr = new int[arr.Length];
            DataPointCollection points = chart.Series["Array"].Points;
            int LargestElementDigits = FindNumLen(GetMaxNum(arr, -1));
            for (int i = 0; i <= LargestElementDigits; i++)
            {
                arr = CountingSort(arr, i);
                for (int j = 0; j < arr.Length; j++)
                {
                    points[j].YValues[0] = arr[j];
                }
                chart.Refresh();
                Thread.Sleep(300);

            }
        }
        private int FindNumLen(int num)
        {
            return (int)(Math.Log10(num) + 1);
        }
        public int[] CountingSort(int[] list, int digit)
        {

            int[] countingArray = new int[GetMaxNum(list, digit) + 1];
            FillCountingArray(countingArray, list, digit);
            return FillRegularSort(list, countingArray, digit);
        }
        private int GetMaxNum(int[] list, int digit)
        {
            int maxNum = 0;
            foreach (int item in list)
            {
                int currItem = digit == -1 ? item : GetDigit(item, digit);
                if (currItem > maxNum)
                {
                    maxNum = currItem;
                }
            }
            return maxNum;
        }
        private void FillCountingArray(int[] cp, int[] list, int digit)
        {
            foreach (int item in list)
            {
                cp[GetDigit(item, digit)]++;
            }
            for (int i = 1; i < cp.Length; i++)
            {
                cp[i] += cp[i - 1];
            }

        }
        private int[] FillRegularSort(int[] list, int[] countedArr, int digit)
        {
            int[] newArr = new int[list.Length];
            for (int i = list.Length - 1; i >= 0; i--)
            {
                newArr[--countedArr[GetDigit(list[i], digit)]] = list[i];
            }
            return newArr;
        }
        public int GetDigit(int number, int positionFromRight)
        {
            string numberStr = number.ToString();

            if (positionFromRight < 0 || positionFromRight >= numberStr.Length)
            {
                return 0;
            }

            char digitChar = numberStr[numberStr.Length - 1 - positionFromRight];
            return int.Parse(digitChar.ToString());
        }
    }
}
