using System;
using System.Windows.Forms;
using Languages.Implementation;
using Languages.Interfaces;
using PrimeCalculator.Properties;

namespace PrimeCalculator
{
    public partial class PrimeCalculator : Form
    {
        private readonly IPrimeCalc _calculator = new PrimeCalc();

        private readonly ILanguageManager _lm = new LanguageManager();

        public PrimeCalculator()
        {
            InitializeComponent();
            InitializeCaption();
            InitializeLanguageManager();
            LoadLanguagesToCombo();
        }

        private void InitializeCaption()
        {
            Text = Application.ProductName + @" " + Application.ProductVersion;
        }

        private void maskedTextBoxPrime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonPrimeCalc_Click(sender, e);
        }

        private void InitializeLanguageManager()
        {
            _lm.SetCurrentLanguage("de-DE");
            _lm.OnLanguageChanged += OnLanguageChanged;
        }

        private void LoadLanguagesToCombo()
        {
            foreach (var lang in _lm.GetLanguages())
                comboBoxLanguage.Items.Add(lang.Name);
            comboBoxLanguage.SelectedIndex = 0;
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _lm.SetCurrentLanguageFromName(comboBoxLanguage.SelectedItem.ToString());
        }

        private void OnLanguageChanged(object sender, EventArgs eventArgs)
        {
            buttonPrimeCalc.Text = _lm.GetCurrentLanguage().GetWord("CalculatePrime");
        }

        private void buttonPrimeCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int number;
                var isParsedSuccessfully = int.TryParse(maskedTextBoxPrime.Text, out number);
                if (isParsedSuccessfully)
                {
                    var isPrime = _calculator.Calc(number);
                    if (isPrime)
                        richTextBoxPrime.Text = number + Resources.IsAPrimeNumber;
                    else
                        richTextBoxPrime.Text = number + Resources.IsNoPrimeNumber;
                }
                else
                {
                    richTextBoxPrime.Text = number + Resources.IsNoPrimeNumber;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}