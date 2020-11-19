using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7_21
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();
        public int number = 0;
        public bool botEndOfTaking = false;
        public bool playerEndOfTaking = false;
        public bool gameEnded = false;

        public Form1()
        {
            InitializeComponent();

            btnTuz1.Visible = false;
            btnTuz10.Visible = false;
            lblTuz.Visible = false;

            btnTake.Visible = false;
            btnStart.Visible = true;
        }
        // после нажатия эта кнопка исчезает и появляется новая в том же месте
        // попробовал привязать handler на эту же кнопку, но чет мне так не понравилось
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
            btnTake.Visible = true;
            btnStart.Visible = false;
        }
        private void btnTake_Click(object sender, EventArgs e)
        {
            // БЕРЕТ ИГРОК
            if (!playerEndOfTaking) PlayerTaking();

            // БЕРЕТ БОТ
            if (!botEndOfTaking) BotTaking();

            // если бот уже закончил брать и у него меньше чем у игрока
            if (botEndOfTaking && (int.Parse(lblPlayer1.Text) > int.Parse(lblPlayer2.Text)))
            {
                EndGame(1);
            }


            // ФИНАЛЬНАЯ ПРОВЕРКА ЕСЛИ ОБА ИГРОКА ЗАКОНЧИЛИ БРАТЬ
            if (playerEndOfTaking && botEndOfTaking)
            {
                if (int.Parse(lblPlayer1.Text) > int.Parse(lblPlayer2.Text)) EndGame(1);
                else if (int.Parse(lblPlayer1.Text) < int.Parse(lblPlayer2.Text)) EndGame(2);
                else EndGame(0);
            }

        }


        private void butnTuz1_Click(object sender, EventArgs e)
        {
            Name1.Text = (int.Parse(Name1.Text) + 1).ToString();
            btnTuz1.Visible = false;
            btnTuz10.Visible = false;
            lblTuz.Visible = false;
        }
        private void butnTuz11_Click(object sender, EventArgs e)
        {
            Name1.Text = (int.Parse(Name1.Text) + 11).ToString();
            btnTuz1.Visible = false;
            btnTuz10.Visible = false;
            lblTuz.Visible = false;
        }


        // игрок перестает брать, и если бот не добрал то добирает
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnTake.Enabled = false;
            btnStart.Enabled = false;
            playerEndOfTaking = true;

            // пока у бота нет 17 карт он добирает
            while (Convert.ToInt32(lblPlayer2.Text) < 17)
            {
                BotTaking();
            }

            // ФИНАЛЬНАЯ ПРОВЕРКА ЕСЛИ ОБА ИГРОКА ЗАКОНЧИЛИ БРАТЬ
            if (int.Parse(lblPlayer1.Text) > int.Parse(lblPlayer2.Text)) EndGame(1);
            else if (int.Parse(lblPlayer1.Text) < int.Parse(lblPlayer2.Text)) EndGame(2);
            else EndGame(0);

        }
        // общее изменение состояний в момент начала игры
        private void StartGame()
        {
            lblPlayer1.Text = "0";
            lblPlayer2.Text = "0";
            gameEnded = false;

            lblTuz.Visible = false;
            btnTuz1.Visible = false;
            btnTuz10.Visible = false;
            btnStop.Visible = true;
            btnTake.Enabled = true;

            botEndOfTaking = false;
            playerEndOfTaking = false;

            lblMessage.Visible = false;
        }
        // общее изменение состояний в момент окончания игры
        // 0-ничья 1-выиграл игрок 2-выиграл бот
        private void EndGame(int win)
        {
            // если игра не закончилась то проверяю
            if (!gameEnded)
            {
                switch (win)
                {
                    case 0:
                        lblMessage.Text = "Ничья";
                        break;
                    case 1:
                        lblMessage.Text = "Вы выиграли";
                        break;
                    case 2:
                        lblMessage.Text = "Вы проиграли";
                        break;
                }
            }
            // ставлю флажок что игра закончилась
            gameEnded = true;
            lblMessage.Visible = true;
            btnTake.Visible = false;
            btnStart.Visible = true;
            btnStart.Enabled = true;
            btnStop.Visible = false;
        }

        /// <summary>
        /// работает напрямую с текущим значением, добавляет к нему зарандомленную карту
        /// и сразу же проверяет если перебор
        /// </summary>
        private void BotTaking()
        {
            // теперь рандомим боту
            int number = rnd.Next(2, 14);
            int retNum;

            if ((number >= 2) && (number <= 10))
            {
                retNum = number;
            }
            else if ((number > 10) && (number < 14)) // 11-13 валет=2 дама=3 король=4
            {
                retNum = number - 9;
            }
            else
            {
                // бот сам решает как нажать туза
                // если меньше 10 то +11 если больше то +1
                if (int.Parse(lblPlayer2.Text) <= 10)
                    retNum = 11;
                else retNum = 1;
            }

            // присваиваем значение
            lblPlayer2.Text = (int.Parse(lblPlayer2.Text) + retNum).ToString();

            // две проверки сразу, на то что бот перешел черту, или набрал 21 и выиграл
            if (int.Parse(lblPlayer2.Text) > 21) { EndGame(1); return; }
            if (int.Parse(lblPlayer2.Text) == 21) { EndGame(2); return; }
            // флажок на окончание добора
            if (int.Parse(lblPlayer2.Text) >= 17) botEndOfTaking = true;
        }

        /// <summary>
        /// работает напрямую с текущим значением, добавляет к нему зарандомленную карту
        /// и сразу же проверяет если перебор
        /// </summary>
        private void PlayerTaking()
        {
            // РАНДОМИМ СЕБЕ
            int number = rnd.Next(2, 14);
            int retNum = 0;
            if ((number >= 2) && (number <= 10))
            {
                retNum = number;
            }
            else if ((number > 10) && (number < 14)) // 11-13  валет=2 дама=3 король=4
            {
                retNum = number - 9;
            }
            else
            {
                btnTuz1.Visible = true;
                btnTuz10.Visible = true;
                lblTuz.Visible = true;
                btnTake.Enabled = false;
            }

            // прибавляем полученное значение
            lblPlayer1.Text = (int.Parse(lblPlayer1.Text) + retNum).ToString();

            // две проверки сразу, на то что игрок перешел черту, или набрал 21 и выиграл
            if (int.Parse(lblPlayer1.Text) > 21) { EndGame(2); return; }
            if (int.Parse(lblPlayer1.Text) == 21) { EndGame(1); return; }
            // если бот закончил брать и у игрока больше чем у бота то сразу вин
            if (botEndOfTaking && int.Parse(lblPlayer1.Text) > int.Parse(lblPlayer2.Text))
            {
                EndGame(1);
                return;
            }
        }

    }
}
