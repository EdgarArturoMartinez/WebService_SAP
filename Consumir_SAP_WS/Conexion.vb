Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes


Public Class Conexion

    'Declarar Variables de Conexión
    Public ds As New DataSet()
    Public da As New SqlDataAdapter
    Public dt As New DataTable
    Public comando As SqlCommand
    Public con As SqlConnection
    Public col As DataColumn

    'Declarar Función Conectar
    Public Function Conectar() As SqlConnection
        Dim cadena = ("Data Source=296imb01; Initial Catalog = db_Negocio_Inmobiliario; Persist Security Info=True;User ID=si2;Password=si2_VPinmobiliaria")
        Dim con As New SqlConnection(cadena)
        Try
            con.Open()
            Return con
        Catch ex As Exception
            Return con
            con.Close()
        End Try
    End Function


    'Función Para Realizar de Contratos a Sincronizar
    Public Function NumContratos(Campo1 As String) As Boolean

        Dim sql As String = " SELECT COUNT(*) FROM [dbo].[tbl_WF_Casual_Leasing_Condiciones_Negocio] " &
                                " WHERE Condiciones_Validadas = 1 AND [Actualizado_SAP] = 0 " &
                                " AND Id_GUID =  '" & Campo1 & "' "
        con = Conectar()
        comando = New SqlCommand(sql, con)
        da = New SqlDataAdapter(comando)
        ds = New DataSet()
        da.Fill(ds)
        dt = New DataTable()
        dt = ds.Tables(0)

        If (ds IsNot Nothing) Then
            Return True
        Else
            Return False
            con.Close()
            ds.Dispose()
        End If
        con.Close()
        ds.Dispose()

    End Function



    'Función Para Realizar Consulta en la Vista de la base de datos.
    Public Function DatosSap(Campo1 As String) As Boolean

        Dim sql As String = " SELECT TOP(1) Depben, Deprec, Contrato, Tipocon, str_Nit_Cedula, " &
                                " Nombre_1, Nombre_2, Apellido_1, Apellido_2, " &
                                " Dirección_Empresa, str_Telefono, str_Correo_Electronico, " &
                                " FECHA_INICIAL, FECHA_FIN, Contraprestación, Ciudad_Cedula, " &
                                " Tiponit, Burks, Pais, Region, Actualizado_SAP  " &
                                " FROM Qry_WS_Casual_Leasing_F2 " &
                                " WHERE Id_GUID =  '" & Campo1 & "' AND Actualizado_SAP = 0 "
        con = Conectar()
        comando = New SqlCommand(sql, con)
        da = New SqlDataAdapter(comando)
        ds = New DataSet()
        da.Fill(ds)
        dt = New DataTable()
        dt = ds.Tables(0)

        If (ds IsNot Nothing) Then
            Return True
        Else
            Return False
            con.Close()
            ds.Dispose()
        End If
        con.Close()
        ds.Dispose()

    End Function



    'Función para actualizar Dependencia 2032
    Public Function Dep2032(campo1 As String, campo2 As String) As Boolean

        Dim sql As String = " ALTER TABLE tbl_WF_Casual_Leasing_Condiciones_Negocio " &
                            " DISABLE Trigger Validar_Condiciones_Casual_Leasing " &
                            " UPDATE [dbo].[tbl_WF_Casual_Leasing_Condiciones_Negocio] " &
                            " SET [Actualizado_SAP] = 1, " &
                            " str_Console_Response = 'Dependencia 2032 Sin Recaudo para Sincronizar en SAP.  Fecha de Proceso = " & Day(Now) & "/" & Month(Now) & "/" & Year(Now) & "   Hora Proceso = " & Hour(Now) & ":" & Minute(Now) & " ' , " &
                            " Validacion_Final = 1  WHERE Id_GUID = '" & campo1 & "' AND Id_Condiciones_Negocio = '" & campo2 & "' " &
                            " ALTER TABLE tbl_WF_Casual_Leasing_Condiciones_Negocio ENABLE Trigger Validar_Condiciones_Casual_Leasing"
        con = Conectar()
        comando = New SqlCommand(sql, con)
        Dim i As String = comando.ExecuteNonQuery()
        con.Close()
        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    'Función para actualizar Dependencias Sin Filtro
    Public Function ActualizarFinal(msgConsole As String, campo1 As String, campo2 As String, Param1 As String,
                                    Param2 As String, Param3 As String, Param4 As String, Param5 As String, Param6 As String,
                                    Param7 As String, Param8 As String, Param9 As String, Param10 As String, Param11 As String,
                                    Param12 As String, Param13 As String, Param14 As String, Param15 As String, Param16 As String,
                                    Param17 As String, Param18 As String, Param19 As String, Param20 As String) As Boolean

        Dim sql As String = " ALTER TABLE tbl_WF_Casual_Leasing_Condiciones_Negocio " &
                            " DISABLE Trigger Validar_Condiciones_Casual_Leasing " &
                            " UPDATE [dbo].[tbl_WF_Casual_Leasing_Condiciones_Negocio] " &
                            " SET [Actualizado_SAP] = 1, " &
                            " str_Console_Response = '" & msgConsole & ".   Fecha de Proceso = " & Day(Now) & "/" & Month(Now) & "/" & Year(Now) & "   Hora Proceso = " & Hour(Now) & ":" & Minute(Now) &
                            " SQL Ejecutada =    SELECT Depben, Deprec, Contrato, Tipocon, str_Nit_Cedula,Nombre_1, Nombre_2, Apellido_1, Apellido_2,Dirección_Empresa, str_Telefono, str_Correo_Electronico,FECHA_INICIAL, FECHA_FIN, Contraprestación, Ciudad_Cedula,Tiponit, Burks, Pais, Region, Actualizado_SAP FROM Qry_WS_Casual_Leasing_F2 WHERE Contrato = " & campo2 &
                            "     Parametros Enviados:  " & Param1 & ", " & Param2 & ", " & Param3 & ", " & Param4 & ", " & Param5 & ", " & Param6 & ", " & Param7 & ", " & Param8 & ", " & Param9 & ", " & Param10 & ", " & Param11 & ", " & Param12 & ", " & Param13 & ", " & Param14 & ", " & Param15 & ", " & Param16 & ", " & Param17 & ", " & Param18 & ", " & Param19 & " ' , " &
                            " Validacion_Final = 1  WHERE Id_GUID = '" & campo1 & "' AND Id_Condiciones_Negocio = '" & campo2 & "' " &
                            " ALTER TABLE tbl_WF_Casual_Leasing_Condiciones_Negocio ENABLE Trigger Validar_Condiciones_Casual_Leasing"
        con = Conectar()
        comando = New SqlCommand(sql, con)
        Dim i As String = comando.ExecuteNonQuery()
        con.Close()
        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function



    'Función Para Realizar Consulta en la Vista de la base de datos.
    Public Function DatosSuper(Campo1 As String) As Boolean

        Dim sql As String = " SELECT TOP (1) tbl_M_Marcas.str_Descripción_Marca " &
                                " FROM tbl_WF_Casual_Leasing_Condiciones_Negocio INNER JOIN " &
                                " tbl_H_Areas_X_Inmueble_Detalle ON   " &
                                " tbl_WF_Casual_Leasing_Condiciones_Negocio.Numero_Local = tbl_H_Areas_X_Inmueble_Detalle.lng_Id_Area_Detalle INNER JOIN " &
                                " tbl_M_Inmueble_Detalle ON tbl_H_Areas_X_Inmueble_Detalle.str_Id_División = tbl_M_Inmueble_Detalle.str_División INNER JOIN " &
                                " tbl_M_Marcas ON tbl_M_Inmueble_Detalle.lng_Id_Marca = tbl_M_Marcas.lng_Id_Marca " &
                                " WHERE (tbl_WF_Casual_Leasing_Condiciones_Negocio.Id_GUID =  '" & Campo1 & "' ) "
        con = Conectar()
        comando = New SqlCommand(sql, con)
        da = New SqlDataAdapter(comando)
        ds = New DataSet()
        da.Fill(ds)
        dt = New DataTable()
        dt = ds.Tables(0)

        If (ds IsNot Nothing) Then
            Return True
        Else
            Return False
            con.Close()
            ds.Dispose()
        End If
        con.Close()
        ds.Dispose()

    End Function


    'Función Para Realizar Consulta en la Vista de la base de datos.
    Public Function DatosSMX(Campo1 As String) As Boolean

        Dim sql As String = " SELECT TOP (1) tbl_M_Marcas.str_Descripción_Marca " &
                                " FROM tbl_WF_Casual_Leasing_Condiciones_Negocio INNER JOIN " &
                                " tbl_H_Areas_X_Inmueble_Detalle ON   " &
                                " tbl_WF_Casual_Leasing_Condiciones_Negocio.Numero_Local = tbl_H_Areas_X_Inmueble_Detalle.lng_Id_Area_Detalle INNER JOIN " &
                                " tbl_M_Inmueble_Detalle ON tbl_H_Areas_X_Inmueble_Detalle.str_Id_División = tbl_M_Inmueble_Detalle.str_División INNER JOIN " &
                                " tbl_M_Marcas ON tbl_M_Inmueble_Detalle.lng_Id_Marca = tbl_M_Marcas.lng_Id_Marca " &
                                " WHERE (tbl_WF_Casual_Leasing_Condiciones_Negocio.Id_GUID =  '" & Campo1 & "' ) "
        con = Conectar()
        comando = New SqlCommand(sql, con)
        da = New SqlDataAdapter(comando)
        ds = New DataSet()
        da.Fill(ds)
        dt = New DataTable()
        dt = ds.Tables(0)

        If (ds IsNot Nothing) Then
            Return True
        Else
            Return False
            con.Close()
            ds.Dispose()
        End If
        con.Close()
        ds.Dispose()

    End Function




End Class
