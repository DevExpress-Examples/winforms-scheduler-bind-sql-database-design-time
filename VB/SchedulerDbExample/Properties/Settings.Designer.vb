'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Namespace SchedulerDbExample.Properties

    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")>
    Friend NotInheritable Partial Class Settings
        Inherits Global.System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As SchedulerDbExample.Properties.Settings = CType((Global.System.Configuration.ApplicationSettingsBase.Synchronized(New SchedulerDbExample.Properties.Settings())), SchedulerDbExample.Properties.Settings)

        Public Shared ReadOnly Property [Default] As Settings
            Get
                Return SchedulerDbExample.Properties.Settings.defaultInstance
            End Get
        End Property

        <Global.System.Configuration.ApplicationScopedSettingAttribute()>
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
        <Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString)>
        <Global.System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SchedulerTest" & ".mdf;Integrated Security=True;Connect Timeout=30")>
        Public ReadOnly Property SchedulerTestConnectionString As String
            Get
                Return(CStr((Me("SchedulerTestConnectionString"))))
            End Get
        End Property
    End Class
End Namespace
