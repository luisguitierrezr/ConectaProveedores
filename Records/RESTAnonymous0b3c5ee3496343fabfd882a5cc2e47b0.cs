using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderCostCenterRecord
public class RESTRC_5460c4bf9b3f96576a08e29ae969cbe7 : AbstractRESTStructure<RC_5460c4bf9b3f96576a08e29ae969cbe7> {
[JsonProperty("OrderCostCenter")]
public ssConectaProveedores.RestRecords.RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord AttrOrderCostCenter;

public RESTRC_5460c4bf9b3f96576a08e29ae969cbe7() { }

public RESTRC_5460c4bf9b3f96576a08e29ae969cbe7 (RC_5460c4bf9b3f96576a08e29ae969cbe7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderCostCenter = ConvertToRestWithoutDefaults(s.ssENOrderCostCenter, new EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.FromStructure, config);
  } else {
AttrOrderCostCenter = ssConectaProveedores.RestRecords.RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.FromStructure(s.ssENOrderCostCenter, config);
  }
}

public static RC_5460c4bf9b3f96576a08e29ae969cbe7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_5460c4bf9b3f96576a08e29ae969cbe7 obj) { 
  RC_5460c4bf9b3f96576a08e29ae969cbe7 s = new RC_5460c4bf9b3f96576a08e29ae969cbe7();
  if(obj != null) {
  s.ssENOrderCostCenter = ssConectaProveedores.RestRecords.RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.ToStructure(obj.AttrOrderCostCenter);
  }
  return s;
}

public static Func<RC_5460c4bf9b3f96576a08e29ae969cbe7, ssConectaProveedores.RestRecords.RESTRC_5460c4bf9b3f96576a08e29ae969cbe7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5460c4bf9b3f96576a08e29ae969cbe7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5460c4bf9b3f96576a08e29ae969cbe7 FromStructure(RC_5460c4bf9b3f96576a08e29ae969cbe7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5460c4bf9b3f96576a08e29ae969cbe7(s, config);
}

}


