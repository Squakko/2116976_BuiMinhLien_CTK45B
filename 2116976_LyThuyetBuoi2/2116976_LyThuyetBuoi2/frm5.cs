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
    public partial class frm5 : Form
    {
        public frm5()
        {
            InitializeComponent();
        }

        private void frm5_Load(object sender, EventArgs e)
        {
            // create a new ContextMenuStrip control
            ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();

            // add items to the context menu strip
            contextMenuStrip1.Items.Add("Cut");
            contextMenuStrip1.Items.Add("Copy");
            contextMenuStrip1.Items.Add("Paste");

            // attach the context menu strip to a control on the form
            label1.ContextMenuStrip = contextMenuStrip1;
        }
    }
}
