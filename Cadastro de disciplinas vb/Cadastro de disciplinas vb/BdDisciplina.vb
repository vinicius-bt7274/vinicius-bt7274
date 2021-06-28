Imports MySql.Data.MySqlClient
Public Class BdDisciplina
    Inherits bd
    Public Sub New()
        Me.User = "root"
        Me.Servidor = "localhost"
        Me.Senha = "vertrigo"
        Me.bd = "Disciplina"
    End Sub
    Public Sub inserir(ByVal disciplina As Disciplina)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into disciplina (codigo,nome,professor,ch) values (@codigo,@nome,@professor,@ch)"
            cmd.Parameters.AddWithValue("@codigo", disciplina.codigo)
            cmd.Parameters.AddWithValue("@nome", disciplina.nome)
            cmd.Parameters.AddWithValue("@ch", disciplina.ch)
            cmd.Parameters.AddWithValue("@professor", disciplina.professor)
            cmd.Connection = Conexao
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub atualizar(ByVal disciplina As disciplina)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update disciplina set nome=@nome, professor=@professor, ch=@ch where codigo=@codigo"
            cmd.Parameters.AddWithValue("@codigo", disciplina.codigo)
            cmd.Parameters.AddWithValue("@nome", disciplina.nome)
            cmd.Parameters.AddWithValue("@professor", disciplina.professor)
            cmd.Parameters.AddWithValue("@ch", disciplina.ch)
            cmd.Connection = Conexao
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub excluir(ByVal codigo As Integer)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from disciplina where codigo=@codigo"
            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Connection = Conexao
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function localizar(ByVal codigo As Integer) As disciplina
        Dim dr As MySqlDataReader = Nothing
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim disciplina As New disciplina
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from disciplina where codigo=@codigo"
            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Connection = Conexao
            dr = cmd.ExecuteReader
            If dr.Read Then
                disciplina.codigo = dr.GetInt32("codigo")
                disciplina.nome = dr.GetString("nome")
                disciplina.ch = dr.GetString("ch")
                disciplina.professor = dr.GetString("professor")
            End If
            cmd.Dispose()
            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return disciplina
    End Function
    Public Function pesquisa(ByVal nome As String) As DataSet
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from disciplina where nome like @nome"
            cmd.Parameters.AddWithValue("@nome", "%" & nome & "%")

            cmd.Connection = Conexao
            da.SelectCommand = cmd
            da.Fill(ds)
            da.Dispose()
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds
    End Function
End Class
