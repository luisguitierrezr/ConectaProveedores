using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// UserApplicationRoleTempByConcept
public class JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord : AbstractRESTStructure<EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("UserApplicationRoleTempId")]
[JsonPropertyName("UserApplicationRoleTempId")]
public long? AttrUserApplicationRoleTempId;

[JsonProperty("ApplicationRoleId")]
[JsonPropertyName("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("ConceptId")]
[JsonPropertyName("ConceptId")]
public int? AttrConceptId;

public JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord() { }

public JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord (EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrUserApplicationRoleTempId = ConvertToRestWithoutDefaults(s.ssUserApplicationRoleTempId, 0L);
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrConceptId = ConvertToRestWithoutDefaults(s.ssConceptId, 0);
  } else {
AttrId = (long?) s.ssId;
AttrUserApplicationRoleTempId = (long?) s.ssUserApplicationRoleTempId;
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrConceptId = (int?) s.ssConceptId;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord, EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord s) => ToStructure(s, config);
}
public static EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord s = new EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssUserApplicationRoleTempId = obj.AttrUserApplicationRoleTempId == null ? 0L : obj.AttrUserApplicationRoleTempId.Value;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssConceptId = obj.AttrConceptId == null ? 0 : obj.AttrConceptId.Value;
  }
  return s;
}

public static Func<EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord FromStructure(EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord(s, config);
}

}


