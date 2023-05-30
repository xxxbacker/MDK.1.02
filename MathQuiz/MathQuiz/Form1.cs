using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classWork
{
    public partial class Form1 : Form
    {
        // Создаем случайный объект, рандомизатор 
        // для генерации случайных чисел.
        Random randomizer = new Random();

        // Создаем целочисленные переменные, которые хранят числа 
        // для сложения
        int addend1;
        int addend2;

        // для вычитания
        int minuend;
        int subtrahend;

        // для умножения
        int multiplicand;
        int multiplier;

        // для деления
        int dividend;
        int divisor;

        // Создаем целочисленную переменную,
        // Которая хранит оставшееся время.
        int timeLeft;

        // Начало теста и запуск таймера.
        public void StartTheQuiz()
        {
            // Генерируется два случайных числа
            // сохранение значений в переменных addend1 и addend2.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Преобразование двух сгенерированных чисел в строки.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // sum - это NumericUpDown.
            sum.Value = 0;

            // Решение задач
            // Вычитание
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // умножение
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;
            
            // деление
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Запуск таймера.
            // 
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        // Проверка истекшего времени в обработчике событий Tick.
        // Если время истекло или ответы указаны правильно, тест должен завершиться.
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // Если CheckTheAnswer() возвращает true,
                // таймер останавливается.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // Если CheckTheAnswer() возвращает false,
                // отсчет продолжается.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
                // Когда на таймере остается 5 сек, он меняет цвет на красный.
                if (timeLeft == 5)
                    timeLabel.BackColor = Color.Red;
            }
            else
            {
                // Таймер останавливается и вводятся ответы.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
                if (timeLeft == 0)
                    timeLabel.BackColor = SystemColors.Menu;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);            
            }
        }
    }
}
