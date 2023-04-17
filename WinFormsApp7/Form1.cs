using System.Windows.Forms;

namespace WinFormsApp7
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

                try
                {
                    string[] s = richTextBox1.Text.Split('\n');
                    Convert.ToSingle(textBox1.Text);
                    foreach (string el in s)
                    {
                        Convert.ToSingle(el);
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
                    float m = Convert.ToSingle(textBox1.Text);
                    int product = 1;
                    bool exists = false;
                    foreach (string number in mass)
                    {
                        if (Convert.ToSingle(number) > m)
                        {
                            product *= Convert.ToInt32(number);
                            exists = true;
                        }
                    }
                    if (exists)
                    {
                        label4.Text = Convert.ToString(product);
                    }
                    else
                    {
                        label4.Text = "Нет таких элементов!";
                    }

                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox1.Text = "";
            label4.Text = "";
        }
    }
}