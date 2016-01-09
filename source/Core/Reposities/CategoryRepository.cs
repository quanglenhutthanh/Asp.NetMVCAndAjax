using Core.Entities;
using Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Reposities
{
    public class CategoryRepository:RepositoryBase<Category>
    {
        public CategoryRepository(DataContext context):base(context){}
    }
}
