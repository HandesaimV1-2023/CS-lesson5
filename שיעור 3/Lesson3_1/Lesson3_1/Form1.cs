namespace Lesson3_1
{
    //delegate
    public delegate int del(int x, int y);

    public partial class Form1 : Form
    {
        // ���� �� �������� ������� ��� �����
        Dictionary<char, del> dicfunc = new Dictionary<char, del>();

        del Func;
        public Form1()
        {
            InitializeComponent();
            dicfunc.Add('+', Add); // ��� �� ������� �� ��������
            dicfunc.Add('-', Sub);
        }
        public int Add(int x,int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //if (chkPlus.Checked)
            //    label1.Text = txtNum1.Text + txtNum2.Text;
            //else
            //    label1.Text =Convert.ToString( int.Parse(txtNum1.Text) - int.Parse (txtNum2.Text));

            // �� ����� ����� �� ���� �����

            //if (chkPlus.Checked)
            //    label1.Text = Convert.ToString(Add (int.Parse(txtNum1.Text),int.Parse(txtNum2.Text)));
            //else
            //    label1.Text = Convert.ToString(Sub( int.Parse(txtNum1.Text) , int.Parse(txtNum2.Text)));
            label1.Text =Convert.ToString( Func(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text)));  


        }

        private void chkPlus_CheckedChanged(object sender, EventArgs e)
        {
            // ���� �
            Func = Add; // ��� �� ������ ��� �� ������
            // ���� �
             label1.Text=Convert.ToString(dicfunc['+'](int.Parse(txtNum1.Text), int.Parse(txtNum2.Text)));
        }

        private void chkMinus_CheckedChanged(object sender, EventArgs e)
        {
            Func = Sub;// ��� �� ������ ��� �� ������
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}