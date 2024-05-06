using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class OrderData
    {
        public static int add(DateTime date, int supplierId, int userId, decimal? discount, List<(int , decimal, int)>orderProducts)
        {
            int orderId = CRUD.add($"INSERT INTO Orders (Date, SupplierId, UserId) VALUES ('{date}', '{supplierId}', '{userId}')");
            string query = string.Empty;
            decimal orederTotalAmount = 0;

            for(int i = 0; i < orderProducts.Count; i++)
            {
                query = $"INSERT INTO OrderProducts VALUES ({orderProducts.ElementAt(i).Item1}, {orderProducts.ElementAt(i).Item2}, {orderProducts.ElementAt(i).Item3}, {orderId}) ";
                orederTotalAmount += orderProducts.ElementAt(i).Item1 * orderProducts.ElementAt(i).Item2;
                CRUD.add(query);
            }

            query = $"UPDATE Orders SET TotalAmount = {orederTotalAmount}, Discount = {discount}";

            return 0;

        }


    }
}
