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
    public class ComicBook
    {
        public int CB_Id { get; set; }
        private string CB_TITL;
        private string CB_DESC;
        private byte CB_RATE;
        private int CB_ART;
        private int CB_SRS;

        public long CB_ADD_USER_ID;
        public DateTime? CB_ADD_DTM;
        public long? CB_CHG_USER_ID;
        public DateTime? CB_CHG_DTM;
        public char CB_STAT_CD;

        public ComicBook(OleDbDataReader dr)
        {
            CB_Id = (int)dr["CB_Id"];
            CB_TITL = dr["CB_TITL"] as string;
            CB_DESC = dr["CB_DESC"] as string;
            CB_RATE = (byte)dr["CB_RATE"];
            CB_ART = (int)dr["CB_ART"];
            CB_SRS = (int)dr["CB_SRS"];

            CB_ADD_USER_ID = (int)dr["CB_ADD_USER_ID"];
            CB_ADD_DTM = dr["CB_ADD_DTM"] as DateTime?;
            CB_CHG_USER_ID = dr["CB_CHG_USER_ID"] as long?;
            CB_CHG_DTM = dr["CB_CHG_DTM"] as DateTime?;
            CB_STAT_CD = dr["CB_STAT_CD"].ToString()[0];
        }

        public ComicBook()
        {

        }

        public string Title
        {
            get { return CB_TITL; }
            set { if (value != null) CB_TITL = value; }
        }

        public string Description
        {
            get { return CB_DESC; }
            set { if (value != null && value.Length < 800) CB_DESC = value; }
        }

        public byte Rate
        {
            get { return CB_RATE; }
            set { if (value>= 0 && value <= 5) CB_RATE = value; }
        }

        public int Artist
        {
            get { return CB_ART; }
            set { if (value != -1) CB_ART = value; }
        }

        public int Series
        {
            get { return CB_SRS; }
            set { if (value != -1) CB_SRS = value; }
        }
    }
}
