using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimPractice
{
    /// <summary>
    /// AimPraktika - WinForms igra za treniranje preciznosti
    /// </summary>
    public partial class Form1 : Form
    {
        // Konstante za igru
        private const int INITIAL_TIME = 30;
        private const int TARGET_POINTS = 10;
        private const int OBSTACLE_PENALTY = 5;
        private const int MISS_PENALTY = 1;
        private const int TARGET_BUTTON_SIZE = 80;
        private const int OBSTACLE_BUTTON_SIZE = 60;
        private const int BUTTON_MOVE_INTERVAL = 2350;
        private const int TIMER_INTERVAL = 1000;

        // Random generator za nasumične pozicije
        private Random random = new Random();

        // Varijable za praćenje stanja igre
        private int points = 0;
        private int timeRemaining = INITIAL_TIME;
        private int successfulHits = 0;
        private int missedClicks = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicijalizacija igre pri učitavanju forme
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Postavi inicijalne vrednosti labela
            label1.Text = "Poeni: 0";
            label2.Text = "Vreme: " + INITIAL_TIME;
            label3.Text = "Preciznost: 100%";

            // Podesi boju i veličinu dugmeta mete (zeleno)
            button1.BackColor = Color.Lime;
            button1.Size = new Size(TARGET_BUTTON_SIZE, TARGET_BUTTON_SIZE);

            // Podesi boju i veličinu prepreka (crvena)
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;

            button2.Size = new Size(OBSTACLE_BUTTON_SIZE, OBSTACLE_BUTTON_SIZE);
            button3.Size = new Size(OBSTACLE_BUTTON_SIZE, OBSTACLE_BUTTON_SIZE);
            button4.Size = new Size(OBSTACLE_BUTTON_SIZE, OBSTACLE_BUTTON_SIZE);
            button5.Size = new Size(OBSTACLE_BUTTON_SIZE, OBSTACLE_BUTTON_SIZE);

            // Pokreni tajmere
            timer1.Interval = TIMER_INTERVAL; // Tajmer za odbrojavanje vremena (svaku sekundu)
            timer1.Start();
            
            timer2.Interval = BUTTON_MOVE_INTERVAL; // Tajmer za pomeranje dugmadi
            timer2.Start();
        }

        /// <summary>
        /// Tajmer za odbrojavanje vremena (svake sekunde)
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeRemaining--;
            label2.Text = "Vreme: " + timeRemaining;

            // Ako je vreme isteklo, završi igru
            if (timeRemaining <= 0)
            {
                EndGame();
            }
        }

        /// <summary>
        /// Tajmer za nasumično pomeranje prepreka (svakih ~2.35 sekundi)
        /// </summary>
        private void timer2_Tick(object sender, EventArgs e)
        {
            // Pomeri sve prepreke na nove nasumične pozicije
            MoveButton(button2);
            MoveButton(button3);
            MoveButton(button4);
            MoveButton(button5);
        }

        /// <summary>
        /// Klik na metu (zeleno dugme) - Igrač je pogodio!
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // Dodaj poene
            points += TARGET_POINTS;
            successfulHits++;

            // Ažuriraj prikaz poena
            label1.Text = "Poeni: " + points;

            // Ažuriraj preciznost
            UpdateAccuracy();

            // Pomeri metu na novu poziciju
            MoveButton(button1);
        }

        /// <summary>
        /// Klik na prepreke (crvena dugmeta) - Igrač je pogriješio!
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            ProcessMiss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessMiss();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessMiss();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProcessMiss();
        }

        /// <summary>
        /// Obrada promašaja (klik na prepreku ili praznu površinu)
        /// </summary>
        private void ProcessMiss()
        {
            // Oduzmi poene
            points -= OBSTACLE_PENALTY;
            missedClicks++;

            // Ažuriraj prikaz poena
            label1.Text = "Poeni: " + points;

            // Ažuriraj preciznost
            UpdateAccuracy();
        }

        /// <summary>
        /// Ažuriraj procenat preciznosti
        /// Preciznost = (Uspešni pogoci / Ukupno klikova) * 100
        /// </summary>
        private void UpdateAccuracy()
        {
            int totalClicks = successfulHits + missedClicks;

            if (totalClicks > 0)
            {
                int accuracy = (successfulHits * 100) / totalClicks;
                label3.Text = "Preciznost: " + accuracy + "%";
            }
        }

        /// <summary>
        /// Pomeri dugme na nasumičnu poziciju u prozoru
        /// </summary>
        private void MoveButton(Button button)
        {
            int randomX = random.Next(0, this.ClientSize.Width - button.Width);
            int randomY = random.Next(0, this.ClientSize.Height - button.Height);

            button.Location = new Point(randomX, randomY);
        }

        /// <summary>
        /// Klik na praznu površinu (bilo gde na formi) - Igrač je promašio!
        /// </summary>
        private void Form1_Click(object sender, EventArgs e)
        {
            ProcessMiss();
        }

        /// <summary>
        /// Završi igru i prikaži rezultate
        /// </summary>
        private void EndGame()
        {
            // Zaustavi tajmere
            timer1.Stop();
            timer2.Stop();

            // Prikaži rezultate
            string gameOverMessage = $"Kraj igre!\n\n" +
                                   $"Poeni: {points}\n" +
                                   $"Uspešni pogoci: {successfulHits}\n" +
                                   $"Promašaji: {missedClicks}";

            MessageBox.Show(gameOverMessage, "Rezultati");

            // Zatvori aplikaciju
            Application.Exit();
        }
    }
}
