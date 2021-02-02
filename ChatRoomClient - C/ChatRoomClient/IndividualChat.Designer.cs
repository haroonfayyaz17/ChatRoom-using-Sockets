namespace ChatRoomClient
{
    partial class IndividualChat
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
            this.btnLoadChat = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnViewFiles = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.GridMsg = new System.Windows.Forms.DataGridView();
            this.Msg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSelectUser = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStartChat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listSelected = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listAvailable = new System.Windows.Forms.ListView();
            this.headerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelViewFiles = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.listFiles = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listNames = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelLoadChat = new System.Windows.Forms.Panel();
            this.btnCloseLoad = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.GridLoadChat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMsg)).BeginInit();
            this.panelSelectUser.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.txtMsg);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1287, 710);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ChatRoom";
            this.groupBox1.Visible = false;
            // 
            // btnLoadChat
            // 
            this.btnLoadChat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoadChat.Location = new System.Drawing.Point(1080, 115);
            this.btnLoadChat.Name = "btnLoadChat";
            this.btnLoadChat.Size = new System.Drawing.Size(192, 42);
            this.btnLoadChat.TabIndex = 3;
            this.btnLoadChat.Text = "&Load Chat";
            this.btnLoadChat.UseVisualStyleBackColor = false;
            this.btnLoadChat.Click += new System.EventHandler(this.btnLoadChat_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackup.Location = new System.Drawing.Point(1080, 48);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(192, 42);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "&Backup Chat";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
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
            this.GridMsg.Size = new System.Drawing.Size(929, 464);
            this.GridMsg.TabIndex = 5;
            // 
            // Msg
            // 
            this.Msg.HeaderText = "Message";
            this.Msg.Name = "Msg";
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
            // panelSelectUser
            // 
            this.panelSelectUser.Controls.Add(this.btnRemove);
            this.panelSelectUser.Controls.Add(this.btnAdd);
            this.panelSelectUser.Controls.Add(this.btnStartChat);
            this.panelSelectUser.Controls.Add(this.label3);
            this.panelSelectUser.Controls.Add(this.label2);
            this.panelSelectUser.Controls.Add(this.listSelected);
            this.panelSelectUser.Controls.Add(this.listAvailable);
            this.panelSelectUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelectUser.Location = new System.Drawing.Point(0, 0);
            this.panelSelectUser.Name = "panelSelectUser";
            this.panelSelectUser.Size = new System.Drawing.Size(1287, 708);
            this.panelSelectUser.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Font = new System.Drawing.Font("Verdana", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(552, 263);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(127, 42);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(552, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 42);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStartChat
            // 
            this.btnStartChat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStartChat.Font = new System.Drawing.Font("Verdana", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartChat.Location = new System.Drawing.Point(956, 505);
            this.btnStartChat.Name = "btnStartChat";
            this.btnStartChat.Size = new System.Drawing.Size(192, 42);
            this.btnStartChat.TabIndex = 5;
            this.btnStartChat.Text = "&Start Chat";
            this.btnStartChat.UseVisualStyleBackColor = false;
            this.btnStartChat.Click += new System.EventHandler(this.btnStartChat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(680, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selected Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available Users";
            // 
            // listSelected
            // 
            this.listSelected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listSelected.Font = new System.Drawing.Font("Verdana", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSelected.FullRowSelect = true;
            this.listSelected.GridLines = true;
            this.listSelected.Location = new System.Drawing.Point(685, 99);
            this.listSelected.MultiSelect = false;
            this.listSelected.Name = "listSelected";
            this.listSelected.Size = new System.Drawing.Size(463, 367);
            this.listSelected.TabIndex = 2;
            this.listSelected.UseCompatibleStateImageBehavior = false;
            this.listSelected.View = System.Windows.Forms.View.Details;
            this.listSelected.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 130;
            // 
            // listAvailable
            // 
            this.listAvailable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerName});
            this.listAvailable.Font = new System.Drawing.Font("Verdana", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAvailable.FullRowSelect = true;
            this.listAvailable.GridLines = true;
            this.listAvailable.Location = new System.Drawing.Point(83, 99);
            this.listAvailable.MultiSelect = false;
            this.listAvailable.Name = "listAvailable";
            this.listAvailable.Size = new System.Drawing.Size(463, 367);
            this.listAvailable.TabIndex = 1;
            this.listAvailable.UseCompatibleStateImageBehavior = false;
            this.listAvailable.View = System.Windows.Forms.View.Details;
            // 
            // headerName
            // 
            this.headerName.Text = "Name";
            this.headerName.Width = 130;
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
            this.panelViewFiles.Size = new System.Drawing.Size(1287, 708);
            this.panelViewFiles.TabIndex = 7;
            this.panelViewFiles.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(507, 447);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(172, 42);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listFiles
            // 
            this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
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
            // columnHeader2
            // 
            this.columnHeader2.Text = "Files";
            this.columnHeader2.Width = 500;
            // 
            // listNames
            // 
            this.listNames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 130;
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
            this.panelLoadChat.Size = new System.Drawing.Size(1287, 708);
            this.panelLoadChat.TabIndex = 6;
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
            this.GridLoadChat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridLoadChat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridLoadChat.BackgroundColor = System.Drawing.Color.White;
            this.GridLoadChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLoadChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.GridLoadChat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridLoadChat.Location = new System.Drawing.Point(0, 110);
            this.GridLoadChat.Name = "GridLoadChat";
            this.GridLoadChat.RowTemplate.Height = 24;
            this.GridLoadChat.Size = new System.Drawing.Size(1287, 598);
            this.GridLoadChat.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Message";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // IndividualChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1287, 708);
            this.Controls.Add(this.panelLoadChat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelViewFiles);
            this.Controls.Add(this.panelSelectUser);
            this.Name = "IndividualChat";
            this.Text = "IndividualChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IndividualChat_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IndividualChat_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMsg)).EndInit();
            this.panelSelectUser.ResumeLayout(false);
            this.panelSelectUser.PerformLayout();
            this.panelViewFiles.ResumeLayout(false);
            this.panelLoadChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridLoadChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewFiles;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.DataGridView GridMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Msg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSelectUser;
        private System.Windows.Forms.ListView listSelected;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listAvailable;
        private System.Windows.Forms.ColumnHeader headerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartChat;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelViewFiles;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listNames;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnLoadChat;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Panel panelLoadChat;
        private System.Windows.Forms.DataGridView GridLoadChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnCloseLoad;
    }
}