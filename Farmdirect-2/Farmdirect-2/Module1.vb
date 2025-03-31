Imports Microsoft.Data.SqlClient

Public Module Module1
    Public LoggedInConsumerID As Integer
    Public LoggedInUserID As Integer  ' Stores Consumer, Farmer, or Admin ID
    Public LoggedInRole As String  ' Stores the role (Farmer, Consumer, Admin)
    Public LoggedInFarmerID As Integer ' Specifically for Farmer ID
End Module
