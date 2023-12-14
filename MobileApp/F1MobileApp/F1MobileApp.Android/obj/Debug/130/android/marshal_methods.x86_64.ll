; ModuleID = 'obj\Debug\130\android\marshal_methods.x86_64.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [348 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 100
	i64 30579257353033782, ; 1: Syncfusion.Buttons.XForms => 0x6ca3ac2c05d836 => 51
	i64 36418902923615093, ; 2: Plugin.LocalNotification => 0x8162cc9bdf1b75 => 46
	i64 98382396393917666, ; 3: Microsoft.Extensions.Primitives.dll => 0x15d8644ad360ce2 => 36
	i64 108510648730319720, ; 4: BottomBar.Droid => 0x18181dc2feafb68 => 10
	i64 120698629574877762, ; 5: Mono.Android => 0x1accec39cafe242 => 40
	i64 181099460066822533, ; 6: Microcharts.Droid.dll => 0x28364ffda4c4985 => 28
	i64 210515253464952879, ; 7: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 89
	i64 232391251801502327, ; 8: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 127
	i64 295915112840604065, ; 9: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 128
	i64 316157742385208084, ; 10: Xamarin.AndroidX.Core.Core.Ktx.dll => 0x46337caa7dc1b14 => 94
	i64 435170709725415398, ; 11: Xamarin.GooglePlayServices.Location => 0x60a097471d687e6 => 148
	i64 464346026994987652, ; 12: System.Reactive.dll => 0x671b04057e67284 => 66
	i64 569564398114481256, ; 13: Microsoft.TestPlatform.CoreUtilities => 0x7e77fcd6a52a468 => 37
	i64 634308326490598313, ; 14: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 112
	i64 687654259221141486, ; 15: Xamarin.GooglePlayServices.Base => 0x98b09e7c92917ee => 146
	i64 702024105029695270, ; 16: System.Drawing.Common => 0x9be17343c0e7726 => 6
	i64 718159679911342543, ; 17: FirebaseAdmin.dll => 0x9f76a6c851fb1cf => 16
	i64 720058930071658100, ; 18: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 105
	i64 737318085524959015, ; 19: NuGet.Frameworks => 0xa3b7ae46e2faf27 => 43
	i64 872800313462103108, ; 20: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 99
	i64 887546508555532406, ; 21: Microcharts.Forms => 0xc5132d8dc173876 => 29
	i64 940822596282819491, ; 22: System.Transactions => 0xd0e792aa81923a3 => 161
	i64 970639903786436877, ; 23: BottomBar.XamarinForms.dll => 0xd7867d98e02890d => 11
	i64 996343623809489702, ; 24: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 142
	i64 1000557547492888992, ; 25: Mono.Security.dll => 0xde2b1c9cba651a0 => 173
	i64 1120440138749646132, ; 26: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 144
	i64 1315114680217950157, ; 27: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 83
	i64 1416135423712704079, ; 28: Microcharts => 0x13a71faa343e364f => 27
	i64 1425944114962822056, ; 29: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 9
	i64 1624659445732251991, ; 30: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 81
	i64 1628611045998245443, ; 31: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 114
	i64 1636321030536304333, ; 32: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 106
	i64 1731380447121279447, ; 33: Newtonsoft.Json => 0x18071957e9b889d7 => 42
	i64 1743969030606105336, ; 34: System.Memory.dll => 0x1833d297e88f2af8 => 62
	i64 1744702963312407042, ; 35: Xamarin.Android.Support.v7.AppCompat => 0x18366e19eeceb202 => 75
	i64 1795316252682057001, ; 36: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 82
	i64 1836611346387731153, ; 37: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 127
	i64 1860886102525309849, ; 38: Xamarin.Android.Support.v7.RecyclerView.dll => 0x19d3320d047b7399 => 76
	i64 1865037103900624886, ; 39: Microsoft.Bcl.AsyncInterfaces => 0x19e1f15d56eb87f6 => 30
	i64 1875917498431009007, ; 40: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 79
	i64 1938067011858688285, ; 41: Xamarin.Android.Support.v4.dll => 0x1ae565add0bd691d => 74
	i64 1959668881137956832, ; 42: BottomBar.XamarinForms => 0x1b322476f19d77e0 => 11
	i64 1981742497975770890, ; 43: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 113
	i64 1986553961460820075, ; 44: Xamarin.CommunityToolkit => 0x1b91a84d8004686b => 138
	i64 2040001226662520565, ; 45: System.Threading.Tasks.Extensions.dll => 0x1c4f8a4ea894a6f5 => 4
	i64 2064708342624596306, ; 46: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x1ca7514c5eecb152 => 153
	i64 2076847052340733488, ; 47: Syncfusion.Core.XForms => 0x1cd27163f7962630 => 53
	i64 2133195048986300728, ; 48: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 42
	i64 2136356949452311481, ; 49: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 118
	i64 2165725771938924357, ; 50: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 87
	i64 2262844636196693701, ; 51: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 99
	i64 2284400282711631002, ; 52: System.Web.Services => 0x1fb3d1f42fd4249a => 162
	i64 2304837677853103545, ; 53: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0x1ffc6da80d5ed5b9 => 126
	i64 2329709569556905518, ; 54: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 109
	i64 2337758774805907496, ; 55: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 68
	i64 2455121377850707897, ; 56: NuGet.Frameworks.dll => 0x221257e2a7424fb9 => 43
	i64 2469392061734276978, ; 57: Syncfusion.Core.XForms.Android.dll => 0x22450aff2ad74f72 => 52
	i64 2470498323731680442, ; 58: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 93
	i64 2479423007379663237, ; 59: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 133
	i64 2497223385847772520, ; 60: System.Runtime => 0x22a7eb7046413568 => 69
	i64 2547086958574651984, ; 61: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 78
	i64 2592350477072141967, ; 62: System.Xml.dll => 0x23f9e10627330e8f => 70
	i64 2624866290265602282, ; 63: mscorlib.dll => 0x246d65fbde2db8ea => 41
	i64 2656907746661064104, ; 64: Microsoft.Extensions.DependencyInjection => 0x24df3b84c8b75da8 => 32
	i64 2694427813909235223, ; 65: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 122
	i64 2783046991838674048, ; 66: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 68
	i64 2787234703088983483, ; 67: Xamarin.AndroidX.Startup.StartupRuntime => 0x26ae3f31ef429dbb => 129
	i64 2812926542227278819, ; 68: Google.Apis.Core.dll => 0x270985c960b98be3 => 22
	i64 2960931600190307745, ; 69: Xamarin.Forms.Core => 0x2917579a49927da1 => 140
	i64 3017704767998173186, ; 70: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 144
	i64 3122911337338800527, ; 71: Microcharts.dll => 0x2b56cf50bf1e898f => 27
	i64 3217286949467762653, ; 72: Syncfusion.SfChart.XForms.Android.dll => 0x2ca6196f4386afdd => 55
	i64 3289520064315143713, ; 73: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 108
	i64 3303437397778967116, ; 74: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 80
	i64 3311221304742556517, ; 75: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 65
	i64 3344514922410554693, ; 76: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 156
	i64 3411255996856937470, ; 77: Xamarin.GooglePlayServices.Basement => 0x2f5737416a942bfe => 147
	i64 3493805808809882663, ; 78: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 131
	i64 3522470458906976663, ; 79: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 130
	i64 3531994851595924923, ; 80: System.Numerics => 0x31042a9aade235bb => 64
	i64 3571415421602489686, ; 81: System.Runtime.dll => 0x319037675df7e556 => 69
	i64 3716579019761409177, ; 82: netstandard.dll => 0x3393f0ed5c8c5c99 => 3
	i64 3727469159507183293, ; 83: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 125
	i64 3772598417116884899, ; 84: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 100
	i64 3845980214428618329, ; 85: Microsoft.VisualStudio.TestPlatform.ObjectModel.resources => 0x355faaa0ce32ce59 => 1
	i64 3869221888984012293, ; 86: Microsoft.Extensions.Logging.dll => 0x35b23cceda0ed605 => 34
	i64 3943415582112705276, ; 87: Syncfusion.Buttons.XForms.dll => 0x36b9d3942d916afc => 51
	i64 3966267475168208030, ; 88: System.Memory => 0x370b03412596249e => 62
	i64 4056584864658557221, ; 89: Google.Apis.Auth => 0x384be27113330925 => 20
	i64 4201423742386704971, ; 90: Xamarin.AndroidX.Core.Core.Ktx => 0x3a4e74a233da124b => 94
	i64 4247996603072512073, ; 91: Xamarin.GooglePlayServices.Tasks => 0x3af3ea6755340049 => 149
	i64 4326933140005261798, ; 92: Xamarin.AndroidX.Biometric => 0x3c0c5ac408e111e6 => 86
	i64 4525561845656915374, ; 93: System.ServiceModel.Internals => 0x3ece06856b710dae => 163
	i64 4636684751163556186, ; 94: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 135
	i64 4759461199762736555, ; 95: Xamarin.AndroidX.Lifecycle.Process.dll => 0x420d00be961cc5ab => 111
	i64 4782108999019072045, ; 96: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 85
	i64 4794310189461587505, ; 97: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 78
	i64 4795410492532947900, ; 98: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 130
	i64 5081566143765835342, ; 99: System.Resources.ResourceManager.dll => 0x4685597c05d06e4e => 5
	i64 5099468265966638712, ; 100: System.Resources.ResourceManager => 0x46c4f35ea8519678 => 5
	i64 5142919913060024034, ; 101: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 141
	i64 5203618020066742981, ; 102: Xamarin.Essentials => 0x4836f704f0e652c5 => 139
	i64 5205316157927637098, ; 103: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 116
	i64 5348796042099802469, ; 104: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 117
	i64 5376510917114486089, ; 105: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 133
	i64 5408338804355907810, ; 106: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 132
	i64 5415938286181081424, ; 107: Microsoft.VisualStudio.TestPlatform.ObjectModel => 0x4b29472d2942e150 => 39
	i64 5439315836349573567, ; 108: Xamarin.Android.Support.Animated.Vector.Drawable.dll => 0x4b7c54ef36c5e9bf => 72
	i64 5446034149219586269, ; 109: System.Diagnostics.Debug => 0x4b94333452e150dd => 170
	i64 5451019430259338467, ; 110: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 92
	i64 5507995362134886206, ; 111: System.Core.dll => 0x4c705499688c873e => 59
	i64 5528247634813456972, ; 112: Plugin.LocalNotification.dll => 0x4cb847ef1773124c => 46
	i64 5665389054145784248, ; 113: Google.Apis.Core => 0x4e9f815406bee9b8 => 22
	i64 5692067934154308417, ; 114: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 137
	i64 5757522595884336624, ; 115: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 90
	i64 5814345312393086621, ; 116: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 122
	i64 5896680224035167651, ; 117: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 110
	i64 5974002045223400615, ; 118: Plugin.Fingerprint => 0x52e7eb3560ff74a7 => 44
	i64 6085203216496545422, ; 119: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 142
	i64 6086316965293125504, ; 120: FormsViewGroup.dll => 0x5476f10882baef80 => 17
	i64 6218967553231149354, ; 121: Firebase.Auth.dll => 0x564e360a4805d92a => 14
	i64 6319713645133255417, ; 122: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 112
	i64 6401687960814735282, ; 123: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 109
	i64 6405879832841858445, ; 124: Xamarin.Android.Support.Vector.Drawable.dll => 0x58e641c4a660ad8d => 77
	i64 6504860066809920875, ; 125: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 87
	i64 6548213210057960872, ; 126: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 97
	i64 6560151584539558821, ; 127: Microsoft.Extensions.Options => 0x5b0a571be53243a5 => 35
	i64 6588599331800941662, ; 128: Xamarin.Android.Support.v4 => 0x5b6f682f335f045e => 74
	i64 6591024623626361694, ; 129: System.Web.Services.dll => 0x5b7805f9751a1b5e => 162
	i64 6659513131007730089, ; 130: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 105
	i64 6671798237668743565, ; 131: SkiaSharp => 0x5c96fd260152998d => 47
	i64 6765186420343520598, ; 132: F1MobileApp.dll => 0x5de2c534afdf3d56 => 13
	i64 6876862101832370452, ; 133: System.Xml.Linq => 0x5f6f85a57d108914 => 71
	i64 6894844156784520562, ; 134: System.Numerics.Vectors => 0x5faf683aead1ad72 => 65
	i64 6934772601320367100, ; 135: Google.Api.Gax.Rest => 0x603d42f05bcfe3fc => 19
	i64 6941080589610463230, ; 136: Google.Apis.Auth.PlatformServices => 0x6053ac0555172ffe => 21
	i64 7026608356547306326, ; 137: Syncfusion.Core.XForms.dll => 0x618387125bcb2356 => 53
	i64 7036436454368433159, ; 138: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 107
	i64 7098131676344687625, ; 139: LiveCharts => 0x6281a126f1791c09 => 26
	i64 7103753931438454322, ; 140: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 104
	i64 7135772949214115721, ; 141: Microsoft.TestPlatform.PlatformAbstractions => 0x63075bb0bbbfb789 => 38
	i64 7141577505875122296, ; 142: System.Runtime.InteropServices.WindowsRuntime.dll => 0x631bfae7659b5878 => 8
	i64 7270811800166795866, ; 143: System.Linq => 0x64e71ccf51a90a5a => 167
	i64 7338192458477945005, ; 144: System.Reflection => 0x65d67f295d0740ad => 171
	i64 7488575175965059935, ; 145: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 71
	i64 7489048572193775167, ; 146: System.ObjectModel => 0x67ee71ff6b419e3f => 164
	i64 7602111570124318452, ; 147: System.Reactive => 0x698020320025a6f4 => 66
	i64 7608871685949591681, ; 148: Microsoft.TestPlatform.CoreUtilities.resources.dll => 0x6998247c1e8d9081 => 0
	i64 7635363394907363464, ; 149: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 140
	i64 7637365915383206639, ; 150: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 139
	i64 7654504624184590948, ; 151: System.Net.Http => 0x6a3a4366801b8264 => 63
	i64 7735352534559001595, ; 152: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 152
	i64 7820441508502274321, ; 153: System.Data => 0x6c87ca1e14ff8111 => 7
	i64 7836164640616011524, ; 154: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 81
	i64 7879037620440914030, ; 155: Xamarin.Android.Support.v7.AppCompat.dll => 0x6d57f6f88a51d86e => 75
	i64 7927939710195668715, ; 156: SkiaSharp.Views.Android.dll => 0x6e05b32992ed16eb => 48
	i64 8042847094967026162, ; 157: BottomNavigationBar.dll => 0x6f9deed1ee4ac1f2 => 12
	i64 8044118961405839122, ; 158: System.ComponentModel.Composition => 0x6fa2739369944712 => 160
	i64 8064050204834738623, ; 159: System.Collections.dll => 0x6fe942efa61731bf => 165
	i64 8083354569033831015, ; 160: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 108
	i64 8087206902342787202, ; 161: System.Diagnostics.DiagnosticSource => 0x703b87d46f3aa082 => 60
	i64 8103644804370223335, ; 162: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 157
	i64 8132393369586336849, ; 163: Plugin.InputKit => 0x70dc10aeafef8451 => 45
	i64 8167236081217502503, ; 164: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 24
	i64 8185542183669246576, ; 165: System.Collections => 0x7198e33f4794aa70 => 165
	i64 8187102936927221770, ; 166: SkiaSharp.Views.Forms => 0x719e6ebe771ab80a => 49
	i64 8187640529827139739, ; 167: Xamarin.KotlinX.Coroutines.Android => 0x71a057ae90f0109b => 155
	i64 8290740647658429042, ; 168: System.Runtime.Extensions => 0x730ea0b15c929a72 => 166
	i64 8398329775253868912, ; 169: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 91
	i64 8400181818043915251, ; 170: Microsoft.TestPlatform.CoreUtilities.resources => 0x749370db8133dbf3 => 0
	i64 8400357532724379117, ; 171: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 121
	i64 8426919725312979251, ; 172: Xamarin.AndroidX.Lifecycle.Process => 0x74f26ed7aa033133 => 111
	i64 8517710342570482946, ; 173: Syncfusion.Buttons.XForms.Android => 0x7634fc6d84959d02 => 50
	i64 8518412311883997971, ; 174: System.Collections.Immutable => 0x76377add7c28e313 => 58
	i64 8598790081731763592, ; 175: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x77550a055fc61d88 => 102
	i64 8601935802264776013, ; 176: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 132
	i64 8626175481042262068, ; 177: Java.Interop => 0x77b654e585b55834 => 24
	i64 8639588376636138208, ; 178: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 120
	i64 8648495978913578441, ; 179: Microsoft.Win32.Registry.dll => 0x7805a1456889bdc9 => 172
	i64 8684531736582871431, ; 180: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 159
	i64 8702320156596882678, ; 181: Firebase.dll => 0x78c4da1357adccf6 => 15
	i64 8725526185868997716, ; 182: System.Diagnostics.DiagnosticSource.dll => 0x79174bd613173454 => 60
	i64 8727204506373749864, ; 183: Microsoft.TestPlatform.PlatformAbstractions.dll => 0x791d424284987c68 => 38
	i64 8853378295825400934, ; 184: Xamarin.Kotlin.StdLib.Common.dll => 0x7add84a720d38466 => 151
	i64 8951477988056063522, ; 185: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0x7c3a09cd9ccf5e22 => 124
	i64 9034105039140296321, ; 186: Syncfusion.SfChart.XForms => 0x7d5f96ab19861681 => 56
	i64 9057635389615298436, ; 187: LiteDB => 0x7db32f65bf06d784 => 25
	i64 9296667808972889535, ; 188: LiteDB.dll => 0x8104661dcca35dbf => 25
	i64 9312692141327339315, ; 189: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 137
	i64 9324707631942237306, ; 190: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 82
	i64 9475595603812259686, ; 191: Xamarin.Android.Support.Design => 0x838013ff707b9766 => 73
	i64 9662334977499516867, ; 192: System.Numerics.dll => 0x8617827802b0cfc3 => 64
	i64 9678050649315576968, ; 193: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 93
	i64 9711637524876806384, ; 194: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 117
	i64 9808709177481450983, ; 195: Mono.Android.dll => 0x881f890734e555e7 => 40
	i64 9825649861376906464, ; 196: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 90
	i64 9834056768316610435, ; 197: System.Transactions.dll => 0x8879968718899783 => 161
	i64 9836529246295212050, ; 198: System.Reflection.Metadata => 0x88825f3bbc2ac012 => 67
	i64 9875200773399460291, ; 199: Xamarin.GooglePlayServices.Base.dll => 0x890bc2c8482339c3 => 146
	i64 9907349773706910547, ; 200: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x897dfa20b758db53 => 102
	i64 9998632235833408227, ; 201: Mono.Security => 0x8ac2470b209ebae3 => 173
	i64 10038780035334861115, ; 202: System.Net.Http.dll => 0x8b50e941206af13b => 63
	i64 10144742755892837524, ; 203: Firebase => 0x8cc95dc98eb5bc94 => 15
	i64 10218821437939648382, ; 204: Google.Apis.Auth.PlatformServices.dll => 0x8dd08bf4c78a077e => 21
	i64 10220684565739810458, ; 205: FirebaseAdmin => 0x8dd72a76063d2e9a => 16
	i64 10226222362177979215, ; 206: Xamarin.Kotlin.StdLib.Jdk7 => 0x8dead70ebbc6434f => 153
	i64 10229024438826829339, ; 207: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 97
	i64 10318047534812931528, ; 208: Xamarin.AndroidX.Biometric.dll => 0x8f311190c81ea5c8 => 86
	i64 10321854143672141184, ; 209: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 150
	i64 10376576884623852283, ; 210: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 131
	i64 10406448008575299332, ; 211: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 156
	i64 10430153318873392755, ; 212: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 95
	i64 10447083246144586668, ; 213: Microsoft.Bcl.AsyncInterfaces.dll => 0x90fb7edc816203ac => 30
	i64 10566960649245365243, ; 214: System.Globalization.dll => 0x92a562b96dcd13fb => 168
	i64 10714184849103829812, ; 215: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 166
	i64 10823124638835005028, ; 216: Google.Api.Gax.dll => 0x963376840189d664 => 18
	i64 10847732767863316357, ; 217: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 83
	i64 10984620054693331049, ; 218: Plugin.InputKit.dll => 0x987135bda0a0c069 => 45
	i64 11002576679268595294, ; 219: Microsoft.Extensions.Logging.Abstractions => 0x98b1013215cd365e => 33
	i64 11023048688141570732, ; 220: System.Core => 0x98f9bc61168392ac => 59
	i64 11037814507248023548, ; 221: System.Xml => 0x992e31d0412bf7fc => 70
	i64 11122995063473561350, ; 222: Xamarin.CommunityToolkit.dll => 0x9a5cd113fcc3df06 => 138
	i64 11162124722117608902, ; 223: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 136
	i64 11226290749488709958, ; 224: Microsoft.Extensions.Options.dll => 0x9bcbcbf50c874146 => 35
	i64 11340910727871153756, ; 225: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 96
	i64 11343270826416147792, ; 226: BottomNavigationBar => 0x9d6b64b7a7960d50 => 12
	i64 11392833485892708388, ; 227: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 123
	i64 11529969570048099689, ; 228: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 136
	i64 11530571088791430846, ; 229: Microsoft.Extensions.Logging => 0xa004d1504ccd66be => 34
	i64 11578238080964724296, ; 230: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 107
	i64 11580057168383206117, ; 231: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 79
	i64 11591352189662810718, ; 232: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0xa0dcc167234c525e => 129
	i64 11597940890313164233, ; 233: netstandard => 0xa0f429ca8d1805c9 => 3
	i64 11672361001936329215, ; 234: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 104
	i64 11920918321499785284, ; 235: F1MobileApp => 0xa56f9c0dbd70c844 => 13
	i64 12080542886298039060, ; 236: F1MobileApp.Android.dll => 0xa7a6b5bfe7aab314 => 2
	i64 12102847907131387746, ; 237: System.Buffers => 0xa7f5f40c43256f62 => 57
	i64 12137774235383566651, ; 238: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 134
	i64 12269460666702402136, ; 239: System.Collections.Immutable.dll => 0xaa45e178506c9258 => 58
	i64 12403667497883933216, ; 240: F1MobileApp.Android => 0xac22addf336e1a20 => 2
	i64 12437742355241350664, ; 241: Google.Apis.dll => 0xac9bbcc62bfdb608 => 23
	i64 12451044538927396471, ; 242: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 103
	i64 12466513435562512481, ; 243: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 115
	i64 12487638416075308985, ; 244: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 98
	i64 12528155905152483962, ; 245: Firebase.Auth => 0xaddcf36b3153827a => 14
	i64 12538491095302438457, ; 246: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 88
	i64 12550732019250633519, ; 247: System.IO.Compression => 0xae2d28465e8e1b2f => 158
	i64 12700543734426720211, ; 248: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 89
	i64 12722065664929968482, ; 249: Google.Api.Gax.Rest.dll => 0xb08ddb515f583162 => 19
	i64 12828192437253469131, ; 250: Xamarin.Kotlin.StdLib.Jdk8.dll => 0xb206e50e14d873cb => 154
	i64 12843321153144804894, ; 251: Microsoft.Extensions.Primitives => 0xb23ca48abd74d61e => 36
	i64 12958614573187252691, ; 252: Google.Apis => 0xb3d63f4bf006c1d3 => 23
	i64 12963446364377008305, ; 253: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 6
	i64 13129914918964716986, ; 254: Xamarin.AndroidX.Emoji2.dll => 0xb636d40db3fe65ba => 101
	i64 13370592475155966277, ; 255: System.Runtime.Serialization => 0xb98de304062ea945 => 9
	i64 13391361154981494717, ; 256: Syncfusion.Buttons.XForms.Android.dll => 0xb9d7ac051da2ffbd => 50
	i64 13401370062847626945, ; 257: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 134
	i64 13403416310143541304, ; 258: Microcharts.Droid => 0xba02801ea6c86038 => 28
	i64 13404347523447273790, ; 259: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 91
	i64 13447930857737371653, ; 260: Microsoft.TestPlatform.CoreUtilities.dll => 0xbaa0a5dd6b734005 => 37
	i64 13454009404024712428, ; 261: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 145
	i64 13465488254036897740, ; 262: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 152
	i64 13491513212026656886, ; 263: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 84
	i64 13492263892638604996, ; 264: SkiaSharp.Views.Forms.dll => 0xbb3e2686788d9ec4 => 49
	i64 13572454107664307259, ; 265: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 125
	i64 13622732128915678507, ; 266: Syncfusion.Core.XForms.Android => 0xbd0daab1e651e52b => 52
	i64 13647894001087880694, ; 267: System.Data.dll => 0xbd670f48cb071df6 => 7
	i64 13782512541859110153, ; 268: Google.Apis.Auth.dll => 0xbf45522249e0dd09 => 20
	i64 13828521679616088467, ; 269: Xamarin.Kotlin.StdLib.Common => 0xbfe8c733724e1993 => 151
	i64 13959074834287824816, ; 270: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 103
	i64 13967638549803255703, ; 271: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 141
	i64 13970307180132182141, ; 272: Syncfusion.Licensing => 0xc1e0805ccade287d => 54
	i64 13977061573113476558, ; 273: Microsoft.VisualStudio.TestPlatform.ObjectModel.dll => 0xc1f87f727530f5ce => 39
	i64 14124974489674258913, ; 274: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 88
	i64 14125464355221830302, ; 275: System.Threading.dll => 0xc407bafdbc707a9e => 169
	i64 14172845254133543601, ; 276: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 118
	i64 14261073672896646636, ; 277: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 123
	i64 14327695147300244862, ; 278: System.Reflection.dll => 0xc6d632d338eb4d7e => 171
	i64 14369828458497533121, ; 279: Xamarin.Android.Support.Vector.Drawable => 0xc76be2d9300b64c1 => 77
	i64 14422096143452322666, ; 280: BottomBar.Droid.dll => 0xc8259407eb01bb6a => 10
	i64 14486659737292545672, ; 281: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 110
	i64 14495724990987328804, ; 282: Xamarin.AndroidX.ResourceInspection.Annotation => 0xc92b2913e18d5d24 => 126
	i64 14538127318538747197, ; 283: Syncfusion.Licensing.dll => 0xc9c1cdc518e77d3d => 54
	i64 14644440854989303794, ; 284: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 116
	i64 14669215534098758659, ; 285: Microsoft.Extensions.DependencyInjection.dll => 0xcb9385ceb3993c03 => 32
	i64 14678510994762383812, ; 286: Xamarin.GooglePlayServices.Location.dll => 0xcbb48bfaca7a41c4 => 148
	i64 14792063746108907174, ; 287: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 145
	i64 14852515768018889994, ; 288: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 96
	i64 14954917835170835695, ; 289: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xcf8a8a895a82ecef => 31
	i64 14987728460634540364, ; 290: System.IO.Compression.dll => 0xcfff1ba06622494c => 158
	i64 14988210264188246988, ; 291: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 98
	i64 15076659072870671916, ; 292: System.ObjectModel.dll => 0xd13b0d8c1620662c => 164
	i64 15133485256822086103, ; 293: System.Linq.dll => 0xd204f0a9127dd9d7 => 167
	i64 15150743910298169673, ; 294: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xd2424150783c3149 => 124
	i64 15279429628684179188, ; 295: Xamarin.KotlinX.Coroutines.Android.dll => 0xd40b704b1c4c96f4 => 155
	i64 15370334346939861994, ; 296: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 95
	i64 15391712275433856905, ; 297: Microsoft.Extensions.DependencyInjection.Abstractions => 0xd59a58c406411f89 => 31
	i64 15540815214206815676, ; 298: Plugin.Fingerprint.dll => 0xd7ac11193ac88dbc => 44
	i64 15582737692548360875, ; 299: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 114
	i64 15609085926864131306, ; 300: System.dll => 0xd89e9cf3334914ea => 61
	i64 15710114879900314733, ; 301: Microsoft.Win32.Registry => 0xda058a3f5d096c6d => 172
	i64 15777549416145007739, ; 302: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 128
	i64 15810740023422282496, ; 303: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 143
	i64 15930129725311349754, ; 304: Xamarin.GooglePlayServices.Tasks.dll => 0xdd1330956f12f3fa => 149
	i64 15963349826457351533, ; 305: System.Threading.Tasks.Extensions => 0xdd893616f748b56d => 4
	i64 16150183177059685051, ; 306: Syncfusion.SfChart.XForms.dll => 0xe020fa083e21d2bb => 56
	i64 16154507427712707110, ; 307: System => 0xe03056ea4e39aa26 => 61
	i64 16321164108206115771, ; 308: Microsoft.Extensions.Logging.Abstractions.dll => 0xe2806c487e7b0bbb => 33
	i64 16324796876805858114, ; 309: SkiaSharp.dll => 0xe28d5444586b6342 => 47
	i64 16330368091231878554, ; 310: Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll => 0xe2a11f41c93ffd9a => 1
	i64 16423015068819898779, ; 311: Xamarin.Kotlin.StdLib.Jdk8 => 0xe3ea453135e5c19b => 154
	i64 16552427520763284698, ; 312: Syncfusion.SfChart.XForms.Android => 0xe5b60921b17eccda => 55
	i64 16565028646146589191, ; 313: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 160
	i64 16621146507174665210, ; 314: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 92
	i64 16677317093839702854, ; 315: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 121
	i64 16822611501064131242, ; 316: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 157
	i64 16833383113903931215, ; 317: mscorlib => 0xe99c30c1484d7f4f => 41
	i64 16866861824412579935, ; 318: System.Runtime.InteropServices.WindowsRuntime => 0xea132176ffb5785f => 8
	i64 16955525858597485057, ; 319: Google.Api.Gax => 0xeb4e20ef25a73a01 => 18
	i64 17001062948826229159, ; 320: Microcharts.Forms.dll => 0xebefe8ad2cd7a9a7 => 29
	i64 17009591894298689098, ; 321: Xamarin.Android.Support.Animated.Vector.Drawable => 0xec0e35b50a097e4a => 72
	i64 17024911836938395553, ; 322: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 80
	i64 17031351772568316411, ; 323: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 119
	i64 17037200463775726619, ; 324: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 106
	i64 17544493274320527064, ; 325: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 85
	i64 17627500474728259406, ; 326: System.Globalization => 0xf4a176498a351f4e => 168
	i64 17671790519499593115, ; 327: SkiaSharp.Views.Android => 0xf53ecfd92be3959b => 48
	i64 17685921127322830888, ; 328: System.Diagnostics.Debug.dll => 0xf571038fafa74828 => 170
	i64 17704177640604968747, ; 329: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 115
	i64 17710060891934109755, ; 330: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 113
	i64 17838668724098252521, ; 331: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 57
	i64 17875729375684862191, ; 332: LiveCharts.dll => 0xf813592852b620ef => 26
	i64 17882897186074144999, ; 333: FormsViewGroup => 0xf82cd03e3ac830e7 => 17
	i64 17891337867145587222, ; 334: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 150
	i64 17892495832318972303, ; 335: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 143
	i64 17928294245072900555, ; 336: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 159
	i64 17936749993673010118, ; 337: Xamarin.Android.Support.Design.dll => 0xf8ec231615deabc6 => 73
	i64 17986907704309214542, ; 338: Xamarin.GooglePlayServices.Basement.dll => 0xf99e554223166d4e => 147
	i64 18025913125965088385, ; 339: System.Threading => 0xfa28e87b91334681 => 169
	i64 18090425465832348288, ; 340: Xamarin.Android.Support.v7.RecyclerView => 0xfb0e1a1d2e9e1a80 => 76
	i64 18116111925905154859, ; 341: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 84
	i64 18121036031235206392, ; 342: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 119
	i64 18129453464017766560, ; 343: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 163
	i64 18260797123374478311, ; 344: Xamarin.AndroidX.Emoji2 => 0xfd6b623bde35f3e7 => 101
	i64 18305135509493619199, ; 345: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 120
	i64 18380184030268848184, ; 346: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 135
	i64 18439108438687598470 ; 347: System.Reflection.Metadata.dll => 0xffe4df6e2ee1c786 => 67
], align 16
@assembly_image_cache_indices = local_unnamed_addr constant [348 x i32] [
	i32 100, i32 51, i32 46, i32 36, i32 10, i32 40, i32 28, i32 89, ; 0..7
	i32 127, i32 128, i32 94, i32 148, i32 66, i32 37, i32 112, i32 146, ; 8..15
	i32 6, i32 16, i32 105, i32 43, i32 99, i32 29, i32 161, i32 11, ; 16..23
	i32 142, i32 173, i32 144, i32 83, i32 27, i32 9, i32 81, i32 114, ; 24..31
	i32 106, i32 42, i32 62, i32 75, i32 82, i32 127, i32 76, i32 30, ; 32..39
	i32 79, i32 74, i32 11, i32 113, i32 138, i32 4, i32 153, i32 53, ; 40..47
	i32 42, i32 118, i32 87, i32 99, i32 162, i32 126, i32 109, i32 68, ; 48..55
	i32 43, i32 52, i32 93, i32 133, i32 69, i32 78, i32 70, i32 41, ; 56..63
	i32 32, i32 122, i32 68, i32 129, i32 22, i32 140, i32 144, i32 27, ; 64..71
	i32 55, i32 108, i32 80, i32 65, i32 156, i32 147, i32 131, i32 130, ; 72..79
	i32 64, i32 69, i32 3, i32 125, i32 100, i32 1, i32 34, i32 51, ; 80..87
	i32 62, i32 20, i32 94, i32 149, i32 86, i32 163, i32 135, i32 111, ; 88..95
	i32 85, i32 78, i32 130, i32 5, i32 5, i32 141, i32 139, i32 116, ; 96..103
	i32 117, i32 133, i32 132, i32 39, i32 72, i32 170, i32 92, i32 59, ; 104..111
	i32 46, i32 22, i32 137, i32 90, i32 122, i32 110, i32 44, i32 142, ; 112..119
	i32 17, i32 14, i32 112, i32 109, i32 77, i32 87, i32 97, i32 35, ; 120..127
	i32 74, i32 162, i32 105, i32 47, i32 13, i32 71, i32 65, i32 19, ; 128..135
	i32 21, i32 53, i32 107, i32 26, i32 104, i32 38, i32 8, i32 167, ; 136..143
	i32 171, i32 71, i32 164, i32 66, i32 0, i32 140, i32 139, i32 63, ; 144..151
	i32 152, i32 7, i32 81, i32 75, i32 48, i32 12, i32 160, i32 165, ; 152..159
	i32 108, i32 60, i32 157, i32 45, i32 24, i32 165, i32 49, i32 155, ; 160..167
	i32 166, i32 91, i32 0, i32 121, i32 111, i32 50, i32 58, i32 102, ; 168..175
	i32 132, i32 24, i32 120, i32 172, i32 159, i32 15, i32 60, i32 38, ; 176..183
	i32 151, i32 124, i32 56, i32 25, i32 25, i32 137, i32 82, i32 73, ; 184..191
	i32 64, i32 93, i32 117, i32 40, i32 90, i32 161, i32 67, i32 146, ; 192..199
	i32 102, i32 173, i32 63, i32 15, i32 21, i32 16, i32 153, i32 97, ; 200..207
	i32 86, i32 150, i32 131, i32 156, i32 95, i32 30, i32 168, i32 166, ; 208..215
	i32 18, i32 83, i32 45, i32 33, i32 59, i32 70, i32 138, i32 136, ; 216..223
	i32 35, i32 96, i32 12, i32 123, i32 136, i32 34, i32 107, i32 79, ; 224..231
	i32 129, i32 3, i32 104, i32 13, i32 2, i32 57, i32 134, i32 58, ; 232..239
	i32 2, i32 23, i32 103, i32 115, i32 98, i32 14, i32 88, i32 158, ; 240..247
	i32 89, i32 19, i32 154, i32 36, i32 23, i32 6, i32 101, i32 9, ; 248..255
	i32 50, i32 134, i32 28, i32 91, i32 37, i32 145, i32 152, i32 84, ; 256..263
	i32 49, i32 125, i32 52, i32 7, i32 20, i32 151, i32 103, i32 141, ; 264..271
	i32 54, i32 39, i32 88, i32 169, i32 118, i32 123, i32 171, i32 77, ; 272..279
	i32 10, i32 110, i32 126, i32 54, i32 116, i32 32, i32 148, i32 145, ; 280..287
	i32 96, i32 31, i32 158, i32 98, i32 164, i32 167, i32 124, i32 155, ; 288..295
	i32 95, i32 31, i32 44, i32 114, i32 61, i32 172, i32 128, i32 143, ; 296..303
	i32 149, i32 4, i32 56, i32 61, i32 33, i32 47, i32 1, i32 154, ; 304..311
	i32 55, i32 160, i32 92, i32 121, i32 157, i32 41, i32 8, i32 18, ; 312..319
	i32 29, i32 72, i32 80, i32 119, i32 106, i32 85, i32 168, i32 48, ; 320..327
	i32 170, i32 115, i32 113, i32 57, i32 26, i32 17, i32 150, i32 143, ; 328..335
	i32 159, i32 73, i32 147, i32 169, i32 76, i32 84, i32 119, i32 163, ; 336..343
	i32 101, i32 120, i32 135, i32 67 ; 344..347
], align 16

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 16; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1}
!llvm.ident = !{!2}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
