﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
   public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; } = new List<double>();
        public double averageGrades
        {
            get { return this.Grades.Average(); }
        }
    }
}
