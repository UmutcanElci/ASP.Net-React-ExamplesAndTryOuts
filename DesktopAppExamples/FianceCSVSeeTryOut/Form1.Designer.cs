namespace FianceCSVSeeTryOut
{
    partial class Form1
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
            this.file_button = new System.Windows.Forms.Button();
            this.nasdaqSite = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openCloseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // file_button
            // 
            this.file_button.Location = new System.Drawing.Point(639, 397);
            this.file_button.Name = "file_button";
            this.file_button.Size = new System.Drawing.Size(132, 32);
            this.file_button.TabIndex = 0;
            this.file_button.Text = "button1";
            this.file_button.UseVisualStyleBackColor = true;
            this.file_button.Click += new System.EventHandler(this.file_button_Click);
            // 
            // nasdaqSite
            // 
            this.nasdaqSite.Location = new System.Drawing.Point(645, 362);
            this.nasdaqSite.Name = "nasdaqSite";
            this.nasdaqSite.Size = new System.Drawing.Size(126, 29);
            this.nasdaqSite.TabIndex = 1;
            this.nasdaqSite.Text = "nasdaq";
            this.nasdaqSite.UseVisualStyleBackColor = true;
            this.nasdaqSite.Click += new System.EventHandler(this.nasdaqSite_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateStockDataGridViewTextBoxColumn,
            this.openCloseDataGridViewTextBoxColumn,
            this.openDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(58, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 230);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateStockDataGridViewTextBoxColumn
            // 
            this.dateStockDataGridViewTextBoxColumn.DataPropertyName = "DateStock";
            this.dateStockDataGridViewTextBoxColumn.HeaderText = "DateStock";
            this.dateStockDataGridViewTextBoxColumn.Name = "dateStockDataGridViewTextBoxColumn";
            // 
            // openCloseDataGridViewTextBoxColumn
            // 
            this.openCloseDataGridViewTextBoxColumn.DataPropertyName = "OpenClose";
            this.openCloseDataGridViewTextBoxColumn.HeaderText = "OpenClose";
            this.openCloseDataGridViewTextBoxColumn.Name = "openCloseDataGridViewTextBoxColumn";
            // 
            // openDataGridViewTextBoxColumn
            // 
            this.openDataGridViewTextBoxColumn.DataPropertyName = "Open";
            this.openDataGridViewTextBoxColumn.HeaderText = "Open";
            this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            // 
            // highDataGridViewTextBoxColumn
            // 
            this.highDataGridViewTextBoxColumn.DataPropertyName = "High";
            this.highDataGridViewTextBoxColumn.HeaderText = "High";
            this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "Low";
            this.lowDataGridViewTextBoxColumn.HeaderText = "Low";
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            // 
            // stockModelBindingSource
            // 
            this.stockModelBindingSource.DataSource = typeof(FianceCSVSeeTryOut.StockModel);
            // 
            // stockModelBindingSource1
            // 
            this.stockModelBindingSource1.DataSource = typeof(FianceCSVSeeTryOut.StockModel);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nasdaqSite);
            this.Controls.Add(this.file_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockModelBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button nasdaqSite;

        private System.Windows.Forms.Button file_button;

        #endregion
        private System.Windows.Forms.BindingSource stockModelBindingSource;
        private System.Windows.Forms.BindingSource stockModelBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openCloseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}