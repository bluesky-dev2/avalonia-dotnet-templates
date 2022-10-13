﻿using Android.App;
using Android.Content.PM;
using Avalonia.Android;
using Avalonia;

namespace AvaloniaTest.Android
{
    [Activity(Label = "AvaloniaTest.Android", Theme = "@style/MyTheme.NoActionBar", Icon = "@drawable/icon", LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class MainActivity : AvaloniaMainActivity
    {
    }
}
