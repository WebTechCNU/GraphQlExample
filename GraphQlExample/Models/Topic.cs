﻿namespace GraphQlExample.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Product> Products { get; set; }
    }
}
