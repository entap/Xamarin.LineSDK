# Xamarin.LineSDK / LineSDK.NET
[LINE SDK for Android](https://developers.line.biz/ja/docs/android-sdk/), [LINE SDK for iOS](https://developers.line.biz/ja/docs/ios-sdk/) のバインディングライブラリです。  
.NET6.0以降で利用時は、LineSDK.NET.Android / LineSDK.NET.iOSを使用してください。

## Xamarin.LineSDK.Android / LineSDK.NET.Android
### 補足説明
* [依存ライブラリ](https://github.com/line/line-sdk-android/blob/master/line-sdk/build.gradle)は、Loginに使用するもののみパッケージに含めています。  
不足分については、「EmbeddedReferenceJar」として追加する必要があります。  
＊ 組み込みプロジェクトで以下のようなビルドエラーが発生時はAndroidManifest.xmlのapplicationにtools:replace="android:allowBackup"を指定してください  
> /Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Android/Xamarin.Android.Common.targets(3,3): Error AMM0000: 	Suggestion: add 'tools:replace="android:allowBackup"' to <application> element at AndroidManifest.xml to override. (AMM0000)

対応例:  
```xml
<?xml version="1.0" encoding="utf-8"?>
<manifest xmlns:android="http://schemas.android.com/apk/res/android" xmlns:tools="http://schemas.android.com/tools" >
	<application android:label="app_name" android:theme="@style/MainTheme" tools:replace="android:allowBackup">
</manifest>
```
  
  
## Xamarin.LineSDK.iOS / LineSDK.NET.iOS
FrameworkはiOS 15.2でビルドしています。
	
### Binding手順
* [line-sdk-ios-swift](https://github.com/line/line-sdk-ios-swift/releases)から 「Source code」 をダウンロードする  
* [binding_swift_library.sh](/Scripts/binding_swift_library.sh)を開き、IOS_SDK_VERSION, SWIFT_SOURCE_DIR, OUTPUT_PATHを設定して実行する  
* 生成された[LineSDK.framework], [LineSDKObjC.framework]をXamarin.LineSDK.iOS/Frameworksに追加する  
* 生成された[ApiDefinitions], [StructsAndEnums.cs]でXamarin.LineSDK.iOSのファイルを更新する  

### Binding補足説明
公式の[Binding手順](https://docs.microsoft.com/ja-jp/xamarin/ios/platform/binding-swift/walkthrough)に沿って説明*
* [ネイティブ ライブラリをビルドする](https://docs.microsoft.com/ja-jp/xamarin/ios/platform/binding-swift/walkthrough#build-a-native-library)について  
  * No.1〜6, 8〜10は[Objective-Cラッパー](https://developers.line.biz/ja/docs/ios-sdk/swift/using-objc/#use-wrapper)が用意されており、それを利用できるため作業不要  
　https://github.com/line/line-sdk-ios-swift/tree/master/LineSDK/LineSDKObjC
  * No.7, 11, 12は、[binding_swift_library.sh](/Scripts/binding_swift_library.sh)で行っています。  
* [メタデータを準備する](https://docs.microsoft.com/ja-jp/xamarin/ios/platform/binding-swift/walkthrough#prepare-metadata)  
 * [binding_swift_library.sh](/Scripts/binding_swift_library.sh)で行っています。  
* 以降は割愛  

### 補足説明
* 以下の理由により、LINEから提供されているソースコードからFat Frameworkを生成しています。
  * .xcframeworkでは、ライブラリでPlatform(iPhone/iPhonesimulator)毎に読み込むFramworkの指定ができない。  
※ライブラリ化せずにプロジェクト参照する場合は、.xcframeworkのままでも読み込みが可能です。
```xml
<ItemGroup Condition=" '$(Platform)' == 'iPhone' ">
  <NativeReference Include="Frameworks\LineSDK.xcframework\ios-arm64_armv7\LineSDK.framework">
    <Kind>Framework</Kind>
    <SmartLink>True</SmartLink>
  </NativeReference>
 </ItemGroup>
 <ItemGroup Condition=" '$(Platform)' == 'iPhoneSimulator' ">
  <NativeReference Include="Frameworks\LineSDK.xcframework\ios-arm64_i386_x86_64-simulator\LineSDK.framework">
    <Kind>Framework</Kind>
    <SmartLink>True</SmartLink>
  </NativeReference>
</ItemGroup>
```  
  * BitCodeの無効化や、iPhoneシミュレータ用ライブラリから arm64 等、追加の設定が必要。
