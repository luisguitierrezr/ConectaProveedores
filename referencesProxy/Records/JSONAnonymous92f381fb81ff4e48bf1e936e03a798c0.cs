using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ItemSMRecord
public class JSONRC_bc90ae5f0dadb418c4abf32f2cb9fe8c : AbstractRESTStructure<RC_bc90ae5f0dadb418c4abf32f2cb9fe8c> {
[JsonProperty("ItemSM")]
[JsonPropertyName("ItemSM")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure AttrItemSM;

public JSONRC_bc90ae5f0dadb418c4abf32f2cb9fe8c() { }

public JSONRC_bc90ae5f0dadb418c4abf32f2cb9fe8c (RC_bc90ae5f0dadb418c4abf32f2cb9fe8c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItemSM = ConvertToRestWithoutDefaults(s.ssSTItemSM, new ST_ab77394b00ae0f5875687584d175cf59Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure.FromStructure, config);
  } else {
AttrItemSM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure.FromStructure(s.ssSTItemSM, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_bc90ae5f0dadb418c4abf32f2cb9fe8c, RC_bc90ae5f0dadb418c4abf32f2cb9fe8c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_bc90ae5f0dadb418c4abf32f2cb9fe8c s) => ToStructure(s, config);
}
public static RC_bc90ae5f0dadb418c4abf32f2cb9fe8c ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_bc90ae5f0dadb418c4abf32f2cb9fe8c obj, IBehaviorsConfiguration config) { 
  RC_bc90ae5f0dadb418c4abf32f2cb9fe8c s = new RC_bc90ae5f0dadb418c4abf32f2cb9fe8c();
  if(obj != null) {
  s.ssSTItemSM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure.ToStructure(obj.AttrItemSM, config);
  }
  return s;
}

public static Func<RC_bc90ae5f0dadb418c4abf32f2cb9fe8c, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_bc90ae5f0dadb418c4abf32f2cb9fe8c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bc90ae5f0dadb418c4abf32f2cb9fe8c s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_bc90ae5f0dadb418c4abf32f2cb9fe8c FromStructure(RC_bc90ae5f0dadb418c4abf32f2cb9fe8c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_bc90ae5f0dadb418c4abf32f2cb9fe8c(s, config);
}

}


