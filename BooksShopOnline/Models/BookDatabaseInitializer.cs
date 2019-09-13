using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BooksShopOnline.Models
{
    public class BookDatabaseInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>{
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Lập Trình"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "WebSite"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Mạng Máy Tính"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Đồ Họa"
                }
            };
            return categories;
        }
        private static List<Book> GetBooks()
        {
            var books = new List<Book>
            {    
                //book 1
                 new Book
                 {
                     BookID = 1,
                     BookName = "Lập Trình C++",
                     Description = "Lập trình cơ bản",
                     ImagePath ="ltc.jpg",
                     UnitPrice = 4f,
                     CategoryID = 1
                 },
                //book 2
                new Book
                {
                    BookID = 2,
                    BookName = "Lập Trình C#",
                    Description = "Lập Trình Nâng Cao",
                    ImagePath ="ltcsharp.jpg",
                    UnitPrice = 4.5f,
                    CategoryID = 1
                },
                //book 3
                new Book
                {
                    BookID = 3,
                    BookName = "HTML5 & CSS3",
                    Description = "WebSite cơ bản",
                    ImagePath ="htmlvacss.jpg",
                    UnitPrice = 26.73f,
                    CategoryID = 2
                },
                //book 4
                new Book
                {
                    BookID = 4,
                    BookName = "JavaScript",
                    Description = "WebSite nâng cao",
                    ImagePath ="javascript.jpg",
                    UnitPrice = 23.79f,
                    CategoryID = 2
                },
                //book 5
                new Book
                {
                    BookID = 5,
                    BookName = "CNNA",
                    Description = "CCNA cơ bản",
                    ImagePath ="ccna.jpg",
                    UnitPrice = 16.04f,
                    CategoryID = 3
                },
                //book 6
                new Book
                {
                    BookID = 6,
                    BookName = "MCSA",
                    Description = "MCSA cơ bản",
                    ImagePath ="mcsa.png",
                    UnitPrice = 16.04f,
                    CategoryID = 3
                },
                //book 7
                new Book
                {
                    BookID = 7,
                    BookName = "Photoshop cơ bản",
                    Description = "Photoshop cơ bản",
                    ImagePath ="ptscoban.png",
                    UnitPrice = 16.04f,
                    CategoryID = 4
                },
                //book 8
                new Book
                {
                    BookID = 8,
                    BookName = "Photoshop nâng cao",
                    Description = "Photoshop nâng cao",
                    ImagePath ="ptsnangcao.png",
                    UnitPrice = 16.04f,
                    CategoryID = 4
                },
                };
            return books;
        }
    }
}