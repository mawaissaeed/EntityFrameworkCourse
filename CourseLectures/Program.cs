﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseLectures.Persistence;

namespace CourseLectures
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new PlutoContext()))
            {
                // Example 1
                var course = unitOfWork.Courses.Get(1);

                // Example 2
                var courses = unitOfWork.Courses.GetCoursesWithAuthors(1, 4);

                // Example 3
                var author = unitOfWork.Authors.GetAuthorWithCourses(5);
                unitOfWork.Courses.RemoveRange(author.Courses);
                unitOfWork.Authors.Remove(author);
                unitOfWork.Complete();
            }

            // 75 ASP.NET MVC Example

        }
    }
}
