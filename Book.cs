using System;
using System.ComponentModel.DataAnnotations;

namespace BooManagerApi
{
    public class Book
    {
        [Key]
        public int ID { get; set; }

        public string Author { get; set; }

        public string Name { get; set; }
        public string Descscription { get; set; }

    }
}
