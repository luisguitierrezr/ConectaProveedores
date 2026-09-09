using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TI_ITEM_InRecord
public class JSONRC_49a19a6c249aebfaa8459808b60b7646 : AbstractRESTStructure<RC_49a19a6c249aebfaa8459808b60b7646> {
[JsonProperty("TI_ITEM_In")]
[JsonPropertyName("TI_ITEM_In")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_8d8928c3b1d6b9b5123f6c51624c56b2Structure AttrTI_ITEM_In;

public JSONRC_49a19a6c249aebfaa8459808b60b7646() { }

public JSONRC_49a19a6c249aebfaa8459808b60b7646 (RC_49a19a6c249aebfaa8459808b60b7646 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_ITEM_In = ConvertToRestWithoutDefaults(s.ssSTTI_ITEM_In, new ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_8d8928c3b1d6b9b5123f6c51624c56b2Structure.FromStructure, config);
  } else {
AttrTI_ITEM_In = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_8d8928c3b1d6b9b5123f6c51624c56b2Structure.FromStructure(s.ssSTTI_ITEM_In, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_49a19a6c249aebfaa8459808b60b7646, RC_49a19a6c249aebfaa8459808b60b7646> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_49a19a6c249aebfaa8459808b60b7646 s) => ToStructure(s, config);
}
public static RC_49a19a6c249aebfaa8459808b60b7646 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_49a19a6c249aebfaa8459808b60b7646 obj, IBehaviorsConfiguration config) { 
  RC_49a19a6c249aebfaa8459808b60b7646 s = new RC_49a19a6c249aebfaa8459808b60b7646();
  if(obj != null) {
  s.ssSTTI_ITEM_In = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_8d8928c3b1d6b9b5123f6c51624c56b2Structure.ToStructure(obj.AttrTI_ITEM_In, config);
  }
  return s;
}

public static Func<RC_49a19a6c249aebfaa8459808b60b7646, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_49a19a6c249aebfaa8459808b60b7646> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_49a19a6c249aebfaa8459808b60b7646 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_49a19a6c249aebfaa8459808b60b7646 FromStructure(RC_49a19a6c249aebfaa8459808b60b7646 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_49a19a6c249aebfaa8459808b60b7646(s, config);
}

}


