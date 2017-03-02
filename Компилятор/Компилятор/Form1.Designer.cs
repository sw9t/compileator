namespace Компилятор
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbCode = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьТекстовыйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВТекстовыйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbCode
            // 
            this.txbCode.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbCode.Location = new System.Drawing.Point(6, 19);
            this.txbCode.Multiline = true;
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(312, 247);
            this.txbCode.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRun.Location = new System.Drawing.Point(6, 272);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(312, 43);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Выполнить";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Result.Enabled = false;
            this.Result.Location = new System.Drawing.Point(6, 15);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(228, 301);
            this.Result.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 221);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Компилятор.Properties.Resources.AQV9v0TEarQ;
            this.pictureBox1.Location = new System.Drawing.Point(42, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 71);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Result);
            this.groupBox1.Location = new System.Drawing.Point(342, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 322);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Значение регистров";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRun);
            this.groupBox2.Controls.Add(this.txbCode);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 321);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Компилятор";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(587, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 321);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Подсказка";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьТекстовыйФайлToolStripMenuItem,
            this.сохранитьВТекстовыйФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьТекстовыйФайлToolStripMenuItem
            // 
            this.открытьТекстовыйФайлToolStripMenuItem.Name = "открытьТекстовыйФайлToolStripMenuItem";
            this.открытьТекстовыйФайлToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.открытьТекстовыйФайлToolStripMenuItem.Text = "Открыть текстовый файл";
            this.открытьТекстовыйФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьТекстовыйФайлToolStripMenuItem_Click);
            // 
            // сохранитьВТекстовыйФайлToolStripMenuItem
            // 
            this.сохранитьВТекстовыйФайлToolStripMenuItem.Name = "сохранитьВТекстовыйФайлToolStripMenuItem";
            this.сохранитьВТекстовыйФайлToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.сохранитьВТекстовыйФайлToolStripMenuItem.Text = "Сохранить в текстовый файл";
            this.сохранитьВТекстовыйФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВТекстовыйФайлToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(850, 346);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fasmw.exe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьТекстовыйФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВТекстовыйФайлToolStripMenuItem;
    }
}

