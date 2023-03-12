using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2116976_LyThuyetBuoi2
{
    public partial class frm6 : Form
    {
        public frm6()
        {
            InitializeComponent();
        }

        private void frm6_Load(object sender, EventArgs e)
        {
            ImageList imageListS1 = new ImageList();
            
            // add images to the image list
            imageListS1.Images.Add(Image.FromFile("Asset/img1.png"));
            imageListS1.Images.Add(Image.FromFile("Asset/img2.png"));
            imageListS1.Images.Add(Image.FromFile("Asset/img3.png"));
            imageListS1.Images.Add(Image.FromFile("Asset/img4.png"));

            imageListS1.Images.Add(Image.FromFile("Asset/img5.png"));

            imageListS1.Images.Add(Image.FromFile("Asset/img6.png"));

            imageListS1.Images.Add(Image.FromFile("Asset/img7.png"));

            imageListS1.ImageSize = new Size(32, 32);

            // attach the image list to a control on the form
            listView1.SmallImageList= imageListS1;
            int count = imageListS1.Images.Count;
        }
    }
}
