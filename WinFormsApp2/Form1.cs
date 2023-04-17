using System.Windows.Forms;

namespace WinFormsApp2
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
            if (richTextBox1.Text != "")
            {

                try
                {
                    string[] s = richTextBox1.Text.Split('\n');
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
                    int pos = 0;
                    int neg = 0;
                    int nul = 0;
                    for (int i = 0; i < mass.Length; i++)
                    {
                        if (Convert.ToSingle(mass[i]) > 0)
                        {
                            pos++;
                        }
                        if (Convert.ToSingle(mass[i]) < 0)
                        {
                            neg++;
                        }
                        if (Convert.ToSingle(mass[i])  == 0)
                        {
                            nul++;
                        }
                    }
                            label7.Text = Convert.ToString(pos);
                            label8.Text = Convert.ToString(nul);
                            label9.Text = Convert.ToString(neg);
                    pos = 0;
                    neg = 0;
                    nul = 0;
                    richTextBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }
    }
}