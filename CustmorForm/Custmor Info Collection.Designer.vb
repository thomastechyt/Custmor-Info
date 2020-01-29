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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim OSLabel As System.Windows.Forms.Label
        Dim VersonLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.CustmorinfoDataSet = New CustmorForm.custmorinfoDataSet()
        Me.CustmorTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustmorTableTableAdapter = New CustmorForm.custmorinfoDataSetTableAdapters.CustmorTableTableAdapter()
        Me.TableAdapterManager = New CustmorForm.custmorinfoDataSetTableAdapters.TableAdapterManager()
        Me.CustmorTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CustmorTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.OSTextBox = New System.Windows.Forms.TextBox()
        Me.VersonTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        OSLabel = New System.Windows.Forms.Label()
        VersonLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.CustmorinfoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustmorTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustmorTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustmorTableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustmorinfoDataSet
        '
        Me.CustmorinfoDataSet.DataSetName = "custmorinfoDataSet"
        Me.CustmorinfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustmorTableBindingSource
        '
        Me.CustmorTableBindingSource.DataMember = "CustmorTable"
        Me.CustmorTableBindingSource.DataSource = Me.CustmorinfoDataSet
        '
        'CustmorTableTableAdapter
        '
        Me.CustmorTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustmorTableTableAdapter = Me.CustmorTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = CustmorForm.custmorinfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustmorTableBindingNavigator
        '
        Me.CustmorTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustmorTableBindingNavigator.BindingSource = Me.CustmorTableBindingSource
        Me.CustmorTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustmorTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustmorTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustmorTableBindingNavigatorSaveItem})
        Me.CustmorTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustmorTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustmorTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustmorTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustmorTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustmorTableBindingNavigator.Name = "CustmorTableBindingNavigator"
        Me.CustmorTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustmorTableBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.CustmorTableBindingNavigator.TabIndex = 0
        Me.CustmorTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CustmorTableBindingNavigatorSaveItem
        '
        Me.CustmorTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustmorTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustmorTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustmorTableBindingNavigatorSaveItem.Name = "CustmorTableBindingNavigatorSaveItem"
        Me.CustmorTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CustmorTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(5, 30)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 1
        First_NameLabel.Text = "First Name:"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustmorTableBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(72, 27)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_NameTextBox.TabIndex = 2
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(5, 56)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 3
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustmorTableBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(72, 53)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 4
        '
        'OSLabel
        '
        OSLabel.AutoSize = True
        OSLabel.Location = New System.Drawing.Point(5, 82)
        OSLabel.Name = "OSLabel"
        OSLabel.Size = New System.Drawing.Size(25, 13)
        OSLabel.TabIndex = 5
        OSLabel.Text = "OS:"
        '
        'OSTextBox
        '
        Me.OSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustmorTableBindingSource, "OS", True))
        Me.OSTextBox.Location = New System.Drawing.Point(72, 79)
        Me.OSTextBox.Name = "OSTextBox"
        Me.OSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OSTextBox.TabIndex = 6
        '
        'VersonLabel
        '
        VersonLabel.AutoSize = True
        VersonLabel.Location = New System.Drawing.Point(5, 108)
        VersonLabel.Name = "VersonLabel"
        VersonLabel.Size = New System.Drawing.Size(43, 13)
        VersonLabel.TabIndex = 7
        VersonLabel.Text = "Verson:"
        '
        'VersonTextBox
        '
        Me.VersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustmorTableBindingSource, "Verson", True))
        Me.VersonTextBox.Location = New System.Drawing.Point(72, 105)
        Me.VersonTextBox.Name = "VersonTextBox"
        Me.VersonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VersonTextBox.TabIndex = 8
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(5, 134)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 9
        PhoneLabel.Text = "Phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustmorTableBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(72, 131)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneTextBox.TabIndex = 10
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(5, 160)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustmorTableBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(72, 157)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 182)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(OSLabel)
        Me.Controls.Add(Me.OSTextBox)
        Me.Controls.Add(VersonLabel)
        Me.Controls.Add(Me.VersonTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.CustmorTableBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CustmorinfoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustmorTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustmorTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustmorTableBindingNavigator.ResumeLayout(False)
        Me.CustmorTableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustmorinfoDataSet As custmorinfoDataSet
    Friend WithEvents CustmorTableBindingSource As BindingSource
    Friend WithEvents CustmorTableTableAdapter As custmorinfoDataSetTableAdapters.CustmorTableTableAdapter
    Friend WithEvents TableAdapterManager As custmorinfoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustmorTableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustmorTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents OSTextBox As TextBox
    Friend WithEvents VersonTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
End Class
