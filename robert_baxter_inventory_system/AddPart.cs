using robert_baxter_inventory_system.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace robert_baxter_inventory_system
{
    public partial class AddPart : Form
    {
        private bool _isEditMode;
        private readonly Inventory _inventory;

        public AddPart(Part part = null)
        {
            InitializeComponent();

            _inventory = new Inventory();
            _isEditMode = part != null;

            if (_isEditMode)
            {
                // set the fields as the selected Part
                PartId.Text = part.PartId.ToString();
                PartName.Text = part.Name;
                PartInventoryCount.Text = part.InStock.ToString();
                PartPrice.Text = part.Price.ToString();
                PartMin.Text = part.Min.ToString();
                PartMax.Text = part.Max.ToString();

                switch (part)
                {
                    case InHouse inHousePart:
                        InHouseRadioOption.Checked = true;
                        UniquePartValue.Text = inHousePart.MachineId.ToString();
                        break;
                    case Outsourced outSourcedPart:
                        OutsourcedRadioOption.Checked = true;
                        UniquePartValue.Text = outSourcedPart.CompanyName;
                        break;
                }
            }
        }

        private void AddPartExitClick(object sender, EventArgs e)
        {
            _isEditMode = false;

            Close();
            Program.ResetLayout();
        }

        private void SavePartClick(object sender, EventArgs e)
        {
            var min = int.Parse(PartMin.Text);
            var max = int.Parse(PartMax.Text);
            var instock = int.Parse(PartInventoryCount.Text);

            if (min > max)
            {
                new BasicConfirmation("Your minimum exceeds your maximum").Show();
            }
            else if (instock > max || instock < min)
            {
                new BasicConfirmation($"Inventory must be in the range Min:{min} and Max: {max}").Show();
            }
            else
            {
                if (_isEditMode)
                {
                    var id = int.Parse(PartId.Text);
                    var selectedPart = _inventory.LookupPart(id);

                    selectedPart.Name = PartName.Text;
                    selectedPart.InStock = int.Parse(PartInventoryCount.Text);
                    selectedPart.Max = int.Parse(PartMax.Text);
                    selectedPart.Min = int.Parse(PartMin.Text);
                    selectedPart.Price = decimal.Parse(PartPrice.Text);

                    switch (selectedPart)
                    {
                        case InHouse inHousePart:
                            inHousePart.MachineId = int.Parse(UniquePartValue.Text);
                            break;
                        case Outsourced outsourcedPart:
                            outsourcedPart.CompanyName = UniquePartValue.Text;
                            break;
                    }
                }
                else
                {
                    if (InHouseRadioOption.Checked)
                    {
                        var newInhousePart = new InHouse
                        {
                            Name = PartName.Text,
                            InStock = int.Parse(PartInventoryCount.Text),
                            MachineId = int.Parse(UniquePartValue.Text),
                            Max = int.Parse(PartMin.Text),
                            Min = int.Parse(PartMax.Text),
                            Price = decimal.Parse(PartPrice.Text),
                        };

                        _inventory.AddPart(newInhousePart);
                    }
                    else if (OutsourcedRadioOption.Checked)
                    {
                        var newOutsourcedPart = new Outsourced
                        {
                            Name = PartName.Text,
                            InStock = int.Parse(PartInventoryCount.Text),
                            CompanyName = UniquePartValue.Text,
                            Max = int.Parse(PartMin.Text),
                            Min = int.Parse(PartMax.Text),
                            Price = decimal.Parse(PartPrice.Text),
                        };

                        _inventory.AddPart(newOutsourcedPart);
                    }
                }

                _isEditMode = false;
                Close();
                Program.ResetLayout();
            }
        }

        private void InHouseRadioOptionCheckedChanged(object sender, EventArgs e)
        {
            if (InHouseRadioOption.Checked)
            {
                UniquePartDescripter.Text = "Machine ID";
                UniquePartValue.BackColor = !int.TryParse(UniquePartValue.Text, out int _) ? Color.Salmon : Color.White;
            }
        }

        private void OutsourcedRadioOptionCheckedChanged(object sender, EventArgs e)
        {
            if (OutsourcedRadioOption.Checked)
            {
                UniquePartDescripter.Text = "Company Name";
                UniquePartValue.BackColor = string.IsNullOrWhiteSpace(UniquePartValue.Text) ? Color.Salmon : Color.White;
            }
        }

        private void PartName_TextChanged(object sender, EventArgs e)
        {
            PartName.BackColor = string.IsNullOrWhiteSpace(PartName.Text) ? Color.Salmon : Color.White;
        }

        private void PartInventoryCount_TextChanged(object sender, EventArgs e)
        {
            PartInventoryCount.BackColor = !int.TryParse(PartInventoryCount.Text, out int _) ? Color.Salmon : Color.White;
        }

        private void PartPrice_TextChanged(object sender, EventArgs e)
        {
            PartPrice.BackColor = !decimal.TryParse(PartPrice.Text, out decimal _) ? Color.Salmon : Color.White;
        }

        private void PartMax_TextChanged(object sender, EventArgs e)
        {
            PartMax.BackColor = !int.TryParse(PartMax.Text, out int _) ? Color.Salmon : Color.White;
        }

        private void PartMin_TextChanged(object sender, EventArgs e)
        {
            PartMin.BackColor = !int.TryParse(PartMin.Text, out int _) ? Color.Salmon : Color.White;
        }

        private void UniquePartValue_TextChanged(object sender, EventArgs e)
        {
            if (InHouseRadioOption.Checked)
            {
                UniquePartValue.BackColor = !int.TryParse(UniquePartValue.Text, out int _) ? Color.Salmon : Color.White;
            }
            else if (OutsourcedRadioOption.Checked)
            {
                UniquePartValue.BackColor = string.IsNullOrWhiteSpace(UniquePartValue.Text) ? Color.Salmon : Color.White;
            }
        }
    }
}
