namespace лр7_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Mas = new int[14];
        
        private void button1_Click(object sender, EventArgs e)
        {
            исходник.Items.Clear();
            Random rnd = new Random();
            for(int i=0;i<14;i++)
            {
                Mas[i] = rnd.Next(-10, 10);
                исходник.Items.Add("Mas[" + i.ToString() + "]=" + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            сумма.Items.Clear();
            int m = 0,a=0,sum=0;
            for(int i=0;i<14;i++)
            {
                if(Mas[i]<0)
                {
                    a = Mas[i];
                    m = i;
                    break;
                }               
            }
            for (int i=0;i<m;i++)
            {
                sum += Mas[i];
            }
            сумма.Items.Add("sum=" + sum.ToString());

        }
    }
}