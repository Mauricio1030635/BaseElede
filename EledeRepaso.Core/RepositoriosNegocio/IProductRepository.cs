using EledeRepaso.Core.Models;
using EledeRepaso.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EledeRepaso.Core.RepositoriosNegocio
{
    public interface IProductRepository : IDatabaseRepository<Producto, int>
    {
    }
}
