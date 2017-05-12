namespace GS.module.entities.Primary
{
    using Base;
    using Internal;
    using System.Collections.Generic;
    using System.Linq;
    public class StringHundredCollection
    {
        public int NroColumns { get; set; }
        public List<Column> Columns { get; set; }
        public int NroRows { get; set; }
        public List<StringHundred> Rows { get; set; }
        public Transaction Transaction { get; set; }

        public StringHundredCollection()
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = 0;
            Rows = new List<StringHundred>();
        }

        public StringHundredCollection(List<StringHundred> ocol, Transaction transaction)
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = ocol.Count();
            Rows = ocol;
            Transaction = transaction;
        }

        public StringHundredCollection(Transaction transaction)
        {
            NroRows = 0;
            Rows = new List<StringHundred>();
            Transaction = transaction;
        }

        ~StringHundredCollection() { }
    }
}
