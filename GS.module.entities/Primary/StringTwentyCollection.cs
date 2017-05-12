namespace GS.module.entities.Primary
{
    using Base;
    using Internal;
    using System.Collections.Generic;
    using System.Linq;
    public class StringTwentyCollection
    {
        public int NroColumns { get; set; }
        public List<Column> Columns { get; set; }
        public int NroRows { get; set; }
        public List<StringTwenty> Rows { get; set; }
        public Transaction Transaction { get; set; }

        public StringTwentyCollection()
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = 0;
            Rows = new List<StringTwenty>();
        }

        public StringTwentyCollection(List<StringTwenty> ocol, Transaction transaction)
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = ocol.Count();
            Rows = ocol;
            Transaction = transaction;
        }

        public StringTwentyCollection(Transaction transaction)
        {
            NroRows = 0;
            Rows = new List<StringTwenty>();
            Transaction = transaction;
        }
        ~StringTwentyCollection() { }
    }
}
