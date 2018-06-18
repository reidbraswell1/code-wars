using System;
using System.Collections.Generic;
using CodeWarsUser;
namespace CodeWars.Shared
{
    public class Student 
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int ClassId { get; set; }
        public string CodeWarsUserId { get; set; }
        public string CodeWarsApiKey { get; set; }
        public int CodeWarsOverallScore { get; set; }
    }
}