using robert_baxter_inventory_system.Models.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace robert_baxter_inventory_system.Models
{
    public class Inventory : IInventory
    {
        public static List<int> ProductIds { get; set; } = new List<int> { 1, 2 };
        public static List<int> PartIds { get; set; } = new List<int> { 1, 2, 3 };

        public static List<Product> Products { get; } = new List<Product>
        {
            new Product
            {
                ProductId = 1,
                InStock = 3,
                Max = 10,
                Min = 2,
                Name = "Chevy",
                Price = 10000m,
            },
            new Product
            {
                ProductId = 2,
                InStock = 5,
                Max = 10,
                Min = 5,
                Name = "Ford",
                Price = 9000m,
            },
        };

        public static List<Part> AllParts { get; set; } = new List<Part>
        {
            new InHouse
            {
                PartId = 1,
                InStock = 5,
                Max = 10,
                Min = 1,
                Name = "Tire",
                Price = 150m,
                MachineId = 1,
            },
            new InHouse
            {
                PartId = 2,
                InStock = 2,
                Max = 8,
                Min = 1,
                Name = "Break",
                Price = 50m,
                MachineId = 2,
            },
            new Outsourced
            {
                PartId = 3,
                InStock = 6,
                Max = 12,
                Min = 5,
                Name = "Head Light",
                Price = 80m,
                CompanyName = "Rob's Auto",
            },
        };

        public void AddPart(Part part)
        {
            part.PartId = PartIds.LastOrDefault() + 1;

            AllParts.Add(part);
            PartIds.Add(part.PartId);
        }

        public void AddProduct(Product product)
        {
            product.ProductId = ProductIds.LastOrDefault() + 1;

            Products.Add(product);
            ProductIds.Add(product.ProductId);
        }

        public bool DeletePart(Part part)
        {
            var response = AllParts.Remove(part);
            return response;
        }

        public Part LookupPart(int partId) => AllParts.FirstOrDefault(part => part.PartId == partId);

        public List<Part> SearchParts(string query) =>
            AllParts
                .Where(part => part.Name.ToLower().Contains(query.ToLower()))
                .ToList();

        public Product LookupProduct(int productId) => Products.FirstOrDefault(product => product.ProductId == productId);

        public List<Product> SearchProducts(string query) =>
            Products
                .Where(product => product.Name.ToLower().Contains(query.ToLower()))
                .ToList();

        public bool RemoveProduct(int productId)
        {
            var product = Products.FirstOrDefault(p => p.ProductId == productId);
            return Products.Remove(product);
        }

        public void UpdatePart(int partId, Part part)
        {
            var partToUpdate = AllParts.FirstOrDefault(p => p.PartId == partId);
            partToUpdate.Name = part.Name;
            partToUpdate.Price = part.Price;
            partToUpdate.Min = part.Min;
            partToUpdate.Max = part.Max;
            partToUpdate.InStock = part.InStock;
        }

        public void UpdateProduct(int productId, Product product)
        {
            var productToUpdate = Products.FirstOrDefault(p => p.ProductId == productId);
            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
            productToUpdate.Min = product.Min;
            productToUpdate.Max = product.Max;
            productToUpdate.InStock = product.InStock;
        }
    }
}
