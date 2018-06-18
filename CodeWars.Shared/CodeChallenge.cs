using System;
using System.Collections.Generic;
using CodeWarsUser;
namespace CodeWars
{
    public class Rank
    {
        public int id { get; set; }
        public string name { get; set; }
        public string color { get; set; }
    }
    public class CreatedBy
    {
        public string username { get; set; }
        public string url { get; set; }
    }
    public class Unresolved
    {
        public int issues { get; set; }
        public int suggestions { get; set; }
    }
    public class RootObject
    {
        public string id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string category { get; set; }
        public DateTime publishedAt { get; set; }
        public object approvedAt { get; set; }
        public List<string> languages { get; set; }
        public string url { get; set; }
        public Rank rank { get; set; }
        public DateTime createdAt { get; set; }
        public CreatedBy createdBy { get; set; }
        public string description { get; set; }
        public int totalAttempts { get; set; }
        public int totalCompleted { get; set; }
        public int totalStars { get; set; }
        public int voteScore { get; set; }
        public List<string> tags { get; set; }
        public bool contributorsWanted { get; set; }
        public Unresolved unresolved { get; set; }
    }
}