using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string testStr =textBox1.Text;
            int countWords = 0;
            int id = 0;
            Label lb = new Label();
            lb.Location = new Point(10, 5);
            lb.Text = countWords.ToString() + "Cлов в тексте";
            this.Controls.Add(lb);
            //Ставим флаг поиска пробела в false - это позволит 
            //избежать ошибок, если в начале строки будут пробелы 
            bool findSpace = false;
            //Идём по символам строки 
            while (id < testStr.Length)
            {
                //Если нашли пробел 
                if (testStr[id] == ' ')
                {
                    //Проверяем - искали-ли мы его. 
                    //Если искали, то ставим флаг того, что нашли, 
                    //если не искали (ищщем уже не пробел) - просто идём дальше. 
                    if (findSpace)
                        findSpace = false;
                }
                //Если нашли не пробел 
                else
                {
                    //Если искали пробел, то ничего не делаем, 
                    //а просто идём дальше, в противном случае 
                    //Говорим, что мы нашлю символ-который-не-пробел, 
                    //и увеличиваем счётчик 
                    if (!findSpace)
                    {
                        //Говорим, что теперь ищщем снова пробел 
                        findSpace = true;
                        //Увеличиваем счётчик слов 
                        countWords++;
                        lb.Text = countWords.ToString() + " cлов в тексте";
                    }
                }

                id++;
            }
            MessageBox.Show(countWords.ToString() + " cлов в тексте");
        }
    }
}
