namespace CS392_HW3
{
    public partial class Form1 : Form
    {
        private String content = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void addText(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Text.Equals("(Space)"))
                {
                    content = $"{content} ";
                }
                else if (btn.Text.Equals("Clear"))
                {
                    content = "";
                }
                else if (btn.Text.Equals("Exit"))
                {
                    this.Close();
                }
                else
                {
                    content = $"{content}{btn.Text}";
                }
            }
            this.textBox1.Text = content;
        }
    }
}