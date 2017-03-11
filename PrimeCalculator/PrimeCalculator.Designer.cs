namespace PrimeCalculator
{
    partial class PrimeCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimeCalculator));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxPrime = new System.Windows.Forms.RichTextBox();
            this.buttonPrimeCalc = new System.Windows.Forms.Button();
            this.maskedTextBoxPrime = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxPrime, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrimeCalc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxPrime, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxLanguage, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 192);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // richTextBoxPrime
            // 
            this.richTextBoxPrime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxPrime.Location = new System.Drawing.Point(3, 93);
            this.richTextBoxPrime.Name = "richTextBoxPrime";
            this.richTextBoxPrime.ReadOnly = true;
            this.richTextBoxPrime.Size = new System.Drawing.Size(346, 126);
            this.richTextBoxPrime.TabIndex = 2;
            this.richTextBoxPrime.Text = "";
            // 
            // buttonPrimeCalc
            // 
            this.buttonPrimeCalc.Location = new System.Drawing.Point(3, 63);
            this.buttonPrimeCalc.Name = "buttonPrimeCalc";
            this.buttonPrimeCalc.Size = new System.Drawing.Size(109, 23);
            this.buttonPrimeCalc.TabIndex = 1;
            this.buttonPrimeCalc.Text = "Calculate prime";
            this.buttonPrimeCalc.UseVisualStyleBackColor = true;
            this.buttonPrimeCalc.Click += new System.EventHandler(this.buttonPrimeCalc_Click);
            // 
            // maskedTextBoxPrime
            // 
            this.maskedTextBoxPrime.Location = new System.Drawing.Point(3, 33);
            this.maskedTextBoxPrime.Name = "maskedTextBoxPrime";
            this.maskedTextBoxPrime.Size = new System.Drawing.Size(109, 20);
            this.maskedTextBoxPrime.TabIndex = 0;
            this.maskedTextBoxPrime.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxPrime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBoxPrime_KeyDown);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(3, 3);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLanguage.TabIndex = 3;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // PrimeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 192);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrimeCalculator";
            this.Text = "PrimeCalculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrime;
        private System.Windows.Forms.Button buttonPrimeCalc;
        private System.Windows.Forms.RichTextBox richTextBoxPrime;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
    }
}