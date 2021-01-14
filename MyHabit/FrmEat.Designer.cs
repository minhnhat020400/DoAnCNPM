
namespace MyHabit
{
    partial class FrmEat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEat));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new MyHabit.Data();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buoiDataGridViewTextBoxColumn,
            this.caloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.revenueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(533, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(255, 128);
            this.dataGridView1.TabIndex = 0;
            // 
            // buoiDataGridViewTextBoxColumn
            // 
            this.buoiDataGridViewTextBoxColumn.DataPropertyName = "Buoi";
            this.buoiDataGridViewTextBoxColumn.HeaderText = "Buoi";
            this.buoiDataGridViewTextBoxColumn.Name = "buoiDataGridViewTextBoxColumn";
            // 
            // caloDataGridViewTextBoxColumn
            // 
            this.caloDataGridViewTextBoxColumn.DataPropertyName = "Calo";
            this.caloDataGridViewTextBoxColumn.HeaderText = "Calo";
            this.caloDataGridViewTextBoxColumn.Name = "caloDataGridViewTextBoxColumn";
            // 
            // revenueBindingSource
            // 
            this.revenueBindingSource.DataMember = "Revenue";
            this.revenueBindingSource.DataSource = this.data;
            // 
            // data
            // 
            this.data.DataSetName = "Data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(516, 201);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(284, 250);
            this.pieChart1.TabIndex = 1;
            this.pieChart1.Text = "pieChart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmEat";
            this.Text = "Ăn";
            this.Load += new System.EventHandler(this.Eat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource revenueBindingSource;
        private Data data;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}