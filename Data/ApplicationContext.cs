﻿using bookDemo.Models;

namespace bookDemo.Data
{
    public static class ApplicationContext
    {
        public static List<Book> Books { get; set; }
        static ApplicationContext()
        {
            Books = new List<Book>()
            {
                new Book(){Id=1, Title="Hamlet", Price = 75},
                new Book(){Id=2, Title="Faust", Price = 150},
                new Book(){Id=3, Title="Frankestain", Price = 75}
            };
        }
    }
}
