using System;
using System.Collections.Generic;
namespace CodeWarsUserCompleted
{
    public class Datum
    {
        public string id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public DateTime completedAt { get; set; }
        public List<string> completedLanguages { get; set; }
    }

    public class RootObject
    {
        public int totalPages { get; set; }
        public int totalItems { get; set; }
        public List<Datum> data { get; set; }
    }
}