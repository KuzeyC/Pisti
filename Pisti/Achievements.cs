using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pisti
{
    public partial class Achievements : Form
    {
        public Achievements()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("Achievements.txt");
            string currentAchievements = sr.ReadToEnd();
            sr.Close();
            CheckBox[] cbAchievement = new CheckBox[11] { cbAchievement1, cbAchievement2, cbAchievement3, cbAchievement4, cbAchievement5, cbAchievement6, cbAchievement7, cbAchievement8, cbAchievement9, cbAchievement10, cbAchievement11 };
            for (int i = 0; i <= cbAchievement.Length; i++)
            {
                if (currentAchievements.Contains("a" + (i + 1)))
                {
                    cbAchievement[i].Checked = true;
                }
            }
        }
    }
}
