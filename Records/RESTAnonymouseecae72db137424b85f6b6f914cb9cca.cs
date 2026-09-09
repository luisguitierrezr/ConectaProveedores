using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionAccConceptsRequisitionRequisitionAccountingRequisitionFile2StorageRecord
public class RESTRC_b9bb40a47bdab047afc7e2a4a1fde846 : AbstractRESTStructure<RC_b9bb40a47bdab047afc7e2a4a1fde846> {
[JsonProperty("RequisitionAccConcepts")]
public ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord AttrRequisitionAccConcepts;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionAccounting")]
public ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord AttrRequisitionAccounting;

[JsonProperty("RequisitionFile2")]
public ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord AttrRequisitionFile2;

[JsonProperty("Storage")]
public ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public RESTRC_b9bb40a47bdab047afc7e2a4a1fde846() { }

public RESTRC_b9bb40a47bdab047afc7e2a4a1fde846 (RC_b9bb40a47bdab047afc7e2a4a1fde846 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionAccConcepts = ConvertToRestWithoutDefaults(s.ssENRequisitionAccConcepts, new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionAccounting = ConvertToRestWithoutDefaults(s.ssENRequisitionAccounting, new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure, config);
AttrRequisitionFile2 = ConvertToRestWithoutDefaults(s.ssENRequisitionFile2, new EN_4cce425e15647f937e21de4e52849889EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrRequisitionAccConcepts = ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure(s.ssENRequisitionAccConcepts, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionAccounting = ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure(s.ssENRequisitionAccounting, config);
AttrRequisitionFile2 = ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure(s.ssENRequisitionFile2, config);
AttrStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static RC_b9bb40a47bdab047afc7e2a4a1fde846 ToStructure(ssConectaProveedores.RestRecords.RESTRC_b9bb40a47bdab047afc7e2a4a1fde846 obj) { 
  RC_b9bb40a47bdab047afc7e2a4a1fde846 s = new RC_b9bb40a47bdab047afc7e2a4a1fde846();
  if(obj != null) {
  s.ssENRequisitionAccConcepts = ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.ToStructure(obj.AttrRequisitionAccConcepts);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENRequisitionAccounting = ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.ToStructure(obj.AttrRequisitionAccounting);
  s.ssENRequisitionFile2 = ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.ToStructure(obj.AttrRequisitionFile2);
  s.ssENStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage);
  }
  return s;
}

public static Func<RC_b9bb40a47bdab047afc7e2a4a1fde846, ssConectaProveedores.RestRecords.RESTRC_b9bb40a47bdab047afc7e2a4a1fde846> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b9bb40a47bdab047afc7e2a4a1fde846 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b9bb40a47bdab047afc7e2a4a1fde846 FromStructure(RC_b9bb40a47bdab047afc7e2a4a1fde846 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b9bb40a47bdab047afc7e2a4a1fde846(s, config);
}

}


