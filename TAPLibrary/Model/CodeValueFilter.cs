using System.Collections.Generic;

namespace TAPLibrary.Model
{
    public class CodeValueFilter
    {
        public int CodeTypeId { get; set; }
        public List<CodeTypeFilterItem> CodeValues { get; set; }
    }
}
