
namespace WindowsFormsApp1
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
            this.lblQuizz = new System.Windows.Forms.Label();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuizz
            // 
            this.lblQuizz.AutoSize = true;
            this.lblQuizz.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizz.Location = new System.Drawing.Point(293, 19);
            this.lblQuizz.Name = "lblQuizz";
            this.lblQuizz.Size = new System.Drawing.Size(452, 117);
            this.lblQuizz.TabIndex = 0;
            this.lblQuizz.Text = "Quizz App";
            // 
            // btnComputer
            // 
            this.btnComputer.AutoSize = true;
            this.btnComputer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnComputer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputer.Location = new System.Drawing.Point(366, 245);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(286, 72);
            this.btnComputer.TabIndex = 1;
            this.btnComputer.Text = "Computer Science";
            this.btnComputer.UseVisualStyleBackColor = false;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.AutoSize = true;
            this.btnGeneral.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.Location = new System.Drawing.Point(366, 355);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(286, 72);
            this.btnGeneral.TabIndex = 2;
            this.btnGeneral.Text = "General Knowledge";
            this.btnGeneral.UseVisualStyleBackColor = false;
            // 
            // btnEnglish
            // 
            this.btnEnglish.AutoSize = true;
            this.btnEnglish.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.Location = new System.Drawing.Point(366, 463);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(286, 72);
            this.btnEnglish.TabIndex = 3;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1067, 636);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.btnComputer);
            this.Controls.Add(this.lblQuizz);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuizz;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnEnglish;
    }
}

