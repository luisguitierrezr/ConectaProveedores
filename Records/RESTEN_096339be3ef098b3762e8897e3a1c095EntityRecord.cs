using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderFile
public class RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord : AbstractRESTStructure<EN_096339be3ef098b3762e8897e3a1c095EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Filename")]
public string AttrFilename;

[JsonProperty("VENDOR")]
public string AttrVENDOR;

[JsonProperty("DOC_TYPE")]
public string AttrDOC_TYPE;

[JsonProperty("SAP_OBJECT")]
public string AttrSAP_OBJECT;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("StorageId")]
public long? AttrStorageId;

public RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord() { }

public RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord (EN_096339be3ef098b3762e8897e3a1c095EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrVENDOR = ConvertToRestWithoutDefaults(s.ssVENDOR, "");
AttrDOC_TYPE = ConvertToRestWithoutDefaults(s.ssDOC_TYPE, "");
AttrSAP_OBJECT = ConvertToRestWithoutDefaults(s.ssSAP_OBJECT, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
  } else {
AttrId = (long?) s.ssId;
AttrFilename = s.ssFilename;
AttrVENDOR = s.ssVENDOR;
AttrDOC_TYPE = s.ssDOC_TYPE;
AttrSAP_OBJECT = s.ssSAP_OBJECT;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrStorageId = (long?) s.ssStorageId;
  }
}

public static EN_096339be3ef098b3762e8897e3a1c095EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord obj) { 
  EN_096339be3ef098b3762e8897e3a1c095EntityRecord s = new EN_096339be3ef098b3762e8897e3a1c095EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssVENDOR = obj.AttrVENDOR == null ? "" : obj.AttrVENDOR;
  s.ssDOC_TYPE = obj.AttrDOC_TYPE == null ? "" : obj.AttrDOC_TYPE;
  s.ssSAP_OBJECT = obj.AttrSAP_OBJECT == null ? "" : obj.AttrSAP_OBJECT;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  }
  return s;
}

public static Func<EN_096339be3ef098b3762e8897e3a1c095EntityRecord, ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_096339be3ef098b3762e8897e3a1c095EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord FromStructure(EN_096339be3ef098b3762e8897e3a1c095EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord(s, config);
}

}


