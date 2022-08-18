namespace HelloDesktop;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        textBox1.Text = "Loading...";

        await Task.Delay(10000);

        textBox1.Text = "Task completed";
    }
}
