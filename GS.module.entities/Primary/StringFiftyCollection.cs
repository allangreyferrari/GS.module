namespace GS.module.entities.Primary
{
    using Base;
    using Internal;
    using System.Collections.Generic;
    using System.Linq;
    public class StringFiftyCollection
    {
        public int NroColumns { get; set; }
        public List<Column> Columns { get; set; }
        public int NroRows { get; set; }
        public List<StringFifty> Rows { get; set; }
        public Transaction Transaction { get; set; }

        public StringFiftyCollection()
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = 0;
            Rows = new List<StringFifty>();
        }

        public StringFiftyCollection(List<StringFifty> ocol, Transaction transaction)
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = ocol.Count();
            Rows = ocol;
            Transaction = transaction;
        }

        public StringFiftyCollection(Transaction transaction)
        {
            NroRows = 0;
            Rows = new List<StringFifty>();
            Transaction = transaction;
        }
        ~StringFiftyCollection() { }
    }
}
