using robert_baxter_inventory_system.Models;
using System;
using System.Windows.Forms;

namespace robert_baxter_inventory_system
{
    public partial class DeleteConfirm : Form
    {
        private readonly string _type;
        private readonly Inventory _inventory;
        private Func<bool> _deleteAction;

        public DeleteConfirm(string type, Func<bool> deleteAction)
        {
            InitializeComponent();

            _type = type;
            _inventory = new Inventory();
            DeleteConfirmationMessage.Text = $"Are you sure you want to delete this {type}?";
            _deleteAction = deleteAction;
        }

        private void CancelDeleteClick(object sender, EventArgs e)
        {
            Program.ResetLayout();
            Close();
        }

        private void ConfirmDeleteClick(object sender, EventArgs e)
        {
            _deleteAction();
            Program.ResetLayout();
            Close();
        }
    }
}
