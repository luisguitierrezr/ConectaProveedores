using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SpecialWorkflowUploadPuestos
public class JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord : AbstractRESTStructure<EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("SpecialWorkflowId")]
[JsonPropertyName("SpecialWorkflowId")]
public long? AttrSpecialWorkflowId;

[JsonProperty("EntraRoleId")]
[JsonPropertyName("EntraRoleId")]
public long? AttrEntraRoleId;

public JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord() { }

public JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord (EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrSpecialWorkflowId = ConvertToRestWithoutDefaults(s.ssSpecialWorkflowId, 0L);
AttrEntraRoleId = ConvertToRestWithoutDefaults(s.ssEntraRoleId, 0L);
  } else {
AttrId = (long?) s.ssId;
AttrSpecialWorkflowId = (long?) s.ssSpecialWorkflowId;
AttrEntraRoleId = (long?) s.ssEntraRoleId;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord, EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord s) => ToStructure(s, config);
}
public static EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord s = new EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssSpecialWorkflowId = obj.AttrSpecialWorkflowId == null ? 0L : obj.AttrSpecialWorkflowId.Value;
  s.ssEntraRoleId = obj.AttrEntraRoleId == null ? 0L : obj.AttrEntraRoleId.Value;
  }
  return s;
}

public static Func<EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord FromStructure(EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord(s, config);
}

}


