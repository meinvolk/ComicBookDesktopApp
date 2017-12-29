using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComicBookData;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;


namespace ComicBookForms
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            //Dark theme using MaterialSkin nuget package.
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green300, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private static bool itemsValid;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form to gather User ID
            Login login = new Login();
            login.ShowDialog();

            //Set User ID for Program.
            if(Login.SetuserIDValue != null)
                lblUserId.Text = Login.SetuserIDValue;
            else
                lblUserId.Text = "1";

            //Initialize drop down lists.
            LoadDropDownLists(true, true, true);
        }

        /// <summary>
        /// Method to search the database for specified comicbook.
        /// </summary>
        private void Inquire()
        {
            ClearValues();

            if (long.TryParse(DDLInquiry.Text, out long inquireValue))
            {
                ComicBook cb = ComicBookDb.Inquire(inquireValue);
                if (cb != null)
                {
                    txtTitle.Text = cb.Title;
                    DDLArtist.SelectedIndex = cb.Artist - 1;
                    DDLSeries.SelectedIndex = cb.Series - 1;
                    txtDescription.Text = cb.Description;
                    if (cb.Rate == 1)
                        radiobtn1.Checked = true;
                    else if (cb.Rate == 2)
                        radiobtn2.Checked = true;
                    else if (cb.Rate == 3)
                        radiobtn3.Checked = true;
                    else if (cb.Rate == 4)
                        radiobtn4.Checked = true;
                    else if (cb.Rate == 5)
                        radiobtn5.Checked = true;
                }
                else

                    MessageBox.Show("Record Not Found!");
            }
            else

                MessageBox.Show("Please enter an integer value!");
        }

        /// <summary>
        /// Method to create a comicbook record.
        /// </summary>
        private void Create()
        {
            ValidateFields();

            if (itemsValid == true)
            {
                ComicBook cb = new ComicBook();
                
                cb.Title = txtTitle.Text;
                cb.Artist = Convert.ToInt32(DDLArtist.SelectedIndex + 1);
                cb.Series = Convert.ToInt32(DDLSeries.SelectedIndex + 1);
                cb.Description = txtDescription.Text;
                cb.Rate = GetCheckBoxSelection();
                cb.CB_ADD_USER_ID = Convert.ToInt32(lblUserId.Text);

                ComicBookDb.Add(cb);
                MessageBox.Show($"Record ID: {cb.CB_Id} was succesfully created by User ID: {lblUserId.Text}.");

                ClearValues();
            }

            DDLInquiry.Items.Clear();
            LoadDropDownLists(false, false, true);
        }

        /// <summary>
        /// Method to update a comicbook record.
        /// </summary>
        private void UpdateCB()
        {
            ValidateFields();

            if (itemsValid == true && int.TryParse(DDLInquiry.Text, out int inquireValue))
            {
                ComicBook cb = new ComicBook();

                cb.CB_Id = inquireValue;
                cb.Title = txtTitle.Text;
                cb.Artist = DDLArtist.SelectedIndex + 1;
                cb.Series = DDLSeries.SelectedIndex + 1;
                cb.Description = txtDescription.Text;
                cb.Rate = GetCheckBoxSelection();
                cb.CB_CHG_USER_ID = Convert.ToInt32(lblUserId.Text);

                ComicBookDb.Update(cb);
                MessageBox.Show($"Record ID: {cb.CB_Id} was succesfully Updated by User ID: {lblUserId.Text}.");
            }
            else

                MessageBox.Show("Please enter an integer value!");
        }

        /// <summary>
        /// Method that sets the status of the comicbook record to 'D'. Purge required for hard delete.
        /// </summary>
        private void Delete()
        {
            if (int.TryParse(DDLInquiry.Text, out int inquireValue))
            {
                ComicBook cb = new ComicBook();

                cb.CB_Id = inquireValue;
                cb.CB_CHG_USER_ID = Convert.ToInt32(lblUserId.Text);

                ComicBookDb.Delete(cb);
                MessageBox.Show($"Record {cb.CB_Id} was deleted. Status set to 'D'.");
            }
            else

                MessageBox.Show("Please Enter a comicbook record ID.");
        }

        /// <summary>
        /// Method to set comicbook record from 'D' back to 'A'.
        /// </summary>
        private void UnDelete()
        {
            if (int.TryParse(DDLInquiry.Text, out int inquireValue))
            {
                ComicBook cb = new ComicBook();

                cb.CB_Id = inquireValue;
                cb.CB_CHG_USER_ID = Convert.ToInt32(lblUserId.Text);

                ComicBookDb.UnDelete(cb);
                MessageBox.Show($"Record {cb.CB_Id} was undeleted. Status set to 'A'.");
            }
            else

                MessageBox.Show("Please Enter a comicbook record ID.");
        }

        /// <summary>
        /// Method to hard delete a record from the database. Must have status letter of 'D'.
        /// </summary>
        private void Purge()
        {
            //Query to read if status record is 'D', so it can be purged from the database.
            string statusLetter = null;
            string sqlCHGSTATUS = "SELECT CB_STAT_CD FROM CBT001_COMICBOOK WHERE CB_Id=" + DDLInquiry.Text + ";";

            if (int.TryParse(DDLInquiry.Text, out int inquireValue))
            {
                //Open a connection to read what the current status code is for the specific record.
                using (OleDbConnection cn = new OleDbConnection(ComicBookDb.cnString))
                {
                    OleDbCommand cm = new OleDbCommand(sqlCHGSTATUS, cn);
                    cn.Open();
                    OleDbDataReader dr = cm.ExecuteReader();

                    while (dr.Read())
                        statusLetter = Convert.ToString(dr["CB_STAT_CD"]);
                }

                //If item has been deleted, then go ahead and purge the record.
                if(statusLetter == "D")
                {
                    ComicBook cb = new ComicBook();
                    cb.CB_Id = inquireValue;

                    ComicBookDb.Purge(cb);
                    MessageBox.Show($"Record {cb.CB_Id} was permenantly deleted.");
                }
                else

                    MessageBox.Show("Comic Book must first be Deleted before it can be purged.");
            }
            else

                MessageBox.Show("Please Enter a comicbook record ID.");

            DDLInquiry.Items.Clear();
            LoadDropDownLists(false, false, true);
        }

        /// <summary>
        /// Method to load and refresh Dropdown lists. Pass the three booleans to indicatate which sql to execute.
        /// </summary>
        private void LoadDropDownLists(bool series, bool artist, bool Id)
        {
            //Queries to load series drop down values.
            if (series)
            {
                string sqlSeries = "SELECT * FROM CBT002_SERIES;";
                using (OleDbConnection cn = new OleDbConnection(ComicBookDb.cnString))
                {
                    OleDbCommand cm = new OleDbCommand(sqlSeries, cn);
                    cn.Open();
                    
                    OleDbDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        DDLSeries.Items.Add(dr["S_NAME"].ToString());
                        DDLSeries.SelectedIndex = 0;
                    }
                }
            }
            if (artist)
            {
                string sqlArtist = "SELECT * FROM CBT003_ARTIST;";
                using (OleDbConnection cn = new OleDbConnection(ComicBookDb.cnString))
                {
                    OleDbCommand cm = new OleDbCommand(sqlArtist, cn);
                    cn.Open();
                    OleDbDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        DDLArtist.Items.Add(dr["A_FIRST_NM"].ToString());
                        DDLArtist.SelectedIndex = 0;
                    }
                }
            }
            if (Id)
            {
                string sqlId = "SELECT * FROM CBT001_COMICBOOK;";
                using (OleDbConnection cn = new OleDbConnection(ComicBookDb.cnString))
                {
                    OleDbCommand cm = new OleDbCommand(sqlId, cn);
                    cn.Open();
                    OleDbDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        DDLInquiry.Items.Add(dr["CB_Id"].ToString());
                        DDLInquiry.SelectedIndex = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Method for validating all user input fields.
        /// </summary>
        private void ValidateFields()
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Enter valid title.");
                itemsValid = false;
            }
            else if (txtDescription.Text == "")
            {
                MessageBox.Show("Enter valid description.");
                itemsValid = false;
            }
            else if (GetCheckBoxSelection() == 6)
            {
                MessageBox.Show("Check valid rating.");
                itemsValid = false;
            }
            else

                itemsValid = true;
        }

        /// <summary>
        /// Method to clear values in text fields.
        /// </summary>
        private void ClearValues()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
            DDLArtist.SelectedIndex = 0;
            DDLSeries.SelectedIndex = 0;
            radiobtn1.Checked = false;
            radiobtn2.Checked = false;
            radiobtn3.Checked = false;
            radiobtn4.Checked = false;
            radiobtn5.Checked = false;
        }

        /// <summary>
        /// Returns the selected checkbox from the form.
        /// </summary>
        /// <returns></returns>
        private byte GetCheckBoxSelection()
        {
            //Get radio button that was checked
            var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if(checkedButton != null)
            {
                return Convert.ToByte(checkedButton.Text);
            }
            else
                return 6;
        }

        private void CMDInquery_Click(object sender, EventArgs e)
        {
            Inquire();
        }

        private void CMDCreate_Click_1(object sender, EventArgs e)
        {
            Create();
        }
        
        private void CMDUpdate_Click(object sender, EventArgs e)
        {
            UpdateCB();
        }

        private void CMDDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        
        private void CMDUndelete_Click(object sender, EventArgs e)
        {
            UnDelete();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutComicBooks abc = new AboutComicBooks();
            abc.ShowDialog();
        }

        private void CMDExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCB();
        }

        private void purgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purge();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnDelete();
        }

        private void DDLArtist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DDLSeries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
