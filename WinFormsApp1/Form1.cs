using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool is_err = false;
            if (textBox1.Text != "" && richTextBox1.Text != "")
            {

                try {
                    string[] s = richTextBox1.Text.Split('\n');
                    Convert.ToInt32(textBox1.Text);
                    foreach(string el in s)
                    {
                        Convert.ToInt32(el);
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода, проверьте правильность введённых данных!");
                }
                if (!is_err)
                {

                    // получаем массив через ввод из richTextBox1
                    string[] mass = richTextBox1.Text.Split('\n');
                    int z = Convert.ToInt32(textBox1.Text);
                    int replaceCount = 0;
                    for (int i = 0; i < mass.Length; i++)
                    {
                        if (Convert.ToInt32(mass[i]) > z)
                        {
                            mass[i] = Convert.ToString(z);
                            replaceCount++;

                        }
                    }
                    foreach (string el in mass)
                    {
                        richTextBox2.Text += el + '\n';
                    }
                    label6.Text = Convert.ToString(replaceCount);
                
                    textBox1.Text = "";
                    richTextBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox1.Text = "";
            label6.Text = "";
        }
    }
}