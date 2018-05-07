using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace OOAD_Final_Project
{
    public partial class user_details_view : Form
    {
        public user_details_view()
        {
            InitializeComponent();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public user_details_view(server.User u)
        {
            InitializeComponent();
            userName.Text = u.Name;
            userEmail.Text = u.Email;
            userPhone.Text = u.Phone;
            userPass.Text = u.Password;
            user_name.Text = u.Username;
            userImage.Image = Image.FromFile(myUtil.loggedIN.UserProfilePic);
        }

        private void exitMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
