using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_WXD_InRecord
public class JSONRC_94d82433e65dbd6bd2e4554a9c8fd005 : AbstractRESTStructure<RC_94d82433e65dbd6bd2e4554a9c8fd005> {
[JsonProperty("TI_WXD_In")]
[JsonPropertyName("TI_WXD_In")]
public ssConectaProveedores.RestRecords.JSONST_a8dbb50321f7e9ee99b69f05907922f9Structure AttrTI_WXD_In;

public JSONRC_94d82433e65dbd6bd2e4554a9c8fd005() { }

public JSONRC_94d82433e65dbd6bd2e4554a9c8fd005 (RC_94d82433e65dbd6bd2e4554a9c8fd005 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_WXD_In = ConvertToRestWithoutDefaults(s.ssSTTI_WXD_In, new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(), ssConectaProveedores.RestRecords.JSONST_a8dbb50321f7e9ee99b69f05907922f9Structure.FromStructure, config);
  } else {
AttrTI_WXD_In = ssConectaProveedores.RestRecords.JSONST_a8dbb50321f7e9ee99b69f05907922f9Structure.FromStructure(s.ssSTTI_WXD_In, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_94d82433e65dbd6bd2e4554a9c8fd005, RC_94d82433e65dbd6bd2e4554a9c8fd005> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_94d82433e65dbd6bd2e4554a9c8fd005 s) => ToStructure(s, config);
}
public static RC_94d82433e65dbd6bd2e4554a9c8fd005 ToStructure(ssConectaProveedores.RestRecords.JSONRC_94d82433e65dbd6bd2e4554a9c8fd005 obj, IBehaviorsConfiguration config) { 
  RC_94d82433e65dbd6bd2e4554a9c8fd005 s = new RC_94d82433e65dbd6bd2e4554a9c8fd005();
  if(obj != null) {
  s.ssSTTI_WXD_In = ssConectaProveedores.RestRecords.JSONST_a8dbb50321f7e9ee99b69f05907922f9Structure.ToStructure(obj.AttrTI_WXD_In, config);
  }
  return s;
}

public static Func<RC_94d82433e65dbd6bd2e4554a9c8fd005, ssConectaProveedores.RestRecords.JSONRC_94d82433e65dbd6bd2e4554a9c8fd005> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_94d82433e65dbd6bd2e4554a9c8fd005 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_94d82433e65dbd6bd2e4554a9c8fd005 FromStructure(RC_94d82433e65dbd6bd2e4554a9c8fd005 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_94d82433e65dbd6bd2e4554a9c8fd005(s, config);
}

}


