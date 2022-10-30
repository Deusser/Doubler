using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{
    public partial class Main : Form
    {

        private Random random = new Random();
        private int computernumber;
        private int usernumber;
        private int countnumber;


        public Main()
        {

            InitializeComponent();
            labelusernumber.Parent = pictureBox1;
            labelusernumber.BackColor = Color.Transparent;
            labelcompnumber.Parent = pictureBox1;
            labelcompnumber.BackColor = Color.Transparent;
            labelcount.Parent = pictureBox1;
            labelcount.BackColor = Color.Transparent;
            labelcountnumber.Parent = pictureBox1;
            labelcountnumber.BackColor = Color.Transparent;

            GameStart();
        }

        private void UpdateGameState(int usernumber)
        {
            labelusernumber.Text = $"Текущее число: {usernumber}";
        }
        private void UpdateGameState(int usernumber, int computernumber)
        {
            UpdateGameState(usernumber);
            this.computernumber = computernumber;
            labelcompnumber.Text = $"Получите число: {computernumber}";
        }
        private void UpdateGameCount(int countnumber)
        {
            labelcountnumber.Text = $"{countnumber}";
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            UpdateGameState(++usernumber);
            UpdateGameCount(++countnumber);
            CheckWin();
        }

        private void buttonmultiple_Click(object sender, EventArgs e)
        {
            UpdateGameState(usernumber *= 2);
            UpdateGameCount(++countnumber);
            CheckWin();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            UpdateGameState(usernumber *= 0, random.Next(20));
            UpdateGameCount(countnumber *= 0);
            CheckWin();
        }

        private void CheckWin()
        {
            if (usernumber == computernumber)
            {
                MessageBox.Show("Вы успешно завершили игру!", "Doubler The Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Хотите еще раунд?", "Doubler The Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    UpdateGameCount(countnumber *= 0);
                    UpdateGameState(usernumber *= 0, random.Next(20));
                }
                else
                {
                    Close();
                }

            }
        }
        private void GameStart()
        {
            if (MessageBox.Show("Начать игру?", "Doubler The Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
            {
                UpdateGameCount(countnumber *= 0);
                UpdateGameState(usernumber *= 0, random.Next(20));
            }
            else
            {
                Close();
            }
        }

        private void labelcompnumber_Click(object sender, EventArgs e)
        {

        }

        private void labelcountnumber_Click(object sender, EventArgs e)
        {

        }
    }
}
