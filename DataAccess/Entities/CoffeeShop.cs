using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    //En la Consola del administrador de Paquetes para crear tablas y campos en DB
    //Add-Migration InitialAppDbContextMigration
    //Secleccionar proyecto predeterminado DataAccesss
    //Update-Database

    //lUEGO DE VARIOS PASOS PARA INGRESAR DATOS A LA DB AGREGAR EL SIGUIETNE COMANDO
    //Add-Migration AddCoffeeShops
    //ALLI EN ESE ARCHIVO AGREGAR MIGRATIONBUILDER.SQL Y EL QUERY ADD
    //LUEGO Update-Database
    public class CoffeeShop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OpeningHours { get; set; }
        public string Address { get; set; }

    }
}
