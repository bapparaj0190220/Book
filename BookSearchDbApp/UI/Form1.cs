using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookSearchDbApp.BLL;
using BookSearchDbApp.Model;

namespace BookSearchDbApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BookSaveManager bookSaveManager = new BookSaveManager();
        private void saveButton_Click(object sender, EventArgs e)
        {
            BookSave bookSave = new BookSave();

            BookSave.name = nameTextBox.Text;
            BookSave.isbn = isbnTextBox.Text;
            BookSave.author = authorTextBox.Text;


            bookSaveManager.insert(bookSave);

            empty();


        }

        public void empty()
        {
            nameTextBox.Text = "";
            isbnTextBox.Text = "";
            authorTextBox.Text = "";
            
        }
    }
}
