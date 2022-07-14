using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace vs_yoketoru2022
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int SpeedMax = 10;
        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] Chrs = new Label[ChrMax];
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;

        const string PlayerText = "○";
        const string EnemyText = "▲";
        const string ItemText = "□";

        static Random rand=new Random();

        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear,
        }
        State currentState = State.None;
        State nextState = State.Title;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < ChrMax; i++)
            {
                Chrs[i] = new Label();
                Chrs[i].AutoSize = true;
                if (i == PlayerIndex)
                {
                    Chrs[i].Text = PlayerText;
                }
                else if (i < ItemIndex)
                {
                    Chrs[i].Text = EnemyText;
                }
                else
                {
                    Chrs[i].Text = ItemText;
                }
                Chrs[i].Font = tempL.Font;
                Controls.Add(Chrs[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nextState != State.None)
            {
                initProc();
            }

            if (isDebug)
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if (GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }

            if (currentState == State.Game)
            {
                updateGames();
            }
        }

        void updateGames()
        {
            Point mp = PointToClient(MousePosition);
            /*
            ChrMax[PlayerIndex].Left = mp.X - ChrMax[PlayerIndex].Width / 2;
            ChrMax[PlayerIndex].Top = mp.X - ChrMax[PlayerIndex].Height / 2;
            */
            for(int i = EnemyIndex;i<ChrMax;i++)
            {
                Chrs[i].Left += vx[i];
                Chrs[i].Top += vy[i];
            }
        }

        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    titieLb.Visible = true;
                    titieBt.Visible = true;
                    crL.Visible = true;
                    scoreL.Visible = false;
                    timeL.Visible = false;
                    overBt.Visible = false;
                    clearL.Visible = false;
                    overLb.Visible = false;
                    break;
            }
        }

        private void titleBt_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
        private void overBt_click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
