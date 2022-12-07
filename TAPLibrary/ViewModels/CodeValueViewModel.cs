namespace TAPLibrary.ViewModels
{
    public class CodeValueViewModel
    {
        public int Id { get; set; }
        public int CodeTypeId { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public string HL7Equivalent { get; set; }
        public string DefaultString { get; set; }
        public bool IsActive { get; set; }
    }
}
