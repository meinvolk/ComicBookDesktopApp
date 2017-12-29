using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ComicBookForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //Get file path where database sits
                string path = System.IO.Path.GetDirectoryName(
                  System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\Database\\ComicBookDataBase.accdb";
                //substring "File" out of path name.
                path = path.Remove(0, 6);


                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var section = (ConnectionStringsSection)config.GetSection("connectionStrings");

                //Delete any existing connectionstrings with the name ComicBookDataBase.
                if (section.ConnectionStrings["ComicBookDataBase"] != null)
                {
                    var keys = section.ConnectionStrings;
                    keys.Remove("ComicBookDataBase");
                }

                //Add new connection string.
                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings(
                                                              "ComicBookDataBase",
                                                              String.Format(
                                                                  $"Provider=Microsoft.ACE.OLEDB.12.0;Persist Security Info=False;Data Source={path};")));

                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");
            }
            catch
            {
                MessageBox.Show("Could not connect to database file.");
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
