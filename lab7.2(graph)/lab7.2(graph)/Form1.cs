namespace lab7._2_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string[] s = str.Split(); // ��������� ��������� ������ �� ������ �����
            int x;
            string t = " ";

            int n = 0;
            try
            {
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("���������� ���������� �� ����� ����� ������������� ��� ������� ��������!", "������",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            catch
            {
                MessageBox.Show("�������� ������ ����� ������!", "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            n = (int)numericUpDown1.Value;
            bool flag = false;
            string t1 = "";

            for (int i = 0; i < s.Length; i++)
            {
                x = 0;
                if (t != s[i])
                {
                    foreach (string word in s)
                    {
                        if (s[i] == word)
                        {
                            ++x;
                        }
                        if (x > n)
                        {
                            t1 += word + Environment.NewLine;
                            t = s[i];
                            flag = true;
                            break;
                        }
                    }
                }
            }

            if (flag == false)
            {
                textBox2.Text += ($"������������� ����� {n} ��� ���� ���!") + Environment.NewLine;

            }
            else
            {
                textBox2.Text += ("����� ����������� ����� " + n + " ���: ") + Environment.NewLine;
                textBox2.Text += (t1) + Environment.NewLine;
            }
        }
    }

}
    