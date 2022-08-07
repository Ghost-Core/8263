using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2_Lab6.Models
{
    public class Course
    {
        public readonly string Code;

        public readonly string Title;
        public int WeeklyHours { get; set; }

        public Course(string code, string title)
        {
            Code = code;
            Title = title;
        }
    }
}