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
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonmultiple = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.labelcompnumber = new System.Windows.Forms.Label();
            this.labelusernumber = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.labelcountnumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPlus.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(12, 14);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(119, 71);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "Плюс один";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonmultiple
            // 
            this.buttonmultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmultiple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonmultiple.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmultiple.Location = new System.Drawing.Point(204, 14);
            this.buttonmultiple.Name = "buttonmultiple";
            this.buttonmultiple.Size = new System.Drawing.Size(119, 71);
            this.buttonmultiple.TabIndex = 1;
            this.buttonmultiple.Text = "Умножить на 2";
            this.buttonmultiple.UseVisualStyleBackColor = false;
            this.buttonmultiple.Click += new System.EventHandler(this.buttonmultiple_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.buttonmultiple);
            this.panel1.Controls.Add(this.buttonPlus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 97);
            this.panel1.TabIndex = 2;
            // 
            // ButtonReset
            // 
            this.ButtonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonReset.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonReset.Font = new System.Drawing.Font("Miriam Fixed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReset.Location = new System.Drawing.Point(254, -1);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(81, 51);
            this.ButtonReset.TabIndex = 3;
            this.ButtonReset.Text = "Новая игра";
            this.ButtonReset.UseVisualStyleBackColor = false;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // labelcompnumber
            // 
            this.labelcompnumber.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcompnumber.Location = new System.Drawing.Point(12, 9);
            this.labelcompnumber.Name = "labelcompnumber";
            this.labelcompnumber.Size = new System.Drawing.Size(183, 63);
            this.labelcompnumber.TabIndex = 4;
            this.labelcompnumber.Text = "Получите число:";
            // 
            // labelusernumber
            // 
            this.labelusernumber.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusernumber.Location = new System.Drawing.Point(9, 72);
            this.labelusernumber.Name = "labelusernumber";
            this.labelusernumber.Size = new System.Drawing.Size(186, 56);
            this.labelusernumber.TabIndex = 5;
            this.labelusernumber.Text = "Текущее число:";
            // 
            // labelcount
            // 
            this.labelcount.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcount.Location = new System.Drawing.Point(189, 63);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(134, 28);
            this.labelcount.TabIndex = 6;
            this.labelcount.Text = "Число действий";
            // 
            // labelcountnumber
            // 
            this.labelcountnumber.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcountnumber.Location = new System.Drawing.Point(249, 91);
            this.labelcountnumber.Name = "labelcountnumber";
            this.labelcountnumber.Size = new System.Drawing.Size(32, 23);
            this.labelcountnumber.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 261);
            this.Controls.Add(this.labelcountnumber);
            this.Controls.Add(this.labelcount);
            this.Controls.Add(this.labelusernumber);
            this.Controls.Add(this.labelcompnumber);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(351, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(351, 300);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doubler The Game";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonmultiple;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Label labelcompnumber;
        private System.Windows.Forms.Label labelusernumber;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.Label labelcountnumber;
    }
}

