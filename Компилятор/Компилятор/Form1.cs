using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Asm;
using System.IO;

namespace Компилятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            AsmCl tre = new AsmCl();
            
            string[] text = new string[txbCode.Lines.Length];
            for (int i = 0; i < txbCode.Lines.Length; i++)
            {
                text[i] = txbCode.Lines[i];
            }
            byte[] registr = new byte[16];
            registr = tre.runCode(text, txbCode.Lines.Length);
            string Resultreg = "";
            for (int i = 0; i < registr.Length; i++)
            {
                Resultreg += "Регистр " + i + " = " + registr[i] + "\r\n";
            }

            Result.Text = Resultreg;
        }
        private void открытьТекстовыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); //Создаем диалоговое окно открытия файла
            openFileDialog1.Filter = "asm files (*.asm)|*.asm|All files (*.*)|*.*"; //Фильтры отображения файлов
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Если на диалоговом окне нажали ОК, то выполняется if
            {
                try
                {
                    txbCode.Text = File.ReadAllText(openFileDialog1.FileName); //Читаем весь текст из выбранного файла и помещаем в textbox на форме
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message); //Сообщение об ошибке если с файлом будет что-то не так
                }
            }
        }
        private void сохранитьВТекстовыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, txbCode.Text);

        }
    }
}
