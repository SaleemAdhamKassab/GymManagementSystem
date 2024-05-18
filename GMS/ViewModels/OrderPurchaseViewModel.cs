namespace GMS.ViewModels
{
	public class OrderPurchaseViewModel
	{
		public int OrderId { get; set; }
		public DateTime Date { get; set; }
		public string UserName { get; set; }
		public string Supplier { get; set; }
		public double TotalAmount { get; set; }
		public double Discount { get; set; }
	}
}
