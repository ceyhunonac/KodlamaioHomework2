using Homework.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        Course Get(int Id);
        void Add(Course course);
        void Update(Course course);
        void Delete(int Id);
    }
}
