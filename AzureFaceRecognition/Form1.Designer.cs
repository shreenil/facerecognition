namespace AzureFaceRecognition
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reg_label = new System.Windows.Forms.Label();
            this.txt_reg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idList = new System.Windows.Forms.ListBox();
            this.btnPBrowse = new System.Windows.Forms.Button();
            this.txtImageFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgBox
            // 
            this.imgBox.BackColor = System.Drawing.Color.Black;
            this.imgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBox.Location = new System.Drawing.Point(0, 0);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(1016, 638);
            this.imgBox.TabIndex = 0;
            this.imgBox.TabStop = false;
            this.imgBox.Click += new System.EventHandler(this.imgBox_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(9, 113);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(166, 34);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "&Browse Image";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(181, 113);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(157, 34);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "&Login";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 10);
            this.panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnTrain);
            this.flowLayoutPanel1.Controls.Add(this.btnIdentify);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(733, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(283, 10);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Visible = false;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(3, 3);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(139, 34);
            this.btnTrain.TabIndex = 3;
            this.btnTrain.Text = "&Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Visible = false;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnIdentify
            // 
            this.btnIdentify.Location = new System.Drawing.Point(3, 43);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(139, 34);
            this.btnIdentify.TabIndex = 4;
            this.btnIdentify.Text = "&Identify";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Visible = false;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(9, 191);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(329, 33);
            this.register_btn.TabIndex = 1;
            this.register_btn.Text = "Register Image 1";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnProcess);
            this.panel2.Controls.Add(this.btnBrowse);
            this.panel2.Controls.Add(this.register_btn);
            this.panel2.Controls.Add(this.reg_label);
            this.panel2.Controls.Add(this.txt_reg);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.idList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(666, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 628);
            this.panel2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(330, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Now don\'t remember your passwords!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "--------------------------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "--------------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "or";
            // 
            // reg_label
            // 
            this.reg_label.AutoSize = true;
            this.reg_label.Location = new System.Drawing.Point(26, 83);
            this.reg_label.Name = "reg_label";
            this.reg_label.Size = new System.Drawing.Size(80, 13);
            this.reg_label.TabIndex = 12;
            this.reg_label.Text = "Your Username";
            this.reg_label.Click += new System.EventHandler(this.reg_label_Click);
            // 
            // txt_reg
            // 
            this.txt_reg.Location = new System.Drawing.Point(112, 80);
            this.txt_reg.Name = "txt_reg";
            this.txt_reg.Size = new System.Drawing.Size(226, 20);
            this.txt_reg.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Identified persons in current image";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // idList
            // 
            this.idList.FormattingEnabled = true;
            this.idList.Location = new System.Drawing.Point(8, 259);
            this.idList.Name = "idList";
            this.idList.Size = new System.Drawing.Size(330, 251);
            this.idList.TabIndex = 9;
            // 
            // btnPBrowse
            // 
            this.btnPBrowse.Location = new System.Drawing.Point(510, 118);
            this.btnPBrowse.Name = "btnPBrowse";
            this.btnPBrowse.Size = new System.Drawing.Size(29, 21);
            this.btnPBrowse.TabIndex = 8;
            this.btnPBrowse.Text = "...";
            this.btnPBrowse.UseVisualStyleBackColor = true;
            this.btnPBrowse.Visible = false;
            this.btnPBrowse.Click += new System.EventHandler(this.btnPBrowse_Click);
            // 
            // txtImageFolder
            // 
            this.txtImageFolder.Location = new System.Drawing.Point(373, 135);
            this.txtImageFolder.Name = "txtImageFolder";
            this.txtImageFolder.Size = new System.Drawing.Size(246, 20);
            this.txtImageFolder.TabIndex = 7;
            this.txtImageFolder.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Persons image folder";
            this.label3.Visible = false;
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(432, 284);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(281, 160);
            this.listUsers.TabIndex = 5;
            this.listUsers.Visible = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(510, 31);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(29, 20);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "+";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Visible = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Location = new System.Drawing.Point(326, 212);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(281, 26);
            this.btnCreateGroup.TabIndex = 3;
            this.btnCreateGroup.Text = "&Create group";
            this.btnCreateGroup.UseVisualStyleBackColor = true;
            this.btnCreateGroup.Visible = false;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // txtNewUser
            // 
            this.txtNewUser.Location = new System.Drawing.Point(326, 31);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(178, 20);
            this.txtNewUser.TabIndex = 3;
            this.txtNewUser.Text = "???";
            this.txtNewUser.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New user";
            this.label2.Visible = false;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(452, 31);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(213, 20);
            this.txtGroupName.TabIndex = 1;
            this.txtGroupName.Text = "My Group";
            this.txtGroupName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group name";
            this.label1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.progressBar1.Location = new System.Drawing.Point(73, 506);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(534, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(89, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Login with your face!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 638);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.txtNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtImageFolder);
            this.Controls.Add(this.btnPBrowse);
            this.Controls.Add(this.btnCreateGroup);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AzureFaceRecognition - Emiliano Musso @2017";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateGroup;
        private System.Windows.Forms.Button btnPBrowse;
        private System.Windows.Forms.TextBox txtImageFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox idList;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label reg_label;
        private System.Windows.Forms.TextBox txt_reg;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

