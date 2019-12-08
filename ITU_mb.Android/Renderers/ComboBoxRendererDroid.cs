using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ITU_mb;
using ITU_mb.Skripty;
using ITU_mb.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using ITU_mb.Droid.Renderers;
using Android.Content.Res;
using Android.Graphics;
using PickerRenderer = Xamarin.Forms.Platform.Android.AppCompat.PickerRenderer;
using Color = Android.Graphics.Color;

[assembly: ExportRenderer(typeof(ComboBox), typeof(ComboBoxRendererDroid))]
namespace ITU_mb.Droid.Renderers
{

    public class ComboBoxRendererDroid : PickerRenderer
    {

        public ComboBoxRendererDroid(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                
                Control.Gravity = GravityFlags.CenterHorizontal;
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                    Control.BackgroundTintList = ColorStateList.ValueOf(Color.Black);
                else
                    Control.Background.SetColorFilter(Color.Black, PorterDuff.Mode.SrcAtop);
            }
        }
    }
}