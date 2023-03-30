using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SudokuForm : Form
    {
        public SudokuForm()
        {
            InitializeComponent();

            createCells();

            startNewGame();
        }

        SudokuCell[,] cells = new SudokuCell[9, 9];

        /// <summary>
        /// Metoda tworzaca siatke gry 9x9 
        /// </summary>
        private void createCells()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cells[i, j] = new SudokuCell();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 30);
                    cells[i, j].Size = new Size(60, 60);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point(i * 60, j * 60);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;

                    cells[i, j].KeyPress += cell_keyPressed;

                    panel1.Controls.Add(cells[i, j]);
                }
            }
        }

        /// <summary>
        /// Metoda sluzaca do wstawiania cyfr do komorek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCell;

            // Jezeli komórka zostala wygenerowana przez gre
            if (cell.IsLocked)
                return;

            int value;

            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                if (value == 0)
                    cell.Clear();
                else
                    cell.Text = value.ToString();
                cell.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        /// <summary>
        /// Metoda wykonywana przy rozpoczynaniu nowej gry, wykonuje sie przy nacisnieciu przycisku nowej gry
        /// </summary>
        private void startNewGame()
        {
            loadValues();

            var hintsCount = 0;

            if (beginnerLevel.Checked)
                hintsCount = 45;
            else if (intermediateLevel.Checked)
                hintsCount = 30;
            else if (advancedLevel.Checked)
                hintsCount = 15;

            showRandomValuesHints(hintsCount);
        }

        /// <summary>
        /// Metoda czysci siatke i laduje nowe wartosci do komorek
        /// </summary>
        private void loadValues()
        {
            foreach (var cell in cells)
            {
                cell.Value = 0;
                cell.Clear();
            }

            findValueForNextCell(0, -1);
        }

        Random random = new Random();


        /// <summary>
        /// Funkcja uzupelniajaca wszystkie komorki cyframi, ktore nie sa widoczne dla gracza
        /// Dzieki temu podczas rozwiazywania sudoku poszczegolne komorki jedynie zmieniaja swoj typ na tekst aby zostaly wyswietone
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private bool findValueForNextCell(int i, int j)
        {
            if (++j > 8)
            {
                j = 0;

                if (++i > 8)
                    return true;
            }

            var value = 0;
            var numsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            do
            {
                if (numsLeft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }

                value = numsLeft[random.Next(0, numsLeft.Count)];
                cells[i, j].Value = value;

                numsLeft.Remove(value);
            }
            while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));

            return true;
        }

        /// <summary>
        /// Metoda sprawdzajaca poprawnosc wstawionych cyfr
        /// </summary>
        /// <param name="value"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool isValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != y && cells[x, i].Value == value)
                    return false;

                if (i != x && cells[i, y].Value == value)
                    return false;
            }

            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Funkcja uzupelniajaca poszczegolna ilosc komorek na podstawie poziomu trudnosci
        /// </summary>
        /// <param name="hintsCount"></param>
        private void showRandomValuesHints(int hintsCount)
        {
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);

                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.Black;
                cells[rX, rY].IsLocked = true;
            }
        }

        /// <summary>
        /// Funkcja uzupeniajaca wszystkie komorki sudoku poprawnymi wartosciami
        /// </summary>
        private void showCorrectValues()
        {
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    cells[i, j].Text = cells[i, j].Value.ToString();
                    cells[i, j].IsLocked = true;
                    cells[i, j].ForeColor = Color.Black;
                }
            }
            MessageBox.Show("Pola zostały wypełnione poprawnymi wartościami.");
        }

        /// <summary>
        /// Funkcja uzupelniajaca jedna losowa komorke
        /// </summary>
        private void showHint()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 9);
            int j = rnd.Next(0, 9);
            if (cells[i, j].IsLocked == false)
            {
                cells[i, j].Text = cells[i, j].Value.ToString();
                cells[i, j].IsLocked = true;
                cells[i, j].ForeColor = Color.Black;
                MessageBox.Show("Uzupełniono jedno pole.");
            }
            else
            {
                showHint();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Przycisk sprawdzajacy, czy sudoku zostalo poprawnie rozwiazane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkButton_Click(object sender, EventArgs e)
        {
            var wrongCells = new List<SudokuCell>();

            foreach (var cell in cells)
            {
                if (!string.Equals(cell.Value.ToString(), cell.Text))
                {
                    wrongCells.Add(cell);
                }
            }

            if (wrongCells.Any())
            {
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Jest parę błędów.");
            }
            else
            {
                MessageBox.Show("Udało Ci się rozwiązać zagadkę!");
            }
        }

        /// <summary>
        /// Przycisk czyszczacy plansze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var cell in cells)
            {
                if (cell.IsLocked == false)
                    cell.Clear();
            }
        }

        /// <summary>
        /// Przycisk rozpoczynajacy nowa gre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ngButton_Click(object sender, EventArgs e)
        {
            startNewGame();
        }

        /// <summary>
        /// Przycisk rozwiazujacy cala zagadke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resButton_Click(object sender, EventArgs e)
        {
            showCorrectValues();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Przycisk uzupelniajacy jedna komorke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hintButton_Click(object sender, EventArgs e)
        {
            showHint();
        }
    }
}