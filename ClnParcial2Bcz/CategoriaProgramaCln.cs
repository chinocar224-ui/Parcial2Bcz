using CadParcial2Bcz;
using System.Collections.Generic;
using System.Linq;

namespace ClnParcial2Bcz
{
    public class CategoriaProgramaCln
    {
        public static List<CategoriaPrograma> listar()
        {
            using (var ctx = new Parcial2BczEntities())
            {
                return ctx.CategoriaPrograma
                    .Where(c => c.estado == 1)
                    .OrderBy(c => c.nombre)
                    .ToList();
            }
        }
    }
}
