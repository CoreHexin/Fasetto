﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Fasetto.Models;

namespace Fasetto.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    public TextEntryViewModel Name { get; set; }
    public TextEntryViewModel Username  { get; set; }
    public TextEntryViewModel Password { get; set; }
    public TextEntryViewModel Email { get; set; }

    public SettingsViewModel()
    {
        Name = new TextEntryViewModel("昵称", "用户昵称");
        Username = new TextEntryViewModel("用户名", "用户名");
        Password = new TextEntryViewModel("密码", "******");
        Email = new TextEntryViewModel("邮件", "hexin@qq.com");
    }

    [RelayCommand]
    private void GoBack()
    {
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<SettingsMessage>(new SettingsMessage(false)));
    }
}
