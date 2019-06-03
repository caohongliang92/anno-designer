﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;

namespace FandomParser.Core.Presets.Models
{
    [DebuggerDisplay("{" + nameof(Name) + "}")]
    [DataContract]
    public class WikiBuildingInfo
    {
        public WikiBuildingInfo()
        {
            ConstructionInfos = new List<ConstructionInfo>();
            MaintenanceInfos = new List<MaintenanceInfo>();
            Region = WorldRegion.Unknown;
            Type = BuildingType.Unknown;
        }

        [DataMember(Order = 0)]
        public string Name { get; set; }

        [DataMember(Order = 1)]
        public string Icon { get; set; }

        [DataMember(Order = 2)]
        public WorldRegion Region { get; set; }

        [DataMember(Order = 3)]
        public string Tier { get; set; }

        [DataMember(Order = 4)]
        public BuildingType Type { get; set; }

        [DataMember(Order = 5)]
        public Size BuildingSize { get; set; }

        [DataMember(Order = 6)]
        public string Radius { get; set; }

        [DataMember(Order = 7)]
        public Uri Url { get; set; }

        [DataMember(Order = 8)]
        public List<ConstructionInfo> ConstructionInfos { get; set; }

        [DataMember(Order = 9)]
        public List<MaintenanceInfo> MaintenanceInfos { get; set; }

        [DataMember(Order = 10)]
        public ProductionInfo ProductionInfos { get; set; }

        [DataMember(Order = 11)]
        public SupplyInfo SupplyInfos { get; set; }

        [DataMember(Order = 12)]
        public UnlockInfo UnlockInfos { get; set; }
    }
}
