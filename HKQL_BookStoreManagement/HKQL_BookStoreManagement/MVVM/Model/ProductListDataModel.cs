using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKQL_BookStoreManagement.MVVM.Model
{
    public class ProductListDataModel
    {
        public List<Book> listOfBook { get; set; }

        public int numOfBooks { get; set; }

        public int numOfPage { get; set; }

        public ProductListDataModel()
        {
            //Do nothing
        }

        public ProductListDataModel(List<Book> listBook)
        {
            listOfBook = listBook;
        }
    }
}
