namespace CSharpSorter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuStrip1 = new MenuStrip();
            BubbleTab = new ToolStripMenuItem();
            ShellTab = new ToolStripMenuItem();
            RadixTab = new ToolStripMenuItem();
            HeapTab = new ToolStripMenuItem();
            insertionSortToolStripMenuItem = new ToolStripMenuItem();
            SortChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            QuickSort = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SortChart).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { BubbleTab, ShellTab, RadixTab, HeapTab, insertionSortToolStripMenuItem, QuickSort });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // BubbleTab
            // 
            BubbleTab.Name = "BubbleTab";
            BubbleTab.Size = new Size(116, 29);
            BubbleTab.Text = "BubbleSort";
            BubbleTab.Click += toolStripMenuItem1_Click;
            // 
            // ShellTab
            // 
            ShellTab.Name = "ShellTab";
            ShellTab.Size = new Size(98, 29);
            ShellTab.Text = "ShellSort";
            ShellTab.Click += toolStripMenuItem2_Click;
            // 
            // RadixTab
            // 
            RadixTab.Name = "RadixTab";
            RadixTab.Size = new Size(104, 29);
            RadixTab.Text = "RadixSort";
            RadixTab.Click += toolStripMenuItem3_Click;
            // 
            // HeapTab
            // 
            HeapTab.Name = "HeapTab";
            HeapTab.Size = new Size(103, 29);
            HeapTab.Text = "HeapSort";
            HeapTab.Click += toolStripMenuItem4_Click;
            // 
            // insertionSortToolStripMenuItem
            // 
            insertionSortToolStripMenuItem.Name = "insertionSortToolStripMenuItem";
            insertionSortToolStripMenuItem.Size = new Size(130, 29);
            insertionSortToolStripMenuItem.Text = "InsertionSort";
            insertionSortToolStripMenuItem.Click += insertionSortToolStripMenuItem_Click;
            // 
            // SortChart
            // 
            chartArea2.Name = "ChartArea1";
            SortChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            SortChart.Legends.Add(legend2);
            SortChart.Location = new Point(227, 36);
            SortChart.Name = "SortChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Array";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            SortChart.Series.Add(series2);
            SortChart.Size = new Size(505, 353);
            SortChart.TabIndex = 1;
            SortChart.Text = "chart1";
            SortChart.Click += SortChart_Click;
            // 
            // QuickSort
            // 
            QuickSort.Name = "QuickSort";
            QuickSort.Size = new Size(106, 29);
            QuickSort.Text = "QuickSort";
            QuickSort.Click += QuickSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SortChart);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SortChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem BubbleTab;
        private ToolStripMenuItem ShellTab;
        private ToolStripMenuItem RadixTab;
        private ToolStripMenuItem HeapTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart SortChart;
        private ToolStripMenuItem insertionSortToolStripMenuItem;
        private ToolStripMenuItem QuickSort;
    }
}
