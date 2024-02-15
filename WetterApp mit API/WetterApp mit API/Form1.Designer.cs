namespace WetterApp_mit_API
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCond = new System.Windows.Forms.Label();
            this.lbldetails = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbltemp = new System.Windows.Forms.Label();
            this.lbltempmin = new System.Windows.Forms.Label();
            this.lbltempmax = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblpre = new System.Windows.Forms.Label();
            this.lblhumid = new System.Windows.Forms.Label();
            this.lblspeed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(447, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(77, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 50);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Enter Your Country";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 31);
            this.label5.TabIndex = 6;
            // 
            // lblCond
            // 
            this.lblCond.AutoSize = true;
            this.lblCond.BackColor = System.Drawing.Color.Transparent;
            this.lblCond.Location = new System.Drawing.Point(46, 120);
            this.lblCond.Name = "lblCond";
            this.lblCond.Size = new System.Drawing.Size(51, 13);
            this.lblCond.TabIndex = 11;
            this.lblCond.Text = "Condition";
            // 
            // lbldetails
            // 
            this.lbldetails.AutoSize = true;
            this.lbldetails.BackColor = System.Drawing.Color.Transparent;
            this.lbldetails.Location = new System.Drawing.Point(46, 151);
            this.lbldetails.Name = "lbldetails";
            this.lbldetails.Size = new System.Drawing.Size(39, 13);
            this.lbldetails.TabIndex = 12;
            this.lbldetails.Text = "Details";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.BackColor = System.Drawing.Color.Transparent;
            this.lbl10.Location = new System.Drawing.Point(66, 238);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(64, 13);
            this.lbl10.TabIndex = 13;
            this.lbl10.Text = "Temperatur:";
            // 
            // lbltemp
            // 
            this.lbltemp.AutoSize = true;
            this.lbltemp.BackColor = System.Drawing.Color.Transparent;
            this.lbltemp.Location = new System.Drawing.Point(136, 238);
            this.lbltemp.Name = "lbltemp";
            this.lbltemp.Size = new System.Drawing.Size(27, 13);
            this.lbltemp.TabIndex = 14;
            this.lbltemp.Text = "N/A";
            // 
            // lbltempmin
            // 
            this.lbltempmin.AutoSize = true;
            this.lbltempmin.BackColor = System.Drawing.Color.Transparent;
            this.lbltempmin.Location = new System.Drawing.Point(136, 266);
            this.lbltempmin.Name = "lbltempmin";
            this.lbltempmin.Size = new System.Drawing.Size(27, 13);
            this.lbltempmin.TabIndex = 15;
            this.lbltempmin.Text = "N/A";
            // 
            // lbltempmax
            // 
            this.lbltempmax.AutoSize = true;
            this.lbltempmax.BackColor = System.Drawing.Color.Transparent;
            this.lbltempmax.Location = new System.Drawing.Point(136, 294);
            this.lbltempmax.Name = "lbltempmax";
            this.lbltempmax.Size = new System.Drawing.Size(27, 13);
            this.lbltempmax.TabIndex = 16;
            this.lbltempmax.Text = "N/A";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.BackColor = System.Drawing.Color.Transparent;
            this.lbl11.Location = new System.Drawing.Point(46, 266);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(84, 13);
            this.lbl11.TabIndex = 17;
            this.lbl11.Text = "Min Temperatur:";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.BackColor = System.Drawing.Color.Transparent;
            this.lbl12.Location = new System.Drawing.Point(46, 294);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(87, 13);
            this.lbl12.TabIndex = 18;
            this.lbl12.Text = "Max Temperatur:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Temperatur:";
            // 
            // lblpre
            // 
            this.lblpre.AutoSize = true;
            this.lblpre.BackColor = System.Drawing.Color.Transparent;
            this.lblpre.Location = new System.Drawing.Point(376, 238);
            this.lblpre.Name = "lblpre";
            this.lblpre.Size = new System.Drawing.Size(27, 13);
            this.lblpre.TabIndex = 20;
            this.lblpre.Text = "N/A";
            // 
            // lblhumid
            // 
            this.lblhumid.AutoSize = true;
            this.lblhumid.BackColor = System.Drawing.Color.Transparent;
            this.lblhumid.Location = new System.Drawing.Point(377, 266);
            this.lblhumid.Name = "lblhumid";
            this.lblhumid.Size = new System.Drawing.Size(27, 13);
            this.lblhumid.TabIndex = 21;
            this.lblhumid.Text = "N/A";
            // 
            // lblspeed
            // 
            this.lblspeed.AutoSize = true;
            this.lblspeed.BackColor = System.Drawing.Color.Transparent;
            this.lblspeed.Location = new System.Drawing.Point(377, 294);
            this.lblspeed.Name = "lblspeed";
            this.lblspeed.Size = new System.Drawing.Size(27, 13);
            this.lblspeed.TabIndex = 22;
            this.lblspeed.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(320, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Pressure:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(321, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Humidity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(330, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Speed:";
            // 
            // picicon
            // 
            this.picicon.BackColor = System.Drawing.Color.Transparent;
            this.picicon.Location = new System.Drawing.Point(323, 104);
            this.picicon.Name = "picicon";
            this.picicon.Size = new System.Drawing.Size(112, 98);
            this.picicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picicon.TabIndex = 27;
            this.picicon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 357);
            this.Controls.Add(this.picicon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblspeed);
            this.Controls.Add(this.lblhumid);
            this.Controls.Add(this.lblpre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.lbltempmax);
            this.Controls.Add(this.lbltempmin);
            this.Controls.Add(this.lbltemp);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbldetails);
            this.Controls.Add(this.lblCond);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCond;
        private System.Windows.Forms.Label lbldetails;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbltemp;
        private System.Windows.Forms.Label lbltempmin;
        private System.Windows.Forms.Label lbltempmax;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblpre;
        private System.Windows.Forms.Label lblhumid;
        private System.Windows.Forms.Label lblspeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picicon;
    }
}

