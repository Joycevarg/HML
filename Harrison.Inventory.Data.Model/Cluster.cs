﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Data.Model
{
    public class Cluster
    {
        public int CLUSTER_ID { get; set; }
        public string CLUSTER_NAME { get; set; }
        public int STATE_ID { get; set; }

        public Cluster(int Did, string Dname, int Sid)
        {
            this.CLUSTER_ID = Did;
            this.CLUSTER_NAME = Dname;
            this.STATE_ID = Sid;

        }
    }
}
