namespace lab7._1_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            str = textBox1.Text;
            int index1, index2;
            string str1, str2, result;
            if (String.IsNullOrEmpty(str))
            {
                MessageBox.Show("������ ������!", "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!str.Contains("(") || !str.Contains(")"))
            {
                MessageBox.Show("������ �� �������� ������� ������", "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                textBox2.Text += ("�������� ������: " + str) + Environment.NewLine;

                index1 = str.IndexOf("("); //������ ������� ������
                index2 = str.IndexOf(")");
                str1 = str.Substring(0, index1 + 1); //��������� ��������� �� ������� ����������
                str2 = str.Substring(index2);
                result = str1 + str2;
                textBox2.Text += ("���������� ������: " + result);
            }

        }
    }
}