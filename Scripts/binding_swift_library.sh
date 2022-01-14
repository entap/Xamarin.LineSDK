# LineSDKObjC.xcframeworkとメタデータ（ApiDefinitions.cs, StructsAndEnums.cs）を生成する
# 実行前にIOS_SDK_VERSION, SWIFT_SOURCE_DIR, OUTPUT_PATH を指定してください。
# 参考：https://github.com/xamcat/xamarin-binding-swift-framework/blob/master/Swift/Scripts/build.fat.sh

IOS_SDK_VERSION="" # e.g. 15.2
SWIFT_SOURCE_DIR="" # e.g. /Downloads/line-sdk-ios-swift-5.8.1
OUTPUT_PATH="" #e.g. /Downloads/LineSDKBinding

SWIFT_PROJECT_NAME="LineSDK"
SWIFT_PROJECT_PATH="$SWIFT_SOURCE_DIR/$SWIFT_PROJECT_NAME/$SWIFT_PROJECT_NAME.xcodeproj"
SWIFT_BUILD_PATH="$SWIFT_SOURCE_DIR/$SWIFT_PROJECT_NAME/build"
OBJC_NAME="LineSDKObjC"

# 警告メッセージをechoする
# $1 : message
function echo_warning () {
	ESC=$(printf '\033')
	echo "${ESC}[31m$1${ESC}[m"
    return 0
}

# frameworkをビルドする
# $1 : scheme(e.g. iphoneos, iphonesimulator)
function build_framework () {
	xcodebuild \
		'ENABLE_BITCODE=NO' \
		'BUILD_LIBRARY_FOR_DISTRIBUTION=YES' \
		-sdk $1$IOS_SDK_VERSION  \
		-project "$SWIFT_PROJECT_PATH"  \
		-configuration Release  \
		-target $OBJC_NAME
    return 0
}

# xcframeworkを生成する
# $1 : input_framework_path1
# $2 : input_framework_path2
# $3 : output_xcframework_path
function create_xcframework () {
	xcodebuild \
		-create-xcframework  \
		-framework $1 \
		-framework $2 \
		-output $3
    return 0
}

# xcframeworkを生成する
# $1 : sdk
# $2 : output
# $3 : namespace
# $4 : scope
# $5 : output_directory_path
function sharpie_bind () {
	sharpie \
		bind \
		--sdk=$1 \
		--output=$2 \
		--namespace=$3 \
		--scope=$4 \
		$5
    return 0
}

if [[ $IOS_SDK_VERSION == "" ]];then
	xcodebuild -showsdks
	echo_warning "[IOS_SDK_VERSION] を指定してください。"
	exit 1
fi

if [[ $SWIFT_SOURCE_DIR == "" ]];then
	echo_warning  "[SWIFT_SOURCE_DIR]を指定してください。"
	exit 1
fi

if [[ $OUTPUT_PATH == "" ]];then
	echo_warning "[OUTPUT_PATH]を指定してください。"
	exit 1
fi

echo "Build iOS framework for simulator and device"
rm -Rf "$SWIFT_BUILD_PATH"
build_framework "iphoneos"
build_framework "iphonesimulator"

echo "Create xcframework"
rm -Rf "$OUTPUT_PATH"
mkdir "$OUTPUT_PATH"
create_xcframework \
	$SWIFT_BUILD_PATH"/Release-iphoneos/"$OBJC_NAME".framework" \
	$SWIFT_BUILD_PATH"/Release-iphonesimulator/"$OBJC_NAME".framework" \
	$OUTPUT_PATH/$OBJC_NAME".xcframework"

echo "Generating binding api definition and structs"
sharpie_bind \
	iphoneos$IOS_SDK_VERSION \
	"$OUTPUT_PATH/XamarinApiDef" \
	$OBJC_NAME \
	"$OUTPUT_PATH/$OBJC_NAME.xcframework/ios-arm64_armv7/$OBJC_NAME.framework/Headers/" \
	"$OUTPUT_PATH/$OBJC_NAME.xcframework/ios-arm64_armv7/$OBJC_NAME.framework/Headers/$OBJC_NAME-Swift.h"

open $OUTPUT_PATH

echo "Done Binding!"