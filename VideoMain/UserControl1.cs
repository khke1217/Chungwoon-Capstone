using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoMain
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            //초기화 과정에서 내부 데이터베이스와 연결될 것
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            listView1.Visible = false;
            ListViewItem Selected = listView1.Items[listView1.SelectedIndices[0]];
            pictureBox1.Image = imageList1.Images[Selected.ImageIndex];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.ImageLocation = Selected.SubItems[0].Text;
            if (pictureBox2.Image == pictureBox2.ErrorImage)
            {
                TitleLable.Text = Selected.Text;
            }
            

        }
    }
}
