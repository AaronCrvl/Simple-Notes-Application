using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp.Data
{
    public class Note
    {
        #region Properties 
        private long pvIdNote;
        private string pvTitle;
        private string pvContent;
        private DateTime pvCreationDate;
        private bool pvActive;
        private bool pvnewObject;
        #endregion

        #region Constructor 
        public Note()
        {
            this.NewObject = true;
        }
        public Note(string title, string context, DateTime creationDate, bool active)
        {
            this.Title = title;
            this.Content = context;
            this.CreationDate = creationDate;
            this.Active = active;
            this.NewObject = true;
        }
        public Note(long idNota)
        {
            this.IdNote = idNota;
            this.NewObject = false;
        }
        #endregion        

        #region Vars
        public long IdNote
        {
            get
            {
                return this.pvIdNote;
            }
            set
            {
                this.pvIdNote = value;
            }
        }
        public string Title
        {
            get
            {
                return this.pvTitle;
            }
            set
            {
                this.pvTitle = value;
            }
        }
        public string Content
        {
            get
            {
                return this.pvContent;
            }
            set
            {
                this.pvContent = value;
            }
        }
        public DateTime CreationDate
        {
            get
            {
                return this.pvCreationDate;
            }
            set
            {
                this.pvCreationDate = value;
            }
        }
        public bool Active
        {
            get
            {
                return this.pvActive;
            }
            set
            {
                this.pvActive = value;
            }
        }
        public bool NewObject
        {
            get
            {
                return this.pvnewObject;
            }
            set
            {
                this.pvnewObject = value;
            }
        }
        #endregion

        #region Methods        
        public void SaveNote()
        {            
            if (IsNewObject())
                CreateNote();
            else
                UpdateNote();
        }
        private string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        private void CleanData()
        {
            this.Content.Replace("'", "");
            this.Title.Replace("'", "");

            this.Content = RemoveSpecialCharacters(this.Content);
            this.Title = RemoveSpecialCharacters(this.Title);
        }
        public void CreateNote()
        {

            try
            {

                CleanData();

                var sqlIdQuery = new StringBuilder();
                sqlIdQuery.AppendLine(" SELECT TOP 1 ID_NOTE FROM Note N(NOLOCK) ");
                sqlIdQuery.AppendLine($" ORDER BY ID_NOTE DESC ");
                
                var data = Framework.Database.Transaction.ExecuteSelectSingleObjectCommand(sqlIdQuery.ToString());
                this.IdNote = (data == null ? 1: data.Field<int>("ID_NOTE"));
                this.IdNote += 1;

                var sqlQuery = new StringBuilder();
                sqlQuery.AppendLine(" INSERT INTO [dbo].[Note] (ID_NOTE, TITLE, CONTENT, CREATION_DATE, ACTIVE)");
                sqlQuery.AppendLine($" VALUES ({this.IdNote}, '{this.Title}', '{this.Content}', CONVERT(DATE, '{DateTime.Now.ToString()}', 103), {(this.Active == true ? "1": "0")})");
                Framework.Database.Transaction.ExecuteCreateObjectCommand(sqlQuery.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public void UpdateNote()
        {
            try
            {
                var sqlQuery = new StringBuilder();
                sqlQuery.AppendLine(" UPDATE Note SET ");
                sqlQuery.AppendLine($" TITLE = '{this.Title}', ");
                sqlQuery.AppendLine($" CONTENT = '{this.Content}', ");
                sqlQuery.AppendLine($" ACTIVE = {(this.Active == true ? "1" : "0")} ");
                sqlQuery.AppendLine($" WHERE ID_NOTE = {this.IdNote}");
                Framework.Database.Transaction.ExecuteUpdateObjectCommand(sqlQuery.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteNote()
        {
            try
            {
                var sqlQuery = new StringBuilder();
                sqlQuery.AppendLine(" DELETE FROM Note ");                                                
                sqlQuery.AppendLine($" WHERE ID_NOTE = {this.IdNote.ToString()} ");
                Framework.Database.Transaction.ExecuteUpdateObjectCommand(sqlQuery.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AlterNote(Note objNote)
        {
            this.pvTitle = objNote.Title;
            this.Content = objNote.Content;
            this.Active = objNote.Active;
            this.CreationDate = DateTime.Now;
            UpdateNote();
        }
        public bool IsNewObject()
        {
            try
            {
                if (this.IdNote <= 0)
                    return true;

                var sqlQuery = new StringBuilder();
                sqlQuery.AppendLine(" SELECT * FROM Note N(NOLOCK) ");
                sqlQuery.AppendLine($" WHERE N.ID_NOTE = {this.IdNote} ");
                var data = Framework.Database.Transaction.ExecuteSelectSingleObjectCommand(sqlQuery.ToString());

                if (data.Table.Rows.Count > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                throw e; 
            }            
        }
        #endregion
    }
}
