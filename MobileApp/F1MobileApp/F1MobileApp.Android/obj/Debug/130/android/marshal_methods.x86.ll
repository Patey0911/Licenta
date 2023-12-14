; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [348 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 112
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 145
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 42
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 140
	i32 99762151, ; 4: Syncfusion.Buttons.XForms.dll => 0x5f23fe7 => 51
	i32 101534019, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 128
	i32 120558881, ; 6: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 128
	i32 134690465, ; 7: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 153
	i32 165246403, ; 8: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 89
	i32 182336117, ; 9: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 130
	i32 196637014, ; 10: F1MobileApp.dll => 0xbb87156 => 13
	i32 207143798, ; 11: Microsoft.TestPlatform.CoreUtilities.resources.dll => 0xc58c376 => 0
	i32 209399409, ; 12: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 87
	i32 219130465, ; 13: Xamarin.Android.Support.v4 => 0xd0faa61 => 74
	i32 220171995, ; 14: System.Diagnostics.Debug => 0xd1f8edb => 170
	i32 230216969, ; 15: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 106
	i32 231814094, ; 16: System.Globalization => 0xdd133ce => 168
	i32 232815796, ; 17: System.Web.Services => 0xde07cb4 => 162
	i32 261689757, ; 18: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 92
	i32 278686392, ; 19: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 110
	i32 280482487, ; 20: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 104
	i32 287869112, ; 21: Syncfusion.SfChart.XForms.dll => 0x112888b8 => 56
	i32 317510438, ; 22: BottomBar.Droid.dll => 0x12ecd326 => 10
	i32 318968648, ; 23: Xamarin.AndroidX.Activity.dll => 0x13031348 => 78
	i32 321597661, ; 24: System.Numerics => 0x132b30dd => 64
	i32 342366114, ; 25: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 108
	i32 385762202, ; 26: System.Memory.dll => 0x16fe439a => 62
	i32 388313361, ; 27: Xamarin.Android.Support.Animated.Vector.Drawable => 0x17253111 => 72
	i32 393699800, ; 28: Firebase => 0x177761d8 => 15
	i32 441335492, ; 29: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 91
	i32 442521989, ; 30: Xamarin.Essentials => 0x1a605985 => 139
	i32 442565967, ; 31: System.Collections => 0x1a61054f => 165
	i32 450948140, ; 32: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 103
	i32 465846621, ; 33: mscorlib => 0x1bc4415d => 41
	i32 469710990, ; 34: System.dll => 0x1bff388e => 61
	i32 476646585, ; 35: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 104
	i32 486930444, ; 36: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 116
	i32 498788369, ; 37: System.ObjectModel => 0x1dbae811 => 164
	i32 504143952, ; 38: Plugin.LocalNotification.dll => 0x1e0ca050 => 46
	i32 513247710, ; 39: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 36
	i32 525008092, ; 40: SkiaSharp.dll => 0x1f4afcdc => 47
	i32 526420162, ; 41: System.Transactions.dll => 0x1f6088c2 => 161
	i32 527452488, ; 42: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 153
	i32 539058512, ; 43: Microsoft.Extensions.Logging => 0x20216150 => 34
	i32 539750087, ; 44: Xamarin.Android.Support.Design => 0x202beec7 => 73
	i32 545304856, ; 45: System.Runtime.Extensions => 0x2080b118 => 166
	i32 548916678, ; 46: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 30
	i32 571524804, ; 47: Xamarin.Android.Support.v7.RecyclerView => 0x2210c6c4 => 76
	i32 605376203, ; 48: System.IO.Compression.FileSystem => 0x24154ecb => 159
	i32 610194910, ; 49: System.Reactive.dll => 0x245ed5de => 66
	i32 627609679, ; 50: Xamarin.AndroidX.CustomView => 0x2568904f => 97
	i32 639843206, ; 51: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 102
	i32 656670485, ; 52: Microsoft.TestPlatform.PlatformAbstractions.dll => 0x2723ff15 => 38
	i32 663517072, ; 53: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 135
	i32 666292255, ; 54: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 83
	i32 690569205, ; 55: System.Xml.Linq.dll => 0x29293ff5 => 71
	i32 691348768, ; 56: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 155
	i32 700284507, ; 57: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 150
	i32 719061231, ; 58: Syncfusion.Core.XForms.dll => 0x2adc00ef => 53
	i32 720511267, ; 59: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 154
	i32 775507847, ; 60: System.IO.Compression => 0x2e394f87 => 158
	i32 789151979, ; 61: Microsoft.Extensions.Options => 0x2f0980eb => 35
	i32 791272004, ; 62: Plugin.InputKit => 0x2f29da44 => 45
	i32 809851609, ; 63: System.Drawing.Common.dll => 0x30455ad9 => 6
	i32 843511501, ; 64: Xamarin.AndroidX.Print => 0x3246f6cd => 123
	i32 857506242, ; 65: Microsoft.VisualStudio.TestPlatform.ObjectModel.dll => 0x331c81c2 => 39
	i32 877678880, ; 66: System.Globalization.dll => 0x34505120 => 168
	i32 882883187, ; 67: Xamarin.Android.Support.v4.dll => 0x349fba73 => 74
	i32 886248193, ; 68: Microcharts.Droid => 0x34d31301 => 28
	i32 912572698, ; 69: Xamarin.AndroidX.Biometric => 0x3664c11a => 86
	i32 928116545, ; 70: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 145
	i32 955402788, ; 71: Newtonsoft.Json => 0x38f24a24 => 42
	i32 956575887, ; 72: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 154
	i32 967690846, ; 73: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 108
	i32 974778368, ; 74: FormsViewGroup.dll => 0x3a19f000 => 17
	i32 992768348, ; 75: System.Collections.dll => 0x3b2c715c => 165
	i32 1012816738, ; 76: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 127
	i32 1028951442, ; 77: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 31
	i32 1035644815, ; 78: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 82
	i32 1042160112, ; 79: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 142
	i32 1052210849, ; 80: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 113
	i32 1080216999, ; 81: BottomBar.XamarinForms.dll => 0x4062cda7 => 11
	i32 1084122840, ; 82: Xamarin.Kotlin.StdLib => 0x409e66d8 => 152
	i32 1098259244, ; 83: System => 0x41761b2c => 61
	i32 1175144683, ; 84: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 133
	i32 1178241025, ; 85: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 120
	i32 1204270330, ; 86: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 83
	i32 1253011324, ; 87: Microsoft.Win32.Registry => 0x4aaf6f7c => 172
	i32 1264511973, ; 88: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 129
	i32 1267360935, ; 89: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 134
	i32 1275534314, ; 90: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 155
	i32 1289200857, ; 91: Microsoft.TestPlatform.PlatformAbstractions => 0x4cd7a4d9 => 38
	i32 1293217323, ; 92: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 99
	i32 1324164729, ; 93: System.Linq => 0x4eed2679 => 167
	i32 1359785034, ; 94: Xamarin.Android.Support.Design.dll => 0x510cac4a => 73
	i32 1365406463, ; 95: System.ServiceModel.Internals.dll => 0x516272ff => 163
	i32 1376866003, ; 96: Xamarin.AndroidX.SavedState => 0x52114ed3 => 127
	i32 1379779777, ; 97: System.Resources.ResourceManager => 0x523dc4c1 => 5
	i32 1382826005, ; 98: Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll => 0x526c4015 => 1
	i32 1395857551, ; 99: Xamarin.AndroidX.Media.dll => 0x5333188f => 117
	i32 1406073936, ; 100: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 93
	i32 1411638395, ; 101: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 68
	i32 1455549312, ; 102: LiveCharts => 0x56c1eb80 => 26
	i32 1457743152, ; 103: System.Runtime.Extensions.dll => 0x56e36530 => 166
	i32 1460219004, ; 104: Xamarin.Forms.Xaml => 0x57092c7c => 143
	i32 1461234159, ; 105: System.Collections.Immutable.dll => 0x5718a9ef => 58
	i32 1462112819, ; 106: System.IO.Compression.dll => 0x57261233 => 158
	i32 1469204771, ; 107: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 81
	i32 1470490898, ; 108: Microsoft.Extensions.Primitives => 0x57a5e912 => 36
	i32 1479771757, ; 109: System.Collections.Immutable => 0x5833866d => 58
	i32 1516315406, ; 110: Syncfusion.Core.XForms.Android.dll => 0x5a61230e => 52
	i32 1520711082, ; 111: Syncfusion.SfChart.XForms.Android.dll => 0x5aa435aa => 55
	i32 1522693535, ; 112: F1MobileApp => 0x5ac2759f => 13
	i32 1524747670, ; 113: Plugin.LocalNotification => 0x5ae1cd96 => 46
	i32 1580996379, ; 114: Google.Apis.Auth.PlatformServices => 0x5e3c171b => 21
	i32 1582372066, ; 115: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 98
	i32 1582526884, ; 116: Microcharts.Forms.dll => 0x5e5371a4 => 29
	i32 1592978981, ; 117: System.Runtime.Serialization.dll => 0x5ef2ee25 => 9
	i32 1622152042, ; 118: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 115
	i32 1624863272, ; 119: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 137
	i32 1635184631, ; 120: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 102
	i32 1636350590, ; 121: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 96
	i32 1639515021, ; 122: System.Net.Http.dll => 0x61b9038d => 63
	i32 1657153582, ; 123: System.Runtime => 0x62c6282e => 69
	i32 1658241508, ; 124: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 131
	i32 1658251792, ; 125: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 144
	i32 1662014763, ; 126: Xamarin.Android.Support.Vector.Drawable => 0x6310552b => 77
	i32 1670060433, ; 127: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 92
	i32 1691477237, ; 128: System.Reflection.Metadata => 0x64d1e4f5 => 67
	i32 1698840827, ; 129: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 151
	i32 1701541528, ; 130: System.Diagnostics.Debug.dll => 0x656b7698 => 170
	i32 1722051300, ; 131: SkiaSharp.Views.Forms => 0x66a46ae4 => 49
	i32 1726116996, ; 132: System.Reflection.dll => 0x66e27484 => 171
	i32 1729485958, ; 133: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 88
	i32 1731089870, ; 134: BottomBar.XamarinForms => 0x672e55ce => 11
	i32 1766324549, ; 135: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 130
	i32 1770582343, ; 136: Microsoft.Extensions.Logging.dll => 0x6988f147 => 34
	i32 1776026572, ; 137: System.Core.dll => 0x69dc03cc => 59
	i32 1788241197, ; 138: Xamarin.AndroidX.Fragment => 0x6a96652d => 103
	i32 1796167890, ; 139: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 30
	i32 1808609942, ; 140: Xamarin.AndroidX.Loader => 0x6bcd3296 => 115
	i32 1813058853, ; 141: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 152
	i32 1813201214, ; 142: Xamarin.Google.Android.Material => 0x6c13413e => 144
	i32 1818569960, ; 143: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 121
	i32 1828688058, ; 144: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 33
	i32 1867746548, ; 145: Xamarin.Essentials.dll => 0x6f538cf4 => 139
	i32 1877418711, ; 146: Xamarin.Android.Support.v7.RecyclerView.dll => 0x6fe722d7 => 76
	i32 1878053835, ; 147: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 143
	i32 1885316902, ; 148: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 84
	i32 1889954781, ; 149: System.Reflection.Metadata.dll => 0x70a66bdd => 67
	i32 1900610850, ; 150: System.Resources.ResourceManager.dll => 0x71490522 => 5
	i32 1904755420, ; 151: System.Runtime.InteropServices.WindowsRuntime.dll => 0x718842dc => 8
	i32 1908813208, ; 152: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 147
	i32 1919157823, ; 153: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 118
	i32 1983156543, ; 154: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 151
	i32 2011961780, ; 155: System.Buffers.dll => 0x77ec19b4 => 57
	i32 2019465201, ; 156: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 113
	i32 2055257422, ; 157: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 109
	i32 2071563619, ; 158: Syncfusion.Buttons.XForms.Android => 0x7b798d63 => 50
	i32 2079903147, ; 159: System.Runtime.dll => 0x7bf8cdab => 69
	i32 2090596640, ; 160: System.Numerics.Vectors => 0x7c9bf920 => 65
	i32 2097448633, ; 161: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 105
	i32 2113414696, ; 162: F1MobileApp.Android.dll => 0x7df82628 => 2
	i32 2126786730, ; 163: Xamarin.Forms.Platform.Android => 0x7ec430aa => 141
	i32 2129483829, ; 164: Xamarin.GooglePlayServices.Base.dll => 0x7eed5835 => 146
	i32 2133113917, ; 165: Syncfusion.SfChart.XForms => 0x7f24bc3d => 56
	i32 2181898931, ; 166: Microsoft.Extensions.Options.dll => 0x820d22b3 => 35
	i32 2192057212, ; 167: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 33
	i32 2193016926, ; 168: System.ObjectModel.dll => 0x82b6c85e => 164
	i32 2201107256, ; 169: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 156
	i32 2201231467, ; 170: System.Net.Http => 0x8334206b => 63
	i32 2216717168, ; 171: Firebase.Auth.dll => 0x84206b70 => 14
	i32 2217644978, ; 172: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 133
	i32 2244775296, ; 173: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 116
	i32 2256548716, ; 174: Xamarin.AndroidX.MultiDex => 0x8680336c => 118
	i32 2261435625, ; 175: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 107
	i32 2279755925, ; 176: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 125
	i32 2305641583, ; 177: Microsoft.TestPlatform.CoreUtilities => 0x896d4c6f => 37
	i32 2315684594, ; 178: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 79
	i32 2343171156, ; 179: Syncfusion.Core.XForms => 0x8ba9f454 => 53
	i32 2354730003, ; 180: Syncfusion.Licensing => 0x8c5a5413 => 54
	i32 2403452196, ; 181: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 101
	i32 2409053734, ; 182: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 122
	i32 2428790861, ; 183: Plugin.Fingerprint => 0x90c4684d => 44
	i32 2459433988, ; 184: Microsoft.TestPlatform.CoreUtilities.resources => 0x9297fc04 => 0
	i32 2465532216, ; 185: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 91
	i32 2471841756, ; 186: netstandard.dll => 0x93554fdc => 3
	i32 2475788418, ; 187: Java.Interop.dll => 0x93918882 => 24
	i32 2483946094, ; 188: Plugin.Fingerprint.dll => 0x940e026e => 44
	i32 2486847491, ; 189: Google.Api.Gax => 0x943a4803 => 18
	i32 2501346920, ; 190: System.Data.DataSetExtensions => 0x95178668 => 157
	i32 2505896520, ; 191: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 112
	i32 2522193584, ; 192: F1MobileApp.Android => 0x96559eb0 => 2
	i32 2526443681, ; 193: Xamarin.AndroidX.Biometric.dll => 0x969678a1 => 86
	i32 2581819634, ; 194: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 134
	i32 2595928349, ; 195: FirebaseAdmin => 0x9abab91d => 16
	i32 2599287763, ; 196: BottomNavigationBar => 0x9aedfbd3 => 12
	i32 2600501332, ; 197: NuGet.Frameworks.dll => 0x9b008054 => 43
	i32 2605712449, ; 198: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 156
	i32 2613717964, ; 199: Microsoft.VisualStudio.TestPlatform.ObjectModel => 0x9bca2bcc => 39
	i32 2620871830, ; 200: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 96
	i32 2624644809, ; 201: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 100
	i32 2624721879, ; 202: Syncfusion.SfChart.XForms.Android => 0x9c7213d7 => 55
	i32 2629053246, ; 203: Google.Api.Gax.Rest => 0x9cb42b3e => 19
	i32 2633051222, ; 204: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 110
	i32 2635300604, ; 205: Syncfusion.Buttons.XForms => 0x9d137efc => 51
	i32 2701096212, ; 206: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 131
	i32 2732626843, ; 207: Xamarin.AndroidX.Activity => 0xa2e0939b => 78
	i32 2736712847, ; 208: Microsoft.VisualStudio.TestPlatform.ObjectModel.resources => 0xa31eec8f => 1
	i32 2737747696, ; 209: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 81
	i32 2766581644, ; 210: Xamarin.Forms.Core => 0xa4e6af8c => 140
	i32 2770495804, ; 211: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 150
	i32 2778768386, ; 212: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 136
	i32 2779977773, ; 213: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 126
	i32 2795602088, ; 214: SkiaSharp.Views.Android.dll => 0xa6a180a8 => 48
	i32 2810250172, ; 215: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 93
	i32 2819470561, ; 216: System.Xml.dll => 0xa80db4e1 => 70
	i32 2821294376, ; 217: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 126
	i32 2847418871, ; 218: Xamarin.GooglePlayServices.Base => 0xa9b829f7 => 146
	i32 2853208004, ; 219: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 136
	i32 2855708567, ; 220: Xamarin.AndroidX.Transition => 0xaa36a797 => 132
	i32 2868557005, ; 221: Syncfusion.Licensing.dll => 0xaafab4cd => 54
	i32 2874148507, ; 222: Syncfusion.Core.XForms.Android => 0xab50069b => 52
	i32 2893550578, ; 223: Google.Apis.Core => 0xac7813f2 => 22
	i32 2901442782, ; 224: System.Reflection => 0xacf080de => 171
	i32 2903344695, ; 225: System.ComponentModel.Composition => 0xad0d8637 => 160
	i32 2905242038, ; 226: mscorlib.dll => 0xad2a79b6 => 41
	i32 2912489636, ; 227: SkiaSharp.Views.Android => 0xad9910a4 => 48
	i32 2916838712, ; 228: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 137
	i32 2919462931, ; 229: System.Numerics.Vectors.dll => 0xae037813 => 65
	i32 2921128767, ; 230: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 80
	i32 2922925221, ; 231: Xamarin.Android.Support.Vector.Drawable.dll => 0xae384ca5 => 77
	i32 2952707053, ; 232: NuGet.Frameworks => 0xaffebbed => 43
	i32 2974793899, ; 233: SkiaSharp.Views.Forms.dll => 0xb14fc0ab => 49
	i32 2978675010, ; 234: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 99
	i32 2990604888, ; 235: Google.Apis => 0xb2410258 => 23
	i32 2996846495, ; 236: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 111
	i32 3016983068, ; 237: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 129
	i32 3024354802, ; 238: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 106
	i32 3036068679, ; 239: Microcharts.Droid.dll => 0xb4f6bb47 => 28
	i32 3044182254, ; 240: FormsViewGroup => 0xb57288ee => 17
	i32 3057625584, ; 241: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 119
	i32 3058099980, ; 242: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 149
	i32 3111772706, ; 243: System.Runtime.Serialization => 0xb979e222 => 9
	i32 3124832203, ; 244: System.Threading.Tasks.Extensions => 0xba4127cb => 4
	i32 3130021562, ; 245: Google.Apis.Auth.PlatformServices.dll => 0xba9056ba => 21
	i32 3203277885, ; 246: Google.Api.Gax.dll => 0xbeee243d => 18
	i32 3204380047, ; 247: System.Data.dll => 0xbefef58f => 7
	i32 3211777861, ; 248: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 98
	i32 3220365878, ; 249: System.Threading => 0xbff2e236 => 169
	i32 3230466174, ; 250: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 147
	i32 3240169105, ; 251: LiveCharts.dll => 0xc1210e91 => 26
	i32 3247949154, ; 252: Mono.Security => 0xc197c562 => 173
	i32 3258312781, ; 253: Xamarin.AndroidX.CardView => 0xc235e84d => 88
	i32 3265893370, ; 254: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 4
	i32 3267021929, ; 255: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 85
	i32 3279906254, ; 256: Microsoft.Win32.Registry.dll => 0xc37f65ce => 172
	i32 3317135071, ; 257: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 97
	i32 3317144872, ; 258: System.Data => 0xc5b79d28 => 7
	i32 3322403133, ; 259: Firebase.dll => 0xc607d93d => 15
	i32 3340387945, ; 260: SkiaSharp => 0xc71a4669 => 47
	i32 3340431453, ; 261: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 84
	i32 3345895724, ; 262: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 124
	i32 3346324047, ; 263: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 120
	i32 3347520357, ; 264: BottomNavigationBar.dll => 0xc7871b65 => 12
	i32 3353484488, ; 265: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 105
	i32 3353544232, ; 266: Xamarin.CommunityToolkit.dll => 0xc7e30628 => 138
	i32 3362522851, ; 267: Xamarin.AndroidX.Core => 0xc86c06e3 => 95
	i32 3366347497, ; 268: Java.Interop => 0xc8a662e9 => 24
	i32 3374999561, ; 269: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 125
	i32 3395150330, ; 270: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 68
	i32 3404865022, ; 271: System.ServiceModel.Internals => 0xcaf21dfe => 163
	i32 3407215217, ; 272: Xamarin.CommunityToolkit => 0xcb15fa71 => 138
	i32 3428513518, ; 273: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 32
	i32 3429136800, ; 274: System.Xml => 0xcc6479a0 => 70
	i32 3430777524, ; 275: netstandard => 0xcc7d82b4 => 3
	i32 3434749838, ; 276: Syncfusion.Buttons.XForms.Android.dll => 0xccba1f8e => 50
	i32 3441283291, ; 277: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 100
	i32 3453592554, ; 278: Google.Apis.Core.dll => 0xcdd9a3ea => 22
	i32 3455791806, ; 279: Microcharts => 0xcdfb32be => 27
	i32 3476120550, ; 280: Mono.Android => 0xcf3163e6 => 40
	i32 3486566296, ; 281: System.Transactions => 0xcfd0c798 => 161
	i32 3493954962, ; 282: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 90
	i32 3494395880, ; 283: Xamarin.GooglePlayServices.Location.dll => 0xd0483fe8 => 148
	i32 3501239056, ; 284: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 85
	i32 3509114376, ; 285: System.Xml.Linq => 0xd128d608 => 71
	i32 3536029504, ; 286: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 141
	i32 3543600791, ; 287: Microsoft.TestPlatform.CoreUtilities.dll => 0xd3370e97 => 37
	i32 3567349600, ; 288: System.ComponentModel.Composition.dll => 0xd4a16f60 => 160
	i32 3570915604, ; 289: BottomBar.Droid => 0xd4d7d914 => 10
	i32 3596207933, ; 290: LiteDB.dll => 0xd659c73d => 25
	i32 3608519521, ; 291: System.Linq.dll => 0xd715a361 => 167
	i32 3618140916, ; 292: Xamarin.AndroidX.Preference => 0xd7a872f4 => 122
	i32 3621458322, ; 293: Google.Api.Gax.Rest.dll => 0xd7db1192 => 19
	i32 3627220390, ; 294: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 123
	i32 3629588173, ; 295: LiteDB => 0xd8571ecd => 25
	i32 3632359727, ; 296: Xamarin.Forms.Platform => 0xd881692f => 142
	i32 3633644679, ; 297: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 80
	i32 3641597786, ; 298: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 109
	i32 3668042751, ; 299: Microcharts.dll => 0xdaa1e3ff => 27
	i32 3672681054, ; 300: Mono.Android.dll => 0xdae8aa5e => 40
	i32 3676310014, ; 301: System.Web.Services.dll => 0xdb2009fe => 162
	i32 3678221644, ; 302: Xamarin.Android.Support.v7.AppCompat => 0xdb3d354c => 75
	i32 3682565725, ; 303: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 87
	i32 3684561358, ; 304: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 90
	i32 3684933406, ; 305: System.Runtime.InteropServices.WindowsRuntime => 0xdba39f1e => 8
	i32 3689375977, ; 306: System.Drawing.Common => 0xdbe768e9 => 6
	i32 3706696989, ; 307: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 94
	i32 3718463572, ; 308: Xamarin.Android.Support.Animated.Vector.Drawable.dll => 0xdda34054 => 72
	i32 3718780102, ; 309: Xamarin.AndroidX.Annotation => 0xdda814c6 => 79
	i32 3724971120, ; 310: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 119
	i32 3731644420, ; 311: System.Reactive => 0xde6c6004 => 66
	i32 3748608112, ; 312: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 60
	i32 3758932259, ; 313: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 107
	i32 3776811843, ; 314: Plugin.InputKit.dll => 0xe11d9343 => 45
	i32 3786282454, ; 315: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 89
	i32 3793997468, ; 316: Google.Apis.Auth.dll => 0xe223ce9c => 20
	i32 3822602673, ; 317: Xamarin.AndroidX.Media => 0xe3d849b1 => 117
	i32 3829621856, ; 318: System.Numerics.dll => 0xe4436460 => 64
	i32 3841636137, ; 319: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 31
	i32 3883175360, ; 320: Xamarin.Android.Support.v7.AppCompat.dll => 0xe7748dc0 => 75
	i32 3885922214, ; 321: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 132
	i32 3888767677, ; 322: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 124
	i32 3896760992, ; 323: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 95
	i32 3903721208, ; 324: Microcharts.Forms => 0xe8ae0ef8 => 29
	i32 3920810846, ; 325: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 159
	i32 3921031405, ; 326: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 135
	i32 3931092270, ; 327: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 121
	i32 3945713374, ; 328: System.Data.DataSetExtensions.dll => 0xeb2ecede => 157
	i32 3955647286, ; 329: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 82
	i32 3959773229, ; 330: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 111
	i32 3967165417, ; 331: Xamarin.GooglePlayServices.Location => 0xec7623e9 => 148
	i32 3970018735, ; 332: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 149
	i32 4024013275, ; 333: Firebase.Auth => 0xefd991db => 14
	i32 4025784931, ; 334: System.Memory => 0xeff49a63 => 62
	i32 4059682726, ; 335: Google.Apis.dll => 0xf1f9d7a6 => 23
	i32 4073602200, ; 336: System.Threading.dll => 0xf2ce3c98 => 169
	i32 4082882467, ; 337: Google.Apis.Auth => 0xf35bd7a3 => 20
	i32 4101593132, ; 338: Xamarin.AndroidX.Emoji2 => 0xf479582c => 101
	i32 4105002889, ; 339: Mono.Security.dll => 0xf4ad5f89 => 173
	i32 4126470640, ; 340: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 32
	i32 4151237749, ; 341: System.Core => 0xf76edc75 => 59
	i32 4177102269, ; 342: FirebaseAdmin.dll => 0xf8f985bd => 16
	i32 4182413190, ; 343: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 114
	i32 4213026141, ; 344: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 60
	i32 4256097574, ; 345: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 94
	i32 4260525087, ; 346: System.Buffers => 0xfdf2741f => 57
	i32 4292120959 ; 347: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 114
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [348 x i32] [
	i32 112, i32 145, i32 42, i32 140, i32 51, i32 128, i32 128, i32 153, ; 0..7
	i32 89, i32 130, i32 13, i32 0, i32 87, i32 74, i32 170, i32 106, ; 8..15
	i32 168, i32 162, i32 92, i32 110, i32 104, i32 56, i32 10, i32 78, ; 16..23
	i32 64, i32 108, i32 62, i32 72, i32 15, i32 91, i32 139, i32 165, ; 24..31
	i32 103, i32 41, i32 61, i32 104, i32 116, i32 164, i32 46, i32 36, ; 32..39
	i32 47, i32 161, i32 153, i32 34, i32 73, i32 166, i32 30, i32 76, ; 40..47
	i32 159, i32 66, i32 97, i32 102, i32 38, i32 135, i32 83, i32 71, ; 48..55
	i32 155, i32 150, i32 53, i32 154, i32 158, i32 35, i32 45, i32 6, ; 56..63
	i32 123, i32 39, i32 168, i32 74, i32 28, i32 86, i32 145, i32 42, ; 64..71
	i32 154, i32 108, i32 17, i32 165, i32 127, i32 31, i32 82, i32 142, ; 72..79
	i32 113, i32 11, i32 152, i32 61, i32 133, i32 120, i32 83, i32 172, ; 80..87
	i32 129, i32 134, i32 155, i32 38, i32 99, i32 167, i32 73, i32 163, ; 88..95
	i32 127, i32 5, i32 1, i32 117, i32 93, i32 68, i32 26, i32 166, ; 96..103
	i32 143, i32 58, i32 158, i32 81, i32 36, i32 58, i32 52, i32 55, ; 104..111
	i32 13, i32 46, i32 21, i32 98, i32 29, i32 9, i32 115, i32 137, ; 112..119
	i32 102, i32 96, i32 63, i32 69, i32 131, i32 144, i32 77, i32 92, ; 120..127
	i32 67, i32 151, i32 170, i32 49, i32 171, i32 88, i32 11, i32 130, ; 128..135
	i32 34, i32 59, i32 103, i32 30, i32 115, i32 152, i32 144, i32 121, ; 136..143
	i32 33, i32 139, i32 76, i32 143, i32 84, i32 67, i32 5, i32 8, ; 144..151
	i32 147, i32 118, i32 151, i32 57, i32 113, i32 109, i32 50, i32 69, ; 152..159
	i32 65, i32 105, i32 2, i32 141, i32 146, i32 56, i32 35, i32 33, ; 160..167
	i32 164, i32 156, i32 63, i32 14, i32 133, i32 116, i32 118, i32 107, ; 168..175
	i32 125, i32 37, i32 79, i32 53, i32 54, i32 101, i32 122, i32 44, ; 176..183
	i32 0, i32 91, i32 3, i32 24, i32 44, i32 18, i32 157, i32 112, ; 184..191
	i32 2, i32 86, i32 134, i32 16, i32 12, i32 43, i32 156, i32 39, ; 192..199
	i32 96, i32 100, i32 55, i32 19, i32 110, i32 51, i32 131, i32 78, ; 200..207
	i32 1, i32 81, i32 140, i32 150, i32 136, i32 126, i32 48, i32 93, ; 208..215
	i32 70, i32 126, i32 146, i32 136, i32 132, i32 54, i32 52, i32 22, ; 216..223
	i32 171, i32 160, i32 41, i32 48, i32 137, i32 65, i32 80, i32 77, ; 224..231
	i32 43, i32 49, i32 99, i32 23, i32 111, i32 129, i32 106, i32 28, ; 232..239
	i32 17, i32 119, i32 149, i32 9, i32 4, i32 21, i32 18, i32 7, ; 240..247
	i32 98, i32 169, i32 147, i32 26, i32 173, i32 88, i32 4, i32 85, ; 248..255
	i32 172, i32 97, i32 7, i32 15, i32 47, i32 84, i32 124, i32 120, ; 256..263
	i32 12, i32 105, i32 138, i32 95, i32 24, i32 125, i32 68, i32 163, ; 264..271
	i32 138, i32 32, i32 70, i32 3, i32 50, i32 100, i32 22, i32 27, ; 272..279
	i32 40, i32 161, i32 90, i32 148, i32 85, i32 71, i32 141, i32 37, ; 280..287
	i32 160, i32 10, i32 25, i32 167, i32 122, i32 19, i32 123, i32 25, ; 288..295
	i32 142, i32 80, i32 109, i32 27, i32 40, i32 162, i32 75, i32 87, ; 296..303
	i32 90, i32 8, i32 6, i32 94, i32 72, i32 79, i32 119, i32 66, ; 304..311
	i32 60, i32 107, i32 45, i32 89, i32 20, i32 117, i32 64, i32 31, ; 312..319
	i32 75, i32 132, i32 124, i32 95, i32 29, i32 159, i32 135, i32 121, ; 320..327
	i32 157, i32 82, i32 111, i32 148, i32 149, i32 14, i32 62, i32 23, ; 328..335
	i32 169, i32 20, i32 101, i32 173, i32 32, i32 59, i32 16, i32 114, ; 336..343
	i32 60, i32 94, i32 57, i32 114 ; 344..347
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
