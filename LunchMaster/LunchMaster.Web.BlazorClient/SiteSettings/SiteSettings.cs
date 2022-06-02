namespace LunchMaster.Web.BlazorClient.SiteSettings;

static public class SiteSettings
{
#if DEBUG
    public static bool IsDeveloperMode => true;
#else
    public static bool IsDeveloperMode => false;
#endif
}
