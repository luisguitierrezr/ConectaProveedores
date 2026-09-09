using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ManualUserArea
public class RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord : AbstractRESTStructure<EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("ManualId")]
public long? AttrManualId;

[JsonProperty("UserAreaId")]
public int? AttrUserAreaId;

public RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord() { }

public RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord (EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord obj) { 
  EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord s = new EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssManualId = obj.AttrManualId == null ? 0L : obj.AttrManualId.Value;
  s.ssUserAreaId = obj.AttrUserAreaId == null ? 0 : obj.AttrUserAreaId.Value;
  }
  return s;
}

public static Func<EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord, ssConectaProveedores.RestRecords.RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord FromStructure(EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord(s, config);
}

}


