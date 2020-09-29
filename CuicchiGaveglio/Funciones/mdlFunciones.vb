Imports System.Windows.Forms

Module mdlFunciones

    Public Sub SoloNumero(ev As KeyPressEventArgs)
        If Char.IsNumber(ev.KeyChar) Or Char.IsControl(ev.KeyChar) Then
            ev.Handled = False
        Else
            ev.Handled = True
        End If
    End Sub
    Public Sub SoloLetra(ev As KeyPressEventArgs)
        If Char.IsNumber(ev.KeyChar) Or Char.IsPunctuation(ev.KeyChar) Then
            ev.Handled = True
        Else
            ev.Handled = False
        End If
    End Sub

    Public Sub SoloImporte(ev As KeyPressEventArgs)
        If Char.IsNumber(ev.KeyChar) Or Char.IsPunctuation(ev.KeyChar) Or Char.IsControl(ev.KeyChar) Then
            ev.Handled = False
        Else
            ev.Handled = True
        End If
    End Sub

    Public Sub LlenarComboClientes(pCombo As ComboBox)
        pCombo.Items.Clear()
        Dim ControladorClientes As New ClsClientes
        Dim RespuestaClientes As ArrayList = ControladorClientes.ConsultarClientesCombo()
        If (RespuestaClientes IsNot Nothing) Then
            For Each item As String In RespuestaClientes
                pCombo.Items.Add(item)
            Next
        End If
    End Sub

    Public Sub LlenarComboEstados(pCombo As ComboBox)
        pCombo.Items.Clear()
        Dim ControladorEstados As New clsEstados
        Dim RespuestaEstados As ArrayList = ControladorEstados.ConsultarEstados()
        If (RespuestaEstados IsNot Nothing) Then
            For Each item As String In RespuestaEstados
                pCombo.Items.Add(item)
            Next
        End If
    End Sub

    Public Sub LlenarComboTipoComprobantes(pCombo As ComboBox)
        pCombo.Items.Clear()
        Dim ControladorTipoComprobantes As New clsTipoComprobantes
        Dim RespuestaTipoComprobantes As ArrayList = ControladorTipoComprobantes.ConsultarTipoComprobantes()
        If (RespuestaTipoComprobantes IsNot Nothing) Then
            For Each item As String In RespuestaTipoComprobantes
                pCombo.Items.Add(item)
            Next
        End If
    End Sub

    Public Sub LlenarComboCompanias(pCombo As ComboBox)
        pCombo.Items.Clear()
        Dim ControladorCompania As New clsCompania
        Dim RespuestaCompania As ArrayList = ControladorCompania.ConsultarCompanias()
        If (RespuestaCompania IsNot Nothing) Then
            For Each item As String In RespuestaCompania
                pCombo.Items.Add(item)
            Next
        End If
    End Sub

    Public Sub LlenarComboBancos(pCombo As ComboBox)
        pCombo.Items.Clear()
        Dim ControladorBancos As New ClsBancos
        Dim RespuestaBancos As ArrayList = ControladorBancos.ConsultarBancos()
        If (RespuestaBancos IsNot Nothing) Then
            For Each item As String In RespuestaBancos
                pCombo.Items.Add(item)
            Next
        End If
    End Sub

    Public Function ExtraerNumeros(ByVal strCadena As String) As String
        Dim SoloNumero As String = ""
        Dim index As Integer
        For index = 1 To Len(strCadena)
            If (Mid$(strCadena, index, 1) Like "#") Then
                SoloNumero &= Mid$(strCadena, index, 1)
            End If
        Next
        If SoloNumero.Length = 0 Then
            SoloNumero = "0"
        End If
        Return SoloNumero
    End Function

    Public Function ExtraerLetras(ByVal strCadena As String) As String
        Dim SoloLetra As String = ""
        Dim index As Integer
        For index = 1 To Len(strCadena)
            If Char.IsLetter(Mid$(strCadena, index, 1)) = True Or (Mid$(strCadena, index, 1) = " ") Then
                SoloLetra &= Mid$(strCadena, index, 1)
            End If
        Next
        SoloLetra = SoloLetra.TrimEnd(" ")
        SoloLetra = SoloLetra.TrimStart(" ")
        If SoloLetra.Length = 0 Then
            SoloLetra = ""
        End If
        Return SoloLetra
    End Function

End Module
