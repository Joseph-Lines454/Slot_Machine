using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace fruit_machineV1
{
    public partial class Form1 : Form
    {
        // Values
        public static Random RanNumber = new Random();
        decimal bank = 15.0m;
        decimal credit = 0m;
        int reel1 = 0;
        int reel2 = 0;
        int reel3 = 0;
        int holdNum = 0;
        int hold1num = 0;
        int hold2num = 0;
        int hold3num = 0;
        int lightconst = 0;
        
        bool lights1 = false;
        bool lights2 = false;
        bool lights3 = false;
        bool lightflash1 = false;
        bool lightflash2 = false;
        bool lightflash3 = false;
        bool lightstop1 = false;
        bool lightstop2 = false;
        bool lightstop3 = false;

        List <string> uploadvalues = new List<string> ();

        Bitmap[] images = { fruit_machineV1.Properties.Resources.apple, fruit_machineV1.Properties.Resources.bannana,
            fruit_machineV1.Properties.Resources.bar, fruit_machineV1.Properties.Resources.cherries,
            fruit_machineV1.Properties.Resources.grapes,fruit_machineV1.Properties.Resources.lemon,
            fruit_machineV1.Properties.Resources.orange,fruit_machineV1.Properties.Resources.watermelon,
            fruit_machineV1.Properties.Resources.seven
        };

        private SoundPlayer spin;
        private SoundPlayer winning;
        public Form1()
        {
            InitializeComponent();
            spin = new SoundPlayer (@"spin.wav");
            winning = new SoundPlayer(@"winning.wav");
        }
        // As soon as teh form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            //Displaying bank and credit values
            lblbank.Text = Convert.ToString(bank);
            lblcredit.Text = Convert.ToString(credit);
            // Timers Enabled state
            timer1.Enabled = false;
            timer2.Enabled = true;
            timer3.Enabled = false;
            timer4.Enabled = false;
            //Date and time function
            lbldate.Text = DateTime.Now.ToString();
            //Defult colours
            btnhold1.BackColor = Color.Pink;
            btnhold2.BackColor = Color.Pink;
            btnhold3.BackColor = Color.Pink;
            // Reel values before spinning
        }

        // If the user clicks the 10p button
        private void lblten_Click(object sender, EventArgs e)
        {
            lblbank.Text += " ";
            lblcredit.Text += " ";

            if (bank >= 0.10m)
            {
                lblcredit.BackColor = Color.Yellow;
                credit += 0.10m;
                bank -= 0.10m;

                lblbank.Text = Convert.ToString(bank);
                lblcredit.Text = Convert.ToString(credit);
                timer1.Enabled = false;
                lblspin.BackColor = Color.Lime;
            }
            // if the bank and/or credit is zero
            else
            {
                if (bank == 0.0m)
                {
                    lblbank.Text = "No money!!!";
                    lblbank.BackColor = Color.Red;
                }
                
                if (credit <= 0.10m)
                {
                    lblcredit.Text = "No credit!!!";
                    lblcredit.BackColor = Color.Red;
                } 
            }
        }

        // If the user clicks the 20p button
        private void lbltwenty_Click(object sender, EventArgs e)
        {
            lblbank.Text += " ";
            lblcredit.Text += " ";

            if (bank >= 0.20m)
            {
                lblcredit.BackColor = Color.Yellow;
                credit += 0.20m;
                bank -= 0.20m;

                lblbank.Text = Convert.ToString(bank);
                lblcredit.Text = Convert.ToString(credit);
                timer1.Enabled = false;
                lblspin.BackColor = Color.Green;
            }
            // if the bank and/or credit is zero
            else
            {
                if (bank == 0.0m)
                {
                    lblbank.Text = "No money!!!";
                    lblbank.BackColor = Color.Red;
                }

                if (credit <= 0.10m)
                {
                    lblcredit.Text = "No credit!!!";
                    lblcredit.BackColor = Color.Red;
                }
            }
        }

        // If the user clicks the 50p button
        private void lblfifty_Click(object sender, EventArgs e)
        {
            lblbank.Text += " ";
            lblcredit.Text += " ";

            if (bank >= 0.50m)
            {
                lblcredit.BackColor = Color.Yellow;
                credit += 0.50m;
                bank -= 0.50m;

                lblbank.Text = Convert.ToString(bank);
                lblcredit.Text = Convert.ToString(credit);
                timer1.Enabled = false;
                lblspin.BackColor = Color.Yellow;
            }
            // if the bank and/or credit is zero
            else
            {
                if (bank == 0.0m)
                {
                    lblbank.Text = "No money!!!";
                    lblbank.BackColor = Color.Red;
                }

                if (credit <= 0.10m)
                {
                    lblcredit.Text = "No credit!!!";
                    lblcredit.BackColor = Color.Red;
                }
            }
        }
        // If the user clicks the £1 button
        private void lblpound_Click(object sender, EventArgs e)
        {
            lblbank.Text += " ";
            lblcredit.Text += " ";
            if (bank >= 1.00m)
            {
                lblcredit.BackColor = Color.Yellow;
                credit += 1.00m;
                bank -= 1.00m;

                lblbank.Text = Convert.ToString(bank);
                lblcredit.Text = Convert.ToString(credit);
                timer1.Enabled = false;
                lblspin.BackColor = Color.Orange;
            }

            // if the bank and/or credit is zero
            else
            {
                if (bank == 0.0m)
                {
                    lblbank.Text = "No money!!!";
                    lblbank.BackColor = Color.Red;
                }

                if (credit <= 0.10m)
                {
                    lblcredit.Text = "No credit!!!";
                    lblcredit.BackColor = Color.Red;
                }
            }
        }
        // User clicks the spin button
        private void lblspin_Click(object sender, EventArgs e)
        {
            // User can only click the spin button if the credit is more than 20p
            if (credit >= 0.20m)
            {

                spin.Play();
                click = true;

                lblbank.BackColor = Color.Yellow;

                lblflashone.BackColor = Color.Pink;
                lblflashtwo.BackColor = Color.Pink;
                lblflashthree.BackColor = Color.Pink;
                lblflashfour.BackColor = Color.Pink;
                lblflashfive.BackColor = Color.Pink;
                lblflashsix.BackColor = Color.Pink;
                lblflashseven.BackColor = Color.Pink;

                // Random number chance for the hold buttons
                holdNum = RanNumber.Next(1, 6);

                // If the random number is three the buttons are enabled
                if (holdNum == 3)
                {
                    timer4.Enabled = true;
                    timer3.Enabled = true;
                    lightstop1 = true;
                    lightstop2 = true;
                    lightstop3 = true;
                }
                // If the random number is not three the buttons are disabled
                else if (holdNum != 3)
                {
                    
                    timer4.Enabled = false;
                    timer3.Enabled = false;
                    lightstop1 = false;
                    lightstop2 = false;
                    lightstop3 = false;
                }
             
                lblout.Text = " ";
                lblout.Text += holdNum;

                // If the lights1 value is false then reel1 is randomised
                if (lights1 == false)
                {
                    reel1 = RanNumber.Next(1,10);
                    lblreel1.Image = images[reel1 - 1];
                }
                // If the lights2 value is false then reel1 is randomised
                if (lights2 == false)
                {
                    reel2 = RanNumber.Next(1,10);
                    lblreel2.Image = images[reel2 - 1];
                }
                // If the lights3 value is false then reel1 is randomised
                if (lights3 == false)
                { 
                    reel3 = RanNumber.Next(1,10);
                    lblreel3.Image = images[reel3 - 1];
                }
                // credit is minused by 20
                credit -= 0.20m;
                lblcredit.Text = Convert.ToString(credit);
                // score values and reset
                score();
                reset();
            }

            else
            {
                if (bank == 0.0m)
                {
                    lblbank.Text = "No money!!!";
                    lblbank.BackColor = Color.Red;
                }

                if (credit <= 0.10m)
                {
                    lblcredit.Text = "No credit!!!";
                    lblcredit.BackColor = Color.Red;
                }
            }
        }
        // reset
        public void reset()
        {
            hold1num = 0;
            hold2num = 0;
            hold3num = 0;
            lights1 = false;
            lights2 = false;
            lights3 = false;
            btnhold1.BackColor = Color.Pink;
            btnhold2.BackColor = Color.Pink;
            btnhold3.BackColor = Color.Pink;
            lightflash1 = false;
            lightflash2 = false;
            lightflash3 = false;
        }
        // score if the user gets a jackpot and two in a row
        public void score()
        {
            if (reel1 == reel2 && reel2 == reel3)
            {
                bank += 1m;
                lbltext.Text += "Jackpot! You win £1" + Environment.NewLine;
                uploadvalues.Add("Jackpot! You win £1");
                lblbank.Text = Convert.ToString(bank);
                lblbank.BackColor = Color.Green;
                winning.Play();
            }

            else if (reel1 == reel2 || reel2 == reel3)
            {
                bank += 0.20m;
                lbltext.Text += "Two in a row! You win 20p" + Environment.NewLine;
                uploadvalues.Add("Two in a row! You win 20p");
                lblbank.Text = Convert.ToString(bank);
                lblbank.BackColor = Color.Green;
                winning.Play();
            }
            reset();
        }

        bool onOrOff = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            onOrOff = !onOrOff;

            if (onOrOff == true)
            {
                lblspin.BackColor = Color.Lime;
            }

            if (onOrOff == false)
            {
                lblspin.BackColor = Color.Green;
            }
        }
        // This is for the flashing logo. This makes it flash constantly
        bool colours = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            colours = !colours;

            if (colours == true)
            {
                lbllogo1.ForeColor = Color.Red;
                lbllogo2.ForeColor = Color.Yellow;
                lbllogo3.ForeColor = Color.Blue;
                lbllogo4.ForeColor = Color.Violet;
            }

            if (colours == false)
            {
                lbllogo1.ForeColor = Color.Green;
                lbllogo2.ForeColor = Color.Purple;
                lbllogo3.ForeColor = Color.Orange;
                lbllogo4.ForeColor = Color.Brown;
            }
        }
        // This is when the hold button is unselected, we put 
        private void flashreset()
        {
            lightflash1 = false;
            lightflash2 = false;
            lightflash3 = false;
        }
        // Hold button one
        private void btnhold1_Click(object sender, EventArgs e)
        {
            flashreset();
            hold1num++;
            // Odd and even numbers determine wether the number is on or off
            if (hold1num % 2 == 0)
            {
                btnhold1.BackColor = Color.Pink;
                if (holdNum == 3 && credit >= 0.20m)
                {
                    lights1 = false;
                    lightstop1 = true;
                    btnhold1.BackColor = Color.Pink;
                }
            }

            else
            {
                btnhold1.BackColor = Color.Pink;
                if (holdNum == 3 && credit >= 0.20m)
                {
                    lights1 = true;
                    lightstop1 = false;
                    btnhold1.BackColor = Color.Pink;
                }
            } 
        }

        // Hold button two
        private void hold2_Click(object sender, EventArgs e)
        {
            flashreset();
            hold2num++;
            // Odd and even numbers determine wether the number is on or off
            if (hold2num % 2 == 0)
            {
                btnhold2.BackColor = Color.Pink;
                if (holdNum == 3 && credit >= 0.20m)
                {
                    lights2 = false;
                    lightstop2 = true;
                    btnhold2.BackColor = Color.Pink;
                }
            }

            else
            {
                btnhold2.BackColor = Color.Pink;
                if (holdNum == 3 && credit >= 0.20m)
                {
                    lights2 = true;
                    lightstop2 = false;
                    btnhold2.BackColor = Color.Pink;
                }
            }
        }

        // hold button three
        private void btnhold3_Click(object sender, EventArgs e)
        {
            flashreset();
            hold3num++;
            // Odd and even numbers determine wether the number is on or off
            if (hold3num % 2 == 0)
            {
                btnhold3.BackColor = Color.Pink;
                if (holdNum == 3 && credit >= 0.20m)
                {
                    lights3 = false;
                    lightstop3 = true;
                    btnhold3.BackColor = Color.Pink;
                }
            }

            else
            {
                btnhold3.BackColor = Color.Pink;
                if (holdNum == 3 && credit >= 0.20m)
                {
                    lights3 = true;
                    lightstop3 = false;
                    btnhold3.BackColor = Color.Pink;
                }
            }   
        }
        // To make the buttons flash continusly on and off
        private void timer3_Tick(object sender, EventArgs e)
        {
            // if the user gets two buttons in a row
            if (reel1 == reel2 || reel2 == reel3)
            {
                // if the random number is three
                while (holdNum == 3)
                {
                    holdNum = RanNumber.Next(1, 6);
                }
            }
            // if the user gets a jackpot
            else if (reel1 == reel2 && reel2 == reel3)
            {
                // if the random number is three
                while (holdNum == 3)
                {
                    holdNum = RanNumber.Next(1, 6);
                }
            }
            // if the user dosent get three with a jackpot or two buttons in a row
            // If the hold num is 3 and credit 20p and up, then the user can choose the hold buttons
            else
            {

                if (holdNum == 3 && lightstop1 == true && credit >= 0.20m)
                {
                    lightflash1 = !lightflash1;

                    if (lightflash1 == true)
                    {
                        btnhold1.BackColor = Color.Turquoise;
                    }

                    if (lightflash1 == false)
                    {
                        btnhold1.BackColor = Color.Pink;
                    }
                }

                if (holdNum == 3 && lightstop2 == true && credit >= 0.20m)
                {
                    lightflash2 = !lightflash2;

                    if (lightflash2 == true)
                    {
                        btnhold2.BackColor = Color.Turquoise;
                    }

                    if (lightflash2 == false)
                    {
                        btnhold2.BackColor = Color.Pink;
                    }
                }
               
                if (holdNum == 3 && lightstop3 == true && credit >= 0.20m)
                {
                    lightflash3 = !lightflash3;

                    if (lightflash3 == true)
                    {
                        btnhold3.BackColor = Color.Turquoise;
                    }

                    if (lightflash3 == false)
                    {
                        btnhold3.BackColor = Color.Pink;
                    }
                }
            }
        }



        // These try and catch statments are a example of data validation. This catches the error.
        private void saveinfo_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream stream = new FileStream("happy1.txt", FileMode.Open);
                StreamWriter writer = new StreamWriter(stream);

                foreach (string values in uploadvalues)
                {
                    writer.WriteLine(values);
                }
                writer.BaseStream.Seek(0, SeekOrigin.End);
                writer.Close();
                stream.Close();
            }

            catch
            {
                lbltext.Text += "Saving to the file does not work" + Environment.NewLine;
            } 
        }

        private void openinfo_Click(object sender, EventArgs e)
        {
            try
            {
                uploadvalues.Clear();
                lbltext.Clear();
                string[] lines = File.ReadAllLines(@"happy1.txt");

                foreach (string line in lines)
                {
                    lbltext.Text += line + Environment.NewLine;
                }
            }
            catch
            {
                lbltext.Text += "You can not open the File" + Environment.NewLine;
            }
        }
        bool down = false;
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (credit >= 0.20m)
            {
                if (down == false)
                {
                    lightconst++;
                }
                if (down != false)
                {
                    lightconst--;
                    lblflashone.BackColor = Color.Pink;
                    lblflashtwo.BackColor = Color.Pink;
                    lblflashthree.BackColor = Color.Pink;
                    lblflashfour.BackColor = Color.Pink;
                    lblflashfive.BackColor = Color.Pink;
                    lblflashsix.BackColor = Color.Pink;
                    lblflashseven.BackColor = Color.Pink;
                }
                if (lightconst == 1)
                {
                    lblflashone.BackColor = Color.Green;
                    down = false;
                }
                if (lightconst == 2)
                {
                    lblflashtwo.BackColor = Color.Green;
                    lblflashone.BackColor = Color.Pink;
                }
                if (lightconst == 3)
                {
                    lblflashthree.BackColor = Color.Green;
                    lblflashtwo.BackColor = Color.Pink;
                }
                if (lightconst == 4)
                {
                    lblflashfour.BackColor = Color.Green;
                    lblflashthree.BackColor = Color.Pink;
                }
                if (lightconst == 5)
                {
                    lblflashfive.BackColor = Color.Green;
                    lblflashfour.BackColor = Color.Pink;
                }
                if (lightconst == 6)
                {
                    lblflashsix.BackColor = Color.Green;
                    lblflashfive.BackColor = Color.Pink;
                }
                if (lightconst == 7)
                {
                    lblflashseven.BackColor = Color.Green;
                    lblflashsix.BackColor = Color.Pink;
                    down = true;
                }
            }  
        }

        bool click = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (click == true)
            {
                if (credit >= 0.20m)
                {
                    timer4.Enabled = false;
                    if (lightconst == 4)
                    {
                        click = false;
                        lbltext.Text += "You won 40p!!" + Environment.NewLine;
                        bank += 0.40m;
                        uploadvalues.Add("You Won 40p");
                        lblbank.Text = Convert.ToString(bank);
                        winning.Play();
                    }
                }
            }

        }
    }
}
