namespace GS.module.entities.Primary
{
    using Base;
    using Internal;
    using System.Collections.Generic;
    using System.Linq;
    public class BasicSeventyCollection
    {
        public int NroColumns { get; set; }
        public List<Column> Columns { get; set; }
        public int NroRows { get; set; }
        public List<BasicSeventy> Rows { get; set; }
        public Transaction Transaction { get; set; }

        public BasicSeventyCollection()
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = 0;
            Rows = new List<BasicSeventy>();
        }

        public BasicSeventyCollection(List<BasicSeventy> ocol, Transaction transaction)
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = ocol.Count();
            Rows = ocol;
            Transaction = transaction;
        }

        public BasicSeventyCollection(Transaction transaction)
        {
            NroRows = 0;
            Rows = new List<BasicSeventy>();
            Transaction = transaction;
        }
        ~BasicSeventyCollection() { }
    }
}
