using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntraRole
public class RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord : AbstractRESTStructure<EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("RoleName")]
public string AttrRoleName;

[JsonProperty("IsAreaUsuaria")]
public bool? AttrIsAreaUsuaria;

[JsonProperty("IsAreaCxP")]
public bool? AttrIsAreaCxP;

[JsonProperty("IsSolicitante")]
public bool? AttrIsSolicitante;

[JsonProperty("IsAssistant")]
public bool? AttrIsAssistant;

public RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord() { }

public RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRoleName = ConvertToRestWithoutDefaults(s.ssRoleName, "");
AttrIsAreaUsuaria = ConvertToRestWithoutDefaults(s.ssIsAreaUsuaria, false);
AttrIsAreaCxP = ConvertToRestWithoutDefaults(s.ssIsAreaCxP, false);
AttrIsSolicitante = ConvertToRestWithoutDefaults(s.ssIsSolicitante, false);
AttrIsAssistant = ConvertToRestWithoutDefaults(s.ssIsAssistant, false);
  } else {
AttrId = (long?) s.ssId;
AttrRoleName = s.ssRoleName;
AttrIsAreaUsuaria = (bool?) s.ssIsAreaUsuaria;
AttrIsAreaCxP = (bool?) s.ssIsAreaCxP;
AttrIsSolicitante = (bool?) s.ssIsSolicitante;
AttrIsAssistant = (bool?) s.ssIsAssistant;
  }
}

public static EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord obj) { 
  EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord s = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRoleName = obj.AttrRoleName == null ? "" : obj.AttrRoleName;
  s.ssIsAreaUsuaria = obj.AttrIsAreaUsuaria == null ? false : obj.AttrIsAreaUsuaria.Value;
  s.ssIsAreaCxP = obj.AttrIsAreaCxP == null ? false : obj.AttrIsAreaCxP.Value;
  s.ssIsSolicitante = obj.AttrIsSolicitante == null ? false : obj.AttrIsSolicitante.Value;
  s.ssIsAssistant = obj.AttrIsAssistant == null ? false : obj.AttrIsAssistant.Value;
  }
  return s;
}

public static Func<EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord, ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord FromStructure(EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(s, config);
}

}


