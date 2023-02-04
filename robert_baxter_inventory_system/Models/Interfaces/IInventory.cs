using System.Collections.Generic;

namespace robert_baxter_inventory_system.Models.Interfaces
{
    public interface IInventory
    {
        // product behavior
        void AddProduct(Product product);
        bool RemoveProduct(int productId);
        Product LookupProduct(int productId);
        void UpdateProduct(int productId, Product product);

        // part behavior
        void AddPart(Part part);
        bool DeletePart(Part part);
        Part LookupPart(int partId);
        List<Part> SearchParts(string query);
        void UpdatePart(int partId, Part part);
    }
}
