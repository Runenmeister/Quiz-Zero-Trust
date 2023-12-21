
namespace QuizZeroTrust
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnKontakt = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblQuestion = new System.Windows.Forms.Label();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn6);
            this.panel1.Controls.Add(this.Btn5);
            this.panel1.Controls.Add(this.Btn4);
            this.panel1.Controls.Add(this.Btn2);
            this.panel1.Controls.Add(this.Btn3);
            this.panel1.Controls.Add(this.Btn1);
            this.panel1.Location = new System.Drawing.Point(13, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 129);
            this.panel1.TabIndex = 1;
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(3, 68);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(232, 58);
            this.Btn4.TabIndex = 3;
            this.Btn4.Tag = "4";
            this.Btn4.Text = "D";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(241, 3);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(232, 58);
            this.Btn2.TabIndex = 2;
            this.Btn2.Tag = "2";
            this.Btn2.Text = "B";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(479, 3);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(232, 58);
            this.Btn3.TabIndex = 1;
            this.Btn3.Tag = "3";
            this.Btn3.Text = "C";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(3, 3);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(232, 58);
            this.Btn1.TabIndex = 0;
            this.Btn1.Tag = "1";
            this.Btn1.Text = "A";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // BtnKontakt
            // 
            this.BtnKontakt.Location = new System.Drawing.Point(735, 447);
            this.BtnKontakt.Name = "BtnKontakt";
            this.BtnKontakt.Size = new System.Drawing.Size(75, 23);
            this.BtnKontakt.TabIndex = 2;
            this.BtnKontakt.Text = "Kontakt";
            this.BtnKontakt.UseVisualStyleBackColor = true;
            this.BtnKontakt.Click += new System.EventHandler(this.BtnKontakt_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(735, 476);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblQuestion
            // 
            this.LblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuestion.ForeColor = System.Drawing.Color.White;
            this.LblQuestion.Location = new System.Drawing.Point(16, 295);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(772, 72);
            this.LblQuestion.TabIndex = 4;
            this.LblQuestion.Text = "Frage";
            this.LblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pb1
            // 
            this.Pb1.Image = global::QuizZeroTrust.Properties.Resources.logo;
            this.Pb1.Location = new System.Drawing.Point(13, 13);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(775, 275);
            this.Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb1.TabIndex = 0;
            this.Pb1.TabStop = false;
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(241, 67);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(232, 58);
            this.Btn5.TabIndex = 4;
            this.Btn5.Tag = "5";
            this.Btn5.Text = "E";
            this.Btn5.UseVisualStyleBackColor = true;
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(479, 68);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(232, 58);
            this.Btn6.TabIndex = 5;
            this.Btn6.Tag = "6";
            this.Btn6.Text = "F";
            this.Btn6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(822, 511);
            this.Controls.Add(this.LblQuestion);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnKontakt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz: Zero Trust | by Runenmeister (c) 12/2023";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnKontakt;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
    }
}

