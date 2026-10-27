using System.IO;
namespace StudentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string path = Path.Combine(AppContext.BaseDirectory,"..", "..", "..","files", "LoginCredentials.txt");
            string[] credentials = File.ReadAllLines(path);
            bool valid = default;
            foreach(var line in credentials)
            {

                string[] userPass = line.Split(',');
                if (userPass[0] == username && userPass[1] == password)
                {
                    valid = true;
                    break;
                }
                
            }
            if (valid)
            {
                Form2 HomePage = new Form2();
                HomePage.ShowDialog();
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
