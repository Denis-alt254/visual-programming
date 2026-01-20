using System;
using System.Windows.Forms;

class LoginForm : Form
{
    TextBox txtName;
    Button btnSubmit;
    Label lblResult;

    public LoginForm()
    {
        this.Text = "Simple Form";
        this.Size = new System.Drawing.Size(400, 250);

        txtName = new TextBox();
        txtName.Location = new System.Drawing.Point(120, 40);

        btnSubmit = new Button();
        btnSubmit.Text = "Submit";
        btnSubmit.Location = new System.Drawing.Point(120, 80);
        btnSubmit.Click += BtnSubmit_Click;

        lblResult = new Label();
        lblResult.Location = new System.Drawing.Point(120, 120);
        lblResult.AutoSize = true;

        this.Controls.Add(txtName);
        this.Controls.Add(btnSubmit);
        this.Controls.Add(lblResult);
    }

    private void BtnSubmit_Click(object sender, EventArgs e)
    {
        lblResult.Text = "Hello " + txtName.Text;
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new LoginForm());
    }
}
