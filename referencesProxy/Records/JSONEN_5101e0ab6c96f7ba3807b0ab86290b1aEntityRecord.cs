using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ApplicationRole
public class JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord : AbstractRESTStructure<EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Code")]
[JsonPropertyName("Code")]
public string AttrCode;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

[JsonProperty("IsAreaUsuaria")]
[JsonPropertyName("IsAreaUsuaria")]
public bool? AttrIsAreaUsuaria;

[JsonProperty("IsAreaCxP")]
[JsonPropertyName("IsAreaCxP")]
public bool? AttrIsAreaCxP;

[JsonProperty("CanBulkApproveFolios")]
[JsonPropertyName("CanBulkApproveFolios")]
public bool? AttrCanBulkApproveFolios;

public JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord() { }

public JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, false);
AttrIsAreaUsuaria = ConvertToRestWithoutDefaults(s.ssIsAreaUsuaria, false);
AttrIsAreaCxP = ConvertToRestWithoutDefaults(s.ssIsAreaCxP, false);
AttrCanBulkApproveFolios = ConvertToRestWithoutDefaults(s.ssCanBulkApproveFolios, false);
  } else {
AttrId = (long?) s.ssId;
AttrCode = s.ssCode;
AttrName = s.ssName;
AttrIsActive = (bool?) s.ssIsActive;
AttrIsAreaUsuaria = (bool?) s.ssIsAreaUsuaria;
AttrIsAreaCxP = (bool?) s.ssIsAreaCxP;
AttrCanBulkApproveFolios = (bool?) s.ssCanBulkApproveFolios;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord, EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord s) => ToStructure(s, config);
}
public static EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord s = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssIsAreaUsuaria = obj.AttrIsAreaUsuaria == null ? false : obj.AttrIsAreaUsuaria.Value;
  s.ssIsAreaCxP = obj.AttrIsAreaCxP == null ? false : obj.AttrIsAreaCxP.Value;
  s.ssCanBulkApproveFolios = obj.AttrCanBulkApproveFolios == null ? false : obj.AttrCanBulkApproveFolios.Value;
  }
  return s;
}

public static Func<EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord FromStructure(EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(s, config);
}

}


