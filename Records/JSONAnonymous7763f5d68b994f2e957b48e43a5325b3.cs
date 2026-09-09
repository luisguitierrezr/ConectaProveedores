using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionContractFileRequisitionRequisitionFile2Record
public class JSONRC_c3feeb794fa34d46adcdce2db9588d18 : AbstractRESTStructure<RC_c3feeb794fa34d46adcdce2db9588d18> {
[JsonProperty("RequisitionContractFile")]
[JsonPropertyName("RequisitionContractFile")]
public ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord AttrRequisitionContractFile;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionFile2")]
[JsonPropertyName("RequisitionFile2")]
public ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord AttrRequisitionFile2;

public JSONRC_c3feeb794fa34d46adcdce2db9588d18() { }

public JSONRC_c3feeb794fa34d46adcdce2db9588d18 (RC_c3feeb794fa34d46adcdce2db9588d18 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionContractFile = ConvertToRestWithoutDefaults(s.ssENRequisitionContractFile, new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionFile2 = ConvertToRestWithoutDefaults(s.ssENRequisitionFile2, new EN_4cce425e15647f937e21de4e52849889EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure, config);
  } else {
AttrRequisitionContractFile = ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure(s.ssENRequisitionContractFile, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionFile2 = ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure(s.ssENRequisitionFile2, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c3feeb794fa34d46adcdce2db9588d18, RC_c3feeb794fa34d46adcdce2db9588d18> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c3feeb794fa34d46adcdce2db9588d18 s) => ToStructure(s, config);
}
public static RC_c3feeb794fa34d46adcdce2db9588d18 ToStructure(ssConectaProveedores.RestRecords.JSONRC_c3feeb794fa34d46adcdce2db9588d18 obj, IBehaviorsConfiguration config) { 
  RC_c3feeb794fa34d46adcdce2db9588d18 s = new RC_c3feeb794fa34d46adcdce2db9588d18();
  if(obj != null) {
  s.ssENRequisitionContractFile = ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.ToStructure(obj.AttrRequisitionContractFile, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRequisitionFile2 = ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.ToStructure(obj.AttrRequisitionFile2, config);
  }
  return s;
}

public static Func<RC_c3feeb794fa34d46adcdce2db9588d18, ssConectaProveedores.RestRecords.JSONRC_c3feeb794fa34d46adcdce2db9588d18> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c3feeb794fa34d46adcdce2db9588d18 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c3feeb794fa34d46adcdce2db9588d18 FromStructure(RC_c3feeb794fa34d46adcdce2db9588d18 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c3feeb794fa34d46adcdce2db9588d18(s, config);
}

}


