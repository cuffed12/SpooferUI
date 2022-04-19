namespace lmitp
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
            this.panelside = new System.Windows.Forms.Panel();
            this.panelheader = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.btnreports = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnemp = new System.Windows.Forms.Button();
            this.btndashbaord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelside.SuspendLayout();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelside.Controls.Add(this.button1);
            this.panelside.Controls.Add(this.btnreports);
            this.panelside.Controls.Add(this.pictureBox1);
            this.panelside.Controls.Add(this.btnemp);
            this.panelside.Controls.Add(this.btndashbaord);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 30);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(200, 420);
            this.panelside.TabIndex = 0;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelheader.Controls.Add(this.label1);
            this.panelheader.Controls.Add(this.btnclose);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(800, 30);
            this.panelheader.TabIndex = 1;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(770, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 30);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.Black;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(200, 30);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(600, 420);
            this.mainpanel.TabIndex = 2;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // btnreports
            // 
            this.btnreports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnreports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnreports.FlatAppearance.BorderSize = 0;
            this.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreports.ForeColor = System.Drawing.Color.White;
            this.btnreports.Image = global::lmitp.Properties.Resources.Ic_settings_48px_svg__1_;
            this.btnreports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreports.Location = new System.Drawing.Point(0, 184);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(200, 30);
            this.btnreports.TabIndex = 2;
            this.btnreports.Text = "SETTINGS";
            this.btnreports.UseVisualStyleBackColor = false;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lmitp.Properties.Resources.Pepega;
            this.pictureBox1.Location = new System.Drawing.Point(43, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnemp
            // 
            this.btnemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnemp.FlatAppearance.BorderSize = 0;
            this.btnemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemp.ForeColor = System.Drawing.Color.White;
            this.btnemp.Image = global::lmitp.Properties.Resources._73575__1_;
            this.btnemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnemp.Location = new System.Drawing.Point(0, 148);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(200, 30);
            this.btnemp.TabIndex = 1;
            this.btnemp.Text = "SYSTEM SPOOF";
            this.btnemp.UseVisualStyleBackColor = false;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // btndashbaord
            // 
            this.btndashbaord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btndashbaord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndashbaord.FlatAppearance.BorderSize = 0;
            this.btndashbaord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashbaord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashbaord.ForeColor = System.Drawing.Color.White;
            this.btndashbaord.Image = global::lmitp.Properties.Resources.kisspng_joystick_scalable_vector;
            this.btndashbaord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashbaord.Location = new System.Drawing.Point(0, 112);
            this.btndashbaord.Name = "btndashbaord";
            this.btndashbaord.Size = new System.Drawing.Size(200, 30);
            this.btndashbaord.TabIndex = 0;
            this.btndashbaord.Text = "GAME SPOOF";
            this.btndashbaord.UseVisualStyleBackColor = false;
            this.btndashbaord.Click += new System.EventHandler(this.btndashbaord_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "CREATOR VEUQX";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veuqx FiveM Spoofer Ui [Only Ui]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelside.ResumeLayout(false);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnemp;
        private System.Windows.Forms.Button btndashbaord;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

