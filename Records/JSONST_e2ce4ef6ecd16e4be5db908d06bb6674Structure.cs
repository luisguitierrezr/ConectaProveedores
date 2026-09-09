using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MinuteDocumentTypeUpdate
public class JSONST_e2ce4ef6ecd16e4be5db908d06bb6674Structure : AbstractRESTStructure<ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure> {
[JsonProperty("Key")]
[JsonPropertyName("Key")]
public int? AttrKey;

[JsonProperty("Value")]
[JsonPropertyName("Value")]
public string AttrValue;

[JsonProperty("FileName")]
[JsonPropertyName("FileName")]
public string AttrFileName;

[JsonProperty("Mandatory")]
[JsonPropertyName("Mandatory")]
public bool? AttrMandatory;

[JsonProperty("WithDocument")]
[JsonPropertyName("WithDocument")]
public bool? AttrWithDocument;

[JsonProperty("StorageId")]
[JsonPropertyName("StorageId")]
public long? AttrStorageId;

public JSONST_e2ce4ef6ecd16e4be5db908d06bb6674Structure() { }

public JSONST_e2ce4ef6ecd16e4be5db908d06bb6674Structure (ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrKey = ConvertToRestWithoutDefaults(s.ssKey, 0);
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, "");
AttrFileName = ConvertToRestWithoutDefaults(s.ssFileName, "");
AttrMandatory = ConvertToRestWithoutDefaults(s.ssMandatory, false);
AttrWithDocument = ConvertToRestWithoutDefaults(s.ssWithDocument, false);
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
  } else {
AttrKey = (int?) s.ssKey;
AttrValue = s.ssValue;
AttrFileName = s.ssFileName;
AttrMandatory = (bool?) s.ssMandatory;
AttrWithDocument = (bool?) s.ssWithDocument;
AttrStorageId = (long?) s.ssStorageId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_e2ce4ef6ecd16e4be5db908d06bb6674Structure, ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_e2ce4ef6ecd16e4be5db908d06bb6674Structure s) => ToStructure(s, config);
}
public static ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_e2ce4ef6ecd16e4be5db908d06bb6674Structure obj, IBehaviorsConfiguration config) { 
  ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure s = new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure();
  if(obj != null) {
  s.ssKey = obj.AttrKey == null ? 0 : obj.AttrKey.Value;
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  s.ssFileName = obj.AttrFileName == null ? "" : obj.AttrFileName;
  s.ssMandatory = obj.AttrMandatory == null ? false : obj.AttrMandatory.Value;
  s.ssWithDocument = obj.AttrWithDocument == null ? false : obj.AttrWithDocument.Value;
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  }
  return s;
}

public static Func<ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure, ssConectaProveedores.RestRecords.JSONST_e2ce4ef6ecd16e4be5db908d06bb6674Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_e2ce4ef6ecd16e4be5db908d06bb6674Structure FromStructure(ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(s, config);
}

}


