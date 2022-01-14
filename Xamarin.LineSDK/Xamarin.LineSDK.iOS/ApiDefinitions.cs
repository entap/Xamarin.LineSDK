using System;
using CoreFoundation;
using Foundation;
using LineSDKObjC;
using ObjCRuntime;
using UIKit;

namespace LineSDKObjC
{
	// @interface LineSDKAPI : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC10LineSDKAPI")]
	interface LineSDKAPI
	{
		// +(void)getProfileWithCompletionHandler:(void (^ _Nonnull)(LineSDKUserProfile * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getProfileWithCompletionHandler:")]
		void GetProfileWithCompletionHandler (Action<LineSDKUserProfile, NSError> completion);

		// +(void)getProfileWithCallbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKUserProfile * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getProfileWithCallbackQueue:completionHandler:")]
		void GetProfileWithCallbackQueue (LineSDKCallbackQueue queue, Action<LineSDKUserProfile, NSError> completion);

		// +(void)getFriendsWithPageToken:(NSString * _Nullable)pageToken completionHandler:(void (^ _Nonnull)(LineSDKGetFriendsResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getFriendsWithPageToken:completionHandler:")]
		void GetFriendsWithPageToken ([NullAllowed] string pageToken, Action<LineSDKGetFriendsResponse, NSError> completion);

		// +(void)getFriendsWithSort:(enum LineSDKGetFriendsRequestSort)sort pageToken:(NSString * _Nullable)pageToken completionHandler:(void (^ _Nonnull)(LineSDKGetFriendsResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getFriendsWithSort:pageToken:completionHandler:")]
		void GetFriendsWithSort (LineSDKGetFriendsRequestSort sort, [NullAllowed] string pageToken, Action<LineSDKGetFriendsResponse, NSError> completion);

		// +(void)getFriendsWithSort:(enum LineSDKGetFriendsRequestSort)sort pageToken:(NSString * _Nullable)pageToken callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKGetFriendsResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getFriendsWithSort:pageToken:callbackQueue:completionHandler:")]
		void GetFriendsWithSort (LineSDKGetFriendsRequestSort sort, [NullAllowed] string pageToken, LineSDKCallbackQueue queue, Action<LineSDKGetFriendsResponse, NSError> completion);

		// +(void)getApproversInFriendsWithPageToken:(NSString * _Nullable)pageToken completionHandler:(void (^ _Nonnull)(LineSDKGetApproversInFriendsResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getApproversInFriendsWithPageToken:completionHandler:")]
		void GetApproversInFriendsWithPageToken ([NullAllowed] string pageToken, Action<LineSDKGetApproversInFriendsResponse, NSError> completion);

		// +(void)getApproversInFriendsWithPageToken:(NSString * _Nullable)pageToken callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKGetApproversInFriendsResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getApproversInFriendsWithPageToken:callbackQueue:completionHandler:")]
		void GetApproversInFriendsWithPageToken ([NullAllowed] string pageToken, LineSDKCallbackQueue queue, Action<LineSDKGetApproversInFriendsResponse, NSError> completion);

		// +(void)getGroupsWithPageToken:(NSString * _Nullable)pageToken completionHandler:(void (^ _Nonnull)(LineSDKGetGroupsResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getGroupsWithPageToken:completionHandler:")]
		void GetGroupsWithPageToken ([NullAllowed] string pageToken, Action<LineSDKGetGroupsResponse, NSError> completion);

		// +(void)getGroupsWithPageToken:(NSString * _Nullable)pageToken callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKGetGroupsResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getGroupsWithPageToken:callbackQueue:completionHandler:")]
		void GetGroupsWithPageToken ([NullAllowed] string pageToken, LineSDKCallbackQueue queue, Action<LineSDKGetGroupsResponse, NSError> completion);

		// +(void)getApproversInGroupWithGroupID:(NSString * _Nonnull)groupID pageToken:(NSString * _Nullable)pageToken completionHandler:(void (^ _Nonnull)(LineSDKGetApproversInGroupResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getApproversInGroupWithGroupID:pageToken:completionHandler:")]
		void GetApproversInGroupWithGroupID (string groupID, [NullAllowed] string pageToken, Action<LineSDKGetApproversInGroupResponse, NSError> completion);

		// +(void)getApproversInGroupWithGroupID:(NSString * _Nonnull)groupID pageToken:(NSString * _Nullable)pageToken callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKGetApproversInGroupResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getApproversInGroupWithGroupID:pageToken:callbackQueue:completionHandler:")]
		void GetApproversInGroupWithGroupID (string groupID, [NullAllowed] string pageToken, LineSDKCallbackQueue queue, Action<LineSDKGetApproversInGroupResponse, NSError> completion);

		// +(void)sendMessages:(NSArray<LineSDKMessage *> * _Nonnull)messages to:(NSString * _Nonnull)chatID completionHandler:(void (^ _Nonnull)(LineSDKPostSendMessagesResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("sendMessages:to:completionHandler:")]
		void SendMessages (LineSDKMessage[] messages, string chatID, Action<LineSDKPostSendMessagesResponse, NSError> completion);

		// +(void)sendMessages:(NSArray<LineSDKMessage *> * _Nonnull)messages to:(NSString * _Nonnull)chatID callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKPostSendMessagesResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("sendMessages:to:callbackQueue:completionHandler:")]
		void SendMessages (LineSDKMessage[] messages, string chatID, LineSDKCallbackQueue queue, Action<LineSDKPostSendMessagesResponse, NSError> completion);

		// +(void)multiSendMessages:(NSArray<LineSDKMessage *> * _Nonnull)messages to:(NSArray<NSString *> * _Nonnull)userIDs completionHandler:(void (^ _Nonnull)(LineSDKPostMultisendMessagesResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("multiSendMessages:to:completionHandler:")]
		void MultiSendMessages (LineSDKMessage[] messages, string[] userIDs, Action<LineSDKPostMultisendMessagesResponse, NSError> completion);

		// +(void)multiSendMessages:(NSArray<LineSDKMessage *> * _Nonnull)messages to:(NSArray<NSString *> * _Nonnull)userIDs callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKPostMultisendMessagesResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("multiSendMessages:to:callbackQueue:completionHandler:")]
		void MultiSendMessages (LineSDKMessage[] messages, string[] userIDs, LineSDKCallbackQueue queue, Action<LineSDKPostMultisendMessagesResponse, NSError> completion);

		// +(void)getBotFriendshipStatusWithCompletionHandler:(void (^ _Nonnull)(LineSDKGetBotFriendshipStatusResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getBotFriendshipStatusWithCompletionHandler:")]
		void GetBotFriendshipStatusWithCompletionHandler (Action<LineSDKGetBotFriendshipStatusResponse, NSError> completion);

		// +(void)getBotFriendshipStatusWithCallbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKGetBotFriendshipStatusResponse * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getBotFriendshipStatusWithCallbackQueue:completionHandler:")]
		void GetBotFriendshipStatusWithCallbackQueue (LineSDKCallbackQueue queue, Action<LineSDKGetBotFriendshipStatusResponse, NSError> completion);

		// +(void)getMessageSendingOneTimeTokenWithUserIDs:(NSArray<NSString *> * _Nonnull)userIDs completionHander:(void (^ _Nonnull)(LineSDKMessageSendingToken * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getMessageSendingOneTimeTokenWithUserIDs:completionHander:")]
		void GetMessageSendingOneTimeTokenWithUserIDs (string[] userIDs, Action<LineSDKMessageSendingToken, NSError> completion);

		// +(void)getMessageSendingOneTimeTokenWithUserIDs:(NSArray<NSString *> * _Nonnull)userIDs callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHander:(void (^ _Nonnull)(LineSDKMessageSendingToken * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getMessageSendingOneTimeTokenWithUserIDs:callbackQueue:completionHander:")]
		void GetMessageSendingOneTimeTokenWithUserIDs (string[] userIDs, LineSDKCallbackQueue queue, Action<LineSDKMessageSendingToken, NSError> completion);

		// +(void)multiSendMessages:(NSArray<LineSDKMessage *> * _Nonnull)messages withMessageToken:(LineSDKMessageSendingToken * _Nonnull)token completionHandler:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Static]
		[Export ("multiSendMessages:withMessageToken:completionHandler:")]
		void MultiSendMessages (LineSDKMessage[] messages, LineSDKMessageSendingToken token, Action<NSError> completion);

		// +(void)multiSendMessages:(NSArray<LineSDKMessage *> * _Nonnull)messages withMessageToken:(LineSDKMessageSendingToken * _Nonnull)token callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Static]
		[Export ("multiSendMessages:withMessageToken:callbackQueue:completionHandler:")]
		void MultiSendMessages (LineSDKMessage[] messages, LineSDKMessageSendingToken token, LineSDKCallbackQueue queue, Action<NSError> completion);

		// +(void)getOpenChatRoomStatusWithOpenChatId:(NSString * _Nonnull)openChatId completionHandler:(void (^ _Nonnull)(LineSDKOpenChatRoomStatus * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getOpenChatRoomStatusWithOpenChatId:completionHandler:")]
		void GetOpenChatRoomStatusWithOpenChatId (string openChatId, Action<LineSDKOpenChatRoomStatus, NSError> completion);

		// +(void)getOpenChatRoomStatusWithOpenChatId:(NSString * _Nonnull)openChatId callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKOpenChatRoomStatus * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getOpenChatRoomStatusWithOpenChatId:callbackQueue:completionHandler:")]
		void GetOpenChatRoomStatusWithOpenChatId (string openChatId, LineSDKCallbackQueue queue, Action<LineSDKOpenChatRoomStatus, NSError> completion);

		// +(void)getOpenChatRoomMembershipStateWithOpenChatId:(NSString * _Nonnull)openChatId completionHandler:(void (^ _Nonnull)(LineSDKOpenChatRoomMembershipState * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getOpenChatRoomMembershipStateWithOpenChatId:completionHandler:")]
		void GetOpenChatRoomMembershipStateWithOpenChatId (string openChatId, Action<LineSDKOpenChatRoomMembershipState, NSError> completion);

		// +(void)getOpenChatRoomMembershipStateWithOpenChatId:(NSString * _Nonnull)openChatId callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKOpenChatRoomMembershipState * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getOpenChatRoomMembershipStateWithOpenChatId:callbackQueue:completionHandler:")]
		void GetOpenChatRoomMembershipStateWithOpenChatId (string openChatId, LineSDKCallbackQueue queue, Action<LineSDKOpenChatRoomMembershipState, NSError> completion);

		// +(void)getOpenChatRoomJoinTypeWithOpenChatId:(NSString * _Nonnull)openChatId completionHandler:(void (^ _Nonnull)(LineSDKOpenChatRoomJoinType * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getOpenChatRoomJoinTypeWithOpenChatId:completionHandler:")]
		void GetOpenChatRoomJoinTypeWithOpenChatId (string openChatId, Action<LineSDKOpenChatRoomJoinType, NSError> completion);

		// +(void)getOpenChatRoomJoinTypeWithOpenChatId:(NSString * _Nonnull)openChatId callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKOpenChatRoomJoinType * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("getOpenChatRoomJoinTypeWithOpenChatId:callbackQueue:completionHandler:")]
		void GetOpenChatRoomJoinTypeWithOpenChatId (string openChatId, LineSDKCallbackQueue queue, Action<LineSDKOpenChatRoomJoinType, NSError> completion);

		// +(void)postOpenChatRoomJoinWithOpenChatId:(NSString * _Nonnull)openChatId displayName:(NSString * _Nonnull)displayName completionHandler:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Static]
		[Export ("postOpenChatRoomJoinWithOpenChatId:displayName:completionHandler:")]
		void PostOpenChatRoomJoinWithOpenChatId (string openChatId, string displayName, Action<NSError> completion);

		// +(void)postOpenChatRoomJoinWithOpenChatId:(NSString * _Nonnull)openChatId displayName:(NSString * _Nonnull)displayName callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Static]
		[Export ("postOpenChatRoomJoinWithOpenChatId:displayName:callbackQueue:completionHandler:")]
		void PostOpenChatRoomJoinWithOpenChatId (string openChatId, string displayName, LineSDKCallbackQueue queue, Action<NSError> completion);
	}

	// @interface LineSDKObjC_Swift_268 (LineSDKAPI)
	[Category]
	[BaseType (typeof(LineSDKAPI))]
	interface LineSDKAPI_LineSDKObjC_Swift_268
	{
		// +(void)refreshAccessTokenWithCompletionHandler:(void (^ _Nonnull)(LineSDKAccessToken * _Nullable, NSError * _Nullable))completion __attribute__((deprecated("
/* [Fix]Error CS1003: Syntax error
        Auth-related APIs don't refresh access tokens automatically.
        Make sure you don't need token refreshing as a side effect, then use methods in `LineSDKAuthAPI` instead.
        ", "LineSDKAuthAPI.refreshAccessToken")));
*/
		[Static]
		[Export ("refreshAccessTokenWithCompletionHandler:")]
		void RefreshAccessTokenWithCompletionHandler (Action<LineSDKAccessToken, NSError> completion);

		// +(void)refreshAccessTokenWithCallbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKAccessToken * _Nullable, NSError * _Nullable))completion __attribute__((deprecated("
/* [Fix]Error CS1003: Syntax error
        Auth-related APIs don't refresh access tokens automatically.
        Make sure you don't need token refreshing as a side effect, then use methods in `LineSDKAuthAPI` instead.
        ", "LineSDKAuthAPI.refreshAccessToken")));
*/
		[Static]
		[Export ("refreshAccessTokenWithCallbackQueue:completionHandler:")]
		void RefreshAccessTokenWithCallbackQueue (LineSDKCallbackQueue queue, Action<LineSDKAccessToken, NSError> completion);

		// +(void)revokeAccessTokenWithCompletionHandler:(void (^ _Nonnull)(NSError * _Nullable))completion __attribute__((deprecated("
/* [Fix]Error CS1003: Syntax error
        Auth-related APIs don't refresh access tokens automatically.
        Make sure you don't need token refreshing as a side effect, then use methods in `LineSDKAuthAPI` instead.
        ", "LineSDKAuthAPI.revokeAccessToken")));
*/
		[Static]
		[Export ("revokeAccessTokenWithCompletionHandler:")]
		void RevokeAccessTokenWithCompletionHandler (Action<NSError> completion);

		// +(void)revokeAccessToken:(NSString * _Nullable)token completionHandler:(void (^ _Nonnull)(NSError * _Nullable))completion __attribute__((deprecated("
/* [Fix]Error CS1003: Syntax error
        Auth-related APIs don't refresh access tokens automatically.
        Make sure you don't need token refreshing as a side effect, then use methods in `LineSDKAuthAPI` instead.
        ", "LineSDKAuthAPI.revokeAccessToken")));
*/
		[Static]
		[Export ("revokeAccessToken:completionHandler:")]
		void RevokeAccessToken ([NullAllowed] string token, Action<NSError> completion);

		// +(void)revokeAccessToken:(NSString * _Nullable)token callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(NSError * _Nullable))completion __attribute__((deprecated("
/* [Fix]Error CS1003: Syntax error
        Auth-related APIs don't refresh access tokens automatically.
        Make sure you don't need token refreshing as a side effect, then use methods in `LineSDKAuthAPI` instead.
        ", "LineSDKAuthAPI.revokeAccessToken")));
*/
		[Static]
		[Export ("revokeAccessToken:callbackQueue:completionHandler:")]
		void RevokeAccessToken ([NullAllowed] string token, LineSDKCallbackQueue queue, Action<NSError> completion);

		// +(void)verifyAccessTokenWithCompletionHandler:(void (^ _Nonnull)(LineSDKAccessTokenVerifyResult * _Nullable, NSError * _Nullable))completion __attribute__((deprecated("
/* [Fix]Error CS1003: Syntax error
        Auth-related APIs don't refresh access tokens automatically.
        Make sure you don't need token refreshing as a side effect, then use methods in `LineSDKAuthAPI` instead.
        ", "LineSDKAuthAPI.verifyAccessToken")));
*/
		[Static]
		[Export ("verifyAccessTokenWithCompletionHandler:")]
		void VerifyAccessTokenWithCompletionHandler (Action<LineSDKAccessTokenVerifyResult, NSError> completion);

		// +(void)verifyAccessToken:(NSString * _Nullable)token completionHandler:(void (^ _Nonnull)(LineSDKAccessTokenVerifyResult * _Nullable, NSError * _Nullable))completion __attribute__((deprecated("
/* [Fix]Error CS1003: Syntax error
        Auth-related APIs don't refresh access tokens automatically.
        Make sure you don't need token refreshing as a side effect, then use methods in `LineSDKAuthAPI` instead.
        ", "LineSDKAuthAPI.verifyAccessToken")));
*/
		[Static]
		[Export ("verifyAccessToken:completionHandler:")]
		void VerifyAccessToken ([NullAllowed] string token, Action<LineSDKAccessTokenVerifyResult, NSError> completion);

		// +(void)verifyAccessToken:(NSString * _Nullable)token callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKAccessTokenVerifyResult * _Nullable, NSError * _Nullable))completion __attribute__((deprecated("
/* [Fix]Error CS1003: Syntax error
        Auth-related APIs don't refresh access tokens automatically.
        Make sure you don't need token refreshing as a side effect, then use methods in `LineSDKAuthAPI` instead.
        ", "LineSDKAuthAPI.verifyAccessToken")));
*/
		[Static]
		[Export ("verifyAccessToken:callbackQueue:completionHandler:")]
		void VerifyAccessToken ([NullAllowed] string token, LineSDKCallbackQueue queue, Action<LineSDKAccessTokenVerifyResult, NSError> completion);
	}

	// @interface LineSDKAPIError : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC15LineSDKAPIError")]
	[DisableDefaultCtor]
	interface LineSDKAPIError
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull error;
		[Export ("error")]
		string Error { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable detail;
		[NullAllowed, Export ("detail")]
		string Detail { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKAPIError New ();
	}

	// @interface LineSDKAccessToken : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC18LineSDKAccessToken")]
	[DisableDefaultCtor]
	interface LineSDKAccessToken
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull value;
		[Export ("value")]
		string Value { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull createdAt;
		[Export ("createdAt", ArgumentSemantic.Copy)]
		NSDate CreatedAt { get; }

		// @property (readonly, nonatomic, strong) LineSDKJWT * _Nullable IDToken;
		[NullAllowed, Export ("IDToken", ArgumentSemantic.Strong)]
		LineSDKJWT IDToken { get; }

		// @property (readonly, copy, nonatomic) NSArray<LineSDKLoginPermission *> * _Nonnull permissions;
		[Export ("permissions", ArgumentSemantic.Copy)]
		LineSDKLoginPermission[] Permissions { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull expiresAt;
		[Export ("expiresAt", ArgumentSemantic.Copy)]
		NSDate ExpiresAt { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable json;
		[NullAllowed, Export ("json")]
		string Json { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKAccessToken New ();
	}

	// @interface LineSDKAccessTokenStore : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC23LineSDKAccessTokenStore")]
	[DisableDefaultCtor]
	interface LineSDKAccessTokenStore
	{
		// @property (readonly, nonatomic, strong, class) LineSDKAccessTokenStore * _Nonnull sharedStore;
		[Static]
		[Export ("sharedStore", ArgumentSemantic.Strong)]
		LineSDKAccessTokenStore SharedStore { get; }

		// @property (readonly, nonatomic, strong) LineSDKAccessToken * _Nullable currentToken;
		[NullAllowed, Export ("currentToken", ArgumentSemantic.Strong)]
		LineSDKAccessToken CurrentToken { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKAccessTokenStore New ();
	}

	// @interface LineSDKAccessTokenVerifyResult : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC30LineSDKAccessTokenVerifyResult")]
	[DisableDefaultCtor]
	interface LineSDKAccessTokenVerifyResult
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull channelID;
		[Export ("channelID")]
		string ChannelID { get; }

		// @property (readonly, copy, nonatomic) NSArray<LineSDKLoginPermission *> * _Nonnull permissions;
		[Export ("permissions", ArgumentSemantic.Copy)]
		LineSDKLoginPermission[] Permissions { get; }

		// @property (readonly, nonatomic) NSTimeInterval expiresIn;
		[Export ("expiresIn")]
		double ExpiresIn { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable json;
		[NullAllowed, Export ("json")]
		string Json { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKAccessTokenVerifyResult New ();
	}

	// @interface LineSDKMessage : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC14LineSDKMessage")]
	interface LineSDKMessage
	{
		// @property (readonly, nonatomic, strong) LineSDKTextMessage * _Nullable textMessage;
		[NullAllowed, Export ("textMessage", ArgumentSemantic.Strong)]
		LineSDKTextMessage TextMessage { get; }

		// @property (readonly, nonatomic, strong) LineSDKImageMessage * _Nullable imageMessage;
		[NullAllowed, Export ("imageMessage", ArgumentSemantic.Strong)]
		LineSDKImageMessage ImageMessage { get; }

		// @property (readonly, nonatomic, strong) LineSDKVideoMessage * _Nullable videoMessage;
		[NullAllowed, Export ("videoMessage", ArgumentSemantic.Strong)]
		LineSDKVideoMessage VideoMessage { get; }

		// @property (readonly, nonatomic, strong) LineSDKAudioMessage * _Nullable audioMessage;
		[NullAllowed, Export ("audioMessage", ArgumentSemantic.Strong)]
		LineSDKAudioMessage AudioMessage { get; }

		// @property (readonly, nonatomic, strong) LineSDKLocationMessage * _Nullable locationMessage;
		[NullAllowed, Export ("locationMessage", ArgumentSemantic.Strong)]
		LineSDKLocationMessage LocationMessage { get; }

		// @property (readonly, nonatomic, strong) LineSDKTemplateMessage * _Nullable templateMessage;
		[NullAllowed, Export ("templateMessage", ArgumentSemantic.Strong)]
		LineSDKTemplateMessage TemplateMessage { get; }

		// @property (readonly, nonatomic, strong) LineSDKFlexMessage * _Nullable flexMessage;
		[NullAllowed, Export ("flexMessage", ArgumentSemantic.Strong)]
		LineSDKFlexMessage FlexMessage { get; }
	}

	// @interface LineSDKAudioMessage : LineSDKMessage
	[BaseType (typeof(LineSDKMessage), Name = "_TtC11LineSDKObjC19LineSDKAudioMessage")]
	[DisableDefaultCtor]
	interface LineSDKAudioMessage
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nonnull originalContentURL;
		[Export ("originalContentURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL OriginalContentURL { get; }
		NSUrl OriginalContentURL { get; }

		// @property (readonly, nonatomic) NSTimeInterval duration;
		[Export ("duration")]
		double Duration { get; }

		// -(instancetype _Nullable)initWithOriginalContentURL:(NSURL * _Nonnull)originalContentURL duration:(NSTimeInterval)duration __attribute__((objc_designated_initializer));
		[Export ("initWithOriginalContentURL:duration:")]
		[DesignatedInitializer]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		IntPtr Constructor (NSURL originalContentURL, double duration);
		IntPtr Constructor (NSUrl originalContentURL, double duration);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKAudioMessage New ();
	}

	// @interface LineSDKAuthAPI : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC14LineSDKAuthAPI")]
	interface LineSDKAuthAPI
	{
		// +(void)refreshAccessTokenWithCompletionHandler:(void (^ _Nonnull)(LineSDKAccessToken * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("refreshAccessTokenWithCompletionHandler:")]
		void RefreshAccessTokenWithCompletionHandler (Action<LineSDKAccessToken, NSError> completion);

		// +(void)refreshAccessTokenWithCallbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKAccessToken * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("refreshAccessTokenWithCallbackQueue:completionHandler:")]
		void RefreshAccessTokenWithCallbackQueue (LineSDKCallbackQueue queue, Action<LineSDKAccessToken, NSError> completion);

		// +(void)revokeAccessTokenWithCompletionHandler:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Static]
		[Export ("revokeAccessTokenWithCompletionHandler:")]
		void RevokeAccessTokenWithCompletionHandler (Action<NSError> completion);

		// +(void)revokeAccessToken:(NSString * _Nullable)token completionHandler:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Static]
		[Export ("revokeAccessToken:completionHandler:")]
		void RevokeAccessToken ([NullAllowed] string token, Action<NSError> completion);

		// +(void)revokeAccessToken:(NSString * _Nullable)token callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Static]
		[Export ("revokeAccessToken:callbackQueue:completionHandler:")]
		void RevokeAccessToken ([NullAllowed] string token, LineSDKCallbackQueue queue, Action<NSError> completion);

		// +(void)revokeRefreshTokenWithCompletionHandler:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Static]
		[Export ("revokeRefreshTokenWithCompletionHandler:")]
		void RevokeRefreshTokenWithCompletionHandler (Action<NSError> completion);

		// +(void)revokeRefreshToken:(NSString * _Nullable)token completionHandler:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Static]
		[Export ("revokeRefreshToken:completionHandler:")]
		void RevokeRefreshToken ([NullAllowed] string token, Action<NSError> completion);

		// +(void)revokeRefreshToken:(NSString * _Nullable)token callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Static]
		[Export ("revokeRefreshToken:callbackQueue:completionHandler:")]
		void RevokeRefreshToken ([NullAllowed] string token, LineSDKCallbackQueue queue, Action<NSError> completion);

		// +(void)verifyAccessTokenWithCompletionHandler:(void (^ _Nonnull)(LineSDKAccessTokenVerifyResult * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("verifyAccessTokenWithCompletionHandler:")]
		void VerifyAccessTokenWithCompletionHandler (Action<LineSDKAccessTokenVerifyResult, NSError> completion);

		// +(void)verifyAccessToken:(NSString * _Nullable)token completionHandler:(void (^ _Nonnull)(LineSDKAccessTokenVerifyResult * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("verifyAccessToken:completionHandler:")]
		void VerifyAccessToken ([NullAllowed] string token, Action<LineSDKAccessTokenVerifyResult, NSError> completion);

		// +(void)verifyAccessToken:(NSString * _Nullable)token callbackQueue:(LineSDKCallbackQueue * _Nonnull)queue completionHandler:(void (^ _Nonnull)(LineSDKAccessTokenVerifyResult * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("verifyAccessToken:callbackQueue:completionHandler:")]
		void VerifyAccessToken ([NullAllowed] string token, LineSDKCallbackQueue queue, Action<LineSDKAccessTokenVerifyResult, NSError> completion);
	}

	// @interface LineSDKAuthorizationStatus : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC26LineSDKAuthorizationStatus")]
	[DisableDefaultCtor]
	interface LineSDKAuthorizationStatus
	{
		// @property (readonly, nonatomic) NSInteger rawValue;
		[Export ("rawValue")]
		nint RawValue { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKAuthorizationStatus * _Nonnull authorized;
		[Static]
		[Export ("authorized", ArgumentSemantic.Strong)]
		LineSDKAuthorizationStatus Authorized { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKAuthorizationStatus * _Nonnull lackOfToken;
		[Static]
		[Export ("lackOfToken", ArgumentSemantic.Strong)]
		LineSDKAuthorizationStatus LackOfToken { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKAuthorizationStatus * _Nonnull lackOfPermissions;
		[Static]
		[Export ("lackOfPermissions", ArgumentSemantic.Strong)]
		LineSDKAuthorizationStatus LackOfPermissions { get; }

		// -(instancetype _Nonnull)initWithRawValue:(NSInteger)rawValue __attribute__((objc_designated_initializer));
		[Export ("initWithRawValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint rawValue);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKAuthorizationStatus New ();
	}

	// @interface LineSDKCallbackQueue : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC20LineSDKCallbackQueue")]
	[DisableDefaultCtor]
	interface LineSDKCallbackQueue
	{
		// @property (readonly, nonatomic, strong, class) LineSDKCallbackQueue * _Nonnull asyncMain;
		[Static]
		[Export ("asyncMain", ArgumentSemantic.Strong)]
		LineSDKCallbackQueue AsyncMain { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKCallbackQueue * _Nonnull currentMainOrAsync;
		[Static]
		[Export ("currentMainOrAsync", ArgumentSemantic.Strong)]
		LineSDKCallbackQueue CurrentMainOrAsync { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKCallbackQueue * _Nonnull untouch;
		[Static]
		[Export ("untouch", ArgumentSemantic.Strong)]
		LineSDKCallbackQueue Untouch { get; }

		// +(LineSDKCallbackQueue * _Nonnull)callbackQueueWithDispatchQueue:(dispatch_queue_t _Nonnull)dispatchQueue __attribute__((warn_unused_result("")));
		[Static]
		[Export ("callbackQueueWithDispatchQueue:")]
		LineSDKCallbackQueue CallbackQueueWithDispatchQueue (DispatchQueue dispatchQueue);

		// +(LineSDKCallbackQueue * _Nonnull)callbackQueueWithOperationQueue:(NSOperationQueue * _Nonnull)operationQueue __attribute__((warn_unused_result("")));
		[Static]
		[Export ("callbackQueueWithOperationQueue:")]
		LineSDKCallbackQueue CallbackQueueWithOperationQueue (NSOperationQueue operationQueue);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKCallbackQueue New ();
	}

	// @interface LineSDKConstant : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC15LineSDKConstant")]
	interface LineSDKConstant
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull SDKVersion;
		[Static]
		[Export ("SDKVersion")]
		string SDKVersion { get; }
	}

	// @interface LineSDKErrorConstant : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC20LineSDKErrorConstant")]
	interface LineSDKErrorConstant
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull errorDomain;
		[Static]
		[Export ("errorDomain")]
		string ErrorDomain { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull cryptoErrorDomain;
		[Static]
		[Export ("cryptoErrorDomain")]
		string CryptoErrorDomain { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyUnderlyingError;
		[Static]
		[Export ("userInfoKeyUnderlyingError")]
		string UserInfoKeyUnderlyingError { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyStatusCode;
		[Static]
		[Export ("userInfoKeyStatusCode")]
		string UserInfoKeyStatusCode { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyResultCode;
		[Static]
		[Export ("userInfoKeyResultCode")]
		string UserInfoKeyResultCode { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyType;
		[Static]
		[Export ("userInfoKeyType")]
		string UserInfoKeyType { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyData;
		[Static]
		[Export ("userInfoKeyData")]
		string UserInfoKeyData { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyAPIError;
		[Static]
		[Export ("userInfoKeyAPIError")]
		string UserInfoKeyAPIError { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyRaw;
		[Static]
		[Export ("userInfoKeyRaw")]
		string UserInfoKeyRaw { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyUrl;
		[Static]
		[Export ("userInfoKeyUrl")]
		string UserInfoKeyUrl { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyMessage;
		[Static]
		[Export ("userInfoKeyMessage")]
		string UserInfoKeyMessage { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyStatus;
		[Static]
		[Export ("userInfoKeyStatus")]
		string UserInfoKeyStatus { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyText;
		[Static]
		[Export ("userInfoKeyText")]
		string UserInfoKeyText { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyEncoding;
		[Static]
		[Export ("userInfoKeyEncoding")]
		string UserInfoKeyEncoding { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyParameterName;
		[Static]
		[Export ("userInfoKeyParameterName")]
		string UserInfoKeyParameterName { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyReason;
		[Static]
		[Export ("userInfoKeyReason")]
		string UserInfoKeyReason { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyIndex;
		[Static]
		[Export ("userInfoKeyIndex")]
		string UserInfoKeyIndex { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyKey;
		[Static]
		[Export ("userInfoKeyKey")]
		string UserInfoKeyKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull userInfoKeyGot;
		[Static]
		[Export ("userInfoKeyGot")]
		string UserInfoKeyGot { get; }
	}

	// @interface LineSDKFlexBlockStyle : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC21LineSDKFlexBlockStyle")]
	[DisableDefaultCtor]
	interface LineSDKFlexBlockStyle
	{
		// @property (nonatomic, strong) LineSDKHexColor * _Nullable backgroundColor;
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
		LineSDKHexColor BackgroundColor { get; set; }

		// @property (nonatomic) BOOL separator;
		[Export ("separator")]
		bool Separator { get; set; }

		// @property (nonatomic, strong) LineSDKHexColor * _Nullable separatorColor;
		[NullAllowed, Export ("separatorColor", ArgumentSemantic.Strong)]
		LineSDKHexColor SeparatorColor { get; set; }

		// -(instancetype _Nonnull)initWithBackgroundColor:(LineSDKHexColor * _Nullable)backgroundColor separator:(BOOL)separator separatorColor:(LineSDKHexColor * _Nullable)separatorColor __attribute__((objc_designated_initializer));
		[Export ("initWithBackgroundColor:separator:separatorColor:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] LineSDKHexColor backgroundColor, bool separator, [NullAllowed] LineSDKHexColor separatorColor);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKFlexBlockStyle New ();
	}

	// @interface LineSDKFlexMessageComponent : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC27LineSDKFlexMessageComponent")]
	interface LineSDKFlexMessageComponent
	{
		// @property (readonly, nonatomic, strong) LineSDKFlexBoxComponent * _Nullable boxComponent;
		[NullAllowed, Export ("boxComponent", ArgumentSemantic.Strong)]
		LineSDKFlexBoxComponent BoxComponent { get; }

		// @property (readonly, nonatomic, strong) LineSDKFlexTextComponent * _Nullable textComponent;
		[NullAllowed, Export ("textComponent", ArgumentSemantic.Strong)]
		LineSDKFlexTextComponent TextComponent { get; }

		// @property (readonly, nonatomic, strong) LineSDKFlexButtonComponent * _Nullable buttonComponent;
		[NullAllowed, Export ("buttonComponent", ArgumentSemantic.Strong)]
		LineSDKFlexButtonComponent ButtonComponent { get; }

		// @property (readonly, nonatomic, strong) LineSDKFlexImageComponent * _Nullable imageComponent;
		[NullAllowed, Export ("imageComponent", ArgumentSemantic.Strong)]
		LineSDKFlexImageComponent ImageComponent { get; }

		// @property (readonly, nonatomic, strong) LineSDKFlexFillerComponent * _Nullable fillerComponent;
		[NullAllowed, Export ("fillerComponent", ArgumentSemantic.Strong)]
		LineSDKFlexFillerComponent FillerComponent { get; }

		// @property (readonly, nonatomic, strong) LineSDKFlexIconComponent * _Nullable iconComponent;
		[NullAllowed, Export ("iconComponent", ArgumentSemantic.Strong)]
		LineSDKFlexIconComponent IconComponent { get; }

		// @property (readonly, nonatomic, strong) LineSDKFlexSeparatorComponent * _Nullable separatorComponent;
		[NullAllowed, Export ("separatorComponent", ArgumentSemantic.Strong)]
		LineSDKFlexSeparatorComponent SeparatorComponent { get; }

		// @property (readonly, nonatomic, strong) LineSDKFlexSpacerComponent * _Nullable spacerComponent;
		[NullAllowed, Export ("spacerComponent", ArgumentSemantic.Strong)]
		LineSDKFlexSpacerComponent SpacerComponent { get; }
	}

	// @interface LineSDKFlexBoxComponent : LineSDKFlexMessageComponent
	[BaseType (typeof(LineSDKFlexMessageComponent), Name = "_TtC11LineSDKObjC23LineSDKFlexBoxComponent")]
	[DisableDefaultCtor]
	interface LineSDKFlexBoxComponent
	{
		// @property (readonly, nonatomic) enum LineSDKFlexMessageComponentLayout layout;
		[Export ("layout")]
		LineSDKFlexMessageComponentLayout Layout { get; }

		// @property (copy, nonatomic) NSArray<LineSDKFlexMessageComponent *> * _Nonnull contents;
		[Export ("contents", ArgumentSemantic.Copy)]
		LineSDKFlexMessageComponent[] Contents { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable flex;
		[NullAllowed, Export ("flex", ArgumentSemantic.Strong)]
		NSNumber Flex { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentSpacing spacing;
		[Export ("spacing", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentSpacing Spacing { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentMargin margin;
		[Export ("margin", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentMargin Margin { get; set; }

		// @property (nonatomic, strong) LineSDKMessageAction * _Nullable action;
		[NullAllowed, Export ("action", ArgumentSemantic.Strong)]
		LineSDKMessageAction Action { get; set; }

		// -(instancetype _Nonnull)initWithLayout:(enum LineSDKFlexMessageComponentLayout)layout contents:(NSArray<LineSDKFlexMessageComponent *> * _Nonnull)contents __attribute__((objc_designated_initializer));
		[Export ("initWithLayout:contents:")]
		[DesignatedInitializer]
		IntPtr Constructor (LineSDKFlexMessageComponentLayout layout, LineSDKFlexMessageComponent[] contents);

		// -(void)addComponent:(LineSDKFlexMessageComponent * _Nonnull)value;
		[Export ("addComponent:")]
		void AddComponent (LineSDKFlexMessageComponent value);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKFlexBoxComponent New ();
	}

	// @interface LineSDKFlexMessageContainer : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC27LineSDKFlexMessageContainer")]
	interface LineSDKFlexMessageContainer
	{
		// @property (readonly, nonatomic, strong) LineSDKFlexBubbleContainer * _Nullable bubbleContainer;
		[NullAllowed, Export ("bubbleContainer", ArgumentSemantic.Strong)]
		LineSDKFlexBubbleContainer BubbleContainer { get; }

		// @property (readonly, nonatomic, strong) LineSDKFlexCarouselContainer * _Nullable carouselContainer;
		[NullAllowed, Export ("carouselContainer", ArgumentSemantic.Strong)]
		LineSDKFlexCarouselContainer CarouselContainer { get; }
	}

	// @interface LineSDKFlexBubbleContainer : LineSDKFlexMessageContainer
	[BaseType (typeof(LineSDKFlexMessageContainer), Name = "_TtC11LineSDKObjC26LineSDKFlexBubbleContainer")]
	interface LineSDKFlexBubbleContainer
	{
		// @property (nonatomic, strong) LineSDKFlexBoxComponent * _Nullable header;
		[NullAllowed, Export ("header", ArgumentSemantic.Strong)]
		LineSDKFlexBoxComponent Header { get; set; }

		// @property (nonatomic, strong) LineSDKFlexImageComponent * _Nullable hero;
		[NullAllowed, Export ("hero", ArgumentSemantic.Strong)]
		LineSDKFlexImageComponent Hero { get; set; }

		// @property (nonatomic, strong) LineSDKFlexBoxComponent * _Nullable body;
		[NullAllowed, Export ("body", ArgumentSemantic.Strong)]
		LineSDKFlexBoxComponent Body { get; set; }

		// @property (nonatomic, strong) LineSDKFlexBoxComponent * _Nullable footer;
		[NullAllowed, Export ("footer", ArgumentSemantic.Strong)]
		LineSDKFlexBoxComponent Footer { get; set; }

		// @property (nonatomic, strong) LineSDKFlexBubbleContainerStyle * _Nullable style;
		[NullAllowed, Export ("style", ArgumentSemantic.Strong)]
		LineSDKFlexBubbleContainerStyle Style { get; set; }

		// @property (nonatomic) enum LineSDKFlexBubbleContainerDirection direction;
		[Export ("direction", ArgumentSemantic.Assign)]
		LineSDKFlexBubbleContainerDirection Direction { get; set; }
	}

	// @interface LineSDKFlexBubbleContainerStyle : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC31LineSDKFlexBubbleContainerStyle")]
	interface LineSDKFlexBubbleContainerStyle
	{
		// @property (nonatomic, strong) LineSDKFlexBlockStyle * _Nullable header;
		[NullAllowed, Export ("header", ArgumentSemantic.Strong)]
		LineSDKFlexBlockStyle Header { get; set; }

		// @property (nonatomic, strong) LineSDKFlexBlockStyle * _Nullable hero;
		[NullAllowed, Export ("hero", ArgumentSemantic.Strong)]
		LineSDKFlexBlockStyle Hero { get; set; }

		// @property (nonatomic, strong) LineSDKFlexBlockStyle * _Nullable body;
		[NullAllowed, Export ("body", ArgumentSemantic.Strong)]
		LineSDKFlexBlockStyle Body { get; set; }

		// @property (nonatomic, strong) LineSDKFlexBlockStyle * _Nullable footer;
		[NullAllowed, Export ("footer", ArgumentSemantic.Strong)]
		LineSDKFlexBlockStyle Footer { get; set; }
	}

	// @interface LineSDKFlexButtonComponent : LineSDKFlexMessageComponent
	[BaseType (typeof(LineSDKFlexMessageComponent), Name = "_TtC11LineSDKObjC26LineSDKFlexButtonComponent")]
	[DisableDefaultCtor]
	interface LineSDKFlexButtonComponent
	{
		// @property (nonatomic, strong) LineSDKMessageAction * _Nonnull action;
		[Export ("action", ArgumentSemantic.Strong)]
		LineSDKMessageAction Action { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable flex;
		[NullAllowed, Export ("flex", ArgumentSemantic.Strong)]
		NSNumber Flex { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentMargin margin;
		[Export ("margin", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentMargin Margin { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentHeight height;
		[Export ("height", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentHeight Height { get; set; }

		// @property (nonatomic) enum LineSDKFlexButtonComponentStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		LineSDKFlexButtonComponentStyle Style { get; set; }

		// @property (nonatomic, strong) LineSDKHexColor * _Nullable color;
		[NullAllowed, Export ("color", ArgumentSemantic.Strong)]
		LineSDKHexColor Color { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentGravity gravity;
		[Export ("gravity", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentGravity Gravity { get; set; }

		// -(instancetype _Nonnull)initWithAction:(LineSDKMessageAction * _Nonnull)action __attribute__((objc_designated_initializer));
		[Export ("initWithAction:")]
		[DesignatedInitializer]
		IntPtr Constructor (LineSDKMessageAction action);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKFlexButtonComponent New ();
	}

	// @interface LineSDKFlexCarouselContainer : LineSDKFlexMessageContainer
	[BaseType (typeof(LineSDKFlexMessageContainer), Name = "_TtC11LineSDKObjC28LineSDKFlexCarouselContainer")]
	[DisableDefaultCtor]
	interface LineSDKFlexCarouselContainer
	{
		// @property (copy, nonatomic) NSArray<LineSDKFlexBubbleContainer *> * _Nonnull contents;
		[Export ("contents", ArgumentSemantic.Copy)]
		LineSDKFlexBubbleContainer[] Contents { get; set; }

		// -(instancetype _Nonnull)initWithContents:(NSArray<LineSDKFlexBubbleContainer *> * _Nonnull)contents __attribute__((objc_designated_initializer));
		[Export ("initWithContents:")]
		[DesignatedInitializer]
		IntPtr Constructor (LineSDKFlexBubbleContainer[] contents);

		// -(void)addBubble:(LineSDKFlexBubbleContainer * _Nonnull)value;
		[Export ("addBubble:")]
		void AddBubble (LineSDKFlexBubbleContainer value);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKFlexCarouselContainer New ();
	}

	// @interface LineSDKFlexFillerComponent : LineSDKFlexMessageComponent
	[BaseType (typeof(LineSDKFlexMessageComponent), Name = "_TtC11LineSDKObjC26LineSDKFlexFillerComponent")]
	interface LineSDKFlexFillerComponent
	{
	}

	// @interface LineSDKFlexIconComponent : LineSDKFlexMessageComponent
	[BaseType (typeof(LineSDKFlexMessageComponent), Name = "_TtC11LineSDKObjC24LineSDKFlexIconComponent")]
	[DisableDefaultCtor]
	interface LineSDKFlexIconComponent
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nonnull url;
		[Export ("url", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL Url { get; }
		NSUrl Url { get; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentMargin margin;
		[Export ("margin", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentMargin Margin { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentSize Size { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentAspectRatio aspectRatio;
		[Export ("aspectRatio", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentAspectRatio AspectRatio { get; set; }

		// -(instancetype _Nullable)initWithIconURL:(NSURL * _Nonnull)iconURL __attribute__((objc_designated_initializer));
		[Export ("initWithIconURL:")]
		[DesignatedInitializer]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		IntPtr Constructor (NSURL iconURL);
		IntPtr Constructor (NSUrl iconURL);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKFlexIconComponent New ();
	}

	// @interface LineSDKFlexImageComponent : LineSDKFlexMessageComponent
	[BaseType (typeof(LineSDKFlexMessageComponent), Name = "_TtC11LineSDKObjC25LineSDKFlexImageComponent")]
	[DisableDefaultCtor]
	interface LineSDKFlexImageComponent
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nonnull url;
		[Export ("url", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL Url { get; }
		NSUrl Url { get; }

		// @property (nonatomic, strong) NSNumber * _Nullable flex;
		[NullAllowed, Export ("flex", ArgumentSemantic.Strong)]
		NSNumber Flex { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentMargin margin;
		[Export ("margin", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentMargin Margin { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentAlignment alignment;
		[Export ("alignment", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentAlignment Alignment { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentGravity gravity;
		[Export ("gravity", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentGravity Gravity { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentSize Size { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentAspectRatio aspectRatio;
		[Export ("aspectRatio", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentAspectRatio AspectRatio { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentAspectMode aspectMode;
		[Export ("aspectMode", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentAspectMode AspectMode { get; set; }

		// @property (nonatomic, strong) LineSDKHexColor * _Nullable backgroundColor;
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
		LineSDKHexColor BackgroundColor { get; set; }

		// -(instancetype _Nullable)initWithImageURL:(NSURL * _Nonnull)imageURL __attribute__((objc_designated_initializer));
		[Export ("initWithImageURL:")]
		[DesignatedInitializer]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		IntPtr Constructor (NSURL imageURL);
		IntPtr Constructor (NSUrl imageURL);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKFlexImageComponent New ();
	}

	// @interface LineSDKFlexMessage : LineSDKMessage
	[BaseType (typeof(LineSDKMessage), Name = "_TtC11LineSDKObjC18LineSDKFlexMessage")]
	[DisableDefaultCtor]
	interface LineSDKFlexMessage
	{
		// @property (copy, nonatomic) NSString * _Nonnull altText;
		[Export ("altText")]
		string AltText { get; set; }

		// @property (nonatomic, strong) LineSDKFlexMessageContainer * _Nonnull contents;
		[Export ("contents", ArgumentSemantic.Strong)]
		LineSDKFlexMessageContainer Contents { get; set; }

		// -(instancetype _Nonnull)initWithAltText:(NSString * _Nonnull)altText container:(LineSDKFlexMessageContainer * _Nonnull)container __attribute__((objc_designated_initializer));
		[Export ("initWithAltText:container:")]
		[DesignatedInitializer]
		IntPtr Constructor (string altText, LineSDKFlexMessageContainer container);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKFlexMessage New ();
	}

	// @interface LineSDKFlexSeparatorComponent : LineSDKFlexMessageComponent
	[BaseType (typeof(LineSDKFlexMessageComponent), Name = "_TtC11LineSDKObjC29LineSDKFlexSeparatorComponent")]
	[DisableDefaultCtor]
	interface LineSDKFlexSeparatorComponent
	{
		// @property (nonatomic) enum LineSDKFlexMessageComponentMargin margin;
		[Export ("margin", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentMargin Margin { get; set; }

		// @property (nonatomic, strong) LineSDKHexColor * _Nullable color;
		[NullAllowed, Export ("color", ArgumentSemantic.Strong)]
		LineSDKHexColor Color { get; set; }

		// -(instancetype _Nonnull)initWithMargin:(enum LineSDKFlexMessageComponentMargin)margin color:(LineSDKHexColor * _Nullable)color __attribute__((objc_designated_initializer));
		[Export ("initWithMargin:color:")]
		[DesignatedInitializer]
		IntPtr Constructor (LineSDKFlexMessageComponentMargin margin, [NullAllowed] LineSDKHexColor color);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKFlexSeparatorComponent New ();
	}

	// @interface LineSDKFlexSpacerComponent : LineSDKFlexMessageComponent
	[BaseType (typeof(LineSDKFlexMessageComponent), Name = "_TtC11LineSDKObjC26LineSDKFlexSpacerComponent")]
	[DisableDefaultCtor]
	interface LineSDKFlexSpacerComponent
	{
		// @property (nonatomic) enum LineSDKFlexMessageComponentSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentSize Size { get; set; }

		// -(instancetype _Nonnull)initWithSize:(enum LineSDKFlexMessageComponentSize)size __attribute__((objc_designated_initializer));
		[Export ("initWithSize:")]
		[DesignatedInitializer]
		IntPtr Constructor (LineSDKFlexMessageComponentSize size);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKFlexSpacerComponent New ();
	}

	// @interface LineSDKFlexTextComponent : LineSDKFlexMessageComponent
	[BaseType (typeof(LineSDKFlexMessageComponent), Name = "_TtC11LineSDKObjC24LineSDKFlexTextComponent")]
	[DisableDefaultCtor]
	interface LineSDKFlexTextComponent
	{
		// @property (copy, nonatomic) NSString * _Nonnull text;
		[Export ("text")]
		string Text { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable flex;
		[NullAllowed, Export ("flex", ArgumentSemantic.Strong)]
		NSNumber Flex { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentMargin margin;
		[Export ("margin", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentMargin Margin { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentSize Size { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentAlignment alignment;
		[Export ("alignment", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentAlignment Alignment { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentGravity gravity;
		[Export ("gravity", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentGravity Gravity { get; set; }

		// @property (nonatomic) BOOL wrapping;
		[Export ("wrapping")]
		bool Wrapping { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable maxLines;
		[NullAllowed, Export ("maxLines", ArgumentSemantic.Strong)]
		NSNumber MaxLines { get; set; }

		// @property (nonatomic) enum LineSDKFlexMessageComponentWeight weight;
		[Export ("weight", ArgumentSemantic.Assign)]
		LineSDKFlexMessageComponentWeight Weight { get; set; }

		// @property (nonatomic, strong) LineSDKHexColor * _Nullable color;
		[NullAllowed, Export ("color", ArgumentSemantic.Strong)]
		LineSDKHexColor Color { get; set; }

		// @property (nonatomic, strong) LineSDKMessageAction * _Nullable action;
		[NullAllowed, Export ("action", ArgumentSemantic.Strong)]
		LineSDKMessageAction Action { get; set; }

		// -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text __attribute__((objc_designated_initializer));
		[Export ("initWithText:")]
		[DesignatedInitializer]
		IntPtr Constructor (string text);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKFlexTextComponent New ();
	}

	// @interface LineSDKGetApproversInFriendsResponse : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC36LineSDKGetApproversInFriendsResponse")]
	[DisableDefaultCtor]
	interface LineSDKGetApproversInFriendsResponse
	{
		// @property (readonly, copy, nonatomic) NSArray<LineSDKUser *> * _Nonnull friends;
		[Export ("friends", ArgumentSemantic.Copy)]
		LineSDKUser[] Friends { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable pageToken;
		[NullAllowed, Export ("pageToken")]
		string PageToken { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKGetApproversInFriendsResponse New ();
	}

	// @interface LineSDKGetApproversInGroupResponse : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC34LineSDKGetApproversInGroupResponse")]
	[DisableDefaultCtor]
	interface LineSDKGetApproversInGroupResponse
	{
		// @property (readonly, copy, nonatomic) NSArray<LineSDKUser *> * _Nonnull users;
		[Export ("users", ArgumentSemantic.Copy)]
		LineSDKUser[] Users { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable pageToken;
		[NullAllowed, Export ("pageToken")]
		string PageToken { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKGetApproversInGroupResponse New ();
	}

	// @interface LineSDKGetBotFriendshipStatusResponse : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC37LineSDKGetBotFriendshipStatusResponse")]
	[DisableDefaultCtor]
	interface LineSDKGetBotFriendshipStatusResponse
	{
		// @property (readonly, nonatomic) BOOL friendFlag;
		[Export ("friendFlag")]
		bool FriendFlag { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable json;
		[NullAllowed, Export ("json")]
		string Json { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKGetBotFriendshipStatusResponse New ();
	}

	// @interface LineSDKGetFriendsResponse : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC25LineSDKGetFriendsResponse")]
	[DisableDefaultCtor]
	interface LineSDKGetFriendsResponse
	{
		// @property (readonly, copy, nonatomic) NSArray<LineSDKUser *> * _Nonnull friends;
		[Export ("friends", ArgumentSemantic.Copy)]
		LineSDKUser[] Friends { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable pageToken;
		[NullAllowed, Export ("pageToken")]
		string PageToken { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKGetFriendsResponse New ();
	}

	// @interface LineSDKGetGroupsResponse : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC24LineSDKGetGroupsResponse")]
	[DisableDefaultCtor]
	interface LineSDKGetGroupsResponse
	{
		// @property (readonly, copy, nonatomic) NSArray<LineSDKGroup *> * _Nonnull groups;
		[Export ("groups", ArgumentSemantic.Copy)]
		LineSDKGroup[] Groups { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable pageToken;
		[NullAllowed, Export ("pageToken")]
		string PageToken { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKGetGroupsResponse New ();
	}

	// @interface LineSDKGroup : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC12LineSDKGroup")]
	[DisableDefaultCtor]
	interface LineSDKGroup
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull groupID;
		[Export ("groupID")]
		string GroupID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull groupName;
		[Export ("groupName")]
		string GroupName { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable pictureURL;
		[NullAllowed, Export ("pictureURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL PictureURL { get; }
		NSUrl PictureURL { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable pictureURLSmall;
		[NullAllowed, Export ("pictureURLSmall", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL PictureURLSmall { get; }
		NSUrl PictureURLSmall { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKGroup New ();
	}

	// @protocol LineSDKShareTarget
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol (Name = "_TtP11LineSDKObjC18LineSDKShareTarget_")]
	interface LineSDKShareTarget
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull targetID;
		[Abstract]
		[Export ("targetID")]
		string TargetID { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull displayName;
		[Abstract]
		[Export ("displayName")]
		string DisplayName { get; }

		// @required @property (readonly, copy, nonatomic) NSURL * _Nullable avatarURL;
		[Abstract]
		[NullAllowed, Export ("avatarURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL AvatarURL { get; }
		NSUrl AvatarURL { get; }
	}

	// @interface LineSDKObjC_Swift_836 (LineSDKGroup) <LineSDKShareTarget>
	[Category]
	[BaseType (typeof(LineSDKGroup))]
	interface LineSDKGroup_LineSDKObjC_Swift_836 : ILineSDKShareTarget
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull targetID;
		[Export ("targetID")]
		string TargetID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull displayName;
		[Export ("displayName")]
		string DisplayName { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable avatarURL;
		[NullAllowed, Export ("avatarURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL AvatarURL { get; }
		NSUrl AvatarURL { get; }
	}

	// @interface LineSDKHexColor : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC15LineSDKHexColor")]
	[DisableDefaultCtor]
	interface LineSDKHexColor
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull rawValue;
		[Export ("rawValue")]
		string RawValue { get; }

		// @property (readonly, nonatomic, strong) UIColor * _Nonnull color;
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; }

		// -(instancetype _Nonnull)init:(UIColor * _Nonnull)color __attribute__((objc_designated_initializer));
		[Export ("init:")]
		[DesignatedInitializer]
		IntPtr Constructor (UIColor color);

		// -(instancetype _Nonnull)initWithRawValue:(NSString * _Nonnull)rawValue defaultColor:(UIColor * _Nonnull)color __attribute__((objc_designated_initializer));
		[Export ("initWithRawValue:defaultColor:")]
		[DesignatedInitializer]
		IntPtr Constructor (string rawValue, UIColor color);

		// -(BOOL)isEqualsToColor:(LineSDKHexColor * _Nonnull)another __attribute__((warn_unused_result("")));
		[Export ("isEqualsToColor:")]
		bool IsEqualsToColor (LineSDKHexColor another);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKHexColor New ();
	}

	// @interface LineSDKImageMessage : LineSDKMessage
	[BaseType (typeof(LineSDKMessage), Name = "_TtC11LineSDKObjC19LineSDKImageMessage")]
	[DisableDefaultCtor]
	interface LineSDKImageMessage
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nonnull originalContentURL;
		[Export ("originalContentURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL OriginalContentURL { get; }
		NSUrl OriginalContentURL { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nonnull previewImageURL;
		[Export ("previewImageURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL PreviewImageURL { get; }
		NSUrl PreviewImageURL { get; }

		// @property (nonatomic) BOOL animated;
		[Export ("animated")]
		bool Animated { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable fileExtension;
		[NullAllowed, Export ("fileExtension")]
		string FileExtension { get; set; }

		// @property (nonatomic, strong) LineSDKMessageSender * _Nullable sender;
		[NullAllowed, Export ("sender", ArgumentSemantic.Strong)]
		LineSDKMessageSender Sender { get; set; }

		// -(instancetype _Nullable)initWithOriginalContentURL:(NSURL * _Nonnull)originalContentURL previewImageURL:(NSURL * _Nonnull)previewImageURL;
		[Export ("initWithOriginalContentURL:previewImageURL:")]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		IntPtr Constructor (NSURL originalContentURL, NSURL previewImageURL);
		IntPtr Constructor (NSUrl originalContentURL, NSUrl previewImageURL);

		// -(instancetype _Nullable)initWithOriginalContentURL:(NSURL * _Nonnull)originalContentURL previewImageURL:(NSURL * _Nonnull)previewImageURL animated:(BOOL)animated fileExtension:(NSString * _Nullable)fileExtension sender:(LineSDKMessageSender * _Nullable)sender __attribute__((objc_designated_initializer));
		[Export ("initWithOriginalContentURL:previewImageURL:animated:fileExtension:sender:")]
		[DesignatedInitializer]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		IntPtr Constructor (NSURL originalContentURL, NSURL previewImageURL, bool animated, [NullAllowed] string fileExtension, [NullAllowed] LineSDKMessageSender sender);
		IntPtr Constructor (NSUrl originalContentURL, NSUrl previewImageURL, bool animated, [NullAllowed] string fileExtension, [NullAllowed] LineSDKMessageSender sender);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKImageMessage New ();
	}

	// @interface LineSDKJWT : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC10LineSDKJWT")]
	[DisableDefaultCtor]
	interface LineSDKJWT
	{
		// @property (readonly, nonatomic, strong) LineSDKJWTPayload * _Nonnull payload;
		[Export ("payload", ArgumentSemantic.Strong)]
		LineSDKJWTPayload Payload { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKJWT New ();
	}

	// @interface LineSDKJWTPayload : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC17LineSDKJWTPayload")]
	[DisableDefaultCtor]
	interface LineSDKJWTPayload
	{
		// -(NSString * _Nullable)getStringForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export ("getStringForKey:")]
		[return: NullAllowed]
		string GetStringForKey (string key);

		// -(NSNumber * _Nullable)getNumberForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export ("getNumberForKey:")]
		[return: NullAllowed]
		NSNumber GetNumberForKey (string key);

		// @property (readonly, copy, nonatomic) NSString * _Nullable issuer;
		[NullAllowed, Export ("issuer")]
		string Issuer { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable subject;
		[NullAllowed, Export ("subject")]
		string Subject { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable audience;
		[NullAllowed, Export ("audience")]
		string Audience { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable expiration;
		[NullAllowed, Export ("expiration", ArgumentSemantic.Copy)]
		NSDate Expiration { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable issueAt;
		[NullAllowed, Export ("issueAt", ArgumentSemantic.Copy)]
		NSDate IssueAt { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable picture;
		[NullAllowed, Export ("picture", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL Picture { get; }
		NSUrl Picture { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable amr;
		[NullAllowed, Export ("amr", ArgumentSemantic.Copy)]
		string[] Amr { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKJWTPayload New ();
	}

	// @interface LineSDKLocationMessage : LineSDKMessage
	[BaseType (typeof(LineSDKMessage), Name = "_TtC11LineSDKObjC22LineSDKLocationMessage")]
	[DisableDefaultCtor]
	interface LineSDKLocationMessage
	{
		// @property (copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull address;
		[Export ("address")]
		string Address { get; set; }

		// @property (nonatomic) double latitude;
		[Export ("latitude")]
		double Latitude { get; set; }

		// @property (nonatomic) double longitude;
		[Export ("longitude")]
		double Longitude { get; set; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title address:(NSString * _Nonnull)address latitude:(double)latitude longitude:(double)longitude __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:address:latitude:longitude:")]
		[DesignatedInitializer]
		IntPtr Constructor (string title, string address, double latitude, double longitude);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKLocationMessage New ();
	}

	// @interface LineSDKLoginButton : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC18LineSDKLoginButton")]
	interface LineSDKLoginButton
	{
		// @property (readonly, nonatomic, strong) UIButton * _Nonnull button;
		[Export ("button", ArgumentSemantic.Strong)]
		UIButton Button { get; }

		[Wrap ("WeakLoginDelegate")]
		[NullAllowed]
		LineSDKLoginButtonDelegate LoginDelegate { get; set; }

		// @property (nonatomic, weak) id<LineSDKLoginButtonDelegate> _Nullable loginDelegate;
		[NullAllowed, Export ("loginDelegate", ArgumentSemantic.Weak)]
		NSObject WeakLoginDelegate { get; set; }

		// @property (nonatomic, weak) UIViewController * _Nullable buttonPresentingViewController;
		[NullAllowed, Export ("buttonPresentingViewController", ArgumentSemantic.Weak)]
		UIViewController ButtonPresentingViewController { get; set; }

		// @property (copy, nonatomic) NSSet<LineSDKLoginPermission *> * _Nonnull loginPermissions;
		[Export ("loginPermissions", ArgumentSemantic.Copy)]
		NSSet<LineSDKLoginPermission> LoginPermissions { get; set; }

		// @property (nonatomic, strong) LineSDKLoginManagerParameters * _Nonnull loginManagerParameters;
		[Export ("loginManagerParameters", ArgumentSemantic.Strong)]
		LineSDKLoginManagerParameters LoginManagerParameters { get; set; }

		// @property (nonatomic) enum LineSDKLoginButtonSize buttonSizeValue;
		[Export ("buttonSizeValue", ArgumentSemantic.Assign)]
		LineSDKLoginButtonSize ButtonSizeValue { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable buttonTextValue;
		[NullAllowed, Export ("buttonTextValue")]
		string ButtonTextValue { get; set; }

		// -(void)login;
		[Export ("login")]
		void Login ();

		// @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("Use `LineSDKLoginButton.loginManagerParameters` instead.") NSArray<LineSDKLoginManagerOptions *> * loginManagerOptions __attribute__((deprecated("Use `LineSDKLoginButton.loginManagerParameters` instead.")));
		[Export ("loginManagerOptions", ArgumentSemantic.Copy)]
		LineSDKLoginManagerOptions[] LoginManagerOptions { get; set; }
	}

	// @protocol LineSDKLoginButtonDelegate
	[Protocol (Name = "_TtP11LineSDKObjC26LineSDKLoginButtonDelegate_"), Model (AutoGeneratedName = true)]
	interface LineSDKLoginButtonDelegate
	{
		// @required -(void)loginButtonDidStartLogin:(LineSDKLoginButton * _Nonnull)button;
		[Abstract]
		[Export ("loginButtonDidStartLogin:")]
		void LoginButtonDidStartLogin (LineSDKLoginButton button);

		// @required -(void)loginButton:(LineSDKLoginButton * _Nonnull)button didSucceedLogin:(LineSDKLoginResult * _Nullable)loginResult;
		[Abstract]
		[Export ("loginButton:didSucceedLogin:")]
		void LoginButton (LineSDKLoginButton button, [NullAllowed] LineSDKLoginResult loginResult);

		// @required -(void)loginButton:(LineSDKLoginButton * _Nonnull)button didFailLogin:(NSError * _Nullable)error;
		[Abstract]
		[Export ("loginButton:didFailLogin:")]
		void LoginButton (LineSDKLoginButton button, [NullAllowed] NSError error);
	}

	// @interface LineSDKLoginManager : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC19LineSDKLoginManager")]
	[DisableDefaultCtor]
	interface LineSDKLoginManager
	{
		// @property (readonly, nonatomic, strong, class) LineSDKLoginManager * _Nonnull sharedManager;
		[Static]
		[Export ("sharedManager", ArgumentSemantic.Strong)]
		LineSDKLoginManager SharedManager { get; }

		// @property (readonly, nonatomic, strong) LineSDKLoginProcess * _Nullable currentProcess;
		[NullAllowed, Export ("currentProcess", ArgumentSemantic.Strong)]
		LineSDKLoginProcess CurrentProcess { get; }

		// @property (readonly, nonatomic) BOOL isSetupFinished;
		[Export ("isSetupFinished")]
		bool IsSetupFinished { get; }

		// @property (readonly, nonatomic) BOOL isAuthorized;
		[Export ("isAuthorized")]
		bool IsAuthorized { get; }

		// @property (readonly, nonatomic) BOOL isAuthorizing;
		[Export ("isAuthorizing")]
		bool IsAuthorizing { get; }

		// @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("Set `preferredWebPageLanguage` in `LineSDKLoginManagerParameters` instead.") NSString * preferredWebPageLanguage __attribute__((deprecated("Set `preferredWebPageLanguage` in `LineSDKLoginManagerParameters` instead.")));
		[Export ("preferredWebPageLanguage")]
		string PreferredWebPageLanguage { get; set; }

		// -(void)setupWithChannelID:(NSString * _Nonnull)channelID universalLinkURL:(NSURL * _Nullable)universalLinkURL;
		[Export ("setupWithChannelID:universalLinkURL:")]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		void SetupWithChannelID (string channelID, [NullAllowed] NSURL universalLinkURL);
		void SetupWithChannelID (string channelID, [NullAllowed] NSUrl universalLinkURL);

		// -(LineSDKLoginProcess * _Nullable)loginWithPermissions:(NSSet<LineSDKLoginPermission *> * _Nullable)permissions inViewController:(UIViewController * _Nullable)viewController completionHandler:(void (^ _Nonnull)(LineSDKLoginResult * _Nullable, NSError * _Nullable))completion;
		[Export ("loginWithPermissions:inViewController:completionHandler:")]
		[return: NullAllowed]
		LineSDKLoginProcess LoginWithPermissions ([NullAllowed] NSSet<LineSDKLoginPermission> permissions, [NullAllowed] UIViewController viewController, Action<LineSDKLoginResult, NSError> completion);

		// -(LineSDKLoginProcess * _Nullable)loginWithPermissions:(NSSet<LineSDKLoginPermission *> * _Nullable)permissions inViewController:(UIViewController * _Nullable)viewController parameters:(LineSDKLoginManagerParameters * _Nonnull)parameters completionHandler:(void (^ _Nonnull)(LineSDKLoginResult * _Nullable, NSError * _Nullable))completion;
		[Export ("loginWithPermissions:inViewController:parameters:completionHandler:")]
		[return: NullAllowed]
		LineSDKLoginProcess LoginWithPermissions ([NullAllowed] NSSet<LineSDKLoginPermission> permissions, [NullAllowed] UIViewController viewController, LineSDKLoginManagerParameters parameters, Action<LineSDKLoginResult, NSError> completion);

		// -(void)logoutWithCompletionHandler:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Export ("logoutWithCompletionHandler:")]
		void LogoutWithCompletionHandler (Action<NSError> completion);

		// -(BOOL)application:(UIApplication * _Nonnull)app open:(NSURL * _Nonnull)url options:(NSDictionary<UIApplicationOpenURLOptionsKey,id> * _Nonnull)options __attribute__((warn_unused_result("")));
		[Export ("application:open:options:")]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		bool Application (UIApplication app, NSURL url, NSDictionary<NSString, NSObject> options);
		bool Application (UIApplication app, NSUrl url, NSDictionary<NSString, NSObject> options);

		// -(LineSDKLoginProcess * _Nullable)loginWithPermissions:(NSSet<LineSDKLoginPermission *> * _Nullable)permissions inViewController:(UIViewController * _Nullable)viewController options:(NSArray<LineSDKLoginManagerOptions *> * _Nullable)options completionHandler:(void (^ _Nonnull)(LineSDKLoginResult * _Nullable, NSError * _Nullable))completion __attribute__((deprecated("
/* [Fix]Error CS1003: Syntax error
    Convert the `options` to a `LoginManager.Parameters` value and
    use `login(permissions:inViewController:parameters:completionHandler:)` instead.")
    ")));
*/
		[Export ("loginWithPermissions:inViewController:options:completionHandler:")]
		[return: NullAllowed]
		LineSDKLoginProcess LoginWithPermissions ([NullAllowed] NSSet<LineSDKLoginPermission> permissions, [NullAllowed] UIViewController viewController, [NullAllowed] LineSDKLoginManagerOptions[] options, Action<LineSDKLoginResult, NSError> completion);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKLoginManager New ();
	}

	// @interface LineSDKLoginManagerBotPrompt : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC28LineSDKLoginManagerBotPrompt")]
	[DisableDefaultCtor]
	interface LineSDKLoginManagerBotPrompt
	{
		// @property (readonly, nonatomic, strong, class) LineSDKLoginManagerBotPrompt * _Nonnull normal;
		[Static]
		[Export ("normal", ArgumentSemantic.Strong)]
		LineSDKLoginManagerBotPrompt Normal { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginManagerBotPrompt * _Nonnull aggressive;
		[Static]
		[Export ("aggressive", ArgumentSemantic.Strong)]
		LineSDKLoginManagerBotPrompt Aggressive { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull rawValue;
		[Export ("rawValue")]
		string RawValue { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKLoginManagerBotPrompt New ();
	}

	// @interface LineSDKLoginManagerOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC26LineSDKLoginManagerOptions")]
	[DisableDefaultCtor]
	interface LineSDKLoginManagerOptions
	{
		// -(instancetype _Nonnull)initWithRawValue:(NSInteger)rawValue __attribute__((objc_designated_initializer));
		[Export ("initWithRawValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (nint rawValue);

		// @property (readonly, nonatomic, strong, class) LineSDKLoginManagerOptions * _Nonnull onlyWebLogin;
		[Static]
		[Export ("onlyWebLogin", ArgumentSemantic.Strong)]
		LineSDKLoginManagerOptions OnlyWebLogin { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginManagerOptions * _Nonnull botPromptNormal;
		[Static]
		[Export ("botPromptNormal", ArgumentSemantic.Strong)]
		LineSDKLoginManagerOptions BotPromptNormal { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginManagerOptions * _Nonnull botPromptAggressive;
		[Static]
		[Export ("botPromptAggressive", ArgumentSemantic.Strong)]
		LineSDKLoginManagerOptions BotPromptAggressive { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKLoginManagerOptions New ();
	}

	// @interface LineSDKLoginManagerParameters : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC29LineSDKLoginManagerParameters")]
	interface LineSDKLoginManagerParameters
	{
		// @property (nonatomic) BOOL onlyWebLogin;
		[Export ("onlyWebLogin")]
		bool OnlyWebLogin { get; set; }

		// @property (nonatomic, strong) LineSDKLoginManagerBotPrompt * _Nullable botPromptStyle;
		[NullAllowed, Export ("botPromptStyle", ArgumentSemantic.Strong)]
		LineSDKLoginManagerBotPrompt BotPromptStyle { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable preferredWebPageLanguage;
		[NullAllowed, Export ("preferredWebPageLanguage")]
		string PreferredWebPageLanguage { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable IDTokenNonce;
		[NullAllowed, Export ("IDTokenNonce")]
		string IDTokenNonce { get; set; }
	}

	// @interface LineSDKLoginPermission : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC22LineSDKLoginPermission")]
	[DisableDefaultCtor]
	interface LineSDKLoginPermission
	{
		// -(instancetype _Nonnull)initWithRawValue:(NSString * _Nonnull)rawValue __attribute__((objc_designated_initializer));
		[Export ("initWithRawValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (string rawValue);

		// +(NSSet<LineSDKLoginPermission *> * _Nonnull)permissionsFrom:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
		[Static]
		[Export ("permissionsFrom:")]
		NSSet<LineSDKLoginPermission> PermissionsFrom (string @string);

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull openID;
		[Static]
		[Export ("openID", ArgumentSemantic.Strong)]
		LineSDKLoginPermission OpenID { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull profile;
		[Static]
		[Export ("profile", ArgumentSemantic.Strong)]
		LineSDKLoginPermission Profile { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull friends;
		[Static]
		[Export ("friends", ArgumentSemantic.Strong)]
		LineSDKLoginPermission Friends { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull groups;
		[Static]
		[Export ("groups", ArgumentSemantic.Strong)]
		LineSDKLoginPermission Groups { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull oneTimeShare;
		[Static]
		[Export ("oneTimeShare", ArgumentSemantic.Strong)]
		LineSDKLoginPermission OneTimeShare { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull messageWrite;
		[Static]
		[Export ("messageWrite", ArgumentSemantic.Strong)]
		LineSDKLoginPermission MessageWrite { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull email;
		[Static]
		[Export ("email", ArgumentSemantic.Strong)]
		LineSDKLoginPermission Email { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull phone;
		[Static]
		[Export ("phone", ArgumentSemantic.Strong)]
		LineSDKLoginPermission Phone { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull gender;
		[Static]
		[Export ("gender", ArgumentSemantic.Strong)]
		LineSDKLoginPermission Gender { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull birthdate;
		[Static]
		[Export ("birthdate", ArgumentSemantic.Strong)]
		LineSDKLoginPermission Birthdate { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull address;
		[Static]
		[Export ("address", ArgumentSemantic.Strong)]
		LineSDKLoginPermission Address { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull realName;
		[Static]
		[Export ("realName", ArgumentSemantic.Strong)]
		LineSDKLoginPermission RealName { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull openChatTermStatus;
		[Static]
		[Export ("openChatTermStatus", ArgumentSemantic.Strong)]
		LineSDKLoginPermission OpenChatTermStatus { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull openChatRoomCreateAndJoin;
		[Static]
		[Export ("openChatRoomCreateAndJoin", ArgumentSemantic.Strong)]
		LineSDKLoginPermission OpenChatRoomCreateAndJoin { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull openChatInfo;
		[Static]
		[Export ("openChatInfo", ArgumentSemantic.Strong)]
		LineSDKLoginPermission OpenChatInfo { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull openChatPlugManagement;
		[Static]
		[Export ("openChatPlugManagement", ArgumentSemantic.Strong)]
		LineSDKLoginPermission OpenChatPlugManagement { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull openChatPlugInfo;
		[Static]
		[Export ("openChatPlugInfo", ArgumentSemantic.Strong)]
		LineSDKLoginPermission OpenChatPlugInfo { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull openChatPlugProfile;
		[Static]
		[Export ("openChatPlugProfile", ArgumentSemantic.Strong)]
		LineSDKLoginPermission OpenChatPlugProfile { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull openChatPlugSendMessage;
		[Static]
		[Export ("openChatPlugSendMessage", ArgumentSemantic.Strong)]
		LineSDKLoginPermission OpenChatPlugSendMessage { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKLoginPermission * _Nonnull openChatPlugReceiveMessageEvent;
		[Static]
		[Export ("openChatPlugReceiveMessageEvent", ArgumentSemantic.Strong)]
		LineSDKLoginPermission OpenChatPlugReceiveMessageEvent { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKLoginPermission New ();
	}

	// @interface LineSDKLoginProcess : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC19LineSDKLoginProcess")]
	[DisableDefaultCtor]
	interface LineSDKLoginProcess
	{
		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKLoginProcess New ();
	}

	// @interface LineSDKLoginResult : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC18LineSDKLoginResult")]
	[DisableDefaultCtor]
	interface LineSDKLoginResult
	{
		// @property (readonly, nonatomic, strong) LineSDKAccessToken * _Nonnull accessToken;
		[Export ("accessToken", ArgumentSemantic.Strong)]
		LineSDKAccessToken AccessToken { get; }

		// @property (readonly, copy, nonatomic) NSSet<LineSDKLoginPermission *> * _Nonnull permissions;
		[Export ("permissions", ArgumentSemantic.Copy)]
		NSSet<LineSDKLoginPermission> Permissions { get; }

		// @property (readonly, nonatomic, strong) LineSDKUserProfile * _Nullable userProfile;
		[NullAllowed, Export ("userProfile", ArgumentSemantic.Strong)]
		LineSDKUserProfile UserProfile { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable friendshipStatusChanged;
		[NullAllowed, Export ("friendshipStatusChanged", ArgumentSemantic.Strong)]
		NSNumber FriendshipStatusChanged { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable IDTokenNonce;
		[NullAllowed, Export ("IDTokenNonce")]
		string IDTokenNonce { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable json;
		[NullAllowed, Export ("json")]
		string Json { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKLoginResult New ();
	}

	// @interface LineSDKMessageAction : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC20LineSDKMessageAction")]
	interface LineSDKMessageAction
	{
		// @property (readonly, nonatomic, strong) LineSDKMessageURIAction * _Nullable URIAction;
		[NullAllowed, Export ("URIAction", ArgumentSemantic.Strong)]
		LineSDKMessageURIAction URIAction { get; }
	}

	// @interface LineSDKMessageSender : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC20LineSDKMessageSender")]
	[DisableDefaultCtor]
	interface LineSDKMessageSender
	{
		// @property (copy, nonatomic) NSString * _Nonnull label;
		[Export ("label")]
		string Label { get; set; }

		// @property (copy, nonatomic) NSURL * _Nonnull iconURL;
		[Export ("iconURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL IconURL { get; set; }
		NSUrl IconURL { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable linkURL;
		[NullAllowed, Export ("linkURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL LinkURL { get; set; }
		NSUrl LinkURL { get; set; }

		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nonnull)label iconURL:(NSURL * _Nonnull)iconURL linkURL:(NSURL * _Nullable)linkURL __attribute__((objc_designated_initializer));
		[Export ("initWithLabel:iconURL:linkURL:")]
		[DesignatedInitializer]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		IntPtr Constructor (string label, NSURL iconURL, [NullAllowed] NSURL linkURL);
		IntPtr Constructor (string label, NSUrl iconURL, [NullAllowed] NSUrl linkURL);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKMessageSender New ();
	}

	// @interface LineSDKMessageSendingStatus : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC27LineSDKMessageSendingStatus")]
	[DisableDefaultCtor]
	interface LineSDKMessageSendingStatus
	{
		// @property (readonly, nonatomic, strong, class) LineSDKMessageSendingStatus * _Nonnull statusOK;
		[Static]
		[Export ("statusOK", ArgumentSemantic.Strong)]
		LineSDKMessageSendingStatus StatusOK { get; }

		// @property (readonly, nonatomic, strong, class) LineSDKMessageSendingStatus * _Nonnull statusDiscarded;
		[Static]
		[Export ("statusDiscarded", ArgumentSemantic.Strong)]
		LineSDKMessageSendingStatus StatusDiscarded { get; }

		// -(BOOL)isEqualToStatus:(LineSDKMessageSendingStatus * _Nonnull)another __attribute__((warn_unused_result("")));
		[Export ("isEqualToStatus:")]
		bool IsEqualToStatus (LineSDKMessageSendingStatus another);

		// @property (readonly, nonatomic) BOOL isOK;
		[Export ("isOK")]
		bool IsOK { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKMessageSendingStatus New ();
	}

	// @interface LineSDKMessageSendingToken : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC26LineSDKMessageSendingToken")]
	[DisableDefaultCtor]
	interface LineSDKMessageSendingToken
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull token;
		[Export ("token")]
		string Token { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable json;
		[NullAllowed, Export ("json")]
		string Json { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKMessageSendingToken New ();
	}

	// @interface LineSDKMessageURIAction : LineSDKMessageAction
	[BaseType (typeof(LineSDKMessageAction), Name = "_TtC11LineSDKObjC23LineSDKMessageURIAction")]
	[DisableDefaultCtor]
	interface LineSDKMessageURIAction
	{
		// @property (copy, nonatomic) NSString * _Nullable label;
		[NullAllowed, Export ("label")]
		string Label { get; set; }

		// @property (copy, nonatomic) NSURL * _Nonnull uri;
		[Export ("uri", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL Uri { get; set; }
		NSUrl Uri { get; set; }

		// -(instancetype _Nonnull)initWithLabel:(NSString * _Nullable)label uri:(NSURL * _Nonnull)uri __attribute__((objc_designated_initializer));
		[Export ("initWithLabel:uri:")]
		[DesignatedInitializer]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		IntPtr Constructor ([NullAllowed] string label, NSURL uri);
		IntPtr Constructor ([NullAllowed] string label, NSUrl uri);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKMessageURIAction New ();
	}

	// @interface LineSDKOpenChatCreatingController : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC33LineSDKOpenChatCreatingController")]
	interface LineSDKOpenChatCreatingController
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		LineSDKOpenChatCreatingControllerDelegate Delegate { get; set; }

		// @property (nonatomic, strong) id<LineSDKOpenChatCreatingControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) NSInteger suggestedCategory;
		[Export ("suggestedCategory")]
		nint SuggestedCategory { get; set; }

		// -(void)loadAndPresentIn:(UIViewController * _Nonnull)viewController presentedHandler:(void (^ _Nonnull)(UIViewController * _Nullable, NSError * _Nullable))handler;
		[Export ("loadAndPresentIn:presentedHandler:")]
		void LoadAndPresentIn (UIViewController viewController, Action<UIViewController, NSError> handler);

		// +(LineSDKAuthorizationStatus * _Nonnull)localAuthorizationStatusForCreatingOpenChat __attribute__((warn_unused_result("")));
		[Static]
		[Export ("localAuthorizationStatusForCreatingOpenChat")]
// Fixed
// Error CS0246: The type or namespace name 'VerifyAttribute', 'Verify' could not be found
//		[Verify (MethodToProperty)]
		LineSDKAuthorizationStatus LocalAuthorizationStatusForCreatingOpenChat { get; }
	}

	// @protocol LineSDKOpenChatCreatingControllerDelegate
	[Protocol (Name = "_TtP11LineSDKObjC41LineSDKOpenChatCreatingControllerDelegate_"), Model (AutoGeneratedName = true)]
	interface LineSDKOpenChatCreatingControllerDelegate
	{
		// @optional -(void)openChatCreatingController:(LineSDKOpenChatCreatingController * _Nonnull)controller didCreateChatRoom:(LineSDKOpenChatRoomInfo * _Nonnull)room withCreatingItem:(LineSDKOpenChatRoomCreatingItem * _Nonnull)item;
		[Export ("openChatCreatingController:didCreateChatRoom:withCreatingItem:")]
		void OpenChatCreatingController (LineSDKOpenChatCreatingController controller, LineSDKOpenChatRoomInfo room, LineSDKOpenChatRoomCreatingItem item);

		// @optional -(void)openChatCreatingController:(LineSDKOpenChatCreatingController * _Nonnull)controller didFailWithError:(NSError * _Nonnull)error withCreatingItem:(LineSDKOpenChatRoomCreatingItem * _Nonnull)item presentingViewController:(UIViewController * _Nonnull)presentingViewController;
		[Export ("openChatCreatingController:didFailWithError:withCreatingItem:presentingViewController:")]
		void OpenChatCreatingController (LineSDKOpenChatCreatingController controller, NSError error, LineSDKOpenChatRoomCreatingItem item, UIViewController presentingViewController);

		// @optional -(BOOL)openChatCreatingController:(LineSDKOpenChatCreatingController * _Nonnull)controller shouldPreventUserTermAlertFrom:(UIViewController * _Nonnull)presentingViewController __attribute__((warn_unused_result("")));
		[Export ("openChatCreatingController:shouldPreventUserTermAlertFrom:")]
		bool OpenChatCreatingController (LineSDKOpenChatCreatingController controller, UIViewController presentingViewController);

		// @optional -(void)openChatCreatingControllerDidCancelCreating:(LineSDKOpenChatCreatingController * _Nonnull)controller;
		[Export ("openChatCreatingControllerDidCancelCreating:")]
		void OpenChatCreatingControllerDidCancelCreating (LineSDKOpenChatCreatingController controller);

		// @optional -(void)openChatCreatingController:(LineSDKOpenChatCreatingController * _Nonnull)controller willPresentCreatingNavigationController:(UINavigationController * _Nonnull)navigationController;
		[Export ("openChatCreatingController:willPresentCreatingNavigationController:")]
		void OpenChatCreatingController (LineSDKOpenChatCreatingController controller, UINavigationController navigationController);
	}

	// @interface LineSDKOpenChatRoomCreatingItem : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC31LineSDKOpenChatRoomCreatingItem")]
	[DisableDefaultCtor]
	interface LineSDKOpenChatRoomCreatingItem
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull roomDescription;
		[Export ("roomDescription")]
		string RoomDescription { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull creatorDisplayName;
		[Export ("creatorDisplayName")]
		string CreatorDisplayName { get; }

		// @property (readonly, nonatomic) NSInteger category;
		[Export ("category")]
		nint Category { get; }

		// @property (readonly, nonatomic) BOOL allowSearch;
		[Export ("allowSearch")]
		bool AllowSearch { get; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name roomDescription:(NSString * _Nonnull)roomDescription creatorDisplayName:(NSString * _Nonnull)creatorDisplayName category:(NSInteger)category allowSearch:(BOOL)allowSearch __attribute__((objc_designated_initializer));
		[Export ("initWithName:roomDescription:creatorDisplayName:category:allowSearch:")]
		[DesignatedInitializer]
		IntPtr Constructor (string name, string roomDescription, string creatorDisplayName, nint category, bool allowSearch);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKOpenChatRoomCreatingItem New ();
	}

	// @interface LineSDKOpenChatRoomInfo : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC23LineSDKOpenChatRoomInfo")]
	[DisableDefaultCtor]
	interface LineSDKOpenChatRoomInfo
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull openChatId;
		[Export ("openChatId")]
		string OpenChatId { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nonnull url;
		[Export ("url", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL Url { get; }
		NSUrl Url { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKOpenChatRoomInfo New ();
	}

	// @interface LineSDKOpenChatRoomJoinType : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC27LineSDKOpenChatRoomJoinType")]
	[DisableDefaultCtor]
	interface LineSDKOpenChatRoomJoinType
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export ("type")]
		string Type { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKOpenChatRoomJoinType New ();
	}

	// @interface LineSDKOpenChatRoomMembershipState : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC34LineSDKOpenChatRoomMembershipState")]
	[DisableDefaultCtor]
	interface LineSDKOpenChatRoomMembershipState
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull state;
		[Export ("state")]
		string State { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKOpenChatRoomMembershipState New ();
	}

	// @interface LineSDKOpenChatRoomStatus : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC25LineSDKOpenChatRoomStatus")]
	[DisableDefaultCtor]
	interface LineSDKOpenChatRoomStatus
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull status;
		[Export ("status")]
		string Status { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable json;
		[NullAllowed, Export ("json")]
		string Json { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKOpenChatRoomStatus New ();
	}

	// @interface LineSDKPostMultisendMessagesResponse : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC36LineSDKPostMultisendMessagesResponse")]
	[DisableDefaultCtor]
	interface LineSDKPostMultisendMessagesResponse
	{
		// @property (readonly, copy, nonatomic) NSArray<LineSDKPostMultisendMessagesResponseSendingResult *> * _Nonnull result;
		[Export ("result", ArgumentSemantic.Copy)]
		LineSDKPostMultisendMessagesResponseSendingResult[] Result { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKPostMultisendMessagesResponse New ();
	}

	// @interface LineSDKPostMultisendMessagesResponseSendingResult : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC49LineSDKPostMultisendMessagesResponseSendingResult")]
	[DisableDefaultCtor]
	interface LineSDKPostMultisendMessagesResponseSendingResult
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull to;
		[Export ("to")]
		string To { get; }

		// @property (readonly, nonatomic, strong) LineSDKMessageSendingStatus * _Nonnull status;
		[Export ("status", ArgumentSemantic.Strong)]
		LineSDKMessageSendingStatus Status { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKPostMultisendMessagesResponseSendingResult New ();
	}

	// @interface LineSDKPostSendMessagesResponse : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC31LineSDKPostSendMessagesResponse")]
	[DisableDefaultCtor]
	interface LineSDKPostSendMessagesResponse
	{
		// @property (readonly, nonatomic, strong) LineSDKMessageSendingStatus * _Nonnull status;
		[Export ("status", ArgumentSemantic.Strong)]
		LineSDKMessageSendingStatus Status { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKPostSendMessagesResponse New ();
	}

	// @interface LineSDKShareViewController : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC26LineSDKShareViewController")]
	interface LineSDKShareViewController
	{
		// @property (readonly, nonatomic, strong) UIViewController * _Nonnull viewController;
		[Export ("viewController", ArgumentSemantic.Strong)]
		UIViewController ViewController { get; }

		// @property (nonatomic, strong) UIColor * _Nonnull shareNavigationBarTintColor;
		[Export ("shareNavigationBarTintColor", ArgumentSemantic.Strong)]
		UIColor ShareNavigationBarTintColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull shareNavigationBarTextColor;
		[Export ("shareNavigationBarTextColor", ArgumentSemantic.Strong)]
		UIColor ShareNavigationBarTextColor { get; set; }

		// @property (nonatomic) UIStatusBarStyle shareStatusBarStyle;
		[Export ("shareStatusBarStyle", ArgumentSemantic.Assign)]
		UIStatusBarStyle ShareStatusBarStyle { get; set; }

		// @property (copy, nonatomic) NSArray<LineSDKMessage *> * _Nullable shareMessages;
		[NullAllowed, Export ("shareMessages", ArgumentSemantic.Copy)]
		LineSDKMessage[] ShareMessages { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		LineSDKShareViewControllerDelegate Delegate { get; set; }

		// @property (nonatomic, strong) id<LineSDKShareViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
		NSObject WeakDelegate { get; set; }

		// +(LineSDKAuthorizationStatus * _Nonnull)localAuthorizationStatusForSendingMessage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("localAuthorizationStatusForSendingMessage")]
// Fixed
// Error CS0246: The type or namespace name 'VerifyAttribute', 'Verify' could not be found
//		[Verify (MethodToProperty)]
		LineSDKAuthorizationStatus LocalAuthorizationStatusForSendingMessage { get; }
	}

	// @protocol LineSDKShareViewControllerDelegate
	[Protocol (Name = "_TtP11LineSDKObjC34LineSDKShareViewControllerDelegate_"), Model (AutoGeneratedName = true)]
	interface LineSDKShareViewControllerDelegate
	{
		// @optional -(void)shareViewController:(LineSDKShareViewController * _Nonnull)controller didFailLoadingListType:(enum LineSDKMessageShareTargetType)shareType withError:(NSError * _Nonnull)error;
		[Export ("shareViewController:didFailLoadingListType:withError:")]
		void ShareViewController (LineSDKShareViewController controller, LineSDKMessageShareTargetType shareType, NSError error);

		// @optional -(void)shareViewControllerDidCancelSharing:(LineSDKShareViewController * _Nonnull)controller;
		[Export ("shareViewControllerDidCancelSharing:")]
		void ShareViewControllerDidCancelSharing (LineSDKShareViewController controller);

		// @optional -(void)shareViewController:(LineSDKShareViewController * _Nonnull)controller didFailSendingMessages:(NSArray<LineSDKMessage *> * _Nonnull)messages toTargets:(NSArray<id<LineSDKShareTarget>> * _Nonnull)targets withError:(NSError * _Nonnull)error;
		[Export ("shareViewController:didFailSendingMessages:toTargets:withError:")]
		void ShareViewController (LineSDKShareViewController controller, LineSDKMessage[] messages, LineSDKShareTarget[] targets, NSError error);

		// @optional -(void)shareViewController:(LineSDKShareViewController * _Nonnull)controller didSendMessages:(NSArray<LineSDKMessage *> * _Nonnull)messages toTargets:(NSArray<id<LineSDKShareTarget>> * _Nonnull)targets;
		[Export ("shareViewController:didSendMessages:toTargets:")]
		void ShareViewController (LineSDKShareViewController controller, LineSDKMessage[] messages, LineSDKShareTarget[] targets);

		// @optional -(NSArray<LineSDKMessage *> * _Nonnull)shareViewController:(LineSDKShareViewController * _Nonnull)controller messagesForSendingToTargets:(NSArray<id<LineSDKShareTarget>> * _Nonnull)targets __attribute__((warn_unused_result("")));
		[Export ("shareViewController:messagesForSendingToTargets:")]
		LineSDKMessage[] ShareViewController (LineSDKShareViewController controller, LineSDKShareTarget[] targets);

		// @optional -(BOOL)shareViewControllerShouldDismissAfterSending:(LineSDKShareViewController * _Nonnull)controller __attribute__((warn_unused_result("")));
		[Export ("shareViewControllerShouldDismissAfterSending:")]
		bool ShareViewControllerShouldDismissAfterSending (LineSDKShareViewController controller);
	}

	// @interface LineSDKTemplateMessagePayload : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC29LineSDKTemplateMessagePayload")]
	interface LineSDKTemplateMessagePayload
	{
		// @property (readonly, nonatomic, strong) LineSDKTemplateButtonsPayload * _Nullable buttonsPayload;
		[NullAllowed, Export ("buttonsPayload", ArgumentSemantic.Strong)]
		LineSDKTemplateButtonsPayload ButtonsPayload { get; }

		// @property (readonly, nonatomic, strong) LineSDKTemplateConfirmPayload * _Nullable confirmPayload;
		[NullAllowed, Export ("confirmPayload", ArgumentSemantic.Strong)]
		LineSDKTemplateConfirmPayload ConfirmPayload { get; }

		// @property (readonly, nonatomic, strong) LineSDKTemplateCarouselPayload * _Nullable carouselPayload;
		[NullAllowed, Export ("carouselPayload", ArgumentSemantic.Strong)]
		LineSDKTemplateCarouselPayload CarouselPayload { get; }

		// @property (readonly, nonatomic, strong) LineSDKTemplateImageCarouselPayload * _Nullable imageCarouselPayload;
		[NullAllowed, Export ("imageCarouselPayload", ArgumentSemantic.Strong)]
		LineSDKTemplateImageCarouselPayload ImageCarouselPayload { get; }
	}

	// @interface LineSDKTemplateButtonsPayload : LineSDKTemplateMessagePayload
	[BaseType (typeof(LineSDKTemplateMessagePayload), Name = "_TtC11LineSDKObjC29LineSDKTemplateButtonsPayload")]
	[DisableDefaultCtor]
	interface LineSDKTemplateButtonsPayload
	{
		// @property (copy, nonatomic) NSString * _Nonnull text;
		[Export ("text")]
		string Text { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSArray<LineSDKMessageAction *> * _Nonnull actions;
		[Export ("actions", ArgumentSemantic.Copy)]
		LineSDKMessageAction[] Actions { get; set; }

		// @property (nonatomic, strong) LineSDKMessageAction * _Nullable defaultAction;
		[NullAllowed, Export ("defaultAction", ArgumentSemantic.Strong)]
		LineSDKMessageAction DefaultAction { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable thumbnailImageURL;
		[NullAllowed, Export ("thumbnailImageURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL ThumbnailImageURL { get; set; }
		NSUrl ThumbnailImageURL { get; set; }

		// @property (nonatomic) enum LineSDKTemplateMessagePayloadImageAspectRatio imageAspectRatio;
		[Export ("imageAspectRatio", ArgumentSemantic.Assign)]
		LineSDKTemplateMessagePayloadImageAspectRatio ImageAspectRatio { get; set; }

		// @property (nonatomic) enum LineSDKTemplateMessagePayloadImageContentMode imageContentMode;
		[Export ("imageContentMode", ArgumentSemantic.Assign)]
		LineSDKTemplateMessagePayloadImageContentMode ImageContentMode { get; set; }

		// @property (nonatomic, strong) LineSDKHexColor * _Nullable imageBackgroundColor;
		[NullAllowed, Export ("imageBackgroundColor", ArgumentSemantic.Strong)]
		LineSDKHexColor ImageBackgroundColor { get; set; }

		// @property (nonatomic, strong) LineSDKMessageSender * _Nullable sender;
		[NullAllowed, Export ("sender", ArgumentSemantic.Strong)]
		LineSDKMessageSender Sender { get; set; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title text:(NSString * _Nonnull)text actions:(NSArray<LineSDKMessageAction *> * _Nonnull)actions __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:text:actions:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string title, string text, LineSDKMessageAction[] actions);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKTemplateButtonsPayload New ();
	}

	// @interface LineSDKTemplateCarouselPayload : LineSDKTemplateMessagePayload
	[BaseType (typeof(LineSDKTemplateMessagePayload), Name = "_TtC11LineSDKObjC30LineSDKTemplateCarouselPayload")]
	[DisableDefaultCtor]
	interface LineSDKTemplateCarouselPayload
	{
		// @property (copy, nonatomic) NSArray<LineSDKTemplateCarouselPayloadColumn *> * _Nonnull columns;
		[Export ("columns", ArgumentSemantic.Copy)]
		LineSDKTemplateCarouselPayloadColumn[] Columns { get; set; }

		// @property (nonatomic) enum LineSDKTemplateMessagePayloadImageAspectRatio imageAspectRatio;
		[Export ("imageAspectRatio", ArgumentSemantic.Assign)]
		LineSDKTemplateMessagePayloadImageAspectRatio ImageAspectRatio { get; set; }

		// @property (nonatomic) enum LineSDKTemplateMessagePayloadImageContentMode imageContentMode;
		[Export ("imageContentMode", ArgumentSemantic.Assign)]
		LineSDKTemplateMessagePayloadImageContentMode ImageContentMode { get; set; }

		// -(instancetype _Nonnull)initWithColumns:(NSArray<LineSDKTemplateCarouselPayloadColumn *> * _Nonnull)columns __attribute__((objc_designated_initializer));
		[Export ("initWithColumns:")]
		[DesignatedInitializer]
		IntPtr Constructor (LineSDKTemplateCarouselPayloadColumn[] columns);

		// -(void)addColumn:(LineSDKTemplateCarouselPayloadColumn * _Nonnull)column;
		[Export ("addColumn:")]
		void AddColumn (LineSDKTemplateCarouselPayloadColumn column);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKTemplateCarouselPayload New ();
	}

	// @interface LineSDKTemplateCarouselPayloadColumn : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC36LineSDKTemplateCarouselPayloadColumn")]
	[DisableDefaultCtor]
	interface LineSDKTemplateCarouselPayloadColumn
	{
		// @property (copy, nonatomic) NSString * _Nonnull text;
		[Export ("text")]
		string Text { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSArray<LineSDKMessageAction *> * _Nonnull actions;
		[Export ("actions", ArgumentSemantic.Copy)]
		LineSDKMessageAction[] Actions { get; set; }

		// @property (nonatomic, strong) LineSDKMessageAction * _Nullable defaultAction;
		[NullAllowed, Export ("defaultAction", ArgumentSemantic.Strong)]
		LineSDKMessageAction DefaultAction { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable thumbnailImageURL;
		[NullAllowed, Export ("thumbnailImageURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL ThumbnailImageURL { get; set; }
		NSUrl ThumbnailImageURL { get; set; }

		// @property (nonatomic, strong) LineSDKHexColor * _Nullable imageBackgroundColor;
		[NullAllowed, Export ("imageBackgroundColor", ArgumentSemantic.Strong)]
		LineSDKHexColor ImageBackgroundColor { get; set; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title text:(NSString * _Nonnull)text actions:(NSArray<LineSDKMessageAction *> * _Nonnull)actions __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:text:actions:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string title, string text, LineSDKMessageAction[] actions);

		// -(void)addAction:(LineSDKMessageAction * _Nonnull)value;
		[Export ("addAction:")]
		void AddAction (LineSDKMessageAction value);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKTemplateCarouselPayloadColumn New ();
	}

	// @interface LineSDKTemplateConfirmPayload : LineSDKTemplateMessagePayload
	[BaseType (typeof(LineSDKTemplateMessagePayload), Name = "_TtC11LineSDKObjC29LineSDKTemplateConfirmPayload")]
	[DisableDefaultCtor]
	interface LineSDKTemplateConfirmPayload
	{
		// @property (copy, nonatomic) NSString * _Nonnull text;
		[Export ("text")]
		string Text { get; set; }

		// @property (nonatomic, strong) LineSDKMessageAction * _Nonnull confirmAction;
		[Export ("confirmAction", ArgumentSemantic.Strong)]
		LineSDKMessageAction ConfirmAction { get; set; }

		// @property (nonatomic, strong) LineSDKMessageAction * _Nonnull cancelAction;
		[Export ("cancelAction", ArgumentSemantic.Strong)]
		LineSDKMessageAction CancelAction { get; set; }

		// -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text confirmAction:(LineSDKMessageAction * _Nonnull)confirmAction cancelAction:(LineSDKMessageAction * _Nonnull)cancelAction __attribute__((objc_designated_initializer));
		[Export ("initWithText:confirmAction:cancelAction:")]
		[DesignatedInitializer]
		IntPtr Constructor (string text, LineSDKMessageAction confirmAction, LineSDKMessageAction cancelAction);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKTemplateConfirmPayload New ();
	}

	// @interface LineSDKTemplateImageCarouselPayload : LineSDKTemplateMessagePayload
	[BaseType (typeof(LineSDKTemplateMessagePayload), Name = "_TtC11LineSDKObjC35LineSDKTemplateImageCarouselPayload")]
	[DisableDefaultCtor]
	interface LineSDKTemplateImageCarouselPayload
	{
		// @property (copy, nonatomic) NSArray<LineSDKTemplateImageCarouselPayloadColumn *> * _Nonnull columns;
		[Export ("columns", ArgumentSemantic.Copy)]
		LineSDKTemplateImageCarouselPayloadColumn[] Columns { get; set; }

		// -(instancetype _Nonnull)initWithColumns:(NSArray<LineSDKTemplateImageCarouselPayloadColumn *> * _Nonnull)columns __attribute__((objc_designated_initializer));
		[Export ("initWithColumns:")]
		[DesignatedInitializer]
		IntPtr Constructor (LineSDKTemplateImageCarouselPayloadColumn[] columns);

		// -(void)addColumn:(LineSDKTemplateImageCarouselPayloadColumn * _Nonnull)column;
		[Export ("addColumn:")]
		void AddColumn (LineSDKTemplateImageCarouselPayloadColumn column);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKTemplateImageCarouselPayload New ();
	}

	// @interface LineSDKTemplateImageCarouselPayloadColumn : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC41LineSDKTemplateImageCarouselPayloadColumn")]
	[DisableDefaultCtor]
	interface LineSDKTemplateImageCarouselPayloadColumn
	{
		// @property (copy, nonatomic) NSURL * _Nonnull imageURL;
		[Export ("imageURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL ImageURL { get; set; }
		NSUrl ImageURL { get; set; }

		// @property (nonatomic, strong) LineSDKMessageAction * _Nullable action;
		[NullAllowed, Export ("action", ArgumentSemantic.Strong)]
		LineSDKMessageAction Action { get; set; }

		// -(instancetype _Nullable)initWithImageURL:(NSURL * _Nonnull)imageURL action:(LineSDKMessageAction * _Nullable)action __attribute__((objc_designated_initializer));
		[Export ("initWithImageURL:action:")]
		[DesignatedInitializer]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		IntPtr Constructor (NSURL imageURL, [NullAllowed] LineSDKMessageAction action);
		IntPtr Constructor (NSUrl imageURL, [NullAllowed] LineSDKMessageAction action);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKTemplateImageCarouselPayloadColumn New ();
	}

	// @interface LineSDKTemplateMessage : LineSDKMessage
	[BaseType (typeof(LineSDKMessage), Name = "_TtC11LineSDKObjC22LineSDKTemplateMessage")]
	[DisableDefaultCtor]
	interface LineSDKTemplateMessage
	{
		// @property (copy, nonatomic) NSString * _Nonnull altText;
		[Export ("altText")]
		string AltText { get; set; }

		// @property (nonatomic, strong) LineSDKTemplateMessagePayload * _Nonnull payload;
		[Export ("payload", ArgumentSemantic.Strong)]
		LineSDKTemplateMessagePayload Payload { get; set; }

		// -(instancetype _Nonnull)initWithAltText:(NSString * _Nonnull)altText payload:(LineSDKTemplateMessagePayload * _Nonnull)payload __attribute__((objc_designated_initializer));
		[Export ("initWithAltText:payload:")]
		[DesignatedInitializer]
		IntPtr Constructor (string altText, LineSDKTemplateMessagePayload payload);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKTemplateMessage New ();
	}

	// @interface LineSDKTextMessage : LineSDKMessage
	[BaseType (typeof(LineSDKMessage), Name = "_TtC11LineSDKObjC18LineSDKTextMessage")]
	[DisableDefaultCtor]
	interface LineSDKTextMessage
	{
		// @property (copy, nonatomic) NSString * _Nonnull text;
		[Export ("text")]
		string Text { get; set; }

		// @property (nonatomic, strong) LineSDKMessageSender * _Nullable sender;
		[NullAllowed, Export ("sender", ArgumentSemantic.Strong)]
		LineSDKMessageSender Sender { get; set; }

		// -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text;
		[Export ("initWithText:")]
		IntPtr Constructor (string text);

		// -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text sender:(LineSDKMessageSender * _Nullable)sender __attribute__((objc_designated_initializer));
		[Export ("initWithText:sender:")]
		[DesignatedInitializer]
		IntPtr Constructor (string text, [NullAllowed] LineSDKMessageSender sender);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKTextMessage New ();
	}

	// @interface LineSDKUser : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC11LineSDKUser")]
	[DisableDefaultCtor]
	interface LineSDKUser
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull userID;
		[Export ("userID")]
		string UserID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull displayName;
		[Export ("displayName")]
		string DisplayName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull displayNameOriginal;
		[Export ("displayNameOriginal")]
		string DisplayNameOriginal { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable displayNameOverridden;
		[NullAllowed, Export ("displayNameOverridden")]
		string DisplayNameOverridden { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable pictureURL;
		[NullAllowed, Export ("pictureURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL PictureURL { get; }
		NSUrl PictureURL { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable pictureURLSmall;
		[NullAllowed, Export ("pictureURLSmall", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL PictureURLSmall { get; }
		NSUrl PictureURLSmall { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKUser New ();
	}

	// @interface LineSDKObjC_Swift_1397 (LineSDKUser) <LineSDKShareTarget>
	[Category]
	[BaseType (typeof(LineSDKUser))]
	interface LineSDKUser_LineSDKObjC_Swift_1397 : ILineSDKShareTarget
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull targetID;
		[Export ("targetID")]
		string TargetID { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable avatarURL;
		[NullAllowed, Export ("avatarURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL AvatarURL { get; }
		NSUrl AvatarURL { get; }
	}

	// @interface LineSDKUserProfile : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11LineSDKObjC18LineSDKUserProfile")]
	[DisableDefaultCtor]
	interface LineSDKUserProfile
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull userID;
		[Export ("userID")]
		string UserID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull displayName;
		[Export ("displayName")]
		string DisplayName { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable pictureURL;
		[NullAllowed, Export ("pictureURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL PictureURL { get; }
		NSUrl PictureURL { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable pictureURLLarge;
		[NullAllowed, Export ("pictureURLLarge", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL PictureURLLarge { get; }
		NSUrl PictureURLLarge { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable pictureURLSmall;
		[NullAllowed, Export ("pictureURLSmall", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL PictureURLSmall { get; }
		NSUrl PictureURLSmall { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable statusMessage;
		[NullAllowed, Export ("statusMessage")]
		string StatusMessage { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable json;
		[NullAllowed, Export ("json")]
		string Json { get; }

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKUserProfile New ();
	}

	// @interface LineSDKVideoMessage : LineSDKMessage
	[BaseType (typeof(LineSDKMessage), Name = "_TtC11LineSDKObjC19LineSDKVideoMessage")]
	[DisableDefaultCtor]
	interface LineSDKVideoMessage
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nonnull originalContentURL;
		[Export ("originalContentURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL OriginalContentURL { get; }
		NSUrl OriginalContentURL { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nonnull previewImageURL;
		[Export ("previewImageURL", ArgumentSemantic.Copy)]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		NSURL PreviewImageURL { get; }
		NSUrl PreviewImageURL { get; }

		// -(instancetype _Nullable)initWithOriginalContentURL:(NSURL * _Nonnull)originalContentURL previewImageURL:(NSURL * _Nonnull)previewImageURL __attribute__((objc_designated_initializer));
		[Export ("initWithOriginalContentURL:previewImageURL:")]
		[DesignatedInitializer]
// Fixed
// Error CS0246: The type or namespace name 'NSURL' could not be found
//		IntPtr Constructor (NSURL originalContentURL, NSURL previewImageURL);
		IntPtr Constructor (NSUrl originalContentURL, NSUrl previewImageURL);

		// +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
		[Static]
		[Export ("new")]
		LineSDKVideoMessage New ();
	}

	// @interface LineSDKObjC_Swift_1427 (NSNotification)
	[Category]
	[BaseType (typeof(NSNotification))]
	interface NSNotification_LineSDKObjC_Swift_1427
	{
		// @property (readonly, nonatomic, class) NSNotificationName _Nonnull LineSDKAccessTokenDidUpdate;
		[Static]
		[Export ("LineSDKAccessTokenDidUpdate")]
		string LineSDKAccessTokenDidUpdate { get; }

		// @property (readonly, nonatomic, class) NSNotificationName _Nonnull LineSDKAccessTokenDidRemove;
		[Static]
		[Export ("LineSDKAccessTokenDidRemove")]
		string LineSDKAccessTokenDidRemove { get; }
	}

	// @interface LineSDKObjC_Swift_1435 (NSNotification)
	[Category]
	[BaseType (typeof(NSNotification))]
	interface NSNotification_LineSDKObjC_Swift_1435
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull LineSDKOldAccessTokenKey;
		[Static]
		[Export ("LineSDKOldAccessTokenKey")]
		string LineSDKOldAccessTokenKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull LineSDKNewAccessTokenKey;
		[Static]
		[Export ("LineSDKNewAccessTokenKey")]
		string LineSDKNewAccessTokenKey { get; }
	}
}
