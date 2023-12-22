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
            this.saveInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.twofishBytes_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AESBytes_textBox = new System.Windows.Forms.TextBox();
            this.twofishResultBytes_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AESResultBytes_textBox = new System.Windows.Forms.TextBox();
            this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.compareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1272, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveInputToolStripMenuItem,
            this.saveResultToolStripMenuItem,
            this.downloadInputToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // saveInputToolStripMenuItem
            // 
            this.saveInputToolStripMenuItem.Name = "saveInputToolStripMenuItem";
            this.saveInputToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.saveInputToolStripMenuItem.Text = "Сохранить исходные данные";
            this.saveInputToolStripMenuItem.Click += new System.EventHandler(this.saveInputToolStripMenuItem_Click);
            // 
            // saveResultToolStripMenuItem
            // 
            this.saveResultToolStripMenuItem.Name = "saveResultToolStripMenuItem";
            this.saveResultToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.saveResultToolStripMenuItem.Text = "Сохранить результат";
            this.saveResultToolStripMenuItem.Click += new System.EventHandler(this.saveResultToolStripMenuItem_Click);
            // 
            // downloadInputToolStripMenuItem
            // 
            this.downloadInputToolStripMenuItem.Name = "downloadInputToolStripMenuItem";
            this.downloadInputToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.downloadInputToolStripMenuItem.Text = "Загрузить исходные данные";
            this.downloadInputToolStripMenuItem.Click += new System.EventHandler(this.downloadInputToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aESToolStripMenuItem,
            this.twofishToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // aESToolStripMenuItem
            // 
            this.aESToolStripMenuItem.Name = "aESToolStripMenuItem";
            this.aESToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aESToolStripMenuItem.Text = "AES";
            // 
            // twofishToolStripMenuItem
            // 
            this.twofishToolStripMenuItem.Name = "twofishToolStripMenuItem";
            this.twofishToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.twofishToolStripMenuItem.Text = "Twofish";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(279, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "AES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(901, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Twofish";
            // 
            // AES_textBox
            // 
            this.AES_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AES_textBox.Location = new System.Drawing.Point(15, 111);
            this.AES_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AES_textBox.Multiline = true;
            this.AES_textBox.Name = "AES_textBox";
            this.AES_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AES_textBox.Size = new System.Drawing.Size(605, 100);
            this.AES_textBox.TabIndex = 4;
            this.AES_textBox.Text = "qwerty";
            this.AES_textBox.Leave += new System.EventHandler(this.AES_textBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(484, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Исходный текст (в символах)";
            // 
            // twofish_textBox
            // 
            this.twofish_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twofish_textBox.Location = new System.Drawing.Point(663, 111);
            this.twofish_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.twofish_textBox.Multiline = true;
            this.twofish_textBox.Name = "twofish_textBox";
            this.twofish_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.twofish_textBox.Size = new System.Drawing.Size(605, 100);
            this.twofish_textBox.TabIndex = 6;
            this.twofish_textBox.Leave += new System.EventHandler(this.twofish_textBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(546, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ключ";
            // 
            // key_textBox
            // 
            this.key_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key_textBox.Location = new System.Drawing.Point(663, 389);
            this.key_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.key_textBox.MaxLength = 16;
            this.key_textBox.Name = "key_textBox";
            this.key_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.key_textBox.Size = new System.Drawing.Size(241, 30);
            this.key_textBox.TabIndex = 7;
            this.key_textBox.Text = "1234567890123456";
            // 
            // crypt_button
            // 
            this.crypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crypt_button.Location = new System.Drawing.Point(227, 433);
            this.crypt_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crypt_button.Name = "crypt_button";
            this.crypt_button.Size = new System.Drawing.Size(219, 57);
            this.crypt_button.TabIndex = 9;
            this.crypt_button.Text = "Зашифровать";
            this.crypt_button.UseVisualStyleBackColor = true;
            this.crypt_button.Click += new System.EventHandler(this.crypt_button_Click);
            // 
            // decrypt_button
            // 
            this.decrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decrypt_button.Location = new System.Drawing.Point(841, 433);
            this.decrypt_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(223, 57);
            this.decrypt_button.TabIndex = 10;
            this.decrypt_button.Text = "Расшифровать";
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // twofishResult_textBox
            // 
            this.twofishResult_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twofishResult_textBox.Location = new System.Drawing.Point(663, 533);
            this.twofishResult_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.twofishResult_textBox.Multiline = true;
            this.twofishResult_textBox.Name = "twofishResult_textBox";
            this.twofishResult_textBox.ReadOnly = true;
            this.twofishResult_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.twofishResult_textBox.Size = new System.Drawing.Size(605, 100);
            this.twofishResult_textBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(508, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Результат (в символах)";
            // 
            // AESResult_textBox
            // 
            this.AESResult_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AESResult_textBox.Location = new System.Drawing.Point(15, 533);
            this.AESResult_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AESResult_textBox.Multiline = true;
            this.AESResult_textBox.Name = "AESResult_textBox";
            this.AESResult_textBox.ReadOnly = true;
            this.AESResult_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AESResult_textBox.Size = new System.Drawing.Size(605, 100);
            this.AESResult_textBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(603, 813);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Время";
            // 
            // timeAES_label
            // 
            this.timeAES_label.AutoSize = true;
            this.timeAES_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeAES_label.Location = new System.Drawing.Point(300, 813);
            this.timeAES_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeAES_label.Name = "timeAES_label";
            this.timeAES_label.Size = new System.Drawing.Size(19, 25);
            this.timeAES_label.TabIndex = 15;
            this.timeAES_label.Text = "-";
            // 
            // timeTwofish_label
            // 
            this.timeTwofish_label.AutoSize = true;
            this.timeTwofish_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTwofish_label.Location = new System.Drawing.Point(958, 813);
            this.timeTwofish_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeTwofish_label.Name = "timeTwofish_label";
            this.timeTwofish_label.Size = new System.Drawing.Size(19, 25);
            this.timeTwofish_label.TabIndex = 16;
            this.timeTwofish_label.Text = "-";
            // 
            // twofishBytes_textBox
            // 
            this.twofishBytes_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twofishBytes_textBox.Location = new System.Drawing.Point(663, 269);
            this.twofishBytes_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.twofishBytes_textBox.Multiline = true;
            this.twofishBytes_textBox.Name = "twofishBytes_textBox";
            this.twofishBytes_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.twofishBytes_textBox.Size = new System.Drawing.Size(605, 100);
            this.twofishBytes_textBox.TabIndex = 19;
            this.twofishBytes_textBox.Leave += new System.EventHandler(this.twofishBytes_textBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(484, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Исходный текст (в байтах)";
            // 
            // AESBytes_textBox
            // 
            this.AESBytes_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AESBytes_textBox.Location = new System.Drawing.Point(15, 269);
            this.AESBytes_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AESBytes_textBox.Multiline = true;
            this.AESBytes_textBox.Name = "AESBytes_textBox";
            this.AESBytes_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AESBytes_textBox.Size = new System.Drawing.Size(605, 100);
            this.AESBytes_textBox.TabIndex = 17;
            this.AESBytes_textBox.Leave += new System.EventHandler(this.AESBytes_textBox_Leave);
            // 
            // twofishResultBytes_textBox
            // 
            this.twofishResultBytes_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twofishResultBytes_textBox.Location = new System.Drawing.Point(663, 689);
            this.twofishResultBytes_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.twofishResultBytes_textBox.Multiline = true;
            this.twofishResultBytes_textBox.Name = "twofishResultBytes_textBox";
            this.twofishResultBytes_textBox.ReadOnly = true;
            this.twofishResultBytes_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.twofishResultBytes_textBox.Size = new System.Drawing.Size(605, 100);
            this.twofishResultBytes_textBox.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(508, 649);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Результат (в символах)";
            // 
            // AESResultBytes_textBox
            // 
            this.AESResultBytes_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AESResultBytes_textBox.Location = new System.Drawing.Point(15, 689);
            this.AESResultBytes_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AESResultBytes_textBox.Multiline = true;
            this.AESResultBytes_textBox.Name = "AESResultBytes_textBox";
            this.AESResultBytes_textBox.ReadOnly = true;
            this.AESResultBytes_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AESResultBytes_textBox.Size = new System.Drawing.Size(605, 100);
            this.AESResultBytes_textBox.TabIndex = 20;
            // 
            // compareToolStripMenuItem
            // 
            this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            this.compareToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.compareToolStripMenuItem.Text = "Сравнение";
            this.compareToolStripMenuItem.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 852);
            this.Controls.Add(this.twofishResultBytes_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AESResultBytes_textBox);
            this.Controls.Add(this.twofishBytes_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AESBytes_textBox);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифрования AES и Twofish";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadInputToolStripMenuItem;
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
        private System.Windows.Forms.TextBox twofishBytes_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AESBytes_textBox;
        private System.Windows.Forms.TextBox twofishResultBytes_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AESResultBytes_textBox;
        private System.Windows.Forms.ToolStripMenuItem compareToolStripMenuItem;
    }
}

