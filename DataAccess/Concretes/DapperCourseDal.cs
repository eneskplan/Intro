﻿using İntro.DataAccess.Abstracts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İntro.DataAccess.Concretes
{
    public class DapperCourseDal : ICourseDal
    {
        List<Course> courses;
        public DapperCourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "Rust";
            course1.Description = ".NET 8";
            course1.Price = 0;


            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java";
            course2.Description = "Java 17";
            course2.Price = 10;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "Python";
            course3.Description = "Python 3.12";
            course3.Price = 20;

            courses = new List<Course> { course1, course2, course3 };
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public List<Course> GetAll()
        {
            return courses;
        }
    }
}