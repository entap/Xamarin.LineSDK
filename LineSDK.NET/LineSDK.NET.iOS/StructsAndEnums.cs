using ObjCRuntime;

namespace LineSDKObjC
{
	[Native]
	public enum LineSDKFlexBubbleContainerDirection : long
	{
		None = 0,
		LeftToRight = 1,
		RightToLeft = 2
	}

	[Native]
	public enum LineSDKFlexButtonComponentStyle : long
	{
		None = 0,
		Link = 1,
		Primary = 2,
		Secondary = 3
	}

	[Native]
	public enum LineSDKFlexMessageComponentAlignment : long
	{
		None = 0,
		Start = 1,
		End = 2,
		Center = 3
	}

	[Native]
	public enum LineSDKFlexMessageComponentAspectMode : long
	{
		None = 0,
		Fill = 1,
		Fit = 2
	}

	[Native]
	public enum LineSDKFlexMessageComponentAspectRatio : long
	{
		None = 0,
		Ratio_1x1 = 1,
		Ratio_1_51x1 = 2,
		Ratio_1_91x1 = 3,
		Ratio_4x3 = 4,
		Ratio_16x9 = 5,
		Ratio_20x13 = 6,
		Ratio_2x1 = 7,
		Ratio_3x1 = 8,
		Ratio_3x4 = 9,
		Ratio_9x16 = 10,
		Ratio_1x2 = 11,
		Ratio_1x3 = 12
	}

	[Native]
	public enum LineSDKFlexMessageComponentGravity : long
	{
		None = 0,
		Top = 1,
		Bottom = 2,
		Center = 3
	}

	[Native]
	public enum LineSDKFlexMessageComponentHeight : long
	{
		None = 0,
		Sm = 1,
		Md = 2
	}

	[Native]
	public enum LineSDKFlexMessageComponentLayout : long
	{
		Horizontal = 0,
		Vertical = 1,
		Baseline = 2
	}

	[Native]
	public enum LineSDKFlexMessageComponentMargin : long
	{
		None = 0,
		Xs = 1,
		Sm = 2,
		Md = 3,
		Lg = 4,
		Xl = 5,
		Xxl = 6
	}

	[Native]
	public enum LineSDKFlexMessageComponentSize : long
	{
		None = 0,
		Xxs = 1,
		Xs = 2,
		Sm = 3,
		Md = 4,
		Lg = 5,
		Xl = 6,
		Xxl = 7,
		Xl3 = 8,
		Xl4 = 9,
		Xl5 = 10,
		Full = 11
	}

	[Native]
	public enum LineSDKFlexMessageComponentSpacing : long
	{
		None = 0,
		Xs = 1,
		Sm = 2,
		Md = 3,
		Lg = 4,
		Xl = 5,
		Xxl = 6
	}

	[Native]
	public enum LineSDKFlexMessageComponentWeight : long
	{
		None = 0,
		Regular = 1,
		Bold = 2
	}

	[Native]
	public enum LineSDKGetFriendsRequestSort : long
	{
		None = 0,
		Name = 1,
		Relation = 2
	}

	[Native]
	public enum LineSDKLoginButtonSize : long
	{
		Small = 0,
		Normal = 1
	}

	[Native]
	public enum LineSDKMessageShareTargetType : long
	{
		Friends = 0,
		Groups = 1
	}

	[Native]
	public enum LineSDKTemplateMessagePayloadImageAspectRatio : long
	{
		None = 0,
		Rectangle = 1,
		Square = 2
	}

	[Native]
	public enum LineSDKTemplateMessagePayloadImageContentMode : long
	{
		None = 0,
		AspectFill = 1,
		AspectFit = 2
	}
}
