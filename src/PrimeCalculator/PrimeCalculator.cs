// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeCalculator.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The main form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PrimeCalculator
{
    using System;
    using System.Windows.Forms;

    using Languages.Implementation;
    using Languages.Interfaces;

    /// <summary>
    /// The main form.
    /// </summary>
    public partial class PrimeCalculator : Form
    {
        /// <summary>
        /// The calculator.
        /// </summary>
        private readonly IPrimeCalc calculator = new PrimeCalc();

        /// <summary>
        /// The language manager.
        /// </summary>
        private readonly ILanguageManager languageManager = new LanguageManager();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrimeCalculator"/> class.
        /// </summary>
        public PrimeCalculator()
        {
            this.InitializeComponent();
            this.InitializeCaption();
            this.InitializeLanguageManager();
            this.LoadLanguagesToCombo();
        }

        /// <summary>
        /// Initializes the caption.
        /// </summary>
        private void InitializeCaption()
        {
            this.Text = Application.ProductName + @" " + Application.ProductVersion;
        }

        /// <summary>
        /// Handles the key down event on the masked text box.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void MaskedTextBoxPrimeKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ButtonPrimeCalcClick(sender, e);
            }
        }

        /// <summary>
        /// Initializes the language manager.
        /// </summary>
        private void InitializeLanguageManager()
        {
            this.languageManager.SetCurrentLanguage("de-DE");
            this.languageManager.OnLanguageChanged += this.OnLanguageChanged;
        }

        /// <summary>
        /// Loads the languages to the combo box.
        /// </summary>
        private void LoadLanguagesToCombo()
        {
            foreach (var lang in this.languageManager.GetLanguages())
            {
                this.comboBoxLanguage.Items.Add(lang.Name);
            }

            this.comboBoxLanguage.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles the language changed event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void ComboBoxLanguageSelectedIndexChanged(object sender, EventArgs e)
        {
            this.languageManager.SetCurrentLanguageFromName(this.comboBoxLanguage.SelectedItem.ToString());
        }

        /// <summary>
        /// Handles the language changed event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void OnLanguageChanged(object sender, EventArgs e)
        {
            this.buttonPrimeCalc.Text = this.languageManager.GetCurrentLanguage().GetWord("CalculatePrime");
        }

        /// <summary>
        /// Handles the check button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void ButtonPrimeCalcClick(object sender, EventArgs e)
        {
            try
            {
                var isParsedSuccessfully = int.TryParse(this.maskedTextBoxPrime.Text, out var number);

                if (isParsedSuccessfully)
                {
                    var isPrime = this.calculator.Calc(number);
                    this.richTextBoxPrime.Text = isPrime ? $@"{number} {this.languageManager.GetWord("IsPrime")}" : $@"{number} {this.languageManager.GetWord("IsntPrime")}";
                }
                else
                {
                    this.richTextBoxPrime.Text = $@"{number} {this.languageManager.GetWord("IsntPrime")}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}