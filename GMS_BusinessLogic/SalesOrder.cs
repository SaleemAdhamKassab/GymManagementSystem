using System;
using System.Data;
using GMS_DataAccess;
using static GMS_BusinessLogic.ViewModels.SharedViewModels;

namespace GMS_BusinessLogic
{
    public class SalesOrder
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public int ClientId {  get; set; }
        public int UserId {  get; set; }
        public double AmountAfterDiscount { get; set; }

        public SalesOrder()
        {
            Id = -1;
            Date = DateTime.Now;
            Amount = 0;
            ClientId = -1;
            UserId = -1;
            AmountAfterDiscount = 0;
        }

        private SalesOrder(int id, DateTime date, double amount, int clientId, int userId, double amountAfterDiscount)
        {
            Id = id;
            Date = date;
            Amount = amount;
            ClientId = clientId;
            UserId = userId;
            AmountAfterDiscount = amountAfterDiscount;
        }

        public static SalesOrder find(int id)
        {
            DateTime date = DateTime.Now;
            double amount = 0, amountAfterDiscount = 0;
            int clientId = -1, userId = -1;

            if (SalesOrderData.getSaleOrderInfoById(id, ref date, ref amount, ref clientId,
                ref userId, ref amountAfterDiscount))

                return new SalesOrder(id, date, amount, clientId, userId, amountAfterDiscount);

            else return null;
        }

        // List : Price, ProductId, Quantity, Discount

        public AddSaleOrderViewModel add(SalesOrder order, List<(double, int, int, int?)> saleOrderProducts)
        {
            AddSaleOrderViewModel viewModel = new ();

            viewModel.CreatedSaleOrderId = SalesOrderData.add(order.Amount, order.ClientId, order.UserId, order.AmountAfterDiscount, saleOrderProducts);
            
            if (viewModel.CreatedSaleOrderId != -1)
            {
                viewModel.OutOfStockProducts = SalesOrderData.outOfStockProductNames(saleOrderProducts);
            }

            return viewModel;
        }

        public DataTable get(string searchString) => SalesOrderData.get(searchString);

        public bool delete(int Id) => SalesOrderData.deleteOrder(Id);


        // This is for Order's Products details
        public DataTable getOrderProductsDetails(int orderId) => SalesOrderData.getOrderDetails(orderId);
    }
}
