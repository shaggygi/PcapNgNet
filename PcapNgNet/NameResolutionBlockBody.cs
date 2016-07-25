﻿using System.Collections.Generic;
using BinarySerialization;
using PcapNgNet.Options;

namespace PcapNgNet
{
    public class NameResolutionBlockBody : BlockBody
    {
        [FieldOrder(0)]
        [ItemSerializeUntil("Type", NameResolutionBlockRecordType.EndOfRecord)]
        public List<NameResolutionBlockRecord> Records { get; set; }

        [FieldOrder(1)]
        [FieldAlignment(4)]
        public OptionSection<OptionCode> Options { get; set; }
    }
}
