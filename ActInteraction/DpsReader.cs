using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ActInteraction
{
    public class DpsReader
    {
        public static string ConnectionString { get; set; }

        public List<Damage> GetDamage()
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            List<Damage> numbers = new List<Damage>();

            using (conn)
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT name, encdps, duration FROM current_table;";

                MySqlDataReader damageReader = cmd.ExecuteReader();

                while (damageReader.Read())
                {
                    Damage damage = new Damage()
                    {
                        name = damageReader["name"].ToString(),
                        dps = (double)damageReader["encdps"],
                        duration = (double)damageReader["duration"]
                    };
                    numbers.Add(damage);
                }
                return numbers;
            }
        }

        public int UpdateDamage (Damage damage)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);

            using (conn)
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "UPDATE current_table SET name = @name, encdps = @dps, duration = @duration;";
                cmd.Parameters.AddWithValue("name", damage.name);
                cmd.Parameters.AddWithValue("dps", damage.dps);
                cmd.Parameters.AddWithValue("duration", damage.duration);

                return cmd.ExecuteNonQuery();
            }
        }
    }
}
