namespace WinFormsApp1;

public partial class Form1 : Form
{
    public int counter { get; set; } = 0;
    public Form1()
    {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        string data = await ReadFileAsync();
        richTextBox1.Text = data;
    }
    private void btnCounter_Click(object sender, EventArgs e)
    {
        textBoxCounter.Text = counter++.ToString();
    }

    private string ReadFile()
    {
        string data = string.Empty;
        using (StreamReader s = new StreamReader("dosya.txt"))
        {
            Thread.Sleep(5000);
            data = s.ReadToEnd();
        }
        return data;
    }

    private async Task<string> ReadFileAsync()
    {
        string data = string.Empty;
        using (StreamReader s = new StreamReader("dosya.txt"))
        {
            Task<string> myTask = s.ReadToEndAsync();


            //bu arada yukarýdaki data ile ilgisi olmayan iþlemler yapabilirim.


            data = await myTask;

            return data;
        }
    }

}
