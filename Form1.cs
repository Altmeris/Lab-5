using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Текстовый_Редактор
{
    public partial class Form1 : Form
    {
        Найти най = new Найти();
        Заменить замена = new Заменить();
        bool myfont = true;
        //RichTextBox rich = new RichTextBox();
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void параметрыСтраницыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            PrintDocument def = new PrintDocument();
            def.PrintPage += new PrintPageEventHandler(PRD);
            def.DocumentName = "Document1";
            def.PrinterSettings = printDialog1.PrinterSettings;
            def.Print();

        }
        void PRD(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString(((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text, ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Font, new SolidBrush(((RichTextBox)tabControl1.SelectedTab.Controls[0]).ForeColor), 0, 0);

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rich = new RichTextBox();
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            //получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            //сохраняем текст в файл
           System.IO.File.WriteAllText(filename, ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text);
            MessageBox.Show("Файл сохранен");
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rich = new RichTextBox();

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            //tabControl1.SelectedTab.Name = openFileDialog1.FileName;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            rich.Dock = DockStyle.Fill;
            rich.Visible = true;
            string files = System.IO.Path.GetFileName(openFileDialog1.FileName);
            tabControl1.TabPages.Add(files);
            tabControl1.SelectTab(i+1);
            tabControl1.SelectedTab.Controls.Add(rich);
            openFileDialog1.ShowDialog();
            
            ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text = fileText;


            i++;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if ()
        }

        private void датаИВремяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rich = new RichTextBox();
            string g = Convert.ToString(System.DateTime.Now);
            ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text += g;
            //rich.Text += g;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            if (tabControl1.TabCount > 0)
                ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont = fontDialog1.Font;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rich = new RichTextBox();
            rich.Visible = true;
            rich.Dock = DockStyle.Fill;
            rich.Enabled = true;
            tabControl1.TabPages.Add("New page");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(rich);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void форматToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RichTextBox rich = new RichTextBox();
            tabControl1.TabPages.Add("New page");

                tabControl1.SelectTab(i+1);
            
            tabControl1.SelectedTab.Controls.Add(rich);
            rich.Visible = true;
            rich.Dock = DockStyle.Fill;
            rich.Enabled = true;
            //((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text;
            i++;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RichTextBox rich = new RichTextBox();
            if (tabControl1.TabPages.Count > 1&& ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text=="")
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i -= 1;
            }
            if (tabControl1.TabPages.Count > 1 && ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text != "")
            {

                DialogResult result = MessageBox.Show("На данной вкладке у вас имеется текст. Сохранить ли его в файл <" + tabControl1.SelectedTab.Text + "> ?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(tabControl1.SelectedTab.Text))
                    {
                        sw.WriteLine(((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text);
                    }
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    
                }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                {

                }
                
                //Отменяем действие
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i -= 1;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if(tabControl1.TabCount>0)
                ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectedText= ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectedText.ToUpper();


        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
                ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectedText= ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectedText.ToLower();

        }

        private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
                ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectAll();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
                ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectedText = "";
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
                ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
                ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
                ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Paste();
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((RichTextBox)tabControl1.SelectedTab.Controls[0]).ResetText();
        }

        private void заменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            замена.ShowDialog();
            замена.textBox1.Text = ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectedText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
            using (System.IO.StreamReader sr = new System.IO.StreamReader("Колво"))
            {
                int kolvo = Convert.ToByte(sr.ReadLine());
                for (int g = 0; g < kolvo; g++)
                {

                    tabControl1.TabPages.Add("1");
                    RichTextBox rich = new RichTextBox();
                    rich.Visible = true;
                    rich.Dock = DockStyle.Fill;
                    rich.Enabled = true;
                    tabControl1.SelectTab(g);
                    tabControl1.SelectedTab.Controls.Add(rich);
                }
                using (System.IO.StreamReader sb = new System.IO.StreamReader("Вкладки"))
                {
                    for(int gg = 0; gg < kolvo; gg++)
                    {
                        tabControl1.SelectedIndex = gg;
                        tabControl1.SelectedTab.Text=sb.ReadLine();
                    }


                }
                tabControl1.SelectedIndex = tabControl1.TabCount - 1;

            }
            замена.buttonЗамена.Click += ButtonЗамена_Click;
            замена.buttonНайтиДЗам.Click += ButtonНайтиДЗам_Click;
            замена.buttonЗаменаВсё.Click += ButtonЗаменаВсё_Click;
            //((RichTextBox)tabControl1.SelectedTab.Controls[0]).TextChanged += Form1_TextChanged;
            if(tabControl1.TabCount!=0)
            i = tabControl1.TabCount - 1;
        }
        private void TextChange()
        {

        }


        private void ButtonЗаменаВсё_Click(object sender, EventArgs e)
        {
            if(tabControl1.TabCount>0)
            while(((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text.Contains(замена.textBox1.Text))
            {
                int index = ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text.IndexOf(замена.textBox1.Text);  // узнаем первое вхождение слова (которое будем заменять)
                string str1, str2;
                str1 = ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text.Substring(0, index); // вырезаем с rtb весь текст до слова (которое будем заменять)
                str2 = ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text.Substring((index + замена.textBox1.TextLength), (((RichTextBox)tabControl1.SelectedTab.Controls[0]).TextLength - (index + замена.textBox1.TextLength))); // вырезаем весь текст после слова (которое будем заменять)
                string result = str1 + замена.textBox2.Text + str2; // соединяем 1 строку со 2, между ними вставляем уже новое слово
                ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Clear(); // очищаем от текста rtb 
                ((RichTextBox)tabControl1.SelectedTab.Controls[0]).AppendText(result); // вставляем текст уже с новым словом
                ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Select(str1.Length, замена.textBox2.Text.Length); // выделяем наше новое слово
                //((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))); ну а тут уже выбираем (новому вставленному) слову любой шрифт, размер шрифта и тд и тп.
            }
        }

        private void ButtonНайтиДЗам_Click(object sender, EventArgs e)
        {
           //поиск след слова для замены
        }

        private void ButtonЗамена_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                if (((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text.Contains(замена.textBox1.Text)) // проверяем есть ли в rtb такое слово которое (мы - пользователь) ввел для замены
                {
                    int index = ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text.IndexOf(замена.textBox1.Text);  // узнаем первое вхождение слова (которое будем заменять)
                    string str1, str2;
                    str1 = ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text.Substring(0, index); // вырезаем с rtb весь текст до слова (которое будем заменять)
                    str2 = ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text.Substring((index + замена.textBox1.TextLength), (((RichTextBox)tabControl1.SelectedTab.Controls[0]).TextLength - (index + замена.textBox1.TextLength))); // вырезаем весь текст после слова (которое будем заменять)
                    string result = str1 + замена.textBox2.Text + str2; // соединяем 1 строку со 2, между ними вставляем уже новое слово
                    ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Clear(); // очищаем от текста rtb 
                    ((RichTextBox)tabControl1.SelectedTab.Controls[0]).AppendText(result); // вставляем текст уже с новым словом
                    ((RichTextBox)tabControl1.SelectedTab.Controls[0]).Select(str1.Length, замена.textBox2.Text.Length); // выделяем наше новое слово
                    ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))); // ну а тут уже выбираем (новому вставленному) слову любой шрифт, размер шрифта и тд и тп.
                }
                else
                    MessageBox.Show("Такого слова в RichTextBox не найдено"); // в противном случае сообщаем о не найденном слове 
            }
            else
            {
                MessageBox.Show("Не создано вкладок с текстом.");
            }

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (tabControl1.TabCount > 0)
                ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionColor = colorDialog1.Color;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if(tabControl1.TabCount>0)
            ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
                ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
                ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionAlignment = HorizontalAlignment.Right;
        }


        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                if (!((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont.Underline)
                {
                    ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont, FontStyle.Underline);
                }
                else if (((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont.Underline)
                {
                    ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont, FontStyle.Regular);
                }
            }



        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                if (!((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont.Strikeout)
                {
                    ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont, FontStyle.Strikeout);
                }
                else if (((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont.Strikeout)
                {
                    ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont, FontStyle.Regular);
                }
            }

        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                if (!((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont.Italic)
                {
                    ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont, FontStyle.Italic);
                }
                else if (((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont.Italic)
                {
                    ((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls[0]).SelectionFont, FontStyle.Regular);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("У вас открыты вкладки. Желаете ли вы сохранить содержимое вкладок?" + tabControl1.SelectedTab.Text + "> ?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (tabControl1.TabCount > 0 &&(result != System.Windows.Forms.DialogResult.Yes || result == System.Windows.Forms.DialogResult.No))
            {
                
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    for (int mat = 0; i < tabControl1.TabCount + 1; mat++)
                    {
                        tabControl1.SelectedIndex = mat;
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(tabControl1.SelectedTab.Text))
                        {
                            sw.WriteLine(((RichTextBox)tabControl1.SelectedTab.Controls[0]).Text);
                        }
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Вкладки"))
                        {
                            sw.WriteLine(tabControl1.SelectedTab.Text);
                        }
                    }
                    this.Close();
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    this.Close();//e.Cancel = true;
                }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                {

                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
