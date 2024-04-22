using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMS_DataAccess;

namespace GMS_BusinessLogic
{
    public class Product : IGmsRepo<Product>
    {
        enum enMode { addNew = 1, update = 2 }
        enMode _Mode = enMode.addNew;

        public int Id {  get; set; }
        public string Name { get; set; }
        public short Quantity {  get; set; }
        public int CategoryId {  get; set; }

        public Product()
        {
            this.Id = -1;
            this.Name = "";
            this.CategoryId = -1;

            _Mode = enMode.addNew;
        }

        private Product(int id, string name, short quantity, int categoryId)
        {
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;
            this.CategoryId = categoryId;

            _Mode = enMode.update;
        }

        public static Product find(int id)
        {
            string name = ""; int categoryId = -1; short quantity = 0;

            if (ProductData.getProductDataByID(id, ref name, ref quantity, ref categoryId))
                return new Product(id, name, quantity, categoryId);
            else
                return null;
        }

        public static Product find(string name)
        {
            int id = -1, categoryId = -1; short quantity = 0;

            if (ProductData.getProductDataByName(ref id, name, ref quantity, ref categoryId))
                return new Product(id, name, quantity, categoryId);
            else
                return null;
        }

        public int add(Product product) => this.Id = ProductData.add(this.Name, this.Quantity, this.CategoryId);
        public DataTable get() => ProductData.get();
        
        public bool update(Product product) => ProductData.update(this.Id, this.Name, this.Quantity, this.CategoryId);
        public bool delete(int id) => ProductData.delete(id);
    }
}
