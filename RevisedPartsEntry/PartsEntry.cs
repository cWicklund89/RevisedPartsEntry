using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisedPartsEntry
{
    public partial class PartsEntry : Form
    {
      

        public PartsEntry()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Validates entries adds part to the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Part Number = {partNumberTextBox.Text}");
                sb.AppendLine($"Part Description = {partDescriptionTextBox.Text}");
                sb.AppendLine($"Item Class = {itemClassTextBox.Text}");
                sb.AppendLine($"Units On Hand = {unitsOnHandTextBox.Text}");
                sb.AppendLine($"Unit Price = {unitPriceTextBox.Text:C}");
                sb.AppendLine($"Total Cost = {totalInventoryCostTextBox.Text:C}");
                sb.AppendLine($"Lead Time = {leadTimeTextBox.Text}");
                sb.AppendLine($"Daily Usage = {dailyUsageTextBox.Text}");
                sb.AppendLine($"Reorder Point = {reorderPointTextBox.Text}");
                MessageBox.Show(sb.ToString());
            }
            else
            {
                MessageBox.Show("Please correct entry errors.", "Entry Errors",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Clears the Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            partNumberTextBox.Clear();
            partDescriptionTextBox.Clear();
            itemClassTextBox.Clear();
            unitsOnHandTextBox.Clear();
            unitPriceTextBox.Clear();
            totalInventoryCostTextBox.Clear();
            leadTimeTextBox.Clear();
            dailyUsageTextBox.Clear();
            reorderPointTextBox.Clear();
            partNumberTextBox.Focus();
        }

        /// <summary>
        /// Close the Parts Entry Application Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Validates the Part Number Entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (partNumberTextBox.Text.Length == 0)
            {
                errorProvider.SetError(partNumberTextBox, "Part Number is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(partNumberTextBox, "");
                e.Cancel = false;
            }
        }

        /// <summary>
        /// Validates the Part Description Entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partDescriptionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (partDescriptionTextBox.Text.Length == 0)
            {
                errorProvider.SetError(partDescriptionTextBox, "Part Description is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(partDescriptionTextBox, "");
                e.Cancel = false;
            }

        }

        /// <summary>
        /// Validates the Item Class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemClassTextBox_Validating(object sender, CancelEventArgs e)
        {
            string itemClass = itemClassTextBox.Text;
            if (itemClass.Length == -1)
            {
                errorProvider.SetError(itemClassTextBox, "Item Class is required.");
                e.Cancel = true;
            }
            else if (!(itemClass == "AP" || itemClass == "HW" || itemClass == "SG"))
            {
                errorProvider.SetError(itemClassTextBox, "Invalid Item Class.  Valid values (AP, HW, SG)");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(itemClassTextBox, "");
                e.Cancel = false;
            }
        }

        /// <summary>
        /// Validates the Units on Hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unitsOnHandTextBox_Validating(object sender, CancelEventArgs e)
        {
            double unitPrice;
            double unitsOnHand;
            if (validateNumericTextBoxes<double>(unitsOnHandTextBox, "Units On Hand", out unitsOnHand, e))
            {
                if (double.TryParse(unitPriceTextBox.Text, out unitPrice))
                    this.totalInventoryCostTextBox.Text = (unitPrice * unitsOnHand).ToString("C");
            }
        }

        /// <summary>
        /// Validates the Unit Price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unitPriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            double unitPrice;
            double unitsOnHand;
            if (validateNumericTextBoxes<double>(unitPriceTextBox, "Unit Price", out unitPrice, e))
            {
                if (double.TryParse(unitsOnHandTextBox.Text, out unitsOnHand))
                    this.totalInventoryCostTextBox.Text = (unitPrice * unitsOnHand).ToString("C");
            }
        }

        /// <summary>
        /// Validates the Lead Time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leadTimeTextBox_Validating(object sender, CancelEventArgs e)
        {
            int leadTimeInDays = 0;
            int dailyUsage = 0;
            if (validateNumericTextBoxes<int>(leadTimeTextBox, "Lead Time in Days", out leadTimeInDays, e))
            {
                if (int.TryParse(dailyUsageTextBox.Text, out dailyUsage))
                    this.reorderPointTextBox.Text = Convert.ToString(leadTimeInDays * dailyUsage);
            }
        }

        /// <summary>
        /// Validates the Daily Usage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dailyUsageTextBox_Validating(object sender, CancelEventArgs e)
        {
            int dailyUsage = 0;
            int leadTimeInDays = 0;
            if (validateNumericTextBoxes(dailyUsageTextBox, "Daily Usage", out dailyUsage, e))
            {
                if (int.TryParse(leadTimeTextBox.Text, out leadTimeInDays))
                    this.reorderPointTextBox.Text = Convert.ToString(dailyUsage * leadTimeInDays);
            }
        }

        /// <summary>
        /// Validates a Numeric Text Box
        /// </summary>
        /// <param name="textBox">TextBox Control to validate</param>
        /// <param name="fieldIdentifier">Field Identifier for use in formulating error messages</param>
        /// <param name="outValue">Converted Decimal Value</param>
        /// <param name="e"></param>
        /// <returns>Boolean indicating whether a validation error occurred.</returns>
        private bool validateNumericTextBoxes<T>(TextBox textBox, string fieldIdentifier, out T outValue, CancelEventArgs e)
        {

            string message;
            outValue = default;

            bool valid = Utility.ValidateIsNumeric<T>(textBox.Text, fieldIdentifier, out message, out outValue);
            errorProvider.SetError(textBox, message);
            e.Cancel = !valid;

            return valid;
        }

        /// <summary>
        /// Performs all Initialization Tasks When the Form is Loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PartsEntry_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }
    }
}
