namespace WinFormsApp1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        BtnReadFile = new Button();
        richTextBox1 = new RichTextBox();
        btnCounter = new Button();
        textBoxCounter = new TextBox();
        SuspendLayout();
        // 
        // BtnReadFile
        // 
        BtnReadFile.Location = new Point(86, 58);
        BtnReadFile.Name = "BtnReadFile";
        BtnReadFile.Size = new Size(75, 23);
        BtnReadFile.TabIndex = 0;
        BtnReadFile.Text = "Dosya Oku";
        BtnReadFile.UseVisualStyleBackColor = true;
        BtnReadFile.Click += button1_Click;
        // 
        // richTextBox1
        // 
        richTextBox1.Location = new Point(86, 87);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(100, 96);
        richTextBox1.TabIndex = 1;
        richTextBox1.Text = "";
        // 
        // btnCounter
        // 
        btnCounter.Location = new Point(532, 88);
        btnCounter.Name = "btnCounter";
        btnCounter.Size = new Size(75, 23);
        btnCounter.TabIndex = 2;
        btnCounter.Text = "Sayaç arttır";
        btnCounter.UseVisualStyleBackColor = true;
        btnCounter.Click += btnCounter_Click;
        // 
        // textBoxCounter
        // 
        textBoxCounter.Location = new Point(370, 118);
        textBoxCounter.Name = "textBoxCounter";
        textBoxCounter.Size = new Size(100, 23);
        textBoxCounter.TabIndex = 3;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(textBoxCounter);
        Controls.Add(btnCounter);
        Controls.Add(richTextBox1);
        Controls.Add(BtnReadFile);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button BtnReadFile;
    private RichTextBox richTextBox1;
    private Button btnCounter;
    private TextBox textBoxCounter;
}
