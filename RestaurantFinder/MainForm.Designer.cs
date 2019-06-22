namespace RestaurantFinder
{
    partial class MainForm
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
            this.uscResultGrid1 = new UserControls.uscResultGrid();
            this.uscSearchBox1 = new UserControls.uscSearchBox();
            this.SuspendLayout();
            // 
            // uscResultGrid1
            // 
            this.uscResultGrid1.Location = new System.Drawing.Point(202, 117);
            this.uscResultGrid1.Name = "uscResultGrid1";
            this.uscResultGrid1.Size = new System.Drawing.Size(669, 333);
            this.uscResultGrid1.TabIndex = 1;
            this.uscResultGrid1.CellDoubleClickedHandler += new System.Action<object, UserControls.ResultFormats.SearchResultData>(this.UscResultGrid1_CellDoubleClickedHandler);
            // 
            // uscSearchBox1
            // 
            this.uscSearchBox1.AutoSize = true;
            this.uscSearchBox1.Location = new System.Drawing.Point(0, 0);
            this.uscSearchBox1.Name = "uscSearchBox1";
            this.uscSearchBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uscSearchBox1.Size = new System.Drawing.Size(579, 118);
            this.uscSearchBox1.TabIndex = 0;
            this.uscSearchBox1.SearchButtonHandler += new System.Action<object, RestaurantDB.DB_jun.SearchConditions>(this.UscSearchBox1_SearchButtonHandler);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 462);
            this.Controls.Add(this.uscResultGrid1);
            this.Controls.Add(this.uscSearchBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.uscSearchBox uscSearchBox1;
        private UserControls.uscResultGrid uscResultGrid1;
    }
}