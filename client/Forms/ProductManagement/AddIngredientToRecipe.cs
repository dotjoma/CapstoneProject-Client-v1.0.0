using client.Forms.InventoryManagement;
using client.Forms.POS.POSUserControl.ProductFoodCategory;
using client.Helpers;
using client.Models;
using client.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Forms.ProductManagement
{
    public partial class AddIngredientToRecipe : Form
    {
        private System.Threading.Timer? _searchTimer;
        private string _lastSearchText = string.Empty;
        private Form _parentForm;

        public AddIngredientToRecipe(Form parentForm)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            _parentForm = parentForm;
        }

        private void AddIngredientToRecipe_Load(object sender, EventArgs e)
        {
            GetInventoryItems();
            LoadRecipes();
            GetInventoryUnitMeasure();
        }

        private void LoadRecipes()
        {
            dgvIngredients.Rows.Clear();

            if (RecipeBuilder.SelectedIngredients.Count == 0)
            {
                //MessageBox.Show("No saved recipe ingredients found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Logger.Write("ITEMS_WARNING", "No saved recipe ingredients found.");
                return;
            }

            foreach (var entry in RecipeBuilder.SelectedIngredients)
            {
                var item = entry.Value.item;
                var measure = entry.Value.measureSymbol;
                var quantity = entry.Value.quantity;

                dgvIngredients.Rows.Add(
                    item.ItemName,
                    measure,
                    quantity,
                    Properties.Resources.trash_red_20
                );
            }

            dgvIngredients.ClearSelection();
        }

        public void GetInventoryItems()
        {
            cboIngredient.Items.Clear();

            cboIngredient.Items.Add("– Select ingredient –");

            var items = CurrentInventoryItem.AllItems;

            if (items != null && items.Count > 0)
            {
                foreach (var ut in items)
                {
                    if (!string.IsNullOrEmpty(ut.ItemName))
                    {
                        cboIngredient.Items.Add(ut.ItemName);
                    }
                    else
                    {
                        Logger.Write("ITEMS_WARNING", "Item name is null or empty, skipping.");
                    }
                }

                cboIngredient.SelectedIndex = 0;
            }
            else
            {
                Logger.Write("ITEMS_WARNING", "No items found.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RecipeBuilder.SelectedIngredients.Clear();
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (RecipeBuilder.SelectedIngredients.Count == 0)
            {
                MessageBox.Show("No ingredients added.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string recipeSummary = "Recipe Saved:\n\n";

            foreach (var entry in RecipeBuilder.SelectedIngredients)
            {
                var item = entry.Value.item;
                var quantity = entry.Value.quantity;
                recipeSummary += $"- {item.ItemName} (ID: {item.ItemId}) x{quantity}\n";
            }

            if (_parentForm is AddProduct addprodfrm)
            {
                addprodfrm.DisplayIngredientsSummary();
            }

            this.Dispose();

            //MessageBox.Show(recipeSummary, "Recipe Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SetSelectedIngredient(string? itemName)
        {
            if (!string.IsNullOrEmpty(itemName))
            {
                cboIngredient.SelectedItem = itemName;
            }
        }

        private void cboIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIngredient.SelectedIndex == 0)
            {
                CurrentInventoryItem.SetCurrentItem(null);
                return;
            }

            if (cboIngredient.SelectedIndex > 0 &&
                CurrentInventoryItem.AllItems != null &&
                (cboIngredient.SelectedIndex - 1) < CurrentInventoryItem.AllItems.Count)
            {
                try
                {
                    var selectedItem = CurrentInventoryItem.AllItems[cboIngredient.SelectedIndex - 1];

                    if (selectedItem != null && selectedItem.ItemId > 0)
                    {
                        CurrentInventoryItem.SetCurrentItem(selectedItem);
                    }
                    else
                    {
                        MessageBox.Show("Invalid item selected", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        cboIngredient.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting item: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cboIngredient.SelectedIndex = 0;
                }
            }
            else
            {
                cboIngredient.SelectedIndex = 0;
            }
        }

        private void cboIngredient_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void AddIngredientToRecipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            _searchTimer?.Dispose();
        }

        private void btnSearchIngredient_Click(object sender, EventArgs e)
        {
            using (var searchIngredients = new SearchIngredients(this))
            {
                this.Hide();
                searchIngredients.StartPosition = FormStartPosition.Manual;
                searchIngredients.StartPosition = FormStartPosition.CenterParent;
                searchIngredients.ShowDialog(this);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CurrentInventoryItem.Current == null)
            {
                MessageBox.Show("Please select an ingredient first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtQuantity.Text) || !decimal.TryParse(txtQuantity.Text, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboMeasure.SelectedIndex == 0 || cboMeasure.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an measurement first.",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = CurrentInventoryItem.Current;

            var selectedUnit = CurrentInventoryUnitMeasure.Current;
            string selectedUnitSymbol = selectedUnit?.measureSymbol ?? "Unknown";

            if (RecipeBuilder.SelectedIngredients.TryGetValue(item.ItemId, out var existing))
            {
                RecipeBuilder.SelectedIngredients[item.ItemId] = (item, existing.quantity + quantity, selectedUnitSymbol);
            }
            else
            {
                RecipeBuilder.SelectedIngredients[item.ItemId] = (item, quantity, selectedUnitSymbol);
            }

            dgvIngredients.Rows.Clear();

            foreach (var entry in RecipeBuilder.SelectedIngredients)
            {
                var i = entry.Value.item;
                var m = entry.Value.measureSymbol;
                var q = entry.Value.quantity;

                dgvIngredients.Rows.Add(
                    i.ItemName,
                    m,
                    q,
                    Properties.Resources.trash_red_20
                );
            }

            dgvIngredients.ClearSelection();

            ResetForm();
        }

        private void ResetForm()
        {
            cboIngredient.SelectedIndex = 0;
            txtQuantity.Text = string.Empty;
        }

        private void dgvIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvIngredients.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                dgvIngredients.ClearSelection();

                var row = dgvIngredients.Rows[e.RowIndex];
                string? ingredientName = row.Cells["ingredient"].Value?.ToString();
                string? quantityText = row.Cells["quantity"].Value?.ToString();

                if (decimal.TryParse(quantityText, out decimal quantity))
                {
                    var entryToRemove = RecipeBuilder.SelectedIngredients
                        .FirstOrDefault(kvp => kvp.Value.item.ItemName == ingredientName && kvp.Value.quantity == quantity);

                    if (!entryToRemove.Equals(default(KeyValuePair<int, (InventoryItem item, decimal quantity)>)))
                    {
                        RecipeBuilder.SelectedIngredients.Remove(entryToRemove.Key);
                    }
                }

                dgvIngredients.Rows.RemoveAt(e.RowIndex);
            }
        }


        public void GetInventoryUnitMeasure()
        {
            cboMeasure.Items.Clear();
            cboMeasure.Items.Add("Select Measurement");

            var suppliers = CurrentInventoryUnitMeasure.AllUnitMeasures;

            if (suppliers != null && suppliers.Count > 0)
            {
                foreach (var sup in suppliers)
                {
                    if (!string.IsNullOrEmpty(sup.measureName))
                    {

                        if (!string.IsNullOrEmpty(sup.measureSymbol))
                        {
                            cboMeasure.Items.Add($"{sup.measureName} ({sup.measureSymbol})");
                        }
                        else
                        {
                            cboMeasure.Items.Add($"{sup.measureName}");
                        }
                    }
                    else
                    {
                        Logger.Write("MEASUREMENT_WARNING", "Measurement name is null or empty, skipping.");
                    }
                }
            }
            else
            {
                Logger.Write("MEASUREMENT_WARNING", "No measures found.");
            }

            cboMeasure.Items.Add("+ Add Measurement");
            cboMeasure.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMeasure.SelectedIndex == 0)
            {
                CurrentInventoryUnitMeasure.SetCurrentUnitMeasure(null);
                return;
            }

            if (cboMeasure.SelectedIndex == cboMeasure.Items.Count - 1)
            {
                using (var newunitfrm = new NewUnit(this))
                {
                    newunitfrm.StartPosition = FormStartPosition.Manual;
                    newunitfrm.StartPosition = FormStartPosition.CenterParent;
                    newunitfrm.ShowDialog(this);
                }

                return;
            }

            if (cboMeasure.SelectedIndex > 0 &&
                CurrentInventoryUnitMeasure.AllUnitMeasures != null &&
                (cboMeasure.SelectedIndex - 1) < CurrentInventoryUnitMeasure.AllUnitMeasures.Count)
            {
                try
                {
                    var selectedUnitMeasure = CurrentInventoryUnitMeasure.AllUnitMeasures[cboMeasure.SelectedIndex - 1];

                    if (selectedUnitMeasure != null && selectedUnitMeasure.Id > 0)
                    {
                        CurrentInventoryUnitMeasure.SetCurrentUnitMeasure(selectedUnitMeasure);
                    }
                    else
                    {
                        MessageBox.Show("Invalid unit measure selected", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        cboMeasure.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting unit measure: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cboMeasure.SelectedIndex = 0;
                }
            }
            else
            {
                cboMeasure.SelectedIndex = 0;
            }
        }
    }
}
