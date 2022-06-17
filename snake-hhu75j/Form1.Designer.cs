namespace snake_hhu75j
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
            this.palya = new System.Windows.Forms.PictureBox();
            this.start_gomb = new System.Windows.Forms.Button();
            this.pontszamLabel = new System.Windows.Forms.Label();
            this.maxPontszamLabel = new System.Windows.Forms.Label();
            this.idozito = new System.Windows.Forms.Timer(this.components);
            this.helpGomb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.palya)).BeginInit();
            this.SuspendLayout();
            // 
            // palya
            // 
            this.palya.BackColor = System.Drawing.Color.Khaki;
            this.palya.Location = new System.Drawing.Point(25, 25);
            this.palya.Name = "palya";
            this.palya.Size = new System.Drawing.Size(704, 704);
            this.palya.TabIndex = 0;
            this.palya.TabStop = false;
            this.palya.Click += new System.EventHandler(this.palya_Click);
            this.palya.Paint += new System.Windows.Forms.PaintEventHandler(this.palya_frissit);
            // 
            // start_gomb
            // 
            this.start_gomb.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.start_gomb.Location = new System.Drawing.Point(774, 48);
            this.start_gomb.Name = "start_gomb";
            this.start_gomb.Size = new System.Drawing.Size(170, 87);
            this.start_gomb.TabIndex = 1;
            this.start_gomb.Text = "START";
            this.start_gomb.UseVisualStyleBackColor = true;
            this.start_gomb.Click += new System.EventHandler(this.start_game);
            // 
            // pontszamLabel
            // 
            this.pontszamLabel.AutoSize = true;
            this.pontszamLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pontszamLabel.Location = new System.Drawing.Point(774, 158);
            this.pontszamLabel.Name = "pontszamLabel";
            this.pontszamLabel.Size = new System.Drawing.Size(148, 18);
            this.pontszamLabel.TabIndex = 2;
            this.pontszamLabel.Text = "Elért pontszám";
            this.pontszamLabel.Click += new System.EventHandler(this.pontszamLabel_Click);
            // 
            // maxPontszamLabel
            // 
            this.maxPontszamLabel.AutoSize = true;
            this.maxPontszamLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxPontszamLabel.Location = new System.Drawing.Point(748, 195);
            this.maxPontszamLabel.Name = "maxPontszamLabel";
            this.maxPontszamLabel.Size = new System.Drawing.Size(198, 18);
            this.maxPontszamLabel.TabIndex = 2;
            this.maxPontszamLabel.Text = "Legnagyobb pontszám";
            // 
            // idozito
            // 
            this.idozito.Tick += new System.EventHandler(this.jatek_orajel);
            // 
            // helpGomb
            // 
            this.helpGomb.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.helpGomb.Location = new System.Drawing.Point(774, 642);
            this.helpGomb.Name = "helpGomb";
            this.helpGomb.Size = new System.Drawing.Size(170, 87);
            this.helpGomb.TabIndex = 1;
            this.helpGomb.Text = "SEGÍTSÉG";
            this.helpGomb.UseVisualStyleBackColor = true;
            this.helpGomb.Click += new System.EventHandler(this.helpGomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.maxPontszamLabel);
            this.Controls.Add(this.pontszamLabel);
            this.Controls.Add(this.helpGomb);
            this.Controls.Add(this.start_gomb);
            this.Controls.Add(this.palya);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Snake - HHU75J";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.legomb);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.felgomb);
            ((System.ComponentModel.ISupportInitialize)(this.palya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox palya;
        private System.Windows.Forms.Button start_gomb;
        private System.Windows.Forms.Label pontszamLabel;
        private System.Windows.Forms.Label maxPontszamLabel;
        private System.Windows.Forms.Timer idozito;
        private System.Windows.Forms.Button helpGomb;
    }
}
