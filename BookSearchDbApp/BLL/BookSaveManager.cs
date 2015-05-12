using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSearchDbApp.DAL;

namespace BookSearchDbApp.BLL
{
    class BookSaveManager
    {
        BookSaveGetway aGetway = new BookSaveGetway();

        public string insert(Employee anEmployee)
        {
            int  result = aGetway.insert(anEmployee);

            if (result > 0)
            {
                return "Saved successfully";
            }

            else
            {
                return "Save failed";
            }
    }
}
