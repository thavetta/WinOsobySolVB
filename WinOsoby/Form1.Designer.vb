<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ListBox1 = New ListBox()
        DataGridView1 = New DataGridView()
        MenuStrip1 = New MenuStrip()
        SuborToolStripMenuItem = New ToolStripMenuItem()
        NacitajToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        UložCSVToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        KoniecToolStripMenuItem = New ToolStripMenuItem()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(77, 66)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(221, 379)
        ListBox1.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(318, 66)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(594, 379)
        DataGridView1.TabIndex = 1
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {SuborToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(924, 24)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SuborToolStripMenuItem
        ' 
        SuborToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NacitajToolStripMenuItem, ToolStripMenuItem1, UložCSVToolStripMenuItem, ToolStripMenuItem2, KoniecToolStripMenuItem})
        SuborToolStripMenuItem.Name = "SuborToolStripMenuItem"
        SuborToolStripMenuItem.Size = New Size(50, 20)
        SuborToolStripMenuItem.Text = "Subor"
        ' 
        ' NacitajToolStripMenuItem
        ' 
        NacitajToolStripMenuItem.Name = "NacitajToolStripMenuItem"
        NacitajToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        NacitajToolStripMenuItem.Size = New Size(180, 22)
        NacitajToolStripMenuItem.Text = "Nacitaj"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(177, 6)
        ' 
        ' UložCSVToolStripMenuItem
        ' 
        UložCSVToolStripMenuItem.Name = "UložCSVToolStripMenuItem"
        UložCSVToolStripMenuItem.Size = New Size(180, 22)
        UložCSVToolStripMenuItem.Text = "Ulož CSV"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(177, 6)
        ' 
        ' KoniecToolStripMenuItem
        ' 
        KoniecToolStripMenuItem.Name = "KoniecToolStripMenuItem"
        KoniecToolStripMenuItem.Size = New Size(180, 22)
        KoniecToolStripMenuItem.Text = "Koniec"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(924, 577)
        Controls.Add(DataGridView1)
        Controls.Add(ListBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SuborToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NacitajToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents UložCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents KoniecToolStripMenuItem As ToolStripMenuItem

End Class
