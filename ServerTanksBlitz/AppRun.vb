
Public Class AppRun

    Private Sub AppRun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Обход чекбоксов для установки обработчиков событий
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is CheckBox AndAlso ctrl.Name.StartsWith("CheckBox") Then
                AddHandler DirectCast(ctrl, CheckBox).CheckedChanged, AddressOf CheckBox_CheckedChanged
            End If
        Next
    End Sub


    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Dim availableCheckBoxes As New List(Of CheckBox)
        Dim selectedLogins As New List(Of String)
        Dim checkBoxToDisable As CheckBox = Nothing ' Для чекбокса, который нужно выключить

        ' Проходимся по всем чекбоксам, проверяем выбранные и формируем список логинов
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is CheckBox AndAlso ctrl.Name.StartsWith("CheckBox") Then
                Dim checkBox As CheckBox = DirectCast(ctrl, CheckBox)
                Dim checkBoxNumber As String = checkBox.Name.Substring("CheckBox".Length)
                Dim login As String = "login" & (CInt(checkBoxNumber) - 1).ToString()

                If checkBox Is CheckBox4 Then ' Проверяем чекбокс 4
                    If checkBox.Checked Then
                        checkBoxToDisable = checkBox ' Запоминаем его, если он выбран
                    End If
                Else
                    If checkBox.Checked Then
                        selectedLogins.Add(login)
                    Else
                        availableCheckBoxes.Add(checkBox)
                    End If
                End If
            End If
        Next

        ' Если был выбран CheckBox4, его нужно выключить
        If checkBoxToDisable IsNot Nothing Then
            checkBoxToDisable.Checked = False
        End If

        ' Вызываем данные из модуля AddressStorage
        Dim data As Dictionary(Of String, List(Of String)) = AddressStorage.GetData()

        ' Отображаем IP адреса в TextBoxOutput с отступами между серверами
        Dim formattedIPs As New List(Of String)
        Dim currentServerIPs As New List(Of String)

        For Each login As String In selectedLogins
            If data.ContainsKey(login) Then
                currentServerIPs = data(login)
                If currentServerIPs.Count > 0 Then
                    formattedIPs.Add("Сервер " & login & ":")
                    formattedIPs.AddRange(currentServerIPs.Select(Function(ip) "    " & ip))
                End If
            End If
        Next

        TextBoxOutput.Text = String.Join(Environment.NewLine, formattedIPs)

        ' Заполняем доступные чекбоксы в порядке появления
        availableCheckBoxes.Reverse()

        ' Определяем последний доступный чекбокс
        Dim lastCheckBox As CheckBox = Nothing
        For Each checkBox As CheckBox In availableCheckBoxes
            If selectedLogins.Count < 5 Then
                checkBox.Enabled = True
            Else
                checkBox.Enabled = False
                lastCheckBox = checkBox ' Запоминаем последний доступный чекбокс
            End If
        Next

        ' Если 5 чекбоксов выбрано, последний становится серым
        If selectedLogins.Count = 5 AndAlso lastCheckBox IsNot Nothing Then
            lastCheckBox.Enabled = False
            MessageBox.Show("Ты, че себя богом возомни́л? Иди, страдай в помоечке любимой. Нельзя блокировать все сервера!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub КопироватьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КопироватьToolStripMenuItem.Click
        ' Проверяем, есть ли текст для копирования
        If Not String.IsNullOrEmpty(TextBoxOutput.Text) Then
            ' Копируем текст в буфер обмена
            Clipboard.SetText(TextBoxOutput.Text)
            MessageBox.Show("Текст скопирован в буфер обмена.")
        Else
            MessageBox.Show("Нет текста для копирования.")
        End If
    End Sub

    Private Sub BlockButton_Click(sender As Object, e As EventArgs) Handles BlockButton.Click
        ' Получаем выбранные IP из TextBoxOutput
        Dim selectedIPs As String() = TextBoxOutput.Lines

        ' Блокируем каждый выбранный IP-адрес
        For Each ip As String In selectedIPs
            If ip.StartsWith("    ") Then ' Проверяем, что это IP-адрес
                Dim ipAddress As String = ip.Trim() ' Убираем пробелы
                BlockIP(ipAddress)
            End If
        Next

        MessageBox.Show("Выбранные IP успешно заблокированы.")
        BlockButton.Enabled = False
        UnblockButton.Enabled = True
    End Sub

    Private Sub BlockIP(ipAddress As String)
        ' Выполнение команды блокировки IP с помощью netsh
        Dim processInfo As New ProcessStartInfo("netsh", $"advfirewall firewall add rule name='BlockedIP_{ipAddress}' dir=out interface=any action=block remoteip={ipAddress}")
        processInfo.UseShellExecute = False
        processInfo.CreateNoWindow = True
        processInfo.RedirectStandardError = True
        processInfo.RedirectStandardOutput = True

        Dim process As Process = Process.Start(processInfo)
        process.WaitForExit()

        ' Обработка результатов выполнения команды netsh
        Dim output As String = process.StandardOutput.ReadToEnd()
        Dim [error] As String = process.StandardError.ReadToEnd()

        ' Формирование сообщения с выводом или ошибкой, если они есть
        Dim message As String = ""
        If Not String.IsNullOrEmpty(output) OrElse Not String.IsNullOrEmpty([error]) Then
            message &= "Выход: " & If(Not String.IsNullOrEmpty(output), output & Environment.NewLine, "")
            message &= "Ошибка: " & If(Not String.IsNullOrEmpty([error]), [error] & Environment.NewLine, "")
        End If

        If Not String.IsNullOrEmpty(message.Trim()) Then
            MessageBox.Show(message)
        End If
    End Sub

    Private Sub UnblockButton_Click(sender As Object, e As EventArgs) Handles UnblockButton.Click
        ' Получаем выбранные IP из TextBoxOutput
        Dim selectedIPs As String() = TextBoxOutput.Lines

        ' Разблокируем каждый выбранный IP-адрес
        For Each ip As String In selectedIPs
            If ip.StartsWith("    ") Then ' Проверяем, что это IP-адрес
                Dim ipAddress As String = ip.Trim() ' Убираем пробелы
                UnblockIP(ipAddress)
            End If
        Next

        MessageBox.Show("Выбранные IP успешно разблокированы.")

        ' Проверка наличия заблокированных IP и управление видимостью кнопок
        Dim blockedIPsExist As Boolean = CheckIfBlockedIPsExist()

        BlockButton.Enabled = Not blockedIPsExist
        UnblockButton.Enabled = blockedIPsExist
    End Sub

    Private Sub UnblockIP(ipAddress As String)
        ' Выполнение команды разблокировки IP с помощью netsh
        Dim processInfo As New ProcessStartInfo("netsh", $"advfirewall firewall delete rule name='BlockedIP_{ipAddress}' dir=out")
        processInfo.UseShellExecute = False
        processInfo.CreateNoWindow = True
        processInfo.RedirectStandardError = True
        processInfo.RedirectStandardOutput = True

        Dim process As Process = Process.Start(processInfo)
        process.WaitForExit()

        ' Обработка результатов выполнения команды netsh
        Dim output As String = process.StandardOutput.ReadToEnd()
        Dim [error] As String = process.StandardError.ReadToEnd()

        ' Формирование сообщения с выводом или ошибкой, если они есть
        Dim message As String = ""
        If Not String.IsNullOrEmpty(output) OrElse Not String.IsNullOrEmpty([error]) Then
            message &= "Выход: " & If(Not String.IsNullOrEmpty(output), output & Environment.NewLine, "")
            message &= "Ошибка: " & If(Not String.IsNullOrEmpty([error]), [error] & Environment.NewLine, "")
        End If

        If Not String.IsNullOrEmpty(message.Trim()) Then
            MessageBox.Show(message)
        End If
    End Sub

    Private Function CheckIfBlockedIPsExist() As Boolean
        ' Проверяем, остались ли заблокированные IP
        Dim selectedIPs As String() = TextBoxOutput.Lines
        For Each ip As String In selectedIPs
            If ip.StartsWith("    ") Then ' Проверяем, что это IP-адрес
                Dim ipAddress As String = ip.Trim() ' Убираем пробелы
                ' Проверяем, существует ли блокировка для этого IP
                If CheckIfIPBlocked(ipAddress) Then
                    Return True ' Если хотя бы один IP заблокирован, возвращаем True
                End If
            End If
        Next
        Return False ' Если ни одного заблокированного IP не обнаружено, возвращаем False
    End Function

    ' Допустим, у вас есть функция, проверяющая, заблокирован ли IP
    Private Function CheckIfIPBlocked(ipAddress As String) As Boolean
        Dim processInfo As New ProcessStartInfo("netsh", $"advfirewall firewall show rule name=all | findstr {ipAddress}")
        processInfo.UseShellExecute = False
        processInfo.CreateNoWindow = True
        processInfo.RedirectStandardOutput = True

        Dim process As Process = Process.Start(processInfo)
        process.WaitForExit()

        Dim output As String = process.StandardOutput.ReadToEnd()

        ' Проверка наличия IP-адреса в выводе команды netsh
        Return output.Contains(ipAddress)
    End Function
End Class
