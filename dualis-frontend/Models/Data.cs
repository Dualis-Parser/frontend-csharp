using System;

namespace dualis_frontend.Models
{
    public class Data
    {
        public string username { get; set; }
        public string name { get; set; }
        public string[] semesters { get; set; }
        public Module[] modules { get; set; }
    }
}