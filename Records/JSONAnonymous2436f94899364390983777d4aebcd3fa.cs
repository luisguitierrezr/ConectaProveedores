using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserApplicationRoleTempByConceptRecord
public class JSONRC_0ac1b5c675d1742c0ea797802ee62592 : AbstractRESTStructure<RC_0ac1b5c675d1742c0ea797802ee62592> {
[JsonProperty("UserApplicationRoleTempByConcept")]
[JsonPropertyName("UserApplicationRoleTempByConcept")]
public ssConectaProveedores.RestRecords.JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord AttrUserApplicationRoleTempByConcept;

public JSONRC_0ac1b5c675d1742c0ea797802ee62592() { }

public JSONRC_0ac1b5c675d1742c0ea797802ee62592 (RC_0ac1b5c675d1742c0ea797802ee62592 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserApplicationRoleTempByConcept = ConvertToRestWithoutDefaults(s.ssENUserApplicationRoleTempByConcept, new EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord.FromStructure, config);
  } else {
AttrUserApplicationRoleTempByConcept = ssConectaProveedores.RestRecords.JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord.FromStructure(s.ssENUserApplicationRoleTempByConcept, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0ac1b5c675d1742c0ea797802ee62592, RC_0ac1b5c675d1742c0ea797802ee62592> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0ac1b5c675d1742c0ea797802ee62592 s) => ToStructure(s, config);
}
public static RC_0ac1b5c675d1742c0ea797802ee62592 ToStructure(ssConectaProveedores.RestRecords.JSONRC_0ac1b5c675d1742c0ea797802ee62592 obj, IBehaviorsConfiguration config) { 
  RC_0ac1b5c675d1742c0ea797802ee62592 s = new RC_0ac1b5c675d1742c0ea797802ee62592();
  if(obj != null) {
  s.ssENUserApplicationRoleTempByConcept = ssConectaProveedores.RestRecords.JSONEN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord.ToStructure(obj.AttrUserApplicationRoleTempByConcept, config);
  }
  return s;
}

public static Func<RC_0ac1b5c675d1742c0ea797802ee62592, ssConectaProveedores.RestRecords.JSONRC_0ac1b5c675d1742c0ea797802ee62592> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0ac1b5c675d1742c0ea797802ee62592 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0ac1b5c675d1742c0ea797802ee62592 FromStructure(RC_0ac1b5c675d1742c0ea797802ee62592 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0ac1b5c675d1742c0ea797802ee62592(s, config);
}

}


