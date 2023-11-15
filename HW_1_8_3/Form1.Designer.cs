namespace HW_1_8_3;

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
        input1 = new TextBox();
        input2 = new TextBox();
        radioButton1 = new RadioButton();
        result = new TextBox();
        Calculate = new Button();
        radioButton2 = new RadioButton();
        radioButton3 = new RadioButton();
        radioButton4 = new RadioButton();
        Clear = new Button();
        SuspendLayout();
        // 
        // input1
        // 
        input1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        input1.Location = new Point(33, 12);
        input1.Multiline = true;
        input1.Name = "input1";
        input1.Size = new Size(110, 40);
        input1.TabIndex = 0;
        input1.TextChanged += textBox1_TextChanged;
        // 
        // input2
        // 
        input2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        input2.Location = new Point(172, 12);
        input2.Multiline = true;
        input2.Name = "input2";
        input2.Size = new Size(110, 40);
        input2.TabIndex = 1;
        input2.TextChanged += textBox2_TextChanged;
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        radioButton1.Location = new Point(33, 67);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(212, 25);
        radioButton1.TabIndex = 2;
        radioButton1.TabStop = true;
        radioButton1.Text = "Remainder from division";
        radioButton1.UseVisualStyleBackColor = true;
        radioButton1.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // result
        // 
        result.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        result.Location = new Point(311, 12);
        result.Multiline = true;
        result.Name = "result";
        result.Size = new Size(110, 40);
        result.TabIndex = 6;
        result.TextChanged += textBox3_TextChanged;
        // 
        // Calculate
        // 
        Calculate.FlatStyle = FlatStyle.Flat;
        Calculate.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        Calculate.Location = new Point(33, 227);
        Calculate.Name = "Calculate";
        Calculate.Size = new Size(110, 40);
        Calculate.TabIndex = 7;
        Calculate.Text = "Calculate";
        Calculate.UseVisualStyleBackColor = true;
        Calculate.Click += button1_Click;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        radioButton2.Location = new Point(33, 107);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(80, 25);
        radioButton2.TabIndex = 8;
        radioButton2.TabStop = true;
        radioButton2.Text = "Degree";
        radioButton2.UseVisualStyleBackColor = true;
        radioButton2.CheckedChanged += radioButton2_CheckedChanged;
        // 
        // radioButton3
        // 
        radioButton3.AutoSize = true;
        radioButton3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        radioButton3.Location = new Point(33, 147);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new Size(135, 25);
        radioButton3.TabIndex = 9;
        radioButton3.TabStop = true;
        radioButton3.Text = "Concatenation";
        radioButton3.UseVisualStyleBackColor = true;
        // 
        // radioButton4
        // 
        radioButton4.AutoSize = true;
        radioButton4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        radioButton4.Location = new Point(33, 187);
        radioButton4.Name = "radioButton4";
        radioButton4.Size = new Size(89, 25);
        radioButton4.TabIndex = 10;
        radioButton4.TabStop = true;
        radioButton4.Text = "Division";
        radioButton4.UseVisualStyleBackColor = true;
        radioButton4.CheckedChanged += radioButton4_CheckedChanged;
        // 
        // Clear
        // 
        Clear.FlatStyle = FlatStyle.Flat;
        Clear.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        Clear.Location = new Point(172, 227);
        Clear.Name = "Clear";
        Clear.Size = new Size(110, 40);
        Clear.TabIndex = 11;
        Clear.Text = "Clear";
        Clear.UseVisualStyleBackColor = true;
        Clear.Click += Clear_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(434, 338);
        Controls.Add(Clear);
        Controls.Add(radioButton4);
        Controls.Add(radioButton3);
        Controls.Add(radioButton2);
        Controls.Add(Calculate);
        Controls.Add(result);
        Controls.Add(radioButton1);
        Controls.Add(input2);
        Controls.Add(input1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox input1;
    private TextBox input2;
    private RadioButton radioButton1;
    private TextBox result;
    private Button Calculate;
    private RadioButton radioButton2;
    private RadioButton radioButton3;
    private RadioButton radioButton4;
    private Button Clear;
}