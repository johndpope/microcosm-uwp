﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microcosm.Models
{
    public class TreeViewItem2
    {
        public string Header { get; set; }
        public string Icon { get; set; }
        public string FileName { get; set; }
        public bool IsDir { get; set; }
        public string FullPath { get; set; }
        public bool NoFile { get; set; }
    }
}
