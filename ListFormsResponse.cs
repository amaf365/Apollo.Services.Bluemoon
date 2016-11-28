using System;

namespace Apollo.Services.Bluemoon
{
    public class ListFormsResponse
    {
        public ListFormsResult[] ListFormsResult { get; set; }
    }

    public class ListFormsResult
    {
        public Item[] Item{ get; set; }
    }

    public class Item
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public int Copies { get; set; }
   
        public Cost[] Cost { get; set; }

        public string PageSize { get; set; }

        public string Language { get; set; }
    }

    public class Cost
    {
        public double Value { get; set; }
    }
}
