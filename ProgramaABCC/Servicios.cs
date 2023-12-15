using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using ProgramaABCC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaABCC
{
    public class Servicios
    {

        private readonly EjercicioTecnicoContext _ejercicioTecnicoContext;

        public Servicios(EjercicioTecnicoContext ejercicioTecnicoContext)
        {
            _ejercicioTecnicoContext = ejercicioTecnicoContext;
        }

        public Articulo Consultar(int sku)
        {
            var parametro = new SqlParameter("@Sku", SqlDbType.Int) {Value=sku};

            FormattableString consulta = $"EXEC Consulta @Sku = {parametro}";

            return _ejercicioTecnicoContext.Articulos.FromSqlInterpolated(consulta).AsNoTracking().AsEnumerable().FirstOrDefault();
        }

        public void Alta(int sku, string articulo, string marca, string modelo, int departamento, int clase, int familia, int stock, int cantidad)
        {
            var parametros = new[]
            {
                new SqlParameter("@Sku", SqlDbType.Int) { Value = sku },
                new SqlParameter("@Articulo", SqlDbType.NVarChar, 15) { Value = articulo },
                new SqlParameter("@Marca", SqlDbType.NVarChar, 15) { Value = marca },
                new SqlParameter("@Modelo", SqlDbType.NVarChar, 20) { Value = modelo },
                new SqlParameter("@Departamento", SqlDbType.Int) { Value = departamento },
                new SqlParameter("@Clase", SqlDbType.Int) { Value = clase },
                new SqlParameter("@Familia", SqlDbType.Int) { Value = familia },
                new SqlParameter("@Stock", SqlDbType.Int) { Value = stock },
                new SqlParameter("@Cantidad", SqlDbType.Int) { Value = cantidad }
            };
           

            _ejercicioTecnicoContext.Database.ExecuteSqlRaw("EXEC Alta @Sku, @Articulo, @Marca, @Modelo, @Departamento, @Clase, @Familia, @Stock, @Cantidad", parametros);
        }

        public void Actualizar(int sku, string articulo, string marca, string modelo, int departamento, int clase, int familia, int cantidad, int stock, int descontinuado)
        {
            var parametros = new[]
            {
                new SqlParameter("@Sku", SqlDbType.Int) { Value = sku },
                new SqlParameter("@Articulo", SqlDbType.NVarChar, 15) { Value = articulo },
                new SqlParameter("@Marca", SqlDbType.NVarChar, 15) { Value = marca },
                new SqlParameter("@Modelo", SqlDbType.NVarChar, 20) { Value = modelo },
                new SqlParameter("@Departamento", SqlDbType.Int) { Value = departamento },
                new SqlParameter("@Clase", SqlDbType.Int) { Value = clase },
                new SqlParameter("@Familia", SqlDbType.Int) { Value = familia },
                new SqlParameter("@Stock", SqlDbType.Int) { Value = stock },
                new SqlParameter("@Cantidad", SqlDbType.Int) { Value = cantidad },
                new SqlParameter("@Descontinuado", SqlDbType.Int) { Value = descontinuado }
            };
            _ejercicioTecnicoContext.Database.ExecuteSqlRaw("EXEC Cambio @Sku, @Articulo, @Marca, @Modelo, @Departamento, @Clase, @Familia, @Stock, @Cantidad, @Descontinuado", parametros);

        }

        public void Borrar(int sku)
        {
            var parametro = new SqlParameter("@Sku", SqlDbType.Int) { Value = sku };
            _ejercicioTecnicoContext.Database.ExecuteSqlRaw("EXEC Baja @Sku", parametro);
        }

        public List<Departamento> ObtenerDepartamentos()
        {
            return _ejercicioTecnicoContext.Departamentos.ToList();
        }

        public List<Clase> ObtenerClases(int numeroDepartamento)
        {
            return _ejercicioTecnicoContext.Clases.Where(x => x.NumeroDepartamento == numeroDepartamento).ToList();
        }

        public List<Familia> ObtenerFamilias(string nombreClase)
        {
            
            return _ejercicioTecnicoContext.Familias.Where(x => x.NombreClase == nombreClase).ToList();
        }
    }
}
