using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consoleappliation.Models;

namespace consoleappliation
{
    class LinqTutorials
    {


        public List<Product> GetProducts()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product() { productId = 1, productName = "M20", productDescription = "Samsung", price = 12000 });
            productList.Add(new Product() { productId = 2, productName = "M30", productDescription = "Samsung", price = 23000 });
            productList.Add(new Product() { productId = 3, productName = "Readme 7", productDescription = "Redme", price = 14000 });
            productList.Add(new Product() { productId = 4, productName = "Oppo", productDescription = "Oppo", price = 15000 });
            return productList;
        }


        public IList<Student> GetStudents()
        {
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
            new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
            new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
            new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
            new Student() { StudentID = 5, StudentName = "Ron"  }
            };
            return studentList;
        }

        public IList<Standard> GetStandards()
        {
            IList<Standard> standardList = new List<Standard>() {
            new Standard(){ StandardID = 1, StandardName="Standard 1"},
            new Standard(){ StandardID = 2, StandardName="Standard 2"},
            new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };
            return standardList;
        }

    }
}
