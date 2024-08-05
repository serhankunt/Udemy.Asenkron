namespace TaskThreadApp;

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
        progressBar1 = new ProgressBar();
        progressBar2 = new ProgressBar();
        btnStart = new Button();
        btnCounter = new Button();
        SuspendLayout();
        // 
        // progressBar1
        // 
        progressBar1.Location = new Point(23, 116);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(752, 23);
        progressBar1.TabIndex = 0;
        // 
        // progressBar2
        // 
        progressBar2.Location = new Point(23, 73);
        progressBar2.Name = "progressBar2";
        progressBar2.Size = new Size(752, 23);
        progressBar2.TabIndex = 1;
        // 
        // btnStart
        // 
        btnStart.Location = new Point(23, 25);
        btnStart.Name = "btnStart";
        btnStart.Size = new Size(75, 23);
        btnStart.TabIndex = 2;
        btnStart.Text = "Başlat";
        btnStart.UseVisualStyleBackColor = true;
        btnStart.Click += btnStart_Click;
        // 
        // btnCounter
        // 
        btnCounter.Location = new Point(150, 25);
        btnCounter.Name = "btnCounter";
        btnCounter.Size = new Size(75, 23);
        btnCounter.TabIndex = 3;
        btnCounter.Text = "Sayaç";
        btnCounter.UseVisualStyleBackColor = true;
        btnCounter.Click += btnCounter_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnCounter);
        Controls.Add(btnStart);
        Controls.Add(progressBar2);
        Controls.Add(progressBar1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private ProgressBar progressBar1;
    private ProgressBar progressBar2;
    private Button btnStart;
    private Button btnCounter;
}
