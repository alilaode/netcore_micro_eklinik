using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using Product.Core.Entities;
using Product.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Infrastructure.Repositories
{

    public class ProductRepository : IProductRepository
    {
        private readonly IConfiguration _configuration;

        public ProductRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<Medicine> GetMedicine(string productName)
        {
            await using var connection = new NpgsqlConnection(_configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var coupon = await connection.QueryFirstOrDefaultAsync<Medicine>
                ("SELECT * FROM Coupon WHERE ProductName = @ProductName", new { ProductName = productName });
            if (coupon == null)
                return new Medicine { Name = "No Discount", Price = 0};
            return coupon;
        }

        public async Task<bool> CreateMedicine(Medicine medicine)
        {
            await using var connection = new NpgsqlConnection(_configuration.GetValue<string>("DatabaseSettings:ConnectionString"));

            var affected =
                await connection.ExecuteAsync
                ("INSERT INTO Medicine (Name, Price) VALUES (@Name, @Price)",
                    new { Name = medicine.Name, Price = medicine.Price });

            if (affected == 0)
                return false;

            return true;
        }

        public async Task<bool> UpdateMedicine(Medicine medicine, string oldName)
        {
            await using var connection = new NpgsqlConnection(_configuration.GetValue<string>("DatabaseSettings:ConnectionString"));

            var affected = await connection.ExecuteAsync
            ("UPDATE Medicine SET Name = @Name, Price = @Price WHERE Name = @oldName",
                new { Name = medicine.Name, Price = medicine.Price, oldName = oldName });

            if (affected == 0)
                return false;

            return true;
        }

        public async Task<bool> DeleteMedicine(string name)
        {
            await using var connection = new NpgsqlConnection(_configuration.GetValue<string>("DatabaseSettings:ConnectionString"));

            var affected = await connection.ExecuteAsync("DELETE FROM Medicine WHERE Name = @Name",
                new { Name = name });

            if (affected == 0)
                return false;

            return true;
        }
    }
}
