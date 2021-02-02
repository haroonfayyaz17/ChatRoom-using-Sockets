using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatRoomClient
{
    public partial class PeerChatRoom : Form
    {
        string n;
        bool joinChat = false;
        Client client = new Client();
        String directory;


        public string Send_File()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = directory;
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null;
        }
        public void Receive_File(string filepath)
        {
            string filename = Path.GetFileName(filepath);
            System.IO.Directory.CreateDirectory(directory);
            System.IO.File.Copy(filepath, directory + "\\" + filename, true);

        }
        public void refreshMsgs()
        {
            GridMsg.Rows.Clear();
            foreach (var item in client.clientMsgs)
            {
                GridMsg.Rows.Add(item);
            }
            if (client.fileReceived == true)
            {
                Receive_File(client.filepath);
                client.fileReceived = false;

            }
        }

        public PeerChatRoom(string name, String path)
        {
            InitializeComponent();
            n = name;
            lblUser.Text = name;
            directory = path;
            client.Udirectory = directory;
            client.Uname = name;
            listNames.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            //listNames.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            listNames.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            //listFiles.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (joinChat == true)
            {
                string msg = "#" + n + ": " + txtMsg.Text + "---" + DateTime.Now.ToShortTimeString();
                client.SendMsg(msg);
                client.clientMsgs.Add(msg.Substring(1));
                txtMsg.Text = "";

            }
        }

        private void PeerChatRoom_Load(object sender, EventArgs e)
        {

        }

        private void btnJoinChat_Click(object sender, EventArgs e)
        {
            joinChat = true;
            string msg = n + " joined the chatroom";
            client.StartClient();
            client.Bind(client.remEP);
            client.ConnectPeers();
            //client.SendMsg(msg);
            //GridMsg.Rows.Add(msg);
            //ReceiveMsg();
            timer1.Start();
            btnJoinChat.Enabled = false;
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            //btnLoad_Click(sender, e);
            refreshMsgs();
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            String filePath = Send_File();
            if (joinChat == true && filePath != "")
            {
                string msg = "@" + n + "~" + filePath;
                client.SendMsg(msg);
                client.clientMsgs.Add("File Sent");
                txtMsg.Text = "";

            }
        }

        private void btnViewFiles_Click(object sender, EventArgs e)
        {
            listNames.Items.Clear();
            groupBox1.Visible = false;
            panelViewFiles.Visible = true;

            foreach (var item in client.names)
            {
                listNames.Items.Add(item);
            }
        }

        private void listNames_DoubleClick(object sender, EventArgs e)
        {
            if (listNames.SelectedItems.Count > 0)
            {
                String text = listNames.SelectedItems[0].Text;
                listFiles.Items.Clear();
                for (int i = 0; i < client.names.Count; i++)
                {
                    if (client.names[i] == text)
                    {
                        string[] fileEntries = Directory.GetFiles(client.directory[i]);
                        foreach (string fileName in fileEntries)
                        {
                            listFiles.Items.Add(fileName.Substring(directory[i].ToString().Length + 1));
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelViewFiles.Visible = false;
            groupBox1.Visible = true;
        }

        private void PeerChatRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.db.deleteIP(client.ip);
        }

        private void PeerChatRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.db.deleteIP(client.ip);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Files|*.txt";
                ofd.ShowDialog();
                String path = ofd.FileName;
                StreamReader file = new StreamReader(path);
                String line = file.ReadLine();
                while (line != null)
                {
                    GridLoadChat.Rows.Add(line);
                    line = file.ReadLine();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnCloseLoad_Click(object sender, EventArgs e)
        {
            panelLoadChat.Visible = false;
            groupBox1.Visible = true;
        }

        private void btnLoadChat_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            panelLoadChat.Visible = true;
            GridLoadChat.Rows.Clear();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files|*.txt";
                sfd.ShowDialog();
                String path = sfd.FileName;

                StreamWriter file = new StreamWriter(path);
                foreach (string line in client.clientMsgs)
                {
                    file.WriteLine(line);
                }
                file.Close();
                MessageBox.Show("Chat Backup Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
