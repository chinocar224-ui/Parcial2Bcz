// ClnParcial2Bcz - Capa Lógica de Negocios
// Lógica de negocio para Canal

using CadParcial2Bcz;
using System.Collections.Generic;
using System.Linq;

namespace ClnParcial2Bcz
{
    public class CanalCln
    {
        /// <summary>Inserta un nuevo canal y retorna el id generado.</summary>
        public static int crear(Canal canal)
        {
            using (var ctx = new Parcial2BczEntities())
            {
                canal.estado = 1;
                ctx.Canal.Add(canal);
                ctx.SaveChanges();
                return canal.id;
            }
        }

        /// <summary>Actualiza los datos de un canal existente.</summary>
        public static int modificar(Canal canal)
        {
            using (var ctx = new Parcial2BczEntities())
            {
                var existente = ctx.Canal.Find(canal.id);
                if (existente == null) return 0;

                existente.nombre    = canal.nombre;
                existente.frecuencia = canal.frecuencia;
                return ctx.SaveChanges();
            }
        }

        /// <summary>Eliminación lógica: estado = -1.</summary>
        public static int eliminar(int id)
        {
            using (var ctx = new Parcial2BczEntities())
            {
                var existente = ctx.Canal.Find(id);
                if (existente == null) return 0;

                existente.estado = -1;
                return ctx.SaveChanges();
            }
        }

        /// <summary>Obtiene un canal por su id (sin importar estado).</summary>
        public static Canal obtenerUno(int id)
        {
            using (var ctx = new Parcial2BczEntities())
            {
                return ctx.Canal.Find(id);
            }
        }

        /// <summary>Lista todos los canales activos.</summary>
        public static List<Canal> listar()
        {
            using (var ctx = new Parcial2BczEntities())
            {
                return ctx.Canal
                    .Where(c => c.estado == 1)
                    .OrderBy(c => c.nombre)
                    .ToList();
            }
        }
    }
}
