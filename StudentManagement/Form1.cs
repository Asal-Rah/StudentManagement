using StudentManagement.BusinessLayer.Dtos;
using StudentManagement.BusinessLayer.Functionality;
using System.IO;
namespace StudentManagement
{
    public partial class Form1 : Form
    {

        private readonly string _path;
        private readonly string _type;
        public Form1(string path , string type )
        {
            InitializeComponent();
            _type = type;
            _path = path;

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

           
            UserDto LoginDto = new UserDto()
            {
                userName = usernameTextBox.Text, 
                password = passwordTextBox.Text,
            };
            bool valid = Login.LoginUser(LoginDto, _path);
            if (valid)
            {
                if(_type.Equals("admin"))
                {
                    Form2 HomePage = new Form2();
                    HomePage.ShowDialog();
                }
                else if (_type.Equals("student"))
                {
                    Form13 StudentDashboard = new Form13();
                    StudentDashboard.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("The Username or Password are incorrect!");
                passwordTextBox.Text = string.Empty;
                usernameTextBox.Text = string.Empty;
            }


        }
    }
}
