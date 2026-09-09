using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicePolizaStorage
public class JSONEN_c914a6fdb165c9751808adf2e01e2226EntityRecord : AbstractRESTStructure<EN_c914a6fdb165c9751808adf2e01e2226EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("PolizaFlowId")]
[JsonPropertyName("PolizaFlowId")]
public long? AttrPolizaFlowId;

[JsonProperty("StorageId")]
[JsonPropertyName("StorageId")]
public long? AttrStorageId;

public JSONEN_c914a6fdb165c9751808adf2e01e2226EntityRecord() { }

public JSONEN_c914a6fdb165c9751808adf2e01e2226EntityRecord (EN_c914a6fdb165c9751808adf2e01e2226EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrPolizaFlowId = ConvertToRestWithoutDefaults(s.ssPolizaFlowId, 0L);
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
  } else {
AttrId = (long?) s.ssId;
AttrPolizaFlowId = (long?) s.ssPolizaFlowId;
AttrStorageId = (long?) s.ssStorageId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_c914a6fdb165c9751808adf2e01e2226EntityRecord, EN_c914a6fdb165c9751808adf2e01e2226EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_c914a6fdb165c9751808adf2e01e2226EntityRecord s) => ToStructure(s, config);
}
public static EN_c914a6fdb165c9751808adf2e01e2226EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_c914a6fdb165c9751808adf2e01e2226EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_c914a6fdb165c9751808adf2e01e2226EntityRecord s = new EN_c914a6fdb165c9751808adf2e01e2226EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssPolizaFlowId = obj.AttrPolizaFlowId == null ? 0L : obj.AttrPolizaFlowId.Value;
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  }
  return s;
}

public static Func<EN_c914a6fdb165c9751808adf2e01e2226EntityRecord, ssConectaProveedores.RestRecords.JSONEN_c914a6fdb165c9751808adf2e01e2226EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c914a6fdb165c9751808adf2e01e2226EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_c914a6fdb165c9751808adf2e01e2226EntityRecord FromStructure(EN_c914a6fdb165c9751808adf2e01e2226EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_c914a6fdb165c9751808adf2e01e2226EntityRecord(s, config);
}

}


