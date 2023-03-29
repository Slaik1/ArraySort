namespace ArraySort
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.labelLenth = new System.Windows.Forms.Label();
            this.textBoxLenth = new System.Windows.Forms.TextBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.textBoxMinNum = new System.Windows.Forms.TextBox();
            this.textBoxMaxNum = new System.Windows.Forms.TextBox();
            this.labelMinNum = new System.Windows.Forms.Label();
            this.labelMaxNum = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.checkBoxFastView = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(909, 562);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Buble Sort",
            "Quick Sort"});
            this.comboBoxSort.Location = new System.Drawing.Point(927, 12);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSort.TabIndex = 2;
            this.comboBoxSort.Text = "Buble Sort";
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // labelLenth
            // 
            this.labelLenth.AutoSize = true;
            this.labelLenth.Location = new System.Drawing.Point(982, 396);
            this.labelLenth.Name = "labelLenth";
            this.labelLenth.Size = new System.Drawing.Size(34, 13);
            this.labelLenth.TabIndex = 3;
            this.labelLenth.Text = "Lenth";
            // 
            // textBoxLenth
            // 
            this.textBoxLenth.Location = new System.Drawing.Point(948, 412);
            this.textBoxLenth.Name = "textBoxLenth";
            this.textBoxLenth.Size = new System.Drawing.Size(100, 20);
            this.textBoxLenth.TabIndex = 4;
            this.textBoxLenth.Text = "100";
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(978, 499);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(34, 13);
            this.labelDelay.TabIndex = 5;
            this.labelDelay.Text = "Delay";
            this.labelDelay.UseMnemonic = false;
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(948, 515);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(100, 20);
            this.textBoxDelay.TabIndex = 6;
            this.textBoxDelay.Text = "0";
            // 
            // textBoxMinNum
            // 
            this.textBoxMinNum.Location = new System.Drawing.Point(948, 372);
            this.textBoxMinNum.Name = "textBoxMinNum";
            this.textBoxMinNum.Size = new System.Drawing.Size(45, 20);
            this.textBoxMinNum.TabIndex = 7;
            this.textBoxMinNum.Text = "1";
            // 
            // textBoxMaxNum
            // 
            this.textBoxMaxNum.Location = new System.Drawing.Point(999, 372);
            this.textBoxMaxNum.Name = "textBoxMaxNum";
            this.textBoxMaxNum.Size = new System.Drawing.Size(49, 20);
            this.textBoxMaxNum.TabIndex = 8;
            this.textBoxMaxNum.Text = "100";
            // 
            // labelMinNum
            // 
            this.labelMinNum.AutoSize = true;
            this.labelMinNum.Location = new System.Drawing.Point(945, 347);
            this.labelMinNum.Name = "labelMinNum";
            this.labelMinNum.Size = new System.Drawing.Size(49, 13);
            this.labelMinNum.TabIndex = 9;
            this.labelMinNum.Text = "Min Num";
            // 
            // labelMaxNum
            // 
            this.labelMaxNum.AutoSize = true;
            this.labelMaxNum.Location = new System.Drawing.Point(996, 347);
            this.labelMaxNum.Name = "labelMaxNum";
            this.labelMaxNum.Size = new System.Drawing.Size(52, 13);
            this.labelMaxNum.TabIndex = 10;
            this.labelMaxNum.Text = "Max Num";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(964, 438);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 11;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // checkBoxFastView
            // 
            this.checkBoxFastView.AutoSize = true;
            this.checkBoxFastView.Location = new System.Drawing.Point(964, 307);
            this.checkBoxFastView.Name = "checkBoxFastView";
            this.checkBoxFastView.Size = new System.Drawing.Size(72, 17);
            this.checkBoxFastView.TabIndex = 13;
            this.checkBoxFastView.Text = "Fast View";
            this.checkBoxFastView.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(964, 551);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 597);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.checkBoxFastView);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelMaxNum);
            this.Controls.Add(this.labelMinNum);
            this.Controls.Add(this.textBoxMaxNum);
            this.Controls.Add(this.textBoxMinNum);
            this.Controls.Add(this.textBoxDelay);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.textBoxLenth);
            this.Controls.Add(this.labelLenth);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLenth;
        private System.Windows.Forms.TextBox textBoxLenth;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.TextBox textBoxDelay;
        private System.Windows.Forms.TextBox textBoxMinNum;
        private System.Windows.Forms.TextBox textBoxMaxNum;
        private System.Windows.Forms.Label labelMinNum;
        private System.Windows.Forms.Label labelMaxNum;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.CheckBox checkBoxFastView;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ComboBox comboBoxSort;
    }
}

