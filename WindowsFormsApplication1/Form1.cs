// Type: WindowsFormsApplication1.Form1
// Assembly: SkypeBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 048B048F-9FED-4588-943C-2DBD6218D623
// Assembly location: C:\Users\Monstercat\Pictures\skypebot.exe

using SKYPE4COMLib;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private const string trigger = "!";
    private const string nick = "";
    private const string trigSMS = "{";
    private const string exit = "}";
    private const string say = ".";
    private Skype skype;
    private Label label1;
    private Label label2;
    private ComboBox comboBox1;

    public Form1()
    {
      this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.skype = (Skype) Activator.CreateInstance(System.Type.GetTypeFromCLSID(new Guid("830690FC-BF2F-47A6-AC2D-330BCB402664")));
      // ISSUE: reference to a compiler-generated method
      this.skype.Attach(7, false);
      // ISSUE: method pointer
      // ISSUE: object of a compiler-generated type is created
      new ComAwareEventInfo(typeof (_ISkypeEvents_Event), "MessageStatus").AddEventHandler((object) this.skype, (Delegate) new _ISkypeEvents_MessageStatusEventHandler((object) this, (UIntPtr) __methodptr(skype_MessageStatus)));
    }

    private void skype_MessageStatus(ChatMessage msg, TChatMessageStatus status)
    {
      if (msg.Body.IndexOf("!") == 0)
      {
        string str = msg.Body.Remove(0, "!".Length).ToLower();
        // ISSUE: reference to a compiler-generated method
        this.skype.SendMessage(msg.Sender.Handle, " " + this.ProcessCommand(str));
      }
      else
      {
        if (msg.Body.IndexOf("{") != 0)
          return;
        string TargetNumbers = "+5555555555";
        string str = msg.Body.Remove(0, "{".Length).ToLower();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: variable of a compiler-generated type
        ISmsMessage smsMessage = (ISmsMessage) this.skype.CreateSms(TSmsMessageType.smsMessageTypeOutgoing, TargetNumbers);
        smsMessage.Body = str;
        // ISSUE: reference to a compiler-generated method
        smsMessage.Send();
      }
    }

    private string ProcessCommand(string str)
    {
      string str1;
      switch (str)
      {
        case "activate":
          str1 = "You have now been activated. Type !cmd to start";
          break;
        case "help":
          str1 = "You must be verified first to use this. Get the auth pass from owner.";
          break;
        case "cmd":
          str1 = "~~~~~~~~CAT's BOT~~~~~~~~\r\n!hello - Will reply with a 'Hello!'\r\n!about - Tells you about the bot!\r\n!nice - Tells you compliment\r\n!diss - Insult\r\n!flip - Flips a coin\r\n!pickup - Pickup line\r\n!racist - Tells a racist joke!\r\n!purchase - Purchase one of our products\r\n!ad - Advertisment\r\n~~~~~~~~CAT's BOT~~~~~~~~\r\n";
          break;
        case "ad":
          str1 = "$10/Week for your Advertisment Here!";
          break;
        case "nice":
          str1 = "Your cooking reminds me of my mother's.";
          break;
        case "diss":
          str1 = "Your the type of nigga to wait to eat until everyone has their food..";
          break;
        case "flip":
          str1 = "Tails.";
          break;
        case "pickup":
          str1 = "I want you more then a Popsicle on a hot summer day";
          break;
        case "racist":
          str1 = "Q: What's long and hard on a black man? - A: First Grade";
          break;
        case "purchase":
          str1 = "http://leak.sx/user-70225";
          break;
        case "spam":
          str1 = "Isn't working at the moment";
          break;
        case "about":
          str1 = "This was designed for fun actually, and made it out of free time. More functions and commands will be added later, like Xbox Codes and Netflix!";
          break;
        case "netflix":
          str1 = "Under maintence";
          break;
        case "resolve":
          str1 = "Resolving..";
          break;
        default:
          str1 = "Sorry, I do not recognize your command";
          break;
      }
      return str1;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.label2 = new Label();
      this.comboBox1 = new ComboBox();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(49, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(312, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Click the Program, then it will ask on Skype to Run The Program.";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(186, 31);
      this.label2.Name = "label2";
      this.label2.Size = new Size(53, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Functions";
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[15]
      {
        (object) "!help",
        (object) "!activate",
        (object) "!cmd",
        (object) "!ad",
        (object) "!nice",
        (object) "!diss",
        (object) "!flip",
        (object) "!pickup",
        (object) "!racist",
        (object) "!purchase",
        (object) "!spam",
        (object) "!about",
        (object) "!resolve",
        (object) "!netflix * not working",
        (object) "!spam * not working"
      });
      this.comboBox1.Location = new Point(12, 47);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(389, 21);
      this.comboBox1.TabIndex = 2;
      this.comboBox1.Text = "!activate";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(413, 89);
      this.Controls.Add((Control) this.comboBox1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Name = "Form1";
      this.Text = "Skype Bot - By Deer/Asylum";
      this.Load += new EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
