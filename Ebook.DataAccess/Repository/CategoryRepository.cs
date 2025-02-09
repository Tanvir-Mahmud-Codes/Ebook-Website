using Ebook.DataAccess.Data;
using Ebook.DataAccess.Repository.IRepository;
using Ebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContex _db;
        public CategoryRepository(ApplicationDbContex db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
