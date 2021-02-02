namespace ChatRoomClient
{
    partial class PeerChatRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViewFiles = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.GridMsg = new System.Windows.Forms.DataGridView();
            this.Msg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnJoinChat = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelViewFiles = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.listFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listNames = new System.Windows.Forms.ListView();
            this.headerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelLoadChat = new System.Windows.Forms.Panel();
            this.btnCloseLoad = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.GridLoadChat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnLoadChat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMsg)).BeginInit();
            this.panelViewFiles.SuspendLayout();
            this.panelLoadChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLoadChat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadChat);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.btnViewFiles);
            this.groupBox1.Controls.Add(this.btnSendFile);
            this.groupBox1.Controls.Add(this.GridMsg);
            this.groupBox1.Controls.Add(this.btnJoinChat);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.txtMsg);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-4, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1317, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ChatRoom";
            // 
            // btnViewFiles
            // 
            this.btnViewFiles.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewFiles.Location = new System.Drawing.Point(1080, 256);
            this.btnViewFiles.Name = "btnViewFiles";
            this.btnViewFiles.Size = new System.Drawing.Size(192, 42);
            this.btnViewFiles.TabIndex = 3;
            this.btnViewFiles.Text = "&View Files";
            this.btnViewFiles.UseVisualStyleBackColor = false;
            this.btnViewFiles.Click += new System.EventHandler(this.btnViewFiles_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendFile.Location = new System.Drawing.Point(1080, 444);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(192, 42);
            this.btnSendFile.TabIndex = 3;
            this.btnSendFile.Text = "Send &File";
            this.btnSendFile.UseVisualStyleBackColor = false;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // GridMsg
            // 
            this.GridMsg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridMsg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridMsg.BackgroundColor = System.Drawing.Color.White;
            this.GridMsg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMsg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Msg});
            this.GridMsg.Location = new System.Drawing.Point(99, 202);
            this.GridMsg.Name = "GridMsg";
            this.GridMsg.RowTemplate.Height = 24;
            this.GridMsg.Size = new System.Drawing.Size(929, 317);
            this.GridMsg.TabIndex = 5;
            // 
            // Msg
            // 
            this.Msg.HeaderText = "Message";
            this.Msg.Name = "Msg";
            // 
            // btnJoinChat
            // 
            this.btnJoinChat.Location = new System.Drawing.Point(82, 55);
            this.btnJoinChat.Name = "btnJoinChat";
            this.btnJoinChat.Size = new System.Drawing.Size(145, 40);
            this.btnJoinChat.TabIndex = 4;
            this.btnJoinChat.Text = "&Join Chat";
            this.btnJoinChat.UseVisualStyleBackColor = true;
            this.btnJoinChat.Click += new System.EventHandler(this.btnJoinChat_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSend.Location = new System.Drawing.Point(809, 115);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(118, 42);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(284, 112);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(496, 36);
            this.txtMsg.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(501, 55);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(134, 30);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Enter msg:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter msg:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelViewFiles
            // 
            this.panelViewFiles.Controls.Add(this.btnClose);
            this.panelViewFiles.Controls.Add(this.listFiles);
            this.panelViewFiles.Controls.Add(this.listNames);
            this.panelViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewFiles.Location = new System.Drawing.Point(0, 0);
            this.panelViewFiles.Name = "panelViewFiles";
            this.panelViewFiles.Size = new System.Drawing.Size(1309, 530);
            this.panelViewFiles.TabIndex = 6;
            this.panelViewFiles.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(293, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 42);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listFiles
            // 
            this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listFiles.Font = new System.Drawing.Font("Verdana", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFiles.FullRowSelect = true;
            this.listFiles.GridLines = true;
            this.listFiles.Location = new System.Drawing.Point(660, 76);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(451, 328);
            this.listFiles.TabIndex = 1;
            this.listFiles.UseCompatibleStateImageBehavior = false;
            this.listFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Files";
            this.columnHeader1.Width = 200;
            // 
            // listNames
            // 
            this.listNames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerName});
            this.listNames.Font = new System.Drawing.Font("Verdana", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNames.FullRowSelect = true;
            this.listNames.GridLines = true;
            this.listNames.Location = new System.Drawing.Point(78, 76);
            this.listNames.MultiSelect = false;
            this.listNames.Name = "listNames";
            this.listNames.Size = new System.Drawing.Size(451, 328);
            this.listNames.TabIndex = 0;
            this.listNames.UseCompatibleStateImageBehavior = false;
            this.listNames.View = System.Windows.Forms.View.Details;
            this.listNames.DoubleClick += new System.EventHandler(this.listNames_DoubleClick);
            // 
            // headerName
            // 
            this.headerName.Text = "Name";
            this.headerName.Width = 130;
            // 
            // panelLoadChat
            // 
            this.panelLoadChat.Controls.Add(this.btnCloseLoad);
            this.panelLoadChat.Controls.Add(this.btnOpenFile);
            this.panelLoadChat.Controls.Add(this.GridLoadChat);
            this.panelLoadChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoadChat.Font = new System.Drawing.Font("Tahoma", 13.824F);
            this.panelLoadChat.Location = new System.Drawing.Point(0, 0);
            this.panelLoadChat.Name = "panelLoadChat";
            this.panelLoadChat.Size = new System.Drawing.Size(1309, 530);
            this.panelLoadChat.TabIndex = 7;
            this.panelLoadChat.Visible = false;
            // 
            // btnCloseLoad
            // 
            this.btnCloseLoad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCloseLoad.Location = new System.Drawing.Point(1036, 41);
            this.btnCloseLoad.Name = "btnCloseLoad";
            this.btnCloseLoad.Size = new System.Drawing.Size(192, 42);
            this.btnCloseLoad.TabIndex = 8;
            this.btnCloseLoad.Text = "&Close";
            this.btnCloseLoad.UseVisualStyleBackColor = false;
            this.btnCloseLoad.Click += new System.EventHandler(this.btnCloseLoad_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenFile.Location = new System.Drawing.Point(20, 41);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(192, 42);
            this.btnOpenFile.TabIndex = 7;
            this.btnOpenFile.Text = "&OpenFile";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // GridLoadChat
            // 
            this.GridLoadChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridLoadChat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridLoadChat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridLoadChat.BackgroundColor = System.Drawing.Color.White;
            this.GridLoadChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLoadChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.GridLoadChat.Location = new System.Drawing.Point(0, 110);
            this.GridLoadChat.Name = "GridLoadChat";
            this.GridLoadChat.RowTemplate.Height = 24;
            this.GridLoadChat.Size = new System.Drawing.Size(1313, 598);
            this.GridLoadChat.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Message";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackup.Location = new System.Drawing.Point(1080, 133);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(192, 42);
            this.btnBackup.TabIndex = 6;
            this.btnBackup.Text = "&Backup Chat";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnLoadChat
            // 
            this.btnLoadChat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoadChat.Location = new System.Drawing.Point(1080, 63);
            this.btnLoadChat.Name = "btnLoadChat";
            this.btnLoadChat.Size = new System.Drawing.Size(192, 42);
            this.btnLoadChat.TabIndex = 7;
            this.btnLoadChat.Text = "&Load Chat";
            this.btnLoadChat.UseVisualStyleBackColor = false;
            this.btnLoadChat.Click += new System.EventHandler(this.btnLoadChat_Click);
            // 
            // PeerChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1309, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelLoadChat);
            this.Controls.Add(this.panelViewFiles);
            this.Name = "PeerChatRoom";
            this.Text = "PeerChatRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PeerChatRoom_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PeerChatRoom_FormClosed);
            this.Load += new System.EventHandler(this.PeerChatRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMsg)).EndInit();
            this.panelViewFiles.ResumeLayout(false);
            this.panelLoadChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridLoadChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnJoinChat;
        private System.Windows.Forms.DataGridView GridMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Msg;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnViewFiles;
        private System.Windows.Forms.Panel panelViewFiles;
        private System.Windows.Forms.ListView listNames;
        private System.Windows.Forms.ColumnHeader headerName;
        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelLoadChat;
        private System.Windows.Forms.Button btnCloseLoad;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.DataGridView GridLoadChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnLoadChat;
    }
}