using CommunityToolkit.Maui;
using MAUISampleDemo.Helpers;
using MAUISampleDemo.PlatformImplementations;
using MAUISampleDemo.Resources.Language;
using MAUISampleDemo.View;
using MAUISampleDemo.View.Navigation;
using MAUISampleDemo.ViewModels;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Plugin.LocalNotification;
using SkiaSharp.Views.Maui.Controls.Hosting;
using ZXing.Net.Maui;

namespace MAUISampleDemo;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
            .UseLocalNotification()
            .UseBarcodeReader()
            .UseSkiaSharp()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("fa-brands-400.ttf", "FaBrands");
            })
           
            .ConfigureMauiHandlers(h =>
            {
                h.AddHandler(typeof(ZXing.Net.Maui.Controls.CameraBarcodeReaderView), typeof(CameraBarcodeReaderViewHandler));
                h.AddHandler(typeof(ZXing.Net.Maui.Controls.CameraView), typeof(CameraViewHandler));
                h.AddHandler(typeof(ZXing.Net.Maui.Controls.BarcodeGeneratorView), typeof(BarcodeGeneratorViewHandler));
            }).UseMauiCommunityToolkit();

        AppCenter.Start("windowsdesktop={Your Windows App secret here};" +
                "android=69cfd5df-6ce1-4659-bc88-040a96a5f695;" +
                "ios=dfe2d75d-8425-446e-8b1e-6f96ca6ca7cb;" +
                "macos={Your macOS App secret here};",
                typeof(Analytics), typeof(Crashes));

        builder.Services.AddSingleton<IConnectivity>((e) => Connectivity.Current);
        builder.Services.AddSingleton<IToast>((e) => new Toaster());
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddSingleton<NavPage1>();
        builder.Services.AddTransient<NavPage1ViewModel>();
        return builder.Build();
    }
}