namespace WinFormsApp10
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool is_err = false;
            if (richTextBox1.Text != "")
            {

                try
                {
                    string[] s = richTextBox1.Text.Split('\n');
                    Convert.ToInt32(textBox1);
                    Convert.ToInt32(textBox2);
                    Convert.ToInt32(textBox3);
                    Convert.ToInt32(textBox4);
                    foreach (string el in s)
                    {
                        Convert.ToInt32(el);
                    }
                }
                catch
                {
                    MessageBox.Show("������ �����, ��������� ������������ �������� ������!");
                }
                if (!is_err)
                {

                    // �������� ������ ����� ���� �� richTextBox1
                    string[] arr = richTextBox1.Text.Split('\n');

                    int Nb = Convert.ToInt32(textBox1); // ������ ������ ������
                    int N = Convert.ToInt32(textBox2); // ������ ������ ������
                    int A = Convert.ToInt32(textBox3); // ������ �������� ���������
                    int b = Convert.ToInt32(textBox4); // ������ ���������� �����������

                    int count = 0; // ������� ����������� �������

                    foreach (string size in arr)
                    {
                        if (Convert.ToInt32(size) < A - b || Convert.ToInt32(size) > A + b)
                            count++; // ����������� ������� ��� ��������������
                    }

                    if (count == 0)
                        label5.Text = "������������� �����"; // ���� ����������� ������� ���, ��������� ������������� �����
                    else
                        label5.Text = $"� ������ ������� {count} ����������� �������"; // ���� ����������� ������ ����, ��������� �� ����������
                }
            }
            else
            {
                MessageBox.Show("��������� ��� ����!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            richTextBox1.Text = "";
            label5.Text = "";
        }
    }
}