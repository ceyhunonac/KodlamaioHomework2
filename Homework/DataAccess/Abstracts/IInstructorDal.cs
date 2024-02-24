using Homework.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        Instructor Get(int Id);
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(int Id);
    }
}
