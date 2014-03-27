// Type: SKYPE4COMLib.ISkype
// Assembly: SkypeBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 048B048F-9FED-4588-943C-2DBD6218D623
// Assembly location: C:\Users\Monstercat\Pictures\skypebot.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SKYPE4COMLib
{
  [TypeIdentifier]
  [Guid("B1878BFE-53D3-402E-8C86-190B19AF70D5")]
  [CompilerGenerated]
  [ComImport]
  public interface ISkype
  {
    [SpecialName]
    void _VtblGap1_26();

    [DispId(21)]
    void Attach([In] int Protocol = 5, [In] bool Wait = true);

    [SpecialName]
    void _VtblGap2_1();

    [DispId(23)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ChatMessage SendMessage([MarshalAs(UnmanagedType.BStr), In] string Username, [MarshalAs(UnmanagedType.BStr), In] string Text);

    [SpecialName]
    void _VtblGap3_44();

    [DispId(65)]
    [return: MarshalAs(UnmanagedType.Interface)]
    SmsMessage CreateSms([In] TSmsMessageType MessageType, [MarshalAs(UnmanagedType.BStr), In] string TargetNumbers);
  }
}
