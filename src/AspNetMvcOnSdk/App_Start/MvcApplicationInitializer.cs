using System.Web.UI;

namespace AspNetMvcOnSdk
{
    /// <remarks>
    /// This initializer method is registered inside the "AssemblyInfo.cs" file.
    /// </remarks>
    public static class MvcApplicationInitializer
    {
        public static void PreApplicationStart() => PageParser.DefaultApplicationBaseType = typeof(MvcApplication);
    }
}