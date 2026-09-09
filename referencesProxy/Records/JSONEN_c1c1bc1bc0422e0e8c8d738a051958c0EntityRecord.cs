using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ManualUserArea
public class JSONEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord : AbstractRESTStructure<EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("ManualId")]
[JsonPropertyName("ManualId")]
public long? AttrManualId;

[JsonProperty("UserAreaId")]
[JsonPropertyName("UserAreaId")]
public int? AttrUserAreaId;

public JSONEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord() { }

public JSONEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord (EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrManualId = ConvertToRestWithoutDefaults(s.ssManualId, 0L);
AttrUserAreaId = ConvertToRestWithoutDefaults(s.ssUserAreaId, 0);
  } else {
AttrId = (long?) s.ssId;
AttrManualId = (long?) s.ssManualId;
AttrUserAreaId = (int?) s.ssUserAreaId;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord, EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord s) => ToStructure(s, config);
}
public static EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord s = new EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssManualId = obj.AttrManualId == null ? 0L : obj.AttrManualId.Value;
  s.ssUserAreaId = obj.AttrUserAreaId == null ? 0 : obj.AttrUserAreaId.Value;
  }
  return s;
}

public static Func<EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord FromStructure(EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord(s, config);
}

}


