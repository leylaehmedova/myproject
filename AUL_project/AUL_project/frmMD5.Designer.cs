
namespace AUL_project
{
    partial class frmMD5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMD5));
            this.txtbtxt = new System.Windows.Forms.TextBox();
            this.txtbres = new System.Windows.Forms.TextBox();
            this.btnEnc2 = new System.Windows.Forms.Button();
            this.lbltxt = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClean2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbtxt
            // 
            this.txtbtxt.Location = new System.Drawing.Point(97, 170);
            this.txtbtxt.Multiline = true;
            this.txtbtxt.Name = "txtbtxt";
            this.txtbtxt.Size = new System.Drawing.Size(519, 42);
            this.txtbtxt.TabIndex = 4;
            // 
            // txtbres
            // 
            this.txtbres.Location = new System.Drawing.Point(97, 268);
            this.txtbres.Multiline = true;
            this.txtbres.Name = "txtbres";
            this.txtbres.Size = new System.Drawing.Size(519, 42);
            this.txtbres.TabIndex = 8;
            this.txtbres.TextChanged += new System.EventHandler(this.txtbres_TextChanged);
            // 
            // btnEnc2
            // 
            this.btnEnc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnc2.Location = new System.Drawing.Point(163, 343);
            this.btnEnc2.Name = "btnEnc2";
            this.btnEnc2.Size = new System.Drawing.Size(163, 66);
            this.btnEnc2.TabIndex = 9;
            this.btnEnc2.Text = "ENCRYPT";
            this.btnEnc2.UseVisualStyleBackColor = true;
            this.btnEnc2.Click += new System.EventHandler(this.btnendec_Click);
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt.Location = new System.Drawing.Point(22, 170);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(62, 25);
            this.lbltxt.TabIndex = 12;
            this.lbltxt.Text = "Text:";
            this.lbltxt.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.Location = new System.Drawing.Point(12, 267);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(79, 25);
            this.lblres.TabIndex = 15;
            this.lblres.Text = "Result:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(284, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "MD5";
            // 
            // btnClean2
            // 
            this.btnClean2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean2.Location = new System.Drawing.Point(404, 343);
            this.btnClean2.Name = "btnClean2";
            this.btnClean2.Size = new System.Drawing.Size(163, 66);
            this.btnClean2.TabIndex = 18;
            this.btnClean2.Text = "CLEAN";
            this.btnClean2.UseVisualStyleBackColor = true;
            this.btnClean2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 32;
            this.button3.Text = ".";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1190, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 60);
            this.button1.TabIndex = 33;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(686, 170);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(553, 364);
            this.listBox1.TabIndex = 35;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(681, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Archive encrypts/decrypts:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.linkLabel1.Location = new System.Drawing.Point(638, 230);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 46);
            this.linkLabel1.TabIndex = 37;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Status:";
            // 
            // frmMD5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1270, 570);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClean2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.btnEnc2);
            this.Controls.Add(this.txtbres);
            this.Controls.Add(this.txtbtxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMD5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMD5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbtxt;
        private System.Windows.Forms.TextBox txtbres;
        private System.Windows.Forms.Button btnEnc2;
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClean2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
    }
}