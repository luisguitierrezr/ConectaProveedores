using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationFiles
public class JSONST_27be19a2068bdbf4844f837df703a71bStructure : AbstractRESTStructure<ST_27be19a2068bdbf4844f837df703a71bStructure> {
[JsonProperty("FileName")]
[JsonPropertyName("FileName")]
public string AttrFileName;

[JsonProperty("StorageId")]
[JsonPropertyName("StorageId")]
public long? AttrStorageId;

[JsonProperty("Select")]
[JsonPropertyName("Select")]
public bool? AttrSelect;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("Size")]
[JsonPropertyName("Size")]
public long? AttrSize;

public JSONST_27be19a2068bdbf4844f837df703a71bStructure() { }

public JSONST_27be19a2068bdbf4844f837df703a71bStructure (ST_27be19a2068bdbf4844f837df703a71bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFileName = ConvertToRestWithoutDefaults(s.ssFileName, "");
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
AttrSelect = ConvertToRestWithoutDefaults(s.ssSelect, false);
AttrCreatedOn = ConvertDateToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrSize = ConvertToRestWithoutDefaults(s.ssSize, 0L);
  } else {
AttrFileName = s.ssFileName;
AttrStorageId = (long?) s.ssStorageId;
AttrSelect = (bool?) s.ssSelect;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssCreatedOn);
AttrSize = (long?) s.ssSize;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_27be19a2068bdbf4844f837df703a71bStructure, ST_27be19a2068bdbf4844f837df703a71bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_27be19a2068bdbf4844f837df703a71bStructure s) => ToStructure(s, config);
}
public static ST_27be19a2068bdbf4844f837df703a71bStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_27be19a2068bdbf4844f837df703a71bStructure obj, IBehaviorsConfiguration config) { 
  ST_27be19a2068bdbf4844f837df703a71bStructure s = new ST_27be19a2068bdbf4844f837df703a71bStructure();
  if(obj != null) {
  s.ssFileName = obj.AttrFileName == null ? "" : obj.AttrFileName;
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  s.ssSelect = obj.AttrSelect == null ? false : obj.AttrSelect.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrCreatedOn);
  s.ssSize = obj.AttrSize == null ? 0L : obj.AttrSize.Value;
  }
  return s;
}

public static Func<ST_27be19a2068bdbf4844f837df703a71bStructure, ssConectaProveedores.RestRecords.JSONST_27be19a2068bdbf4844f837df703a71bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_27be19a2068bdbf4844f837df703a71bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_27be19a2068bdbf4844f837df703a71bStructure FromStructure(ST_27be19a2068bdbf4844f837df703a71bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_27be19a2068bdbf4844f837df703a71bStructure(s, config);
}

}


