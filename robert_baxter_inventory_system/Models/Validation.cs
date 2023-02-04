namespace robert_baxter_inventory_system.Models
{
    public class Validation
    {
        public bool NameIsValid { get; set; }
        public bool MaxIsValid { get; set; }
        public bool MinIsValid { get; set; }
        public bool InventoryIsValid { get; set; }
        public bool PriceIsValid { get; set; }
        
        public void SetFalse()
        {
            NameIsValid = false;
            MaxIsValid = false;
            MinIsValid = false;
            InventoryIsValid = false;
            PriceIsValid = false;
        }

        public virtual bool CanSave()
        {
            return
                NameIsValid &&
                PriceIsValid &&
                MaxIsValid &&
                MinIsValid &&
                InventoryIsValid;
        }
    }
}
