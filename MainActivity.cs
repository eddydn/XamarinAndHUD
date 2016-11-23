using Android.App;
using Android.Widget;
using Android.OS;
using AndroidHUD;
using System;

namespace XamarinAndHUD
{
    [Activity(Label = "XamarinAndHUD", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            var btnShow = FindViewById<Button>(Resource.Id.btnShow);
            var btnShowToast = FindViewById<Button>(Resource.Id.btnShowToast);
            var btnShowError = FindViewById<Button>(Resource.Id.btnShowError);
            var btnShowErrorWithStatus = FindViewById<Button>(Resource.Id.btnShowErrorWithStatus);
            var btnShowImage = FindViewById<Button>(Resource.Id.btnShowImage);
            var btnShowSuccess = FindViewById<Button>(Resource.Id.btnShowSuccess);
            var btnShowSuccessWithStatus = FindViewById<Button>(Resource.Id.btnShowSuccessWithStatus);
            var btnShowWithEventHandler = FindViewById<Button>(Resource.Id.btnEventHandler);

            btnShow.Click += delegate
             {
                 AndHUD.Shared.Show(this, "Show Text", 100, MaskType.Black, TimeSpan.FromSeconds(2));
             };

            btnShowToast.Click += delegate {
                AndHUD.Shared.ShowToast(this, "Show Toast", MaskType.Black, TimeSpan.FromSeconds(2));
            };

            btnShowError.Click += delegate {
                AndHUD.Shared.ShowError(this, "Show Error", MaskType.Black, TimeSpan.FromSeconds(2));
            };

            btnShowErrorWithStatus.Click += delegate {
                AndHUD.Shared.ShowErrorWithStatus(this, "Show Error With Status", MaskType.Black, TimeSpan.FromSeconds(2));
            };

            btnShowSuccess.Click += delegate {
                AndHUD.Shared.ShowSuccess(this, "Show Successs", MaskType.Black, TimeSpan.FromSeconds(2));
            };

            btnShowSuccessWithStatus.Click += delegate {
                AndHUD.Shared.ShowSuccessWithStatus(this, "Show Successs With Status", MaskType.Black, TimeSpan.FromSeconds(2));
            };

            btnShowImage.Click += delegate{
                AndHUD.Shared.ShowImage(this, Resource.Drawable.Icon,null,MaskType.Black,TimeSpan.FromSeconds(2));
            };

            btnShowWithEventHandler.Click += delegate
            {
                AndHUD.Shared.ShowSuccess(this, "This is event handler", MaskType.Black, null, () =>
                 {
                     Toast.MakeText(this, "OK Click", ToastLength.Short).Show();
                 });
            };

        }
    }
}

