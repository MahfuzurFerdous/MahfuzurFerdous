namespace MusicalIntrumentStoreManagementProject
{
    partial class Profile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usr = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.okPass = new System.Windows.Forms.Button();
            this.usrName = new System.Windows.Forms.TextBox();
            this.usrPhn = new System.Windows.Forms.TextBox();
            this.chngUsrPass = new System.Windows.Forms.TextBox();
            this.usrPass = new System.Windows.Forms.TextBox();
            this.usrId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 603);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.usr);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.okPass);
            this.panel2.Controls.Add(this.usrName);
            this.panel2.Controls.Add(this.usrPhn);
            this.panel2.Controls.Add(this.chngUsrPass);
            this.panel2.Controls.Add(this.usrPass);
            this.panel2.Controls.Add(this.usrId);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(-6, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 554);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // usr
            // 
            this.usr.AutoSize = true;
            this.usr.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr.Location = new System.Drawing.Point(285, 20);
            this.usr.Name = "usr";
            this.usr.Size = new System.Drawing.Size(96, 38);
            this.usr.TabIndex = 16;
            this.usr.Text = "Hello";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkRed;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit.Location = new System.Drawing.Point(634, 474);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(145, 58);
            this.exit.TabIndex = 15;
            this.exit.Text = "Close";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // okPass
            // 
            this.okPass.BackColor = System.Drawing.Color.DarkGreen;
            this.okPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.okPass.Location = new System.Drawing.Point(716, 335);
            this.okPass.Name = "okPass";
            this.okPass.Size = new System.Drawing.Size(75, 30);
            this.okPass.TabIndex = 14;
            this.okPass.Text = "Change";
            this.okPass.UseVisualStyleBackColor = false;
            this.okPass.Click += new System.EventHandler(this.okPass_Click);
            // 
            // usrName
            // 
            this.usrName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usrName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrName.Location = new System.Drawing.Point(209, 186);
            this.usrName.Name = "usrName";
            this.usrName.ReadOnly = true;
            this.usrName.Size = new System.Drawing.Size(494, 23);
            this.usrName.TabIndex = 12;
            // 
            // usrPhn
            // 
            this.usrPhn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usrPhn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrPhn.Location = new System.Drawing.Point(209, 233);
            this.usrPhn.Name = "usrPhn";
            this.usrPhn.ReadOnly = true;
            this.usrPhn.Size = new System.Drawing.Size(494, 23);
            this.usrPhn.TabIndex = 11;
            // 
            // chngUsrPass
            // 
            this.chngUsrPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chngUsrPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chngUsrPass.Location = new System.Drawing.Point(209, 335);
            this.chngUsrPass.Name = "chngUsrPass";
            this.chngUsrPass.Size = new System.Drawing.Size(494, 23);
            this.chngUsrPass.TabIndex = 9;
            // 
            // usrPass
            // 
            this.usrPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usrPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrPass.Location = new System.Drawing.Point(209, 283);
            this.usrPass.Name = "usrPass";
            this.usrPass.ReadOnly = true;
            this.usrPass.Size = new System.Drawing.Size(494, 23);
            this.usrPass.TabIndex = 7;
            // 
            // usrId
            // 
            this.usrId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usrId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrId.Location = new System.Drawing.Point(209, 132);
            this.usrId.Name = "usrId";
            this.usrId.ReadOnly = true;
            this.usrId.Size = new System.Drawing.Size(494, 23);
            this.usrId.TabIndex = 6;
            this.usrId.TextChanged += new System.EventHandler(this.usrId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone no:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Change Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 603);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Profile";
            this.Text = "profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okPass;
        private System.Windows.Forms.TextBox usrName;
        private System.Windows.Forms.TextBox usrPhn;
        private System.Windows.Forms.TextBox chngUsrPass;
        private System.Windows.Forms.TextBox usrPass;
        private System.Windows.Forms.TextBox usrId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label usr;
    }
}