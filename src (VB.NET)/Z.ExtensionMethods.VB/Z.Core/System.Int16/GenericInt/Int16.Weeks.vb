
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_257

	''' <summary>
	'''     An Int16 extension method that weeks the given this.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A TimeSpan.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Weeks(this As Int16) As TimeSpan
		Return TimeSpan.FromDays(this * 7)
	End Function
End Module


