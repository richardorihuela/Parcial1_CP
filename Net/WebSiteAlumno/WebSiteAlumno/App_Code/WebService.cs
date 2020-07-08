using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {
        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }
    //Pregunta 1
    //Genere un Web Service de los datos alumno de su persona
    [WebMethod]
    public List<string> alumno(int ci)
    {
        switch (ci) {
            case 9064877:
                List<string> datos1 = new List<string>();
                datos1.Add("Richard");
                datos1.Add("Orihuela");
                datos1.Add("Gil");
                datos1.Add("67142884");
                return datos1;
            default:
                List<string> datos = new List<string>();
                datos.Add("");
                datos.Add("");
                datos.Add("");
                datos.Add("");
                return datos;
        }
    }
    //Genere un Web Service de los datos alumno de su persona con DB
    [WebMethod]
    public DataSet alumnoDB(int ci) {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "server=DESKTOP-MBV61GG\\SQLEXPRESS01; user=parker; pwd=123456; database=parcial1";

        SqlDataAdapter ada = new SqlDataAdapter();
        ada.SelectCommand = new SqlCommand();
        ada.SelectCommand.Connection = con;
        ada.SelectCommand.CommandText = "select * from alumno where ci=@ci";
        ada.SelectCommand.CommandType = CommandType.Text;
        ada.SelectCommand.Parameters.Add("@ci", SqlDbType.Int).Value = ci;

        DataSet ds = new DataSet();
        ada.Fill(ds);
        return ds;
    }
}
