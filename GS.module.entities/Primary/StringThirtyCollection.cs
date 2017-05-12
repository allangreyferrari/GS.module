namespace GS.module.entities.Primary
{
    using Base;
    using Internal;
    using System.Collections.Generic;
    using System.Linq;
    public class StringThirtyCollection
    {
        public int NroColumns { get; set; }
        public List<Column> Columns { get; set; }
        public int NroRows { get; set; }
        public List<StringThirty> Rows { get; set; }
        public Transaction Transaction { get; set; }

        public StringThirtyCollection()
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = 0;
            Rows = new List<StringThirty>();
        }

        public StringThirtyCollection(List<StringThirty> ocol, Transaction transaction)
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = ocol.Count();
            Rows = ocol;
            Transaction = transaction;
        }

        public StringThirtyCollection(Transaction transaction)
        {
            NroRows = 0;
            Rows = new List<StringThirty>();
            Transaction = transaction;
        }

        ~StringThirtyCollection() { }
    }
}
