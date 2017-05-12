﻿namespace GS.module.entities.Primary
{
    using Base;
    using Internal;
    using System.Collections.Generic;
    using System.Linq;
    public class BasicFiftyCollection
    {
        public int NroColumns { get; set; }
        public List<Column> Columns { get; set; }
        public int NroRows { get; set; }
        public List<BasicFifty> Rows { get; set; }
        public Transaction Transaction { get; set; }

        public BasicFiftyCollection()
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = 0;
            Rows = new List<BasicFifty>();
        }

        public BasicFiftyCollection(List<BasicFifty> ocol, Transaction transaction)
        {
            NroColumns = 0;
            Columns = new List<Column>();
            NroRows = ocol.Count();
            Rows = ocol;
            Transaction = transaction;
        }

        public BasicFiftyCollection(Transaction transaction)
        {
            NroRows = 0;
            Rows = new List<BasicFifty>();
            Transaction = transaction;
        }
        ~BasicFiftyCollection() { }
    }
}
