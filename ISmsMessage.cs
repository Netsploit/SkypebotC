// Type: SKYPE4COMLib.ISmsMessage
// Assembly: SkypeBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 048B048F-9FED-4588-943C-2DBD6218D623
// Assembly location: C:\Users\Monstercat\Pictures\skypebot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SKYPE4COMLib
{
  [Guid("82D97F2A-0E17-40F3-8E01-24937F936FF4")]
  [TypeIdentifier]
  [CompilerGenerated]
  [ComImport]
  public interface ISmsMessage
  {
    string Body { [DispId(12)] get; [DispId(12)] set; }

    [SpecialName]
    void _VtblGap1_12();

    [SpecialName]
    void _VtblGap2_2();

    [DispId(15)]
    void Send();
  }
}
