// Decompiled with JetBrains decompiler
// Type: SearchAPI.tagVARDESC
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System.Runtime.InteropServices;

namespace SearchAPI
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct tagVARDESC
  {
    public int memid;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string lpstrSchema;
    public __MIDL_IOleAutomationTypes_0006 DUMMYUNIONNAME;
    public tagELEMDESC elemdescVar;
    public ushort wVarFlags;
    public tagVARKIND varkind;
  }
}
