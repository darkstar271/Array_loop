namespace Array_Loop
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbxNames = new System.Windows.Forms.ListBox();
            this.lbxWinners = new System.Windows.Forms.ListBox();
            this.lblwinner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(143, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run \r\nArray";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxNames
            // 
            this.lbxNames.FormattingEnabled = true;
            this.lbxNames.Location = new System.Drawing.Point(7, 12);
            this.lbxNames.Name = "lbxNames";
            this.lbxNames.Size = new System.Drawing.Size(120, 238);
            this.lbxNames.TabIndex = 1;
            this.lbxNames.SelectedIndexChanged += new System.EventHandler(this.lbxNames_SelectedIndexChanged);
            // 
            // lbxWinners
            // 
            this.lbxWinners.FormattingEnabled = true;
            this.lbxWinners.Location = new System.Drawing.Point(237, 12);
            this.lbxWinners.Name = "lbxWinners";
            this.lbxWinners.Size = new System.Drawing.Size(120, 238);
            this.lbxWinners.TabIndex = 2;
            this.lbxWinners.SelectedIndexChanged += new System.EventHandler(this.lbxWinners_SelectedIndexChanged);
            // 
            // lblwinner
            // 
            this.lblwinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinner.ForeColor = System.Drawing.Color.Blue;
            this.lblwinner.Location = new System.Drawing.Point(140, 23);
            this.lblwinner.Name = "lblwinner";
            this.lblwinner.Size = new System.Drawing.Size(84, 97);
            this.lblwinner.TabIndex = 3;
            this.lblwinner.Text = "lblwinner";
            this.lblwinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 378);
            this.Controls.Add(this.lblwinner);
            this.Controls.Add(this.lbxWinners);
            this.Controls.Add(this.lbxNames);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbxNames;
        private System.Windows.Forms.ListBox lbxWinners;
        private System.Windows.Forms.Label lblwinner;
    }
}

