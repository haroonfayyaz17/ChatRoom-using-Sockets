namespace ChatRoomClient
{
    partial class frmChatSelection
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
            this.btnIndividual = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIndividual
            // 
            this.btnIndividual.BackColor = System.Drawing.Color.Green;
            this.btnIndividual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIndividual.Location = new System.Drawing.Point(528, 177);
            this.btnIndividual.Name = "btnIndividual";
            this.btnIndividual.Size = new System.Drawing.Size(214, 41);
            this.btnIndividual.TabIndex = 0;
            this.btnIndividual.Text = "&Individual Chats";
            this.btnIndividual.UseVisualStyleBackColor = false;
            this.btnIndividual.Click += new System.EventHandler(this.btnIndividual_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.Green;
            this.btnGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGroup.Location = new System.Drawing.Point(528, 249);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(214, 41);
            this.btnGroup.TabIndex = 0;
            this.btnGroup.Text = "&Group Chat";
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // frmChatSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1924, 932);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.btnIndividual);
            this.Font = new System.Drawing.Font("Verdana", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmChatSelection";
            this.Text = "frmChatSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIndividual;
        private System.Windows.Forms.Button btnGroup;
    }
}