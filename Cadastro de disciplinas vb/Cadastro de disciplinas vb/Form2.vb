Public Class Form2
    Dim mDisciplina As New Disciplina
    Dim mnovo As Boolean
    Dim bd As New BdDisciplina
    Private Sub Disciplinatotela()
        txtcodigo.Text = mDisciplina.codigo
        txtnome.Text = mDisciplina.nome
        txtprofessor.Text = mDisciplina.professor
        txtch.Text = mDisciplina.ch
        txtprofessor.Text = mDisciplina.professor
    End Sub
    Private Sub telatoDisciplina()
        mDisciplina.codigo = txtcodigo.Text
        mDisciplina.professor = txtprofessor.Text
        mDisciplina.nome = txtnome.Text
        mDisciplina.ch = txtch.Text
        mDisciplina.professor = txtprofessor.Text
    End Sub
    Public Property Disciplina()
        Get
            Return mDisciplina
        End Get
        Set(ByVal value)
            mDisciplina = value
            Disciplinatotela()
        End Set
    End Property
    Public Property novo()
        Get
            Return mnovo
        End Get
        Set(ByVal value)
            mnovo = value
        End Set
    End Property

    Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click

    End Sub

    Private Sub btnsalvar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        telatoDisciplina()
        If novo Then
            bd.inserir(Disciplina)
        Else
            bd.atualizar(Disciplina)
        End If
        Me.Dispose()
    End Sub
End Class