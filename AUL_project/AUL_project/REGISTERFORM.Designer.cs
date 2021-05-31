
using System;

namespace AUL_project
{
    partial class REGISTERFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTERFORM));
            this.btnreg = new System.Windows.Forms.Button();
            this.lblregform = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbfirst = new System.Windows.Forms.TextBox();
            this.txtpassw = new System.Windows.Forms.TextBox();
            this.txtbemail = new System.Windows.Forms.TextBox();
            this.txtblast = new System.Windows.Forms.TextBox();
            this.txtbcon = new System.Windows.Forms.TextBox();
            this.rEGİstERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEGİstERDataSet1 = new AUL_project.REGİstERDataSet1();
            this.txtbuser = new System.Windows.Forms.TextBox();
            this.lblalready = new System.Windows.Forms.Label();
            this.rEGİstERTableAdapter = new AUL_project.REGİstERDataSet1TableAdapters.REGİstERTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.RBml = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.RBfml = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.rEGİstERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGİstERDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBml)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnreg
            // 
            this.btnreg.BackColor = System.Drawing.Color.Tomato;
            this.btnreg.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreg.Location = new System.Drawing.Point(632, 537);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(434, 62);
            this.btnreg.TabIndex = 1;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = false;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // lblregform
            // 
            this.lblregform.AutoSize = true;
            this.lblregform.BackColor = System.Drawing.Color.White;
            this.lblregform.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregform.Location = new System.Drawing.Point(664, 58);
            this.lblregform.Name = "lblregform";
            this.lblregform.Size = new System.Drawing.Size(383, 44);
            this.lblregform.TabIndex = 3;
            this.lblregform.Text = "REGISTRATION FORM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(894, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // txtbfirst
            // 
            this.txtbfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbfirst.Location = new System.Drawing.Point(633, 127);
            this.txtbfirst.Multiline = true;
            this.txtbfirst.Name = "txtbfirst";
            this.txtbfirst.Size = new System.Drawing.Size(206, 39);
            this.txtbfirst.TabIndex = 9;
            this.txtbfirst.Text = "First name";
            this.txtbfirst.Click += new System.EventHandler(this.txtbfirst_Click);
            // 
            // txtpassw
            // 
            this.txtpassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassw.Location = new System.Drawing.Point(632, 330);
            this.txtpassw.Multiline = true;
            this.txtpassw.Name = "txtpassw";
            this.txtpassw.PasswordChar = '*';
            this.txtpassw.Size = new System.Drawing.Size(434, 38);
            this.txtpassw.TabIndex = 10;
            this.txtpassw.Text = "Password";
            this.txtpassw.Click += new System.EventHandler(this.txtpassw_Click);
            this.txtpassw.TextChanged += new System.EventHandler(this.txtpassw_TextChanged);
            // 
            // txtbemail
            // 
            this.txtbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbemail.Location = new System.Drawing.Point(632, 263);
            this.txtbemail.Multiline = true;
            this.txtbemail.Name = "txtbemail";
            this.txtbemail.Size = new System.Drawing.Size(434, 38);
            this.txtbemail.TabIndex = 11;
            this.txtbemail.Text = "E-mail";
            this.txtbemail.Click += new System.EventHandler(this.txtbemail_Click);
            // 
            // txtblast
            // 
            this.txtblast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtblast.Location = new System.Drawing.Point(845, 127);
            this.txtblast.Multiline = true;
            this.txtblast.Name = "txtblast";
            this.txtblast.Size = new System.Drawing.Size(221, 39);
            this.txtblast.TabIndex = 12;
            this.txtblast.Text = "Last name";
            this.txtblast.Click += new System.EventHandler(this.txtblast_Click);
            this.txtblast.TextChanged += new System.EventHandler(this.txtblast_TextChanged);
            // 
            // txtbcon
            // 
            this.txtbcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbcon.Location = new System.Drawing.Point(633, 401);
            this.txtbcon.Multiline = true;
            this.txtbcon.Name = "txtbcon";
            this.txtbcon.PasswordChar = '*';
            this.txtbcon.Size = new System.Drawing.Size(434, 41);
            this.txtbcon.TabIndex = 13;
            this.txtbcon.Text = "Confirm password";
            this.txtbcon.Click += new System.EventHandler(this.txtbcon_Click);
            this.txtbcon.TextChanged += new System.EventHandler(this.txtbcon_TextChanged);
            // 
            // rEGİstERBindingSource
            // 
            this.rEGİstERBindingSource.DataMember = "REGİstER";
            this.rEGİstERBindingSource.DataSource = this.rEGİstERDataSet1;
            // 
            // rEGİstERDataSet1
            // 
            this.rEGİstERDataSet1.DataSetName = "REGİstERDataSet1";
            this.rEGİstERDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbuser
            // 
            this.txtbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuser.Location = new System.Drawing.Point(632, 196);
            this.txtbuser.Multiline = true;
            this.txtbuser.Name = "txtbuser";
            this.txtbuser.Size = new System.Drawing.Size(434, 39);
            this.txtbuser.TabIndex = 17;
            this.txtbuser.Text = "Username";
            this.txtbuser.Click += new System.EventHandler(this.txtbuser_Click);
            // 
            // lblalready
            // 
            this.lblalready.AutoSize = true;
            this.lblalready.BackColor = System.Drawing.Color.White;
            this.lblalready.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalready.Location = new System.Drawing.Point(691, 620);
            this.lblalready.Name = "lblalready";
            this.lblalready.Size = new System.Drawing.Size(174, 20);
            this.lblalready.TabIndex = 19;
            this.lblalready.Text = "I am already registered:";
            // 
            // rEGİstERTableAdapter
            // 
            this.rEGİstERTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.button1.Location = new System.Drawing.Point(882, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Login Here";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RBml
            // 
            this.RBml.Image = global::AUL_project.Properties.Resources.crystal_absolute_white;
            this.RBml.Location = new System.Drawing.Point(569, 12);
            this.RBml.Name = "RBml";
            this.RBml.Size = new System.Drawing.Size(562, 646);
            this.RBml.TabIndex = 22;
            this.RBml.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AUL_project.Properties.Resources.images;
            this.pictureBox4.Location = new System.Drawing.Point(1025, 332);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Brown;
            this.pictureBox6.Image = global::AUL_project.Properties.Resources.indir;
            this.pictureBox6.Location = new System.Drawing.Point(1026, 265);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(123, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 76);
            this.label1.TabIndex = 27;
            this.label1.Text = "SIGN UP :)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::AUL_project.Properties.Resources._62667_red_user_icon_images;
            this.pictureBox3.Location = new System.Drawing.Point(1024, 199);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AUL_project.Properties.Resources.BLMN;
            this.pictureBox1.Location = new System.Drawing.Point(1026, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(25, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 62);
            this.button3.TabIndex = 30;
            this.button3.Text = ".";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RBfml
            // 
            this.RBfml.AutoSize = true;
            this.RBfml.BackColor = System.Drawing.Color.White;
            this.RBfml.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBfml.ForeColor = System.Drawing.Color.Maroon;
            this.RBfml.Location = new System.Drawing.Point(729, 472);
            this.RBfml.Name = "RBfml";
            this.RBfml.Size = new System.Drawing.Size(110, 30);
            this.RBfml.TabIndex = 31;
            this.RBfml.TabStop = true;
            this.RBfml.Text = "Female";
            this.RBfml.UseVisualStyleBackColor = false;
            this.RBfml.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.White;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Maroon;
            this.radioButton2.Location = new System.Drawing.Point(907, 472);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 30);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Male";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(997, 339);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(997, 410);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(22, 21);
            this.checkBox2.TabIndex = 34;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // REGISTERFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1155, 734);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.RBfml);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblalready);
            this.Controls.Add(this.txtbuser);
            this.Controls.Add(this.txtbcon);
            this.Controls.Add(this.txtblast);
            this.Controls.Add(this.txtbemail);
            this.Controls.Add(this.txtpassw);
            this.Controls.Add(this.txtbfirst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblregform);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.RBml);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "REGISTERFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTERFORM";
            this.Load += new System.EventHandler(this.REGISTERFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rEGİstERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGİstERDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBml)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cmbgen_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Label lblregform;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbfirst;
        private System.Windows.Forms.TextBox txtpassw;
        private System.Windows.Forms.TextBox txtbemail;
        private System.Windows.Forms.TextBox txtblast;
        private System.Windows.Forms.TextBox txtbcon;
        private System.Windows.Forms.TextBox txtbuser;
        private System.Windows.Forms.Label lblalready;
        private REGİstERDataSet1 rEGİstERDataSet1;
        private System.Windows.Forms.BindingSource rEGİstERBindingSource;
        private REGİstERDataSet1TableAdapters.REGİstERTableAdapter rEGİstERTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox RBml;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton RBfml;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}