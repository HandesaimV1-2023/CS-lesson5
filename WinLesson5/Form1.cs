using Dal;
using BL;
namespace WinLesson5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // שימו לב שמטפלי הארוע כלומר הפונקציות שמופעלות כתגובה לארוע הם
        // פונקציות שנכנסות למאפין שהוא מסוג דליגגיט
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("filename");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person p = new Person();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonBL bl = new PersonBL();
            textBox1.Text = bl.GetPersonById(textBox1.Text).Name;
        }
    }
}