namespace PasswordGenerator
{
    partial class PasswordGeneratorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PasswordResultTextBox = new System.Windows.Forms.TextBox();
            this.GeneratePasswordButton = new System.Windows.Forms.Button();
            this.EnglishLettersCheckBox = new System.Windows.Forms.CheckBox();
            this.CapitalEnglishLettersCheckBox = new System.Windows.Forms.CheckBox();
            this.RussianLettersCheckBox = new System.Windows.Forms.CheckBox();
            this.CapitalRussianLettersCheckBox = new System.Windows.Forms.CheckBox();
            this.NumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.SpecialSymbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.SelectPasswordSizeLabel = new System.Windows.Forms.Label();
            this.SelectPasswordOptionsLabel = new System.Windows.Forms.Label();
            this.GenerationResultLabel = new System.Windows.Forms.Label();
            this.CopyPasswordButton = new System.Windows.Forms.Button();
            this.AllOptionsCheckBox = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordLengthNumericUpDown
            // 
            this.PasswordLengthNumericUpDown.Location = new System.Drawing.Point(34, 82);
            this.PasswordLengthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PasswordLengthNumericUpDown.Name = "PasswordLengthNumericUpDown";
            this.PasswordLengthNumericUpDown.Size = new System.Drawing.Size(135, 20);
            this.PasswordLengthNumericUpDown.TabIndex = 0;
            this.PasswordLengthNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // PasswordResultTextBox
            // 
            this.PasswordResultTextBox.Location = new System.Drawing.Point(313, 82);
            this.PasswordResultTextBox.Name = "PasswordResultTextBox";
            this.PasswordResultTextBox.ReadOnly = true;
            this.PasswordResultTextBox.Size = new System.Drawing.Size(670, 20);
            this.PasswordResultTextBox.TabIndex = 1;
            // 
            // GeneratePasswordButton
            // 
            this.GeneratePasswordButton.Location = new System.Drawing.Point(734, 333);
            this.GeneratePasswordButton.Name = "GeneratePasswordButton";
            this.GeneratePasswordButton.Size = new System.Drawing.Size(120, 38);
            this.GeneratePasswordButton.TabIndex = 2;
            this.GeneratePasswordButton.Text = "Сгенерировать крутой пароль";
            this.GeneratePasswordButton.UseVisualStyleBackColor = true;
            this.GeneratePasswordButton.Click += new System.EventHandler(this.GeneratePasswordButton_Click);
            // 
            // EnglishLettersCheckBox
            // 
            this.EnglishLettersCheckBox.AutoSize = true;
            this.EnglishLettersCheckBox.Location = new System.Drawing.Point(34, 189);
            this.EnglishLettersCheckBox.Name = "EnglishLettersCheckBox";
            this.EnglishLettersCheckBox.Size = new System.Drawing.Size(120, 17);
            this.EnglishLettersCheckBox.TabIndex = 3;
            this.EnglishLettersCheckBox.Text = "Английские буквы";
            this.EnglishLettersCheckBox.UseVisualStyleBackColor = true;
            this.EnglishLettersCheckBox.Click += new System.EventHandler(this.EnglishLettersCheckBox_Click);
            // 
            // CapitalEnglishLettersCheckBox
            // 
            this.CapitalEnglishLettersCheckBox.AutoSize = true;
            this.CapitalEnglishLettersCheckBox.Location = new System.Drawing.Point(34, 213);
            this.CapitalEnglishLettersCheckBox.Name = "CapitalEnglishLettersCheckBox";
            this.CapitalEnglishLettersCheckBox.Size = new System.Drawing.Size(167, 17);
            this.CapitalEnglishLettersCheckBox.TabIndex = 4;
            this.CapitalEnglishLettersCheckBox.Text = "Большие английские буквы";
            this.CapitalEnglishLettersCheckBox.UseVisualStyleBackColor = true;
            this.CapitalEnglishLettersCheckBox.Click += new System.EventHandler(this.CapitalEnglishLettersCheckBox_Click);
            // 
            // RussianLettersCheckBox
            // 
            this.RussianLettersCheckBox.AutoSize = true;
            this.RussianLettersCheckBox.Location = new System.Drawing.Point(34, 236);
            this.RussianLettersCheckBox.Name = "RussianLettersCheckBox";
            this.RussianLettersCheckBox.Size = new System.Drawing.Size(102, 17);
            this.RussianLettersCheckBox.TabIndex = 5;
            this.RussianLettersCheckBox.Text = "Русские буквы";
            this.RussianLettersCheckBox.UseVisualStyleBackColor = true;
            this.RussianLettersCheckBox.Click += new System.EventHandler(this.RussianLettersCheckBox_Click);
            // 
            // CapitalRussianLettersCheckBox
            // 
            this.CapitalRussianLettersCheckBox.AutoSize = true;
            this.CapitalRussianLettersCheckBox.Location = new System.Drawing.Point(34, 260);
            this.CapitalRussianLettersCheckBox.Name = "CapitalRussianLettersCheckBox";
            this.CapitalRussianLettersCheckBox.Size = new System.Drawing.Size(149, 17);
            this.CapitalRussianLettersCheckBox.TabIndex = 6;
            this.CapitalRussianLettersCheckBox.Text = "Большие русские буквы";
            this.CapitalRussianLettersCheckBox.UseVisualStyleBackColor = true;
            this.CapitalRussianLettersCheckBox.Click += new System.EventHandler(this.CapitalRussianLettersCheckBox_Click);
            // 
            // NumbersCheckBox
            // 
            this.NumbersCheckBox.AutoSize = true;
            this.NumbersCheckBox.Location = new System.Drawing.Point(34, 283);
            this.NumbersCheckBox.Name = "NumbersCheckBox";
            this.NumbersCheckBox.Size = new System.Drawing.Size(62, 17);
            this.NumbersCheckBox.TabIndex = 8;
            this.NumbersCheckBox.Text = "Цифры";
            this.NumbersCheckBox.UseVisualStyleBackColor = true;
            this.NumbersCheckBox.Click += new System.EventHandler(this.NumbersCheckBox_Click);
            // 
            // SpecialSymbolsCheckBox
            // 
            this.SpecialSymbolsCheckBox.AutoSize = true;
            this.SpecialSymbolsCheckBox.Location = new System.Drawing.Point(34, 307);
            this.SpecialSymbolsCheckBox.Name = "SpecialSymbolsCheckBox";
            this.SpecialSymbolsCheckBox.Size = new System.Drawing.Size(100, 17);
            this.SpecialSymbolsCheckBox.TabIndex = 9;
            this.SpecialSymbolsCheckBox.Text = "Спец символы";
            this.SpecialSymbolsCheckBox.UseVisualStyleBackColor = true;
            this.SpecialSymbolsCheckBox.Click += new System.EventHandler(this.SpecialSymbolsCheckBox_Click);
            // 
            // SelectPasswordSizeLabel
            // 
            this.SelectPasswordSizeLabel.AutoSize = true;
            this.SelectPasswordSizeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectPasswordSizeLabel.Location = new System.Drawing.Point(30, 63);
            this.SelectPasswordSizeLabel.Name = "SelectPasswordSizeLabel";
            this.SelectPasswordSizeLabel.Size = new System.Drawing.Size(178, 19);
            this.SelectPasswordSizeLabel.TabIndex = 10;
            this.SelectPasswordSizeLabel.Text = "Выставте длинну пароля";
            // 
            // SelectPasswordOptionsLabel
            // 
            this.SelectPasswordOptionsLabel.AutoSize = true;
            this.SelectPasswordOptionsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectPasswordOptionsLabel.Location = new System.Drawing.Point(30, 167);
            this.SelectPasswordOptionsLabel.Name = "SelectPasswordOptionsLabel";
            this.SelectPasswordOptionsLabel.Size = new System.Drawing.Size(203, 19);
            this.SelectPasswordOptionsLabel.TabIndex = 11;
            this.SelectPasswordOptionsLabel.Text = "Выберете параметры пароля";
            // 
            // GenerationResultLabel
            // 
            this.GenerationResultLabel.AutoSize = true;
            this.GenerationResultLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerationResultLabel.Location = new System.Drawing.Point(313, 63);
            this.GenerationResultLabel.Name = "GenerationResultLabel";
            this.GenerationResultLabel.Size = new System.Drawing.Size(147, 19);
            this.GenerationResultLabel.TabIndex = 12;
            this.GenerationResultLabel.Text = "Результат генерации";
            // 
            // CopyPasswordButton
            // 
            this.CopyPasswordButton.Location = new System.Drawing.Point(889, 333);
            this.CopyPasswordButton.Name = "CopyPasswordButton";
            this.CopyPasswordButton.Size = new System.Drawing.Size(94, 23);
            this.CopyPasswordButton.TabIndex = 13;
            this.CopyPasswordButton.Text = "Скопировать";
            this.CopyPasswordButton.UseVisualStyleBackColor = true;
            this.CopyPasswordButton.Click += new System.EventHandler(this.CopyPasswordButton_Click);
            // 
            // AllOptionsCheckBox
            // 
            this.AllOptionsCheckBox.AutoSize = true;
            this.AllOptionsCheckBox.Location = new System.Drawing.Point(34, 330);
            this.AllOptionsCheckBox.Name = "AllOptionsCheckBox";
            this.AllOptionsCheckBox.Size = new System.Drawing.Size(91, 17);
            this.AllOptionsCheckBox.TabIndex = 14;
            this.AllOptionsCheckBox.Text = "Выбрать все";
            this.AllOptionsCheckBox.UseVisualStyleBackColor = true;
            this.AllOptionsCheckBox.CheckedChanged += new System.EventHandler(this.AllOptionsCheckBox_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 0;
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 383);
            this.Controls.Add(this.AllOptionsCheckBox);
            this.Controls.Add(this.CopyPasswordButton);
            this.Controls.Add(this.GenerationResultLabel);
            this.Controls.Add(this.SelectPasswordOptionsLabel);
            this.Controls.Add(this.SelectPasswordSizeLabel);
            this.Controls.Add(this.SpecialSymbolsCheckBox);
            this.Controls.Add(this.NumbersCheckBox);
            this.Controls.Add(this.CapitalRussianLettersCheckBox);
            this.Controls.Add(this.RussianLettersCheckBox);
            this.Controls.Add(this.CapitalEnglishLettersCheckBox);
            this.Controls.Add(this.EnglishLettersCheckBox);
            this.Controls.Add(this.GeneratePasswordButton);
            this.Controls.Add(this.PasswordResultTextBox);
            this.Controls.Add(this.PasswordLengthNumericUpDown);
            this.Name = "PasswordGeneratorForm";
            this.Text = "Лучший генератор паролей1";
            this.Load += new System.EventHandler(this.PasswordGeneratorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PasswordLengthNumericUpDown;
        private System.Windows.Forms.TextBox PasswordResultTextBox;
        private System.Windows.Forms.Button GeneratePasswordButton;
        private System.Windows.Forms.CheckBox EnglishLettersCheckBox;
        private System.Windows.Forms.CheckBox CapitalEnglishLettersCheckBox;
        private System.Windows.Forms.CheckBox RussianLettersCheckBox;
        private System.Windows.Forms.CheckBox CapitalRussianLettersCheckBox;
        private System.Windows.Forms.CheckBox NumbersCheckBox;
        private System.Windows.Forms.CheckBox SpecialSymbolsCheckBox;
        private System.Windows.Forms.Label SelectPasswordSizeLabel;
        private System.Windows.Forms.Label SelectPasswordOptionsLabel;
        private System.Windows.Forms.Label GenerationResultLabel;
        private System.Windows.Forms.Button CopyPasswordButton;
        private System.Windows.Forms.CheckBox AllOptionsCheckBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}