using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteClient
{
    public class Field
    {
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public bool HasSize { get; set; }
        public decimal Size { get; set; }
        public bool HasAccuracy { get; set; }
        public decimal Accuracy { get; set; }
        public bool PrimaryKey { get; set; }
        public bool ForeignKey { get; set; }
        public string ForeignTable { get; set; }
        public string ForeignField { get; set; }
        public bool Uniq { get; set; }
        public bool NotNull { get; set; }

        public Field()
        {

        }
    }
}
