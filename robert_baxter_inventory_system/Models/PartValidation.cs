namespace robert_baxter_inventory_system.Models
{
    public class PartValidation : Validation
    {
        public bool UniqueValueIsValid { get; set; }

        public override bool CanSave()
        {
            return UniqueValueIsValid && base.CanSave();
        }

    }
}
