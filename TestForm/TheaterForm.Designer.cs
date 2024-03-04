namespace Facade
{
    partial class TheaterForm
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
            label1 = new Label();
            txbMovieName = new TextBox();
            btnTheaterOn = new Button();
            btnTheaterOff = new Button();
            eqcAmplifierControl = new TheaterEquipControls.AmplifierControl();
            eqcCDPLayerControl = new TheaterEquipControls.CDPLayerControl();
            eqcDvdPlayerControl = new TheaterEquipControls.DVDPlayerControl();
            eqcPopcornPopperControl = new TheaterEquipControls.PopcornPopperControl();
            eqcProjectorControl = new TheaterEquipControls.ProjectorControl();
            eqcScreenControl = new TheaterEquipControls.ScreenControl();
            eqcTheaterLigthsControl = new TheaterEquipControls.TheaterLigthsControl();
            eqcTunerControl = new TheaterEquipControls.TunerControl();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 22);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Movie Name:";
            // 
            // txbMovieName
            // 
            txbMovieName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txbMovieName.Location = new Point(99, 19);
            txbMovieName.Margin = new Padding(10);
            txbMovieName.Name = "txbMovieName";
            txbMovieName.Size = new Size(493, 23);
            txbMovieName.TabIndex = 2;
            txbMovieName.Text = "Tinker Tailor Soldier Spy";
            txbMovieName.TextChanged += txbMovieName_TextChanged;
            // 
            // btnTheaterOn
            // 
            btnTheaterOn.AutoSize = true;
            btnTheaterOn.BackColor = Color.FromArgb(191, 191, 191);
            btnTheaterOn.Cursor = Cursors.Hand;
            btnTheaterOn.FlatAppearance.BorderColor = Color.Green;
            btnTheaterOn.FlatStyle = FlatStyle.Flat;
            btnTheaterOn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTheaterOn.Location = new Point(14, 71);
            btnTheaterOn.Name = "btnTheaterOn";
            btnTheaterOn.Size = new Size(102, 27);
            btnTheaterOn.TabIndex = 3;
            btnTheaterOn.Text = "Theater On";
            btnTheaterOn.UseVisualStyleBackColor = false;
            btnTheaterOn.Click += btnTheaterOn_Click;
            // 
            // btnTheaterOff
            // 
            btnTheaterOff.AutoSize = true;
            btnTheaterOff.BackColor = Color.FromArgb(191, 191, 191);
            btnTheaterOff.Cursor = Cursors.Hand;
            btnTheaterOff.FlatAppearance.BorderColor = Color.Red;
            btnTheaterOff.FlatStyle = FlatStyle.Flat;
            btnTheaterOff.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTheaterOff.Location = new Point(486, 75);
            btnTheaterOff.Name = "btnTheaterOff";
            btnTheaterOff.Size = new Size(102, 27);
            btnTheaterOff.TabIndex = 4;
            btnTheaterOff.Text = "Theater Off";
            btnTheaterOff.UseVisualStyleBackColor = true;
            btnTheaterOff.Click += btnTheaterOff_Click;
            // 
            // eqcAmplifierControl
            // 
            eqcAmplifierControl.BackColor = SystemColors.GradientActiveCaption;
            eqcAmplifierControl.BorderStyle = BorderStyle.FixedSingle;
            eqcAmplifierControl.Location = new Point(15, 118);
            eqcAmplifierControl.Name = "eqcAmplifierControl";
            eqcAmplifierControl.Size = new Size(573, 50);
            eqcAmplifierControl.TabIndex = 5;
            eqcAmplifierControl.Title = "Amplifier";
            // 
            // eqcCDPLayerControl
            // 
            eqcCDPLayerControl.BackColor = SystemColors.GradientActiveCaption;
            eqcCDPLayerControl.BorderStyle = BorderStyle.FixedSingle;
            eqcCDPLayerControl.Location = new Point(14, 444);
            eqcCDPLayerControl.Name = "eqcCDPLayerControl";
            eqcCDPLayerControl.Size = new Size(577, 48);
            eqcCDPLayerControl.TabIndex = 6;
            eqcCDPLayerControl.Title = "CDP Layer -  up to you :-)";
            // 
            // eqcDvdPlayerControl
            // 
            eqcDvdPlayerControl.BackColor = SystemColors.GradientActiveCaption;
            eqcDvdPlayerControl.BorderStyle = BorderStyle.FixedSingle;
            eqcDvdPlayerControl.Location = new Point(14, 174);
            eqcDvdPlayerControl.Name = "eqcDvdPlayerControl";
            eqcDvdPlayerControl.Size = new Size(577, 48);
            eqcDvdPlayerControl.TabIndex = 7;
            eqcDvdPlayerControl.Title = "DVD Player";
            // 
            // eqcPopcornPopperControl
            // 
            eqcPopcornPopperControl.BackColor = SystemColors.GradientActiveCaption;
            eqcPopcornPopperControl.BorderStyle = BorderStyle.FixedSingle;
            eqcPopcornPopperControl.Location = new Point(14, 228);
            eqcPopcornPopperControl.Name = "eqcPopcornPopperControl";
            eqcPopcornPopperControl.Size = new Size(577, 48);
            eqcPopcornPopperControl.TabIndex = 9;
            eqcPopcornPopperControl.Title = "Popcorn Popper";
            // 
            // eqcProjectorControl
            // 
            eqcProjectorControl.BackColor = SystemColors.GradientActiveCaption;
            eqcProjectorControl.BorderStyle = BorderStyle.FixedSingle;
            eqcProjectorControl.Location = new Point(14, 282);
            eqcProjectorControl.Name = "eqcProjectorControl";
            eqcProjectorControl.Size = new Size(577, 48);
            eqcProjectorControl.TabIndex = 10;
            eqcProjectorControl.Title = "Projector";
            // 
            // eqcScreenControl
            // 
            eqcScreenControl.BackColor = SystemColors.GradientActiveCaption;
            eqcScreenControl.BorderStyle = BorderStyle.FixedSingle;
            eqcScreenControl.Location = new Point(14, 336);
            eqcScreenControl.Name = "eqcScreenControl";
            eqcScreenControl.Size = new Size(577, 48);
            eqcScreenControl.TabIndex = 11;
            eqcScreenControl.Title = "Screen";
            // 
            // eqcTheaterLigthsControl
            // 
            eqcTheaterLigthsControl.BackColor = SystemColors.GradientActiveCaption;
            eqcTheaterLigthsControl.BorderStyle = BorderStyle.FixedSingle;
            eqcTheaterLigthsControl.Location = new Point(14, 390);
            eqcTheaterLigthsControl.Name = "eqcTheaterLigthsControl";
            eqcTheaterLigthsControl.Size = new Size(577, 48);
            eqcTheaterLigthsControl.TabIndex = 12;
            eqcTheaterLigthsControl.Title = "Theater Ligths";
            // 
            // eqcTunerControl
            // 
            eqcTunerControl.BackColor = SystemColors.GradientActiveCaption;
            eqcTunerControl.BorderStyle = BorderStyle.FixedSingle;
            eqcTunerControl.Location = new Point(15, 498);
            eqcTunerControl.Name = "eqcTunerControl";
            eqcTunerControl.Size = new Size(577, 48);
            eqcTunerControl.TabIndex = 13;
            eqcTunerControl.Title = "Tuner -        up to you :-)";
            // 
            // TheaterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 556);
            Controls.Add(eqcTunerControl);
            Controls.Add(eqcTheaterLigthsControl);
            Controls.Add(eqcScreenControl);
            Controls.Add(eqcProjectorControl);
            Controls.Add(eqcPopcornPopperControl);
            Controls.Add(eqcDvdPlayerControl);
            Controls.Add(eqcCDPLayerControl);
            Controls.Add(eqcAmplifierControl);
            Controls.Add(btnTheaterOff);
            Controls.Add(btnTheaterOn);
            Controls.Add(txbMovieName);
            Controls.Add(label1);
            Name = "TheaterForm";
            Text = "Theater - Facade Design Pattern";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TheaterEquipControls.AmplifierControl eqcAmplifier;
        private Label label1;
        private TextBox txbMovieName;
        private Button btnTheaterOn;
        private Button btnTheaterOff;
        private TheaterEquipControls.CDPLayerControl cdPlayerControl1;
        private TheaterEquipControls.DVDPlayerControl dvdPlayerControl1;
        private TheaterEquipControls.PopcornPopperControl popcornPopperControl1;
        private TheaterEquipControls.ProjectorControl projectorControl1;
        private TheaterEquipControls.ScreenControl screenControl1;
        private TheaterEquipControls.TheaterLigthsControl theaterLigthsControl1;
        private TheaterEquipControls.TunerControl tunerControl1;
        private TheaterEquipControls.AmplifierControl eqcAmplifierControl;
        private TheaterEquipControls.CDPLayerControl eqcCDPLayerControl;
        private TheaterEquipControls.DVDPlayerControl eqcDvdPlayerControl;
        private TheaterEquipControls.PopcornPopperControl eqcPopcornPopperControl;
        private TheaterEquipControls.ProjectorControl eqcProjectorControl;
        private TheaterEquipControls.ScreenControl eqcScreenControl;
        private TheaterEquipControls.TheaterLigthsControl eqcTheaterLigthsControl;
        private TheaterEquipControls.TunerControl eqcTunerControl;
    }
}