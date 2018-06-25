using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CdCatalogue
{
    public partial class newform : Form
    {
        bool changesMade = false;
        
        Form2 f2;
        Form3 f1;

        public newform()
        {
            InitializeComponent();
            f2 = new Form2(this);
            f2.Hide();
          
        }
        //initialize string(s)
        string cdfile;

        //this is the open file handler
        // opens desired .csv file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.changesMade && MessageBox.Show("Save your changes?","Offer to save changes", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                save1();
            }
            OpenFileDialog ff = new OpenFileDialog();

            ff.InitialDirectory = "c:\\";
            ff.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            ff.FilterIndex = 1;
            ff.RestoreDirectory = true;

            if (ff.ShowDialog() == DialogResult.OK)
            {
                cdfile = ff.FileName;
            }

            run();
        }

        private ArrayList readdata()
        {
            // create an arraylist to store the data
            ArrayList cddata = new ArrayList();

            //read the file line by line 
            using (StreamReader reader = new StreamReader(cdfile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //split the line into a string array using a comma delimiter
                    //and add to the arraylist
                    string[] parts = line.Split(',');
                    cddata.Add(parts);
                }
            }
            //ignore the first row in file as it contains header information
            //and pass out the rest of the data
            //cddata.RemoveAt(0);
            return cddata;
        }


        public void run()
        {
            ArrayList data = readdata();
            dataGridView1.Rows.Clear();

            //for every sample in the data
            foreach (string[] d in data)
            {
                string Artist = d[0].Trim();
                string Album = d[1].Trim();
                string Genre = d[2].Trim();
                string Year = d[3].Trim();

                this.dataGridView1.Rows.Add(Artist, Album, Genre, Year);
            }
        }
        //this is the create new cd catalog handler
        //opens a new catalog for user
        private void catalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.changesMade && MessageBox.Show("Save your changes?", "Offer to save changes", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                save1();
            }
            newform form1 = new newform();
            form1.Show();

            this.Hide();
        }

        //this is the close application handler
        //it closes current file
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.changesMade && MessageBox.Show("Save your changes?", "Offer to save changes", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                save1();
            }
        }

        //this is the save file handler
        //updates already existing files and saves to new files
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save1();

            //reset bool operation
            bool changesMade = false;
        }

        public void save()
        {
            int number = dataGridView1.Rows.Count;
            number = number - 1;
            File.WriteAllText(cdfile, "");
            for (int i = 0; i < number; i++)
            {
                string artist = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                string album = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                string genre = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                string date = this.dataGridView1.Rows[i].Cells[3].Value.ToString();

                string lines = artist + "," + album + "," + genre + "," + date + Environment.NewLine;
                File.AppendAllText(cdfile, lines);
            }
        }

        public void save1()
        {
            if (File.Exists(cdfile))
            {
                save();
            }
            if (!File.Exists(cdfile))
            {
                saveas();
            }
        }

        //this is the saveAs handler
        //exports the datagridview content as .csv to chosen location
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveas();

            //reset bool operation
            bool changesMade = false;
        }

        public void saveas()
        {
            SaveFileDialog ff = new SaveFileDialog();

            ff.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            ff.FilterIndex = 1;
            ff.RestoreDirectory = true;

            if (ff.ShowDialog() == DialogResult.OK)
            {
                string newfile = ff.FileName;
                int number = dataGridView1.Rows.Count;
                File.WriteAllText(newfile, "");
                number = number - 1;
                for (int i = 0; i < number; i++)
                {
                    string artist = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string album = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string genre = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string date = this.dataGridView1.Rows[i].Cells[3].Value.ToString();

                    string lines = artist + "," + album + "," + genre + "," + date + Environment.NewLine;
                    File.AppendAllText(newfile, lines);
                }

            }
        }
        //this ends the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.changesMade && MessageBox.Show("Save your changes?", "Offer to save changes", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                save1();
                Application.Exit();
            }
            
        }

        //this sorts the cd catalogue by artist
        private void byArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Artist"], ListSortDirection.Ascending);
            changesMade = true;
        }

        //this sorts the cd catalogue by album
        private void byAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Album"], ListSortDirection.Ascending);
            changesMade = true;
        }

        //this sorts the cd catalogue by genre
        private void byGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Genre"], ListSortDirection.Ascending);
            changesMade = true;
        }

        //this sorts the cd catalogue by year
        private void byYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Year"], ListSortDirection.Ascending);
            changesMade = true;
        }

        //this is the add record handler
        //adds a record to cd catalog
        private void addbutton_Click(object sender, EventArgs e)
        {
            if (!f2.Visible)
            {
                f2 = new Form2(this);
                f2.Show();
            }
            changesMade = true;
        }

        //this is the edit record handler
        // edits the records for modifications
        private void editbutton_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3(this);
            //load data from datagridview to form 3
            f1.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f1.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f1.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f1.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

            //change text form
            f1.Text = "Edit record";
            f1.Show();
            
            changesMade = true;
        }

        //this is the delete record handler
        //it deletes a record from the catalog
        private void delbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete record?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                delete();
            }

            changesMade = true;
        }
        public void delete()
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                    dataGridView1.Rows.Remove(row);
            }
        }

    }
}
