using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace RevisedPartsEntry
{
    public class Part
    {
        /// <summary>
        /// No Paramater Constructor
        /// </summary>
        public Part()
        {
            throw new System.NotImplementedException();
        }

        /// <param name="DailyUsage">Daily Usage</param>
        /// <param name="LeadTimeInDays">Lead Time In Days</param>
        /// <param name="PartDescription">Part Description</param>
        /// <param name="PartItemClass">Part Item Class</param>
        /// <param name="PartNumber">Part Number</param>
        /// <param name="ReorderPoint">Reorder Point</param>
        /// <param name="TotalInventoryCost">Total Inventory</param>
        /// <param name="UnitPrice">Unit Price</param>
        /// <param name="UnitsOnHand">Units On Hand</param>
        public Part(int dailyUsage, int leadTimeInDays, int partDescription, int partItemClass, int partNumber, int reorderPoint, int totalInventoryCost, int UnitPrice, int UnitsOnHand)
        {
            DailyUsage = dailyUsage;
            LeadTimeInDays = leadTimeInDays;
            PartDescription = partDescription;
            PartItemClass = partItemClass;
            PartNumber = partNumber;
            ReorderPoint = reorderPoint;
            TotalInventoryCost = totalInventoryCost;
        }

        /// <summary>
        /// Daily Usage property
        /// </summary>
        [DisplayName("Daily Usage")]
        public int DailyUsage { get; set; }

        /// <summary>
        /// Lead Time In Days property
        /// </summary>
        [DisplayName("Lead Time In Days")]
        public int LeadTimeInDays { get; set; }

        /// <summary>
        ///Part Description property
        /// </summary>
        [DisplayName("Part Description")]
        public int PartDescription { get; set; }

        /// <summary>
        /// Part Item Class property
        /// </summary>
        [DisplayName("Part Item Class")]
        public int PartItemClass { get; set; }

        /// <summary>
        /// part Number property
        /// </summary>
        [DisplayName("Part Number")]
        public int PartNumber { get; set; }

        /// <summary>
        /// Reorder Point property
        /// </summary>
        [DisplayName("Reorder Point")]
        public int  ReorderPoint { get; set; }

        /// <summary>
        /// Inventory cost property
        /// </summary>
        [DisplayName("Total Inventory cost")]
        public int TotalInventoryCost { get; set; }

        /// <summary>
        /// Unit Price Property
        /// </summary>
      
        [DisplayName("Unit Price")]
        public int UnitPrice { get; set; }

        /// <summary>
        /// Units On Hand property
        /// </summary>
        [DisplayName("Units On Hand")]
        public int UnitsOnHand{ get; set; }

       
        /// <summary>
        /// TO STRING
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"Daily Usage = {DailyUsage}\n");
            sb.AppendLine($"Lead Time In Days = {LeadTimeInDays}");
            sb.AppendLine($"Part Description = {PartDescription}");
            sb.AppendLine($"Part Item Class = {PartItemClass}");
            sb.AppendLine($"Part Number = {PartNumber}");
            sb.AppendLine($"Unit Price = {UnitPrice}");
            sb.AppendLine($"Units On Hand = {UnitsOnHand}");

            return sb.ToString();
        }
    }
}