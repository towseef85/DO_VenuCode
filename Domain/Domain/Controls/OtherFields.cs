using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Controls
{
    public class OtherFields : BaseEntity
    {

        public int FormID { get; set; }

        public int? Width { get; set; }

        public int? Rank { get; set; }
        public bool IsHidden { get; set; }

        public string? EngName { get; set; }

        public string? ArbName { get; set; }

        public string? FieldType { get; set; }

        public int? DataType { get; set; }

        public short? DataLength { get; set; }

        public string? Remarks { get; set; }

        public bool  IsFilter { get; set; }
        public bool IsInList { get; set; }

        public DateTime? ModifyDate { get; set; }

        public virtual FormControls FormControls { get; set; }
    }
}
