# Xamarin.LineSDK

## Xamarin.LineSDK.iOS
### Binding手順
* [line-sdk-ios-swift](https://github.com/line/line-sdk-ios-swift/releases)から 「Source code」 をダウンロードする  
* [binding_swift_library.sh](/Scripts/binding_swift_library.sh)を開き、IOS_SDK_VERSION, SWIFT_SOURCE_DIR, OUTPUT_PATHを設定して実行する  
* 生成された[LineSDK.framework], [LineSDKObjC.framework]をXamarin.LineSDK.iOS/Frameworksに追加する  
* 生成された[ApiDefinitions], [StructsAndEnums.cs]でXamarin.LineSDK.iOSのファイルを更新する  

### 補足説明
 * 以下の理由により、LINEから提供されているソースコードからFat Frameworkを生成しています。
   * .xcframeworkでは、ライブラリでPlatform(iPhone/iPhonesimulator)毎に読み込むFramworkの指定ができない。
   * BitCodeの無効化や、iPhoneシミュレータ用ライブラリから arm64 等、追加の設定が必要。