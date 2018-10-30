Public Class Surplus_Demand

    'PC: several Public Property variables holding the attributes from the dataset
    Public Property name As String
    Public Property value As Short
    Public Property unitOfMeasurement As String

    'PC: creates a list of Surplus Demand objects for the user
    Public Shared Property Suplus_DemandList As New List(Of Surplus_Demand)
    Public Sub New()
        'PC: constrctor for the Surplus_Demand class
    End Sub

End Class
