﻿#pragma checksum "C:\Users\Flaubert Le Khem\Documents\GitHub\UWP_Chat_audio_video\UWPVideoAudioCall\VideoReceiverClientApp\Views\VideoChat.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "772A1D50FCCA322B057B53298F3A1D23"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoReceiverClientApp
{
    partial class VideoChat : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\VideoChat.xaml line 12
                {
                    this.MainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\VideoChat.xaml line 28
                {
                    this.ImageVideo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // Views\VideoChat.xaml line 18
                {
                    this.StreamVideo = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.StreamVideo).Click += this.StreamVideo_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

