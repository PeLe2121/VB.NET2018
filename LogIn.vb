'The LogIn class works closely with the Welcome form to allow the uesr to log in
Public Class LogIn
    'EDD several Public Property variables holding the attributes from the dataset
    Public Property username As String
        Public Property password As String

    'EDD: creates a list of LogIn objects for the user
    Public Shared Property LogInList As New List(Of LogIn)
    Public Sub New()
        'EDD: constrctor for the LogIn class
    End Sub
End Class
