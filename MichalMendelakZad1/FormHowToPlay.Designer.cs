
namespace MichalMendelakZad1
{
    partial class FormHowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHowToPlay));
            this.labelHowToPlay = new System.Windows.Forms.Label();
            this.buttonHowToPlayClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHowToPlay
            // 
            this.labelHowToPlay.AutoSize = true;
            this.labelHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHowToPlay.Location = new System.Drawing.Point(12, 9);
            this.labelHowToPlay.Name = "labelHowToPlay";
            this.labelHowToPlay.Size = new System.Drawing.Size(967, 640);
            this.labelHowToPlay.TabIndex = 0;
            this.labelHowToPlay.Text = resources.GetString("labelHowToPlay.Text");
            // 
            // buttonHowToPlayClose
            // 
            this.buttonHowToPlayClose.Location = new System.Drawing.Point(759, 68);
            this.buttonHowToPlayClose.Name = "buttonHowToPlayClose";
            this.buttonHowToPlayClose.Size = new System.Drawing.Size(128, 68);
            this.buttonHowToPlayClose.TabIndex = 1;
            this.buttonHowToPlayClose.Text = "Got it!";
            this.buttonHowToPlayClose.UseVisualStyleBackColor = true;
            this.buttonHowToPlayClose.Click += new System.EventHandler(this.buttonHowToPlayClose_Click);
            // 
            // FormHowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 657);
            this.Controls.Add(this.buttonHowToPlayClose);
            this.Controls.Add(this.labelHowToPlay);
            this.Name = "FormHowToPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHowToPlay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHowToPlay;
        private System.Windows.Forms.Button buttonHowToPlayClose;
    }
}