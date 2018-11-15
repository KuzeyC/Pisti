using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pisti
{
    public partial class InputName : Form
    {
        public InputName()
        {
            InitializeComponent();
            tbFinalScore.Text = Game.finalScore.ToString();
            tbDifficulty.Text = DBConnect.ConvertDifficulty(Game.difficulty);
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                DBConnect db = new DBConnect();
                db.Insert(tbName.Text);
                Close();
                Leaderboard leaderboard = new Leaderboard();
                leaderboard.Show();
            }
            else
            {
                MessageBox.Show("Enter a valid username.");
            }
        }
    }
}
