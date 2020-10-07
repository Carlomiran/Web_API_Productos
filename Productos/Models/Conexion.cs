using Microsoft.EntityFrameworkCore;

namespace Productos.Models{

    class Conexion : DbContext{
        public Conexion(DbContextOptions<Conexion> options) : base (options){ }
        public DbSet<Productos> Productos {get; set;}

    }
        class Conectar{
            private const  string cadenaConexion ="server=localhost;port=3306;database=prueba;userid=root;pwd=7832#@zxcC";
            public static Conexion Create (){
                var constructor = new DbContextOptionsBuilder<Conexion>(){};
                constructor.UseMySQL(cadenaConexion);
                var cn = new Conexion(constructor.Options);
                return cn;
            }
        }

}

