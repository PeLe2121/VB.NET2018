Public Class Storage_Capacity

    'PC: several Public Property variables holding the attributes from the dataset
    Public Property name As String
    Public Property value As Short
    Public Property unitOfMeasurement As String

    'PC: creates a list of Stockout substitution group objects for the user
    'PC: storage_cap is short for "storage capacity"
    Public Shared Property Storage_CapList As New List(Of Storage_Capacity)
    Public Sub New()
        'PC: constrctor for the Storage_Capacity class
    End Sub

End Class
