using Homework.DataAccess.Abstracts;
using Homework.Entities.Abstracts;
using Homework.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course>
        {
           new Course
           {
               Id=1,
               InstructorName="Engin Demiroğ",
               Name ="Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
               PercentageProgress =83,
           },
           new Course
           {
               Id=2,
               InstructorName="Engin Demiroğ",
               Name ="2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
               PercentageProgress =75,
              },
           new Course
           {
               Id=3,
               InstructorName="Halit Enes Kalaycı",
               Name ="(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",
               PercentageProgress =100,
           }
           };
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(int Id)
        {
            var requestedDelete = _courses.SingleOrDefault(courses => courses.Id == Id);
            _courses.Remove(requestedDelete);
        }

        public Course Get(int Id)
        {
            return _courses.SingleOrDefault(courses => courses.Id == Id);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
