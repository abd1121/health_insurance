using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOAD_Final_Project
{
    public partial class UserView : UserControl
    {
        server.Service1 myService = new server.Service1();
        server.User user;
        int this_index;
        public UserView()
        {
            InitializeComponent();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public UserView(server.User u, int index)
        {
            InitializeComponent();
            user = u;
            ToolTip image_lable = new ToolTip();
            image_lable.SetToolTip(userImage, u.Name);
            this_index = index;
            if(user.UserProfilePic != null)
            {
                userImage.Image = Image.FromFile(user.UserProfilePic);
            }
        }

        private void userDetailsBtn_Click(object sender, EventArgs e)
        {
            myService.deleteUser(this_index.ToString());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            addnewUser edit_user = new addnewUser(user, this_index);
            edit_user.Show();
        }

        private void userImage_Click(object sender, EventArgs e)
        {
            user_details_view udv = new user_details_view(user);
            udv.Show();
        }
    }
}
