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
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors = new List<Instructor>
        {
            new Instructor{Id=1,Name="Engin Demiroğ",InstructorInfo="(MCT),PMP ve ITIL sertifikaları ve Dev Framework"},
            new Instructor{Id=2,Name="Halit Enes Kalaycı",InstructorInfo="kodlama.io'da Yazılım Eğitmeni ve Danışmanı ve nArch"}

        };
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(int Id)
        {
            var requestedDelete = _instructors.SingleOrDefault(instructor => instructor.Id == Id);
            _instructors.Remove(requestedDelete);
        }

        public Instructor Get(int Id)
        {
            return _instructors.SingleOrDefault(instructor => instructor.Id == Id);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            throw new NotImplementedException();
        }
    }
}
