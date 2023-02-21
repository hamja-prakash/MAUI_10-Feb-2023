
#if ANDROID
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Android.Content.Res;
#endif

namespace MAUISampleDemo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
        {
#if __ANDROID__
            handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#endif
        });
        MainPage = new AppShell();
    }
}
