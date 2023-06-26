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
@assembly_image_cache_hashes = local_unnamed_addr constant [250 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 71
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 103
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 21
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 98
	i32 101534019, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 86
	i32 120558881, ; 5: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 86
	i32 134690465, ; 6: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 111
	i32 165246403, ; 7: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 51
	i32 182336117, ; 8: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 88
	i32 196637014, ; 9: F1MobileApp.dll => 0xbb87156 => 4
	i32 209399409, ; 10: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 49
	i32 230216969, ; 11: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 66
	i32 232815796, ; 12: System.Web.Services => 0xde07cb4 => 122
	i32 261689757, ; 13: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 54
	i32 278686392, ; 14: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 70
	i32 280482487, ; 15: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 64
	i32 318968648, ; 16: Xamarin.AndroidX.Activity.dll => 0x13031348 => 40
	i32 321597661, ; 17: System.Numerics => 0x132b30dd => 33
	i32 342366114, ; 18: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 68
	i32 385762202, ; 19: System.Memory.dll => 0x16fe439a => 31
	i32 393699800, ; 20: Firebase => 0x177761d8 => 6
	i32 441335492, ; 21: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 53
	i32 442521989, ; 22: Xamarin.Essentials => 0x1a605985 => 97
	i32 450948140, ; 23: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 63
	i32 465846621, ; 24: mscorlib => 0x1bc4415d => 20
	i32 469710990, ; 25: System.dll => 0x1bff388e => 30
	i32 476646585, ; 26: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 64
	i32 486930444, ; 27: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 75
	i32 504143952, ; 28: Plugin.LocalNotification.dll => 0x1e0ca050 => 23
	i32 513247710, ; 29: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 18
	i32 525008092, ; 30: SkiaSharp.dll => 0x1f4afcdc => 24
	i32 526420162, ; 31: System.Transactions.dll => 0x1f6088c2 => 116
	i32 527452488, ; 32: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 111
	i32 539058512, ; 33: Microsoft.Extensions.Logging => 0x20216150 => 16
	i32 605376203, ; 34: System.IO.Compression.FileSystem => 0x24154ecb => 120
	i32 610194910, ; 35: System.Reactive.dll => 0x245ed5de => 35
	i32 627609679, ; 36: Xamarin.AndroidX.CustomView => 0x2568904f => 59
	i32 663517072, ; 37: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 93
	i32 666292255, ; 38: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 45
	i32 690569205, ; 39: System.Xml.Linq.dll => 0x29293ff5 => 39
	i32 691348768, ; 40: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 113
	i32 700284507, ; 41: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 108
	i32 720511267, ; 42: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 112
	i32 775507847, ; 43: System.IO.Compression => 0x2e394f87 => 119
	i32 789151979, ; 44: Microsoft.Extensions.Options => 0x2f0980eb => 17
	i32 809851609, ; 45: System.Drawing.Common.dll => 0x30455ad9 => 118
	i32 843511501, ; 46: Xamarin.AndroidX.Print => 0x3246f6cd => 82
	i32 886248193, ; 47: Microcharts.Droid => 0x34d31301 => 11
	i32 912572698, ; 48: Xamarin.AndroidX.Biometric => 0x3664c11a => 48
	i32 928116545, ; 49: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 103
	i32 955402788, ; 50: Newtonsoft.Json => 0x38f24a24 => 21
	i32 956575887, ; 51: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 112
	i32 967690846, ; 52: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 68
	i32 974778368, ; 53: FormsViewGroup.dll => 0x3a19f000 => 7
	i32 1012816738, ; 54: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 85
	i32 1028951442, ; 55: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 13
	i32 1035644815, ; 56: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 44
	i32 1042160112, ; 57: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 100
	i32 1052210849, ; 58: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 72
	i32 1084122840, ; 59: Xamarin.Kotlin.StdLib => 0x409e66d8 => 110
	i32 1098259244, ; 60: System => 0x41761b2c => 30
	i32 1175144683, ; 61: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 91
	i32 1178241025, ; 62: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 79
	i32 1204270330, ; 63: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 45
	i32 1264511973, ; 64: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 87
	i32 1267360935, ; 65: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 92
	i32 1275534314, ; 66: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 113
	i32 1293217323, ; 67: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 61
	i32 1365406463, ; 68: System.ServiceModel.Internals.dll => 0x516272ff => 123
	i32 1376866003, ; 69: Xamarin.AndroidX.SavedState => 0x52114ed3 => 85
	i32 1395857551, ; 70: Xamarin.AndroidX.Media.dll => 0x5333188f => 76
	i32 1406073936, ; 71: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 55
	i32 1411638395, ; 72: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 36
	i32 1460219004, ; 73: Xamarin.Forms.Xaml => 0x57092c7c => 101
	i32 1462112819, ; 74: System.IO.Compression.dll => 0x57261233 => 119
	i32 1469204771, ; 75: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 43
	i32 1470490898, ; 76: Microsoft.Extensions.Primitives => 0x57a5e912 => 18
	i32 1522693535, ; 77: F1MobileApp => 0x5ac2759f => 4
	i32 1524747670, ; 78: Plugin.LocalNotification => 0x5ae1cd96 => 23
	i32 1582372066, ; 79: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 60
	i32 1582526884, ; 80: Microcharts.Forms.dll => 0x5e5371a4 => 12
	i32 1592978981, ; 81: System.Runtime.Serialization.dll => 0x5ef2ee25 => 3
	i32 1622152042, ; 82: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 74
	i32 1624863272, ; 83: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 95
	i32 1636350590, ; 84: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 58
	i32 1639515021, ; 85: System.Net.Http.dll => 0x61b9038d => 32
	i32 1657153582, ; 86: System.Runtime => 0x62c6282e => 37
	i32 1658241508, ; 87: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 89
	i32 1658251792, ; 88: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 102
	i32 1670060433, ; 89: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 54
	i32 1698840827, ; 90: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 109
	i32 1722051300, ; 91: SkiaSharp.Views.Forms => 0x66a46ae4 => 26
	i32 1729485958, ; 92: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 50
	i32 1766324549, ; 93: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 88
	i32 1770582343, ; 94: Microsoft.Extensions.Logging.dll => 0x6988f147 => 16
	i32 1776026572, ; 95: System.Core.dll => 0x69dc03cc => 28
	i32 1788241197, ; 96: Xamarin.AndroidX.Fragment => 0x6a96652d => 63
	i32 1808609942, ; 97: Xamarin.AndroidX.Loader => 0x6bcd3296 => 74
	i32 1813058853, ; 98: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 110
	i32 1813201214, ; 99: Xamarin.Google.Android.Material => 0x6c13413e => 102
	i32 1818569960, ; 100: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 80
	i32 1828688058, ; 101: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 15
	i32 1867746548, ; 102: Xamarin.Essentials.dll => 0x6f538cf4 => 97
	i32 1878053835, ; 103: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 101
	i32 1885316902, ; 104: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 46
	i32 1904755420, ; 105: System.Runtime.InteropServices.WindowsRuntime.dll => 0x718842dc => 2
	i32 1908813208, ; 106: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 105
	i32 1919157823, ; 107: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 77
	i32 1983156543, ; 108: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 109
	i32 2011961780, ; 109: System.Buffers.dll => 0x77ec19b4 => 27
	i32 2019465201, ; 110: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 72
	i32 2055257422, ; 111: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 69
	i32 2079903147, ; 112: System.Runtime.dll => 0x7bf8cdab => 37
	i32 2090596640, ; 113: System.Numerics.Vectors => 0x7c9bf920 => 34
	i32 2097448633, ; 114: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 65
	i32 2113414696, ; 115: F1MobileApp.Android.dll => 0x7df82628 => 0
	i32 2126786730, ; 116: Xamarin.Forms.Platform.Android => 0x7ec430aa => 99
	i32 2129483829, ; 117: Xamarin.GooglePlayServices.Base.dll => 0x7eed5835 => 104
	i32 2181898931, ; 118: Microsoft.Extensions.Options.dll => 0x820d22b3 => 17
	i32 2192057212, ; 119: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 15
	i32 2201107256, ; 120: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 114
	i32 2201231467, ; 121: System.Net.Http => 0x8334206b => 32
	i32 2216717168, ; 122: Firebase.Auth.dll => 0x84206b70 => 5
	i32 2217644978, ; 123: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 91
	i32 2244775296, ; 124: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 75
	i32 2256548716, ; 125: Xamarin.AndroidX.MultiDex => 0x8680336c => 77
	i32 2261435625, ; 126: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 67
	i32 2279755925, ; 127: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 84
	i32 2315684594, ; 128: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 41
	i32 2409053734, ; 129: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 81
	i32 2428790861, ; 130: Plugin.Fingerprint => 0x90c4684d => 22
	i32 2465532216, ; 131: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 53
	i32 2471841756, ; 132: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 133: Java.Interop.dll => 0x93918882 => 8
	i32 2483946094, ; 134: Plugin.Fingerprint.dll => 0x940e026e => 22
	i32 2501346920, ; 135: System.Data.DataSetExtensions => 0x95178668 => 117
	i32 2505896520, ; 136: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 71
	i32 2522193584, ; 137: F1MobileApp.Android => 0x96559eb0 => 0
	i32 2526443681, ; 138: Xamarin.AndroidX.Biometric.dll => 0x969678a1 => 48
	i32 2581819634, ; 139: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 92
	i32 2605712449, ; 140: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 114
	i32 2620871830, ; 141: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 58
	i32 2624644809, ; 142: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 62
	i32 2633051222, ; 143: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 70
	i32 2701096212, ; 144: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 89
	i32 2732626843, ; 145: Xamarin.AndroidX.Activity => 0xa2e0939b => 40
	i32 2737747696, ; 146: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 43
	i32 2766581644, ; 147: Xamarin.Forms.Core => 0xa4e6af8c => 98
	i32 2770495804, ; 148: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 108
	i32 2778768386, ; 149: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 94
	i32 2795602088, ; 150: SkiaSharp.Views.Android.dll => 0xa6a180a8 => 25
	i32 2810250172, ; 151: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 55
	i32 2819470561, ; 152: System.Xml.dll => 0xa80db4e1 => 38
	i32 2847418871, ; 153: Xamarin.GooglePlayServices.Base => 0xa9b829f7 => 104
	i32 2853208004, ; 154: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 94
	i32 2855708567, ; 155: Xamarin.AndroidX.Transition => 0xaa36a797 => 90
	i32 2903344695, ; 156: System.ComponentModel.Composition => 0xad0d8637 => 121
	i32 2905242038, ; 157: mscorlib.dll => 0xad2a79b6 => 20
	i32 2912489636, ; 158: SkiaSharp.Views.Android => 0xad9910a4 => 25
	i32 2916838712, ; 159: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 95
	i32 2919462931, ; 160: System.Numerics.Vectors.dll => 0xae037813 => 34
	i32 2921128767, ; 161: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 42
	i32 2974793899, ; 162: SkiaSharp.Views.Forms.dll => 0xb14fc0ab => 26
	i32 2978675010, ; 163: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 61
	i32 3016983068, ; 164: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 87
	i32 3024354802, ; 165: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 66
	i32 3036068679, ; 166: Microcharts.Droid.dll => 0xb4f6bb47 => 11
	i32 3044182254, ; 167: FormsViewGroup => 0xb57288ee => 7
	i32 3057625584, ; 168: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 78
	i32 3058099980, ; 169: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 107
	i32 3111772706, ; 170: System.Runtime.Serialization => 0xb979e222 => 3
	i32 3204380047, ; 171: System.Data.dll => 0xbefef58f => 115
	i32 3211777861, ; 172: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 60
	i32 3230466174, ; 173: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 105
	i32 3247949154, ; 174: Mono.Security => 0xc197c562 => 124
	i32 3258312781, ; 175: Xamarin.AndroidX.CardView => 0xc235e84d => 50
	i32 3267021929, ; 176: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 47
	i32 3317135071, ; 177: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 59
	i32 3317144872, ; 178: System.Data => 0xc5b79d28 => 115
	i32 3322403133, ; 179: Firebase.dll => 0xc607d93d => 6
	i32 3340387945, ; 180: SkiaSharp => 0xc71a4669 => 24
	i32 3340431453, ; 181: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 46
	i32 3345895724, ; 182: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 83
	i32 3346324047, ; 183: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 79
	i32 3353484488, ; 184: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 65
	i32 3353544232, ; 185: Xamarin.CommunityToolkit.dll => 0xc7e30628 => 96
	i32 3362522851, ; 186: Xamarin.AndroidX.Core => 0xc86c06e3 => 57
	i32 3366347497, ; 187: Java.Interop => 0xc8a662e9 => 8
	i32 3374999561, ; 188: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 84
	i32 3395150330, ; 189: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 36
	i32 3404865022, ; 190: System.ServiceModel.Internals => 0xcaf21dfe => 123
	i32 3407215217, ; 191: Xamarin.CommunityToolkit => 0xcb15fa71 => 96
	i32 3428513518, ; 192: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 14
	i32 3429136800, ; 193: System.Xml => 0xcc6479a0 => 38
	i32 3430777524, ; 194: netstandard => 0xcc7d82b4 => 1
	i32 3441283291, ; 195: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 62
	i32 3455791806, ; 196: Microcharts => 0xcdfb32be => 10
	i32 3476120550, ; 197: Mono.Android => 0xcf3163e6 => 19
	i32 3486566296, ; 198: System.Transactions => 0xcfd0c798 => 116
	i32 3493954962, ; 199: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 52
	i32 3494395880, ; 200: Xamarin.GooglePlayServices.Location.dll => 0xd0483fe8 => 106
	i32 3501239056, ; 201: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 47
	i32 3509114376, ; 202: System.Xml.Linq => 0xd128d608 => 39
	i32 3536029504, ; 203: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 99
	i32 3567349600, ; 204: System.ComponentModel.Composition.dll => 0xd4a16f60 => 121
	i32 3596207933, ; 205: LiteDB.dll => 0xd659c73d => 9
	i32 3618140916, ; 206: Xamarin.AndroidX.Preference => 0xd7a872f4 => 81
	i32 3627220390, ; 207: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 82
	i32 3629588173, ; 208: LiteDB => 0xd8571ecd => 9
	i32 3632359727, ; 209: Xamarin.Forms.Platform => 0xd881692f => 100
	i32 3633644679, ; 210: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 42
	i32 3641597786, ; 211: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 69
	i32 3668042751, ; 212: Microcharts.dll => 0xdaa1e3ff => 10
	i32 3672681054, ; 213: Mono.Android.dll => 0xdae8aa5e => 19
	i32 3676310014, ; 214: System.Web.Services.dll => 0xdb2009fe => 122
	i32 3682565725, ; 215: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 49
	i32 3684561358, ; 216: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 52
	i32 3684933406, ; 217: System.Runtime.InteropServices.WindowsRuntime => 0xdba39f1e => 2
	i32 3689375977, ; 218: System.Drawing.Common => 0xdbe768e9 => 118
	i32 3706696989, ; 219: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 56
	i32 3718780102, ; 220: Xamarin.AndroidX.Annotation => 0xdda814c6 => 41
	i32 3724971120, ; 221: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 78
	i32 3731644420, ; 222: System.Reactive => 0xde6c6004 => 35
	i32 3748608112, ; 223: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 29
	i32 3758932259, ; 224: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 67
	i32 3786282454, ; 225: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 51
	i32 3822602673, ; 226: Xamarin.AndroidX.Media => 0xe3d849b1 => 76
	i32 3829621856, ; 227: System.Numerics.dll => 0xe4436460 => 33
	i32 3841636137, ; 228: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 13
	i32 3885922214, ; 229: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 90
	i32 3888767677, ; 230: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 83
	i32 3896760992, ; 231: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 57
	i32 3903721208, ; 232: Microcharts.Forms => 0xe8ae0ef8 => 12
	i32 3920810846, ; 233: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 120
	i32 3921031405, ; 234: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 93
	i32 3931092270, ; 235: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 80
	i32 3945713374, ; 236: System.Data.DataSetExtensions.dll => 0xeb2ecede => 117
	i32 3955647286, ; 237: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 44
	i32 3967165417, ; 238: Xamarin.GooglePlayServices.Location => 0xec7623e9 => 106
	i32 3970018735, ; 239: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 107
	i32 4024013275, ; 240: Firebase.Auth => 0xefd991db => 5
	i32 4025784931, ; 241: System.Memory => 0xeff49a63 => 31
	i32 4105002889, ; 242: Mono.Security.dll => 0xf4ad5f89 => 124
	i32 4126470640, ; 243: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 14
	i32 4151237749, ; 244: System.Core => 0xf76edc75 => 28
	i32 4182413190, ; 245: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 73
	i32 4213026141, ; 246: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 29
	i32 4256097574, ; 247: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 56
	i32 4260525087, ; 248: System.Buffers => 0xfdf2741f => 27
	i32 4292120959 ; 249: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 73
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [250 x i32] [
	i32 71, i32 103, i32 21, i32 98, i32 86, i32 86, i32 111, i32 51, ; 0..7
	i32 88, i32 4, i32 49, i32 66, i32 122, i32 54, i32 70, i32 64, ; 8..15
	i32 40, i32 33, i32 68, i32 31, i32 6, i32 53, i32 97, i32 63, ; 16..23
	i32 20, i32 30, i32 64, i32 75, i32 23, i32 18, i32 24, i32 116, ; 24..31
	i32 111, i32 16, i32 120, i32 35, i32 59, i32 93, i32 45, i32 39, ; 32..39
	i32 113, i32 108, i32 112, i32 119, i32 17, i32 118, i32 82, i32 11, ; 40..47
	i32 48, i32 103, i32 21, i32 112, i32 68, i32 7, i32 85, i32 13, ; 48..55
	i32 44, i32 100, i32 72, i32 110, i32 30, i32 91, i32 79, i32 45, ; 56..63
	i32 87, i32 92, i32 113, i32 61, i32 123, i32 85, i32 76, i32 55, ; 64..71
	i32 36, i32 101, i32 119, i32 43, i32 18, i32 4, i32 23, i32 60, ; 72..79
	i32 12, i32 3, i32 74, i32 95, i32 58, i32 32, i32 37, i32 89, ; 80..87
	i32 102, i32 54, i32 109, i32 26, i32 50, i32 88, i32 16, i32 28, ; 88..95
	i32 63, i32 74, i32 110, i32 102, i32 80, i32 15, i32 97, i32 101, ; 96..103
	i32 46, i32 2, i32 105, i32 77, i32 109, i32 27, i32 72, i32 69, ; 104..111
	i32 37, i32 34, i32 65, i32 0, i32 99, i32 104, i32 17, i32 15, ; 112..119
	i32 114, i32 32, i32 5, i32 91, i32 75, i32 77, i32 67, i32 84, ; 120..127
	i32 41, i32 81, i32 22, i32 53, i32 1, i32 8, i32 22, i32 117, ; 128..135
	i32 71, i32 0, i32 48, i32 92, i32 114, i32 58, i32 62, i32 70, ; 136..143
	i32 89, i32 40, i32 43, i32 98, i32 108, i32 94, i32 25, i32 55, ; 144..151
	i32 38, i32 104, i32 94, i32 90, i32 121, i32 20, i32 25, i32 95, ; 152..159
	i32 34, i32 42, i32 26, i32 61, i32 87, i32 66, i32 11, i32 7, ; 160..167
	i32 78, i32 107, i32 3, i32 115, i32 60, i32 105, i32 124, i32 50, ; 168..175
	i32 47, i32 59, i32 115, i32 6, i32 24, i32 46, i32 83, i32 79, ; 176..183
	i32 65, i32 96, i32 57, i32 8, i32 84, i32 36, i32 123, i32 96, ; 184..191
	i32 14, i32 38, i32 1, i32 62, i32 10, i32 19, i32 116, i32 52, ; 192..199
	i32 106, i32 47, i32 39, i32 99, i32 121, i32 9, i32 81, i32 82, ; 200..207
	i32 9, i32 100, i32 42, i32 69, i32 10, i32 19, i32 122, i32 49, ; 208..215
	i32 52, i32 2, i32 118, i32 56, i32 41, i32 78, i32 35, i32 29, ; 216..223
	i32 67, i32 51, i32 76, i32 33, i32 13, i32 90, i32 83, i32 57, ; 224..231
	i32 12, i32 120, i32 93, i32 80, i32 117, i32 44, i32 106, i32 107, ; 232..239
	i32 5, i32 31, i32 124, i32 14, i32 28, i32 73, i32 29, i32 56, ; 240..247
	i32 27, i32 73 ; 248..249
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
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
