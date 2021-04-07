Imports System.Windows.Forms
Imports CapaDatos
Imports SpreadsheetLight
Module mdlFunciones

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
        Dim ControladorEstados As New ClsEstados
        Dim RespuestaEstados As ArrayList = ControladorEstados.ConsultarEstados()
        If (RespuestaEstados IsNot Nothing) Then
            For Each item As String In RespuestaEstados
                pCombo.Items.Add(item)
            Next
        End If
    End Sub

    Public Sub LlenarComboTipoComprobantes(pCombo As ComboBox)
        pCombo.Items.Clear()
        Dim ControladorTipoComprobantes As New ClsTipoComprobantes
        Dim RespuestaTipoComprobantes As ArrayList = ControladorTipoComprobantes.ConsultarTipoComprobantes()
        If (RespuestaTipoComprobantes IsNot Nothing) Then
            For Each item As String In RespuestaTipoComprobantes
                pCombo.Items.Add(item)
            Next
        End If
    End Sub

    Public Sub LlenarComboCobradores(pCombo As ComboBox)
        pCombo.Items.Clear()
        Dim ControladorCobradores As New clsCobradores
        Dim RespuestaCobradores As ArrayList = ControladorCobradores.ConsultarCobradoresCombo()
        If (RespuestaCobradores IsNot Nothing) Then
            For Each item As String In RespuestaCobradores
                pCombo.Items.Add(item)
            Next
        End If
    End Sub
    Public Sub LlenarComboCompanias(pCombo As ComboBox)
        pCombo.Items.Clear()
        Dim ControladorCompania As New ClsCompania
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

    Public Sub LlenarComboUsuarios(pCombo As ComboBox)
        pCombo.Items.Clear()
        Dim ControladorUsuarios As New clsUsuarios
        Dim RespuestaUsuarios As ArrayList = ControladorUsuarios.ConsultarUsuarios()
        If (RespuestaUsuarios IsNot Nothing) Then
            For Each item As String In RespuestaUsuarios
                pCombo.Items.Add(item)
            Next
        End If
    End Sub

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

    Public Function ExtraerIdCliente(ByVal strCadena As String) As String
        Try
            Dim index = strCadena.IndexOf("|")
            Dim cadena = strCadena.Substring(index)
            Dim idCliente = ExtraerNumeros(cadena)
            Return idCliente
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function

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
    Public Function ExportarExcel(pDataGrid As DataGridView)
        Try

            Dim dialog = New SaveFileDialog()
            dialog.ShowDialog()

            If dialog.FileName = "" Then
                Return 0
            End If

            Dim documento As New SLDocument()
            Dim style As New SLStyle()
            style.Font.Bold = True
            style.Font.FontSize = 14

            Dim dt As Data.DataTable = DirectCast(pDataGrid.DataSource, Data.DataTable)
            documento.SetRowStyle(1, style)

            documento.ImportDataTable(1, 1, dt, True)

            documento.SaveAs($"{dialog.FileName}.xlsx")
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function

    Public Function EliminarFilaDataGridClickDerecho(e As DataGridViewCellMouseEventArgs, dg As DataGridView) As Double
        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Or e.Button = MouseButtons.Left Then
                Return 0
            End If
            Dim filaEliminar As DataGridViewRow = dg.Rows(e.RowIndex)
            Dim resp = dg.Item("Importe", e.RowIndex).Value
            dg.Rows.Remove(filaEliminar)
            Return resp
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function

    Public Function ComprobarSiValorExisteCombo(combos As List(Of ComboBox)) As Int16

        For Each combo As ComboBox In combos

            Dim contador = 0

            For Each i As String In combo.Items
                If i = combo.Text Then
                    contador = 1
                ElseIf combo.Text = "" Then
                    contador = 1
                End If
            Next

            If contador <> 1 Then
                Return 0
            End If

        Next

        Return 1

    End Function

    Public Function FormatearFecha(d As Date) As Integer

        Dim fechaFormateada = Format(d, "yyyyMMdd")

        Return CInt(fechaFormateada)
    End Function


End Module
