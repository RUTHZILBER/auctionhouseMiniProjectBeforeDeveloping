using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Auctionhouse.Data;
using Auctionhouse.Db;
using Auctionhouse.Properties;
using Auctionhouse.Utilitis;
using System.Data.OleDb;
using System.Collections;
using Auctionhouse.Gui;
using Auctionhouse.Models;


namespace Auctionhouse.Db
{
    public abstract class GeneralDB
    {
        protected DataTable table;
        protected int currentRow;
        protected string primaryKey;
        protected string primaryKey1;
        protected string primaryKey2;
        protected string primaryKey3;
        //פעולה בונה
        public GeneralDB(string tableName, string primaryKey)
        {
            Dal.GetInstance().AddTable(tableName);
            table = Dal.GetInstance().GetTable(tableName);
            this.primaryKey = primaryKey;
            if (IsEmpty())
                currentRow = -1;
            else
                currentRow = 0;
        }

        //פעולה בונה
        public GeneralDB(string tableName, string primaryKey, string primaryKey1)
        {
            Dal.GetInstance().AddTable(tableName);
            table = Dal.GetInstance().GetTable(tableName);
            this.primaryKey = primaryKey;
            this.primaryKey1 = primaryKey1;
            if (IsEmpty())
                currentRow = -1;
            else
                currentRow = 0;
        }
        //פעולה בונה
        public GeneralDB(string tableName, string primaryKey, string primaryKey1, string primaryKey2, string primaryKey3)
        {
            Dal.GetInstance().AddTable(tableName);
            table = Dal.GetInstance().GetTable(tableName);
            this.primaryKey = primaryKey;
            this.primaryKey1 = primaryKey1;
            this.primaryKey2 = primaryKey2;
            this.primaryKey3 = primaryKey3;
            if (IsEmpty())
                currentRow = -1;
            else
                currentRow = 0;
        }
        //פעולה בונה
        public GeneralDB(string tableName, string primaryKey, string primaryKey1, string primaryKey2)
        {
            Dal.GetInstance().AddTable(tableName);
            table = Dal.GetInstance().GetTable(tableName);
            this.primaryKey = primaryKey;
            this.primaryKey1 = primaryKey1;
            this.primaryKey2 = primaryKey2;
            if (IsEmpty())
                currentRow = -1;
            else
                currentRow = 0;
        }

        //לרשומה הראשונה
        public void GoToFirst()
        {
            if (!IsEmpty())
                currentRow = 0;
        }
        //לרשומה האחרונה
        public void GoToLast()
        {
            if (!IsEmpty())
                currentRow = table.Rows.Count - 1;
        }

        //לרשומה הבאה
        public void MoveToNext()
        {
            if (!IsEmpty())
                if (this.currentRow == table.Rows.Count - 1)
                    currentRow = 0;
                else
                    currentRow++;
        }
        //לרשומה הקודמת
        public void MovePrev()
        {
            if (!IsEmpty())
                if (this.currentRow == 0)
                    currentRow = table.Rows.Count - 1;
                else
                    currentRow--;
        }
        //
        public bool Find(object key)
        {
            int r = 0;
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].ToString().Equals(key.ToString()))
                {
                    currentRow = r;
                    return true;
                }
                else
                    r++;
            }
            return false;
        }
        //פעולה מועמסת: האם קיים במאגר רשומה שהמפתח הראשי שלה זהה למפתח שהתקבל כפרמטר? אם כן ההצבעה תעבור אליה ויוחזר כן אחרת יוחזר לא 
        public bool Find(object key, object key1, object key2)
         {
            int r = 0;
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].ToString().Equals(key.ToString()) && dr[primaryKey1].ToString().Equals(key1.ToString())&&dr[primaryKey2].ToString().Equals(key2.ToString()))
                {
                    currentRow = r;
                    return true;
                }
                else
                    r++;
            }
            return false;
        }
        public bool Find(object key, object key1, object key2, object key3)
        {
            int r = 0;
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].ToString().Equals(key.ToString()) && dr[primaryKey1].ToString().Equals(key1.ToString()) && dr[primaryKey2].ToString().Equals(key2.ToString()) && dr[primaryKey3].ToString().Equals(key3.ToString()))
                {
                    currentRow = r;
                    return true;
                }
                else
                    r++;
            }
            return false;
        }
        public bool Find(object key, object key1)
        {
            int r = 0;
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].ToString().Equals(key.ToString()) && dr[primaryKey1].ToString().Equals(key1.ToString()))
                {
                    currentRow = r;
                    return true;
                }
                else
                    r++;
            }
            return false;
        }
        //גודל הטבלה
        public int Size()
        {
            return table.Rows.Count;
        }
        //האם הטבלה ריקה
        public bool IsEmpty()
        {
            return table.Rows.Count == 0;
        }
        //שמירת הטבלה במסד
        public virtual void Save()
        {
            Dal.GetInstance().Update(table.TableName);
        }
        //אחזור חתך טבלאי [מערך שורות] מהטבלה הנוכחית עפ"י תנאי סינון שהתקבל כפרמטר אם התנאי ריק תוחזר כל הטבלה
        public DataRow[] Filter(string sq1)
        {
            if (sq1.Trim().Length == 0)
                return table.Select();
            return table.Select(sq1);
        }
        //הוספת רשומה חדשה לטבלה וההצבעה תעבור אליה
        public void Add(DataRow dr)
        {
            table.Rows.Add(dr);
            this.Save();
            Find(dr[primaryKey]);
        }
        //מחיקת הרשומה שההצבעה מכוונת אליה ועדכון ההצבעה בהתאם: אם הטבלה ריקה -1 ואם נמחקה השורה האחרונה תעבור ההצבעה לשורה הראשונה
        public virtual void DeleteCurrentRow()
        {
            if (!IsEmpty())
            {
                table.Rows[currentRow].Delete();
                this.Save();
                if (IsEmpty())
                    currentRow = -1;
                if (currentRow + 1 >= Size())
                    currentRow = 0;
            }
        }
        //הרשומה הנוכחית
        public virtual DataRow GetCurrentRow()
        {
            if (!IsEmpty())
                return table.Rows[currentRow];
            else
                return null;
        }
        //הטבלה כולה
        public DataTable GetTable()
        {
            return this.table;
        }
        //עדכון הטבלה כולה עפ"י השינויים
        public void Update()
        {
            Dal.GetInstance().Update(table.TableName);
        }

        //אחזור טבלה חלקית עפ"י תנאי סינון
        public DataTable SelectWhere(string sq1)
        {
            return Dal.GetInstance().GetSelectTable("select * from " + this.table + " where " + sq1);
        }
        //אחזור טבלה חלקית  ממספר טבלאות עפ"י תנאי סינון
        public DataTable SelectMore(string sq1)
        {
            return Dal.GetInstance().GetSelectTable(sq1);
        }
        //מיון הטבלה הנוכחית עפ"י שדה או עפ"י מספר שדות
        public DataTable SortedBy(object field)
        {
            return Dal.GetInstance().GetSelectTable(" select * from " + this.table + " order by " + field.ToString());
        }
        public int GetKey()
        {
            DataTable dt = new DataTable();
            string key;
            int k = currentRow;
            if (k != -1)
            {
                dt = SortedBy(primaryKey);
                int kk = dt.Rows.Count - 1;
                key = dt.Rows[kk][primaryKey].ToString();
            }
            else
                key = "0";
            return Convert.ToInt32(key) + 1;
        }
      
    }
}
