using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteTakingApp.Data;

namespace Noter.Forms
{
    public partial class frmNote : Form
    {
        #region Properties
        public string labelIdNote;
        public string labelTitle;
        public string labelContent;
        public string labelCreationDate;
        public bool ckBoxActive;
        public int IdNote;
        #endregion

        #region Constructor
        public frmNote()
        {            
            InitializeComponent();
            this.checkBoxActive.Checked = ckBoxActive;
        }    
        #endregion

        #region Methods
        public void SetProperties()
        {            
            this.lblIdNote.Text += this.labelIdNote;
            this.txtBoxTitle.Text += this.labelTitle;
            this.txtBoxContent.Text = this.labelContent;
            this.checkBoxActive.Checked = this.ckBoxActive;
            this.lblCreationDate.Text += this.labelCreationDate;
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            var objNote = new Note();
            if (!string.IsNullOrEmpty(txtBoxTitle.Text))
            {
                objNote.IdNote = this.IdNote;
                objNote.Title = this.txtBoxTitle.Text;
                objNote.Content = this.txtBoxContent.Text;
                objNote.Active = this.checkBoxActive.Checked;
                objNote.SaveNote();
            }
            MessageBox.Show("Success saving note!");
            this.Close();
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var objNote = new Note();
            if (!string.IsNullOrEmpty(txtBoxTitle.Text))
            {
                objNote.IdNote = this.IdNote;                                                
                objNote.DeleteNote();
            }
            MessageBox.Show("Sucess deleting note!");            
            this.Close();
        }
    }
}