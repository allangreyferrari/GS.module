namespace GS.module.entities.Primary
{
    using Base;
    using Internal;
    using System.Collections.Generic;
    using System.Linq;
    public class BasicTenCollection
    {
        public int NroColumns { get; set; }
        public List<Column> Columns { get; set; }
        public int NroRows { get; set; }
        public List<BasicTen> Rows { get; set; }
        public Transaction Transaction { get; set; }

        public BasicTenCollection()
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = 0;
            Rows = new List<BasicTen>();
        }

        public BasicTenCollection(List<BasicTen> ocol, Transaction transaction)
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = ocol.Count();
            Rows = ocol;
            Transaction = transaction;
        }

        public BasicTenCollection(Transaction transaction)
        {
            NroRows = 0;
            Rows = new List<BasicTen>();
            Transaction = transaction;
        }
        ~BasicTenCollection() { }
    }
}
