
Imports System.Collections.Generic

Module AddressStorage
    Public Function GetData() As Dictionary(Of String, List(Of String))
        ' Создаем словарь для хранения данных
        Dim data As New Dictionary(Of String, List(Of String))()

        ' Добавляем данные
        data.Add("login0", New List(Of String) From {
            "92.223.6.74",
            "92.223.6.75",
            "92.223.6.71",
            "92.223.6.72",
            "92.223.6.73",
            "92.223.6.76"
        })

        data.Add("login1", New List(Of String) From {
            "92.223.33.42",
            "92.223.33.87",
            "92.223.33.41",
            "92.223.33.46",
            "92.223.33.44"
        })

        data.Add("login2", New List(Of String) From {
            "92.223.14.222",
            "92.223.14.216",
            "92.223.14.214"
        })

        data.Add("login3", New List(Of String) From {
            "92.38.156.93",
            "92.38.156.142",
            "92.38.156.13",
            "92.38.156.189"
        })

        data.Add("login4", New List(Of String) From {
            "2.223.4.178",
            "92.223.4.179",
            "92.223.4.190"
        })

        data.Add("login5", New List(Of String) From {
            "92.223.41.129",
            "92.223.41.34",
            "92.223.41.183",
            "92.223.41.195"
        })
        Return data
    End Function
End Module
