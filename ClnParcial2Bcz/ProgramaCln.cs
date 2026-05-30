using CadParcial2Bcz;
using System.Collections.Generic;
using System.Linq;

namespace ClnParcial2Bcz
{
    public class ProgramaCln
    {
        public static int crear(Programa programa)
        {
            using (var ctx = new Parcial2BczEntities())
            {
                programa.estado = 1;
                ctx.Programa.Add(programa);
                ctx.SaveChanges();
                return programa.id;
            }
        }

        public static int modificar(Programa programa)
        {
            using (var ctx = new Parcial2BczEntities())
            {
                var existente = ctx.Programa.Find(programa.id);
                if (existente == null) return 0;

                existente.idCanal             = programa.idCanal;
                existente.titulo              = programa.titulo;
                existente.descripcion         = programa.descripcion;
                existente.duracion            = programa.duracion;
                existente.productor           = programa.productor;
                existente.fechaEstreno        = programa.fechaEstreno;
                existente.idCategoriaPrograma = programa.idCategoriaPrograma;
                return ctx.SaveChanges();
            }
        }

        public static int eliminar(int id)
        {
            using (var ctx = new Parcial2BczEntities())
            {
                var existente = ctx.Programa.Find(id);
                if (existente == null) return 0;
                existente.estado = -1;
                return ctx.SaveChanges();
            }
        }

        public static Programa obtenerUno(int id)
        {
            using (var ctx = new Parcial2BczEntities())
            {
                return ctx.Programa.Find(id);
            }
        }

        public static List<ProgramaListarDto> listar(string parametro)
        {
            parametro = (parametro ?? string.Empty).Trim();
            using (var ctx = new Parcial2BczEntities())
            {
                return ctx.Programa
                    .Where(p => p.estado == 1 &&
                                (p.titulo.Contains(parametro) ||
                                 p.productor.Contains(parametro) ||
                                 p.Canal.nombre.Contains(parametro)))
                    .OrderBy(p => p.titulo)
                    .Select(p => new ProgramaListarDto
                    {
                        id                  = p.id,
                        idCanal             = p.idCanal,
                        canal               = p.Canal.nombre,
                        titulo              = p.titulo,
                        descripcion         = p.descripcion,
                        duracion            = p.duracion,
                        productor           = p.productor,
                        fechaEstreno        = p.fechaEstreno,
                        idCategoriaPrograma = p.idCategoriaPrograma,
                        categoria           = p.CategoriaPrograma.nombre,
                        estado              = p.estado
                    })
                    .ToList();
            }
        }
    }

    public class ProgramaListarDto
    {
        public int             id                  { get; set; }
        public int             idCanal             { get; set; }
        public string          canal               { get; set; }
        public string          titulo              { get; set; }
        public string          descripcion         { get; set; }
        public int             duracion            { get; set; }
        public string          productor           { get; set; }
        public System.DateTime fechaEstreno        { get; set; }
        public int             idCategoriaPrograma { get; set; }
        public string          categoria           { get; set; }
        public short           estado              { get; set; }
    }
}
