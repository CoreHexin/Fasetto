using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Fasetto.Models;

namespace Fasetto.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    public TextEntryViewModel? Name { get; set; }
    public TextEntryViewModel? Username  { get; set; }
    public PasswordEntryViewModel? Password { get; set; }
    public TextEntryViewModel? Email { get; set; }

    public SettingsViewModel()
    {
        // todo 测试阶段使用
        Name = new TextEntryViewModel("昵称", "用户昵称" + DateTime.Now);
        Username = new TextEntryViewModel("用户名", "用户名");
        Password = new PasswordEntryViewModel();
        Email = new TextEntryViewModel("邮件", "hexin@qq.com");
    }

    [RelayCommand]
    public void GoBack()
    {
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<SettingsMessage>(new SettingsMessage(false)));
    }

    [RelayCommand]
    public void Logout()
    {
        // todo 弹出确认是否退出对话框

        // 清除当前用户数据
        ClearUserInfo();

        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<ApplicationPage>(ApplicationPage.Login));
    }

    private void ClearUserInfo()
    {
        Name = null;
        Username = null;
        Email = null;
        Password = null;
    }
}
