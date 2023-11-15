namespace HW_1_8_3;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }
    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void radioButton4_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        double operand1, operand2;
        operand1 = Convert.ToDouble(input1.Text);
        operand2 = Convert.ToDouble(input2.Text);

        if (radioButton1.Checked == true)
        {
            result.Text = Convert.ToString(operand1 % operand2);

        }

        if (radioButton2.Checked == true)
        {
            result.Text = Convert.ToString(Math.Pow(operand1, operand2));

        }

        if (radioButton3.Checked == true)
        {
            result.Text = Convert.ToString(operand1 + operand2);

        }

        if (radioButton4.Checked == true)
        {
            result.Text = Convert.ToString(operand1 / operand2);
        }
    }

    //private void button2_Click(object sender, EventArgs e)
    //{
    //    input1.Text = "";
    //    input2.Text = "";
    //    result.Text = "";

    //}

    private void Clear_Click(object sender, EventArgs e)
    {
        input1.Text = "";
        input2.Text = "";
        result.Text = "";
    }
}


