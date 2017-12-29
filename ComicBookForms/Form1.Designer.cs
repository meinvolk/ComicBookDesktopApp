namespace ComicBookForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtn5 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radiobtn4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radiobtn3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radiobtn2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radiobtn1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.CMDInquery = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.CMDCreate = new MaterialSkin.Controls.MaterialFlatButton();
            this.CMDUpdate = new MaterialSkin.Controls.MaterialFlatButton();
            this.CMDDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.CMDUndelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.CMDExit = new MaterialSkin.Controls.MaterialFlatButton();
            this.DDLArtist = new System.Windows.Forms.ComboBox();
            this.DDLSeries = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.DDLInquiry = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(111, 115);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(291, 20);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(111, 230);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(291, 106);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(412, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.purgeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // purgeToolStripMenuItem
            // 
            this.purgeToolStripMenuItem.Name = "purgeToolStripMenuItem";
            this.purgeToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.purgeToolStripMenuItem.Text = "Purge";
            this.purgeToolStripMenuItem.Click += new System.EventHandler(this.purgeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.updateToolStripMenuItem.Text = "Undelete";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtn5);
            this.groupBox1.Controls.Add(this.radiobtn4);
            this.groupBox1.Controls.Add(this.radiobtn3);
            this.groupBox1.Controls.Add(this.radiobtn2);
            this.groupBox1.Controls.Add(this.radiobtn1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(16, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 73);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ratings";
            // 
            // radiobtn5
            // 
            this.radiobtn5.AutoSize = true;
            this.radiobtn5.Depth = 0;
            this.radiobtn5.Font = new System.Drawing.Font("Roboto", 10F);
            this.radiobtn5.Location = new System.Drawing.Point(322, 25);
            this.radiobtn5.Margin = new System.Windows.Forms.Padding(0);
            this.radiobtn5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radiobtn5.MouseState = MaterialSkin.MouseState.HOVER;
            this.radiobtn5.Name = "radiobtn5";
            this.radiobtn5.Ripple = true;
            this.radiobtn5.Size = new System.Drawing.Size(37, 30);
            this.radiobtn5.TabIndex = 4;
            this.radiobtn5.TabStop = true;
            this.radiobtn5.Text = "5";
            this.radiobtn5.UseVisualStyleBackColor = true;
            // 
            // radiobtn4
            // 
            this.radiobtn4.AutoSize = true;
            this.radiobtn4.Depth = 0;
            this.radiobtn4.Font = new System.Drawing.Font("Roboto", 10F);
            this.radiobtn4.Location = new System.Drawing.Point(249, 25);
            this.radiobtn4.Margin = new System.Windows.Forms.Padding(0);
            this.radiobtn4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radiobtn4.MouseState = MaterialSkin.MouseState.HOVER;
            this.radiobtn4.Name = "radiobtn4";
            this.radiobtn4.Ripple = true;
            this.radiobtn4.Size = new System.Drawing.Size(37, 30);
            this.radiobtn4.TabIndex = 3;
            this.radiobtn4.TabStop = true;
            this.radiobtn4.Text = "4";
            this.radiobtn4.UseVisualStyleBackColor = true;
            // 
            // radiobtn3
            // 
            this.radiobtn3.AutoSize = true;
            this.radiobtn3.Depth = 0;
            this.radiobtn3.Font = new System.Drawing.Font("Roboto", 10F);
            this.radiobtn3.Location = new System.Drawing.Point(176, 25);
            this.radiobtn3.Margin = new System.Windows.Forms.Padding(0);
            this.radiobtn3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radiobtn3.MouseState = MaterialSkin.MouseState.HOVER;
            this.radiobtn3.Name = "radiobtn3";
            this.radiobtn3.Ripple = true;
            this.radiobtn3.Size = new System.Drawing.Size(37, 30);
            this.radiobtn3.TabIndex = 2;
            this.radiobtn3.TabStop = true;
            this.radiobtn3.Text = "3";
            this.radiobtn3.UseVisualStyleBackColor = true;
            // 
            // radiobtn2
            // 
            this.radiobtn2.AutoSize = true;
            this.radiobtn2.Depth = 0;
            this.radiobtn2.Font = new System.Drawing.Font("Roboto", 10F);
            this.radiobtn2.Location = new System.Drawing.Point(100, 25);
            this.radiobtn2.Margin = new System.Windows.Forms.Padding(0);
            this.radiobtn2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radiobtn2.MouseState = MaterialSkin.MouseState.HOVER;
            this.radiobtn2.Name = "radiobtn2";
            this.radiobtn2.Ripple = true;
            this.radiobtn2.Size = new System.Drawing.Size(37, 30);
            this.radiobtn2.TabIndex = 1;
            this.radiobtn2.TabStop = true;
            this.radiobtn2.Text = "2";
            this.radiobtn2.UseVisualStyleBackColor = true;
            // 
            // radiobtn1
            // 
            this.radiobtn1.AutoSize = true;
            this.radiobtn1.Depth = 0;
            this.radiobtn1.Font = new System.Drawing.Font("Roboto", 10F);
            this.radiobtn1.Location = new System.Drawing.Point(23, 25);
            this.radiobtn1.Margin = new System.Windows.Forms.Padding(0);
            this.radiobtn1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radiobtn1.MouseState = MaterialSkin.MouseState.HOVER;
            this.radiobtn1.Name = "radiobtn1";
            this.radiobtn1.Ripple = true;
            this.radiobtn1.Size = new System.Drawing.Size(37, 30);
            this.radiobtn1.TabIndex = 0;
            this.radiobtn1.TabStop = true;
            this.radiobtn1.Text = "1";
            this.radiobtn1.UseVisualStyleBackColor = true;
            // 
            // CMDInquery
            // 
            this.CMDInquery.AutoSize = true;
            this.CMDInquery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CMDInquery.Depth = 0;
            this.CMDInquery.Location = new System.Drawing.Point(239, 70);
            this.CMDInquery.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CMDInquery.MouseState = MaterialSkin.MouseState.HOVER;
            this.CMDInquery.Name = "CMDInquery";
            this.CMDInquery.Primary = false;
            this.CMDInquery.Size = new System.Drawing.Size(69, 36);
            this.CMDInquery.TabIndex = 23;
            this.CMDInquery.Text = "Inquery";
            this.CMDInquery.UseVisualStyleBackColor = true;
            this.CMDInquery.Click += new System.EventHandler(this.CMDInquery_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 79);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(25, 19);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "Id:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 118);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(43, 19);
            this.materialLabel2.TabIndex = 25;
            this.materialLabel2.Text = "Title:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(14, 156);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(50, 19);
            this.materialLabel3.TabIndex = 26;
            this.materialLabel3.Text = "Artist:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(14, 194);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(55, 19);
            this.materialLabel4.TabIndex = 27;
            this.materialLabel4.Text = "Series:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(15, 229);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(90, 19);
            this.materialLabel5.TabIndex = 28;
            this.materialLabel5.Text = "Description:";
            // 
            // CMDCreate
            // 
            this.CMDCreate.AutoSize = true;
            this.CMDCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CMDCreate.Depth = 0;
            this.CMDCreate.Location = new System.Drawing.Point(17, 451);
            this.CMDCreate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CMDCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.CMDCreate.Name = "CMDCreate";
            this.CMDCreate.Primary = false;
            this.CMDCreate.Size = new System.Drawing.Size(62, 36);
            this.CMDCreate.TabIndex = 29;
            this.CMDCreate.Text = "Create";
            this.CMDCreate.UseVisualStyleBackColor = true;
            this.CMDCreate.Click += new System.EventHandler(this.CMDCreate_Click_1);
            // 
            // CMDUpdate
            // 
            this.CMDUpdate.AutoSize = true;
            this.CMDUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CMDUpdate.Depth = 0;
            this.CMDUpdate.Location = new System.Drawing.Point(100, 451);
            this.CMDUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CMDUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.CMDUpdate.Name = "CMDUpdate";
            this.CMDUpdate.Primary = false;
            this.CMDUpdate.Size = new System.Drawing.Size(64, 36);
            this.CMDUpdate.TabIndex = 30;
            this.CMDUpdate.Text = "Update";
            this.CMDUpdate.UseVisualStyleBackColor = true;
            this.CMDUpdate.Click += new System.EventHandler(this.CMDUpdate_Click);
            // 
            // CMDDelete
            // 
            this.CMDDelete.AutoSize = true;
            this.CMDDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CMDDelete.Depth = 0;
            this.CMDDelete.Location = new System.Drawing.Point(187, 451);
            this.CMDDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CMDDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.CMDDelete.Name = "CMDDelete";
            this.CMDDelete.Primary = false;
            this.CMDDelete.Size = new System.Drawing.Size(60, 36);
            this.CMDDelete.TabIndex = 31;
            this.CMDDelete.Text = "Delete";
            this.CMDDelete.UseVisualStyleBackColor = true;
            this.CMDDelete.Click += new System.EventHandler(this.CMDDelete_Click);
            // 
            // CMDUndelete
            // 
            this.CMDUndelete.AutoSize = true;
            this.CMDUndelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CMDUndelete.Depth = 0;
            this.CMDUndelete.Location = new System.Drawing.Point(267, 451);
            this.CMDUndelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CMDUndelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.CMDUndelete.Name = "CMDUndelete";
            this.CMDUndelete.Primary = false;
            this.CMDUndelete.Size = new System.Drawing.Size(79, 36);
            this.CMDUndelete.TabIndex = 32;
            this.CMDUndelete.Text = "UnDelete";
            this.CMDUndelete.UseVisualStyleBackColor = true;
            this.CMDUndelete.Click += new System.EventHandler(this.CMDUndelete_Click);
            // 
            // CMDExit
            // 
            this.CMDExit.AutoSize = true;
            this.CMDExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CMDExit.Depth = 0;
            this.CMDExit.Location = new System.Drawing.Point(360, 451);
            this.CMDExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CMDExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.CMDExit.Name = "CMDExit";
            this.CMDExit.Primary = false;
            this.CMDExit.Size = new System.Drawing.Size(41, 36);
            this.CMDExit.TabIndex = 33;
            this.CMDExit.Text = "Exit";
            this.CMDExit.UseVisualStyleBackColor = true;
            this.CMDExit.Click += new System.EventHandler(this.CMDExit_Click);
            // 
            // DDLArtist
            // 
            this.DDLArtist.FormattingEnabled = true;
            this.DDLArtist.Location = new System.Drawing.Point(111, 156);
            this.DDLArtist.Name = "DDLArtist";
            this.DDLArtist.Size = new System.Drawing.Size(121, 21);
            this.DDLArtist.TabIndex = 3;
            this.DDLArtist.SelectedIndexChanged += new System.EventHandler(this.DDLArtist_SelectedIndexChanged);
            // 
            // DDLSeries
            // 
            this.DDLSeries.FormattingEnabled = true;
            this.DDLSeries.Location = new System.Drawing.Point(111, 194);
            this.DDLSeries.Name = "DDLSeries";
            this.DDLSeries.Size = new System.Drawing.Size(121, 21);
            this.DDLSeries.TabIndex = 4;
            this.DDLSeries.SelectedIndexChanged += new System.EventHandler(this.DDLSeries_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(340, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "User ID:";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.BackColor = System.Drawing.SystemColors.Window;
            this.lblUserId.Location = new System.Drawing.Point(386, 5);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(13, 13);
            this.lblUserId.TabIndex = 37;
            this.lblUserId.Text = "4";
            // 
            // DDLInquiry
            // 
            this.DDLInquiry.FormattingEnabled = true;
            this.DDLInquiry.Location = new System.Drawing.Point(111, 77);
            this.DDLInquiry.Name = "DDLInquiry";
            this.DDLInquiry.Size = new System.Drawing.Size(121, 21);
            this.DDLInquiry.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 503);
            this.Controls.Add(this.DDLInquiry);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DDLSeries);
            this.Controls.Add(this.DDLArtist);
            this.Controls.Add(this.CMDExit);
            this.Controls.Add(this.CMDUndelete);
            this.Controls.Add(this.CMDDelete);
            this.Controls.Add(this.CMDUpdate);
            this.Controls.Add(this.CMDCreate);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.CMDInquery);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Comic Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton radiobtn5;
        private MaterialSkin.Controls.MaterialRadioButton radiobtn4;
        private MaterialSkin.Controls.MaterialRadioButton radiobtn3;
        private MaterialSkin.Controls.MaterialRadioButton radiobtn2;
        private MaterialSkin.Controls.MaterialRadioButton radiobtn1;
        private MaterialSkin.Controls.MaterialFlatButton CMDInquery;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton CMDCreate;
        private MaterialSkin.Controls.MaterialFlatButton CMDUpdate;
        private MaterialSkin.Controls.MaterialFlatButton CMDDelete;
        private MaterialSkin.Controls.MaterialFlatButton CMDUndelete;
        private MaterialSkin.Controls.MaterialFlatButton CMDExit;
        private System.Windows.Forms.ComboBox DDLArtist;
        private System.Windows.Forms.ComboBox DDLSeries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ToolStripMenuItem purgeToolStripMenuItem;
        private System.Windows.Forms.ComboBox DDLInquiry;
    }
}

