using Microsoft.EntityFrameworkCore;

namespace web_api_db.Models
{

    class Conexion : DbContext{
        public Conexion (DbContextOptions<Conexion> options) : base (options){}
        public DbSet<Clientes> Clientes {get; set;}
    }
    class Conectar{
        private const string cadenaConexion = "server=localhost;port=3306;database=empresa;userid=root;pwd=";
        public static Conexion Create(){
            var constuctor = new DbContextOptionsBuilder<Conexion>();
            constuctor.UseMySQL(cadenaConexion);
            var cn = new Conexion (constuctor.Options);
            return cn;
        }
    }
}