using robert_baxter_inventory_system.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace robert_baxter_inventory_system
{
    public partial class MainLayout : Form
    {
        private BindingSource _productsBindingSource;
        private BindingSource _partsBindingSource;

        private readonly Inventory _inventory;
        private Part _selectedPart;
        private Product _selectedProduct;
        private AddPart _addPartForm;

        public MainLayout()
        {
            InitializeComponent();

            // setting parts and products display to binding source
            // some additional setup for testing
            foreach(var product in Inventory.Products)
            {
                foreach(var part in Inventory.AllParts)
                {
                    product.AssociatedParts.Add(part);
                }
            }

            _partsBindingSource = new BindingSource { DataSource = Inventory.AllParts, };
            _productsBindingSource = new BindingSource { DataSource = Inventory.Products, };

            PartsDisplay.DataSource = _partsBindingSource;
            ProductsDisplay.DataSource = _productsBindingSource;

            _inventory = new Inventory();
            _addPartForm = new AddPart();
        }

        // lets not start with anything selected
        private void ClearPartsDisplayOnLoad(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PartsDisplay.ClearSelection();
        }

        private void ClearProductsDisplayOnLoad(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ProductsDisplay.ClearSelection();
        }

        private void AddPartClick(object sender, System.EventArgs e)
        {
            _addPartForm = new AddPart();
            _addPartForm.Show();

            Hide();
        }

        private void MainFormExitClick(object sender, System.EventArgs e)
        {
            Close();
        }

        private void PartSearchButtonClick(object sender, System.EventArgs e)
        {
            var searchValue = PartSearchTextField.Text;

            // when no value provided, show all
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                _partsBindingSource.DataSource = Inventory.AllParts;
            }
            // if integer value provided, lookup by id
            else if (int.TryParse(searchValue, out int intValue))
            {
                _partsBindingSource.DataSource = _inventory.LookupPart(intValue);
            }
            // otherwise search by name
            else
            {
                _partsBindingSource.DataSource = _inventory.SearchParts(searchValue);
            }
        }

        private void ModifyPartButtonClick(object sender, System.EventArgs e)
        {
            if (PartsDisplay.SelectedRows.Count > 0)
            {
                var rowIndex = PartsDisplay.CurrentCell.RowIndex;
                _selectedPart = Inventory.AllParts.ElementAt(rowIndex);

                _addPartForm = new AddPart(_selectedPart);
                _addPartForm.Show();

                Hide();
            }
            else
            {
                // no part selected - show notification dialog
                new BasicConfirmation("Please select a part to continue").Show();
            }
        }

        private void DeletePartButtonClick(object sender, EventArgs e)
        {
            if (PartsDisplay.SelectedRows.Count > 0)
            {
                var rowIndex = PartsDisplay.CurrentCell.RowIndex;
                _selectedPart = Inventory.AllParts.ElementAt(rowIndex);

                if(Inventory.Products.Any(p => p.AssociatedParts.Contains(_selectedPart)))
                {
                    new BasicConfirmation($"Cannot delete {_selectedPart.Name}, it is associated to a product").Show();
                }
                else
                {
                   new DeleteConfirm(nameof(Part).ToLower(), DeletePartAction).Show();
                }
            }
            else
            {
                // no part selected, show the dialog
                new BasicConfirmation("Please select a part to continue").Show();
            }
        }

        private bool DeletePartAction()
        {
            var part = _inventory.LookupPart(_selectedPart.PartId);
            return _inventory.DeletePart(part);
        }

        public override void Refresh()
        {
            PartsDisplay.DataSource = null;
            ProductsDisplay.DataSource = null;

            _partsBindingSource.DataSource = Inventory.AllParts;
            _productsBindingSource.DataSource = Inventory.Products;

            PartsDisplay.DataSource = _partsBindingSource;
            ProductsDisplay.DataSource = _productsBindingSource;

            PartsDisplay.Refresh();
            ProductsDisplay.Refresh();
        }

        private void AddProductButton_Click(object sender, System.EventArgs e)
        {
            Hide();
            new AddProductLayout().Show();
        }

        private void ModifyProductButton_Click(object sender, System.EventArgs e)
        {
            if (ProductsDisplay.SelectedRows.Count > 0)
            {
                var rowIndex = ProductsDisplay.CurrentCell.RowIndex;
                _selectedProduct = Inventory.Products.ElementAt(rowIndex);

                new AddProductLayout(_selectedProduct).Show();
            }
            else
            {
                // no product selected, show the dialog
                new BasicConfirmation("Please select a product to continue").Show();
            }
        }
    }
}
