using System.ComponentModel.DataAnnotations;


namespace Productos.Models{
    public class Productos{
        [Key]
        public int id_producto{get; set;}
         public string nombre{get; set;}
        public float precio_costo{get; set;}
        public float precio_venta{get; set;}
        public int existencia{get; set;}
        public string entrada_fn{get; set;}
        public string descripcion{get; set;}
        public string codigo_marca{get; set;}
        public string marca{get; set;}

    }
}