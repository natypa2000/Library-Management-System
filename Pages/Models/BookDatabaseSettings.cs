﻿namespace WebApplication8.Pages.Models
{
    public class BookDatabaseSettings
    {
        public string ConnectionString {get; set;}=null;

        public string DatabaseName { get; set; } = null;

        public string BooksCollectionName { get; set; } = null;
    }
}
