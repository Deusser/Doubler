namespace Doubler
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ButtonReset = new System.Windows.Forms.Button();
            this.labelcompnumber = new System.Windows.Forms.Label();
            this.labelusernumber = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.labelcountnumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonmultiple = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonReset
            // 
            this.ButtonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(2)))), ((int)(((byte)(141)))));
            this.ButtonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonReset.Font = new System.Drawing.Font("Miriam Fixed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReset.Location = new System.Drawing.Point(0, 112);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(25, 26);
            this.ButtonReset.TabIndex = 3;
            this.ButtonReset.Text = "Новая игра";
            this.ButtonReset.UseVisualStyleBackColor = false;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // labelcompnumber
            // 
            this.labelcompnumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelcompnumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelcompnumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcompnumber.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelcompnumber.Location = new System.Drawing.Point(256, 152);
            this.labelcompnumber.Name = "labelcompnumber";
            this.labelcompnumber.Size = new System.Drawing.Size(79, 53);
            this.labelcompnumber.TabIndex = 4;
            this.labelcompnumber.Text = "Получите число:";
            this.labelcompnumber.Click += new System.EventHandler(this.labelcompnumber_Click);
            // 
            // labelusernumber
            // 
            this.labelusernumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelusernumber.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelusernumber.Location = new System.Drawing.Point(0, 152);
            this.labelusernumber.Name = "labelusernumber";
            this.labelusernumber.Size = new System.Drawing.Size(79, 54);
            this.labelusernumber.TabIndex = 5;
            this.labelusernumber.Text = "Текущее число:";
            // 
            // labelcount
            // 
            this.labelcount.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcount.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelcount.Location = new System.Drawing.Point(104, 177);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(134, 28);
            this.labelcount.TabIndex = 6;
            this.labelcount.Text = "Число действий:";
            // 
            // labelcountnumber
            // 
            this.labelcountnumber.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcountnumber.ForeColor = System.Drawing.Color.Crimson;
            this.labelcountnumber.Location = new System.Drawing.Point(154, 205);
            this.labelcountnumber.Name = "labelcountnumber";
            this.labelcountnumber.Size = new System.Drawing.Size(36, 56);
            this.labelcountnumber.TabIndex = 7;
            this.labelcountnumber.Click += new System.EventHandler(this.labelcountnumber_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(75)))), ((int)(((byte)(181)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Purple;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlus.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(0, 208);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(79, 53);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "Плюс один";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonmultiple
            // 
            this.buttonmultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmultiple.BackColor = System.Drawing.Color.Purple;
            this.buttonmultiple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonmultiple.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonmultiple.Location = new System.Drawing.Point(256, 208);
            this.buttonmultiple.Name = "buttonmultiple";
            this.buttonmultiple.Size = new System.Drawing.Size(79, 53);
            this.buttonmultiple.TabIndex = 1;
            this.buttonmultiple.Text = "Умножить на 2";
            this.buttonmultiple.UseVisualStyleBackColor = false;
            this.buttonmultiple.Click += new System.EventHandler(this.buttonmultiple_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 261);
            this.Controls.Add(this.buttonmultiple);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.labelcompnumber);
            this.Controls.Add(this.labelcountnumber);
            this.Controls.Add(this.labelcount);
            this.Controls.Add(this.labelusernumber);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(351, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(351, 300);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doubler The Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Label labelcompnumber;
        private System.Windows.Forms.Label labelusernumber;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.Label labelcountnumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonmultiple;
    }
}

