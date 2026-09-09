using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionCostCenter
public class RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord : AbstractRESTStructure<EN_114fcf95674648310a3efb0d78529a37EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("CostcenterSAP")]
public long? AttrCostcenterSAP;

public RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord() { }

public RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord (EN_114fcf95674648310a3efb0d78529a37EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_114fcf95674648310a3efb0d78529a37EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord obj) { 
  EN_114fcf95674648310a3efb0d78529a37EntityRecord s = new EN_114fcf95674648310a3efb0d78529a37EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssCostcenterSAP = obj.AttrCostcenterSAP == null ? 0L : obj.AttrCostcenterSAP.Value;
  }
  return s;
}

public static Func<EN_114fcf95674648310a3efb0d78529a37EntityRecord, ssConectaProveedores.RestRecords.RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_114fcf95674648310a3efb0d78529a37EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord FromStructure(EN_114fcf95674648310a3efb0d78529a37EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord(s, config);
}

}


