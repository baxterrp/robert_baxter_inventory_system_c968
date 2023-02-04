using robert_baxter_inventory_system.Models.Interfaces;
using System.ComponentModel;
using System.Linq;

namespace robert_baxter_inventory_system.Models
{
    public class Product : IProduct
    {
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public Part LookupAssociatedPart(int partId) => AssociatedParts.FirstOrDefault(part => part.PartId == partId);

        public bool RemoveAssociatedParet(int partId)
        {
            var part = AssociatedParts.FirstOrDefault(p => p.PartId == partId);
            return AssociatedParts.Remove(part);
        }
    }
}
