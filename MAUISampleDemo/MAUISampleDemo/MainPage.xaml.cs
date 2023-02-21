using CommunityToolkit.Maui.Alerts;
using MAUISampleDemo.Model;
using MAUISampleDemo.Shared;
using MAUISampleDemo.View;
using MAUISampleDemo.View.CsharpMarkup;
using MAUISampleDemo.View.FieldModifier;
using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel mainPageViewModel)
    {
		InitializeComponent();
        CommonToolbar.LblToolbarTitle.Text = "Main Page";
        CommonToolbar.ImgToolbarBack.IsVisible = false;
        this.BindingContext = mainPageViewModel;
    }

    private async void FrmMVVMDemo_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmMVVMDemo.ScaleTo(0.9, 100, Easing.Linear);
            await FrmMVVMDemo.ScaleTo(1.0, 100, Easing.Linear);
            Navigation.PushAsync(new LoginPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmDeviceandAPPInfo_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmDevice_APPInfo.ScaleTo(0.9, 100, Easing.Linear);
            await FrmDevice_APPInfo.ScaleTo(1.0, 100, Easing.Linear);
            Navigation.PushAsync(new Device_APPInfoPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmFiledModifiers_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmFiledModifiers.ScaleTo(0.9, 100, Easing.Linear);
            await FrmFiledModifiers.ScaleTo(1.0, 100, Easing.Linear);
            Navigation.PushAsync(new FieldModifierMainPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmObservableProperty_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmObservableProperty.ScaleTo(0.9, 100, Easing.Linear);
            await FrmObservableProperty.ScaleTo(1.0, 100, Easing.Linear);
            Navigation.PushAsync(new ObservablePropertyDemoPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmScanner_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmScanner.ScaleTo(0.9, 100, Easing.Linear);
            await FrmScanner.ScaleTo(1.0, 100, Easing.Linear);
            Navigation.PushAsync(new BarcodeScanner());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmLocalization_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmLocalization.ScaleTo(0.9, 100, Easing.Linear);
            await FrmLocalization.ScaleTo(1.0, 100, Easing.Linear);
            Navigation.PushAsync(new LocalizationDemoPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmCardView_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmCardView.ScaleTo(0.9, 100, Easing.Linear);
            await FrmCardView.ScaleTo(1.0, 100, Easing.Linear);
            Navigation.PushAsync(new CardViewDemoPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmChangeStatusbarBG_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmChangeStatusBarBG.ScaleTo(0.9, 100, Easing.Linear);
            await FrmChangeStatusBarBG.ScaleTo(1.0, 100, Easing.Linear);
            Navigation.PushAsync(new ChangeStatusbarBGPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmFilePicker_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmFilePicker.ScaleTo(0.9, 100, Easing.Linear);
            await FrmFilePicker.ScaleTo(1.0, 100, Easing.Linear);
            Navigation.PushAsync(new FilePickerPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmCachedImage_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmCachedImage.ScaleTo(0.9, 100, Easing.Linear);
            await FrmCachedImage.ScaleTo(1.0, 100, Easing.Linear);
            Navigation.PushAsync(new CacheImagePage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmLocalNtf_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmLocalNtf.ScaleTo(0.9, 100, Easing.Linear);
            await FrmLocalNtf.ScaleTo(1.0, 100, Easing.Linear);
            Navigation.PushAsync(new LocalNotificationPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmMetroLog_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmMetroLog.ScaleTo(0.9, 100, Easing.Linear);
            await FrmMetroLog.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(new MetroLogDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmRefreshEmpty_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmRefreshEmpty.ScaleTo(0.9, 100, Easing.Linear);
            await FrmRefreshEmpty.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(new RefreshandEmpltyViewDemoPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmImagecolorchange_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmImagecolorchange.ScaleTo(0.9, 100, Easing.Linear);
            await FrmImagecolorchange.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(new ImagechangecolorDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmMAUIPagewithSharpMrkp_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmMAUIPagewithSharpMrkp.ScaleTo(0.9, 100, Easing.Linear);
            await FrmMAUIPagewithSharpMrkp.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(new CsharpMarkupMainPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmMVVMDatabinding_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmMVVMDatabinding.ScaleTo(0.9, 100, Easing.Linear);
            await FrmMVVMDatabinding.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(new MVVM_Databinding());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmLottieAnimation_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmLottieAnimation.ScaleTo(0.9, 100, Easing.Linear);
            await FrmLottieAnimation.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(new LottieAnimationDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmCustomCalender_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmCustomCalender.ScaleTo(0.9, 100, Easing.Linear);
            await FrmCustomCalender.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(new CustomCalender());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmAudio_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmAudio.ScaleTo(0.9, 100, Easing.Linear);
            await FrmAudio.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(new AudioDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmBarcodeGenerate_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmBarcodeGenerate.ScaleTo(0.9, 100, Easing.Linear);
            await FrmBarcodeGenerate.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(new BarcodeGenerateDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmCompileBinding_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmCompileBinding.ScaleTo(0.9, 100, Easing.Linear);
            await FrmCompileBinding.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(new ComplieBindingDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmImgUpload_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmImgUpload.ScaleTo(0.9, 100, Easing.Linear);
            await FrmImgUpload.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(new ImageUploadDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmCollectionviewGrouping_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmCollectionviewGrouping.ScaleTo(0.9, 100, Easing.Linear);
            await FrmCollectionviewGrouping.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(new CollectionViewGroupingDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void FrmCustomizeCntwithHndlr_Tapped(object sender, EventArgs e)
    {
        try
        {
            await FrmCustomizeCntwithHndlr.ScaleTo(0.9, 100, Easing.Linear);
            await FrmCustomizeCntwithHndlr.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(new CustomiseControlwithHandlerDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}

