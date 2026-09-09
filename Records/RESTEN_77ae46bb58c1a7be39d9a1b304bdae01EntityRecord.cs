using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RoleConcept
public class RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord : AbstractRESTStructure<EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("ConceptId")]
public int? AttrConceptId;

[JsonProperty("EntraRoleId")]
public long? AttrEntraRoleId;

public RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord() { }

public RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord (EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrConceptId = ConvertToRestWithoutDefaults(s.ssConceptId, 0);
AttrEntraRoleId = ConvertToRestWithoutDefaults(s.ssEntraRoleId, 0L);
  } else {
AttrId = (long?) s.ssId;
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrConceptId = (int?) s.ssConceptId;
AttrEntraRoleId = (long?) s.ssEntraRoleId;
  }
}

public static EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord obj) { 
  EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord s = new EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssConceptId = obj.AttrConceptId == null ? 0 : obj.AttrConceptId.Value;
  s.ssEntraRoleId = obj.AttrEntraRoleId == null ? 0L : obj.AttrEntraRoleId.Value;
  }
  return s;
}

public static Func<EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord, ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord FromStructure(EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord(s, config);
}

}


