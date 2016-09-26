namespace Tutorial_5_8
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
            this.pbxTails = new System.Windows.Forms.PictureBox();
            this.pbxHeads = new System.Windows.Forms.PictureBox();
            this.btmToos = new System.Windows.Forms.Button();
            this.lblcount = new System.Windows.Forms.Label();
            this.lblpercentage = new System.Windows.Forms.Label();
            this.tbxheads = new System.Windows.Forms.TextBox();
            this.tbxtails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxtp = new System.Windows.Forms.TextBox();
            this.tbxhp = new System.Windows.Forms.TextBox();
            this.lflips = new System.Windows.Forms.Label();
            this.txflips = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeads)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxTails
            // 
            this.pbxTails.Image = global::Tutorial_5_8.Properties.Resources.Tails1;
            this.pbxTails.Location = new System.Drawing.Point(12, 12);
            this.pbxTails.Name = "pbxTails";
            this.pbxTails.Size = new System.Drawing.Size(170, 170);
            this.pbxTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTails.TabIndex = 1;
            this.pbxTails.TabStop = false;
            this.pbxTails.Visible = false;
            // 
            // pbxHeads
            // 
            this.pbxHeads.Image = global::Tutorial_5_8.Properties.Resources.Heads1;
            this.pbxHeads.Location = new System.Drawing.Point(12, 12);
            this.pbxHeads.Name = "pbxHeads";
            this.pbxHeads.Size = new System.Drawing.Size(170, 170);
            this.pbxHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHeads.TabIndex = 0;
            this.pbxHeads.TabStop = false;
            this.pbxHeads.Visible = false;
            // 
            // btmToos
            // 
            this.btmToos.Location = new System.Drawing.Point(52, 203);
            this.btmToos.Name = "btmToos";
            this.btmToos.Size = new System.Drawing.Size(75, 23);
            this.btmToos.TabIndex = 2;
            this.btmToos.Text = "Toss";
            this.btmToos.UseVisualStyleBackColor = true;
            this.btmToos.Click += new System.EventHandler(this.btmToos_Click);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.Location = new System.Drawing.Point(196, 12);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(51, 17);
            this.lblcount.TabIndex = 3;
            this.lblcount.Text = "Times";
            // 
            // lblpercentage
            // 
            this.lblpercentage.AutoSize = true;
            this.lblpercentage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpercentage.Location = new System.Drawing.Point(188, 131);
            this.lblpercentage.Name = "lblpercentage";
            this.lblpercentage.Size = new System.Drawing.Size(93, 17);
            this.lblpercentage.TabIndex = 4;
            this.lblpercentage.Text = "Percentage";
            // 
            // tbxheads
            // 
            this.tbxheads.Enabled = false;
            this.tbxheads.Location = new System.Drawing.Point(253, 68);
            this.tbxheads.Name = "tbxheads";
            this.tbxheads.Size = new System.Drawing.Size(35, 20);
            this.tbxheads.TabIndex = 5;
            // 
            // tbxtails
            // 
            this.tbxtails.Enabled = false;
            this.tbxtails.Location = new System.Drawing.Point(253, 95);
            this.tbxtails.Name = "tbxtails";
            this.tbxtails.Size = new System.Drawing.Size(35, 20);
            this.tbxtails.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Heads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tails";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tails";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Heads";
            // 
            // tbxtp
            // 
            this.tbxtp.Enabled = false;
            this.tbxtp.Location = new System.Drawing.Point(253, 190);
            this.tbxtp.Name = "tbxtp";
            this.tbxtp.Size = new System.Drawing.Size(35, 20);
            this.tbxtp.TabIndex = 11;
            // 
            // tbxhp
            // 
            this.tbxhp.Enabled = false;
            this.tbxhp.Location = new System.Drawing.Point(253, 162);
            this.tbxhp.Name = "tbxhp";
            this.tbxhp.Size = new System.Drawing.Size(35, 20);
            this.tbxhp.TabIndex = 10;
            // 
            // lflips
            // 
            this.lflips.AutoSize = true;
            this.lflips.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lflips.Location = new System.Drawing.Point(196, 47);
            this.lflips.Name = "lflips";
            this.lflips.Size = new System.Drawing.Size(38, 15);
            this.lflips.TabIndex = 14;
            this.lflips.Text = "Flips";
            // 
            // txflips
            // 
            this.txflips.Enabled = false;
            this.txflips.Location = new System.Drawing.Point(253, 42);
            this.txflips.Name = "txflips";
            this.txflips.Size = new System.Drawing.Size(35, 20);
            this.txflips.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 262);
            this.Controls.Add(this.txflips);
            this.Controls.Add(this.lflips);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxtp);
            this.Controls.Add(this.tbxhp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxtails);
            this.Controls.Add(this.tbxheads);
            this.Controls.Add(this.lblpercentage);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.btmToos);
            this.Controls.Add(this.pbxTails);
            this.Controls.Add(this.pbxHeads);
            this.Name = "Form1";
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.pbxTails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxHeads;
        private System.Windows.Forms.PictureBox pbxTails;
        private System.Windows.Forms.Button btmToos;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label lblpercentage;
        private System.Windows.Forms.TextBox tbxheads;
        private System.Windows.Forms.TextBox tbxtails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxtp;
        private System.Windows.Forms.TextBox tbxhp;
        private System.Windows.Forms.Label lflips;
        private System.Windows.Forms.TextBox txflips;
    }
}

