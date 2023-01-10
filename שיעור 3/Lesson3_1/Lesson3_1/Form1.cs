namespace Lesson3_1
{
    //delegate
    public delegate int del(int x, int y);

    public partial class Form1 : Form
    {
        // אוסף של פונקציות שמזוהות לפי סימון
        Dictionary<char, del> dicfunc = new Dictionary<char, del>();

        del Func;
        public Form1()
        {
            InitializeComponent();
            dicfunc.Add('+', Add); // כאן לא מפעילים את הפונקציה
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

            // לא רוצים לכתוב בו הרבה תנאים

            //if (chkPlus.Checked)
            //    label1.Text = Convert.ToString(Add (int.Parse(txtNum1.Text),int.Parse(txtNum2.Text)));
            //else
            //    label1.Text = Convert.ToString(Sub( int.Parse(txtNum1.Text) , int.Parse(txtNum2.Text)));
            label1.Text =Convert.ToString( Func(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text)));  


        }

        private void chkPlus_CheckedChanged(object sender, EventArgs e)
        {
            // גרסה א
            Func = Add; // כאן לא מזמנים אלא רק מציבים
            // גרסה ב
             label1.Text=Convert.ToString(dicfunc['+'](int.Parse(txtNum1.Text), int.Parse(txtNum2.Text)));
        }

        private void chkMinus_CheckedChanged(object sender, EventArgs e)
        {
            Func = Sub;// כאן לא מזמנים אלא רק מציבים
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}