// Type: SKYPE4COMLib._ISkypeEvents
// Assembly: SkypeBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 048B048F-9FED-4588-943C-2DBD6218D623
// Assembly location: C:\Users\Monstercat\Pictures\skypebot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SKYPE4COMLib
{
  [TypeIdentifier]
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
  [Guid("F4F90CDD-C620-4118-945E-CAA1BBEBA435")]
  [ComImport]
  public interface _ISkypeEvents
  {
    [DispId(11)]
    void MessageStatus([MarshalAs(UnmanagedType.Interface), In] ChatMessage pMessage, [In] TChatMessageStatus Status);
  }
}
