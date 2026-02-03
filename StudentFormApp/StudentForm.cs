using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace StudentFormApp
{
    public class StudentForm : Form
    {
        Label lblName, lblRegNo, lblCourse, lblAge;
        TextBox txtName, txtRegNo, txtCourse, txtAge;
        Button btnSubmit;

        public StudentForm()
        {
            this.Text = "Student Details Form";
            this.Width = 400;
            this.Height = 350;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Labels
            lblName = new Label() { Text = "Name:", Left = 30, Top = 30 };
            lblRegNo = new Label() { Text = "Reg No:", Left = 30, Top = 70 };
            lblCourse = new Label() { Text = "Course:", Left = 30, Top = 110 };
            lblAge = new Label() { Text = "Age:", Left = 30, Top = 150 };

            // TextBoxes
            txtName = new TextBox() { Left = 130, Top = 30, Width = 200 };
            txtRegNo = new TextBox() { Left = 130, Top = 70, Width = 200 };
            txtCourse = new TextBox() { Left = 130, Top = 110, Width = 200 };
            txtAge = new TextBox() { Left = 130, Top = 150, Width = 200 };

            // Button
            btnSubmit = new Button()
            {
                Text = "Submit",
                Left = 120,
                Top = 200,
                Width = 100
            };

            btnSubmit.Click += Submit_Click;

            // Add controls to form
            this.Controls.Add(lblName);
            this.Controls.Add(lblRegNo);
            this.Controls.Add(lblCourse);
            this.Controls.Add(lblAge);
            this.Controls.Add(txtName);
            this.Controls.Add(txtRegNo);
            this.Controls.Add(txtCourse);
            this.Controls.Add(txtAge);
            this.Controls.Add(btnSubmit);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Age must be a number");
                return;
            }

            using (SqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO students(name, reg_no, course, age)
                                    VALUES (@name, @reg, @course, @age)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@reg", txtRegNo.Text);
                        cmd.Parameters.AddWithValue("@course", txtCourse.Text);
                        cmd.Parameters.AddWithValue("@age", age);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Student saved successfully!");

                    txtName.Clear();
                    txtRegNo.Clear();
                    txtCourse.Clear();
                    txtAge.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error:\n" + ex.Message);
                }
            }
        }

}
}
