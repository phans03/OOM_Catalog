namespace CdCatalogue
{
    partial class newform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newform));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addbutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newformBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newformBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artist,
            this.Album,
            this.Genre,
            this.Year});
            this.dataGridView1.Location = new System.Drawing.Point(145, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            // 
            // Album
            // 
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogueToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // catalogueToolStripMenuItem
            // 
            this.catalogueToolStripMenuItem.Name = "catalogueToolStripMenuItem";
            this.catalogueToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.catalogueToolStripMenuItem.Text = "Catalogue";
            this.catalogueToolStripMenuItem.Click += new System.EventHandler(this.catalogueToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byArtistToolStripMenuItem,
            this.byAlbumToolStripMenuItem,
            this.byGenreToolStripMenuItem,
            this.byYearToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // byArtistToolStripMenuItem
            // 
            this.byArtistToolStripMenuItem.Name = "byArtistToolStripMenuItem";
            this.byArtistToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.byArtistToolStripMenuItem.Text = "By Artist";
            this.byArtistToolStripMenuItem.Click += new System.EventHandler(this.byArtistToolStripMenuItem_Click);
            // 
            // byAlbumToolStripMenuItem
            // 
            this.byAlbumToolStripMenuItem.Name = "byAlbumToolStripMenuItem";
            this.byAlbumToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.byAlbumToolStripMenuItem.Text = "By Album";
            this.byAlbumToolStripMenuItem.Click += new System.EventHandler(this.byAlbumToolStripMenuItem_Click);
            // 
            // byGenreToolStripMenuItem
            // 
            this.byGenreToolStripMenuItem.Name = "byGenreToolStripMenuItem";
            this.byGenreToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.byGenreToolStripMenuItem.Text = "By Genre";
            this.byGenreToolStripMenuItem.Click += new System.EventHandler(this.byGenreToolStripMenuItem_Click);
            // 
            // byYearToolStripMenuItem
            // 
            this.byYearToolStripMenuItem.Name = "byYearToolStripMenuItem";
            this.byYearToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.byYearToolStripMenuItem.Text = "By Year";
            this.byYearToolStripMenuItem.Click += new System.EventHandler(this.byYearToolStripMenuItem_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(11, 162);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(115, 29);
            this.addbutton.TabIndex = 2;
            this.addbutton.Text = "Add record";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(11, 207);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(115, 29);
            this.editbutton.TabIndex = 3;
            this.editbutton.Text = "Edit record";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // delbutton
            // 
            this.delbutton.Location = new System.Drawing.Point(11, 255);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(115, 29);
            this.delbutton.TabIndex = 4;
            this.delbutton.Text = "Delete record";
            this.delbutton.UseVisualStyleBackColor = true;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(CdCatalogue.Program);
            // 
            // newformBindingSource
            // 
            this.newformBindingSource.DataSource = typeof(CdCatalogue.newform);
            // 
            // newform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 332);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "newform";
            this.Text = "CD Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newformBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byYearToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource newformBindingSource;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

