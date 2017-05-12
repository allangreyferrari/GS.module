
namespace GS.module.entities.Primary
{
    using Base;
    using Internal;
    using System.Collections.Generic;
    using System.Linq;
    public class StringSeventyCollection
    {
        public int NroColumns { get; set; }
        public List<Column> Columns { get; set; }
        public int NroRows { get; set; }
        public List<StringSeventy> Rows { get; set; }
        public Transaction Transaction { get; set; }

        public StringSeventyCollection()
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = 0;
            Rows = new List<StringSeventy>();
        }

        public StringSeventyCollection(List<StringSeventy> ocol, Transaction transaction)
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = ocol.Count();
            Rows = ocol;
            Transaction = transaction;
        }

        public StringSeventyCollection(Transaction transaction)
        {
            NroRows = 0;
            Rows = new List<StringSeventy>();
            Transaction = transaction;
        }

        ~StringSeventyCollection() { }
    }
}
