// Type: SKYPE4COMLib.IChatMessage
// Assembly: SkypeBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 048B048F-9FED-4588-943C-2DBD6218D623
// Assembly location: C:\Users\Monstercat\Pictures\skypebot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SKYPE4COMLib
{
  [CompilerGenerated]
  [TypeIdentifier]
  [Guid("4CFF5C70-3C95-4566-824A-FA164586D535")]
  [ComImport]
  public interface IChatMessage
  {
    string Body { [DispId(8)] get; [DispId(8)] set; }

    User Sender { [DispId(13)] get; }

    [SpecialName]
    void _VtblGap1_7();

    [SpecialName]
    void _VtblGap2_4();

    [SpecialName]
    void _VtblGap3_2();
  }
}
