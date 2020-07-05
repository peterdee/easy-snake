using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Snake
{
    public partial class Form4Options : Form
    {
        public static bool UsePowerUps;
        public static bool ShowDevInfo;
        public static int DiffToTimer = 200;
        
        public Form4Options()
        {
            InitializeComponent();
            if (UsePowerUps == true) cbPower.Checked = true;
            if (UsePowerUps == false) cbPower.Checked = false;
            if (ShowDevInfo == true) cbDeveloper.Checked = true;
            if (ShowDevInfo == false) cbDeveloper.Checked = false;

            if (DiffToTimer == 260) rbEasy.Checked = true;
            if (DiffToTimer == 200) rbNormal.Checked = true;
            if (DiffToTimer == 140) rbHard.Checked = true;
            if (DiffToTimer == 80)  rbExtreme.Checked = true;
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        // POWER UP CHECK BOX
        private void cbPower_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPower.Checked == true) UsePowerUps = true;
            if (cbPower.Checked == false) UsePowerUps = false;
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        // SHOW DEVELOPER INFORMATION
        private void cbDeveloper_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDeveloper.Checked == true) ShowDevInfo = true;
            if (cbDeveloper.Checked == false) ShowDevInfo = false;
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        // EASY DIFFICULTY
        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEasy.Checked == true)
            {
                DiffToTimer = 260;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        // NORMAL DIFFICULTY (DEFAULT)
        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked == true)
            {
                DiffToTimer = 200;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        // HARD DIFFICULTY
        private void rbHard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHard.Checked == true)
            {
                DiffToTimer = 140;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        // EXTREME DIFFICULTY
        private void rbExtreme_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExtreme.Checked == true)
            {
                DiffToTimer = 80;
            }
        }
    }
}
