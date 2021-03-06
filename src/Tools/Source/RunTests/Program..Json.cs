﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTests
{
    internal partial class Program
    {
        internal sealed class TestRunData
        {
            public string Cache { get; set; }
            public int ElapsedSeconds { get; set; }
            public bool Succeeded { get; set; }
            public bool IsJenkins { get; set; }
            public bool Is32Bit { get; set; }
            public int AssemblyCount { get; set; }
            public int CacheCount { get; set; }
            public int ChunkCount { get; set; }
        }
    }
}
