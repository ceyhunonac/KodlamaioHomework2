using Homework.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Entities.Concretes
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string InstructorName { get; set; }

        public int PercentageProgress { get; set; }
    }
}
