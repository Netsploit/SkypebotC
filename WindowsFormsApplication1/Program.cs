// Type: WindowsFormsApplication1.Program
// Assembly: SkypeBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 048B048F-9FED-4588-943C-2DBD6218D623
// Assembly location: C:\Users\Monstercat\Pictures\skypebot.exe

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
