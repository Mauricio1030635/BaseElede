using EledeRepaso.Core.Implementacion;
using EledeRepaso.Core.Models;
using EledeRepaso.Core.RepositoriosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EledeRepaso.Data.Repositorios
{
    public class ProductRepository:RepositoryBase<EledeDBContext, Producto, int>, IProductRepository
    {
        public ProductRepository(EledeDBContext entities) : base(entities)
        {
        }
    }
}
