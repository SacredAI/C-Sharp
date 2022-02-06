using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoko
{
    public partial class Form1 : Form
    {
        #region Variables

        public event ShowCluesEventHandler ShowClues;
        public delegate void ShowCluesEventHandler(int[][] grid);
        public event ShowSolutionEventHandler ShowSolution;
        public delegate void ShowSolutionEventHandler(int[][] grid);

        private List<int>[] HRow = new List<int>[9];
        private List<int>[] VRow = new List<int>[9];
        private List<int>[] ThreeSquare = new List<int>[9];

        private int[][] grid = new int[9][];
        private bool inc = false;
        private bool guide = false;

        public int Time;
        #endregion

        public Form1()
        {
            InitializeComponent();
            btn_NewGame.Click += btn_NewGame_Click;
            btn_Answer.Click += btn_Answer_Click;
            DataGridView1.Paint += DataGridView1_Paint;
            cbo_GameLevel.SelectedIndexChanged += cbo_GameLevel_SelectedIndexChanged;
            ShowClues += game_ShowClues;
            ShowSolution += game_ShowSolution;
        }

        public Random r = new Random();
        public void NewGame(Random rn)
        {
            this.r = rn;
            timer1.Enabled = true;
            createNewGame();
        }

        private void initializeLists()
        {
            for (int x = 0; x <= 8; x++)
            {
                HRow[x] = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                VRow[x] = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                ThreeSquare[x] = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                int[] row = new int[9];
                grid[x] = row;
            }
        }

        private void createNewGame()
        {
            while (true)
            {
            break1:
                initializeLists();
                for (int y = 0; y <= 8; y++)
                {
                    for (int x = 0; x <= 8; x++)
                    {
                        int si = (y / 3) * 3 + (x / 3);
                        int[] useful = HRow[y].Intersect(VRow[x]).Intersect(ThreeSquare[si]).ToArray();
                        if (useful.Count() == 0)
                        {
                            goto break1;
                        }
                        int randomNumber = useful[this.r.Next(0, useful.Count())];
                        HRow[y].Remove(randomNumber);
                        VRow[x].Remove(randomNumber);
                        ThreeSquare[si].Remove(randomNumber);
                        grid[y][x] = randomNumber;
                        if (y == 8 & x == 8)
                        {
                            goto break2;
                        }
                    }
                }
            };
        break2:

            ShowClues.Invoke(grid);

        }


        public void showGridSolution()
        {
            ShowSolution.Invoke(grid);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridView1.Rows.Add(9);
            cbo_GameLevel.SelectedIndex = 0;
            btn_NewGame.PerformClick();
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            NewGame(r);
        }

        private void DataGridView1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 75, 0, 75, 228);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 150, 0, 150, 228);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, 66, 228, 66);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, 132, 228, 132);
        }

        private void btn_Answer_Click(object sender, EventArgs e)
        {
            showGridSolution();
        }

        private void cbo_GameLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_NewGame.PerformClick();
        }

        public void game_ShowClues(int[][] grid)
        {
            for (int y = 0; y <= 8; y++)
            {
                List<int> cells = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                for (int c = 1; c <= 9 - (5 - cbo_GameLevel.SelectedIndex); c++)
                {
                    int randomNumber = cells[r.Next(0, cells.Count())];
                    cells.Remove(randomNumber);
                }
                for (int x = 0; x <= 8; x++)
                {
                    if (cells.Contains(x + 1))
                    {
                        DataGridView1.Rows[y].Cells[x].Value = grid[y][x];
                        DataGridView1.Rows[y].Cells[x].Style.ForeColor = Color.Red;
                        DataGridView1.Rows[y].Cells[x].ReadOnly = true;
                    }
                    else
                    {
                        DataGridView1.Rows[y].Cells[x].Value = "";
                        DataGridView1.Rows[y].Cells[x].Style.ForeColor = Color.Black;
                        DataGridView1.Rows[y].Cells[x].ReadOnly = false;
                    }
                }
            }
        }

        public void game_ShowSolution(int[][] grid)
        {
            for (int y = 0; y <= 8; y++)
            {
                for (int x = 0; x <= 8; x++)
                {
                    if (DataGridView1.Rows[y].Cells[x].Style.ForeColor == Color.Black)
                    {
                        if (string.IsNullOrEmpty(DataGridView1.Rows[y].Cells[x].Value.ToString()))
                        {
                            DataGridView1.Rows[y].Cells[x].Style.ForeColor = Color.Blue;
                            DataGridView1.Rows[y].Cells[x].Value = grid[y][x];

                        }
                        else
                        {
                            if (grid[y][x].ToString() != DataGridView1.Rows[y].Cells[x].Value.ToString())
                            {
                                DataGridView1.Rows[y].Cells[x].Style.ForeColor = Color.Blue;
                                DataGridView1.Rows[y].Cells[x].Value = grid[y][x];
                            }
                        }
                    }
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (DataGridView1.Rows[x].Cells[y].Value.ToString() == btn.Text)
                    {
                        DataGridView1.Rows[x].Cells[y].Style.BackColor = Color.Gray;
                    }
                    else if (DataGridView1.Rows[x].Cells[y].Style.BackColor == Color.Gray && DataGridView1.Rows[x].Cells[y].Value.ToString() != btn.Text)
                    {
                        DataGridView1.Rows[x].Cells[y].Style.BackColor = Color.White;
                    }
                }
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time++;

            time.Text = "Time: " + Time.ToString();

            int amnt = 0;
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    try
                    {
                        if (DataGridView1.Rows[x].Cells[y].Value.ToString() == grid[y][x].ToString())
                        {
                            amnt++;
                        }
                    }
                    catch (NullReferenceException ex)
                    {
                        return;
                    }
                }
            }

            if (amnt == 81)
            {
                timer1.Enabled = false;
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        DataGridView1.Rows[x].Cells[y].Style.BackColor = Color.White;
                    }
                }
                MessageBox.Show("You Won!!!!");
            }

            if (inc)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (DataGridView1.Rows[i].Cells[j].Style.BackColor == Color.Gray)
                        {
                            DataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                        }
                        if (DataGridView1.Rows[i].Cells[j].Value.ToString() != grid[i][j].ToString() && DataGridView1.Rows[i].Cells[j].Value.ToString() != "")
                        {
                            DataGridView1.Rows[i].Cells[j].Style.BackColor = Color.OrangeRed;
                        }
                    }
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    DataGridView1.Rows[x].Cells[y].Style.BackColor = Color.White;
                }
            }
        }

        private void btn_Incorrect_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (inc)
            {
                inc = false;
                btn.BackColor = Color.White;
            }
            else
            {
                inc = true;
                btn.BackColor = Color.Gray;
            }
        }

        private void btn_guides_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (guide)
            {
                guide = false;
                btn.BackColor = Color.White;
            }
            else
            {
                guide = true;
                btn.BackColor = Color.Gray;
            }
        }
    }
}


