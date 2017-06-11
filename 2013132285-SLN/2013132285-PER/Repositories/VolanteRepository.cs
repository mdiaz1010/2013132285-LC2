using _2013223347_ENT.Entities;
using _2013223347_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013223347_PER.Repositories
{
    public class VolanteRepository : Repository<Volante>, IVolanteRepository
    {
        public VolanteRepository(EnsambladoraDbContext context) : base(context)
        {
           
        }

    }
}
