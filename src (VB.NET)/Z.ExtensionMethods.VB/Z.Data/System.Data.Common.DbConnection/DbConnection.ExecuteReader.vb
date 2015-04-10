
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data
Imports System.Data.Common

Public Module Extensions_660

	''' <summary>
	'''     A DbConnection extension method that executes the reader operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="parameters">Options for controlling the operation.</param>
	''' <param name="commandType">Type of the command.</param>
	''' <param name="transaction">The transaction.</param>
	''' <returns>A DbDataReader.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteReader(this As DbConnection, cmdText As String, parameters As DbParameter(), commandType As CommandType, transaction As DbTransaction) As DbDataReader
		Using command As DbCommand = this.CreateCommand()
			command.CommandText = cmdText
			command.CommandType = commandType
			command.Transaction = transaction

			If parameters IsNot Nothing Then
				command.Parameters.AddRange(parameters)
			End If

			Return command.ExecuteReader()
		End Using
	End Function

	''' <summary>
	'''     A DbConnection extension method that executes the reader operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="commandFactory">The command factory.</param>
	''' <returns>A DbDataReader.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteReader(this As DbConnection, commandFactory As Action(Of DbCommand)) As DbDataReader
		Using command As DbCommand = this.CreateCommand()
			commandFactory(command)

			Return command.ExecuteReader()
		End Using
	End Function

	''' <summary>
	'''     A DbConnection extension method that executes the reader operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <returns>A DbDataReader.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteReader(this As DbConnection, cmdText As String) As DbDataReader
		Return this.ExecuteReader(cmdText, Nothing, CommandType.Text, Nothing)
	End Function

	''' <summary>
	'''     A DbConnection extension method that executes the reader operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="transaction">The transaction.</param>
	''' <returns>A DbDataReader.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteReader(this As DbConnection, cmdText As String, transaction As DbTransaction) As DbDataReader
		Return this.ExecuteReader(cmdText, Nothing, CommandType.Text, transaction)
	End Function

	''' <summary>
	'''     A DbConnection extension method that executes the reader operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="commandType">Type of the command.</param>
	''' <returns>A DbDataReader.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteReader(this As DbConnection, cmdText As String, commandType As CommandType) As DbDataReader
		Return this.ExecuteReader(cmdText, Nothing, commandType, Nothing)
	End Function

	''' <summary>
	'''     A DbConnection extension method that executes the reader operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="commandType">Type of the command.</param>
	''' <param name="transaction">The transaction.</param>
	''' <returns>A DbDataReader.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteReader(this As DbConnection, cmdText As String, commandType As CommandType, transaction As DbTransaction) As DbDataReader
		Return this.ExecuteReader(cmdText, Nothing, commandType, transaction)
	End Function

	''' <summary>
	'''     A DbConnection extension method that executes the reader operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="parameters">Options for controlling the operation.</param>
	''' <returns>A DbDataReader.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteReader(this As DbConnection, cmdText As String, parameters As DbParameter()) As DbDataReader
		Return this.ExecuteReader(cmdText, parameters, CommandType.Text, Nothing)
	End Function

	''' <summary>
	'''     A DbConnection extension method that executes the reader operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="parameters">Options for controlling the operation.</param>
	''' <param name="transaction">The transaction.</param>
	''' <returns>A DbDataReader.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteReader(this As DbConnection, cmdText As String, parameters As DbParameter(), transaction As DbTransaction) As DbDataReader
		Return this.ExecuteReader(cmdText, parameters, CommandType.Text, transaction)
	End Function

	''' <summary>
	'''     A DbConnection extension method that executes the reader operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="parameters">Options for controlling the operation.</param>
	''' <param name="commandType">Type of the command.</param>
	''' <returns>A DbDataReader.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteReader(this As DbConnection, cmdText As String, parameters As DbParameter(), commandType As CommandType) As DbDataReader
		Return this.ExecuteReader(cmdText, parameters, commandType, Nothing)
	End Function
End Module

