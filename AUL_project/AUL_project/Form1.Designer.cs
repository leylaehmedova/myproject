
namespace AUL_project
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.Btnlogin = new System.Windows.Forms.Button();
            this.Lbldont = new System.Windows.Forms.Label();
            this.Btnregher = new System.Windows.Forms.Button();
            this.LblUser = new System.Windows.Forms.Label();
            this.Txtbpass = new System.Windows.Forms.TextBox();
            this.Txtbusern = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pickey = new System.Windows.Forms.PictureBox();
            this.Picuser = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.auL_projectDataSet1 = new AUL_project.AUL_projectDataSet();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pickey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auL_projectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnlogin
            // 
            this.Btnlogin.BackColor = System.Drawing.Color.Tomato;
            this.Btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnlogin.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlogin.Location = new System.Drawing.Point(35, 305);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(439, 60);
            this.Btnlogin.TabIndex = 1;
            this.Btnlogin.Text = "Login";
            this.Btnlogin.UseVisualStyleBackColor = false;
            this.Btnlogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lbldont
            // 
            this.Lbldont.AutoSize = true;
            this.Lbldont.ForeColor = System.Drawing.SystemColors.Info;
            this.Lbldont.Location = new System.Drawing.Point(119, 590);
            this.Lbldont.Name = "Lbldont";
            this.Lbldont.Size = new System.Drawing.Size(177, 20);
            this.Lbldont.TabIndex = 9;
            this.Lbldont.Text = "Don\'t have an account?";
            // 
            // Btnregher
            // 
            this.Btnregher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnregher.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.Btnregher.ForeColor = System.Drawing.Color.Brown;
            this.Btnregher.Location = new System.Drawing.Point(315, 576);
            this.Btnregher.Name = "Btnregher";
            this.Btnregher.Size = new System.Drawing.Size(191, 47);
            this.Btnregher.TabIndex = 10;
            this.Btnregher.Text = "REGISTER HERE";
            this.Btnregher.UseVisualStyleBackColor = true;
            this.Btnregher.Click += new System.EventHandler(this.Btnregher_Click);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.BackColor = System.Drawing.Color.Brown;
            this.LblUser.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LblUser.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.White;
            this.LblUser.Location = new System.Drawing.Point(159, 24);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(197, 38);
            this.LblUser.TabIndex = 11;
            this.LblUser.Text = "USER LOGIN";
            this.LblUser.Click += new System.EventHandler(this.LblUser_Click);
            // 
            // Txtbpass
            // 
            this.Txtbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbpass.ForeColor = System.Drawing.Color.Gray;
            this.Txtbpass.Location = new System.Drawing.Point(83, 180);
            this.Txtbpass.Multiline = true;
            this.Txtbpass.Name = "Txtbpass";
            this.Txtbpass.PasswordChar = '*';
            this.Txtbpass.Size = new System.Drawing.Size(382, 50);
            this.Txtbpass.TabIndex = 4;
            this.Txtbpass.Text = "Password";
            this.Txtbpass.Click += new System.EventHandler(this.Txtbpass_Click);
            this.Txtbpass.TextChanged += new System.EventHandler(this.Txtbpass_TextChanged);
            // 
            // Txtbusern
            // 
            this.Txtbusern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbusern.ForeColor = System.Drawing.Color.Gray;
            this.Txtbusern.Location = new System.Drawing.Point(83, 99);
            this.Txtbusern.Multiline = true;
            this.Txtbusern.Name = "Txtbusern";
            this.Txtbusern.Size = new System.Drawing.Size(384, 51);
            this.Txtbusern.TabIndex = 3;
            this.Txtbusern.Text = "Username";
            this.Txtbusern.Click += new System.EventHandler(this.Txtbusern_Click);
            this.Txtbusern.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txtbusern_MouseClick);
            this.Txtbusern.TextChanged += new System.EventHandler(this.Txtbusern_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LblUser);
            this.panel1.Controls.Add(this.Pickey);
            this.panel1.Controls.Add(this.Picuser);
            this.panel1.Controls.Add(this.Txtbusern);
            this.panel1.Controls.Add(this.Btnlogin);
            this.panel1.Controls.Add(this.Txtbpass);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(55, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 409);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Brown;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(324, 237);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 24);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Forgot Password?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Pickey
            // 
            this.Pickey.Image = ((System.Drawing.Image)(resources.GetObject("Pickey.Image")));
            this.Pickey.Location = new System.Drawing.Point(35, 182);
            this.Pickey.Name = "Pickey";
            this.Pickey.Size = new System.Drawing.Size(51, 50);
            this.Pickey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pickey.TabIndex = 19;
            this.Pickey.TabStop = false;
            // 
            // Picuser
            // 
            this.Picuser.Image = ((System.Drawing.Image)(resources.GetObject("Picuser.Image")));
            this.Picuser.Location = new System.Drawing.Point(35, 100);
            this.Picuser.Name = "Picuser";
            this.Picuser.Size = new System.Drawing.Size(49, 51);
            this.Picuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picuser.TabIndex = 18;
            this.Picuser.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(642, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 50);
            this.label1.TabIndex = 20;
            this.label1.Text = "Encryption and Decryption";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(753, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 50);
            this.label2.TabIndex = 23;
            this.label2.Text = "WELCOME...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // auL_projectDataSet1
            // 
            this.auL_projectDataSet1.DataSetName = "AUL_projectDataSet";
            this.auL_projectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(841, 576);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 88);
            this.button7.TabIndex = 34;
            this.button7.Text = ".";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(716, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AUL_project.Properties.Resources._3d_perspective_style_diamond_shape_white_background_1017_27556;
            this.pictureBox2.Location = new System.Drawing.Point(618, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(569, 711);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 702);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnregher);
            this.Controls.Add(this.Lbldont);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pickey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auL_projectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btnlogin;
        private System.Windows.Forms.Label Lbldont;
        private System.Windows.Forms.Button Btnregher;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox Txtbpass;
        private System.Windows.Forms.TextBox Txtbusern;
        private System.Windows.Forms.PictureBox Picuser;
        private System.Windows.Forms.PictureBox Pickey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private AUL_projectDataSet auL_projectDataSet1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

