using Noter.Data.Lists;
using Noter.Forms;
using Noter.Utils;
using NoteTakingApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class BaseForms : Form
    {
        public BaseForms()
        {
            InitializeComponent();
            LoadGridNotes();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (var frm = new frmNote())
            {
                frm.ShowDialog();
            }
        }

        #region Events GridNotes
        private void LoadGridNotes()
        {
            var objList = new ListNote();
            //objList.LoadListNotes();
            if (objList.list.Count > 0)
            {
                gridViewNotes.DataSource = objList.list;
                gridViewNotes.Columns["NewObject"].Visible = false;
                gridViewNotes.Columns["Content"].Visible = false;
                gridViewNotes.Columns["IdNote"].Visible = false;
                gridViewNotes.ReadOnly = true;
            }
            else
                MessageBox.Show("The sql select didn't return any data.");
        }
        #endregion       

        private void gridViewNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in this.gridViewNotes.SelectedRows)
            {
                Note objNote = row.DataBoundItem as Note;
                if (objNote != null)
                {
                    using (var frm = new frmNote())
                    {
                        frm.IdNote = (int)objNote.IdNote;
                        frm.labelIdNote = objNote.IdNote.ToString();
                        frm.labelTitle = objNote.Title;
                        frm.labelContent = objNote.Content;
                        frm.ckBoxActive = objNote.Active;
                        frm.labelCreationDate = objNote.CreationDate.ToShortDateString();
                        frm.SetProperties();
                        frm.ShowDialog();
                    }

                    LoadGridNotes();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var objList = new ListNote();
            objList.LoadListNotes();
            if (objList.list.Count > 0)
            {
                gridViewNotes.DataSource = objList.list;
                gridViewNotes.AutoResizeColumns();
                gridViewNotes.AutoResizeRows();               
                gridViewNotes.ReadOnly = true;
            }
            else
                MessageBox.Show("The sql select didn't return any data.");
        }
    }
}
