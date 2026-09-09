using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionFileTypesStruct
public class JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure : AbstractRESTStructure<ST_26b16bea631cbd94cf555acb5c7a4be3Structure> {
[JsonProperty("RequisitionContractFile")]
[JsonPropertyName("RequisitionContractFile")]
public ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord AttrRequisitionContractFile;

[JsonProperty("RequisitionFile")]
[JsonPropertyName("RequisitionFile")]
public ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord AttrRequisitionFile;

[JsonProperty("Valid")]
[JsonPropertyName("Valid")]
public ssConectaProveedores.RestRecords.JSONST_b453bea0930035904f55a74692afd3a8Structure AttrValid;

[JsonProperty("Binary")]
[JsonPropertyName("Binary")]
public byte[] AttrBinary;

[JsonProperty("BigUploadfileId")]
[JsonPropertyName("BigUploadfileId")]
public long? AttrBigUploadfileId;

public JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure() { }

public JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure (ST_26b16bea631cbd94cf555acb5c7a4be3Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionContractFile = ConvertToRestWithoutDefaults(s.ssRequisitionContractFile, new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure, config);
AttrRequisitionFile = ConvertToRestWithoutDefaults(s.ssRequisitionFile, new EN_4cce425e15647f937e21de4e52849889EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure, config);
AttrValid = ConvertToRestWithoutDefaults(s.ssValid, new ST_b453bea0930035904f55a74692afd3a8Structure(), ssConectaProveedores.RestRecords.JSONST_b453bea0930035904f55a74692afd3a8Structure.FromStructure, config);
AttrBinary = ConvertToRestWithoutDefaults(s.ssBinary);
AttrBigUploadfileId = ConvertToRestWithoutDefaults(s.ssBigUploadfileId, 0L);
  } else {
AttrRequisitionContractFile = ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure(s.ssRequisitionContractFile, config);
AttrRequisitionFile = ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure(s.ssRequisitionFile, config);
AttrValid = ssConectaProveedores.RestRecords.JSONST_b453bea0930035904f55a74692afd3a8Structure.FromStructure(s.ssValid, config);
AttrBinary = s.ssBinary;
AttrBigUploadfileId = (long?) s.ssBigUploadfileId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure, ST_26b16bea631cbd94cf555acb5c7a4be3Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure s) => ToStructure(s, config);
}
public static ST_26b16bea631cbd94cf555acb5c7a4be3Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure obj, IBehaviorsConfiguration config) { 
  ST_26b16bea631cbd94cf555acb5c7a4be3Structure s = new ST_26b16bea631cbd94cf555acb5c7a4be3Structure();
  if(obj != null) {
  s.ssRequisitionContractFile = ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.ToStructure(obj.AttrRequisitionContractFile, config);
  s.ssRequisitionFile = ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.ToStructure(obj.AttrRequisitionFile, config);
  s.ssValid = ssConectaProveedores.RestRecords.JSONST_b453bea0930035904f55a74692afd3a8Structure.ToStructure(obj.AttrValid, config);
  s.ssBinary = obj.AttrBinary == null ? new byte[] {} : obj.AttrBinary;
  s.ssBigUploadfileId = obj.AttrBigUploadfileId == null ? 0L : obj.AttrBigUploadfileId.Value;
  }
  return s;
}

public static Func<ST_26b16bea631cbd94cf555acb5c7a4be3Structure, ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_26b16bea631cbd94cf555acb5c7a4be3Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure FromStructure(ST_26b16bea631cbd94cf555acb5c7a4be3Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure(s, config);
}

}


