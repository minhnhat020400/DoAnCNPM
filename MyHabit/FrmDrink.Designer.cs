
namespace MyHabit
{
    partial class FrmDrink
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDrink));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mililitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data1 = new MyHabit.Data1();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.button1 = new System.Windows.Forms.Button();
            this.data1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buoiDataGridViewTextBoxColumn,
            this.mililitDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.revenueBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(547, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(241, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // buoiDataGridViewTextBoxColumn
            // 
            this.buoiDataGridViewTextBoxColumn.DataPropertyName = "Buoi";
            this.buoiDataGridViewTextBoxColumn.HeaderText = "Buoi";
            this.buoiDataGridViewTextBoxColumn.Name = "buoiDataGridViewTextBoxColumn";
            // 
            // mililitDataGridViewTextBoxColumn
            // 
            this.mililitDataGridViewTextBoxColumn.DataPropertyName = "Mililit";
            this.mililitDataGridViewTextBoxColumn.HeaderText = "Mililit";
            this.mililitDataGridViewTextBoxColumn.Name = "mililitDataGridViewTextBoxColumn";
            // 
            // revenueBindingSource
            // 
            this.revenueBindingSource.DataMember = "Revenue";
            this.revenueBindingSource.DataSource = this.data1;
            // 
            // data1
            // 
            this.data1.DataSetName = "Data1";
            this.data1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pieChart1
            // 
            this.pieChart1.BackColor = System.Drawing.Color.Transparent;
            this.pieChart1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pieChart1.BackgroundImage")));
            this.pieChart1.Location = new System.Drawing.Point(494, 228);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(306, 223);
            this.pieChart1.TabIndex = 2;
            this.pieChart1.Text = "pieChart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data1BindingSource
            // 
            this.data1BindingSource.DataSource = this.data1;
            this.data1BindingSource.Position = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FrmDrink";
            this.Text = "FrmDrink";
            this.Load += new System.EventHandler(this.FrmDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mililitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource revenueBindingSource;
        private Data1 data1;
        private System.Windows.Forms.BindingSource data1BindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}