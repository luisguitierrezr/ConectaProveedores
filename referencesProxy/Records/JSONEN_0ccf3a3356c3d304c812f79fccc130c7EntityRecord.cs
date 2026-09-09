using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ProcessType
public class JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord : AbstractRESTStructure<EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Code")]
[JsonPropertyName("Code")]
public string AttrCode;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
[JsonPropertyName("Is_Active")]
public bool? AttrIs_Active;

public JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord() { }

public JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord (EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  } else {
AttrId = (long?) s.ssId;
AttrCode = s.ssCode;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord, EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord s) => ToStructure(s, config);
}
public static EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord s = new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord FromStructure(EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord(s, config);
}

}


