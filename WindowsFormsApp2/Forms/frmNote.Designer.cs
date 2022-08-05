namespace Noter.Forms
{
    partial class frmNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxContent = new System.Windows.Forms.RichTextBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblIdNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxContent
            // 
            this.txtBoxContent.Location = new System.Drawing.Point(15, 135);
            this.txtBoxContent.Name = "txtBoxContent";
            this.txtBoxContent.Size = new System.Drawing.Size(382, 212);
            this.txtBoxContent.TabIndex = 0;
            this.txtBoxContent.Text = "";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.Location = new System.Drawing.Point(313, 95);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(64, 20);
            this.checkBoxActive.TabIndex = 1;
            this.checkBoxActive.Text = "Active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(55, 95);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(239, 20);
            this.txtBoxTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 99);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title:";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationDate.Location = new System.Drawing.Point(12, 12);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(93, 16);
            this.lblCreationDate.TabIndex = 4;
            this.lblCreationDate.Text = "Creation Date:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(254, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(334, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 33);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblIdNote
            // 
            this.lblIdNote.AutoSize = true;
            this.lblIdNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNote.Location = new System.Drawing.Point(12, 66);
            this.lblIdNote.Name = "lblIdNote";
            this.lblIdNote.Size = new System.Drawing.Size(22, 16);
            this.lblIdNote.TabIndex = 7;
            this.lblIdNote.Text = "Id:";
            // 
            // frmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 359);
            this.Controls.Add(this.lblIdNote);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.txtBoxContent);
            this.Name = "frmNote";
            this.Text = "Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxContent;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblIdNote;
    }
}