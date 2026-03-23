
namespace fruit_machineV1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblreel1 = new System.Windows.Forms.Label();
            this.lblreel3 = new System.Windows.Forms.Label();
            this.lblreel2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblpound = new System.Windows.Forms.Button();
            this.lblfifty = new System.Windows.Forms.Button();
            this.lblten = new System.Windows.Forms.Button();
            this.lbltwenty = new System.Windows.Forms.Button();
            this.lblspin = new System.Windows.Forms.Button();
            this.lblbank = new System.Windows.Forms.Label();
            this.lblcredit = new System.Windows.Forms.Label();
            this.lblout = new System.Windows.Forms.Label();
            this.lbllogo1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbllogo2 = new System.Windows.Forms.Label();
            this.lbllogo4 = new System.Windows.Forms.Label();
            this.lbllogo3 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltext = new System.Windows.Forms.RichTextBox();
            this.btnhold1 = new System.Windows.Forms.Button();
            this.btnhold3 = new System.Windows.Forms.Button();
            this.btnhold2 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.saveinfo = new System.Windows.Forms.Button();
            this.openinfo = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.lblflashone = new System.Windows.Forms.Label();
            this.lblflashtwo = new System.Windows.Forms.Label();
            this.lblflashthree = new System.Windows.Forms.Label();
            this.lblflashfour = new System.Windows.Forms.Label();
            this.lblflashfive = new System.Windows.Forms.Label();
            this.lblflashsix = new System.Windows.Forms.Label();
            this.lblflashseven = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblreel1
            // 
            this.lblreel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblreel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblreel1.Image = global::fruit_machineV1.Properties.Resources.happy;
            this.lblreel1.Location = new System.Drawing.Point(12, 110);
            this.lblreel1.Name = "lblreel1";
            this.lblreel1.Size = new System.Drawing.Size(129, 86);
            this.lblreel1.TabIndex = 0;
            this.lblreel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblreel3
            // 
            this.lblreel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblreel3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblreel3.Image = global::fruit_machineV1.Properties.Resources.happy;
            this.lblreel3.Location = new System.Drawing.Point(282, 110);
            this.lblreel3.Name = "lblreel3";
            this.lblreel3.Size = new System.Drawing.Size(129, 86);
            this.lblreel3.TabIndex = 1;
            this.lblreel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblreel2
            // 
            this.lblreel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblreel2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblreel2.Image = global::fruit_machineV1.Properties.Resources.happy;
            this.lblreel2.Location = new System.Drawing.Point(147, 110);
            this.lblreel2.Name = "lblreel2";
            this.lblreel2.Size = new System.Drawing.Size(129, 86);
            this.lblreel2.TabIndex = 2;
            this.lblreel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblpound
            // 
            this.lblpound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblpound.Location = new System.Drawing.Point(252, 369);
            this.lblpound.Name = "lblpound";
            this.lblpound.Size = new System.Drawing.Size(114, 46);
            this.lblpound.TabIndex = 3;
            this.lblpound.Text = "£1";
            this.lblpound.UseVisualStyleBackColor = false;
            this.lblpound.Click += new System.EventHandler(this.lblpound_Click);
            // 
            // lblfifty
            // 
            this.lblfifty.BackColor = System.Drawing.Color.Teal;
            this.lblfifty.Location = new System.Drawing.Point(132, 369);
            this.lblfifty.Name = "lblfifty";
            this.lblfifty.Size = new System.Drawing.Size(114, 46);
            this.lblfifty.TabIndex = 4;
            this.lblfifty.Text = "50p";
            this.lblfifty.UseVisualStyleBackColor = false;
            this.lblfifty.Click += new System.EventHandler(this.lblfifty_Click);
            // 
            // lblten
            // 
            this.lblten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblten.Location = new System.Drawing.Point(132, 317);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(114, 46);
            this.lblten.TabIndex = 5;
            this.lblten.Text = "10p";
            this.lblten.UseVisualStyleBackColor = false;
            this.lblten.Click += new System.EventHandler(this.lblten_Click);
            // 
            // lbltwenty
            // 
            this.lbltwenty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbltwenty.Location = new System.Drawing.Point(252, 317);
            this.lbltwenty.Name = "lbltwenty";
            this.lbltwenty.Size = new System.Drawing.Size(114, 46);
            this.lbltwenty.TabIndex = 6;
            this.lbltwenty.Text = "20p";
            this.lbltwenty.UseVisualStyleBackColor = false;
            this.lbltwenty.Click += new System.EventHandler(this.lbltwenty_Click);
            // 
            // lblspin
            // 
            this.lblspin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblspin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblspin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblspin.Location = new System.Drawing.Point(12, 317);
            this.lblspin.Name = "lblspin";
            this.lblspin.Size = new System.Drawing.Size(114, 98);
            this.lblspin.TabIndex = 7;
            this.lblspin.Text = "Spin";
            this.lblspin.UseVisualStyleBackColor = false;
            this.lblspin.Click += new System.EventHandler(this.lblspin_Click);
            // 
            // lblbank
            // 
            this.lblbank.BackColor = System.Drawing.Color.Gold;
            this.lblbank.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblbank.Location = new System.Drawing.Point(417, 110);
            this.lblbank.Name = "lblbank";
            this.lblbank.Size = new System.Drawing.Size(114, 57);
            this.lblbank.TabIndex = 8;
            this.lblbank.Text = "bank";
            this.lblbank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcredit
            // 
            this.lblcredit.BackColor = System.Drawing.Color.Gold;
            this.lblcredit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcredit.Location = new System.Drawing.Point(417, 180);
            this.lblcredit.Name = "lblcredit";
            this.lblcredit.Size = new System.Drawing.Size(114, 57);
            this.lblcredit.TabIndex = 9;
            this.lblcredit.Text = "credit";
            this.lblcredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblout
            // 
            this.lblout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblout.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblout.Location = new System.Drawing.Point(12, 431);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(272, 78);
            this.lblout.TabIndex = 10;
            this.lblout.Text = "Winnings Output";
            this.lblout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbllogo1
            // 
            this.lbllogo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbllogo1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbllogo1.Location = new System.Drawing.Point(12, 30);
            this.lbllogo1.Name = "lbllogo1";
            this.lbllogo1.Size = new System.Drawing.Size(54, 48);
            this.lbllogo1.TabIndex = 11;
            this.lbllogo1.Text = "S";
            this.lbllogo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbllogo2
            // 
            this.lbllogo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbllogo2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbllogo2.Location = new System.Drawing.Point(72, 30);
            this.lbllogo2.Name = "lbllogo2";
            this.lbllogo2.Size = new System.Drawing.Size(54, 48);
            this.lbllogo2.TabIndex = 12;
            this.lbllogo2.Text = "L";
            this.lbllogo2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbllogo4
            // 
            this.lbllogo4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbllogo4.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbllogo4.Location = new System.Drawing.Point(192, 30);
            this.lbllogo4.Name = "lbllogo4";
            this.lbllogo4.Size = new System.Drawing.Size(54, 48);
            this.lbllogo4.TabIndex = 13;
            this.lbllogo4.Text = "T";
            this.lbllogo4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbllogo3
            // 
            this.lbllogo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbllogo3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbllogo3.Location = new System.Drawing.Point(132, 30);
            this.lbllogo3.Name = "lbllogo3";
            this.lbllogo3.Size = new System.Drawing.Size(54, 48);
            this.lbllogo3.TabIndex = 14;
            this.lbllogo3.Text = "O";
            this.lbllogo3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbldate
            // 
            this.lbldate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbldate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldate.Location = new System.Drawing.Point(252, 30);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(345, 48);
            this.lbldate.TabIndex = 15;
            this.lbldate.Text = "Date and Time";
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltext
            // 
            this.lbltext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltext.Location = new System.Drawing.Point(537, 95);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(269, 385);
            this.lbltext.TabIndex = 16;
            this.lbltext.Text = "";
            // 
            // btnhold1
            // 
            this.btnhold1.BackColor = System.Drawing.Color.Pink;
            this.btnhold1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnhold1.Location = new System.Drawing.Point(12, 202);
            this.btnhold1.Name = "btnhold1";
            this.btnhold1.Size = new System.Drawing.Size(129, 86);
            this.btnhold1.TabIndex = 17;
            this.btnhold1.Text = "Hold1";
            this.btnhold1.UseVisualStyleBackColor = false;
            this.btnhold1.Click += new System.EventHandler(this.btnhold1_Click);
            // 
            // btnhold3
            // 
            this.btnhold3.BackColor = System.Drawing.Color.Pink;
            this.btnhold3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnhold3.Location = new System.Drawing.Point(282, 202);
            this.btnhold3.Name = "btnhold3";
            this.btnhold3.Size = new System.Drawing.Size(129, 86);
            this.btnhold3.TabIndex = 18;
            this.btnhold3.Text = "Hold3";
            this.btnhold3.UseVisualStyleBackColor = false;
            this.btnhold3.Click += new System.EventHandler(this.btnhold3_Click);
            // 
            // btnhold2
            // 
            this.btnhold2.BackColor = System.Drawing.Color.Pink;
            this.btnhold2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnhold2.Location = new System.Drawing.Point(147, 202);
            this.btnhold2.Name = "btnhold2";
            this.btnhold2.Size = new System.Drawing.Size(129, 86);
            this.btnhold2.TabIndex = 19;
            this.btnhold2.Text = "Hold2";
            this.btnhold2.UseVisualStyleBackColor = false;
            this.btnhold2.Click += new System.EventHandler(this.hold2_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // saveinfo
            // 
            this.saveinfo.BackColor = System.Drawing.Color.Blue;
            this.saveinfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveinfo.Location = new System.Drawing.Point(290, 431);
            this.saveinfo.Name = "saveinfo";
            this.saveinfo.Size = new System.Drawing.Size(95, 36);
            this.saveinfo.TabIndex = 20;
            this.saveinfo.Text = "SaveInfo";
            this.saveinfo.UseVisualStyleBackColor = false;
            this.saveinfo.Click += new System.EventHandler(this.saveinfo_Click);
            // 
            // openinfo
            // 
            this.openinfo.BackColor = System.Drawing.Color.Blue;
            this.openinfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openinfo.Location = new System.Drawing.Point(290, 473);
            this.openinfo.Name = "openinfo";
            this.openinfo.Size = new System.Drawing.Size(95, 36);
            this.openinfo.TabIndex = 21;
            this.openinfo.Text = "OpenInfo";
            this.openinfo.UseVisualStyleBackColor = false;
            this.openinfo.Click += new System.EventHandler(this.openinfo_Click);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // lblflashone
            // 
            this.lblflashone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblflashone.Location = new System.Drawing.Point(922, 359);
            this.lblflashone.Name = "lblflashone";
            this.lblflashone.Size = new System.Drawing.Size(165, 36);
            this.lblflashone.TabIndex = 22;
            // 
            // lblflashtwo
            // 
            this.lblflashtwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblflashtwo.Location = new System.Drawing.Point(922, 304);
            this.lblflashtwo.Name = "lblflashtwo";
            this.lblflashtwo.Size = new System.Drawing.Size(165, 36);
            this.lblflashtwo.TabIndex = 23;
            // 
            // lblflashthree
            // 
            this.lblflashthree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblflashthree.Location = new System.Drawing.Point(922, 252);
            this.lblflashthree.Name = "lblflashthree";
            this.lblflashthree.Size = new System.Drawing.Size(165, 36);
            this.lblflashthree.TabIndex = 24;
            // 
            // lblflashfour
            // 
            this.lblflashfour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblflashfour.Location = new System.Drawing.Point(922, 201);
            this.lblflashfour.Name = "lblflashfour";
            this.lblflashfour.Size = new System.Drawing.Size(165, 36);
            this.lblflashfour.TabIndex = 25;
            this.lblflashfour.Text = "TARGET";
            this.lblflashfour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblflashfive
            // 
            this.lblflashfive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblflashfive.Location = new System.Drawing.Point(922, 148);
            this.lblflashfive.Name = "lblflashfive";
            this.lblflashfive.Size = new System.Drawing.Size(165, 36);
            this.lblflashfive.TabIndex = 26;
            // 
            // lblflashsix
            // 
            this.lblflashsix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblflashsix.Location = new System.Drawing.Point(922, 101);
            this.lblflashsix.Name = "lblflashsix";
            this.lblflashsix.Size = new System.Drawing.Size(165, 36);
            this.lblflashsix.TabIndex = 27;
            // 
            // lblflashseven
            // 
            this.lblflashseven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblflashseven.Location = new System.Drawing.Point(922, 52);
            this.lblflashseven.Name = "lblflashseven";
            this.lblflashseven.Size = new System.Drawing.Size(165, 36);
            this.lblflashseven.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(933, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 51);
            this.button1.TabIndex = 29;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1182, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblflashseven);
            this.Controls.Add(this.lblflashsix);
            this.Controls.Add(this.lblflashfive);
            this.Controls.Add(this.lblflashfour);
            this.Controls.Add(this.lblflashthree);
            this.Controls.Add(this.lblflashtwo);
            this.Controls.Add(this.lblflashone);
            this.Controls.Add(this.openinfo);
            this.Controls.Add(this.saveinfo);
            this.Controls.Add(this.btnhold2);
            this.Controls.Add(this.btnhold3);
            this.Controls.Add(this.btnhold1);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lbllogo3);
            this.Controls.Add(this.lbllogo4);
            this.Controls.Add(this.lbllogo2);
            this.Controls.Add(this.lbllogo1);
            this.Controls.Add(this.lblout);
            this.Controls.Add(this.lblcredit);
            this.Controls.Add(this.lblbank);
            this.Controls.Add(this.lblspin);
            this.Controls.Add(this.lbltwenty);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.lblfifty);
            this.Controls.Add(this.lblpound);
            this.Controls.Add(this.lblreel2);
            this.Controls.Add(this.lblreel3);
            this.Controls.Add(this.lblreel1);
            this.Name = "Form1";
            this.Text = "Slot Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblreel1;
        private System.Windows.Forms.Label lblreel3;
        private System.Windows.Forms.Label lblreel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button lblpound;
        private System.Windows.Forms.Button lblfifty;
        private System.Windows.Forms.Button lblten;
        private System.Windows.Forms.Button lbltwenty;
        private System.Windows.Forms.Button lblspin;
        private System.Windows.Forms.Label lblbank;
        private System.Windows.Forms.Label lblcredit;
        private System.Windows.Forms.Label lblout;
        private System.Windows.Forms.Label lbllogo1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbllogo2;
        private System.Windows.Forms.Label lbllogo4;
        private System.Windows.Forms.Label lbllogo3;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.RichTextBox lbltext;
        private System.Windows.Forms.Button btnhold1;
        private System.Windows.Forms.Button btnhold3;
        private System.Windows.Forms.Button btnhold2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button saveinfo;
        private System.Windows.Forms.Button openinfo;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label lblflashone;
        private System.Windows.Forms.Label lblflashtwo;
        private System.Windows.Forms.Label lblflashthree;
        private System.Windows.Forms.Label lblflashfour;
        private System.Windows.Forms.Label lblflashfive;
        private System.Windows.Forms.Label lblflashsix;
        private System.Windows.Forms.Label lblflashseven;
        private System.Windows.Forms.Button button1;
    }
}

