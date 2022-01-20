using System;
using Foundation;

namespace LineSDKObjC
{
    /// <summary>
    /// エラーコード
    /// LineSDKObjCではエラーLineSDKErrorが生成されず
    /// エラーハンドリングができないため定義を追加
    /// https://github.com/line/line-sdk-ios-swift/blob/955322119dbd9d3561804f00e3583118004d3054/LineSDK/LineSDK/General/LineSDKError.swift
    /// https://github.com/line/line-sdk-ios-swift/blob/master/LineSDK/LineSDKObjC/General/LineSDKErrorConstant.swift
    /// </summary>
    public struct LineSDKErrorCode
    {
		// RequestError
		// https://github.com/line/line-sdk-ios-swift/blob/955322119dbd9d3561804f00e3583118004d3054/LineSDK/LineSDK/General/LineSDKError.swift#L460
		public const int MissingURL = 1001;
		public const int LackOfAccessToken = 1002;
		public const int JsonEncodingFailed = 1003;
		public const int InvalidParameter = 1004;

		// ResponseError
		// https://github.com/line/line-sdk-ios-swift/blob/955322119dbd9d3561804f00e3583118004d3054/LineSDK/LineSDK/General/LineSDKError.swift#L509
		public const int URLSessionError = 2001;
		public const int NonHTTPURLResponse = 2002;
		public const int DataParsingFailed = 2003;
		public const int InvalidHTTPStatusAPIError = 2004;

		// AuthorizeError
		// https://github.com/line/line-sdk-ios-swift/blob/955322119dbd9d3561804f00e3583118004d3054/LineSDK/LineSDK/General/LineSDKError.swift#L580
		public const int ExhaustedLoginFlow = 3001;
		public const int MalformedHierarchy = 3002;
		public const int UserCancelled = 3003;
		public const int ForceStopped = 3004;
		public const int CallbackURLSchemeNotMatching = 3005;
		public const int InvalidSourceApplication = 3006;
		public const int MalformedRedirectURL = 3007;
		public const int InvalidLineURLResultCode = 3008;
		public const int LineClientError = 3009;
		public const int ResponseStateValueNotMatching = 3010;
		public const int WebLoginError = 3011;
		public const int KeychainOperation = 3012;
		public const int InvalidDataInKeychain = 3013;
		public const int LackOfIDToken = 3014;
		public const int JWTPublicKeyNotFound = 3015;
		public const int CryptoError = 3016;

		// GeneralError
		// https://github.com/line/line-sdk-ios-swift/blob/955322119dbd9d3561804f00e3583118004d3054/LineSDK/LineSDK/General/LineSDKError.swift#L651
		public const int ConversionError = 4001;
		public const int ParameterError = 4002;
		public const int NotOriginalTask = 4003;
		public const int ProcessDiscarded = 4004;
	}
}
