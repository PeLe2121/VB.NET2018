Public Class Total_Profit_Growth

    'PC: several Public Property variables holding the attributes from the dataset
    Public Property name As String
    Public Property value As Single
    Public Property unitOfMeasurement As String

    'PC: creates a list of Total Profit Growth objects for the user
    'PC: Total_GrowthList is a list for the class of Total Profit Growth
    Public Shared Property Total_GrowthList As New List(Of Total_Profit_Growth)
    Public Sub New()
        'PC: constrctor for the Total_Profit_Growth class
    End Sub
    
End Class
