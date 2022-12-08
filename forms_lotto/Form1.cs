using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_lotto
{
    public partial class Form1 : Form
    {
        //setup Variables
        int[] lucky_nums = new int[6];
        Label[] r_labels = new Label[6];
        TextBox[] choose_textbox = new TextBox[6];

        //setup Randomiser
        Random rnd = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void b_roll_Click(object sender, EventArgs e)
        {
            //give each random number Lable an Lable array for later use in the Loop
            r_labels[0] = l_luckynum1;
            r_labels[1] = l_luckynum2;
            r_labels[2] = l_luckynum3;
            r_labels[3] = l_luckynum4;
            r_labels[4] = l_luckynum5;
            r_labels[5] = l_luckynum6;

            //give each written number Lable an array for later use in the Loop
            choose_textbox[0] = t_entrynum1;
            choose_textbox[1] = t_entrynum2;
            choose_textbox[2] = t_entrynum3;
            choose_textbox[3] = t_entrynum4;
            choose_textbox[4] = t_entrynum5;
            choose_textbox[5] = t_entrynum6;

            //give each Lable a Random Number
            for (int i = 0; i < 6; i++)
            {
                
                lucky_nums[i] = rnd.Next(1, 50);
                for(int j = 0; j < 6; j++)
                {            
                    if (lucky_nums[i] == lucky_nums[j] && i != j && i != 0)
                    {
                        i--;
                    }
                    r_labels[i].Text = lucky_nums[i].ToString();
                }
            }
            for(int i = 0; i < 6; i++)
            {
                bool colorLock = false;
                for (int j = 0; j < 6; j++)
                {
                    if (choose_textbox[i].Text == r_labels[j].Text && choose_textbox[i].Text != "")
                    {
                        choose_textbox[i].BackColor = Color.Green;
                        colorLock = true;
                    }
                    else if (colorLock == false)
                    {
                        choose_textbox[i].BackColor = Color.White;
                    }
                }
            }
        }
    }
}
