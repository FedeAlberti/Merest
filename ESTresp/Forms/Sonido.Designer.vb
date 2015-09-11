<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sonido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sonido))
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imagen = New System.Windows.Forms.PictureBox()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(12, 12)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 80
        Me.btnsalir.TabStop = False
        Me.btnsalir.Text = "Volver"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'imagen
        '
        Me.imagen.Image = Global.WindowsApplication1.My.Resources.Resources.audio
        Me.imagen.InitialImage = CType(resources.GetObject("imagen.InitialImage"), System.Drawing.Image)
        Me.imagen.Location = New System.Drawing.Point(0, 1)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(470, 369)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 3
        Me.imagen.TabStop = False
        '
        'Sonido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(465, 366)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.imagen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Sonido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prueba - Sonido"
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
End Class
