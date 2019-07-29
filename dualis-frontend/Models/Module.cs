using System;

namespace dualis_frontend.Models
{
    public class Module
    {
        public string module_no { get; set; }
        public string module_name { get; set; }
        public string final_grade { get; set; }
        public string credits { get; set; }
        public string exams_url { get; set; }
        public Nullable<bool> passed { get; set; }
        public string semesters { get; set; }
        public Grade[] grades { get; set; }
    }
}