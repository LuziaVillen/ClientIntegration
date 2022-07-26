namespace ClientIntegration
{
    partial class Form2
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
            this.username = new System.Windows.Forms.Label();
            this.playbutton = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.ComboBox();
            this.downloadclient = new System.Windows.Forms.Button();
            this.ram = new System.Windows.Forms.ComboBox();
            this.width = new System.Windows.Forms.ComboBox();
            this.height = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft PhagsPa", 16.25F, System.Drawing.FontStyle.Bold);
            this.username.Location = new System.Drawing.Point(29, 217);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(117, 29);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // playbutton
            // 
            this.playbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.playbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playbutton.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbutton.Location = new System.Drawing.Point(509, 248);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(138, 33);
            this.playbutton.TabIndex = 3;
            this.playbutton.Text = "PLAY";
            this.playbutton.UseVisualStyleBackColor = true;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // version
            // 
            this.version.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.25F);
            this.version.FormattingEnabled = true;
            this.version.Items.AddRange(new object[] {
            "1.19.1",
            "1.18.2",
            "1.17.1",
            "1.16.5",
            "1.15.2",
            "1.14.4",
            "1.13.2",
            "1.12.2",
            "1.11.2",
            "1.10.2",
            "1.9",
            "1.8.8",
            "1.7.10"});
            this.version.Location = new System.Drawing.Point(347, 249);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(154, 29);
            this.version.TabIndex = 4;
            this.version.Text = "1.16.5";
            // 
            // downloadclient
            // 
            this.downloadclient.Cursor = System.Windows.Forms.Cursors.Default;
            this.downloadclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadclient.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadclient.Location = new System.Drawing.Point(28, 248);
            this.downloadclient.Name = "downloadclient";
            this.downloadclient.Size = new System.Drawing.Size(133, 33);
            this.downloadclient.TabIndex = 6;
            this.downloadclient.Text = "Download Client";
            this.downloadclient.UseVisualStyleBackColor = true;
            this.downloadclient.Click += new System.EventHandler(this.downloadclient_Click);
            // 
            // ram
            // 
            this.ram.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.25F);
            this.ram.FormattingEnabled = true;
            this.ram.Items.AddRange(new object[] {
            "1024",
            "2048",
            "3072",
            "4096",
            "5120",
            "6144",
            "7168",
            "8192"});
            this.ram.Location = new System.Drawing.Point(25, 12);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(121, 29);
            this.ram.TabIndex = 7;
            this.ram.Text = "Ram";
            this.ram.SelectedIndexChanged += new System.EventHandler(this.ram_SelectedIndexChanged);
            // 
            // width
            // 
            this.width.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.25F);
            this.width.FormattingEnabled = true;
            this.width.Items.AddRange(new object[] {
            "1920",
            "1366",
            "1280",
            "1024"});
            this.width.Location = new System.Drawing.Point(25, 47);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(121, 29);
            this.width.TabIndex = 8;
            this.width.Text = "Width";
            this.width.SelectedIndexChanged += new System.EventHandler(this.width_SelectedIndexChanged);
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.25F);
            this.height.FormattingEnabled = true;
            this.height.Items.AddRange(new object[] {
            "1080",
            "768",
            "720"});
            this.height.Location = new System.Drawing.Point(25, 82);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(121, 29);
            this.height.TabIndex = 9;
            this.height.Text = "Height";
            this.height.SelectedIndexChanged += new System.EventHandler(this.height_SelectedIndexChanged);
            // 
            // status
            // 
            this.status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.status.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(342, 216);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(301, 23);
            this.status.TabIndex = 10;
            this.status.Text = "Client status";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(627, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 289);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.downloadclient);
            this.Controls.Add(this.version);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button playbutton;
        private System.Windows.Forms.ComboBox version;
        private System.Windows.Forms.Button downloadclient;
        private System.Windows.Forms.ComboBox ram;
        private System.Windows.Forms.ComboBox width;
        private System.Windows.Forms.ComboBox height;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button button1;
    }
}