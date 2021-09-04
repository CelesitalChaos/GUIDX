using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GUIDX
{
    /// <summary>
    /// The <see cref="GUIDType"/> enum.
    /// </summary>
    public enum GUIDType
    {
        [DescriptionAttribute(Constants.GUID_EMPTY)]
        Alphanumeric = 0,
        
        [DescriptionAttribute(Constants.GUID_Letters)]
        Letters = 1,

        [DescriptionAttribute(Constants.GUID_Numeric)]
        Numeric = 2
    }
}
