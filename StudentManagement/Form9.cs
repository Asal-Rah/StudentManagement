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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        public void showProfile(string firstname = null, string lastname = null)
        {

            if (firstname == null & lastname == null)
            {
                return;
            }

            List<Professor> profs = Form8.GetProfessors(name: firstname, lastname: lastname);

            foreach (var prof in profs)
            {
                ProfProfileTextBox.Text = $" Name: {prof.firstName}{Environment.NewLine} LastName: {prof.lastName}{Environment.NewLine} Phone Number: {prof.phoneNumber}{Environment.NewLine} National code: {prof.nationalCode}{Environment.NewLine}";
                string profilePicturePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "images", $"{prof.nationalCode}.jpg");

                Image? newImage = null;

                if (File.Exists(profilePicturePath))
                {
                    using Image loadedImage = Image.FromFile(profilePicturePath);

                    // Create an independent copy
                    newImage = new Bitmap(loadedImage);
                }

                Image? previousImage = ProfProfilePicture.Image;

                ProfProfilePicture.Image = newImage;
                ProfProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;

                previousImage?.Dispose();
            }



        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            showProfile(ProfProfileFirstNametextBox.Text, ProfProfileLastNameTextbox.Text);
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

                Image? previousImage = ProfProfilePicture.Image;

                ProfProfilePicture.Image = selectedImage;
                ProfProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;

                List<Professor> profs = Form8.GetProfessors(name: ProfProfileFirstNametextBox.Text, lastname: ProfProfileLastNameTextbox.Text);

                foreach (var prof in profs)
                {
                    string savePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "images", $"{prof.nationalCode}.jpg");
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
