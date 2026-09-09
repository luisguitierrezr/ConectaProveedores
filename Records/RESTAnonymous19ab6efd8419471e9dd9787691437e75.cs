using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_ITEM_InRecord
public class RESTRC_49a19a6c249aebfaa8459808b60b7646 : AbstractRESTStructure<RC_49a19a6c249aebfaa8459808b60b7646> {
[JsonProperty("TI_ITEM_In")]
public ssConectaProveedores.RestRecords.RESTST_8d8928c3b1d6b9b5123f6c51624c56b2Structure AttrTI_ITEM_In;

public RESTRC_49a19a6c249aebfaa8459808b60b7646() { }

public RESTRC_49a19a6c249aebfaa8459808b60b7646 (RC_49a19a6c249aebfaa8459808b60b7646 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_ITEM_In = ConvertToRestWithoutDefaults(s.ssSTTI_ITEM_In, new ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure(), ssConectaProveedores.RestRecords.RESTST_8d8928c3b1d6b9b5123f6c51624c56b2Structure.FromStructure, config);
  } else {
AttrTI_ITEM_In = ssConectaProveedores.RestRecords.RESTST_8d8928c3b1d6b9b5123f6c51624c56b2Structure.FromStructure(s.ssSTTI_ITEM_In, config);
  }
}

public static RC_49a19a6c249aebfaa8459808b60b7646 ToStructure(ssConectaProveedores.RestRecords.RESTRC_49a19a6c249aebfaa8459808b60b7646 obj) { 
  RC_49a19a6c249aebfaa8459808b60b7646 s = new RC_49a19a6c249aebfaa8459808b60b7646();
  if(obj != null) {
  s.ssSTTI_ITEM_In = ssConectaProveedores.RestRecords.RESTST_8d8928c3b1d6b9b5123f6c51624c56b2Structure.ToStructure(obj.AttrTI_ITEM_In);
  }
  return s;
}

public static Func<RC_49a19a6c249aebfaa8459808b60b7646, ssConectaProveedores.RestRecords.RESTRC_49a19a6c249aebfaa8459808b60b7646> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_49a19a6c249aebfaa8459808b60b7646 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_49a19a6c249aebfaa8459808b60b7646 FromStructure(RC_49a19a6c249aebfaa8459808b60b7646 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_49a19a6c249aebfaa8459808b60b7646(s, config);
}

}


