using Homework.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        Category Get(int Id);
        void Add(Category category);
        void Update(Category category);
        void Delete(int Id);
    }
}
