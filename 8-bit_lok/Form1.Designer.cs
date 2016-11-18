namespace _8_bit_lok
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
            this.canv1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // canv1
            // 
            this.canv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canv1.Location = new System.Drawing.Point(0, 0);
            this.canv1.Name = "canv1";
            this.canv1.Size = new System.Drawing.Size(1200, 700);
            this.canv1.TabIndex = 0;
            this.canv1.Paint += new System.Windows.Forms.PaintEventHandler(this.canv1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.canv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Side";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canv1;

    }
}

