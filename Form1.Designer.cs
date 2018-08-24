namespace RacetrackSimulator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dogNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.betNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.betsLabel = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.raceTrackPictureBox = new System.Windows.Forms.PictureBox();
            this.dogPicture0 = new System.Windows.Forms.PictureBox();
            this.dogPicture1 = new System.Windows.Forms.PictureBox();
            this.dogPicture2 = new System.Windows.Forms.PictureBox();
            this.dogPicture3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dogNumericUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.betNumericUpDown);
            this.groupBox1.Controls.Add(this.betsButton);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.raceButton);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.alRadioButton);
            this.groupBox1.Controls.Add(this.bobRadioButton);
            this.groupBox1.Controls.Add(this.joeRadioButton);
            this.groupBox1.Controls.Add(this.betsLabel);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dogNumericUpDown
            // 
            this.dogNumericUpDown.Location = new System.Drawing.Point(375, 168);
            this.dogNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumericUpDown.Name = "dogNumericUpDown";
            this.dogNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.dogNumericUpDown.TabIndex = 13;
            this.dogNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "£ on the dog number:";
            // 
            // betNumericUpDown
            // 
            this.betNumericUpDown.Location = new System.Drawing.Point(183, 167);
            this.betNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betNumericUpDown.Name = "betNumericUpDown";
            this.betNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.betNumericUpDown.TabIndex = 11;
            this.betNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(92, 164);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(75, 23);
            this.betsButton.TabIndex = 9;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(29, 165);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 18);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // raceButton
            // 
            this.raceButton.Font = new System.Drawing.Font("Segoe Marker", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceButton.Location = new System.Drawing.Point(675, 36);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(257, 136);
            this.raceButton.TabIndex = 7;
            this.raceButton.Text = "RACE!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(350, 116);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(186, 22);
            this.alBetLabel.TabIndex = 6;
            this.alBetLabel.Text = "alBetLabel";
            this.alBetLabel.Click += new System.EventHandler(this.alBetLabel_Click);
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(350, 87);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(186, 23);
            this.bobBetLabel.TabIndex = 6;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(350, 60);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(186, 23);
            this.joeBetLabel.TabIndex = 5;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(22, 116);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(92, 17);
            this.alRadioButton.TabIndex = 4;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(22, 93);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 3;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(22, 66);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.joeRadioButton.TabIndex = 2;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // betsLabel
            // 
            this.betsLabel.AutoSize = true;
            this.betsLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betsLabel.Location = new System.Drawing.Point(347, 35);
            this.betsLabel.Name = "betsLabel";
            this.betsLabel.Size = new System.Drawing.Size(41, 17);
            this.betsLabel.TabIndex = 1;
            this.betsLabel.Text = "Bets:";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(19, 35);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(43, 17);
            this.minimumBetLabel.TabIndex = 1;
            this.minimumBetLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Betting Parlor";
            // 
            // raceTrackPictureBox
            // 
            this.raceTrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("raceTrackPictureBox.Image")));
            this.raceTrackPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("raceTrackPictureBox.InitialImage")));
            this.raceTrackPictureBox.Location = new System.Drawing.Point(12, 16);
            this.raceTrackPictureBox.Name = "raceTrackPictureBox";
            this.raceTrackPictureBox.Size = new System.Drawing.Size(973, 328);
            this.raceTrackPictureBox.TabIndex = 1;
            this.raceTrackPictureBox.TabStop = false;
            // 
            // dogPicture0
            // 
            this.dogPicture0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dogPicture0.Image = ((System.Drawing.Image)(resources.GetObject("dogPicture0.Image")));
            this.dogPicture0.InitialImage = null;
            this.dogPicture0.Location = new System.Drawing.Point(12, 49);
            this.dogPicture0.Name = "dogPicture0";
            this.dogPicture0.Size = new System.Drawing.Size(122, 42);
            this.dogPicture0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPicture0.TabIndex = 2;
            this.dogPicture0.TabStop = false;
            // 
            // dogPicture1
            // 
            this.dogPicture1.Image = ((System.Drawing.Image)(resources.GetObject("dogPicture1.Image")));
            this.dogPicture1.Location = new System.Drawing.Point(12, 124);
            this.dogPicture1.Name = "dogPicture1";
            this.dogPicture1.Size = new System.Drawing.Size(122, 42);
            this.dogPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPicture1.TabIndex = 3;
            this.dogPicture1.TabStop = false;
            // 
            // dogPicture2
            // 
            this.dogPicture2.Image = ((System.Drawing.Image)(resources.GetObject("dogPicture2.Image")));
            this.dogPicture2.Location = new System.Drawing.Point(12, 207);
            this.dogPicture2.Name = "dogPicture2";
            this.dogPicture2.Size = new System.Drawing.Size(122, 42);
            this.dogPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPicture2.TabIndex = 4;
            this.dogPicture2.TabStop = false;
            // 
            // dogPicture3
            // 
            this.dogPicture3.Image = ((System.Drawing.Image)(resources.GetObject("dogPicture3.Image")));
            this.dogPicture3.Location = new System.Drawing.Point(12, 280);
            this.dogPicture3.Name = "dogPicture3";
            this.dogPicture3.Size = new System.Drawing.Size(122, 42);
            this.dogPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPicture3.TabIndex = 5;
            this.dogPicture3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 553);
            this.Controls.Add(this.dogPicture3);
            this.Controls.Add(this.dogPicture2);
            this.Controls.Add(this.dogPicture1);
            this.Controls.Add(this.dogPicture0);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.raceTrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Racetrack Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox raceTrackPictureBox;
        private System.Windows.Forms.PictureBox dogPicture0;
        private System.Windows.Forms.PictureBox dogPicture1;
        private System.Windows.Forms.PictureBox dogPicture2;
        private System.Windows.Forms.PictureBox dogPicture3;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label betsLabel;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.NumericUpDown betNumericUpDown;
        private System.Windows.Forms.NumericUpDown dogNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

