﻿using UnityEngine;

namespace GorillaShirts.Models.Locations
{
    internal class Location_MonkeBlocks : Location_Base
    {
        public override GTZone[] Zones => [GTZone.monkeBlocks];
        public override Vector3 Position => new(-123.7533f, 16.8881f, -219.073f);
        public override Vector3 EulerAngles => Vector3.up * 209.9129f;
    }
}
