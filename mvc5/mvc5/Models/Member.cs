using System;

namespace mvc5.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public DateTime Birth { get; set; }
        public bool Married { get; set; }
        public string Memo { get; set; }
    }
}