﻿using System;
using System.Collections.Generic;

namespace SMOKYICESHOP_API_TEST.Entities
{
    public partial class Liquid : IHasGood
    {
        public Guid GoodId { get; set; }
        public Guid GroupId { get; set; }
        public Guid TasteMixId { get; set; }
        public byte Strength { get; set; }

        public virtual Good Good { get; set; } = null!;
        public virtual LiquidsGroup Group { get; set; } = null!;
        public virtual LiquidTasteMix TasteMix { get; set; } = null!;
    }
}
