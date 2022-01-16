using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGeneratorForm : Form
    {
        public PasswordGeneratorForm()
        {
            InitializeComponent();
        }

        private void GeneratePasswordButton_Click(object sender, EventArgs e)
        {
            if (EnglishLettersCheckBox.Checked | CapitalEnglishLettersCheckBox.Checked | RussianLettersCheckBox.Checked | CapitalRussianLettersCheckBox.Checked | NumbersCheckBox.Checked | SpecialSymbolsCheckBox.Checked | AllOptionsCheckBox.Checked != false)
            {
                var Password = new StringBuilder();
                var random = new Random();
                var RussianLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                var CapitalRussianLetters = RussianLetters.ToUpper();
                var SpecialSymbols = "!@#$%^&*()[]|";
                for (int i = 0; i < PasswordLengthNumericUpDown.Value;)
                {
                    switch (random.Next(0, 6))
                    {
                        case 0:
                            if (EnglishLettersCheckBox.Checked || AllOptionsCheckBox.Checked)
                            {
                                Password.Append(Convert.ToChar(random.Next(97, 123)));
                                i++;
                            }
                            break;
                        case 1:
                            if (CapitalEnglishLettersCheckBox.Checked || AllOptionsCheckBox.Checked)
                            {
                                Password.Append(Convert.ToChar(random.Next(65, 91)));
                                i++;
                            }
                            break;
                        case 2:
                            if (RussianLettersCheckBox.Checked || AllOptionsCheckBox.Checked)
                            {
                                Password.Append(RussianLetters[random.Next(RussianLetters.Length)]);
                                i++;
                            }
                            break;
                        case 3:
                            if (CapitalRussianLettersCheckBox.Checked || AllOptionsCheckBox.Checked)
                            {
                                Password.Append(CapitalRussianLetters[random.Next(CapitalRussianLetters.Length)]);
                                i++;
                            }
                            break;
                        case 4:
                            if (NumbersCheckBox.Checked || AllOptionsCheckBox.Checked)
                            {
                                Password.Append(random.Next(0, 10).ToString());
                                i++;
                            }
                            break;
                        case 5:
                            if (SpecialSymbolsCheckBox.Checked || AllOptionsCheckBox.Checked)
                            {
                                Password.Append(SpecialSymbols[random.Next(SpecialSymbols.Length)]);
                                i++;
                            }
                            break;
                    }
                }
                PasswordResultTextBox.Text = Password.ToString();
            }
            else
            {
                MessageBox.Show("YOU DON'T CHOOSE ANY OPTION!", "OPTIONS DON'T CHOOSED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyPasswordButton_Click(object sender, EventArgs e)
        {
            if (PasswordResultTextBox.Text.Length != 0)
            {
                Clipboard.SetText(PasswordResultTextBox.Text);
            }
            else
            {
                MessageBox.Show("YOU DON'T GENERATE PASSWORD YET!", "PASSWORD DON`T GENERATED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AllOptionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var CheckedState = !(sender as CheckBox).Checked;
            if (!CheckedState)
            {
                EnglishLettersCheckBox.Checked = CheckedState;
                CapitalEnglishLettersCheckBox.Checked = CheckedState;
                RussianLettersCheckBox.Checked = CheckedState;
                CapitalRussianLettersCheckBox.Checked = CheckedState;
                NumbersCheckBox.Checked = CheckedState;
                SpecialSymbolsCheckBox.Checked = CheckedState;
            }

        }
        private void EnglishLettersCheckBox_Click(object sender, EventArgs e)
        {
            AllOptionsCheckBox.Checked = false;
        }
        private void CapitalEnglishLettersCheckBox_Click(object sender, EventArgs e)
        {
            AllOptionsCheckBox.Checked = false;
        }
        private void RussianLettersCheckBox_Click(object sender, EventArgs e)
        {
            AllOptionsCheckBox.Checked = false;
        }
        private void CapitalRussianLettersCheckBox_Click(object sender, EventArgs e)
        {
            AllOptionsCheckBox.Checked = false;
        }
        private void NumbersCheckBox_Click(object sender, EventArgs e)
        {
            AllOptionsCheckBox.Checked = false;
        }
        private void SpecialSymbolsCheckBox_Click(object sender, EventArgs e)
        {
            AllOptionsCheckBox.Checked = false;
        }

        private void GenerationResultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
