using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionApprovalLevelIdRequisitionIdRequisitionNameIsAccountingIsSelectedRecord
public class JSONRC_da31ba4ed131103eb5a5b5464cca7643 : AbstractRESTStructure<RC_da31ba4ed131103eb5a5b5464cca7643> {
[JsonProperty("RequisitionApprovalLevelId")]
[JsonPropertyName("RequisitionApprovalLevelId")]
public long? AttrRequisitionApprovalLevelId;

[JsonProperty("RequisitionId")]
[JsonPropertyName("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("RequisitionName")]
[JsonPropertyName("RequisitionName")]
public string AttrRequisitionName;

[JsonProperty("IsAccounting")]
[JsonPropertyName("IsAccounting")]
public bool? AttrIsAccounting;

[JsonProperty("IsSelected")]
[JsonPropertyName("IsSelected")]
public bool? AttrIsSelected;

public JSONRC_da31ba4ed131103eb5a5b5464cca7643() { }

public JSONRC_da31ba4ed131103eb5a5b5464cca7643 (RC_da31ba4ed131103eb5a5b5464cca7643 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionApprovalLevelId = ConvertToRestWithoutDefaults(s.ssRequisitionApprovalLevelId, 0L);
AttrRequisitionId = ConvertToRestWithoutDefaults(s.ssRequisitionId, 0L);
AttrRequisitionName = ConvertToRestWithoutDefaults(s.ssRequisitionName, "");
AttrIsAccounting = ConvertToRestWithoutDefaults(s.ssIsAccounting, false);
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
  } else {
AttrRequisitionApprovalLevelId = (long?) s.ssRequisitionApprovalLevelId;
AttrRequisitionId = (long?) s.ssRequisitionId;
AttrRequisitionName = s.ssRequisitionName;
AttrIsAccounting = (bool?) s.ssIsAccounting;
AttrIsSelected = (bool?) s.ssIsSelected;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_da31ba4ed131103eb5a5b5464cca7643, RC_da31ba4ed131103eb5a5b5464cca7643> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_da31ba4ed131103eb5a5b5464cca7643 s) => ToStructure(s, config);
}
public static RC_da31ba4ed131103eb5a5b5464cca7643 ToStructure(ssConectaProveedores.RestRecords.JSONRC_da31ba4ed131103eb5a5b5464cca7643 obj, IBehaviorsConfiguration config) { 
  RC_da31ba4ed131103eb5a5b5464cca7643 s = new RC_da31ba4ed131103eb5a5b5464cca7643();
  if(obj != null) {
  s.ssRequisitionApprovalLevelId = obj.AttrRequisitionApprovalLevelId == null ? 0L : obj.AttrRequisitionApprovalLevelId.Value;
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssRequisitionName = obj.AttrRequisitionName == null ? "" : obj.AttrRequisitionName;
  s.ssIsAccounting = obj.AttrIsAccounting == null ? false : obj.AttrIsAccounting.Value;
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  }
  return s;
}

public static Func<RC_da31ba4ed131103eb5a5b5464cca7643, ssConectaProveedores.RestRecords.JSONRC_da31ba4ed131103eb5a5b5464cca7643> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_da31ba4ed131103eb5a5b5464cca7643 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_da31ba4ed131103eb5a5b5464cca7643 FromStructure(RC_da31ba4ed131103eb5a5b5464cca7643 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_da31ba4ed131103eb5a5b5464cca7643(s, config);
}

}


