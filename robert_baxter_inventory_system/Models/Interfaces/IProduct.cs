namespace robert_baxter_inventory_system.Models.Interfaces
{
    public interface IProduct
    {
        void AddAssociatedPart(Part part);
        bool RemoveAssociatedParet(int partId);
        Part LookupAssociatedPart(int partId);
    }
}
