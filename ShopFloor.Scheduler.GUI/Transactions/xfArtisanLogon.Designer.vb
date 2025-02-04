<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfArtisanLogon
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtArtisanCode = New DevExpress.XtraEditors.TextEdit()
        Me.lcLogon = New DevExpress.XtraLayout.LayoutControl()
        Me.btManage = New DevExpress.XtraEditors.SimpleButton()
        Me.btCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btOk = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPassword = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.txtArtisanCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcLogon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lcLogon.SuspendLayout()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtArtisanCode
        '
        Me.txtArtisanCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArtisanCode.Location = New System.Drawing.Point(444, 479)
        Me.txtArtisanCode.Name = "txtArtisanCode"
        Me.txtArtisanCode.Size = New System.Drawing.Size(648, 20)
        Me.txtArtisanCode.StyleController = Me.lcLogon
        Me.txtArtisanCode.TabIndex = 0
        '
        'lcLogon
        '
        Me.lcLogon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lcLogon.Controls.Add(Me.btManage)
        Me.lcLogon.Controls.Add(Me.btCancel)
        Me.lcLogon.Controls.Add(Me.btOk)
        Me.lcLogon.Controls.Add(Me.txtPassword)
        Me.lcLogon.Controls.Add(Me.txtArtisanCode)
        Me.lcLogon.Controls.Add(Me.PictureEdit1)
        Me.lcLogon.Location = New System.Drawing.Point(0, 0)
        Me.lcLogon.Name = "lcLogon"
        Me.lcLogon.OptionsView.UseSkinIndents = False
        Me.lcLogon.Root = Me.LayoutControlGroup1
        Me.lcLogon.Size = New System.Drawing.Size(1097, 566)
        Me.lcLogon.TabIndex = 0
        Me.lcLogon.Text = "LayoutControl1"
        '
        'btManage
        '
        Me.btManage.Location = New System.Drawing.Point(5, 5)
        Me.btManage.Name = "btManage"
        Me.btManage.Size = New System.Drawing.Size(362, 22)
        Me.btManage.StyleController = Me.lcLogon
        Me.btManage.TabIndex = 9
        Me.btManage.Text = "Manage"
        '
        'btCancel
        '
        Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancel.Location = New System.Drawing.Point(768, 539)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(324, 22)
        Me.btCancel.StyleController = Me.lcLogon
        Me.btCancel.TabIndex = 4
        Me.btCancel.Text = "&Cancel"
        '
        'btOk
        '
        Me.btOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btOk.Location = New System.Drawing.Point(377, 539)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(381, 22)
        Me.btOk.StyleController = Me.lcLogon
        Me.btOk.TabIndex = 3
        Me.btOk.Text = "&Logon"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.Location = New System.Drawing.Point(444, 509)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(648, 20)
        Me.txtPassword.StyleController = Me.lcLogon
        Me.txtPassword.TabIndex = 1
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(5, 37)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.NullText = "Company Logo"
        Me.PictureEdit1.Size = New System.Drawing.Size(362, 524)
        Me.PictureEdit1.StyleController = Me.lcLogon
        Me.PictureEdit1.TabIndex = 8
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciName, Me.lciPassword, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1097, 566)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lciName
        '
        Me.lciName.Control = Me.txtArtisanCode
        Me.lciName.CustomizationFormText = "&Artisan Code"
        Me.lciName.Location = New System.Drawing.Point(372, 474)
        Me.lciName.Name = "lciName"
        Me.lciName.Size = New System.Drawing.Size(725, 30)
        Me.lciName.Text = "&Artisan Code"
        Me.lciName.TextSize = New System.Drawing.Size(62, 13)
        Me.lciName.TextToControlDistance = 5
        '
        'lciPassword
        '
        Me.lciPassword.Control = Me.txtPassword
        Me.lciPassword.CustomizationFormText = "&Password"
        Me.lciPassword.Location = New System.Drawing.Point(372, 504)
        Me.lciPassword.Name = "lciPassword"
        Me.lciPassword.Size = New System.Drawing.Size(725, 30)
        Me.lciPassword.Text = "&Password"
        Me.lciPassword.TextSize = New System.Drawing.Size(62, 13)
        Me.lciPassword.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btOk
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(372, 534)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(391, 32)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btCancel
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(763, 534)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(334, 32)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PictureEdit1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 32)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(372, 534)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(372, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(725, 474)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btManage
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(372, 32)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'xfArtisanLogon
        '
        Me.AcceptButton = Me.btOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btCancel
        Me.ClientSize = New System.Drawing.Size(1097, 566)
        Me.Controls.Add(Me.lcLogon)
        Me.Name = "xfArtisanLogon"
        Me.Text = "Artisan Logon"
        CType(Me.txtArtisanCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcLogon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lcLogon.ResumeLayout(False)
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtArtisanCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lcLogon As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciPassword As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btManage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
