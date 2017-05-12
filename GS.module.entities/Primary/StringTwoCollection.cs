namespace GS.module.entities.Primary
{
    using Base;
    using Internal;
    using System.Collections.Generic;
    using System.Linq;
    public class StringTwoCollection
    {
        public int NroColumns { get; set; }
        public List<Column> Columns { get; set; }
        public int NroRows { get; set; }
        public List<StringTwo> Rows { get; set; }
        public Transaction Transaction { get; set; }

        public StringTwoCollection()
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = 0;
            Rows = new List<StringTwo>();
        }

        public StringTwoCollection(List<StringTwo> ocol, Transaction transaction)
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = ocol.Count();
            Rows = ocol;
            Transaction = transaction;
        }

        public StringTwoCollection(Transaction transaction)
        {
            NroRows = 0;
            Rows = new List<StringTwo>();
            Transaction = transaction;
        }

        ~StringTwoCollection() { }
    }
}
