﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wyam.Common.Shortcodes;
using Wyam.Core.Util;

namespace Wyam.Core.Shortcodes
{
    internal class ShortcodeInstance
    {
        public ShortcodeInstance(int firstIndex, string name, string[] arguments, IShortcode shortcode)
        {
            FirstIndex = firstIndex;
            Name = name;
            Arguments = arguments;
            Shortcode = shortcode;
        }

        public void Finish(int lastIndex)
        {
            LastIndex = lastIndex;
        }

        public int FirstIndex { get; }
        public string Name { get; }
        public string[] Arguments { get; }
        public IShortcode Shortcode { get; }

        public string Content { get; set; } = string.Empty;

        public int LastIndex { get; private set; }
    }
}
