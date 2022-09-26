using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace DapperExample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (IDbConnection db = new SqlConnection("server=localhost;user=exchange;password=exchange1;database=Exchange"))
            {
                var result = await db.QueryAsync<Wallets>("SELECT Convert(Decimal(38,20),91234567.12345678901234567891) as Value");

                int i = 10;
            }

        }

        class Wallets
        {
            public int Id { get; set; }
            public decimal Value { get; set; }
        }
    }
}