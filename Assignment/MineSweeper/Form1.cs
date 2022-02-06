using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form1 : Form
    {

        #region Global Varibles
        public int bombAmount, bombAmountLeft, width, length, x_start = 20, y_start = 80;
        public Zone[,] zones;
        public bool win;
        int time = 0;
        Random rnd = new Random();

        #endregion

        public Form1()
        {
            InitializeComponent();
            btn_Face.Location = new Point((Width / 2) + 10, 30);
        }

        #region Difficulty & Game Start
        // Set Difficulty
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }

        //Handles Chosen Difficulty
        public void startGame(int diff, int w, int l, int b)
        {
            removeboxes();
            if(diff == 1)
            {
                width = 10;
                length = 10;
                bombAmount = 15;
            }else if(diff == 2)
            {
                width = 20;
                length = 20;
                bombAmount = 75;
            }else if(diff == 3)
            {
                width = 40;
                length = 20;
                bombAmount = 145;
            }
            else
            {
                width = w;
                length = l;
                bombAmount = b;
            }

            Width = (x_start + 9) * 2 + width * 24;
            Height = y_start * 2 + length * 24;

            create();
        }
        #endregion

        #region Creation
        //Handles Creation of Everything
        private void create()
        {
            bombAmountLeft = bombAmount;
            lbl_t.Text = "Time: 0";
            lbl_b.Text = "Bombs: " + bombAmountLeft.ToString();
            time = 0;

            zones = new Zone[width, length];
            btn_Face.Location = new Point((Width / 2) + 10, 30);

            //zone location & creation
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < length; j++)
                {
                    zones[i,j] = createZones(x_start + 24 * i, y_start + 24 * j);
                }
            } 

            //Bomb zone Location creator
            for(int i = 0; i < bombAmount; i++)
            {
                int bombx = rnd.Next(0, width);
                int bomby = rnd.Next(0, length);

                        if(zones[bombx, bomby].State == true)
                        {
                            i--;
                        }
                        if(zones[bombx, bomby].State == false)
                        {
                            zones[bombx, bomby].State = true;
                        }
                    
                    bombsaround();                
            }
        }

        // Creates the zones TO hold mines etc
        private Zone createZones(int x, int y)
        {
            Zone zn = new Zone();
            Button btn = new Button();

            Controls.AddRange(new System.Windows.Forms.Control[] { btn, });
            btn.Size = new System.Drawing.Size(22, 22);
            btn.Location = new System.Drawing.Point(x, y);
            btn.Image = Image.FromFile(@"ms/Cell.png");
            btn.Visible = true;

            btn.MouseUp += new MouseEventHandler(rclick);
            btn.Click += new EventHandler(lClick);

            zn.btn = btn;
            zn.Revealed = false;
            zn.State = false;
            zn.Marked = false;
            zn.ZoneValue = 0;

            return zn;
        }

        #endregion

        #region bomb Stuff
        private int numb = 0;
        //bomb stuff
        private void bombsaround()
        {
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < length; j++)
                {
                    if(zones[i,j].State == false)
                    {
                        bombsaroundhelp(i, j);
                        if(numb > 0)
                        {
                            zones[i, j].ZoneValue = numb;
                        }
                        numb = 0;
                    }
                }
            }
        }

        //more bomb stuff
        private int bombsaroundhelp(int x, int y)
        {
            for(int i = -1; i < 2; i++)
            {
                for(int j = -1; j < 2; j++)
                {
                    if (i + x < width && j + y < length && i + x >= 0 && j + y >= 0)
                    {
                        if(zones[i + x, j + y].State)
                        {
                            numb++;
                        }
                    }
                }
            }
            return numb;
        }
        #endregion

        #region Other
        //Controls time && checks win statements
        private void timer1_Tick(object sender, EventArgs e)
        {
            int quantity = 0;
            time++;

            lbl_t.Text = "Time: " + time.ToString();
            lbl_b.Text = "Bombs: " + bombAmountLeft.ToString();

            if (bombAmountLeft <= 0)
            {
                for(int i = 0; i < width; i++)
                {
                    for(int j = 0; j < length; j++)
                    {
                        if(!zones[i, j].State && !zones[i, j].Revealed && !zones[i, j].Marked)
                        {
                            quantity++;
                        }
                    }
                }
            }

            if (bombAmountLeft == 0 && quantity == (width * length) - bombAmount)
            {
                win = true;
                timer1.Enabled = false;
            }else if(bombAmountLeft == 0 && quantity != (width * length) - bombAmount)
            {
                timer1.Enabled = false;
                time = 0;
                MessageBox.Show("You Lost!!");
                Revealboxes();

            }

            if (win)
            {
                timer1.Enabled = false;
                MessageBox.Show("Congratulations You Win!!!!");
                btn_Face.Image = Image.FromFile(@"ms/FaceW.png");
                Revealboxes();
            }
        }

        //Clears Board of Boxes
        private void removeboxes()
        {
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < length; j++)
                {
                    Controls.Remove(zones[i, j].btn);
                }
            }
        }

        //Reveals all boxes
        private void Revealboxes()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (!zones[i, j].State && !zones[i, j].Marked && zones[i, j].ZoneValue != 0)
                    {
                        try
                        {
                            zones[i, j].btn.Image = Image.FromFile(@"ms/" + zones[i, j].ZoneValue + ".png");
                            zones[i, j].Revealed = true;
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    else if (zones[i, j].State && !zones[i, j].Marked)
                    {
                        zones[i, j].btn.Image = Image.FromFile(@"ms/RevealedMineCell.png");
                        zones[i, j].Revealed = true;
                    } else if (zones[i, j].State && zones[i, j].Marked)
                    {
                        zones[i, j].btn.Image = Image.FromFile(@"ms/FlaggedCell.png");
                    }
                    else if (!zones[i, j].State && zones[i, j].Marked)
                    {
                        zones[i, j].btn.Image = Image.FromFile(@"ms/FlaggedWrongCell.png");
                        zones[i, j].Revealed = true;
                    }
                    else
                    {
                        zones[i, j].btn.Image = Image.FromFile(@"ms/EmptyCell.png");
                        zones[i, j].Revealed = true;
                    }
                }
            }
        }

        //When a PLayer Clicks on the face restart with current difficulty
        private void btn_Face_Click(object sender, EventArgs e)
        {
            win = false;
            removeboxes();
            create();

        }

        //Handles RigthClick object on boxes
        private void rclick(object sender, MouseEventArgs e)
        {
                Button click = sender as Button;

                int x = 0;
                int y = 0;

                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (click.Location.X == zones[i, j].btn.Location.X && click.Location.Y == zones[i, j].btn.Location.Y)
                        {
                            x = i;
                            y = j;
                        }
                    }
                }

            if (!zones[x,y].Revealed) { 
                if ( e.Button == MouseButtons.Right)
                {
                    if (timer1.Enabled == false)
                    {
                        timer1.Enabled = true;
                    }

                    if (bombAmountLeft > 0)
                    {
                        if (zones[x, y].Marked)
                        {
                            zones[x, y].Marked = false;
                            zones[x, y].btn.Image = Image.FromFile(@"ms/Cell.png");
                            bombAmountLeft++;
                        }
                        else if (!zones[x, y].Marked)
                        {
                            zones[x, y].Marked = true;
                            zones[x, y].btn.Image = Image.FromFile(@"ms/FlaggedCell.png");
                            bombAmountLeft--;
                        }
                    }
                    else
                    {

                    }
                }
            }
        }

        //Handles LeftClick on Boxes 
        //TO-DO Fix && Optomise
        private void lClick(object sender, EventArgs e)
        {
            Button click = sender as Button;

            int x = 0;
            int y = 0;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (click.Location.X == zones[i, j].btn.Location.X && click.Location.Y == zones[i, j].btn.Location.Y)
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            if (!zones[x, y].Revealed) {
                if (zones[x, y].State)
                {
                    timer1.Enabled = false;
                    zones[x, y].btn.Image = Image.FromFile(@"ms/ExplodedMineCell.png");
                    MessageBox.Show("You Lost!!");
                    Revealboxes();

                }
                else
                {
                    zones[x, y].Revealed = true;

                    if (timer1.Enabled == false)
                    {
                        timer1.Enabled = true;
                    }

                    try
                    {
                        zones[x, y].btn.Image = Image.FromFile(@"ms/" + zones[x, y].ZoneValue + ".png");
                    } catch (Exception ex)
                    {
                        clearempty();
                    }
                    zones[x, y].im = zones[x, y].btn.Image;
                }
            }
        }

        // Clears empty sqards around clicked ones TO-DO Optomise
        private void clearempty()
        {
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < length; j++)
                {
                    if (zones[i, j].ZoneValue == 0 && zones[i, j].Revealed)
                    {
                        clearemptyhelp(i, j);
                    }
                }
            }  
        }

        private void clearemptyhelp(int x, int y)
        {
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (i + x < width && j + y < length && i + x >= 0 && j + y >= 0)
                    {
                        if (!zones[i + x, j + y].State && zones[i + x, j + y].ZoneValue == 0) 
                        {
                            zones[i + x, j + y].btn.Image = Image.FromFile(@"ms/EmptyCell.png");
                            zones[i + x, j + y].Revealed = true;
                        }
                        else if (!zones[i + x, j + y].State && zones[i + x, j + y].ZoneValue != 0)
                        {
                            zones[i + x, j + y].btn.Image = Image.FromFile(@"ms/" + zones[i + x, j + y].ZoneValue + ".png");
                            zones[i + x, j + y].Revealed = true;
                        }
                    }
                }
            }
        }

        #endregion
    }
    public class Zone
    {
        public Button btn { get; set; } // button the player interacts with
        public bool State { get; set; } // whether it contains a mine or not.
        public bool Revealed { get; set; } // Whether the user has opened the zone
        public bool Marked { get; set; } // Whether the user has Marked it
        public int ZoneValue { get; set; } // The number written inside the zone representing the number of mines in the surrounding zones.
        public Image im { get; set; } // The Current Image of the Object
    }
}
