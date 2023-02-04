using robert_baxter_inventory_system.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace robert_baxter_inventory_system
{
    public partial class AddProductLayout : Form
    {
        private BindingSource _partsBindingSource;
        private BindingSource _partsAssociatedToProductBindingSource;

        private bool _isEditMode = false;
        private Product _selectedProduct;
        private Validation _productValidation = new Validation
        {
            NameIsValid = true,
            InventoryIsValid = true,
            MaxIsValid = true,
            MinIsValid = true,
            PriceIsValid = true,
        };

        private readonly Inventory _inventory;

        // storing temporarily added or deleted parts to restore state of associated parts upon cancellation
        private List<Part> _tempAddedParts = new List<Part>();
        private List<Part> _tempDeletedParts = new List<Part>();

        public AddProductLayout(Product product = null)
        {
            InitializeComponent();

            _inventory = new Inventory();
            _isEditMode = product != null;
            _selectedProduct = _isEditMode ? product : new Product();

            _partsBindingSource = new BindingSource { DataSource = Inventory.AllParts, };
            _partsAssociatedToProductBindingSource = new BindingSource { DataSource = _selectedProduct.AssociatedParts, };

            AllPartsDisplay.DataSource = _partsBindingSource;
            PartsAssociatedToProduct.DataSource = _partsAssociatedToProductBindingSource;

            if (_isEditMode)
            {
                ProductNameInput.Text = _selectedProduct.Name;
                ProductInventoryInput.Text = _selectedProduct.InStock.ToString();
                ProductMaxInput.Text = _selectedProduct.Max.ToString();
                ProductMinInput.Text = _selectedProduct.Min.ToString();
                ProductPriceInput.Text = _selectedProduct.Price.ToString();
            }
            else
            {
                _productValidation.SetFalse();
                SaveProductButton.Enabled = _productValidation.CanSave();
            }
        }

        private void AllPartsDisplay_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AllPartsDisplay.ClearSelection();
        }

        // restore state of parts depending on what is contained in temp lists
        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            foreach (var part in _tempAddedParts)
            {
                _selectedProduct.AssociatedParts.Remove(part);
            }

            foreach(var part in _tempDeletedParts)
            {
                _selectedProduct.AssociatedParts.Add(part);
            }

            _tempAddedParts.Clear();
            Close();
            Program.ResetLayout();
        }

        private void ProductNameInput_TextChanged(object sender, System.EventArgs e)
        {
            _productValidation.NameIsValid = !string.IsNullOrWhiteSpace(ProductNameInput.Text);
            ProductNameInput.BackColor = _productValidation.NameIsValid ? Color.White : Color.Salmon;
            SaveProductButton.Enabled = _productValidation.CanSave();
        }

        private void ProductInventoryInput_TextChanged(object sender, System.EventArgs e)
        {
            _productValidation.InventoryIsValid = int.TryParse(ProductInventoryInput.Text, out int _);
            ProductInventoryInput.BackColor = _productValidation.InventoryIsValid ? Color.White : Color.Salmon;
            SaveProductButton.Enabled = _productValidation.CanSave();
        }

        private void ProductPriceInput_TextChanged(object sender, System.EventArgs e)
        {
            _productValidation.PriceIsValid = decimal.TryParse(ProductPriceInput.Text, out decimal _);
            ProductPriceInput.BackColor = _productValidation.PriceIsValid ? Color.White : Color.Salmon;
            SaveProductButton.Enabled = _productValidation.CanSave();
        }

        private void ProductMaxInput_TextChanged(object sender, System.EventArgs e)
        {
            _productValidation.MaxIsValid = int.TryParse(ProductMaxInput.Text, out int _);
            ProductMaxInput.BackColor = _productValidation.MaxIsValid ? Color.White : Color.Salmon;
            SaveProductButton.Enabled = _productValidation.CanSave();
        }

        private void ProductMinInput_TextChanged(object sender, System.EventArgs e)
        {
            _productValidation.MinIsValid = int.TryParse(ProductMinInput.Text, out int _);
            ProductMinInput.BackColor = _productValidation.MinIsValid ? Color.White : Color.Salmon;
            SaveProductButton.Enabled = _productValidation.CanSave();
        }

        private void SaveProductButton_Click(object sender, System.EventArgs e)
        {
            _selectedProduct.Name = ProductNameInput.Text;
            _selectedProduct.Price = decimal.Parse(ProductPriceInput.Text);
            _selectedProduct.InStock = int.Parse(ProductInventoryInput.Text);
            _selectedProduct.Max = int.Parse(ProductMaxInput.Text);
            _selectedProduct.Min = int.Parse(ProductMinInput.Text);

            if (_selectedProduct.Max < _selectedProduct.Min)
            {
                new BasicConfirmation("Your minimum exceeds your maximum").Show();
            }
            else if (_selectedProduct.InStock < _selectedProduct.Min ||
                _selectedProduct.InStock > _selectedProduct.Max)
            {
                new BasicConfirmation($"Inventory must be in the range of Min: {_selectedProduct.Min} and Max: {_selectedProduct.Max}").Show();
            }
            else if (!_selectedProduct.AssociatedParts.Any())
            {
                new BasicConfirmation("You must have at least one associated part").Show();
            }
            else
            {
                if (_isEditMode)
                {
                    _inventory.UpdateProduct(_selectedProduct.ProductId, _selectedProduct);
                }
                else
                {
                    _inventory.AddProduct(_selectedProduct);
                }

                _tempAddedParts.Clear();
                _tempDeletedParts.Clear();
                Close();
                Program.ResetLayout();
            }
        }

        private void AddPartToProductButton_Click(object sender, System.EventArgs e)
        {
            if (AllPartsDisplay.SelectedCells.Count > 0)
            {
                var rowIndex = AllPartsDisplay.CurrentCell.RowIndex;
                var part = Inventory.AllParts.ElementAt(rowIndex);

                if (!_selectedProduct.AssociatedParts.Contains(part))
                {
                    _selectedProduct.AssociatedParts.Add(part);
                    _tempAddedParts.Add(part);
                    _tempDeletedParts.Remove(part);
                }
            }
        }

        private void DeleteAssociatedPartButton_Click(object sender, System.EventArgs e)
        {
            if (PartsAssociatedToProduct.SelectedCells.Count > 0)
            {
                new DeleteConfirm("associated part", DeleteAssociatedPartAction).Show();
            }
            else
            {
                new BasicConfirmation("Please select a part to continue");
            }
        }

        private bool DeleteAssociatedPartAction()
        {
            var rowIndex = PartsAssociatedToProduct.CurrentCell.RowIndex;
            var part = _selectedProduct.AssociatedParts.ElementAt(rowIndex);

            if (_tempAddedParts.Contains(part))
            {
                _tempAddedParts.Remove(part);
            }

            _tempDeletedParts.Add(part);
            return _selectedProduct.AssociatedParts.Remove(part);
        }
    }
}
