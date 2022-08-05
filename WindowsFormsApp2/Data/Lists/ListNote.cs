using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteTakingApp.Data;

namespace Noter.Data.Lists
{
    class ListNote
    {
        public List<Note> list;
        public ListNote() {
            list = new List<Note>();
        }

        #region Methods
        public void LoadListNotes()
        {
            try
            {
                var data = new DataTable();
                var sqlQuery = new StringBuilder();
                var list = new List<Note>();

                sqlQuery.AppendLine(" SELECT * FROM [dbo].[Note] ORDER BY CREATION_DATE DESC ");
                data = Framework.Database.Transaction.ExecuteSelectListOfObjectCommand(sqlQuery.ToString()).Tables[0];
                foreach (DataRow note in data.Rows)
                {
                    var objNote = new Note();
                    objNote.IdNote = note.Field<int>("ID_NOTE");
                    objNote.Title = note.Field<string>("TITLE");
                    objNote.Content = note.Field<string>("CONTENT");
                    objNote.Active = note.Field<bool>("ACTIVE");
                    objNote.CreationDate = note.Field<DateTime>("CREATION_DATE");
                    this.list.Add(objNote);
                }                
            }
            catch (Exception e)
            {
                throw e;
            }            
        }
        #endregion
    }
}
