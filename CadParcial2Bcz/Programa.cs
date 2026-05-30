using System;

namespace CadParcial2Bcz
{
    public class Programa
    {
        public int      id                  { get; set; }
        public int      idCanal             { get; set; }
        public string   titulo              { get; set; }
        public string   descripcion         { get; set; }
        public int      duracion            { get; set; }
        public string   productor           { get; set; }
        public DateTime fechaEstreno        { get; set; }
        public short    estado              { get; set; }
        public int      idCategoriaPrograma { get; set; }

        public virtual Canal             Canal             { get; set; }
        public virtual CategoriaPrograma CategoriaPrograma { get; set; }
    }
}
