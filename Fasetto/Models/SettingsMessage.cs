namespace Fasetto.Models;

public class SettingsMessage
{
    public bool IsShowSettingsMenu { get; set; }

    public SettingsMessage(bool isShowSettingsMenu)
    {
        IsShowSettingsMenu = isShowSettingsMenu;
    }
}
