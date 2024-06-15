using System;
using System.Data;
using GMS_DataAccess;


namespace GMS_BusinessLogic
{
    public class SaleOrderProduct
    {
        public int Id { get; set; }
        public double Price {  get; set; }
        public int ProductId {  get; set; }
        public Product ProductInfo { get; set; }
        public int SalesOrderId {  get; set; }
        public SalesOrder SalesOrderInfo { get; set; }
        public int Quantity {  get; set; }
        public int? Discount {  get; set; }


        public SaleOrderProduct() 
        {
            Id = -1;
            Price = 0.0f;
            ProductId = -1;
            SalesOrderId = -1;
            Quantity = 0;
            Discount = 0;
        }
        private SaleOrderProduct(int id, double price, int productId, int salesOrderId, int quantity, int? discount)
        {
            Id = id;
            Price = price;
            ProductId = productId;
            ProductInfo = Product.find(ProductId);
            SalesOrderId = salesOrderId;
            SalesOrderInfo = SalesOrder.find(SalesOrderId);
            Quantity = quantity;
            Discount = discount;
        }

        public static SaleOrderProduct find(int Id)
        {
            int? discount = 0;
            double price = 0;
            int productId = 0, salesOrderId = 0, quantity = 0;
            

            if (SalesOrderProductData.getSalesOrderProductInfoById(Id, ref price, ref productId, ref salesOrderId,
                ref quantity, ref discount))

                return new SaleOrderProduct(Id, price, productId, salesOrderId, quantity, discount);
            else return null;
        }
    }
}
