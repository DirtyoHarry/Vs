namespace calc
{
    partial class FormGrid
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
            this.dataGridWarehouse = new System.Windows.Forms.DataGridView();
            this.ClmnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clmnload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clmnprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridWarehouse
            // 
            this.dataGridWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnDate,
            this.ClmnDs,
            this.Clmnload,
            this.ClmnUn,
            this.Clmnprice});
            this.dataGridWarehouse.Location = new System.Drawing.Point(12, 48);
            this.dataGridWarehouse.Name = "dataGridWarehouse";
            this.dataGridWarehouse.Size = new System.Drawing.Size(345, 277);
            this.dataGridWarehouse.TabIndex = 0;
            this.dataGridWarehouse.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gridChecker);
            // 
            // ClmnDate
            // 
            this.ClmnDate.HeaderText = "Data";
            this.ClmnDate.Name = "ClmnDate";
            this.ClmnDate.Width = 50;
            // 
            // ClmnDs
            // 
            this.ClmnDs.HeaderText = "Descrizione";
            this.ClmnDs.Name = "ClmnDs";
            // 
            // Clmnload
            // 
            this.Clmnload.HeaderText = "Carico";
            this.Clmnload.Name = "Clmnload";
            this.Clmnload.Width = 50;
            // 
            // ClmnUn
            // 
            this.ClmnUn.HeaderText = "Scarico";
            this.ClmnUn.Name = "ClmnUn";
            this.ClmnUn.Width = 50;
            // 
            // Clmnprice
            // 
            this.Clmnprice.HeaderText = "Prezzo";
            this.Clmnprice.Name = "Clmnprice";
            this.Clmnprice.Width = 50;
            // 
            // FormGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 337);
            this.Controls.Add(this.dataGridWarehouse);
            this.Name = "FormGrid";
            this.Text = "FormGrid";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clmnload;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clmnprice;
    }
}