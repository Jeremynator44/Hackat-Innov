﻿using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Migration
{
    public uint Id { get; set; }

    public string Migration1 { get; set; } = null!;

    public int Batch { get; set; }
}
