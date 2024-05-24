using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class NoteTakingForm : Form
    {
        DataTable Notes = new DataTable();
        bool editing = false;

        public NoteTakingForm()
        {
            InitializeComponent();
        }

        private void NoteTakingForm_Load(object sender, EventArgs e)
        {
            
            Notes.Columns.Add("Title");
            Notes.Columns.Add("Content");
            // Notes.Columns.Add("Last Updated");
            
            NotesDataGrid.DataSource = Notes;

        }

        private void TextLabel_Click(object sender, EventArgs e)
        {

        }

        private void TitleField_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContentsLabel_Click(object sender, EventArgs e)
        {

        }

        private void ContentsField_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            TitleField.Text = "";
            ContentsField.Text = "";

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                
                Notes.Rows[NotesDataGrid.CurrentCell.RowIndex]["Title"] = TitleField.Text;
                Notes.Rows[NotesDataGrid.CurrentCell.RowIndex]["Content"] = ContentsField.Text;

            }
            else
            {
                Notes.Rows.Add(TitleField.Text, ContentsField.Text);
            }

            TitleField.Text = "";
            ContentsField.Text = "";
            editing = false;
            SaveButton.Text = "Save";
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                TitleField.Text = Notes.Rows[NotesDataGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
                ContentsField.Text = Notes.Rows[NotesDataGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
                editing = true;
                SaveButton.Text = "Update";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Notes.Rows[NotesDataGrid.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void NotesLabel_Click(object sender, EventArgs e)
        {

        }

        private void NotesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NotesDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TitleField.Text = Notes.Rows[NotesDataGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
                ContentsField.Text = Notes.Rows[NotesDataGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
                editing = true;
                SaveButton.Text = "Update";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
