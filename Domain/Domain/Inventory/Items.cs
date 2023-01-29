using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Inventory
{
    public class Items : BaseEntity
    {
        public string Code { get; set; }
        public string EngName { get; set; }
        public string ArbName { get; set; }
        public string Del_Category { get; set; }
        public string ArbName4Search { get; set; }
        public string ArbName4S { get; set; }
        public string Remarks { get; set; }
        public string ShortName { get; set; }
        public string GenericName { get; set; }
        public int ItemClassID { get; set; }
        public string Track { get; set; }
        public decimal QuantityDecimals { get; set; }
        public int ItemTypeID { get; set; }
        public int ValuationMethodID { get; set; }
        public int UnitID { get; set; }
        public bool AllowBackOrders { get; set; }
        public string AbcCode { get; set; }
        public int CompanyID { get; set; }
        public float CustomDutyFreeQty { get; set; }
        public int DeafultWasteUnitID { get; set; }
        public float DeafultWasteQty { get; set; }
        public float DeafultUnitSize { get; set; }
        public bool IssuePartialy { get; set; }
        public bool IsContinual { get; set; }
        public bool IsActive { get; set; }

    }
}
