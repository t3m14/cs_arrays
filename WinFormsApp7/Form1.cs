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
                    Convert.ToInt32(textBox1.Text);
                    foreach (string el in s)
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
                    int m = Convert.ToInt32(textBox1.Text);
                    int product = 1;
                    bool exists = false;
                    foreach (string number in mass)
                    {
                        if (Convert.ToInt32(number) > m)
                        {
                            product *= Convert.ToInt32(number);
                            exists = true;
                        }
                    }
                    if (exists)
                    {
                        label4.Text = Convert.ToString(product);
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