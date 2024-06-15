using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS_BusinessLogic.ViewModels
{
    public class SharedViewModels
    {
        public class AddSaleOrderViewModel
        {
            public int CreatedSaleOrderId { get; set; }
            public List<string> OutOfStockProducts { get; set; }

        }
    }
}
