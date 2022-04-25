
namespace MichalMendelakZad1
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.buttonTickStartStop = new System.Windows.Forms.Button();
            this.buttonSetTickTimeFast = new System.Windows.Forms.Button();
            this.buttonSetTickTimeDefault = new System.Windows.Forms.Button();
            this.buttonSetTickTimeSlow = new System.Windows.Forms.Button();
            this.labelWarehouse = new System.Windows.Forms.Label();
            this.labelInGameTime = new System.Windows.Forms.Label();
            this.labelInfrastructure = new System.Windows.Forms.Label();
            this.buttonLivingQuarterlevelIncrease = new System.Windows.Forms.Button();
            this.buttonFarmslevelIncrease = new System.Windows.Forms.Button();
            this.buttonLumberMilllevelIncrease = new System.Windows.Forms.Button();
            this.buttonQuarrylevelIncrease = new System.Windows.Forms.Button();
            this.buttonMinelevelIncrease = new System.Windows.Forms.Button();
            this.labelConstructionCosts = new System.Windows.Forms.Label();
            this.labelNews = new System.Windows.Forms.Label();
            this.labelMarketplace = new System.Windows.Forms.Label();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.buttonBuildMarketplace = new System.Windows.Forms.Button();
            this.buttonSellWood = new System.Windows.Forms.Button();
            this.buttonBuyWood = new System.Windows.Forms.Button();
            this.buttonSellStone = new System.Windows.Forms.Button();
            this.buttonBuyStone = new System.Windows.Forms.Button();
            this.buttonSellIron = new System.Windows.Forms.Button();
            this.buttonBuyIron = new System.Windows.Forms.Button();
            this.buttonHowToPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerTick
            // 
            this.timerTick.Interval = 1000;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // buttonTickStartStop
            // 
            this.buttonTickStartStop.Location = new System.Drawing.Point(12, 57);
            this.buttonTickStartStop.Name = "buttonTickStartStop";
            this.buttonTickStartStop.Size = new System.Drawing.Size(75, 36);
            this.buttonTickStartStop.TabIndex = 1;
            this.buttonTickStartStop.Text = "start";
            this.buttonTickStartStop.UseVisualStyleBackColor = true;
            this.buttonTickStartStop.Click += new System.EventHandler(this.buttonTickStartStop_Click);
            // 
            // buttonSetTickTimeFast
            // 
            this.buttonSetTickTimeFast.Location = new System.Drawing.Point(185, 57);
            this.buttonSetTickTimeFast.Name = "buttonSetTickTimeFast";
            this.buttonSetTickTimeFast.Size = new System.Drawing.Size(40, 36);
            this.buttonSetTickTimeFast.TabIndex = 3;
            this.buttonSetTickTimeFast.Text = ">>>";
            this.buttonSetTickTimeFast.UseVisualStyleBackColor = true;
            this.buttonSetTickTimeFast.Click += new System.EventHandler(this.buttonSetTickTimeFast_Click);
            // 
            // buttonSetTickTimeDefault
            // 
            this.buttonSetTickTimeDefault.Location = new System.Drawing.Point(139, 57);
            this.buttonSetTickTimeDefault.Name = "buttonSetTickTimeDefault";
            this.buttonSetTickTimeDefault.Size = new System.Drawing.Size(40, 36);
            this.buttonSetTickTimeDefault.TabIndex = 4;
            this.buttonSetTickTimeDefault.Text = ">>";
            this.buttonSetTickTimeDefault.UseVisualStyleBackColor = true;
            this.buttonSetTickTimeDefault.Click += new System.EventHandler(this.buttonSetTickTimeDefault_Click);
            // 
            // buttonSetTickTimeSlow
            // 
            this.buttonSetTickTimeSlow.Location = new System.Drawing.Point(93, 57);
            this.buttonSetTickTimeSlow.Name = "buttonSetTickTimeSlow";
            this.buttonSetTickTimeSlow.Size = new System.Drawing.Size(40, 36);
            this.buttonSetTickTimeSlow.TabIndex = 5;
            this.buttonSetTickTimeSlow.Text = ">";
            this.buttonSetTickTimeSlow.UseVisualStyleBackColor = true;
            this.buttonSetTickTimeSlow.Click += new System.EventHandler(this.buttonSetTickTimeSlow_Click);
            // 
            // labelWarehouse
            // 
            this.labelWarehouse.AutoSize = true;
            this.labelWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWarehouse.Location = new System.Drawing.Point(12, 482);
            this.labelWarehouse.Name = "labelWarehouse";
            this.labelWarehouse.Size = new System.Drawing.Size(109, 220);
            this.labelWarehouse.TabIndex = 6;
            this.labelWarehouse.Text = "Warehouse:\r\n|\r\n|---food: - [-]\r\n|\r\n|---wood: - [-]\r\n|\r\n|---stone: - [-]\r\n|\r\n|---i" +
    "ron: - [-]\r\n|\r\nL--gold: -";
            // 
            // labelInGameTime
            // 
            this.labelInGameTime.AutoSize = true;
            this.labelInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInGameTime.Location = new System.Drawing.Point(12, 19);
            this.labelInGameTime.Name = "labelInGameTime";
            this.labelInGameTime.Size = new System.Drawing.Size(164, 20);
            this.labelInGameTime.TabIndex = 7;
            this.labelInGameTime.Text = "Current game time: -";
            // 
            // labelInfrastructure
            // 
            this.labelInfrastructure.AutoSize = true;
            this.labelInfrastructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfrastructure.Location = new System.Drawing.Point(244, 484);
            this.labelInfrastructure.Name = "labelInfrastructure";
            this.labelInfrastructure.Size = new System.Drawing.Size(191, 220);
            this.labelInfrastructure.TabIndex = 13;
            this.labelInfrastructure.Text = "Infrastructure:\r\n|\r\n|---living quarters level: -\r\n|\r\n|---farms level: -\r\n|\r\n|---l" +
    "umber mill level: -\r\n|\r\n|---quarry level: -\r\n|\r\nL--mine level: -";
            // 
            // buttonLivingQuarterlevelIncrease
            // 
            this.buttonLivingQuarterlevelIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLivingQuarterlevelIncrease.Location = new System.Drawing.Point(450, 514);
            this.buttonLivingQuarterlevelIncrease.Name = "buttonLivingQuarterlevelIncrease";
            this.buttonLivingQuarterlevelIncrease.Size = new System.Drawing.Size(21, 23);
            this.buttonLivingQuarterlevelIncrease.TabIndex = 23;
            this.buttonLivingQuarterlevelIncrease.Text = "+";
            this.buttonLivingQuarterlevelIncrease.UseVisualStyleBackColor = true;
            this.buttonLivingQuarterlevelIncrease.Click += new System.EventHandler(this.buttonLivingQuarterlevelIncrease_Click);
            // 
            // buttonFarmslevelIncrease
            // 
            this.buttonFarmslevelIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFarmslevelIncrease.Location = new System.Drawing.Point(450, 552);
            this.buttonFarmslevelIncrease.Name = "buttonFarmslevelIncrease";
            this.buttonFarmslevelIncrease.Size = new System.Drawing.Size(21, 23);
            this.buttonFarmslevelIncrease.TabIndex = 24;
            this.buttonFarmslevelIncrease.Text = "+";
            this.buttonFarmslevelIncrease.UseVisualStyleBackColor = true;
            this.buttonFarmslevelIncrease.Click += new System.EventHandler(this.buttonFarmslevelIncrease_Click);
            // 
            // buttonLumberMilllevelIncrease
            // 
            this.buttonLumberMilllevelIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLumberMilllevelIncrease.Location = new System.Drawing.Point(450, 596);
            this.buttonLumberMilllevelIncrease.Name = "buttonLumberMilllevelIncrease";
            this.buttonLumberMilllevelIncrease.Size = new System.Drawing.Size(21, 23);
            this.buttonLumberMilllevelIncrease.TabIndex = 25;
            this.buttonLumberMilllevelIncrease.Text = "+";
            this.buttonLumberMilllevelIncrease.UseVisualStyleBackColor = true;
            this.buttonLumberMilllevelIncrease.Click += new System.EventHandler(this.buttonLumberMilllevelIncrease_Click);
            // 
            // buttonQuarrylevelIncrease
            // 
            this.buttonQuarrylevelIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonQuarrylevelIncrease.Location = new System.Drawing.Point(450, 639);
            this.buttonQuarrylevelIncrease.Name = "buttonQuarrylevelIncrease";
            this.buttonQuarrylevelIncrease.Size = new System.Drawing.Size(21, 23);
            this.buttonQuarrylevelIncrease.TabIndex = 26;
            this.buttonQuarrylevelIncrease.Text = "+";
            this.buttonQuarrylevelIncrease.UseVisualStyleBackColor = true;
            this.buttonQuarrylevelIncrease.Click += new System.EventHandler(this.buttonQuarrylevelIncrease_Click);
            // 
            // buttonMinelevelIncrease
            // 
            this.buttonMinelevelIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMinelevelIncrease.Location = new System.Drawing.Point(450, 679);
            this.buttonMinelevelIncrease.Name = "buttonMinelevelIncrease";
            this.buttonMinelevelIncrease.Size = new System.Drawing.Size(21, 23);
            this.buttonMinelevelIncrease.TabIndex = 27;
            this.buttonMinelevelIncrease.Text = "+";
            this.buttonMinelevelIncrease.UseVisualStyleBackColor = true;
            this.buttonMinelevelIncrease.Click += new System.EventHandler(this.buttonMinelevelIncrease_Click);
            // 
            // labelConstructionCosts
            // 
            this.labelConstructionCosts.AutoSize = true;
            this.labelConstructionCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelConstructionCosts.Location = new System.Drawing.Point(520, 482);
            this.labelConstructionCosts.Name = "labelConstructionCosts";
            this.labelConstructionCosts.Size = new System.Drawing.Size(359, 220);
            this.labelConstructionCosts.TabIndex = 28;
            this.labelConstructionCosts.Text = resources.GetString("labelConstructionCosts.Text");
            // 
            // labelNews
            // 
            this.labelNews.AutoSize = true;
            this.labelNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNews.Location = new System.Drawing.Point(12, 117);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(121, 20);
            this.labelNews.TabIndex = 29;
            this.labelNews.Text = "Recent events:";
            // 
            // labelMarketplace
            // 
            this.labelMarketplace.AutoSize = true;
            this.labelMarketplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMarketplace.Location = new System.Drawing.Point(921, 482);
            this.labelMarketplace.Name = "labelMarketplace";
            this.labelMarketplace.Size = new System.Drawing.Size(310, 220);
            this.labelMarketplace.TabIndex = 30;
            this.labelMarketplace.Text = "Marketplace:                                         \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.labelMarketplace.Visible = false;
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPopulation.Location = new System.Drawing.Point(1182, 45);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(218, 120);
            this.labelPopulation.TabIndex = 31;
            this.labelPopulation.Text = "Population:   - / -\r\n\r\nRecent food balance: - , - , -\r\n\r\n\r\nScore: -";
            // 
            // buttonBuildMarketplace
            // 
            this.buttonBuildMarketplace.Location = new System.Drawing.Point(987, 568);
            this.buttonBuildMarketplace.Name = "buttonBuildMarketplace";
            this.buttonBuildMarketplace.Size = new System.Drawing.Size(176, 68);
            this.buttonBuildMarketplace.TabIndex = 32;
            this.buttonBuildMarketplace.Text = "build marketplace for:\r\n100 wood, 50 stone,\r\n10 iron, 50 gold";
            this.buttonBuildMarketplace.UseVisualStyleBackColor = true;
            this.buttonBuildMarketplace.Click += new System.EventHandler(this.buttonBuildMarketplace_Click);
            // 
            // buttonSellWood
            // 
            this.buttonSellWood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSellWood.Location = new System.Drawing.Point(925, 505);
            this.buttonSellWood.Name = "buttonSellWood";
            this.buttonSellWood.Size = new System.Drawing.Size(142, 61);
            this.buttonSellWood.TabIndex = 33;
            this.buttonSellWood.Text = "sell 50 wood for 50 gold";
            this.buttonSellWood.UseVisualStyleBackColor = true;
            this.buttonSellWood.Visible = false;
            this.buttonSellWood.Click += new System.EventHandler(this.buttonSellWood_Click);
            // 
            // buttonBuyWood
            // 
            this.buttonBuyWood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBuyWood.Location = new System.Drawing.Point(1087, 505);
            this.buttonBuyWood.Name = "buttonBuyWood";
            this.buttonBuyWood.Size = new System.Drawing.Size(142, 61);
            this.buttonBuyWood.TabIndex = 34;
            this.buttonBuyWood.Text = "buy 50 wood for 50 gold";
            this.buttonBuyWood.UseVisualStyleBackColor = true;
            this.buttonBuyWood.Visible = false;
            this.buttonBuyWood.Click += new System.EventHandler(this.buttonBuyWood_Click);
            // 
            // buttonSellStone
            // 
            this.buttonSellStone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSellStone.Location = new System.Drawing.Point(925, 571);
            this.buttonSellStone.Name = "buttonSellStone";
            this.buttonSellStone.Size = new System.Drawing.Size(142, 61);
            this.buttonSellStone.TabIndex = 35;
            this.buttonSellStone.Text = "sell 50 stone for 70 gold";
            this.buttonSellStone.UseVisualStyleBackColor = true;
            this.buttonSellStone.Visible = false;
            this.buttonSellStone.Click += new System.EventHandler(this.buttonSellStone_Click);
            // 
            // buttonBuyStone
            // 
            this.buttonBuyStone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBuyStone.Location = new System.Drawing.Point(1087, 571);
            this.buttonBuyStone.Name = "buttonBuyStone";
            this.buttonBuyStone.Size = new System.Drawing.Size(142, 61);
            this.buttonBuyStone.TabIndex = 36;
            this.buttonBuyStone.Text = "buy 50 stone for 140 gold";
            this.buttonBuyStone.UseVisualStyleBackColor = true;
            this.buttonBuyStone.Visible = false;
            this.buttonBuyStone.Click += new System.EventHandler(this.buttonBuyStone_Click);
            // 
            // buttonSellIron
            // 
            this.buttonSellIron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSellIron.Location = new System.Drawing.Point(925, 638);
            this.buttonSellIron.Name = "buttonSellIron";
            this.buttonSellIron.Size = new System.Drawing.Size(142, 61);
            this.buttonSellIron.TabIndex = 37;
            this.buttonSellIron.Text = "sell 50 iron for 100 gold";
            this.buttonSellIron.UseVisualStyleBackColor = true;
            this.buttonSellIron.Visible = false;
            this.buttonSellIron.Click += new System.EventHandler(this.buttonSellIron_Click);
            // 
            // buttonBuyIron
            // 
            this.buttonBuyIron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBuyIron.Location = new System.Drawing.Point(1087, 638);
            this.buttonBuyIron.Name = "buttonBuyIron";
            this.buttonBuyIron.Size = new System.Drawing.Size(142, 61);
            this.buttonBuyIron.TabIndex = 38;
            this.buttonBuyIron.Text = "buy 50 iron for 200 gold";
            this.buttonBuyIron.UseVisualStyleBackColor = true;
            this.buttonBuyIron.Visible = false;
            this.buttonBuyIron.Click += new System.EventHandler(this.buttonBuyIron_Click);
            // 
            // buttonHowToPlay
            // 
            this.buttonHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHowToPlay.Location = new System.Drawing.Point(1321, 638);
            this.buttonHowToPlay.Name = "buttonHowToPlay";
            this.buttonHowToPlay.Size = new System.Drawing.Size(122, 61);
            this.buttonHowToPlay.TabIndex = 39;
            this.buttonHowToPlay.Text = "how to play?";
            this.buttonHowToPlay.UseVisualStyleBackColor = true;
            this.buttonHowToPlay.Click += new System.EventHandler(this.buttonHowToPlay_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1455, 711);
            this.Controls.Add(this.buttonHowToPlay);
            this.Controls.Add(this.buttonBuyIron);
            this.Controls.Add(this.buttonSellIron);
            this.Controls.Add(this.buttonBuyStone);
            this.Controls.Add(this.buttonSellStone);
            this.Controls.Add(this.buttonBuyWood);
            this.Controls.Add(this.buttonSellWood);
            this.Controls.Add(this.buttonBuildMarketplace);
            this.Controls.Add(this.labelPopulation);
            this.Controls.Add(this.labelMarketplace);
            this.Controls.Add(this.labelNews);
            this.Controls.Add(this.labelConstructionCosts);
            this.Controls.Add(this.buttonMinelevelIncrease);
            this.Controls.Add(this.buttonQuarrylevelIncrease);
            this.Controls.Add(this.buttonLumberMilllevelIncrease);
            this.Controls.Add(this.buttonFarmslevelIncrease);
            this.Controls.Add(this.buttonLivingQuarterlevelIncrease);
            this.Controls.Add(this.labelInfrastructure);
            this.Controls.Add(this.labelInGameTime);
            this.Controls.Add(this.labelWarehouse);
            this.Controls.Add(this.buttonSetTickTimeSlow);
            this.Controls.Add(this.buttonSetTickTimeDefault);
            this.Controls.Add(this.buttonSetTickTimeFast);
            this.Controls.Add(this.buttonTickStartStop);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.Button buttonTickStartStop;
        private System.Windows.Forms.Button buttonSetTickTimeFast;
        private System.Windows.Forms.Button buttonSetTickTimeDefault;
        private System.Windows.Forms.Button buttonSetTickTimeSlow;
        private System.Windows.Forms.Label labelWarehouse;
        private System.Windows.Forms.Label labelInGameTime;
        private System.Windows.Forms.Label labelInfrastructure;
        private System.Windows.Forms.Button buttonLivingQuarterlevelIncrease;
        private System.Windows.Forms.Button buttonFarmslevelIncrease;
        private System.Windows.Forms.Button buttonLumberMilllevelIncrease;
        private System.Windows.Forms.Button buttonQuarrylevelIncrease;
        private System.Windows.Forms.Button buttonMinelevelIncrease;
        private System.Windows.Forms.Label labelConstructionCosts;
        private System.Windows.Forms.Label labelNews;
        private System.Windows.Forms.Label labelMarketplace;
        private System.Windows.Forms.Label labelPopulation;
        private System.Windows.Forms.Button buttonBuildMarketplace;
        private System.Windows.Forms.Button buttonSellWood;
        private System.Windows.Forms.Button buttonBuyWood;
        private System.Windows.Forms.Button buttonSellStone;
        private System.Windows.Forms.Button buttonBuyStone;
        private System.Windows.Forms.Button buttonSellIron;
        private System.Windows.Forms.Button buttonBuyIron;
        private System.Windows.Forms.Button buttonHowToPlay;
    }
}

