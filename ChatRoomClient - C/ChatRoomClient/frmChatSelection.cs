using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatRoomClient
{
    public partial class frmChatSelection : Form
    {
        String name, path;
        public frmChatSelection(String name,String path)
        {
            InitializeComponent();
            this.name = name;
            this.path = path;
        }

        private void btnIndividual_Click(object sender, EventArgs e)
        {
            IndividualChat frm = new IndividualChat(name, path);
            this.Hide();
            frm.Show();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            PeerChatRoom frm = new PeerChatRoom(name, path);
            this.Hide();
            frm.Show();
        }
    }
}
