using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalMendelakZad1
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// contains amount of in game ticks
        /// </summary>
        int counterTick = 0;
        /// <summary>
        /// 
        /// </summary>
        int counterTickStartStop = 0;
        /// <summary>
        /// checks if player built something this round
        /// </summary>
        int wasBuilt = 0;
        /// <summary>
        /// text in warehouse tab
        /// </summary>
        string warehouseText = "";
        /// <summary>
        /// text in infrastructure tab
        /// </summary>
        string infrastructureText = "";
        /// <summary>
        /// text in price of structure upgrades tab
        /// </summary>
        string priceText = "";
        /// <summary>
        /// informs about disasters
        /// </summary>
        string disasterText = "";
        /// <summary>
        /// previous events
        /// </summary>
        string previousDisasterText = "";
        /// <summary>
        /// older event
        /// </summary>
        string oldDisasterText = "";
        /// <summary>
        /// text in population tab
        /// </summary>
        string populationText = "";
        /// <summary>
        /// warns about starvation
        /// </summary>
        string starvationText = "";
        /// <summary>
        /// population of village
        /// </summary>
        int counterPopulation = 10;
        /// <summary>
        /// population thats going to die due to starvation
        /// </summary>
        int counterPopulationStarved = 0;
        /// <summary>
        /// amount of food
        /// </summary>
        int counterResourceFood = 0;
        /// <summary>
        /// food thats going to be edible next day
        /// </summary>
        int spareFood = 0;
        /// <summary>
        /// how much food was saved previous day, negative value can lead to starvation
        /// </summary>
        int savedFood = 0;
        /// <summary>
        /// how much food was saved 2 days ago, negative value can lead to starvation
        /// </summary>
        int savedFoodPast = 0;
        /// <summary>
        /// amount of wood
        /// </summary>
        int counterResourceWood = 100;
        /// <summary>
        /// amount of stone
        /// </summary>
        int counterResourceStone = 50;
        /// <summary>
        /// amount of iron
        /// </summary>
        int counterResourceIron = 0;
        /// <summary>
        /// amount of gold
        /// </summary>
        int counterResourceGold = 0;
        /// <summary>
        /// food gain amount
        /// </summary>
        int counterResourceGainFood = 0;
        /// <summary>
        /// wood gain amount
        /// </summary>
        int counterResourceGainWood = 0;
        /// <summary>
        /// stone gain amount
        /// </summary>
        int counterResourceGainStone = 0;
        /// <summary>
        /// iron gain amount
        /// </summary>
        int counterResourceGainIron = 0;
        /// <summary>
        /// level of living quarters
        /// </summary>
        int counterLivingQuarterslevel = 5;
        /// <summary>
        /// level of farms
        /// </summary>
        int counterFarmslevel = 2;
        /// <summary>
        /// level of lumber mill
        /// </summary>
        int counterLumberMilllevel = 1;
        /// <summary>
        /// level of quarry
        /// </summary>
        int counterQuarrylevel = 0;
        /// <summary>
        /// level of mines
        /// </summary>
        int counterMinelevel = 0;
        /// <summary>
        /// price of upgrading living quarters
        /// </summary>
        int[] livingQuartersPrice = new int[4] { 0, 0, 0, 0 };
        /// <summary>
        /// price of upgrading farms
        /// </summary>
        int[] farmsPrice = new int[4] { 0, 0, 0, 0 };
        /// <summary>
        /// price of upgrading lumber mill
        /// </summary>
        int[] lumberMillPrice = new int[4] { 0, 0, 0, 0 };
        /// <summary>
        /// price of upgrading quarrt
        /// </summary>
        int[] quarryPrice = new int[4] { 0, 0, 0, 0 };
        /// <summary>
        /// price of upgrading mine
        /// </summary>
        int[] minePrice = new int[4] { 0, 0, 0, 0 };
        /// <summary>
        /// price of building marketplace
        /// </summary>
        int[] marketplacePrice = new int[4] { 100, 50, 10, 50 };
        /// <summary>
        /// checks if marketplace was built
        /// </summary>
        bool marketplaceBuilt = false;
        /// <summary>
        /// market price of wood
        /// </summary>
        int woodPrice = 0;
        /// <summary>
        /// market price of stone
        /// </summary>
        int stonePrice = 0;
        /// <summary>
        /// market price of iron
        /// </summary>
        int ironPrice = 0;
        /// <summary>
        /// random used in calculation of gold gain
        /// </summary>
        int randGold = 0;
        /// <summary>
        /// chance of fire breaking out
        /// </summary>
        int randFire = 0;
        /// <summary>
        /// chance of quarry collapsing
        /// </summary>
        int randLandslide = 0;
        /// <summary>
        /// chance of mine collapsing
        /// </summary>
        int randCollapse = 0;
        /// <summary>
        /// chance of disease breaking out
        /// </summary>
        int randDisease = 0;
        /// <summary>
        /// checks if bad event happened this round
        /// </summary>
        int wasRandEvent = 0;
        /// <summary>
        /// player score
        /// </summary>
        int counterPlayerScore = 0;
        /// <summary>
        /// random number generator
        /// </summary>
        Random rnd = new Random();
        /// <summary>
        /// form with info about game
        /// </summary>
        FormHowToPlay formHowToPlay;
        /// <summary>
        /// form with info about winning game
        /// </summary>
        FormVictory formVictory;
        /// <summary>
        /// form with info about losing game
        /// </summary>
        FormDefeat formDefeat;


        /// <summary>
        /// resets colors of buttons
        /// </summary>
        void buttonColorReset()
        {
            buttonLivingQuarterlevelIncrease.BackColor = Color.FromArgb(240, 240, 240);
            buttonFarmslevelIncrease.BackColor = Color.FromArgb(240, 240, 240);
            buttonLumberMilllevelIncrease.BackColor = Color.FromArgb(240, 240, 240);
            buttonQuarrylevelIncrease.BackColor = Color.FromArgb(240, 240, 240);
            buttonMinelevelIncrease.BackColor = Color.FromArgb(240, 240, 240);
            if(marketplaceBuilt == true)
            {
                buttonBuyIron.BackColor = Color.FromArgb(240, 240, 240);
                buttonSellIron.BackColor = Color.FromArgb(240, 240, 240);
                buttonBuyStone.BackColor = Color.FromArgb(240, 240, 240);
                buttonSellStone.BackColor = Color.FromArgb(240, 240, 240);
                buttonBuyWood.BackColor = Color.FromArgb(240, 240, 240);
                buttonSellWood.BackColor = Color.FromArgb(240, 240, 240);
            }
        }
        /// <summary>
        /// prepares some of necessary counters and strings that need to be reset or adjusted
        /// </summary>
        void prepareCountersStrings()
        {
            wasBuilt = 0;
            wasRandEvent = 0;
            warehouseText = "";
            infrastructureText = "";
            priceText = "";
            disasterText = "";
            starvationText = "";
            populationText = "";
            counterPopulationStarved = 0;
            spareFood = 0;
        }
        /// <summary>
        /// updates resource count
        /// </summary>
        void updateResourceCount()
        {
            counterResourceFood = counterResourceGainFood;
            counterResourceWood += counterResourceGainWood;
            counterResourceStone += counterResourceGainStone;
            counterResourceIron += counterResourceGainIron;
        }
        /// <summary>
        /// updates resource gain
        /// </summary>
        void updateResourceGain()
        {
            counterResourceGainFood = 4 * counterFarmslevel;
            counterResourceGainWood = counterLumberMilllevel;
            counterResourceGainStone = counterQuarrylevel;
            counterResourceGainIron = counterMinelevel;
        }
        /// <summary>
        /// updates price of upgrading living quarters
        /// </summary>
        void updateLivingQuartersPrice()
        {
            if (counterLivingQuarterslevel < 10)
            {
                livingQuartersPrice[0] = 50 + 20 * counterLivingQuarterslevel;
                livingQuartersPrice[1] = 0 + 5 * counterLivingQuarterslevel;
                livingQuartersPrice[2] = 0;
                livingQuartersPrice[3] = 0;
            }
            if (counterLivingQuarterslevel < 20 && counterLivingQuarterslevel >= 10)
            {
                livingQuartersPrice[0] = 75 + 35 * counterLivingQuarterslevel;
                livingQuartersPrice[1] = 25 + 10 * counterLivingQuarterslevel;
                livingQuartersPrice[2] = counterLivingQuarterslevel;
                livingQuartersPrice[3] = 0;
            }
            if (counterLivingQuarterslevel >= 20)
            {
                livingQuartersPrice[0] = 100 + 50 * counterLivingQuarterslevel;
                livingQuartersPrice[1] = 75 + 15 * counterLivingQuarterslevel;
                livingQuartersPrice[2] = 40 + 5 * counterLivingQuarterslevel;
                livingQuartersPrice[3] = 5 * counterLivingQuarterslevel;
            }

        }
        /// <summary>
        /// updates price of upgrading farms
        /// </summary>
        void updateFarmsPrice()
        {
            if (counterFarmslevel < 10)
            {
                farmsPrice[0] = 50 + 20 * counterFarmslevel;
                farmsPrice[1] = 0 + 5 * counterFarmslevel;
                farmsPrice[2] = 0;
                farmsPrice[3] = 0;
            }
            if (counterFarmslevel < 20 && counterFarmslevel >= 10)
            {
                farmsPrice[0] = 75 + 35 * counterFarmslevel;
                farmsPrice[1] = 25 + 10 * counterFarmslevel;
                farmsPrice[2] = counterFarmslevel;
                farmsPrice[3] = 0;
            }
            if (counterFarmslevel >= 20)
            {
                farmsPrice[0] = 100 + 50 * counterFarmslevel;
                farmsPrice[1] = 50 + 25 * counterFarmslevel;
                farmsPrice[2] = 25 + 5 * counterFarmslevel;
                farmsPrice[3] = 5 * counterFarmslevel;
            }
        }
        /// <summary>
        /// updates price of upgrading lumber mill
        /// </summary>
        void updateLumerMillPrice()
        {
            if(counterLumberMilllevel < 10)
            {
                lumberMillPrice[0] = 50 + 20 * counterLumberMilllevel;
                lumberMillPrice[1] = 10 + counterLumberMilllevel;
                lumberMillPrice[2] = 0;
                lumberMillPrice[3] = 0;
            }
            if(counterLumberMilllevel < 20 && counterLumberMilllevel >= 10)
            {
                lumberMillPrice[0] = 75 + 30 * counterLumberMilllevel;
                lumberMillPrice[1] = 20 + 5 * counterLumberMilllevel;
                lumberMillPrice[2] = 5*counterLumberMilllevel;
                lumberMillPrice[3] = counterLumberMilllevel;
            }
            if(counterLumberMilllevel >= 20)
            {
                lumberMillPrice[0] = 100 + 50 * counterLumberMilllevel;
                lumberMillPrice[1] = 30 + 10*counterLumberMilllevel;
                lumberMillPrice[2] = 10 + 10*counterLumberMilllevel;
                lumberMillPrice[3] = 5*counterLumberMilllevel;
            }
        }
        /// <summary>
        /// updates price of upgrading quarry
        /// </summary>
        void updateQuarryPrice()
        {
            if(counterQuarrylevel <10)
            {
                quarryPrice[0] = 50 + 20 * counterQuarrylevel;
                quarryPrice[1] = 25 + 10 * counterQuarrylevel;
                quarryPrice[2] = 0;
                quarryPrice[3] = 0;
            }
            if(counterQuarrylevel < 20 && counterQuarrylevel >= 10)
            {
                quarryPrice[0] = 100 + 40 * counterQuarrylevel;
                quarryPrice[1] = 50 + 20 * counterQuarrylevel;
                quarryPrice[2] = 0;
                quarryPrice[3] = 0;
            }
            if(counterQuarrylevel >=20)
            {
                quarryPrice[0] = 150 + 65 * counterQuarrylevel;
                quarryPrice[1] = 50 + 30 * counterQuarrylevel;
                quarryPrice[2] = 25 + 10 * counterQuarrylevel;
                quarryPrice[3] = 10*counterQuarrylevel;
            }
        }
        /// <summary>
        /// updates price of upgrading mines
        /// </summary>
        void updateMinePrice()
        {
            if(counterMinelevel < 10)
            {
                minePrice[0] = 100 + 20 * counterMinelevel;
                minePrice[1] = 30 + 10 * counterMinelevel;
                minePrice[2] = 0;
                minePrice[3] = 0;
            }
            if(counterMinelevel < 20 && counterMinelevel >= 10)
            {
                minePrice[0] = 100 + 40 * counterMinelevel;
                minePrice[1] = 40 + 20 * counterMinelevel;
                minePrice[2] = 100 + 10 * counterMinelevel;
                minePrice[3] = 0;
            }
            if(counterMinelevel >= 20)
            {
                minePrice[0] = 100 + 60 * counterMinelevel;
                minePrice[1] = 30 + 10 * counterMinelevel;
                minePrice[2] = 100 + 25 * counterMinelevel;
                minePrice[3] = 20 * counterMinelevel;
            }    
        }

        void updateMarketPrices()
        {
            woodPrice = 40 + rnd.Next(11);
            stonePrice = 60 + rnd.Next(21);
            ironPrice = 80 + rnd.Next(41);
        }

        /// <summary>
        /// checks if player can purchase something
        /// </summary>
        /// <param name="wood"></param>
        /// <param name="stone"></param>
        /// <param name="iron"></param>
        /// <param name="gold"></param>
        /// <param name="woodPrice"></param>
        /// <param name="stonePrice"></param>
        /// <param name="ironPrice"></param>
        /// <param name="goldPrice"></param>
        /// <returns></returns>
        bool canPurchase(int wood, int stone, int iron, int gold, int woodUpgradePrice, int stoneUpgradePrice, int ironUpgradePrice, int goldUpgradePrice)
        {
            if (wood >= woodUpgradePrice && stone >= stoneUpgradePrice && iron >= ironUpgradePrice && gold >= goldUpgradePrice)
                return true;
            else
                return false;
        }

        /// <summary>
        /// updates buildings upgrade prices
        /// </summary>
        void updateBuildingsPrices()
        {
            updateLivingQuartersPrice();
            updateFarmsPrice();
            updateLumerMillPrice();
            updateQuarryPrice();
            updateMinePrice();
        }
            
        /// <summary>
        /// updates population and awards score
        /// </summary>
        void updatePopulationCount()
        {
            if (savedFood < 0 && savedFoodPast < 0 && counterResourceFood - counterPopulation < 0)
            {
                counterPopulationStarved = -(savedFood + savedFoodPast + counterResourceFood - counterPopulation) / 3;
                starvationText += "Your people are starving Sir!";
                counterPlayerScore -= counterPopulationStarved * 10;
            }

            if (savedFood > 0 && savedFoodPast > 0 && counterResourceFood - counterPopulation > 0 && counterTick % 10 == 0)
            {
                counterPopulation += 4;
                if (counterPopulation > 2 * counterLivingQuarterslevel) counterPopulation = 2 * counterLivingQuarterslevel;
                starvationText += "Your village prospers!";
                counterPlayerScore += 5;
            }
        }
        /// <summary>
        /// updates tabs
        /// </summary>
        void updateTabs()
        {
            labelInGameTime.Text = "Current game Time: " + counterTick.ToString();
            populationText += "Population: " + counterPopulation.ToString() + " / " + (counterLivingQuarterslevel * 2).ToString() + "\n";
            populationText += "Recent food balance: " + (counterResourceFood - counterPopulation).ToString() + " , " + savedFood.ToString() + " , " + savedFoodPast.ToString() + "\n";
            populationText += starvationText + "\n\n";
            populationText += "Score: " + counterPlayerScore.ToString();
            labelPopulation.Text = populationText;
            labelNews.Text = "Recent events: " + disasterText + "\n                   " + previousDisasterText + "\n                   " + oldDisasterText;
            warehouseText += "Warehouse:\n|\n| ---food: " + counterResourceFood.ToString() + " - " + counterPopulation.ToString()+ " [" + counterResourceGainFood.ToString() + " ]";
            warehouseText += "\n|\n| ---wood: " + counterResourceWood.ToString() + " [" + counterResourceGainWood.ToString() + "]";
            warehouseText += "\n|\n| ---stone: " + counterResourceStone.ToString() + " [" + counterResourceGainStone.ToString() + "]";
            warehouseText += "\n|\n| ---iron: " + counterResourceIron.ToString() + " [" + counterResourceGainIron.ToString() + "]";
            warehouseText += "\n|\nL--gold: " + counterResourceGold.ToString();
            labelWarehouse.Text = warehouseText;
            infrastructureText += "Infrastructure:\n|\n| ---living quarters level:" + counterLivingQuarterslevel;
            infrastructureText += "\n|\n| ---farms level:" + counterFarmslevel;
            infrastructureText += "\n|\n| ---lumber mill level:" + counterLumberMilllevel;
            infrastructureText += "\n|\n| ---quarry level:" + counterQuarrylevel;
            infrastructureText += "\n|\nL--mine level:" + counterMinelevel;
            labelInfrastructure.Text = infrastructureText;
            priceText += "Construcion costs[Wood] [Stone] [Iron] [Gold]:";
            priceText += "\n|\n| ---living quarters level[2]: " + livingQuartersPrice[0].ToString() + " " + livingQuartersPrice[1].ToString() + " " + livingQuartersPrice[2].ToString() + " " + livingQuartersPrice[3].ToString();
            priceText += "\n|\n| ---farms level[2]: " + farmsPrice[0].ToString() + " " + farmsPrice[1].ToString() + " " + farmsPrice[2].ToString() + " " + farmsPrice[3].ToString();
            priceText += "\n|\n| ---lumber mill level[2]: " + lumberMillPrice[0].ToString() + " " + lumberMillPrice[1].ToString() + " " + lumberMillPrice[2].ToString() + " " + lumberMillPrice[3].ToString();
            priceText += "\n|\n| ---quarry level[1]: " + quarryPrice[0].ToString() + " " + quarryPrice[1].ToString() + " " + quarryPrice[2].ToString() + " " + quarryPrice[3].ToString();
            priceText += "\n|\nL--mine level[1]: " + minePrice[0].ToString() + " " + minePrice[1].ToString() + " " + minePrice[2].ToString() + " " + minePrice[3].ToString();
            labelConstructionCosts.Text = priceText;
            if(marketplaceBuilt==true)
            {
                buttonSellWood.Text = "sell 50 wood for " + woodPrice.ToString() + " gold";
                buttonBuyWood.Text = "buy 50 wood for " + (2*woodPrice).ToString() + " gold";
                buttonSellStone.Text = "sell 50 stone for " + stonePrice.ToString() + " gold";
                buttonBuyStone.Text = "buy 50 stone for " + (2 * stonePrice).ToString() + " gold";
                buttonSellIron.Text = "sell 50 iron for " + ironPrice.ToString() + " gold";
                buttonBuyIron.Text = "buy 50 iron for " + (2 * ironPrice).ToString() + " gold";
            }
        }
        /// <summary>
        /// generates random events
        /// </summary>
        void randomEvents()
        {
            randCollapse = rnd.Next(1001);
            if (wasRandEvent == 0 && counterMinelevel > 20 && randCollapse < 200 * counterMinelevel / counterTick && randCollapse < 10)
            {
                counterMinelevel -= 10;
                counterResourceIron = Int32.Parse(Math.Round(0.75 * counterResourceIron).ToString());
                wasRandEvent = 1;
                disasterText += "Most dire news, our mine has collapse traping some of our finest miners inside";
            }
            randLandslide = rnd.Next(1001);
            if (wasRandEvent == 0 && counterQuarrylevel > 15 && randLandslide < 200 * counterQuarrylevel / counterTick && randLandslide < 20)
            {
                counterQuarrylevel -= 8;
                counterResourceStone = Int32.Parse(Math.Round(0.75 * counterResourceStone).ToString());
                wasRandEvent = 1;
                disasterText += "In the morning a there was a landslide, lets hope noone died...";
            }
            randFire = rnd.Next(1001);
            if (counterLumberMilllevel > 10 && counterResourceWood / 10 > 20 * counterLumberMilllevel / counterTick && randFire < 40) //przy 400 dzieje się często
            {
                counterLumberMilllevel -= 5;
                counterResourceWood = Int32.Parse(Math.Round(0.8 * counterResourceWood).ToString());
                counterFarmslevel -= 5;
                counterLivingQuarterslevel -= 5;
                wasRandEvent = 1;
                disasterText += "A terrible fire broke out in lumber mill last night";
            }
            randDisease = rnd.Next(1001);
            if (wasRandEvent == 0 && counterPopulation / (10 * counterLivingQuarterslevel) > 0.7 && randDisease < 60)
            {
                counterPopulation = ((100 - randDisease) / 100 * counterPopulation);
                wasRandEvent = 1;
                disasterText += "A plague wiped out majority of our population... ";
            }
            randGold = rnd.Next(101);
            if (counterMinelevel > randGold)
            {
                counterResourceGold += counterMinelevel - randGold;
                if (wasRandEvent == 1)
                    disasterText += " and " + (counterMinelevel - randGold).ToString() + " gold was found!!!";
                if (wasRandEvent == 0)
                    disasterText += (counterMinelevel - randGold).ToString() + " gold was found!!!";
                counterPlayerScore += counterMinelevel - randGold;
            }
        }

        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// function pauses/restarts game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTickStartStop_Click(object sender, EventArgs e)
        {
            counterTickStartStop++;
            if (counterTickStartStop == 2) counterTickStartStop = 0;
            if (counterTickStartStop == 0)
            {
                timerTick.Stop();
                buttonTickStartStop.Text = "unpause";
            }
            if (counterTickStartStop == 1)
            {
                timerTick.Start();
                buttonTickStartStop.Text = "pause";
            }
        }
        /// <summary>
        /// game funcion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTick_Tick(object sender, EventArgs e)
        {

            prepareCountersStrings();
            buttonColorReset();
            updateMarketPrices();
            randomEvents();

            if (counterResourceFood - counterPopulation > 0) spareFood = counterResourceFood - counterPopulation;

            updateResourceGain();
            updateResourceCount();
            updateBuildingsPrices();
            updatePopulationCount();
            updateTabs();

            savedFoodPast = savedFood;
            savedFood = counterResourceFood - counterPopulation;

            counterPopulation -= counterPopulationStarved;
            counterResourceFood -= counterPopulation;

            oldDisasterText = previousDisasterText;
            previousDisasterText = disasterText;

            if(counterPopulation<6 || counterPlayerScore < -100)
            {
                
                timerTick.Stop();
                buttonTickStartStop.Hide();
                buttonSetTickTimeSlow.Hide();
                buttonSetTickTimeDefault.Hide();
                buttonSetTickTimeFast.Hide();
                formDefeat = new FormDefeat();
                formDefeat.Show();
            }
            if(counterPlayerScore >= 2000)
            {
                timerTick.Stop();
                buttonTickStartStop.Hide();
                buttonSetTickTimeSlow.Hide();
                buttonSetTickTimeDefault.Hide();
                buttonSetTickTimeFast.Hide();
                formVictory = new FormVictory();
                formVictory.Show();
            }
            counterTick++;
        }
        /// <summary>
        /// sets game speed to fast
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetTickTimeFast_Click(object sender, EventArgs e)
        {
            timerTick.Interval = 500;
            buttonSetTickTimeSlow.BackColor = Color.FromArgb(240, 240, 240);
            buttonSetTickTimeDefault.BackColor = Color.FromArgb(240, 240, 240);
            buttonSetTickTimeFast.BackColor = Color.FromArgb(200, 200, 200);
        }
        /// <summary>
        /// sets game speed to default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetTickTimeDefault_Click(object sender, EventArgs e)
        {
            timerTick.Interval = 2000;
            buttonSetTickTimeSlow.BackColor = Color.FromArgb(240, 240, 240);
            buttonSetTickTimeDefault.BackColor = Color.FromArgb(200, 200, 200);
            buttonSetTickTimeFast.BackColor = Color.FromArgb(240, 240, 240);
        }
        /// <summary>
        /// sets game speed to slow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetTickTimeSlow_Click(object sender, EventArgs e)
        {
            timerTick.Interval = 8000;
            buttonSetTickTimeSlow.BackColor = Color.FromArgb(200, 200, 200);
            buttonSetTickTimeDefault.BackColor = Color.FromArgb(240, 240, 240);
            buttonSetTickTimeFast.BackColor = Color.FromArgb(240, 240, 240);
        }
        /// <summary>
        /// increase living quarters level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLivingQuarterlevelIncrease_Click(object sender, EventArgs e)
        {
            if (counterLivingQuarterslevel < 100 && wasBuilt != 1 && canPurchase(counterResourceWood,counterResourceStone,counterResourceIron,counterResourceGold,livingQuartersPrice[0], livingQuartersPrice[1], livingQuartersPrice[2], livingQuartersPrice[3]) ==true)
            { 
                counterLivingQuarterslevel++;
                wasBuilt++;
                buttonLivingQuarterlevelIncrease.BackColor = Color.Teal;
                counterResourceWood -= livingQuartersPrice[0];
                counterResourceStone -= livingQuartersPrice[1];
                counterResourceIron -= livingQuartersPrice[2];
                counterResourceGold -= livingQuartersPrice[3];
            }
            else
            {
                buttonLivingQuarterlevelIncrease.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// increase farms level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFarmslevelIncrease_Click(object sender, EventArgs e)
        {
            if (counterPopulation > counterFarmslevel && counterFarmslevel < 100 && wasBuilt != 1 && canPurchase(counterResourceWood, counterResourceStone, counterResourceIron, counterResourceGold, farmsPrice[0], farmsPrice[1], farmsPrice[2], farmsPrice[3]) == true)
            {
                counterFarmslevel++;
                wasBuilt++;
                buttonFarmslevelIncrease.BackColor = Color.Teal;
                counterResourceWood -= farmsPrice[0];
                counterResourceStone -= farmsPrice[1];
                counterResourceIron -= farmsPrice[2];
                counterResourceGold -= farmsPrice[3];
            }
            else
            {
                buttonFarmslevelIncrease.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// increase lumber mill level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLumberMilllevelIncrease_Click(object sender, EventArgs e)
        {
            if (counterPopulation > counterLumberMilllevel && counterLumberMilllevel < 100 && wasBuilt != 1 && canPurchase(counterResourceWood, counterResourceStone, counterResourceIron, counterResourceGold, lumberMillPrice[0], lumberMillPrice[1], lumberMillPrice[2], lumberMillPrice[3]) == true)
            {
                counterLumberMilllevel++;
                wasBuilt++;
                buttonLumberMilllevelIncrease.BackColor = Color.Teal;
                counterResourceWood -= lumberMillPrice[0];
                counterResourceStone -= lumberMillPrice[1];
                counterResourceIron -= lumberMillPrice[2];
                counterResourceGold -= lumberMillPrice[3];
            }
            else
            {
                buttonLumberMilllevelIncrease.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// increase quarry level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuarrylevelIncrease_Click(object sender, EventArgs e)
        {
            if (counterPopulation > counterQuarrylevel && counterQuarrylevel < 100 && wasBuilt != 1 && canPurchase(counterResourceWood, counterResourceStone, counterResourceIron, counterResourceGold, quarryPrice[0], quarryPrice[1], quarryPrice[2], quarryPrice[3]) == true)
            {
                counterQuarrylevel++;
                wasBuilt++;
                buttonQuarrylevelIncrease.BackColor = Color.Teal;
                counterResourceWood -= quarryPrice[0];
                counterResourceStone -= quarryPrice[1];
                counterResourceIron -= quarryPrice[2];
                counterResourceGold -= quarryPrice[3];
            }
            else
            {
                buttonQuarrylevelIncrease.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// increase mine level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMinelevelIncrease_Click(object sender, EventArgs e)
        {
            if (counterPopulation > counterMinelevel && counterMinelevel < 100 && wasBuilt != 1 && canPurchase(counterResourceWood, counterResourceStone, counterResourceIron, counterResourceGold, minePrice[0], minePrice[1], minePrice[2], minePrice[3]) == true)
            {
                counterMinelevel++;
                wasBuilt++;
                buttonMinelevelIncrease.BackColor = Color.Teal;
                counterResourceWood -= minePrice[0];
                counterResourceStone -= minePrice[1];
                counterResourceIron -= minePrice[2];
                counterResourceGold -= minePrice[3];
            }
            else
            {
                buttonMinelevelIncrease.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// enables marketplace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildMarketplace_Click(object sender, EventArgs e)
        {
            if(marketplaceBuilt == false && canPurchase(counterResourceWood, counterResourceStone, counterResourceIron, counterResourceGold, marketplacePrice[0], marketplacePrice[1], marketplacePrice[2], marketplacePrice[3]) == true)
            {
                marketplaceBuilt = true;
                counterResourceWood -= marketplacePrice[0];
                counterResourceStone -= marketplacePrice[1];
                counterResourceIron -= marketplacePrice[2];
                counterResourceGold -= marketplacePrice[3];
                buttonBuildMarketplace.Hide();
                labelMarketplace.Show();
                buttonSellWood.Show();
                buttonBuyWood.Show();
                buttonSellStone.Show();
                buttonBuyStone.Show();
                buttonSellIron.Show();
                buttonBuyIron.Show();
            }
            else
            {
                buttonBuildMarketplace.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// sell 50 wood for market price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSellWood_Click(object sender, EventArgs e)
        {
            if(marketplaceBuilt == true && canPurchase(counterResourceWood, counterResourceStone, counterResourceIron, counterResourceGold, 50, 0, 0, 0) == true)
            {
                counterResourceGold += woodPrice;
                counterResourceWood -= 50;
                buttonSellWood.BackColor = Color.Teal;
            }
            else
            {
                buttonSellWood.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// buy 50 wood for twice the market price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyWood_Click(object sender, EventArgs e)
        {
            if (marketplaceBuilt == true && canPurchase(counterResourceWood, counterResourceStone, counterResourceIron, counterResourceGold, 0, 0, 0, woodPrice) == true)
            {
                counterResourceGold -= 2*woodPrice;
                counterResourceWood += 50;
                buttonBuyWood.BackColor = Color.Teal;
            }
            else
            {
                buttonBuyWood.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// sell 50 stone for market price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSellStone_Click(object sender, EventArgs e)
        {
            if (marketplaceBuilt == true && canPurchase(counterResourceWood, counterResourceStone, counterResourceIron, counterResourceGold, 0, 50, 0, 0) == true)
            {
                counterResourceGold += stonePrice;
                counterResourceStone -= 50;
                buttonSellStone.BackColor = Color.Teal;
            }
            else
            {
                buttonSellStone.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// buy 50 stone for twice the market price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyStone_Click(object sender, EventArgs e)
        {
            if (marketplaceBuilt == true && canPurchase(counterResourceWood, counterResourceStone, counterResourceIron, counterResourceGold, 0, 0, 0, 2*stonePrice) == true)
            {
                counterResourceGold -= 2 * stonePrice;
                counterResourceStone += 50;
                buttonBuyStone.BackColor = Color.Teal;
            }
            else
            {
                buttonBuyStone.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// sell 50 iron for market price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSellIron_Click(object sender, EventArgs e)
        {
            if (marketplaceBuilt == true && canPurchase(counterResourceWood, counterResourceStone, counterResourceIron, counterResourceGold, 0, 0, 50, 0) == true)
            {
                counterResourceGold += ironPrice;
                counterResourceIron -= 50;
                buttonSellIron.BackColor = Color.Teal;
            }
            else
            {
                buttonSellIron.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// buy 50 iron for twice the market price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyIron_Click(object sender, EventArgs e)
        {
            if (marketplaceBuilt == true && canPurchase(counterResourceWood, counterResourceStone, counterResourceIron, counterResourceGold, 0, 0, 0, 2*ironPrice) == true)
            {
                counterResourceGold -= 2 * ironPrice;
                counterResourceIron += 50;
                buttonSellIron.BackColor = Color.Teal;
            }
            else
            {
                buttonSellIron.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// shows guide how to play game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHowToPlay_Click(object sender, EventArgs e)
        {
            formHowToPlay = new FormHowToPlay();
            formHowToPlay.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
