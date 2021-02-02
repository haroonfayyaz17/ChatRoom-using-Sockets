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
    public partial class IndividualChat : Form
    {

        DBController db = new DBController();

        string n;
        bool joinChat = true;
        Client client = new Client();
        String directoryPath;


        public string Send_File()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = directoryPath;
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
            if (filepath != "")
            {
                string filename = Path.GetFileName(filepath);
                System.IO.Directory.CreateDirectory(directoryPath);
                System.IO.File.Copy(filepath, directoryPath + "\\" + filename, true);
            }
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


        public IndividualChat(string name, String path)
        {
            InitializeComponent();
            n = name;
            lblUser.Text = name;
            directoryPath = path;
            client.Udirectory = directoryPath;
            client.Uname = name;

            client.db.LoadIPs(client.IPAddresses, client.ports, client.names, client.directory);

            for (int i = 0; i < client.names.Count; i++)
            {
                listAvailable.Items.Add(client.names[i]);
            }
            listNames.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            //listNames.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            listNames.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (listAvailable.SelectedItems.Count > 0)
                {
                    ListViewItem item = new ListViewItem();
                    item = listAvailable.SelectedItems[0];
                    String text = listAvailable.SelectedItems[0].Text;
                    listSelected.Items.Add(text);
                    listAvailable.Items.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (listSelected.SelectedItems.Count > 0)
                {
                    ListViewItem item = new ListViewItem();
                    item = listSelected.SelectedItems[0];
                    String text = listSelected.SelectedItems[0].Text;
                    listAvailable.Items.Add(text);
                    listSelected.Items.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStartChat_Click(object sender, EventArgs e)
        {
            try
            {
                if (listAvailable.Items.Count > 0)
                {
                    for (int i = 0; i < listAvailable.Items.Count; i++)
                    {
                        int position = client.names.IndexOf(listAvailable.Items[i].ToString());
                        client.names.RemoveAt(position);
                        client.IPAddresses.RemoveAt(position);
                        client.ports.RemoveAt(position);
                        client.directory.RemoveAt(position);

                    }

                }
                client.StartClient();
                client.Bind(client.remEP);
                client.ConnectPeers();
                timer1.Start();
                panelSelectUser.Visible = false;
                groupBox1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            if (joinChat == true)
            {
                listNames.Items.Clear();
                panelViewFiles.Visible = true;
                groupBox1.Visible = false;
                //client.db.LoadIPs(client.IPAddresses, client.ports, client.names, client.directory);
                foreach (var item in client.names)
                {
                    listNames.Items.Add(item);
                }
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
                            listFiles.Items.Add(fileName.Substring(client.directory[i].ToString().Length + 1));
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

        private void IndividualChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.db.deleteIP(client.ip);
        }

        private void IndividualChat_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnLoadChat_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            panelLoadChat.Visible = true;
            GridLoadChat.Rows.Clear();
        }

        private void btnCloseLoad_Click(object sender, EventArgs e)
        {
            panelLoadChat.Visible = false;
            groupBox1.Visible = true;
        }

       

    }
}
