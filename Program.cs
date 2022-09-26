using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DapperExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start application");

            using (IDbConnection db = new SqlConnection("server=192.168.1.69;user=exchange;password=exchange1;database=Exchange"))
            {
                var result = db.Query<Wallets>("SELECT Id, Convert(Decimal(38,14),Value) as Value from Wallets").ToList();

                var i = 10;
            }

        }

        class Wallets
        {
            public int Id { get; set; }
            public decimal Value { get; set; }
        }
    }
}