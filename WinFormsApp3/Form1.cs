using System.Windows.Forms;

namespace WinFormsApp3
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
                    MessageBox.Show("������ �����, ��������� ������������ �������� ������!");
                }
                try
                {
                    Convert.ToInt32(textBox1.Text);
                }
                catch
                {
                    is_err = true;
                    MessageBox.Show("������� �� �����");
                    return;
                }
                if(Convert.ToInt32(textBox1.Text) < 0)
                {
                    is_err=true;
                    MessageBox.Show("������� ������������� �����");
                    return ;
                }

                if (!is_err)
                {

                    // �������� ������ ����� ���� �� richTextBox1
                    string[] heights = richTextBox1.Text.Split('\n');
                    if (heights.Length != Convert.ToInt32(textBox1.Text))
                    {
                        MessageBox.Show("N �� ����� ������ �������");
                        return;
                    }
                    double boysSum = 0, girlsSum = 0;
                    int boysCount = 0, girlsCount = 0;

                    for (int i = 0; i < heights.Length; i++)
                    {
                        if (Convert.ToSingle(heights[i]) < 0)
                        { // �������
                            boysSum += Math.Abs(Convert.ToSingle(heights[i]));
                            boysCount++;
                        }
                        else
                        { // �������
                            girlsSum += Convert.ToSingle(heights[i]);
                            girlsCount++;
                        }
                    }

                    double boysAverage = boysSum / boysCount;
                    double girlsAverage = girlsSum / girlsCount;

                    label6.Text = Convert.ToString(girlsAverage);
                    label7.Text = Convert.ToString(boysAverage);
                    richTextBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("��������� ��� ����!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            label7.Text = "";
        }
    }
}