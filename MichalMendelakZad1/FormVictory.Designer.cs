
namespace MichalMendelakZad1
{
    partial class FormVictory
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
            this.labelVictory = new System.Windows.Forms.Label();
            this.buttonVictoryClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVictory
            // 
            this.labelVictory.AutoSize = true;
            this.labelVictory.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVictory.Location = new System.Drawing.Point(12, 9);
            this.labelVictory.Name = "labelVictory";
            this.labelVictory.Size = new System.Drawing.Size(221, 68);
            this.labelVictory.TabIndex = 0;
            this.labelVictory.Text = "you won!";
            // 
            // buttonVictoryClose
            // 
            this.buttonVictoryClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVictoryClose.Location = new System.Drawing.Point(253, 112);
            this.buttonVictoryClose.Name = "buttonVictoryClose";
            this.buttonVictoryClose.Size = new System.Drawing.Size(108, 38);
            this.buttonVictoryClose.TabIndex = 1;
            this.buttonVictoryClose.Text = "great !";
            this.buttonVictoryClose.UseVisualStyleBackColor = true;
            this.buttonVictoryClose.Click += new System.EventHandler(this.buttonVictoryClose_Click);
            // 
            // FormVictory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 162);
            this.Controls.Add(this.buttonVictoryClose);
            this.Controls.Add(this.labelVictory);
            this.Name = "FormVictory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVictory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVictory;
        private System.Windows.Forms.Button buttonVictoryClose;
    }
}