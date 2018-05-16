namespace RandomLabelMove
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
            this.buttonRace = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.raceTrackPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownDog = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonBet = new System.Windows.Forms.Button();
            this.labelBetterName = new System.Windows.Forms.Label();
            this.labelAlBet = new System.Windows.Forms.Label();
            this.labelBobBet = new System.Windows.Forms.Label();
            this.labelJoeBet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonAl = new System.Windows.Forms.RadioButton();
            this.radioButtonBob = new System.Windows.Forms.RadioButton();
            this.radioButtonJoe = new System.Windows.Forms.RadioButton();
            this.labelMinimumBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRace
            // 
            this.buttonRace.Location = new System.Drawing.Point(421, 56);
            this.buttonRace.Name = "buttonRace";
            this.buttonRace.Size = new System.Drawing.Size(172, 85);
            this.buttonRace.TabIndex = 3;
            this.buttonRace.Text = "Race";
            this.buttonRace.UseVisualStyleBackColor = true;
            this.buttonRace.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // raceTrackPicture
            // 
            this.raceTrackPicture.Image = global::RandomLabelMove.Properties.Resources.racetrack;
            this.raceTrackPicture.Location = new System.Drawing.Point(0, 0);
            this.raceTrackPicture.Name = "raceTrackPicture";
            this.raceTrackPicture.Size = new System.Drawing.Size(622, 211);
            this.raceTrackPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrackPicture.TabIndex = 8;
            this.raceTrackPicture.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RandomLabelMove.Properties.Resources.dog;
            this.pictureBox4.Location = new System.Drawing.Point(12, 180);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RandomLabelMove.Properties.Resources.dog;
            this.pictureBox3.Location = new System.Drawing.Point(12, 127);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RandomLabelMove.Properties.Resources.dog;
            this.pictureBox2.Location = new System.Drawing.Point(12, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RandomLabelMove.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownDog);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownAmount);
            this.groupBox1.Controls.Add(this.buttonBet);
            this.groupBox1.Controls.Add(this.labelBetterName);
            this.groupBox1.Controls.Add(this.labelAlBet);
            this.groupBox1.Controls.Add(this.labelBobBet);
            this.groupBox1.Controls.Add(this.labelJoeBet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonAl);
            this.groupBox1.Controls.Add(this.radioButtonBob);
            this.groupBox1.Controls.Add(this.radioButtonJoe);
            this.groupBox1.Controls.Add(this.labelMinimumBet);
            this.groupBox1.Controls.Add(this.buttonRace);
            this.groupBox1.Location = new System.Drawing.Point(0, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 183);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // numericUpDownDog
            // 
            this.numericUpDownDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDog.Location = new System.Drawing.Point(371, 151);
            this.numericUpDownDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDog.Name = "numericUpDownDog";
            this.numericUpDownDog.Size = new System.Drawing.Size(45, 22);
            this.numericUpDownDog.TabIndex = 16;
            this.numericUpDownDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "bucks on dog number";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAmount.Location = new System.Drawing.Point(177, 150);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(45, 22);
            this.numericUpDownAmount.TabIndex = 14;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonBet
            // 
            this.buttonBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBet.Location = new System.Drawing.Point(99, 150);
            this.buttonBet.Name = "buttonBet";
            this.buttonBet.Size = new System.Drawing.Size(54, 23);
            this.buttonBet.TabIndex = 13;
            this.buttonBet.Text = "Bets";
            this.buttonBet.UseVisualStyleBackColor = true;
            this.buttonBet.Click += new System.EventHandler(this.buttonBet_Click);
            // 
            // labelBetterName
            // 
            this.labelBetterName.AutoSize = true;
            this.labelBetterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBetterName.Location = new System.Drawing.Point(12, 153);
            this.labelBetterName.Name = "labelBetterName";
            this.labelBetterName.Size = new System.Drawing.Size(42, 16);
            this.labelBetterName.TabIndex = 12;
            this.labelBetterName.Text = "name";
            // 
            // labelAlBet
            // 
            this.labelAlBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAlBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlBet.Location = new System.Drawing.Point(186, 118);
            this.labelAlBet.Name = "labelAlBet";
            this.labelAlBet.Size = new System.Drawing.Size(201, 23);
            this.labelAlBet.TabIndex = 11;
            this.labelAlBet.Text = "alBetLabel";
            // 
            // labelBobBet
            // 
            this.labelBobBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBobBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBobBet.Location = new System.Drawing.Point(186, 86);
            this.labelBobBet.Name = "labelBobBet";
            this.labelBobBet.Size = new System.Drawing.Size(201, 23);
            this.labelBobBet.TabIndex = 10;
            this.labelBobBet.Text = "bobBetLabel";
            // 
            // labelJoeBet
            // 
            this.labelJoeBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelJoeBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoeBet.Location = new System.Drawing.Point(186, 56);
            this.labelJoeBet.Name = "labelJoeBet";
            this.labelJoeBet.Size = new System.Drawing.Size(201, 25);
            this.labelJoeBet.TabIndex = 9;
            this.labelJoeBet.Text = "joeBetLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bets";
            // 
            // radioButtonAl
            // 
            this.radioButtonAl.AutoSize = true;
            this.radioButtonAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAl.Location = new System.Drawing.Point(12, 117);
            this.radioButtonAl.Name = "radioButtonAl";
            this.radioButtonAl.Size = new System.Drawing.Size(111, 20);
            this.radioButtonAl.TabIndex = 7;
            this.radioButtonAl.TabStop = true;
            this.radioButtonAl.Text = "alRadioButton";
            this.radioButtonAl.UseVisualStyleBackColor = true;
            this.radioButtonAl.CheckedChanged += new System.EventHandler(this.radioButtonAl_CheckedChanged);
            // 
            // radioButtonBob
            // 
            this.radioButtonBob.AutoSize = true;
            this.radioButtonBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBob.Location = new System.Drawing.Point(12, 86);
            this.radioButtonBob.Name = "radioButtonBob";
            this.radioButtonBob.Size = new System.Drawing.Size(124, 20);
            this.radioButtonBob.TabIndex = 6;
            this.radioButtonBob.TabStop = true;
            this.radioButtonBob.Text = "bobRadioButton";
            this.radioButtonBob.UseVisualStyleBackColor = true;
            this.radioButtonBob.CheckedChanged += new System.EventHandler(this.radioButtonBob_CheckedChanged);
            // 
            // radioButtonJoe
            // 
            this.radioButtonJoe.AutoSize = true;
            this.radioButtonJoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonJoe.Location = new System.Drawing.Point(12, 55);
            this.radioButtonJoe.Name = "radioButtonJoe";
            this.radioButtonJoe.Size = new System.Drawing.Size(123, 20);
            this.radioButtonJoe.TabIndex = 5;
            this.radioButtonJoe.TabStop = true;
            this.radioButtonJoe.Text = "JoeRadioButton";
            this.radioButtonJoe.UseVisualStyleBackColor = true;
            this.radioButtonJoe.CheckedChanged += new System.EventHandler(this.radioButtonJoe_CheckedChanged);
            // 
            // labelMinimumBet
            // 
            this.labelMinimumBet.AutoSize = true;
            this.labelMinimumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimumBet.Location = new System.Drawing.Point(12, 31);
            this.labelMinimumBet.Name = "labelMinimumBet";
            this.labelMinimumBet.Size = new System.Drawing.Size(130, 16);
            this.labelMinimumBet.TabIndex = 4;
            this.labelMinimumBet.Text = "minimumBetLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.raceTrackPicture);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRace;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox raceTrackPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMinimumBet;
        private System.Windows.Forms.NumericUpDown numericUpDownDog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Button buttonBet;
        private System.Windows.Forms.Label labelBetterName;
        private System.Windows.Forms.Label labelAlBet;
        private System.Windows.Forms.Label labelBobBet;
        private System.Windows.Forms.Label labelJoeBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonAl;
        private System.Windows.Forms.RadioButton radioButtonBob;
        private System.Windows.Forms.RadioButton radioButtonJoe;
    }
}

