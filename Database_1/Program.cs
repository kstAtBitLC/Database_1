using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_1 {
    class Program {
        static void Main ( string [] args ) {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Gebrauchtwagen;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using ( SqlConnection connection = new SqlConnection ( connectionString ) ) {
                connection.Open ();
                // Execute operations against the database 
                SqlCommand command = new SqlCommand ( "select * from fahrzeug", connection );

                SqlDataReader reader = command.ExecuteReader ();

                while ( reader.Read () ) {
                    string marke = reader [ "marke" ].ToString ();
                    string modell = reader [ "modell" ].ToString ();
                    string fahrzeug_ID = reader [ "fahrzeug_id" ].ToString ();
                    string preis = reader [ "preis" ].ToString ();
                    string verkaeufer_id = reader [ "verkaeufer_id" ].ToString ();

                    Console.WriteLine ( "Marke: {0} Modellreihe: {1}", marke, modell );
                }
            } // Connection wird automatisch geschlossen
            Console.Read ();
        }
    }
}
