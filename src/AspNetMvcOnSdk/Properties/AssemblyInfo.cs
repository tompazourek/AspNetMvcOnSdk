using System.Web;
using AspNetMvcOnSdk;

[assembly: PreApplicationStartMethod(typeof(MvcApplicationInitializer), nameof(MvcApplicationInitializer.PreApplicationStart))]