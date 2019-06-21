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
            this.ucsChooseLocation1 = new UserControls.ucsChooseLocation();
            this.SuspendLayout();
            // 
            // ucsChooseLocation1
            // 
            this.ucsChooseLocation1.Location = new System.Drawing.Point(0, 0);
            this.ucsChooseLocation1.Name = "ucsChooseLocation1";
            this.ucsChooseLocation1.Size = new System.Drawing.Size(382, 409);
            this.ucsChooseLocation1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucsChooseLocation1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucsChooseLocation ucsChooseLocation1;
    }
}