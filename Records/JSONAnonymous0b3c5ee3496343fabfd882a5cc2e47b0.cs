using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderCostCenterRecord
public class JSONRC_5460c4bf9b3f96576a08e29ae969cbe7 : AbstractRESTStructure<RC_5460c4bf9b3f96576a08e29ae969cbe7> {
[JsonProperty("OrderCostCenter")]
[JsonPropertyName("OrderCostCenter")]
public ssConectaProveedores.RestRecords.JSONEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord AttrOrderCostCenter;

public JSONRC_5460c4bf9b3f96576a08e29ae969cbe7() { }

public JSONRC_5460c4bf9b3f96576a08e29ae969cbe7 (RC_5460c4bf9b3f96576a08e29ae969cbe7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderCostCenter = ConvertToRestWithoutDefaults(s.ssENOrderCostCenter, new EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.FromStructure, config);
  } else {
AttrOrderCostCenter = ssConectaProveedores.RestRecords.JSONEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.FromStructure(s.ssENOrderCostCenter, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_5460c4bf9b3f96576a08e29ae969cbe7, RC_5460c4bf9b3f96576a08e29ae969cbe7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_5460c4bf9b3f96576a08e29ae969cbe7 s) => ToStructure(s, config);
}
public static RC_5460c4bf9b3f96576a08e29ae969cbe7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_5460c4bf9b3f96576a08e29ae969cbe7 obj, IBehaviorsConfiguration config) { 
  RC_5460c4bf9b3f96576a08e29ae969cbe7 s = new RC_5460c4bf9b3f96576a08e29ae969cbe7();
  if(obj != null) {
  s.ssENOrderCostCenter = ssConectaProveedores.RestRecords.JSONEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.ToStructure(obj.AttrOrderCostCenter, config);
  }
  return s;
}

public static Func<RC_5460c4bf9b3f96576a08e29ae969cbe7, ssConectaProveedores.RestRecords.JSONRC_5460c4bf9b3f96576a08e29ae969cbe7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5460c4bf9b3f96576a08e29ae969cbe7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_5460c4bf9b3f96576a08e29ae969cbe7 FromStructure(RC_5460c4bf9b3f96576a08e29ae969cbe7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_5460c4bf9b3f96576a08e29ae969cbe7(s, config);
}

}


