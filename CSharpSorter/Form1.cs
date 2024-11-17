namespace CSharpSorter
{
    public partial class Form1 : Form
    {
        private int[] array = [21, 85, 4, 79, 96, 69, 31, 45, 49, 33, 38, 23, 68, 49, 80, 34, 41,
 19, 92, 3, 74, 43, 43, 35, 7, 48, 29, 38, 50, 83];
        private int[] original = [21, 85, 4, 79, 96, 69, 31, 45, 49, 33, 38, 23, 68, 49, 80, 34, 41,
 19, 92, 3, 74, 43, 43, 35, 7, 48, 29, 38, 50, 83];
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BubbleSorter bubble = new BubbleSorter();
            bubble.Sort(array, SortChart);
            Thread.Sleep(1000);
            for (int i = 0; i < original.Length; i++)
            {
                SortChart.Series["Array"].Points[i].YValues[0] = original[i];
            }
            SortChart.Refresh();
            array = (int[])original.Clone();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RadixSort radix = new RadixSort();
            radix.Sort(array, SortChart);
            Thread.Sleep(1000);
            for (int i = 0; i < original.Length; i++)
            {
                SortChart.Series["Array"].Points[i].YValues[0] = original[i];
            }
            SortChart.Refresh();
            array = (int[])original.Clone();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShellSorter shell = new ShellSorter();
            shell.Sort(array, SortChart);
            Thread.Sleep(1000);
            for (int i = 0; i < original.Length; i++)
            {
                SortChart.Series["Array"].Points[i].YValues[0] = original[i];
            }
            SortChart.Refresh();
            array = (int[])original.Clone();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            HeapSorter heap = new HeapSorter();
            heap.Sort(array, SortChart);
            Thread.Sleep(1000);
            for (int i = 0; i < original.Length; i++)
            {
                SortChart.Series["Array"].Points[i].YValues[0] = original[i];
            }
            SortChart.Refresh();
            array = (int[])original.Clone();
        }

        private void SortChart_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < array.Length; i++)
            {
                SortChart.Series["Array"].Points.AddXY(i, array[i]);
            }
        }

        private void insertionSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertionSorter insert = new InsertionSorter();
            insert.Sort(array, SortChart);
            Thread.Sleep(1000);
            for (int i = 0; i < original.Length; i++)
            {
                SortChart.Series["Array"].Points[i].YValues[0] = original[i];
            }
            SortChart.Refresh();
            array = (int[])original.Clone();
        }

        private void QuickSort_Click(object sender, EventArgs e)
        {
            QuickSorter quick = new QuickSorter();
            quick.Sort(array, SortChart);
            Thread.Sleep(1000);
            for (int i = 0; i < original.Length; i++)
            {
                SortChart.Series["Array"].Points[i].YValues[0] = original[i];
            }
            SortChart.Refresh();
            array = (int[])original.Clone();
        }
    }
}
