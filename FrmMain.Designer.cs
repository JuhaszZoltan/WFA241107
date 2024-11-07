namespace WFA241107
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtb = new RichTextBox();
            txb = new TextBox();
            SuspendLayout();
            // 
            // rtb
            // 
            rtb.Location = new Point(12, 50);
            rtb.Name = "rtb";
            rtb.Size = new Size(367, 222);
            rtb.TabIndex = 0;
            rtb.Text = "";
            // 
            // txb
            // 
            txb.Location = new Point(12, 12);
            txb.Name = "txb";
            txb.Size = new Size(367, 32);
            txb.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 284);
            Controls.Add(txb);
            Controls.Add(rtb);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FrmMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb;
        private TextBox txb;
    }
}
