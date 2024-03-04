namespace FormLogger
{
    partial class LogForm
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
            components = new System.ComponentModel.Container();
            tbxLogSheet = new TextBox();
            Timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // tbxLogSheet
            // 
            tbxLogSheet.BackColor = Color.MistyRose;
            tbxLogSheet.Location = new Point(15, 13);
            tbxLogSheet.Multiline = true;
            tbxLogSheet.Name = "tbxLogSheet";
            tbxLogSheet.ScrollBars = ScrollBars.Horizontal;
            tbxLogSheet.Size = new Size(533, 579);
            tbxLogSheet.TabIndex = 0;
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(564, 607);
            Controls.Add(tbxLogSheet);
            Name = "LogForm";
            Text = "LogForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxLogSheet;
        private System.Windows.Forms.Timer Timer1;
    }
}