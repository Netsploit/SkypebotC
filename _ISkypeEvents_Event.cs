// Type: SKYPE4COMLib._ISkypeEvents_Event
// Assembly: SkypeBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 048B048F-9FED-4588-943C-2DBD6218D623
// Assembly location: C:\Users\Monstercat\Pictures\skypebot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SKYPE4COMLib
{
  [ComEventInterface(typeof (_ISkypeEvents), typeof (_ISkypeEvents))]
  [TypeIdentifier("03282b5d-b38f-469d-849a-09b0a7f4881b", "SKYPE4COMLib._ISkypeEvents_Event")]
  [CompilerGenerated]
  [ComImport]
  public interface _ISkypeEvents_Event
  {
    event _ISkypeEvents_MessageStatusEventHandler MessageStatus;

    [SpecialName]
    void _VtblGap1_20();
  }
}
