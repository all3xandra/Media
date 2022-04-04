using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Media
{
    /// <summary>
    /// Descripción breve de Cliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Cliente : System.Web.Services.WebService
    {
        private BBDD.Datos bd = new BBDD.Datos();
        public int mediaHoras(String asign)
        {
            List<int> horas = bd.getHoras(asign);

            return horas.Sum()/horas.Count();
        }
    }
}
