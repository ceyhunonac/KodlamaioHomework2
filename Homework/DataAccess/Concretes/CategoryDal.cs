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
    public class CategoryDal : ICategoryDal
    {

        List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>
        {
            new Category{Id=1,Name="Yazılım Geliştirici Yetiştirme Kampı Başlangıç seviye"},
            new Category{Id=2,Name="Yazılım Geliştirici Yetiştirme Kampı İleri seviye"}
            
        };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(int Id)
        {
            var requestedDelete = _categories.SingleOrDefault(categories => categories.Id == Id);
            _categories.Remove(requestedDelete);
        }

        public Category Get(int Id)
        {
            return _categories.SingleOrDefault(categories => categories.Id == Id);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {

            throw new NotImplementedException();
        }
    }
}
