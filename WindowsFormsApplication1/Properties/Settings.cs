// Type: WindowsFormsApplication1.Properties.Settings
// Assembly: SkypeBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 048B048F-9FED-4588-943C-2DBD6218D623
// Assembly location: C:\Users\Monstercat\Pictures\skypebot.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace WindowsFormsApplication1.Properties
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  [CompilerGenerated]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings settings = Settings.defaultInstance;
        return settings;
      }
    }

    static Settings()
    {
    }
  }
}
