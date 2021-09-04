using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GUIDX.Enums;

namespace GUIDX
{
    public class GUIDGenerationOptions
    {
        public GUIDFormat Format = GUIDFormat.Alphanumeric;
        public string PrefixText = string.Empty;
        public string SuffixText = string.Empty;
        public bool Prefix = false;
        public bool Suffix = false;
    }
}
