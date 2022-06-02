using MudBlazor;

namespace LunchMaster.Web.BlazorClient.Themes;

static public class SiteThemes
{
    static public MudTheme LightTheme => new MudTheme();  //defaluts to light theme.
    static public MudTheme DarkTheme => new MudTheme()
    {
        Palette = new Palette()
        {
            Black = "#27272f",
            Background = "#32333d",
            BackgroundGrey = "#27272f",
            Surface = "#373740",
            TextPrimary = "#ffffffb3",
            TextSecondary = "rgba(255,255,255, 0.50)",
            DrawerBackground = "#27272f",
            DrawerText = "#ffffffb3",
            DrawerIcon = "#ffffffb3"
        }
    };  //Dark Theme
}
