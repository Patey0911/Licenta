; ModuleID = 'obj\Debug\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


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
@assembly_image_cache_hashes = local_unnamed_addr constant [314 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 101
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 134
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 38
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 129
	i32 101534019, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 117
	i32 120558881, ; 5: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 117
	i32 134690465, ; 6: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 142
	i32 165246403, ; 7: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 78
	i32 182336117, ; 8: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 119
	i32 196637014, ; 9: F1MobileApp.dll => 0xbb87156 => 10
	i32 207143798, ; 10: Microsoft.TestPlatform.CoreUtilities.resources.dll => 0xc58c376 => 0
	i32 209399409, ; 11: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 76
	i32 219130465, ; 12: Xamarin.Android.Support.v4 => 0xd0faa61 => 63
	i32 230216969, ; 13: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 95
	i32 232815796, ; 14: System.Web.Services => 0xde07cb4 => 153
	i32 261689757, ; 15: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 81
	i32 278686392, ; 16: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 99
	i32 280482487, ; 17: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 93
	i32 317510438, ; 18: BottomBar.Droid.dll => 0x12ecd326 => 7
	i32 318968648, ; 19: Xamarin.AndroidX.Activity.dll => 0x13031348 => 67
	i32 321597661, ; 20: System.Numerics => 0x132b30dd => 53
	i32 342366114, ; 21: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 97
	i32 385762202, ; 22: System.Memory.dll => 0x16fe439a => 51
	i32 388313361, ; 23: Xamarin.Android.Support.Animated.Vector.Drawable => 0x17253111 => 61
	i32 393699800, ; 24: Firebase => 0x177761d8 => 12
	i32 441335492, ; 25: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 80
	i32 442521989, ; 26: Xamarin.Essentials => 0x1a605985 => 128
	i32 450948140, ; 27: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 92
	i32 465846621, ; 28: mscorlib => 0x1bc4415d => 37
	i32 469710990, ; 29: System.dll => 0x1bff388e => 50
	i32 476646585, ; 30: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 93
	i32 486930444, ; 31: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 105
	i32 504143952, ; 32: Plugin.LocalNotification.dll => 0x1e0ca050 => 42
	i32 513247710, ; 33: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 32
	i32 525008092, ; 34: SkiaSharp.dll => 0x1f4afcdc => 43
	i32 526420162, ; 35: System.Transactions.dll => 0x1f6088c2 => 147
	i32 527452488, ; 36: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 142
	i32 539058512, ; 37: Microsoft.Extensions.Logging => 0x20216150 => 30
	i32 539750087, ; 38: Xamarin.Android.Support.Design => 0x202beec7 => 62
	i32 548916678, ; 39: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 26
	i32 571524804, ; 40: Xamarin.Android.Support.v7.RecyclerView => 0x2210c6c4 => 65
	i32 605376203, ; 41: System.IO.Compression.FileSystem => 0x24154ecb => 151
	i32 610194910, ; 42: System.Reactive.dll => 0x245ed5de => 55
	i32 627609679, ; 43: Xamarin.AndroidX.CustomView => 0x2568904f => 86
	i32 639843206, ; 44: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 91
	i32 656670485, ; 45: Microsoft.TestPlatform.PlatformAbstractions.dll => 0x2723ff15 => 34
	i32 663517072, ; 46: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 124
	i32 666292255, ; 47: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 72
	i32 690569205, ; 48: System.Xml.Linq.dll => 0x29293ff5 => 60
	i32 691348768, ; 49: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 144
	i32 700284507, ; 50: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 139
	i32 720511267, ; 51: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 143
	i32 775507847, ; 52: System.IO.Compression => 0x2e394f87 => 150
	i32 789151979, ; 53: Microsoft.Extensions.Options => 0x2f0980eb => 31
	i32 791272004, ; 54: Plugin.InputKit => 0x2f29da44 => 41
	i32 809851609, ; 55: System.Drawing.Common.dll => 0x30455ad9 => 149
	i32 843511501, ; 56: Xamarin.AndroidX.Print => 0x3246f6cd => 112
	i32 857506242, ; 57: Microsoft.VisualStudio.TestPlatform.ObjectModel.dll => 0x331c81c2 => 35
	i32 882883187, ; 58: Xamarin.Android.Support.v4.dll => 0x349fba73 => 63
	i32 886248193, ; 59: Microcharts.Droid => 0x34d31301 => 24
	i32 912572698, ; 60: Xamarin.AndroidX.Biometric => 0x3664c11a => 75
	i32 928116545, ; 61: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 134
	i32 955402788, ; 62: Newtonsoft.Json => 0x38f24a24 => 38
	i32 956575887, ; 63: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 143
	i32 967690846, ; 64: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 97
	i32 974778368, ; 65: FormsViewGroup.dll => 0x3a19f000 => 14
	i32 1012816738, ; 66: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 116
	i32 1028951442, ; 67: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 27
	i32 1035644815, ; 68: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 71
	i32 1042160112, ; 69: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 131
	i32 1052210849, ; 70: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 102
	i32 1080216999, ; 71: BottomBar.XamarinForms.dll => 0x4062cda7 => 8
	i32 1084122840, ; 72: Xamarin.Kotlin.StdLib => 0x409e66d8 => 141
	i32 1098259244, ; 73: System => 0x41761b2c => 50
	i32 1175144683, ; 74: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 122
	i32 1178241025, ; 75: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 109
	i32 1204270330, ; 76: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 72
	i32 1253011324, ; 77: Microsoft.Win32.Registry => 0x4aaf6f7c => 155
	i32 1264511973, ; 78: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 118
	i32 1267360935, ; 79: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 123
	i32 1275534314, ; 80: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 144
	i32 1289200857, ; 81: Microsoft.TestPlatform.PlatformAbstractions => 0x4cd7a4d9 => 34
	i32 1293217323, ; 82: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 88
	i32 1359785034, ; 83: Xamarin.Android.Support.Design.dll => 0x510cac4a => 62
	i32 1365406463, ; 84: System.ServiceModel.Internals.dll => 0x516272ff => 154
	i32 1376866003, ; 85: Xamarin.AndroidX.SavedState => 0x52114ed3 => 116
	i32 1382826005, ; 86: Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll => 0x526c4015 => 1
	i32 1395857551, ; 87: Xamarin.AndroidX.Media.dll => 0x5333188f => 106
	i32 1406073936, ; 88: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 82
	i32 1411638395, ; 89: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 57
	i32 1460219004, ; 90: Xamarin.Forms.Xaml => 0x57092c7c => 132
	i32 1461234159, ; 91: System.Collections.Immutable.dll => 0x5718a9ef => 47
	i32 1462112819, ; 92: System.IO.Compression.dll => 0x57261233 => 150
	i32 1469204771, ; 93: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 70
	i32 1470490898, ; 94: Microsoft.Extensions.Primitives => 0x57a5e912 => 32
	i32 1479771757, ; 95: System.Collections.Immutable => 0x5833866d => 47
	i32 1522693535, ; 96: F1MobileApp => 0x5ac2759f => 10
	i32 1524747670, ; 97: Plugin.LocalNotification => 0x5ae1cd96 => 42
	i32 1580996379, ; 98: Google.Apis.Auth.PlatformServices => 0x5e3c171b => 18
	i32 1582372066, ; 99: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 87
	i32 1582526884, ; 100: Microcharts.Forms.dll => 0x5e5371a4 => 25
	i32 1592978981, ; 101: System.Runtime.Serialization.dll => 0x5ef2ee25 => 6
	i32 1622152042, ; 102: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 104
	i32 1624863272, ; 103: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 126
	i32 1635184631, ; 104: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 91
	i32 1636350590, ; 105: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 85
	i32 1639515021, ; 106: System.Net.Http.dll => 0x61b9038d => 52
	i32 1657153582, ; 107: System.Runtime => 0x62c6282e => 58
	i32 1658241508, ; 108: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 120
	i32 1658251792, ; 109: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 133
	i32 1662014763, ; 110: Xamarin.Android.Support.Vector.Drawable => 0x6310552b => 66
	i32 1670060433, ; 111: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 81
	i32 1691477237, ; 112: System.Reflection.Metadata => 0x64d1e4f5 => 56
	i32 1698840827, ; 113: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 140
	i32 1722051300, ; 114: SkiaSharp.Views.Forms => 0x66a46ae4 => 45
	i32 1729485958, ; 115: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 77
	i32 1731089870, ; 116: BottomBar.XamarinForms => 0x672e55ce => 8
	i32 1766324549, ; 117: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 119
	i32 1770582343, ; 118: Microsoft.Extensions.Logging.dll => 0x6988f147 => 30
	i32 1776026572, ; 119: System.Core.dll => 0x69dc03cc => 48
	i32 1788241197, ; 120: Xamarin.AndroidX.Fragment => 0x6a96652d => 92
	i32 1796167890, ; 121: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 26
	i32 1808609942, ; 122: Xamarin.AndroidX.Loader => 0x6bcd3296 => 104
	i32 1813058853, ; 123: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 141
	i32 1813201214, ; 124: Xamarin.Google.Android.Material => 0x6c13413e => 133
	i32 1818569960, ; 125: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 110
	i32 1828688058, ; 126: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 29
	i32 1867746548, ; 127: Xamarin.Essentials.dll => 0x6f538cf4 => 128
	i32 1877418711, ; 128: Xamarin.Android.Support.v7.RecyclerView.dll => 0x6fe722d7 => 65
	i32 1878053835, ; 129: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 132
	i32 1885316902, ; 130: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 73
	i32 1889954781, ; 131: System.Reflection.Metadata.dll => 0x70a66bdd => 56
	i32 1904755420, ; 132: System.Runtime.InteropServices.WindowsRuntime.dll => 0x718842dc => 5
	i32 1908813208, ; 133: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 136
	i32 1919157823, ; 134: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 107
	i32 1983156543, ; 135: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 140
	i32 2011961780, ; 136: System.Buffers.dll => 0x77ec19b4 => 46
	i32 2019465201, ; 137: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 102
	i32 2055257422, ; 138: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 98
	i32 2079903147, ; 139: System.Runtime.dll => 0x7bf8cdab => 58
	i32 2090596640, ; 140: System.Numerics.Vectors => 0x7c9bf920 => 54
	i32 2097448633, ; 141: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 94
	i32 2113414696, ; 142: F1MobileApp.Android.dll => 0x7df82628 => 2
	i32 2126786730, ; 143: Xamarin.Forms.Platform.Android => 0x7ec430aa => 130
	i32 2129483829, ; 144: Xamarin.GooglePlayServices.Base.dll => 0x7eed5835 => 135
	i32 2181898931, ; 145: Microsoft.Extensions.Options.dll => 0x820d22b3 => 31
	i32 2192057212, ; 146: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 29
	i32 2201107256, ; 147: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 145
	i32 2201231467, ; 148: System.Net.Http => 0x8334206b => 52
	i32 2216717168, ; 149: Firebase.Auth.dll => 0x84206b70 => 11
	i32 2217644978, ; 150: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 122
	i32 2244775296, ; 151: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 105
	i32 2256548716, ; 152: Xamarin.AndroidX.MultiDex => 0x8680336c => 107
	i32 2261435625, ; 153: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 96
	i32 2279755925, ; 154: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 114
	i32 2305641583, ; 155: Microsoft.TestPlatform.CoreUtilities => 0x896d4c6f => 33
	i32 2315684594, ; 156: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 68
	i32 2403452196, ; 157: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 90
	i32 2409053734, ; 158: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 111
	i32 2428790861, ; 159: Plugin.Fingerprint => 0x90c4684d => 40
	i32 2459433988, ; 160: Microsoft.TestPlatform.CoreUtilities.resources => 0x9297fc04 => 0
	i32 2465532216, ; 161: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 80
	i32 2471841756, ; 162: netstandard.dll => 0x93554fdc => 3
	i32 2475788418, ; 163: Java.Interop.dll => 0x93918882 => 21
	i32 2483946094, ; 164: Plugin.Fingerprint.dll => 0x940e026e => 40
	i32 2486847491, ; 165: Google.Api.Gax => 0x943a4803 => 15
	i32 2501346920, ; 166: System.Data.DataSetExtensions => 0x95178668 => 148
	i32 2505896520, ; 167: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 101
	i32 2522193584, ; 168: F1MobileApp.Android => 0x96559eb0 => 2
	i32 2526443681, ; 169: Xamarin.AndroidX.Biometric.dll => 0x969678a1 => 75
	i32 2581819634, ; 170: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 123
	i32 2595928349, ; 171: FirebaseAdmin => 0x9abab91d => 13
	i32 2599287763, ; 172: BottomNavigationBar => 0x9aedfbd3 => 9
	i32 2600501332, ; 173: NuGet.Frameworks.dll => 0x9b008054 => 39
	i32 2605712449, ; 174: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 145
	i32 2613717964, ; 175: Microsoft.VisualStudio.TestPlatform.ObjectModel => 0x9bca2bcc => 35
	i32 2620871830, ; 176: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 85
	i32 2624644809, ; 177: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 89
	i32 2629053246, ; 178: Google.Api.Gax.Rest => 0x9cb42b3e => 16
	i32 2633051222, ; 179: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 99
	i32 2701096212, ; 180: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 120
	i32 2732626843, ; 181: Xamarin.AndroidX.Activity => 0xa2e0939b => 67
	i32 2736712847, ; 182: Microsoft.VisualStudio.TestPlatform.ObjectModel.resources => 0xa31eec8f => 1
	i32 2737747696, ; 183: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 70
	i32 2766581644, ; 184: Xamarin.Forms.Core => 0xa4e6af8c => 129
	i32 2770495804, ; 185: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 139
	i32 2778768386, ; 186: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 125
	i32 2779977773, ; 187: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 115
	i32 2795602088, ; 188: SkiaSharp.Views.Android.dll => 0xa6a180a8 => 44
	i32 2810250172, ; 189: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 82
	i32 2819470561, ; 190: System.Xml.dll => 0xa80db4e1 => 59
	i32 2821294376, ; 191: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 115
	i32 2847418871, ; 192: Xamarin.GooglePlayServices.Base => 0xa9b829f7 => 135
	i32 2853208004, ; 193: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 125
	i32 2855708567, ; 194: Xamarin.AndroidX.Transition => 0xaa36a797 => 121
	i32 2893550578, ; 195: Google.Apis.Core => 0xac7813f2 => 19
	i32 2903344695, ; 196: System.ComponentModel.Composition => 0xad0d8637 => 152
	i32 2905242038, ; 197: mscorlib.dll => 0xad2a79b6 => 37
	i32 2912489636, ; 198: SkiaSharp.Views.Android => 0xad9910a4 => 44
	i32 2916838712, ; 199: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 126
	i32 2919462931, ; 200: System.Numerics.Vectors.dll => 0xae037813 => 54
	i32 2921128767, ; 201: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 69
	i32 2922925221, ; 202: Xamarin.Android.Support.Vector.Drawable.dll => 0xae384ca5 => 66
	i32 2952707053, ; 203: NuGet.Frameworks => 0xaffebbed => 39
	i32 2974793899, ; 204: SkiaSharp.Views.Forms.dll => 0xb14fc0ab => 45
	i32 2978675010, ; 205: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 88
	i32 2990604888, ; 206: Google.Apis => 0xb2410258 => 20
	i32 2996846495, ; 207: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 100
	i32 3016983068, ; 208: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 118
	i32 3024354802, ; 209: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 95
	i32 3036068679, ; 210: Microcharts.Droid.dll => 0xb4f6bb47 => 24
	i32 3044182254, ; 211: FormsViewGroup => 0xb57288ee => 14
	i32 3057625584, ; 212: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 108
	i32 3058099980, ; 213: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 138
	i32 3111772706, ; 214: System.Runtime.Serialization => 0xb979e222 => 6
	i32 3124832203, ; 215: System.Threading.Tasks.Extensions => 0xba4127cb => 4
	i32 3130021562, ; 216: Google.Apis.Auth.PlatformServices.dll => 0xba9056ba => 18
	i32 3203277885, ; 217: Google.Api.Gax.dll => 0xbeee243d => 15
	i32 3204380047, ; 218: System.Data.dll => 0xbefef58f => 146
	i32 3211777861, ; 219: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 87
	i32 3230466174, ; 220: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 136
	i32 3247949154, ; 221: Mono.Security => 0xc197c562 => 156
	i32 3258312781, ; 222: Xamarin.AndroidX.CardView => 0xc235e84d => 77
	i32 3265893370, ; 223: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 4
	i32 3267021929, ; 224: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 74
	i32 3279906254, ; 225: Microsoft.Win32.Registry.dll => 0xc37f65ce => 155
	i32 3317135071, ; 226: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 86
	i32 3317144872, ; 227: System.Data => 0xc5b79d28 => 146
	i32 3322403133, ; 228: Firebase.dll => 0xc607d93d => 12
	i32 3340387945, ; 229: SkiaSharp => 0xc71a4669 => 43
	i32 3340431453, ; 230: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 73
	i32 3345895724, ; 231: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 113
	i32 3346324047, ; 232: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 109
	i32 3347520357, ; 233: BottomNavigationBar.dll => 0xc7871b65 => 9
	i32 3353484488, ; 234: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 94
	i32 3353544232, ; 235: Xamarin.CommunityToolkit.dll => 0xc7e30628 => 127
	i32 3362522851, ; 236: Xamarin.AndroidX.Core => 0xc86c06e3 => 84
	i32 3366347497, ; 237: Java.Interop => 0xc8a662e9 => 21
	i32 3374999561, ; 238: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 114
	i32 3395150330, ; 239: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 57
	i32 3404865022, ; 240: System.ServiceModel.Internals => 0xcaf21dfe => 154
	i32 3407215217, ; 241: Xamarin.CommunityToolkit => 0xcb15fa71 => 127
	i32 3428513518, ; 242: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 28
	i32 3429136800, ; 243: System.Xml => 0xcc6479a0 => 59
	i32 3430777524, ; 244: netstandard => 0xcc7d82b4 => 3
	i32 3441283291, ; 245: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 89
	i32 3453592554, ; 246: Google.Apis.Core.dll => 0xcdd9a3ea => 19
	i32 3455791806, ; 247: Microcharts => 0xcdfb32be => 23
	i32 3476120550, ; 248: Mono.Android => 0xcf3163e6 => 36
	i32 3486566296, ; 249: System.Transactions => 0xcfd0c798 => 147
	i32 3493954962, ; 250: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 79
	i32 3494395880, ; 251: Xamarin.GooglePlayServices.Location.dll => 0xd0483fe8 => 137
	i32 3501239056, ; 252: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 74
	i32 3509114376, ; 253: System.Xml.Linq => 0xd128d608 => 60
	i32 3536029504, ; 254: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 130
	i32 3543600791, ; 255: Microsoft.TestPlatform.CoreUtilities.dll => 0xd3370e97 => 33
	i32 3567349600, ; 256: System.ComponentModel.Composition.dll => 0xd4a16f60 => 152
	i32 3570915604, ; 257: BottomBar.Droid => 0xd4d7d914 => 7
	i32 3596207933, ; 258: LiteDB.dll => 0xd659c73d => 22
	i32 3618140916, ; 259: Xamarin.AndroidX.Preference => 0xd7a872f4 => 111
	i32 3621458322, ; 260: Google.Api.Gax.Rest.dll => 0xd7db1192 => 16
	i32 3627220390, ; 261: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 112
	i32 3629588173, ; 262: LiteDB => 0xd8571ecd => 22
	i32 3632359727, ; 263: Xamarin.Forms.Platform => 0xd881692f => 131
	i32 3633644679, ; 264: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 69
	i32 3641597786, ; 265: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 98
	i32 3668042751, ; 266: Microcharts.dll => 0xdaa1e3ff => 23
	i32 3672681054, ; 267: Mono.Android.dll => 0xdae8aa5e => 36
	i32 3676310014, ; 268: System.Web.Services.dll => 0xdb2009fe => 153
	i32 3678221644, ; 269: Xamarin.Android.Support.v7.AppCompat => 0xdb3d354c => 64
	i32 3682565725, ; 270: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 76
	i32 3684561358, ; 271: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 79
	i32 3684933406, ; 272: System.Runtime.InteropServices.WindowsRuntime => 0xdba39f1e => 5
	i32 3689375977, ; 273: System.Drawing.Common => 0xdbe768e9 => 149
	i32 3706696989, ; 274: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 83
	i32 3718463572, ; 275: Xamarin.Android.Support.Animated.Vector.Drawable.dll => 0xdda34054 => 61
	i32 3718780102, ; 276: Xamarin.AndroidX.Annotation => 0xdda814c6 => 68
	i32 3724971120, ; 277: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 108
	i32 3731644420, ; 278: System.Reactive => 0xde6c6004 => 55
	i32 3748608112, ; 279: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 49
	i32 3758932259, ; 280: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 96
	i32 3776811843, ; 281: Plugin.InputKit.dll => 0xe11d9343 => 41
	i32 3786282454, ; 282: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 78
	i32 3793997468, ; 283: Google.Apis.Auth.dll => 0xe223ce9c => 17
	i32 3822602673, ; 284: Xamarin.AndroidX.Media => 0xe3d849b1 => 106
	i32 3829621856, ; 285: System.Numerics.dll => 0xe4436460 => 53
	i32 3841636137, ; 286: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 27
	i32 3883175360, ; 287: Xamarin.Android.Support.v7.AppCompat.dll => 0xe7748dc0 => 64
	i32 3885922214, ; 288: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 121
	i32 3888767677, ; 289: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 113
	i32 3896760992, ; 290: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 84
	i32 3903721208, ; 291: Microcharts.Forms => 0xe8ae0ef8 => 25
	i32 3920810846, ; 292: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 151
	i32 3921031405, ; 293: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 124
	i32 3931092270, ; 294: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 110
	i32 3945713374, ; 295: System.Data.DataSetExtensions.dll => 0xeb2ecede => 148
	i32 3955647286, ; 296: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 71
	i32 3959773229, ; 297: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 100
	i32 3967165417, ; 298: Xamarin.GooglePlayServices.Location => 0xec7623e9 => 137
	i32 3970018735, ; 299: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 138
	i32 4024013275, ; 300: Firebase.Auth => 0xefd991db => 11
	i32 4025784931, ; 301: System.Memory => 0xeff49a63 => 51
	i32 4059682726, ; 302: Google.Apis.dll => 0xf1f9d7a6 => 20
	i32 4082882467, ; 303: Google.Apis.Auth => 0xf35bd7a3 => 17
	i32 4101593132, ; 304: Xamarin.AndroidX.Emoji2 => 0xf479582c => 90
	i32 4105002889, ; 305: Mono.Security.dll => 0xf4ad5f89 => 156
	i32 4126470640, ; 306: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 28
	i32 4151237749, ; 307: System.Core => 0xf76edc75 => 48
	i32 4177102269, ; 308: FirebaseAdmin.dll => 0xf8f985bd => 13
	i32 4182413190, ; 309: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 103
	i32 4213026141, ; 310: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 49
	i32 4256097574, ; 311: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 83
	i32 4260525087, ; 312: System.Buffers => 0xfdf2741f => 46
	i32 4292120959 ; 313: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 103
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [314 x i32] [
	i32 101, i32 134, i32 38, i32 129, i32 117, i32 117, i32 142, i32 78, ; 0..7
	i32 119, i32 10, i32 0, i32 76, i32 63, i32 95, i32 153, i32 81, ; 8..15
	i32 99, i32 93, i32 7, i32 67, i32 53, i32 97, i32 51, i32 61, ; 16..23
	i32 12, i32 80, i32 128, i32 92, i32 37, i32 50, i32 93, i32 105, ; 24..31
	i32 42, i32 32, i32 43, i32 147, i32 142, i32 30, i32 62, i32 26, ; 32..39
	i32 65, i32 151, i32 55, i32 86, i32 91, i32 34, i32 124, i32 72, ; 40..47
	i32 60, i32 144, i32 139, i32 143, i32 150, i32 31, i32 41, i32 149, ; 48..55
	i32 112, i32 35, i32 63, i32 24, i32 75, i32 134, i32 38, i32 143, ; 56..63
	i32 97, i32 14, i32 116, i32 27, i32 71, i32 131, i32 102, i32 8, ; 64..71
	i32 141, i32 50, i32 122, i32 109, i32 72, i32 155, i32 118, i32 123, ; 72..79
	i32 144, i32 34, i32 88, i32 62, i32 154, i32 116, i32 1, i32 106, ; 80..87
	i32 82, i32 57, i32 132, i32 47, i32 150, i32 70, i32 32, i32 47, ; 88..95
	i32 10, i32 42, i32 18, i32 87, i32 25, i32 6, i32 104, i32 126, ; 96..103
	i32 91, i32 85, i32 52, i32 58, i32 120, i32 133, i32 66, i32 81, ; 104..111
	i32 56, i32 140, i32 45, i32 77, i32 8, i32 119, i32 30, i32 48, ; 112..119
	i32 92, i32 26, i32 104, i32 141, i32 133, i32 110, i32 29, i32 128, ; 120..127
	i32 65, i32 132, i32 73, i32 56, i32 5, i32 136, i32 107, i32 140, ; 128..135
	i32 46, i32 102, i32 98, i32 58, i32 54, i32 94, i32 2, i32 130, ; 136..143
	i32 135, i32 31, i32 29, i32 145, i32 52, i32 11, i32 122, i32 105, ; 144..151
	i32 107, i32 96, i32 114, i32 33, i32 68, i32 90, i32 111, i32 40, ; 152..159
	i32 0, i32 80, i32 3, i32 21, i32 40, i32 15, i32 148, i32 101, ; 160..167
	i32 2, i32 75, i32 123, i32 13, i32 9, i32 39, i32 145, i32 35, ; 168..175
	i32 85, i32 89, i32 16, i32 99, i32 120, i32 67, i32 1, i32 70, ; 176..183
	i32 129, i32 139, i32 125, i32 115, i32 44, i32 82, i32 59, i32 115, ; 184..191
	i32 135, i32 125, i32 121, i32 19, i32 152, i32 37, i32 44, i32 126, ; 192..199
	i32 54, i32 69, i32 66, i32 39, i32 45, i32 88, i32 20, i32 100, ; 200..207
	i32 118, i32 95, i32 24, i32 14, i32 108, i32 138, i32 6, i32 4, ; 208..215
	i32 18, i32 15, i32 146, i32 87, i32 136, i32 156, i32 77, i32 4, ; 216..223
	i32 74, i32 155, i32 86, i32 146, i32 12, i32 43, i32 73, i32 113, ; 224..231
	i32 109, i32 9, i32 94, i32 127, i32 84, i32 21, i32 114, i32 57, ; 232..239
	i32 154, i32 127, i32 28, i32 59, i32 3, i32 89, i32 19, i32 23, ; 240..247
	i32 36, i32 147, i32 79, i32 137, i32 74, i32 60, i32 130, i32 33, ; 248..255
	i32 152, i32 7, i32 22, i32 111, i32 16, i32 112, i32 22, i32 131, ; 256..263
	i32 69, i32 98, i32 23, i32 36, i32 153, i32 64, i32 76, i32 79, ; 264..271
	i32 5, i32 149, i32 83, i32 61, i32 68, i32 108, i32 55, i32 49, ; 272..279
	i32 96, i32 41, i32 78, i32 17, i32 106, i32 53, i32 27, i32 64, ; 280..287
	i32 121, i32 113, i32 84, i32 25, i32 151, i32 124, i32 110, i32 148, ; 288..295
	i32 71, i32 100, i32 137, i32 138, i32 11, i32 51, i32 20, i32 17, ; 296..303
	i32 90, i32 156, i32 28, i32 48, i32 13, i32 103, i32 49, i32 83, ; 304..311
	i32 46, i32 103 ; 312..313
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
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


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}