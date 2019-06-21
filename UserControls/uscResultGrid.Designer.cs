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
            this.cbbResult = new System.Windows.Forms.DataGridView();
            this.bdsResult = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsResult)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbResult
            // 
            this.cbbResult.AutoGenerateColumns = false;
            this.cbbResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cbbResult.DataSource = this.bdsResult;
            this.cbbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbResult.Location = new System.Drawing.Point(0, 0);
            this.cbbResult.Name = "cbbResult";
            this.cbbResult.RowTemplate.Height = 23;
            this.cbbResult.Size = new System.Drawing.Size(669, 333);
            this.cbbResult.TabIndex = 0;
            // 
            // uscResultGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbResult);
            this.Name = "uscResultGrid";
            this.Size = new System.Drawing.Size(669, 333);
            ((System.ComponentModel.ISupportInitialize)(this.cbbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cbbResult;
        private System.Windows.Forms.BindingSource bdsResult;
    }
}
