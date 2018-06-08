﻿using System.Collections.Generic;
using SBCA_DataStandard.Enums;

namespace SBCA_DataStandard
{
    public class Component
    {
        public string Name { get; set; }

        public DistanceUnit DistanceUnit { get; set; }

        public AngleUnit AngleUnit { get; set; }

        public int NumberOfPlies { get; set; }

        public List<ComponentUsage> ComponentUsages { get; set; }

        public List<MaterialType> MaterialTypes { get; set; }

        public List<Member> Members { get; set; } = new List<Member>();

        public List<Lumber> Lumbers { get; set; } = new List<Lumber>();

        public List<SteelSection> SteelSections { get; set; } = new List<SteelSection>();

        public List<PlatePair> PlatePairs { get; set; } = new List<PlatePair>();

        public List<Hanger> Hangers { get; set; } = new List<Hanger>();

        public List<Bearing> Bearings { get; set; } = new List<Bearing>();
    }
}
