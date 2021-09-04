#region Namespaces

using GUIDX.Enums;

#endregion

namespace GUIDX
{
    public class GUIDGenerationOptions
    {
        public GUIDFormat Format = GUIDFormat.Alphanumeric;
        public bool Prefix = false;
        public string PrefixText = string.Empty;
        public bool Suffix = false;
        public string SuffixText = string.Empty;
        public bool UpperCase = false;
    }
}