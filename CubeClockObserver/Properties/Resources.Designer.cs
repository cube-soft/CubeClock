﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.1008
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CubeClockObserver.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CubeClockObserver.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   http://cielquis.net/trash/ad-dummy.html に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string AdUrl {
            get {
                return ResourceManager.GetString("AdUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   yyyy/MM/dd hh:mm:ss.fff に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ClockFormat {
            get {
                return ResourceManager.GetString("ClockFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   CubeClock エラー に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorTitle {
            get {
                return ResourceManager.GetString("ErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   時間 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string HourUnit {
            get {
                return ResourceManager.GetString("HourUnit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   分 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string MinuteUnit {
            get {
                return ResourceManager.GetString("MinuteUnit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   秒 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string SecondUnit {
            get {
                return ResourceManager.GetString("SecondUnit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   サーバとの通信に失敗しました。
        ///サーバのホスト名、または IP アドレスを確認して下さい。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ServerFailed {
            get {
                return ResourceManager.GetString("ServerFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   時刻が{0}遅れています。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TimeBehindWarning {
            get {
                return ResourceManager.GetString("TimeBehindWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   時刻が{0}進んでいます。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TimeFastWarning {
            get {
                return ResourceManager.GetString("TimeFastWarning", resourceCulture);
            }
        }
    }
}
