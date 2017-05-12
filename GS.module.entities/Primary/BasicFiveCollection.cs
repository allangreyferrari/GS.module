namespace GS.module.entities.Primary
{
    using Base;
    using Internal;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicFiveCollection
    {
        public int NroColumns { get; set; }
        public List<Column> Columns { get; set; }
        public int NroRows { get; set; }
        public List<BasicFive> Rows { get; set; }
        public Transaction Transaction { get; set; }

        public BasicFiveCollection()
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = 0;
            Rows = new List<BasicFive>();
        }

        public BasicFiveCollection(List<BasicFive> ocol, Transaction transaction)
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = ocol.Count();
            Rows = ocol;
            Transaction = transaction;
        }

        public BasicFiveCollection(Transaction transaction)
        {
            NroRows = 0;
            Rows = new List<BasicFive>();
            Transaction = transaction;
        }
        ~BasicFiveCollection() { }
    }
}
