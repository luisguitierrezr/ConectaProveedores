using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionFileTypesStruct
public class RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure : AbstractRESTStructure<ST_26b16bea631cbd94cf555acb5c7a4be3Structure> {
[JsonProperty("RequisitionContractFile")]
public ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord AttrRequisitionContractFile;

[JsonProperty("RequisitionFile")]
public ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord AttrRequisitionFile;

[JsonProperty("Valid")]
public ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure AttrValid;

[JsonProperty("Binary")]
public byte[] AttrBinary;

[JsonProperty("BigUploadfileId")]
public long? AttrBigUploadfileId;

public RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure() { }

public RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure (ST_26b16bea631cbd94cf555acb5c7a4be3Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionContractFile = ConvertToRestWithoutDefaults(s.ssRequisitionContractFile, new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure, config);
AttrRequisitionFile = ConvertToRestWithoutDefaults(s.ssRequisitionFile, new EN_4cce425e15647f937e21de4e52849889EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure, config);
AttrValid = ConvertToRestWithoutDefaults(s.ssValid, new ST_b453bea0930035904f55a74692afd3a8Structure(), ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure.FromStructure, config);
AttrBinary = ConvertToRestWithoutDefaults(s.ssBinary);
AttrBigUploadfileId = ConvertToRestWithoutDefaults(s.ssBigUploadfileId, 0L);
  } else {
AttrRequisitionContractFile = ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure(s.ssRequisitionContractFile, config);
AttrRequisitionFile = ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure(s.ssRequisitionFile, config);
AttrValid = ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure.FromStructure(s.ssValid, config);
AttrBinary = s.ssBinary;
AttrBigUploadfileId = (long?) s.ssBigUploadfileId;
  }
}

public static ST_26b16bea631cbd94cf555acb5c7a4be3Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure obj) { 
  ST_26b16bea631cbd94cf555acb5c7a4be3Structure s = new ST_26b16bea631cbd94cf555acb5c7a4be3Structure();
  if(obj != null) {
  s.ssRequisitionContractFile = ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.ToStructure(obj.AttrRequisitionContractFile);
  s.ssRequisitionFile = ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.ToStructure(obj.AttrRequisitionFile);
  s.ssValid = ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure.ToStructure(obj.AttrValid);
  s.ssBinary = obj.AttrBinary == null ? new byte[] {} : obj.AttrBinary;
  s.ssBigUploadfileId = obj.AttrBigUploadfileId == null ? 0L : obj.AttrBigUploadfileId.Value;
  }
  return s;
}

public static Func<ST_26b16bea631cbd94cf555acb5c7a4be3Structure, ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_26b16bea631cbd94cf555acb5c7a4be3Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure FromStructure(ST_26b16bea631cbd94cf555acb5c7a4be3Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure(s, config);
}

}


