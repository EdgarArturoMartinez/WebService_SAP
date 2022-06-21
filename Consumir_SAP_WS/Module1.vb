Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports Consumir_SAP_WS.sapdev
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Xml
Imports System.Net
Imports System.Text
Imports System.Net.Mime.MediaTypeNames
Imports System.IO


Module Module1
    Public Connect1 As New Conexion()
    Public Connect2 As New Conexion()
    Public Connect3 As New Conexion()
    Public Connect4 As New Conexion()
    Public Connect5 As New Conexion()
    Public Connect6 As New Conexion()

    Sub Main()

        Dim Guid As String

        'Consulta de proyecto XML
        Dim reader As XmlTextReader = New XmlTextReader("C:\Gabmer\SI²\Parametros Actividades.xml")
        reader.WhitespaceHandling = WhitespaceHandling.None
        reader.Read()
        While Not reader.EOF
            reader.Read()
            If Not reader.IsStartElement() Then
                Exit While
            End If

            Dim Casual As String

            Dim genderAttribute = reader.GetAttribute("GUID")
            reader.Read()

            Casual = reader.Value
            Guid = Casual

        End While
        reader.Close()


        'Procedimiento Para Conocer el Numero de Contratos Procesar
        Dim NumeroContratos As String
        Connect1.NumContratos(Guid)

        NumeroContratos = Connect1.ds.Tables(0).Rows(0)(0).ToString()

        Connect1.con.Close()
        Connect1.ds.Dispose()

        'Validar Si Existe un Contrato Para Procesar
        If NumeroContratos = 0 Then

            Dim EsSuper As String
            Connect5.DatosSuper(Guid)

            EsSuper = Connect5.ds.Tables(0).Rows(0)(0).ToString()

            If EsSuper = "SUPER INTER" Then

                Process.Start("\\296imb02\WF Casual Leasing\Modelos del Proceso\Calculo Tarifa Casual Leasing Super Inter.xlsm")
                Exit Sub

            Else

                Dim EsSMX As String
                Connect6.DatosSMX(Guid)

                EsSMX = Connect6.ds.Tables(0).Rows(0)(0).ToString()

                If EsSMX = "Surtimax" Or EsSMX = "Bodega Surtimax" Or EsSMX = "Bodeguita Surtimax" Then

                    Process.Start("\\296imb02\WF Casual Leasing\Modelos del Proceso\Calculo Tarifa Casual Leasing Surtimax.xlsm")
                    Exit Sub

                Else

                    Process.Start("\\296imb02\WF Casual Leasing\Modelos del Proceso\Calculo Tarifa Casual Leasing v1.xlsm")
                    Exit Sub

                End If


            End If

        Else


            Dim i As Integer



            For i = 1 To NumeroContratos

                'Consulta de Datos a Servicio Web

Bifurc:

                Dim Depben, Deprec, Tipocon, Nit,
                    Nombre1, Nombre2, Apell1, Apell2, Dir,
                    Telef, Email, Fecini, Fefin, Tiponit,
                    Bukrs, Pais, Region, ContratoNum, Valor, Ciudad As String


                Connect2.DatosSap(Guid)

                Depben = Connect2.ds.Tables(0).Rows(0)(0).ToString()
                Deprec = Connect2.ds.Tables(0).Rows(0)(1).ToString()
                ContratoNum = Connect2.ds.Tables(0).Rows(0)(2).ToString()
                Tipocon = Connect2.ds.Tables(0).Rows(0)(3).ToString()
                Nit = Connect2.ds.Tables(0).Rows(0)(4).ToString()
                Nombre1 = Connect2.ds.Tables(0).Rows(0)(5).ToString()
                Nombre2 = Connect2.ds.Tables(0).Rows(0)(6).ToString()
                Apell1 = Connect2.ds.Tables(0).Rows(0)(7).ToString()
                Apell2 = Connect2.ds.Tables(0).Rows(0)(8).ToString()
                Dir = Connect2.ds.Tables(0).Rows(0)(9).ToString()
                Telef = Connect2.ds.Tables(0).Rows(0)(10).ToString()
                Email = Connect2.ds.Tables(0).Rows(0)(11).ToString()
                Fecini = Connect2.ds.Tables(0).Rows(0)(12).ToString()
                Fefin = Connect2.ds.Tables(0).Rows(0)(13).ToString()
                Valor = Connect2.ds.Tables(0).Rows(0)(14).ToString()
                Ciudad = Connect2.ds.Tables(0).Rows(0)(15).ToString()
                Tiponit = Connect2.ds.Tables(0).Rows(0)(16).ToString()
                Bukrs = Connect2.ds.Tables(0).Rows(0)(17).ToString()
                Pais = Connect2.ds.Tables(0).Rows(0)(18).ToString()
                Region = Connect2.ds.Tables(0).Rows(0)(19).ToString()

                Connect2.con.Close()
                Connect2.ds.Dispose()

                'Proceso Dependencia 2032
                If Deprec = "2032" Then

                    'Condición que evalua la función actualizar
                    If Connect3.Dep2032(Guid, ContratoNum) Then
                        'Exit Sub

                        i = i + 1
                        GoTo Bifurc

                    End If

                Else

                    Dim ws = New ZFICL_CONTRATO()
                    ws.Credentials = New System.Net.NetworkCredential("conciliador", "visualsaldo123")

                    Dim contrato = New ZficlContrato()

                    Dim data = New ZficlDatos()

                    data.Depben = Depben
                    data.Deprec = Deprec
                    data.Contrato = ContratoNum
                    data.Tipocon = Tipocon
                    data.Nit = Nit
                    data.Nombre1 = Nombre1
                    data.Nombre2 = Nombre2
                    data.Apell1 = Apell1
                    data.Apell2 = Apell2
                    data.Dir = Dir
                    data.Telef = Telef
                    data.Email = Email
                    data.Fecini = Fecini
                    data.Fefin = Fefin
                    data.ValorSiniva = Valor
                    data.Ciudad = Ciudad
                    data.Tiponit = Tiponit
                    data.Bukrs = Bukrs
                    data.Pais = Pais
                    data.Region = Region

                    contrato.ItDatos = New ZficlDatos() {data}
                    contrato.ItReturn = New Bapireturn1() {}

                    Dim cadena As String

                    Try
                        Dim response = ws.ZficlContrato(contrato)

                        For Each resp In response.ItReturn
                            Console.WriteLine("{0} - {1}", resp.Type, resp.Message)
                            Dim v1 As String
                            v1 = resp.Message
                            cadena = v1

                            If Connect4.ActualizarFinal(cadena, Guid, ContratoNum, Depben, Deprec, ContratoNum, Tipocon, Nit, Nombre1, Nombre2, Apell1, Apell2,
                                                Dir, Telef, Email, Fecini, Fefin, Valor, Ciudad, Tiponit, Bukrs, Pais, Region) Then

                                MsgBox("El Contrato " & ContratoNum & " Se Ha Enviado a SAP Correctamente, Presione OK para continuar con el proceso.")

                            End If

                        Next

                    Catch ex As Exception
                        Console.WriteLine("{0}\n{1}", ex.Message, ex.StackTrace)

                        MsgBox("Existe un Problema de Conexión con el Servidor de SAP, por favor repita el proceso o comuniquese con los responsables del sistema.")
                        Exit Sub

                    End Try

                    'Console.ReadLine()


                End If

            Next i

        End If


    End Sub


End Module
