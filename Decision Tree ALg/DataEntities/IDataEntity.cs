﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Tree_ALg.DataEntities
{
    interface IDataEntity
    {
        // Get Property by indexing it with string
        object this[string nameOfProperty] { get; set; }
        string ClassifiedResult { get; set; }

    }
}
