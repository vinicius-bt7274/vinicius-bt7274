<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TxtfiltroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlteraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnfiltro = New System.Windows.Forms.Button()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.dgfiltro = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgfiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TxtfiltroToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TxtfiltroToolStripMenuItem
        '
        Me.TxtfiltroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AlteraToolStripMenuItem, Me.ExcluirToolStripMenuItem})
        Me.TxtfiltroToolStripMenuItem.Name = "TxtfiltroToolStripMenuItem"
        Me.TxtfiltroToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.TxtfiltroToolStripMenuItem.Text = "arquivo"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NovoToolStripMenuItem.Text = "novo"
        '
        'AlteraToolStripMenuItem
        '
        Me.AlteraToolStripMenuItem.Name = "AlteraToolStripMenuItem"
        Me.AlteraToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlteraToolStripMenuItem.Text = "alterar"
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExcluirToolStripMenuItem.Text = "excluir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "filtro"
        '
        'btnfiltro
        '
        Me.btnfiltro.Location = New System.Drawing.Point(178, 25)
        Me.btnfiltro.Name = "btnfiltro"
        Me.btnfiltro.Size = New System.Drawing.Size(75, 23)
        Me.btnfiltro.TabIndex = 2
        Me.btnfiltro.Text = "ok"
        Me.btnfiltro.UseVisualStyleBackColor = True
        '
        'txtfiltro
        '
        Me.txtfiltro.Location = New System.Drawing.Point(47, 27)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(125, 20)
        Me.txtfiltro.TabIndex = 3
        '
        'dgfiltro
        '
        Me.dgfiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgfiltro.Location = New System.Drawing.Point(18, 54)
        Me.dgfiltro.Name = "dgfiltro"
        Me.dgfiltro.Size = New System.Drawing.Size(240, 150)
        Me.dgfiltro.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.dgfiltro)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.btnfiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgfiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TxtfiltroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlteraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnfiltro As System.Windows.Forms.Button
    Friend WithEvents txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents dgfiltro As System.Windows.Forms.DataGridView

End Class
