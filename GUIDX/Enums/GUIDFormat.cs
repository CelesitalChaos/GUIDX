#region Namespaces

using System.ComponentModel;

#endregion

namespace GUIDX.Enums
{
    /// <summary>
    ///     The <see cref="GUIDFormat" /> enum.
    /// </summary>
    public enum GUIDFormat
    {
        [Description(Constants.GUID_EMPTY)] Alphanumeric = 0,

        [Description(Constants.GUID_Letters)] Letters = 1,

        [Description(Constants.GUID_Numeric)] Numeric = 2
    }
}