﻿using System.Collections.Generic;
using BinarySerialization;

namespace PcapNgNet.Options
{
    public class OptionSection<TCode>
    {
        [ItemSerializeUntil("Code", 0)]
        public List<Option<TCode>> Options { get; set; }
    }
}
