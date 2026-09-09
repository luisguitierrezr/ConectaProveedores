using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderCostCenter
public class RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord : AbstractRESTStructure<EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("OrderId")]
public long? AttrOrderId;

[JsonProperty("CostcenterSAP")]
public long? AttrCostcenterSAP;

public RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord() { }

public RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord (EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderId = ConvertToRestWithoutDefaults(s.ssOrderId, 0L);
AttrCostcenterSAP = ConvertToRestWithoutDefaults(s.ssCostcenterSAP, 0L);
  } else {
AttrId = (long?) s.ssId;
AttrOrderId = (long?) s.ssOrderId;
AttrCostcenterSAP = (long?) s.ssCostcenterSAP;
  }
}

public static EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord obj) { 
  EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord s = new EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderId = obj.AttrOrderId == null ? 0L : obj.AttrOrderId.Value;
  s.ssCostcenterSAP = obj.AttrCostcenterSAP == null ? 0L : obj.AttrCostcenterSAP.Value;
  }
  return s;
}

public static Func<EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord, ssConectaProveedores.RestRecords.RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord FromStructure(EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord(s, config);
}

}


