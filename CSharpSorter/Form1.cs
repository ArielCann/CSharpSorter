namespace CSharpSorter
{
    public partial class Form1 : Form
    {
        private int[] array = [21, 85, 4, 79, 96, 69, 31, 45, 49, 33, 38, 23, 68, 49, 80, 34, 41,
 19, 92, 3, 74, 43, 43, 35, 7, 48, 29, 38, 50, 83];
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void SortChart_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < array.Length; i++) {
                SortChart.Series["Array"].Points.AddXY(i, array[i]);
                SortChart.Series["Array"].Points.ElementAt(i).SetValueY(i);
            }
        }
    }
}
