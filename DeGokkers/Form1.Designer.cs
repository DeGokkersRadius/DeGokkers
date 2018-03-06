namespace DeGokkers
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPlayer3 = new System.Windows.Forms.RadioButton();
            this.rbPlayer2 = new System.Windows.Forms.RadioButton();
            this.rbPlayer1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.choose = new System.Windows.Forms.Button();
            this.rb_Fish = new System.Windows.Forms.RadioButton();
            this.rb_Shark = new System.Windows.Forms.RadioButton();
            this.rb_Dolphin = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.betAnimal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.btnBet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescp3 = new System.Windows.Forms.TextBox();
            this.txtDescp1 = new System.Windows.Forms.TextBox();
            this.txtDescp2 = new System.Windows.Forms.TextBox();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber3 = new System.Windows.Forms.Label();
            this.lblNumber4 = new System.Windows.Forms.Label();
            this.pbAnimal4 = new System.Windows.Forms.PictureBox();
            this.pbAnimal3 = new System.Windows.Forms.PictureBox();
            this.pbAnimal2 = new System.Windows.Forms.PictureBox();
            this.pbAnimal1 = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.rbPlayer3);
            this.groupBox1.Controls.Add(this.rbPlayer2);
            this.groupBox1.Controls.Add(this.rbPlayer1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 154);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wedder";
            // 
            // rbPlayer3
            // 
            this.rbPlayer3.AutoSize = true;
            this.rbPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlayer3.Location = new System.Drawing.Point(9, 79);
            this.rbPlayer3.Name = "rbPlayer3";
            this.rbPlayer3.Size = new System.Drawing.Size(43, 19);
            this.rbPlayer3.TabIndex = 2;
            this.rbPlayer3.TabStop = true;
            this.rbPlayer3.Text = "Fer";
            this.rbPlayer3.UseVisualStyleBackColor = true;
            this.rbPlayer3.CheckedChanged += new System.EventHandler(this.rbPlayer3_CheckedChanged);
            // 
            // rbPlayer2
            // 
            this.rbPlayer2.AutoSize = true;
            this.rbPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlayer2.Location = new System.Drawing.Point(9, 52);
            this.rbPlayer2.Name = "rbPlayer2";
            this.rbPlayer2.Size = new System.Drawing.Size(47, 19);
            this.rbPlayer2.TabIndex = 1;
            this.rbPlayer2.TabStop = true;
            this.rbPlayer2.Text = "Lidy";
            this.rbPlayer2.UseVisualStyleBackColor = true;
            this.rbPlayer2.CheckedChanged += new System.EventHandler(this.rbPlayer2_CheckedChanged);
            // 
            // rbPlayer1
            // 
            this.rbPlayer1.AutoSize = true;
            this.rbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlayer1.Location = new System.Drawing.Point(9, 24);
            this.rbPlayer1.Name = "rbPlayer1";
            this.rbPlayer1.Size = new System.Drawing.Size(59, 19);
            this.rbPlayer1.TabIndex = 0;
            this.rbPlayer1.TabStop = true;
            this.rbPlayer1.Text = "Sietse";
            this.rbPlayer1.UseVisualStyleBackColor = true;
            this.rbPlayer1.CheckedChanged += new System.EventHandler(this.rbPlayer1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minimum inzet: 5 euro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.betAnimal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.betAmount);
            this.groupBox2.Controls.Add(this.btnBet);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 224);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WedBureau";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox4.Controls.Add(this.choose);
            this.groupBox4.Controls.Add(this.rb_Fish);
            this.groupBox4.Controls.Add(this.rb_Shark);
            this.groupBox4.Controls.Add(this.rb_Dolphin);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(238, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 125);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Animal";
            // 
            // choose
            // 
            this.choose.BackColor = System.Drawing.Color.LightSeaGreen;
            this.choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose.Location = new System.Drawing.Point(6, 94);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(177, 25);
            this.choose.TabIndex = 3;
            this.choose.Text = "choose";
            this.choose.UseVisualStyleBackColor = false;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // rb_Fish
            // 
            this.rb_Fish.AutoSize = true;
            this.rb_Fish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Fish.Location = new System.Drawing.Point(6, 70);
            this.rb_Fish.Name = "rb_Fish";
            this.rb_Fish.Size = new System.Drawing.Size(48, 19);
            this.rb_Fish.TabIndex = 2;
            this.rb_Fish.Text = "Fish";
            this.rb_Fish.UseVisualStyleBackColor = true;
            // 
            // rb_Shark
            // 
            this.rb_Shark.AutoSize = true;
            this.rb_Shark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Shark.Location = new System.Drawing.Point(6, 45);
            this.rb_Shark.Name = "rb_Shark";
            this.rb_Shark.Size = new System.Drawing.Size(57, 19);
            this.rb_Shark.TabIndex = 1;
            this.rb_Shark.Text = "Shark";
            this.rb_Shark.UseVisualStyleBackColor = true;
            // 
            // rb_Dolphin
            // 
            this.rb_Dolphin.AutoSize = true;
            this.rb_Dolphin.Checked = true;
            this.rb_Dolphin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Dolphin.Location = new System.Drawing.Point(6, 20);
            this.rb_Dolphin.Name = "rb_Dolphin";
            this.rb_Dolphin.Size = new System.Drawing.Size(68, 19);
            this.rb_Dolphin.TabIndex = 0;
            this.rb_Dolphin.TabStop = true;
            this.rb_Dolphin.Text = "Dolphin";
            this.rb_Dolphin.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnStart.Location = new System.Drawing.Point(433, 188);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(327, 30);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start Race";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // betAnimal
            // 
            this.betAnimal.BackColor = System.Drawing.Color.White;
            this.betAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.betAnimal.Location = new System.Drawing.Point(387, 161);
            this.betAnimal.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.betAnimal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betAnimal.Name = "betAnimal";
            this.betAnimal.ReadOnly = true;
            this.betAnimal.Size = new System.Drawing.Size(40, 23);
            this.betAnimal.TabIndex = 11;
            this.betAnimal.Tag = "Animal";
            this.betAnimal.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "euro op nummer:";
            // 
            // betAmount
            // 
            this.betAmount.BackColor = System.Drawing.Color.White;
            this.betAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.betAmount.Location = new System.Drawing.Point(238, 161);
            this.betAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.ReadOnly = true;
            this.betAmount.Size = new System.Drawing.Size(35, 23);
            this.betAmount.TabIndex = 9;
            this.betAmount.Tag = "Euro";
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBet.Location = new System.Drawing.Point(10, 190);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(417, 28);
            this.btnBet.TabIndex = 8;
            this.btnBet.Text = "Wedt";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox3.Controls.Add(this.txtDescp3);
            this.groupBox3.Controls.Add(this.txtDescp1);
            this.groupBox3.Controls.Add(this.txtDescp2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(433, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 152);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Weddenschappen";
            // 
            // txtDescp3
            // 
            this.txtDescp3.BackColor = System.Drawing.Color.White;
            this.txtDescp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescp3.Location = new System.Drawing.Point(6, 107);
            this.txtDescp3.Name = "txtDescp3";
            this.txtDescp3.ReadOnly = true;
            this.txtDescp3.Size = new System.Drawing.Size(315, 21);
            this.txtDescp3.TabIndex = 14;
            this.txtDescp3.Text = "Allaith heeft geen weddenschap geplaatst";
            // 
            // txtDescp1
            // 
            this.txtDescp1.BackColor = System.Drawing.Color.White;
            this.txtDescp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescp1.Location = new System.Drawing.Point(6, 21);
            this.txtDescp1.Name = "txtDescp1";
            this.txtDescp1.ReadOnly = true;
            this.txtDescp1.Size = new System.Drawing.Size(315, 21);
            this.txtDescp1.TabIndex = 12;
            this.txtDescp1.Text = "Kevin heeft geen weddenschap geplaatst";
            // 
            // txtDescp2
            // 
            this.txtDescp2.BackColor = System.Drawing.Color.White;
            this.txtDescp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescp2.Location = new System.Drawing.Point(6, 63);
            this.txtDescp2.Name = "txtDescp2";
            this.txtDescp2.ReadOnly = true;
            this.txtDescp2.Size = new System.Drawing.Size(315, 21);
            this.txtDescp2.TabIndex = 13;
            this.txtDescp2.Text = "Pieter Jan heeft geen weddenschap geplaatst";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.ForeColor = System.Drawing.Color.White;
            this.lblNumber1.Location = new System.Drawing.Point(93, 18);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(25, 25);
            this.lblNumber1.TabIndex = 9;
            this.lblNumber1.Text = "1";
            this.lblNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.ForeColor = System.Drawing.Color.White;
            this.lblNumber2.Location = new System.Drawing.Point(93, 81);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(25, 25);
            this.lblNumber2.TabIndex = 10;
            this.lblNumber2.Text = "2";
            this.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber3
            // 
            this.lblNumber3.AutoSize = true;
            this.lblNumber3.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber3.ForeColor = System.Drawing.Color.White;
            this.lblNumber3.Location = new System.Drawing.Point(93, 148);
            this.lblNumber3.Name = "lblNumber3";
            this.lblNumber3.Size = new System.Drawing.Size(25, 25);
            this.lblNumber3.TabIndex = 11;
            this.lblNumber3.Text = "3";
            this.lblNumber3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber4
            // 
            this.lblNumber4.AutoSize = true;
            this.lblNumber4.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber4.ForeColor = System.Drawing.Color.White;
            this.lblNumber4.Location = new System.Drawing.Point(93, 228);
            this.lblNumber4.Name = "lblNumber4";
            this.lblNumber4.Size = new System.Drawing.Size(25, 25);
            this.lblNumber4.TabIndex = 12;
            this.lblNumber4.Text = "4";
            this.lblNumber4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAnimal4
            // 
            this.pbAnimal4.BackColor = System.Drawing.Color.Transparent;
            this.pbAnimal4.Image = global::DeGokkers.Properties.Resources.Dolphin;
            this.pbAnimal4.Location = new System.Drawing.Point(2, 214);
            this.pbAnimal4.Name = "pbAnimal4";
            this.pbAnimal4.Size = new System.Drawing.Size(85, 50);
            this.pbAnimal4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimal4.TabIndex = 4;
            this.pbAnimal4.TabStop = false;
            // 
            // pbAnimal3
            // 
            this.pbAnimal3.BackColor = System.Drawing.Color.Transparent;
            this.pbAnimal3.Image = global::DeGokkers.Properties.Resources.Dolphin;
            this.pbAnimal3.Location = new System.Drawing.Point(2, 135);
            this.pbAnimal3.Name = "pbAnimal3";
            this.pbAnimal3.Size = new System.Drawing.Size(85, 50);
            this.pbAnimal3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimal3.TabIndex = 3;
            this.pbAnimal3.TabStop = false;
            // 
            // pbAnimal2
            // 
            this.pbAnimal2.BackColor = System.Drawing.Color.Transparent;
            this.pbAnimal2.Image = global::DeGokkers.Properties.Resources.Dolphin;
            this.pbAnimal2.Location = new System.Drawing.Point(2, 64);
            this.pbAnimal2.Name = "pbAnimal2";
            this.pbAnimal2.Size = new System.Drawing.Size(85, 50);
            this.pbAnimal2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimal2.TabIndex = 2;
            this.pbAnimal2.TabStop = false;
            // 
            // pbAnimal1
            // 
            this.pbAnimal1.BackColor = System.Drawing.Color.Transparent;
            this.pbAnimal1.Image = global::DeGokkers.Properties.Resources.Dolphin;
            this.pbAnimal1.Location = new System.Drawing.Point(2, 4);
            this.pbAnimal1.Name = "pbAnimal1";
            this.pbAnimal1.Size = new System.Drawing.Size(85, 50);
            this.pbAnimal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimal1.TabIndex = 1;
            this.pbAnimal1.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBackground.Image = global::DeGokkers.Properties.Resources.ocean_lines;
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(773, 276);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(773, 522);
            this.Controls.Add(this.lblNumber4);
            this.Controls.Add(this.lblNumber3);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.pbAnimal4);
            this.Controls.Add(this.pbAnimal3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbAnimal2);
            this.Controls.Add(this.pbAnimal1);
            this.Controls.Add(this.pbBackground);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(789, 561);
            this.MinimumSize = new System.Drawing.Size(789, 561);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "De Gokkers";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbAnimal1;
        private System.Windows.Forms.PictureBox pbAnimal2;
        private System.Windows.Forms.PictureBox pbAnimal3;
        private System.Windows.Forms.PictureBox pbAnimal4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPlayer3;
        private System.Windows.Forms.RadioButton rbPlayer2;
        private System.Windows.Forms.RadioButton rbPlayer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.NumericUpDown betAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDescp3;
        private System.Windows.Forms.TextBox txtDescp1;
        private System.Windows.Forms.TextBox txtDescp2;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblNumber3;
        private System.Windows.Forms.Label lblNumber4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.RadioButton rb_Fish;
        private System.Windows.Forms.RadioButton rb_Shark;
        private System.Windows.Forms.RadioButton rb_Dolphin;
    }
}

