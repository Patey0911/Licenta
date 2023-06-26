; ModuleID = 'obj\Debug\130\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


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
@assembly_image_cache_hashes = local_unnamed_addr constant [250 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 62
	i64 36418902923615093, ; 1: Plugin.LocalNotification => 0x8162cc9bdf1b75 => 23
	i64 98382396393917666, ; 2: Microsoft.Extensions.Primitives.dll => 0x15d8644ad360ce2 => 18
	i64 120698629574877762, ; 3: Mono.Android => 0x1accec39cafe242 => 19
	i64 181099460066822533, ; 4: Microcharts.Droid.dll => 0x28364ffda4c4985 => 11
	i64 210515253464952879, ; 5: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 51
	i64 232391251801502327, ; 6: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 85
	i64 295915112840604065, ; 7: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 86
	i64 316157742385208084, ; 8: Xamarin.AndroidX.Core.Core.Ktx.dll => 0x46337caa7dc1b14 => 56
	i64 435170709725415398, ; 9: Xamarin.GooglePlayServices.Location => 0x60a097471d687e6 => 106
	i64 464346026994987652, ; 10: System.Reactive.dll => 0x671b04057e67284 => 35
	i64 634308326490598313, ; 11: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 71
	i64 687654259221141486, ; 12: Xamarin.GooglePlayServices.Base => 0x98b09e7c92917ee => 104
	i64 702024105029695270, ; 13: System.Drawing.Common => 0x9be17343c0e7726 => 118
	i64 720058930071658100, ; 14: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 65
	i64 872800313462103108, ; 15: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 61
	i64 887546508555532406, ; 16: Microcharts.Forms => 0xc5132d8dc173876 => 12
	i64 940822596282819491, ; 17: System.Transactions => 0xd0e792aa81923a3 => 116
	i64 996343623809489702, ; 18: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 100
	i64 1000557547492888992, ; 19: Mono.Security.dll => 0xde2b1c9cba651a0 => 124
	i64 1120440138749646132, ; 20: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 102
	i64 1315114680217950157, ; 21: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 45
	i64 1416135423712704079, ; 22: Microcharts => 0x13a71faa343e364f => 10
	i64 1425944114962822056, ; 23: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 3
	i64 1624659445732251991, ; 24: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 43
	i64 1628611045998245443, ; 25: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 73
	i64 1636321030536304333, ; 26: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 66
	i64 1731380447121279447, ; 27: Newtonsoft.Json => 0x18071957e9b889d7 => 21
	i64 1743969030606105336, ; 28: System.Memory.dll => 0x1833d297e88f2af8 => 31
	i64 1795316252682057001, ; 29: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 44
	i64 1836611346387731153, ; 30: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 85
	i64 1875917498431009007, ; 31: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 41
	i64 1981742497975770890, ; 32: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 72
	i64 1986553961460820075, ; 33: Xamarin.CommunityToolkit => 0x1b91a84d8004686b => 96
	i64 2064708342624596306, ; 34: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x1ca7514c5eecb152 => 111
	i64 2133195048986300728, ; 35: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 21
	i64 2136356949452311481, ; 36: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 77
	i64 2165725771938924357, ; 37: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 49
	i64 2262844636196693701, ; 38: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 61
	i64 2284400282711631002, ; 39: System.Web.Services => 0x1fb3d1f42fd4249a => 122
	i64 2329709569556905518, ; 40: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 69
	i64 2337758774805907496, ; 41: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 36
	i64 2470498323731680442, ; 42: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 55
	i64 2479423007379663237, ; 43: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 91
	i64 2497223385847772520, ; 44: System.Runtime => 0x22a7eb7046413568 => 37
	i64 2547086958574651984, ; 45: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 40
	i64 2592350477072141967, ; 46: System.Xml.dll => 0x23f9e10627330e8f => 38
	i64 2624866290265602282, ; 47: mscorlib.dll => 0x246d65fbde2db8ea => 20
	i64 2656907746661064104, ; 48: Microsoft.Extensions.DependencyInjection => 0x24df3b84c8b75da8 => 14
	i64 2694427813909235223, ; 49: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 81
	i64 2783046991838674048, ; 50: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 36
	i64 2787234703088983483, ; 51: Xamarin.AndroidX.Startup.StartupRuntime => 0x26ae3f31ef429dbb => 87
	i64 2960931600190307745, ; 52: Xamarin.Forms.Core => 0x2917579a49927da1 => 98
	i64 3017704767998173186, ; 53: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 102
	i64 3122911337338800527, ; 54: Microcharts.dll => 0x2b56cf50bf1e898f => 10
	i64 3289520064315143713, ; 55: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 68
	i64 3303437397778967116, ; 56: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 42
	i64 3311221304742556517, ; 57: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 34
	i64 3344514922410554693, ; 58: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 114
	i64 3411255996856937470, ; 59: Xamarin.GooglePlayServices.Basement => 0x2f5737416a942bfe => 105
	i64 3493805808809882663, ; 60: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 89
	i64 3522470458906976663, ; 61: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 88
	i64 3531994851595924923, ; 62: System.Numerics => 0x31042a9aade235bb => 33
	i64 3571415421602489686, ; 63: System.Runtime.dll => 0x319037675df7e556 => 37
	i64 3716579019761409177, ; 64: netstandard.dll => 0x3393f0ed5c8c5c99 => 1
	i64 3727469159507183293, ; 65: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 84
	i64 3772598417116884899, ; 66: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 62
	i64 3869221888984012293, ; 67: Microsoft.Extensions.Logging.dll => 0x35b23cceda0ed605 => 16
	i64 3966267475168208030, ; 68: System.Memory => 0x370b03412596249e => 31
	i64 4201423742386704971, ; 69: Xamarin.AndroidX.Core.Core.Ktx => 0x3a4e74a233da124b => 56
	i64 4247996603072512073, ; 70: Xamarin.GooglePlayServices.Tasks => 0x3af3ea6755340049 => 107
	i64 4326933140005261798, ; 71: Xamarin.AndroidX.Biometric => 0x3c0c5ac408e111e6 => 48
	i64 4525561845656915374, ; 72: System.ServiceModel.Internals => 0x3ece06856b710dae => 123
	i64 4636684751163556186, ; 73: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 93
	i64 4782108999019072045, ; 74: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 47
	i64 4794310189461587505, ; 75: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 40
	i64 4795410492532947900, ; 76: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 88
	i64 5142919913060024034, ; 77: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 99
	i64 5203618020066742981, ; 78: Xamarin.Essentials => 0x4836f704f0e652c5 => 97
	i64 5205316157927637098, ; 79: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 75
	i64 5348796042099802469, ; 80: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 76
	i64 5376510917114486089, ; 81: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 91
	i64 5408338804355907810, ; 82: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 90
	i64 5451019430259338467, ; 83: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 54
	i64 5507995362134886206, ; 84: System.Core.dll => 0x4c705499688c873e => 28
	i64 5528247634813456972, ; 85: Plugin.LocalNotification.dll => 0x4cb847ef1773124c => 23
	i64 5692067934154308417, ; 86: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 95
	i64 5757522595884336624, ; 87: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 52
	i64 5814345312393086621, ; 88: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 81
	i64 5896680224035167651, ; 89: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 70
	i64 5974002045223400615, ; 90: Plugin.Fingerprint => 0x52e7eb3560ff74a7 => 22
	i64 6085203216496545422, ; 91: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 100
	i64 6086316965293125504, ; 92: FormsViewGroup.dll => 0x5476f10882baef80 => 7
	i64 6218967553231149354, ; 93: Firebase.Auth.dll => 0x564e360a4805d92a => 5
	i64 6319713645133255417, ; 94: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 71
	i64 6401687960814735282, ; 95: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 69
	i64 6504860066809920875, ; 96: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 49
	i64 6548213210057960872, ; 97: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 59
	i64 6560151584539558821, ; 98: Microsoft.Extensions.Options => 0x5b0a571be53243a5 => 17
	i64 6591024623626361694, ; 99: System.Web.Services.dll => 0x5b7805f9751a1b5e => 122
	i64 6659513131007730089, ; 100: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 65
	i64 6671798237668743565, ; 101: SkiaSharp => 0x5c96fd260152998d => 24
	i64 6765186420343520598, ; 102: F1MobileApp.dll => 0x5de2c534afdf3d56 => 4
	i64 6876862101832370452, ; 103: System.Xml.Linq => 0x5f6f85a57d108914 => 39
	i64 6894844156784520562, ; 104: System.Numerics.Vectors => 0x5faf683aead1ad72 => 34
	i64 7036436454368433159, ; 105: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 67
	i64 7103753931438454322, ; 106: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 64
	i64 7141577505875122296, ; 107: System.Runtime.InteropServices.WindowsRuntime.dll => 0x631bfae7659b5878 => 2
	i64 7488575175965059935, ; 108: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 39
	i64 7602111570124318452, ; 109: System.Reactive => 0x698020320025a6f4 => 35
	i64 7635363394907363464, ; 110: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 98
	i64 7637365915383206639, ; 111: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 97
	i64 7654504624184590948, ; 112: System.Net.Http => 0x6a3a4366801b8264 => 32
	i64 7735352534559001595, ; 113: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 110
	i64 7820441508502274321, ; 114: System.Data => 0x6c87ca1e14ff8111 => 115
	i64 7836164640616011524, ; 115: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 43
	i64 7927939710195668715, ; 116: SkiaSharp.Views.Android.dll => 0x6e05b32992ed16eb => 25
	i64 8044118961405839122, ; 117: System.ComponentModel.Composition => 0x6fa2739369944712 => 121
	i64 8083354569033831015, ; 118: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 68
	i64 8087206902342787202, ; 119: System.Diagnostics.DiagnosticSource => 0x703b87d46f3aa082 => 29
	i64 8103644804370223335, ; 120: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 117
	i64 8167236081217502503, ; 121: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 8
	i64 8187102936927221770, ; 122: SkiaSharp.Views.Forms => 0x719e6ebe771ab80a => 26
	i64 8187640529827139739, ; 123: Xamarin.KotlinX.Coroutines.Android => 0x71a057ae90f0109b => 113
	i64 8398329775253868912, ; 124: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 53
	i64 8400357532724379117, ; 125: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 80
	i64 8601935802264776013, ; 126: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 90
	i64 8626175481042262068, ; 127: Java.Interop => 0x77b654e585b55834 => 8
	i64 8639588376636138208, ; 128: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 79
	i64 8684531736582871431, ; 129: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 120
	i64 8702320156596882678, ; 130: Firebase.dll => 0x78c4da1357adccf6 => 6
	i64 8725526185868997716, ; 131: System.Diagnostics.DiagnosticSource.dll => 0x79174bd613173454 => 29
	i64 8853378295825400934, ; 132: Xamarin.Kotlin.StdLib.Common.dll => 0x7add84a720d38466 => 109
	i64 8951477988056063522, ; 133: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0x7c3a09cd9ccf5e22 => 83
	i64 9057635389615298436, ; 134: LiteDB => 0x7db32f65bf06d784 => 9
	i64 9296667808972889535, ; 135: LiteDB.dll => 0x8104661dcca35dbf => 9
	i64 9312692141327339315, ; 136: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 95
	i64 9324707631942237306, ; 137: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 44
	i64 9662334977499516867, ; 138: System.Numerics.dll => 0x8617827802b0cfc3 => 33
	i64 9678050649315576968, ; 139: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 55
	i64 9711637524876806384, ; 140: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 76
	i64 9808709177481450983, ; 141: Mono.Android.dll => 0x881f890734e555e7 => 19
	i64 9825649861376906464, ; 142: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 52
	i64 9834056768316610435, ; 143: System.Transactions.dll => 0x8879968718899783 => 116
	i64 9875200773399460291, ; 144: Xamarin.GooglePlayServices.Base.dll => 0x890bc2c8482339c3 => 104
	i64 9998632235833408227, ; 145: Mono.Security => 0x8ac2470b209ebae3 => 124
	i64 10038780035334861115, ; 146: System.Net.Http.dll => 0x8b50e941206af13b => 32
	i64 10144742755892837524, ; 147: Firebase => 0x8cc95dc98eb5bc94 => 6
	i64 10226222362177979215, ; 148: Xamarin.Kotlin.StdLib.Jdk7 => 0x8dead70ebbc6434f => 111
	i64 10229024438826829339, ; 149: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 59
	i64 10318047534812931528, ; 150: Xamarin.AndroidX.Biometric.dll => 0x8f311190c81ea5c8 => 48
	i64 10321854143672141184, ; 151: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 108
	i64 10376576884623852283, ; 152: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 89
	i64 10406448008575299332, ; 153: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 114
	i64 10430153318873392755, ; 154: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 57
	i64 10847732767863316357, ; 155: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 45
	i64 11002576679268595294, ; 156: Microsoft.Extensions.Logging.Abstractions => 0x98b1013215cd365e => 15
	i64 11023048688141570732, ; 157: System.Core => 0x98f9bc61168392ac => 28
	i64 11037814507248023548, ; 158: System.Xml => 0x992e31d0412bf7fc => 38
	i64 11122995063473561350, ; 159: Xamarin.CommunityToolkit.dll => 0x9a5cd113fcc3df06 => 96
	i64 11162124722117608902, ; 160: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 94
	i64 11226290749488709958, ; 161: Microsoft.Extensions.Options.dll => 0x9bcbcbf50c874146 => 17
	i64 11340910727871153756, ; 162: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 58
	i64 11392833485892708388, ; 163: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 82
	i64 11529969570048099689, ; 164: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 94
	i64 11530571088791430846, ; 165: Microsoft.Extensions.Logging => 0xa004d1504ccd66be => 16
	i64 11578238080964724296, ; 166: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 67
	i64 11580057168383206117, ; 167: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 41
	i64 11591352189662810718, ; 168: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0xa0dcc167234c525e => 87
	i64 11597940890313164233, ; 169: netstandard => 0xa0f429ca8d1805c9 => 1
	i64 11672361001936329215, ; 170: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 64
	i64 11920918321499785284, ; 171: F1MobileApp => 0xa56f9c0dbd70c844 => 4
	i64 12080542886298039060, ; 172: F1MobileApp.Android.dll => 0xa7a6b5bfe7aab314 => 0
	i64 12102847907131387746, ; 173: System.Buffers => 0xa7f5f40c43256f62 => 27
	i64 12137774235383566651, ; 174: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 92
	i64 12403667497883933216, ; 175: F1MobileApp.Android => 0xac22addf336e1a20 => 0
	i64 12451044538927396471, ; 176: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 63
	i64 12466513435562512481, ; 177: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 74
	i64 12487638416075308985, ; 178: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 60
	i64 12528155905152483962, ; 179: Firebase.Auth => 0xaddcf36b3153827a => 5
	i64 12538491095302438457, ; 180: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 50
	i64 12550732019250633519, ; 181: System.IO.Compression => 0xae2d28465e8e1b2f => 119
	i64 12700543734426720211, ; 182: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 51
	i64 12828192437253469131, ; 183: Xamarin.Kotlin.StdLib.Jdk8.dll => 0xb206e50e14d873cb => 112
	i64 12843321153144804894, ; 184: Microsoft.Extensions.Primitives => 0xb23ca48abd74d61e => 18
	i64 12963446364377008305, ; 185: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 118
	i64 13370592475155966277, ; 186: System.Runtime.Serialization => 0xb98de304062ea945 => 3
	i64 13401370062847626945, ; 187: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 92
	i64 13403416310143541304, ; 188: Microcharts.Droid => 0xba02801ea6c86038 => 11
	i64 13404347523447273790, ; 189: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 53
	i64 13454009404024712428, ; 190: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 103
	i64 13465488254036897740, ; 191: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 110
	i64 13491513212026656886, ; 192: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 46
	i64 13492263892638604996, ; 193: SkiaSharp.Views.Forms.dll => 0xbb3e2686788d9ec4 => 26
	i64 13572454107664307259, ; 194: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 84
	i64 13647894001087880694, ; 195: System.Data.dll => 0xbd670f48cb071df6 => 115
	i64 13828521679616088467, ; 196: Xamarin.Kotlin.StdLib.Common => 0xbfe8c733724e1993 => 109
	i64 13959074834287824816, ; 197: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 63
	i64 13967638549803255703, ; 198: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 99
	i64 14124974489674258913, ; 199: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 50
	i64 14172845254133543601, ; 200: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 77
	i64 14261073672896646636, ; 201: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 82
	i64 14486659737292545672, ; 202: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 70
	i64 14644440854989303794, ; 203: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 75
	i64 14669215534098758659, ; 204: Microsoft.Extensions.DependencyInjection.dll => 0xcb9385ceb3993c03 => 14
	i64 14678510994762383812, ; 205: Xamarin.GooglePlayServices.Location.dll => 0xcbb48bfaca7a41c4 => 106
	i64 14792063746108907174, ; 206: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 103
	i64 14852515768018889994, ; 207: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 58
	i64 14954917835170835695, ; 208: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xcf8a8a895a82ecef => 13
	i64 14987728460634540364, ; 209: System.IO.Compression.dll => 0xcfff1ba06622494c => 119
	i64 14988210264188246988, ; 210: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 60
	i64 15150743910298169673, ; 211: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xd2424150783c3149 => 83
	i64 15279429628684179188, ; 212: Xamarin.KotlinX.Coroutines.Android.dll => 0xd40b704b1c4c96f4 => 113
	i64 15370334346939861994, ; 213: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 57
	i64 15391712275433856905, ; 214: Microsoft.Extensions.DependencyInjection.Abstractions => 0xd59a58c406411f89 => 13
	i64 15540815214206815676, ; 215: Plugin.Fingerprint.dll => 0xd7ac11193ac88dbc => 22
	i64 15582737692548360875, ; 216: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 73
	i64 15609085926864131306, ; 217: System.dll => 0xd89e9cf3334914ea => 30
	i64 15777549416145007739, ; 218: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 86
	i64 15810740023422282496, ; 219: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 101
	i64 15930129725311349754, ; 220: Xamarin.GooglePlayServices.Tasks.dll => 0xdd1330956f12f3fa => 107
	i64 16154507427712707110, ; 221: System => 0xe03056ea4e39aa26 => 30
	i64 16321164108206115771, ; 222: Microsoft.Extensions.Logging.Abstractions.dll => 0xe2806c487e7b0bbb => 15
	i64 16324796876805858114, ; 223: SkiaSharp.dll => 0xe28d5444586b6342 => 24
	i64 16423015068819898779, ; 224: Xamarin.Kotlin.StdLib.Jdk8 => 0xe3ea453135e5c19b => 112
	i64 16565028646146589191, ; 225: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 121
	i64 16621146507174665210, ; 226: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 54
	i64 16677317093839702854, ; 227: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 80
	i64 16822611501064131242, ; 228: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 117
	i64 16833383113903931215, ; 229: mscorlib => 0xe99c30c1484d7f4f => 20
	i64 16866861824412579935, ; 230: System.Runtime.InteropServices.WindowsRuntime => 0xea132176ffb5785f => 2
	i64 17001062948826229159, ; 231: Microcharts.Forms.dll => 0xebefe8ad2cd7a9a7 => 12
	i64 17024911836938395553, ; 232: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 42
	i64 17031351772568316411, ; 233: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 78
	i64 17037200463775726619, ; 234: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 66
	i64 17544493274320527064, ; 235: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 47
	i64 17671790519499593115, ; 236: SkiaSharp.Views.Android => 0xf53ecfd92be3959b => 25
	i64 17704177640604968747, ; 237: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 74
	i64 17710060891934109755, ; 238: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 72
	i64 17838668724098252521, ; 239: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 27
	i64 17882897186074144999, ; 240: FormsViewGroup => 0xf82cd03e3ac830e7 => 7
	i64 17891337867145587222, ; 241: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 108
	i64 17892495832318972303, ; 242: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 101
	i64 17928294245072900555, ; 243: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 120
	i64 17986907704309214542, ; 244: Xamarin.GooglePlayServices.Basement.dll => 0xf99e554223166d4e => 105
	i64 18116111925905154859, ; 245: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 46
	i64 18121036031235206392, ; 246: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 78
	i64 18129453464017766560, ; 247: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 123
	i64 18305135509493619199, ; 248: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 79
	i64 18380184030268848184 ; 249: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 93
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [250 x i32] [
	i32 62, i32 23, i32 18, i32 19, i32 11, i32 51, i32 85, i32 86, ; 0..7
	i32 56, i32 106, i32 35, i32 71, i32 104, i32 118, i32 65, i32 61, ; 8..15
	i32 12, i32 116, i32 100, i32 124, i32 102, i32 45, i32 10, i32 3, ; 16..23
	i32 43, i32 73, i32 66, i32 21, i32 31, i32 44, i32 85, i32 41, ; 24..31
	i32 72, i32 96, i32 111, i32 21, i32 77, i32 49, i32 61, i32 122, ; 32..39
	i32 69, i32 36, i32 55, i32 91, i32 37, i32 40, i32 38, i32 20, ; 40..47
	i32 14, i32 81, i32 36, i32 87, i32 98, i32 102, i32 10, i32 68, ; 48..55
	i32 42, i32 34, i32 114, i32 105, i32 89, i32 88, i32 33, i32 37, ; 56..63
	i32 1, i32 84, i32 62, i32 16, i32 31, i32 56, i32 107, i32 48, ; 64..71
	i32 123, i32 93, i32 47, i32 40, i32 88, i32 99, i32 97, i32 75, ; 72..79
	i32 76, i32 91, i32 90, i32 54, i32 28, i32 23, i32 95, i32 52, ; 80..87
	i32 81, i32 70, i32 22, i32 100, i32 7, i32 5, i32 71, i32 69, ; 88..95
	i32 49, i32 59, i32 17, i32 122, i32 65, i32 24, i32 4, i32 39, ; 96..103
	i32 34, i32 67, i32 64, i32 2, i32 39, i32 35, i32 98, i32 97, ; 104..111
	i32 32, i32 110, i32 115, i32 43, i32 25, i32 121, i32 68, i32 29, ; 112..119
	i32 117, i32 8, i32 26, i32 113, i32 53, i32 80, i32 90, i32 8, ; 120..127
	i32 79, i32 120, i32 6, i32 29, i32 109, i32 83, i32 9, i32 9, ; 128..135
	i32 95, i32 44, i32 33, i32 55, i32 76, i32 19, i32 52, i32 116, ; 136..143
	i32 104, i32 124, i32 32, i32 6, i32 111, i32 59, i32 48, i32 108, ; 144..151
	i32 89, i32 114, i32 57, i32 45, i32 15, i32 28, i32 38, i32 96, ; 152..159
	i32 94, i32 17, i32 58, i32 82, i32 94, i32 16, i32 67, i32 41, ; 160..167
	i32 87, i32 1, i32 64, i32 4, i32 0, i32 27, i32 92, i32 0, ; 168..175
	i32 63, i32 74, i32 60, i32 5, i32 50, i32 119, i32 51, i32 112, ; 176..183
	i32 18, i32 118, i32 3, i32 92, i32 11, i32 53, i32 103, i32 110, ; 184..191
	i32 46, i32 26, i32 84, i32 115, i32 109, i32 63, i32 99, i32 50, ; 192..199
	i32 77, i32 82, i32 70, i32 75, i32 14, i32 106, i32 103, i32 58, ; 200..207
	i32 13, i32 119, i32 60, i32 83, i32 113, i32 57, i32 13, i32 22, ; 208..215
	i32 73, i32 30, i32 86, i32 101, i32 107, i32 30, i32 15, i32 24, ; 216..223
	i32 112, i32 121, i32 54, i32 80, i32 117, i32 20, i32 2, i32 12, ; 224..231
	i32 42, i32 78, i32 66, i32 47, i32 25, i32 74, i32 72, i32 27, ; 232..239
	i32 7, i32 108, i32 101, i32 120, i32 105, i32 46, i32 78, i32 123, ; 240..247
	i32 79, i32 93 ; 248..249
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
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
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
