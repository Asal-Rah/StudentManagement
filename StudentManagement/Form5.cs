using Newtonsoft.Json;
using StudentManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            showProfile();
        }

        public void showProfile(string firstname = null, string lastname = null)
        {

            if (firstname == null & lastname == null)
            {
                return;
            }

            List<Student> students = Form4.GetStudents(name: firstname, lastname: lastname);

            foreach (var std in students)
            {
                ProfileTextBox.Text = $" Name: {std.firstName}{Environment.NewLine} LastName: {std.lastName}{Environment.NewLine} Phone Number: {std.phoneNumber}{Environment.NewLine} National code: {std.nationalCode}{Environment.NewLine}";
                string profilePicturePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "images", $"{std.nationalCode}.jpg");
                
                Image? newImage = null;

                if (File.Exists(profilePicturePath))
                {
                    using Image loadedImage = Image.FromFile(profilePicturePath);

                    // Create an independent copy
                    newImage = new Bitmap(loadedImage);
                }

                Image? previousImage = ProfilePicture.Image;

                ProfilePicture.Image = newImage;
                ProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;

                previousImage?.Dispose();
            }



        }


        private void ProfileButton_Click(object sender, EventArgs e)
        {
            showProfile(ProfileFirstNametextBox.Text, ProfileLastNametextBox.Text);
        }

        private void ProfilePictureButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select a Picture";

            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Load a copy so the original image file isn't locked
                using Image original = Image.FromFile(dialog.FileName);
                Image selectedImage = new Bitmap(original);

                Image? previousImage = ProfilePicture.Image;

                ProfilePicture.Image = selectedImage;
                ProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;

                List<Student> students = Form4.GetStudents(name: ProfileFirstNametextBox.Text, lastname: ProfileLastNametextBox.Text);

                foreach (var std in students)
                {
                    string savePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "images", $"{std.nationalCode}.jpg");
                    selectedImage.Save(
                           savePath,
                           System.Drawing.Imaging.ImageFormat.Png
                    );
                }
                
               
                previousImage?.Dispose();
            }
        }
    }
}
