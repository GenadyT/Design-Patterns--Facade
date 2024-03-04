namespace Facade.TheaterEquipControls
{
    partial class EquipControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public EquipControl(string equipTitle)
        {
            this.lblTitle.Text = equipTitle;
        }

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
            txbState = new TextBox();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // txbState
            // 
            txbState.Location = new Point(173, 13);
            txbState.Name = "txbState";
            txbState.Size = new Size(389, 23);
            txbState.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(13, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "label1";
            // 
            // EquipControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblTitle);
            Controls.Add(txbState);
            Name = "EquipControl";
            Size = new Size(577, 48);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbState;
        public Label lblTitle;
    }
}
