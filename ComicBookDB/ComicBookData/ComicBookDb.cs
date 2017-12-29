using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.OleDb;


namespace ComicBookData
{
    public static class ComicBookDb
    {
        public static string cnString = ConfigurationManager.ConnectionStrings["ComicBookDataBase"].ConnectionString;
        
        /// <summary>
        /// Inquire about specific ComicBook
        /// </summary>
        /// <param name="STUD_ID"></param>
        /// <returns></returns>
        public static ComicBook Inquire(long CB_Id)
        {
            ComicBook comicBook = null;
            string sql = "SELECT * FROM CBT001_COMICBOOK WHERE CB_Id = @CB_Id;"; // TODO: REMOVE *

            using (OleDbConnection cn = new OleDbConnection(cnString))
            {
                OleDbCommand cm = new OleDbCommand(sql, cn);
                cm.Parameters.AddWithValue("@CB_Id", CB_Id);

                cn.Open();
                OleDbDataReader dr = cm.ExecuteReader();

                if (dr.Read()) comicBook = new ComicBook(dr);

            }

            return comicBook;
        } //End Inquire

        /// <summary>
        /// Method to update ComicBook
        /// </summary>
        /// <param name="student"></param>
        public static void Update(ComicBook comicBook)
        {
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append("UPDATE CBT001_COMICBOOK ");
            sbSQL.Append("SET CB_TITL = @CB_TITL,");
            sbSQL.Append("    CB_DESC = @CB_DESC,");
            sbSQL.Append("    CB_RATE = @CB_RATE,");
            sbSQL.Append("    CB_ART = @CB_ART,");
            sbSQL.Append("    CB_SRS = @CB_SRS,");
            sbSQL.Append("    CB_CHG_USER_ID = @CB_CHG_USER_ID,");
            sbSQL.Append("    CB_CHG_DTM = Now() ");
            sbSQL.Append("WHERE CB_Id = @CB_Id;");

            using (OleDbConnection cn = new OleDbConnection(cnString))
            {
                OleDbCommand cm = new OleDbCommand(sbSQL.ToString(), cn);

                cm.Parameters.AddWithValue("@CB_TITL", comicBook.Title);
                cm.Parameters.AddWithValue("@CB_DESC", comicBook.Description);
                cm.Parameters.AddWithValue("@CB_RATE", comicBook.Rate);
                cm.Parameters.AddWithValue("@CB_ART", comicBook.Artist);
                cm.Parameters.AddWithValue("@CB_SRS", comicBook.Series);
                cm.Parameters.AddWithValue("@CB_CHG_USER_ID", comicBook.CB_CHG_USER_ID);
                cm.Parameters.AddWithValue("@CB_Id", comicBook.CB_Id);

                cn.Open();
                cm.ExecuteNonQuery();
            }

        }// End Update

        public static void Delete(ComicBook comicBook)
        {
            long user_id = long.MinValue;
            if (comicBook.CB_CHG_USER_ID.HasValue)
            {
                user_id = comicBook.CB_CHG_USER_ID.Value;

                Delete(comicBook.CB_Id, user_id);
            }

        }

        public static void Delete(int CB_Id, long CB_CHG_USER_ID)
        {
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append("UPDATE CBT001_COMICBOOK ");
            sbSQL.Append("SET CB_CHG_USER_ID = @CB_CHG_USER_ID,");
            sbSQL.Append("    CB_CHG_DTM = Now(), ");
            sbSQL.Append("    CB_STAT_CD = 'D' ");
            sbSQL.Append("WHERE CB_Id = @CB_Id AND CB_STAT_CD <> 'D';");

            using (OleDbConnection cn = new OleDbConnection(cnString))
            {
                OleDbCommand cm = new OleDbCommand(sbSQL.ToString(), cn);


                cm.Parameters.AddWithValue("@CB_CHG_USER_ID", CB_CHG_USER_ID);
                cm.Parameters.AddWithValue("@CB_Id", CB_Id);

                cn.Open();
                cm.ExecuteNonQuery();
            }
        }// End Delete

        public static void UnDelete(ComicBook comicBook)
        {
            long user_id = long.MinValue;
            if (comicBook.CB_CHG_USER_ID.HasValue)
            {
                user_id = comicBook.CB_CHG_USER_ID.Value;

                UnDelete(comicBook.CB_Id, user_id);
            }

        }

        public static void UnDelete(int CB_Id, long CB_CHG_USER_ID)
        {
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append("UPDATE CBT001_COMICBOOK ");
            sbSQL.Append("SET CB_CHG_USER_ID = @CB_CHG_USER_ID,");
            sbSQL.Append("    CB_CHG_DTM = Now(), ");
            sbSQL.Append("    CB_STAT_CD = 'A' ");
            sbSQL.Append("WHERE CB_Id = @CB_Id AND CB_STAT_CD = 'D';");

            using (OleDbConnection cn = new OleDbConnection(cnString))
            {
                OleDbCommand cm = new OleDbCommand(sbSQL.ToString(), cn);


                cm.Parameters.AddWithValue("@CB_CHG_USER_ID", CB_CHG_USER_ID);
                cm.Parameters.AddWithValue("@CB_Id", CB_Id);

                cn.Open();
                cm.ExecuteNonQuery();
            }
        }// End Delete

        public static void Purge(ComicBook comicBook)
        {
            Purge(comicBook.CB_Id);
        }



        public static void Purge(int CB_Id)
        {
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append("DELETE FROM CBT001_COMICBOOK WHERE CB_Id = @CB_Id AND CB_STAT_CD = 'D';");

            using (OleDbConnection cn = new OleDbConnection(cnString))
            {
                OleDbCommand cm = new OleDbCommand(sbSQL.ToString(), cn);
                cm.Parameters.AddWithValue("@CB_Id", CB_Id);

                cn.Open();
                cm.ExecuteNonQuery();
            }
        }// End Delete

        public static long Add(ComicBook comicBook)
        {
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append("INSERT INTO CBT001_COMICBOOK ");
            sbSQL.Append("(");
            sbSQL.Append("CB_TITL,");
            sbSQL.Append("CB_DESC,");
            sbSQL.Append("CB_RATE,");
            sbSQL.Append("CB_ART,");
            sbSQL.Append("CB_SRS,");
            sbSQL.Append("CB_ADD_USER_ID");
            sbSQL.Append(")");
            sbSQL.Append("VALUES");
            sbSQL.Append("(");
            sbSQL.Append("@CB_TITL,");
            sbSQL.Append("@CB_DESC,");
            sbSQL.Append("@CB_RATE,");
            sbSQL.Append("@CB_ART,");
            sbSQL.Append("@CB_SRS,");
            sbSQL.Append("@CB_ADD_USER_ID");
            sbSQL.Append(");");

            using (OleDbConnection cn = new OleDbConnection(cnString))
            {
                OleDbCommand cm = new OleDbCommand(sbSQL.ToString(), cn);

                
                cm.Parameters.AddWithValue("@CB_TITL,", comicBook.Title);
                cm.Parameters.AddWithValue("@CB_DESC,", comicBook.Description);
                cm.Parameters.AddWithValue("@CB_RATE,", comicBook.Rate);
                cm.Parameters.AddWithValue("@CB_ART,", comicBook.Artist);
                cm.Parameters.AddWithValue("@CB_SRS", comicBook.Series);
                cm.Parameters.AddWithValue("@STUD_ADD_USER_ID", comicBook.CB_ADD_USER_ID);

                cn.Open();
                cm.ExecuteNonQuery();
                cm.Parameters.Clear();

                cm.CommandText = "SELECT @@IDENTITY AS CB_Id;";
                OleDbDataReader dr = cm.ExecuteReader();

                if (dr.Read()) comicBook.CB_Id = (int)dr["CB_Id"];
            }
            return comicBook.CB_Id;
        }// END ADD METHOD
        
    }
    
}
