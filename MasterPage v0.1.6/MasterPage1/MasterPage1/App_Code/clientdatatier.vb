Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Web
Imports System.Configuration.ConfigurationManager
Imports System.Collections
Imports System.Collections.Generic


Public Class clientdatatier


    'create connection
    Dim connString As New SqlClient.SqlConnection(ConnectionStrings("connString").ConnectionString)
    Dim cmdString As New SqlClient.SqlCommand

    Public Sub AddPatient(ByVal PAT_ID As String, ByVal FNAME As String, ByVal MI As String, ByVal LNAME As String, ByVal DOB As Date, ByVal GENDER As String, ByVal STREET As String, ByVal CITY As String, ByVal STATEABBR As String, ByVal ZIP As String, ByVal CELL_PHONE As String, ByVal HOME_PHONE As String)
        'ByVal PAT_ID As String, ByVal FNAME As String, ByVal MI As String, ByVal LNAME As String)

        Try

            cmdString.Parameters.Clear()

            'open connection
            connString.Open()

            'command
            With cmdString
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 900
                .CommandText = "ADD_PATIENT"
                'Define input parameter 
                .Parameters.Add("@PATIENTID", SqlDbType.VarChar, 5).Value = PAT_ID
                .Parameters.Add("@FNAME", SqlDbType.VarChar, 25).Value = FNAME
                .Parameters.Add("@MIDINT", SqlDbType.Char, 1).Value = MI
                .Parameters.Add("@LNAME", SqlDbType.VarChar, 25).Value = LNAME
                .Parameters.Add("@GENDER", SqlDbType.VarChar, 6).Value = GENDER
                .Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB
                .Parameters.Add("@STREET", SqlDbType.VarChar, 60).Value = STREET
                .Parameters.Add("@CITY", SqlDbType.VarChar, 60).Value = CITY
                .Parameters.Add("@STATE_INT", SqlDbType.VarChar, 2).Value = STATEABBR
                .Parameters.Add("@ZIPCODE", SqlDbType.VarChar, 5).Value = ZIP
                .Parameters.Add("@HOME_PHONE", SqlDbType.VarChar, 15).Value = HOME_PHONE
                .Parameters.Add("@CELL_PHONE", SqlDbType.VarChar, 15).Value = CELL_PHONE
                '.Parameters.Add("@ACCT_BAL", SqlDbType.VarChar, 8, 2).Value = ACCT_BAL
                '.Parameters.Add("@WORK_EMAIL", SqlDbType.VarChar, 60).Value = WORK_EMAIL
                '.Parameters.Add("@PERSONAL_EMAIL", SqlDbType.VarChar, 60).Value = PERSONAL_EMAIL
                '.Parameters.Add("@ACCT_BAL", SqlDbType.VarChar, 8, 2).Value = ACCT_BAL

                'execute command
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        Finally
            connString.Close()
        End Try
    End Sub


    Public Sub AddPhysician(ByVal PHYS_ID As String, ByVal FNAME As String, ByVal MI As String, ByVal LNAME As String, ByVal DOB As Date, ByVal GENDER As String, ByVal STREET As String, ByVal CITY As String, ByVal STATEABBR As String, ByVal ZIP As String, ByVal CELL_PHONE As String, ByVal HOME_PHONE As String, ByVal SALARY As String, ByVal EMAIL As String, ByVal SPECIAL As String)
        'ByVal PAT_ID As String, ByVal FNAME As String, ByVal MI As String, ByVal LNAME As String)

        Try

            cmdString.Parameters.Clear()

            'open connection
            connString.Open()

            'command
            With cmdString
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 900
                .CommandText = "AddPhysician"
                'Define input parameter 
                .Parameters.Add("@Staff_ID", SqlDbType.VarChar, 6).Value = PHYS_ID
                .Parameters.Add("@Fname", SqlDbType.VarChar, 25).Value = FNAME
                .Parameters.Add("@Midinit", SqlDbType.Char, 1).Value = MI
                .Parameters.Add("@Lname", SqlDbType.VarChar, 25).Value = LNAME
                .Parameters.Add("@Gender", SqlDbType.VarChar, 6).Value = GENDER
                .Parameters.Add("@Dob", SqlDbType.DateTime).Value = DOB
                .Parameters.Add("@Street", SqlDbType.VarChar, 60).Value = STREET
                .Parameters.Add("@City", SqlDbType.VarChar, 60).Value = CITY
                .Parameters.Add("@State_init", SqlDbType.VarChar, 2).Value = STATEABBR
                .Parameters.Add("@Zipcode", SqlDbType.VarChar, 5).Value = ZIP
                .Parameters.Add("@Home_phone", SqlDbType.VarChar, 15).Value = HOME_PHONE
                .Parameters.Add("@Cell_phone", SqlDbType.VarChar, 15).Value = CELL_PHONE
                .Parameters.Add("@Salary", SqlDbType.VarChar, 10, 2).Value = SALARY
                .Parameters.Add("@Email", SqlDbType.VarChar, 60).Value = EMAIL
                .Parameters.Add("@Specialty", SqlDbType.VarChar, 60).Value = SPECIAL
                '.Parameters.Add("@WORK_EMAIL", SqlDbType.VarChar, 60).Value = WORK_EMAIL
                '.Parameters.Add("@PERSONAL_EMAIL", SqlDbType.VarChar, 60).Value = PERSONAL_EMAIL
                '.Parameters.Add("@ACCT_BAL", SqlDbType.VarChar, 8, 2).Value = ACCT_BAL

                'execute command
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        Finally
            connString.Close()
        End Try
    End Sub


    Public Sub AddPrescription(ByVal RXNUM As String, ByVal MEDNAME As String, ByVal Patient_ID As String, ByVal PATIENTFNAME As String, ByVal PATIENTLNAME As String, ByVal REFILL As String, ByVal INTAKE As String, ByVal DOSAGE As String, ByVal FREQ As String, ByVal STAFF_ID As String, ByVal DOCTORSFNAME As String, ByVal DOCTORSLNAME As String, ByVal DATEPRESCRIBED As Date)
        Try
            cmdString.Parameters.Clear()
            connString.Open()
            With cmdString
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 900
                .CommandText = "ADD_PRESCRIPTION"
                .Parameters.Add("@RXNUM", SqlDbType.VarChar, 5).Value = RXNUM
                .Parameters.Add("@MEDNAME", SqlDbType.VarChar, 60).Value = MEDNAME
                .Parameters.Add("@PATIENT_ID", SqlDbType.VarChar, 5).Value = Patient_ID
                .Parameters.Add("@PATIENTFNAME", SqlDbType.VarChar, 25).Value = PATIENTFNAME
                .Parameters.Add("@PATIENTLNAME", SqlDbType.VarChar, 25).Value = PATIENTLNAME
                .Parameters.Add("@REFILL", SqlDbType.VarChar, 10).Value = REFILL
                .Parameters.Add("@INTAKE", SqlDbType.VarChar, 25).Value = INTAKE
                .Parameters.Add("@DOSAGE", SqlDbType.VarChar, 255).Value = DOSAGE
                .Parameters.Add("@FREQ", SqlDbType.VarChar, 255).Value = FREQ
                .Parameters.Add("@STAFF_ID", SqlDbType.VarChar, 5).Value = STAFF_ID
                .Parameters.Add("@DOCTORSFNAME", SqlDbType.VarChar, 25).Value = DOCTORSFNAME
                .Parameters.Add("@DOCTORSLNAME", SqlDbType.VarChar, 25).Value = DOCTORSLNAME
                .Parameters.Add("@DATEPRESCRIBED", SqlDbType.Date).Value = DATEPRESCRIBED
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        Finally
            connString.Close()
        End Try
    End Sub


    Public Function searchRX(ByVal rxID As String) As DataSet

        Try
            'open connection
            connString.Open()
            cmdString.Parameters.Clear()
            'command
            cmdString.Connection = connString
            cmdString.CommandType = CommandType.StoredProcedure
            cmdString.CommandTimeout = 1500
            cmdString.CommandText = "searchPresc"

            'define input parameter
            'cmdString.Parameters.Add("@studentid", SqlDbType.VarChar, 5).Value = studid
            'cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname
            cmdString.Parameters.Add("@Prescription_ID", SqlDbType.VarChar, 5).Value = rxID

            'adapter and dataset
            Dim aAdapter As New SqlClient.SqlDataAdapter
            aAdapter.SelectCommand = cmdString
            Dim aDataset As New DataSet

            'fill adapter
            aAdapter.Fill(aDataset)

            'return dataset
            Return aDataset

        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        Finally
            connString.Close()
        End Try
    End Function


    Public Function SearchNameInRX(ByVal lname As String, ByVal fname As String, ByVal rxID As String) As DataSet

        Try
            'open connection
            connString.Open()
            cmdString.Parameters.Clear()
            'command
            cmdString.Connection = connString
            cmdString.CommandType = CommandType.StoredProcedure
            cmdString.CommandTimeout = 1500
            cmdString.CommandText = "SearchRX"

            'define input parameter
            cmdString.Parameters.Add("@rxnum", SqlDbType.VarChar, 5).Value = rxID
            cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname
            cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname

            'adapter and dataset
            Dim aAdapter As New SqlClient.SqlDataAdapter
            aAdapter.SelectCommand = cmdString
            Dim aDataset As New DataSet

            'fill adapter
            aAdapter.Fill(aDataset)

            'return dataset
            Return aDataset

        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        Finally
            connString.Close()
        End Try
    End Function


    Public Function GETPREscriptionINFO(ByVal rxID As String) As DataSet

        Try
            'open connection
            connString.Open()
            cmdString.Parameters.Clear()
            'command
            cmdString.Connection = connString
            cmdString.CommandType = CommandType.StoredProcedure
            cmdString.CommandTimeout = 1500
            cmdString.CommandText = "GETPREscriptionINFO"

            'define input parameter
            'cmdString.Parameters.Add("@studentid", SqlDbType.VarChar, 5).Value = studid
            'cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname
            cmdString.Parameters.Add("@RXNUM", SqlDbType.VarChar, 5).Value = rxID

            'adapter and dataset
            Dim aAdapter As New SqlClient.SqlDataAdapter
            aAdapter.SelectCommand = cmdString
            Dim aDataset As New DataSet

            'fill adapter
            aAdapter.Fill(aDataset)

            'return dataset
            Return aDataset

        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        Finally
            connString.Close()
        End Try
    End Function


    Public Sub UPDATEPRESCRIPTION(ByVal RXNUM As String, ByVal MEDNAME As String, ByVal Patient_ID As String, ByVal PATIENTFNAME As String, ByVal PATIENTLNAME As String, ByVal REFILL As String, ByVal INTAKE As String, ByVal DOSAGE As String, ByVal FREQ As String, ByVal STAFF_ID As String, ByVal DOCTORSFNAME As String, ByVal DOCTORSLNAME As String, ByVal DATEPRESCRIBED As Date)

        Try
            cmdString.Parameters.Clear()

            'open connection'
            connString.Open()

            'command'
            With cmdString
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "UPDATEPRESCRIPTION"

                'Define input parameter'
                .Parameters.Add("@RXNUM", SqlDbType.VarChar, 5).Value = RXNUM
                .Parameters.Add("@MEDNAME", SqlDbType.VarChar, 60).Value = MEDNAME
                .Parameters.Add("@PATIENT_ID", SqlDbType.VarChar, 5).Value = Patient_ID
                .Parameters.Add("@PATIENTFNAME", SqlDbType.VarChar, 25).Value = PATIENTFNAME
                .Parameters.Add("@PATIENTLNAME", SqlDbType.VarChar, 25).Value = PATIENTLNAME
                .Parameters.Add("@REFILL", SqlDbType.VarChar, 10).Value = REFILL
                .Parameters.Add("@INTAKE", SqlDbType.VarChar, 25).Value = INTAKE
                .Parameters.Add("@DOSAGE", SqlDbType.VarChar, 255).Value = DOSAGE
                .Parameters.Add("@FREQ", SqlDbType.VarChar, 255).Value = FREQ
                .Parameters.Add("@STAFF_ID", SqlDbType.VarChar, 5).Value = STAFF_ID
                .Parameters.Add("@DOCTORSFNAME", SqlDbType.VarChar, 25).Value = DOCTORSFNAME
                .Parameters.Add("@DOCTORSLNAME", SqlDbType.VarChar, 25).Value = DOCTORSLNAME
                .Parameters.Add("@DATEPRESCRIBED", SqlDbType.Date).Value = DATEPRESCRIBED
                .ExecuteNonQuery()

                'execute command'
                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        Finally
            connString.Close()
        End Try

    End Sub


    Public Sub DELETE_PRESCRIPTION(ByVal RXNUM As String)

        Try
            cmdString.Parameters.Clear()
            connString.Open()

            With cmdString
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "DELETEPRESCRIPTION"

                'Define input parameter'
                .Parameters.Add("@RXNUM", SqlDbType.VarChar, 5).Value = RXNUM

                'execute command'
                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        Finally
            connString.Close()
        End Try

    End Sub


    'Public Function GetCompletionList(ByVal prefixText As String, ByVal count As Integer) As String()

    '    Try
    '        cmdString.Parameters.Clear()

    '        'open connection'
    '        connString.Open()

    '        'command'
    '        With cmdString
    '            .Connection = connString
    '            .CommandType = CommandType.StoredProcedure
    '            .CommandTimeout = 1500
    '            .CommandText = ""

    '        End With

    '    Catch ex As Exception
    '        Throw New ArgumentException(ex.Message)
    '    Finally
    '        connString.Close()
    '    End Try

    'End Function

End Class
