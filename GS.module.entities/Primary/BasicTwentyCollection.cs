namespace GS.module.entities.Primary
{
    using Base;
    using Internal;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicTwentyCollection
    {
        public int NroColumns { get; set; }
        public List<Column> Columns { get; set; }
        public int NroRows { get; set; }
        public List<BasicTwenty> Rows { get; set; }
        public Transaction Transaction { get; set; }

        public BasicTwentyCollection()
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = 0;
            Rows = new List<BasicTwenty>();
        }

        public BasicTwentyCollection(List<BasicTwenty> ocol, Transaction transaction)
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = ocol.Count();
            Rows = ocol;
            Transaction = transaction;
        }

        public BasicTwentyCollection(Transaction transaction)
        {
            NroRows = 0;
            Rows = new List<BasicTwenty>();
            Transaction = transaction;
        }
        ~BasicTwentyCollection() { }
    }
}
