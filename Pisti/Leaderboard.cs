using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pisti
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton[] rbDifficulty = new RadioButton[4] { rbEasy, rbMedium, rbHard, rbExtreme};
            for (int i = 0; i <= 3; i++)
            {
                if (rbDifficulty[i].Checked)
                {
                    Game.difficulty = (i + 1);
                    DisplayLD();
                }
            }
        }
        
        private void bMenu_Click(object sender, EventArgs e)
        {
            Close();
            Program.menu.Show();
        }

        private void DisplayLD()
        {
            DBConnect dbConnect = new DBConnect();
            List<string>[] list = dbConnect.Select();

            dgDisplay.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = dgDisplay.Rows.Add();
                for (int j = 0; j < 4; j = j + 1)
                {
                    dgDisplay.Rows[number].Cells[j].Value = list[j][i];
                }
            }
        }
    }
}