using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionContractFileRequisitionRequisitionFile2StorageRecord
public class JSONRC_409326af30f6b67f1d011aa096c0a54e : AbstractRESTStructure<RC_409326af30f6b67f1d011aa096c0a54e> {
[JsonProperty("RequisitionContractFile")]
[JsonPropertyName("RequisitionContractFile")]
public ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord AttrRequisitionContractFile;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionFile2")]
[JsonPropertyName("RequisitionFile2")]
public ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord AttrRequisitionFile2;

[JsonProperty("Storage")]
[JsonPropertyName("Storage")]
public ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public JSONRC_409326af30f6b67f1d011aa096c0a54e() { }

public JSONRC_409326af30f6b67f1d011aa096c0a54e (RC_409326af30f6b67f1d011aa096c0a54e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionContractFile = ConvertToRestWithoutDefaults(s.ssENRequisitionContractFile, new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionFile2 = ConvertToRestWithoutDefaults(s.ssENRequisitionFile2, new EN_4cce425e15647f937e21de4e52849889EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrRequisitionContractFile = ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure(s.ssENRequisitionContractFile, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionFile2 = ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure(s.ssENRequisitionFile2, config);
AttrStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_409326af30f6b67f1d011aa096c0a54e, RC_409326af30f6b67f1d011aa096c0a54e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_409326af30f6b67f1d011aa096c0a54e s) => ToStructure(s, config);
}
public static RC_409326af30f6b67f1d011aa096c0a54e ToStructure(ssConectaProveedores.RestRecords.JSONRC_409326af30f6b67f1d011aa096c0a54e obj, IBehaviorsConfiguration config) { 
  RC_409326af30f6b67f1d011aa096c0a54e s = new RC_409326af30f6b67f1d011aa096c0a54e();
  if(obj != null) {
  s.ssENRequisitionContractFile = ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.ToStructure(obj.AttrRequisitionContractFile, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRequisitionFile2 = ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.ToStructure(obj.AttrRequisitionFile2, config);
  s.ssENStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage, config);
  }
  return s;
}

public static Func<RC_409326af30f6b67f1d011aa096c0a54e, ssConectaProveedores.RestRecords.JSONRC_409326af30f6b67f1d011aa096c0a54e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_409326af30f6b67f1d011aa096c0a54e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_409326af30f6b67f1d011aa096c0a54e FromStructure(RC_409326af30f6b67f1d011aa096c0a54e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_409326af30f6b67f1d011aa096c0a54e(s, config);
}

}


