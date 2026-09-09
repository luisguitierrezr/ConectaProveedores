using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionCostCenter
public class JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord : AbstractRESTStructure<EN_114fcf95674648310a3efb0d78529a37EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("RequisitionId")]
[JsonPropertyName("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("CostcenterSAP")]
[JsonPropertyName("CostcenterSAP")]
public long? AttrCostcenterSAP;

public JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord() { }

public JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord (EN_114fcf95674648310a3efb0d78529a37EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRequisitionId = ConvertToRestWithoutDefaults(s.ssRequisitionId, 0L);
AttrCostcenterSAP = ConvertToRestWithoutDefaults(s.ssCostcenterSAP, 0L);
  } else {
AttrId = (long?) s.ssId;
AttrRequisitionId = (long?) s.ssRequisitionId;
AttrCostcenterSAP = (long?) s.ssCostcenterSAP;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord, EN_114fcf95674648310a3efb0d78529a37EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord s) => ToStructure(s, config);
}
public static EN_114fcf95674648310a3efb0d78529a37EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_114fcf95674648310a3efb0d78529a37EntityRecord s = new EN_114fcf95674648310a3efb0d78529a37EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssCostcenterSAP = obj.AttrCostcenterSAP == null ? 0L : obj.AttrCostcenterSAP.Value;
  }
  return s;
}

public static Func<EN_114fcf95674648310a3efb0d78529a37EntityRecord, ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_114fcf95674648310a3efb0d78529a37EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord FromStructure(EN_114fcf95674648310a3efb0d78529a37EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_114fcf95674648310a3efb0d78529a37EntityRecord(s, config);
}

}


