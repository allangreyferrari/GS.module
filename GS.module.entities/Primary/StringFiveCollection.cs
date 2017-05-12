namespace GS.module.entities.Primary
{
    using Base;
    using Internal;
    using System.Collections.Generic;
    using System.Linq;
    public class StringFiveCollection
    {
        public int NroColumns { get; set; }
        public List<Column> Columns { get; set; }
        public int NroRows { get; set; }
        public List<StringFive> Rows { get; set; }
        public Transaction Transaction { get; set; }

        public StringFiveCollection()
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = 0;
            Rows = new List<StringFive>();
        }

        public StringFiveCollection(List<StringFive> ocol, Transaction transaction)
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = ocol.Count();
            Rows = ocol;
            Transaction = transaction;
        }

        public StringFiveCollection(Transaction transaction)
        {
            NroRows = 0;
            Rows = new List<StringFive>();
            Transaction = transaction;
        }
        ~StringFiveCollection() { }
    }
}
