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
        string data = string.Empty;

        Task<string> okuma = ReadFileAsync();

        richTextBox2.Text = await new HttpClient().GetStringAsync("https://www.google.com");

        data = await okuma;

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
            Thread.Sleep(5000);
            data = await myTask;

            return data;
        }
    }

    private Task<string> ReadFileAsync2()
    {
        using (StreamReader s = new StreamReader("dosya.txt"))
        {
            return s.ReadToEndAsync();
        }
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
