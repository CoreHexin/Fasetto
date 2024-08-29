using System.Runtime.InteropServices;
using System.Security;

namespace Fasetto.Helpers;

public static class SecureStringHelper
{
    /// <summary>
    /// 将SecureString转化为明文
    /// </summary>
    /// <param name="secureString"></param>
    /// <returns></returns>
    public static string GetPlainText(this SecureString secureString)
    {
        if (secureString == null)
            return string.Empty;

        var unmanagedString = IntPtr.Zero;

        try
        {
            unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
            return Marshal.PtrToStringUni(unmanagedString) ?? string.Empty;
        }
        finally
        {
            Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
        }
    }
}
