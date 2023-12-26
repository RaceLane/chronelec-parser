// Decompiled with JetBrains decompiler
// Type: Elite2Telegram.Settings
// Assembly: Elite2Telegram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 46828820-D95D-4403-BC47-900D61E5BF21
// Assembly location: D:\Projects\auto-sport\Chronelec\22RT\Elite2Telegram.exe

using System;

#nullable disable
namespace Elite2Telegram
{
  [Serializable]
  public class Settings
  {
    public string BotToken { get; set; }

    public string GroupID { get; set; }

    public string Directory { get; set; }

    public int EventType { get; set; }

    public int EventId { get; set; }
  }
}
