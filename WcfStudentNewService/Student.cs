﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfStudentNewService
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student()
        {
            
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}