namespace GS.module.entities.Primary
{
    using Base;
    using Internal;
    using System.Collections.Generic;
    using System.Linq;
    public class StringTenCollection
    {
        public int NroColumns { get; set; }
        public List<Column> Columns { get; set; }
        public int NroRows { get; set; }
        public List<StringTen> Rows { get; set; }
        public Transaction Transaction { get; set; }

        public StringTenCollection()
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = 0;
            Rows = new List<StringTen>();
        }

        public StringTenCollection(List<StringTen> ocol, Transaction transaction)
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = ocol.Count();
            Rows = ocol;
            Transaction = transaction;
        }

        public StringTenCollection(Transaction transaction)
        {
            NroRows = 0;
            Rows = new List<StringTen>();
            Transaction = transaction;
        }

        ~StringTenCollection() { }
    }
}
