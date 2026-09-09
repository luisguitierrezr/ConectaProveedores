using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionAccConceptsRequisitionRequisitionAccountingRequisitionFile2StorageRecord
public class JSONRC_b9bb40a47bdab047afc7e2a4a1fde846 : AbstractRESTStructure<RC_b9bb40a47bdab047afc7e2a4a1fde846> {
[JsonProperty("RequisitionAccConcepts")]
[JsonPropertyName("RequisitionAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord AttrRequisitionAccConcepts;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionAccounting")]
[JsonPropertyName("RequisitionAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord AttrRequisitionAccounting;

[JsonProperty("RequisitionFile2")]
[JsonPropertyName("RequisitionFile2")]
public ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord AttrRequisitionFile2;

[JsonProperty("Storage")]
[JsonPropertyName("Storage")]
public ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public JSONRC_b9bb40a47bdab047afc7e2a4a1fde846() { }

public JSONRC_b9bb40a47bdab047afc7e2a4a1fde846 (RC_b9bb40a47bdab047afc7e2a4a1fde846 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionAccConcepts = ConvertToRestWithoutDefaults(s.ssENRequisitionAccConcepts, new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionAccounting = ConvertToRestWithoutDefaults(s.ssENRequisitionAccounting, new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure, config);
AttrRequisitionFile2 = ConvertToRestWithoutDefaults(s.ssENRequisitionFile2, new EN_4cce425e15647f937e21de4e52849889EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrRequisitionAccConcepts = ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure(s.ssENRequisitionAccConcepts, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionAccounting = ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure(s.ssENRequisitionAccounting, config);
AttrRequisitionFile2 = ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure(s.ssENRequisitionFile2, config);
AttrStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b9bb40a47bdab047afc7e2a4a1fde846, RC_b9bb40a47bdab047afc7e2a4a1fde846> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b9bb40a47bdab047afc7e2a4a1fde846 s) => ToStructure(s, config);
}
public static RC_b9bb40a47bdab047afc7e2a4a1fde846 ToStructure(ssConectaProveedores.RestRecords.JSONRC_b9bb40a47bdab047afc7e2a4a1fde846 obj, IBehaviorsConfiguration config) { 
  RC_b9bb40a47bdab047afc7e2a4a1fde846 s = new RC_b9bb40a47bdab047afc7e2a4a1fde846();
  if(obj != null) {
  s.ssENRequisitionAccConcepts = ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.ToStructure(obj.AttrRequisitionAccConcepts, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRequisitionAccounting = ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.ToStructure(obj.AttrRequisitionAccounting, config);
  s.ssENRequisitionFile2 = ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.ToStructure(obj.AttrRequisitionFile2, config);
  s.ssENStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage, config);
  }
  return s;
}

public static Func<RC_b9bb40a47bdab047afc7e2a4a1fde846, ssConectaProveedores.RestRecords.JSONRC_b9bb40a47bdab047afc7e2a4a1fde846> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b9bb40a47bdab047afc7e2a4a1fde846 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b9bb40a47bdab047afc7e2a4a1fde846 FromStructure(RC_b9bb40a47bdab047afc7e2a4a1fde846 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b9bb40a47bdab047afc7e2a4a1fde846(s, config);
}

}


