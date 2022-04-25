
namespace MichalMendelakZad1
{
    partial class FormDefeat
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
            this.labelDefeat = new System.Windows.Forms.Label();
            this.buttonDefeatClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDefeat
            // 
            this.labelDefeat.AutoSize = true;
            this.labelDefeat.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDefeat.Location = new System.Drawing.Point(52, 41);
            this.labelDefeat.Name = "labelDefeat";
            this.labelDefeat.Size = new System.Drawing.Size(94, 29);
            this.labelDefeat.TabIndex = 0;
            this.labelDefeat.Text = "you lost!";
            // 
            // buttonDefeatClose
            // 
            this.buttonDefeatClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDefeatClose.Location = new System.Drawing.Point(173, 99);
            this.buttonDefeatClose.Name = "buttonDefeatClose";
            this.buttonDefeatClose.Size = new System.Drawing.Size(106, 34);
            this.buttonDefeatClose.TabIndex = 1;
            this.buttonDefeatClose.Text = "ok :(";
            this.buttonDefeatClose.UseVisualStyleBackColor = true;
            this.buttonDefeatClose.Click += new System.EventHandler(this.buttonDefeatClose_Click);
            // 
            // FormDefeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 145);
            this.Controls.Add(this.buttonDefeatClose);
            this.Controls.Add(this.labelDefeat);
            this.Name = "FormDefeat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDefeat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDefeat;
        private System.Windows.Forms.Button buttonDefeatClose;
    }
}