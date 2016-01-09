using Core.Entities;
using Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Reposities
{
    public class GadgetRepository : RepositoryBase<Gadget>
    {
        public GadgetRepository(DataContext context):base(context){}
    }
}
