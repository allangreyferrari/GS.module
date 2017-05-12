namespace GS.module.entities.Primary
{
    using Base;
    using Internal;
    using System.Collections.Generic;
    using System.Linq;
    public class BasicHundredCollection
    {
        public int NroColumns { get; set; }
        public List<Column> Columns { get; set; }
        public int NroRows { get; set; }
        public List<BasicHundred> Rows { get; set; }
        public Transaction Transaction { get; set; }

        public BasicHundredCollection()
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = 0;
            Rows = new List<BasicHundred>();
        }

        public BasicHundredCollection(List<BasicHundred> ocol, Transaction transaction)
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = ocol.Count();
            Rows = ocol;
            Transaction = transaction;
        }

        public BasicHundredCollection(Transaction transaction)
        {
            NroRows = 0;
            Rows = new List<BasicHundred>();
            Transaction = transaction;
        }
        ~BasicHundredCollection() { }
    }
}
