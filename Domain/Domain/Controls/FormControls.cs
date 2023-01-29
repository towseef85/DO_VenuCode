using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Controls
{
    public class FormControls : BaseEntity
    {
        public int FormId { get; set; }
        public string ControlName { get; set; }
        public string FieldName { get; set; }
        public string? Icon { get; set; }
        public string ArbCaption { get; set; }
        public string? EngCaption { get; set; }
        public string? MaxLength { get; set; }
        public string? MinLength { get; set; }
        public string? MaxValue { get; set; }
        public string? MinValue { get; set; }
        public string? DataType { get; set; }
        public bool? IsHidden { get; set; }
        public string? DefaultValue { get; set; }
        public string? DefaultValueScalarFun { get; set; }
        public bool? Required { get; set; }
        public string? RegExpression { get; set; }
        public string ControlType { get; set; }
        public int? SearchId { get; set; }
        public string? AnotherCriteria { get; set; }
        public bool? Disabled { get; set; }
        public bool? IndexPage { get; set; }
        public int? Width { get; set; }
        public int? Section { get; set; }
        public bool? AutoGenerate { get; set; }
        public int? Rank { get; set; }
        public string? EngToolTip { get; set; }
        public string? ArbToolTip { get; set; }
        public ICollection<OtherFields> OtherFields { get; set; }


    }
}
