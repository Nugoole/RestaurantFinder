namespace UserControls
{
    partial class uscResultGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridResult = new System.Windows.Forms.DataGridView();
            this.bdsResult = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gridResult
            // 
            this.gridResult.AutoGenerateColumns = false;
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.outlineDataGridViewTextBoxColumn});
            this.gridResult.DataSource = this.bdsResult;
            this.gridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridResult.Location = new System.Drawing.Point(0, 0);
            this.gridResult.Name = "gridResult";
            this.gridResult.RowTemplate.Height = 23;
            this.gridResult.Size = new System.Drawing.Size(669, 333);
            this.gridResult.TabIndex = 0;
            this.gridResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridResult_CellContentClick);
            // 
            // bdsResult
            // 
            this.bdsResult.DataSource = typeof(UserControls.ResultFormats.SearchResultData);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // outlineDataGridViewTextBoxColumn
            // 
            this.outlineDataGridViewTextBoxColumn.DataPropertyName = "Outline";
            this.outlineDataGridViewTextBoxColumn.HeaderText = "Outline";
            this.outlineDataGridViewTextBoxColumn.Name = "outlineDataGridViewTextBoxColumn";
            // 
            // uscResultGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridResult);
            this.Name = "uscResultGrid";
            this.Size = new System.Drawing.Size(669, 333);
            this.Load += new System.EventHandler(this.UscResultGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridResult;
        private System.Windows.Forms.BindingSource bdsResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outlineDataGridViewTextBoxColumn;
    }
}
