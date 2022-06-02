using MudBlazor;

namespace LunchMaster.Web.BlazorClient.SiteSettings;

static public class SiteSettings
{
#if DEBUG
    public static bool IsDeveloperMode => true;
#else
    public static bool IsDeveloperMode => false;
#endif
    public static bool DarkModeEnabled { get; set; } = false;

    public static string SelectedTheme { get; set; } = "";

    public static MudTheme currentTheme { get;set; }
}
