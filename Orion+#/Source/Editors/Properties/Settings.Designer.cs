
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Collections;
using System.Linq;


using System.Threading;
using Engine;

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace Engine
{
	namespace My
	{
		
		[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute(), 
		global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0"), 
		global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]sealed public 
		partial class Settings : global::System.Configuration.ApplicationSettingsBase
		{
			
			private static Settings defaultInstance; 
			
#region My.Settings Auto-Save Functionality
#if _MyType
			private static bool addedHandler;
			
			private static object addedHandlerLockObject = new object();
			
			[global::System.Diagnostics.DebuggerNonUserCodeAttribute(), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]private static void AutoSaveSettings(global::System.Object sender, global::System.EventArgs e)
			{
				if ((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).SaveMySettingsOnExit)
				{
					My.Settings.Default.Save();
				}
			}
#endif
#endregion
			
			public static Settings Default
			{
				get
				{
					
#if _MyType
					if (!addedHandler)
					{
						lock(addedHandlerLockObject)
						{
							if (!addedHandler)
							{
								(new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Shutdown += AutoSaveSettings;
								addedHandler = true;
							}
						}
					}
#endif
					return defaultInstance;
				}
			}
		}
	}
	
	namespace My
	{
		
		[global::Microsoft.VisualBasic.HideModuleNameAttribute(), 
		global::System.Diagnostics.DebuggerNonUserCodeAttribute(), 
		global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]internal sealed class MySettingsProperty
		{
			
			[global::System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")]internal static global::Engine.My.Settings Settings
			{
				get
				{
					return global::Engine.My.Settings.Default;
				}
			}
		}
	}
	
}