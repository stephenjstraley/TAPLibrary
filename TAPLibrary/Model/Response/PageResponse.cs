using System.Collections.Generic;

namespace TAPLibrary.Model.Response
{
    public class PageResponse<T>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItemsCount { get; set; }
        public int TotalPagesCount { get; set; }
        public string Filter { get; set; }
        public string Search { get; set; }
        public List<T> Items { get; set; }
    }
}
