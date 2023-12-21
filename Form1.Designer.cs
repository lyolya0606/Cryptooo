namespace Cryptooo {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИсходныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРезультатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИсходныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twofishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AES_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.twofish_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.key_textBox = new System.Windows.Forms.TextBox();
            this.crypt_button = new System.Windows.Forms.Button();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.twofishResult_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AESResult_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timeAES_label = new System.Windows.Forms.Label();
            this.timeTwofish_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(963, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьИсходныйТекстToolStripMenuItem,
            this.сохранитьРезультатToolStripMenuItem,
            this.загрузитьИсходныеДанныеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьИсходныйТекстToolStripMenuItem
            // 
            this.сохранитьИсходныйТекстToolStripMenuItem.Name = "сохранитьИсходныйТекстToolStripMenuItem";
            this.сохранитьИсходныйТекстToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.сохранитьИсходныйТекстToolStripMenuItem.Text = "Сохранить исходные данные";
            // 
            // сохранитьРезультатToolStripMenuItem
            // 
            this.сохранитьРезультатToolStripMenuItem.Name = "сохранитьРезультатToolStripMenuItem";
            this.сохранитьРезультатToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.сохранитьРезультатToolStripMenuItem.Text = "Сохранить результат";
            // 
            // загрузитьИсходныеДанныеToolStripMenuItem
            // 
            this.загрузитьИсходныеДанныеToolStripMenuItem.Name = "загрузитьИсходныеДанныеToolStripMenuItem";
            this.загрузитьИсходныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.загрузитьИсходныеДанныеToolStripMenuItem.Text = "Загрузить исходные данные";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aESToolStripMenuItem,
            this.twofishToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // aESToolStripMenuItem
            // 
            this.aESToolStripMenuItem.Name = "aESToolStripMenuItem";
            this.aESToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aESToolStripMenuItem.Text = "AES";
            // 
            // twofishToolStripMenuItem
            // 
            this.twofishToolStripMenuItem.Name = "twofishToolStripMenuItem";
            this.twofishToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.twofishToolStripMenuItem.Text = "Twofish";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "AES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(676, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Twofish";
            // 
            // AES_textBox
            // 
            this.AES_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AES_textBox.Location = new System.Drawing.Point(11, 90);
            this.AES_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.AES_textBox.Multiline = true;
            this.AES_textBox.Name = "AES_textBox";
            this.AES_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AES_textBox.Size = new System.Drawing.Size(455, 160);
            this.AES_textBox.TabIndex = 4;
            this.AES_textBox.Text = "qwerty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(410, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Исходный текст";
            // 
            // twofish_textBox
            // 
            this.twofish_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twofish_textBox.Location = new System.Drawing.Point(497, 90);
            this.twofish_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.twofish_textBox.Multiline = true;
            this.twofish_textBox.Name = "twofish_textBox";
            this.twofish_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.twofish_textBox.Size = new System.Drawing.Size(455, 160);
            this.twofish_textBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(455, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ключ";
            // 
            // key_textBox
            // 
            this.key_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key_textBox.Location = new System.Drawing.Point(11, 292);
            this.key_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.key_textBox.MaxLength = 16;
            this.key_textBox.Multiline = true;
            this.key_textBox.Name = "key_textBox";
            this.key_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.key_textBox.Size = new System.Drawing.Size(941, 80);
            this.key_textBox.TabIndex = 7;
            this.key_textBox.Text = "1234567890123456";
            // 
            // crypt_button
            // 
            this.crypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crypt_button.Location = new System.Drawing.Point(170, 391);
            this.crypt_button.Margin = new System.Windows.Forms.Padding(2);
            this.crypt_button.Name = "crypt_button";
            this.crypt_button.Size = new System.Drawing.Size(164, 46);
            this.crypt_button.TabIndex = 9;
            this.crypt_button.Text = "Зашифровать";
            this.crypt_button.UseVisualStyleBackColor = true;
            this.crypt_button.Click += new System.EventHandler(this.crypt_button_Click);
            // 
            // decrypt_button
            // 
            this.decrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decrypt_button.Location = new System.Drawing.Point(631, 391);
            this.decrypt_button.Margin = new System.Windows.Forms.Padding(2);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(167, 46);
            this.decrypt_button.TabIndex = 10;
            this.decrypt_button.Text = "Расшифровать";
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // twofishResult_textBox
            // 
            this.twofishResult_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twofishResult_textBox.Location = new System.Drawing.Point(497, 472);
            this.twofishResult_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.twofishResult_textBox.Multiline = true;
            this.twofishResult_textBox.Name = "twofishResult_textBox";
            this.twofishResult_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.twofishResult_textBox.Size = new System.Drawing.Size(455, 160);
            this.twofishResult_textBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(432, 434);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Результат";
            // 
            // AESResult_textBox
            // 
            this.AESResult_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AESResult_textBox.Location = new System.Drawing.Point(11, 472);
            this.AESResult_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.AESResult_textBox.Multiline = true;
            this.AESResult_textBox.Name = "AESResult_textBox";
            this.AESResult_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AESResult_textBox.Size = new System.Drawing.Size(455, 160);
            this.AESResult_textBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(453, 643);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Время";
            // 
            // timeAES_label
            // 
            this.timeAES_label.AutoSize = true;
            this.timeAES_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeAES_label.Location = new System.Drawing.Point(226, 643);
            this.timeAES_label.Name = "timeAES_label";
            this.timeAES_label.Size = new System.Drawing.Size(14, 20);
            this.timeAES_label.TabIndex = 15;
            this.timeAES_label.Text = "-";
            // 
            // timeTwofish_label
            // 
            this.timeTwofish_label.AutoSize = true;
            this.timeTwofish_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTwofish_label.Location = new System.Drawing.Point(719, 643);
            this.timeTwofish_label.Name = "timeTwofish_label";
            this.timeTwofish_label.Size = new System.Drawing.Size(14, 20);
            this.timeTwofish_label.TabIndex = 16;
            this.timeTwofish_label.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 678);
            this.Controls.Add(this.timeTwofish_label);
            this.Controls.Add(this.timeAES_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.twofishResult_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AESResult_textBox);
            this.Controls.Add(this.decrypt_button);
            this.Controls.Add(this.crypt_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.key_textBox);
            this.Controls.Add(this.twofish_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AES_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИсходныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьРезультатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИсходныеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twofishToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AES_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox twofish_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox key_textBox;
        private System.Windows.Forms.Button crypt_button;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.TextBox twofishResult_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AESResult_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label timeAES_label;
        private System.Windows.Forms.Label timeTwofish_label;
    }
}

