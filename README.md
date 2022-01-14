# Xamarin.LineSDK

## Xamarin.LineSDK.iOS
### Binding手順
* [line-sdk-ios-swift](https://github.com/line/line-sdk-ios-swift/releases)から以下のファイルをダウンロードする  
  * Swiftライブラリ「LineSDK_[version].zip」  
  * 「Source code」  
* ダウンロードした[LineSDK.xcframework]をXamarin.LineSDK.iOS/Frameworksに追加する  
* [binding_swift_library.sh](/Scripts/binding_swift_library.sh)を開き、IOS_SDK_VERSION, SWIFT_SOURCE_DIR, OUTPUT_PATHを設定して実行する  
* 生成された[LineSDKObjC.xcframework]をXamarin.LineSDK.iOS/Frameworksに追加する  
* 生成された[ApiDefinitions], [StructsAndEnums.cs]でXamarin.LineSDK.iOSのファイルを更新する  