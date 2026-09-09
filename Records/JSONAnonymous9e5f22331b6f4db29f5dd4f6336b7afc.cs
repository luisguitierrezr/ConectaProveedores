using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AppRolesListTextTelcelDirectionsListTextIsCorporativoCxPCorporativoRegionIdRecord
public class JSONRC_4eba0035378aebca97affd4e1528379d : AbstractRESTStructure<RC_4eba0035378aebca97affd4e1528379d> {
[JsonProperty("AppRolesListText")]
[JsonPropertyName("AppRolesListText")]
public string AttrAppRolesListText;

[JsonProperty("TelcelDirectionsListText")]
[JsonPropertyName("TelcelDirectionsListText")]
public string AttrTelcelDirectionsListText;

[JsonProperty("IsCorporativoCxP")]
[JsonPropertyName("IsCorporativoCxP")]
public bool? AttrIsCorporativoCxP;

[JsonProperty("CorporativoRegionId")]
[JsonPropertyName("CorporativoRegionId")]
public long? AttrCorporativoRegionId;

public JSONRC_4eba0035378aebca97affd4e1528379d() { }

public JSONRC_4eba0035378aebca97affd4e1528379d (RC_4eba0035378aebca97affd4e1528379d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAppRolesListText = ConvertToRestWithoutDefaults(s.ssAppRolesListText, "");
AttrTelcelDirectionsListText = ConvertToRestWithoutDefaults(s.ssTelcelDirectionsListText, "");
AttrIsCorporativoCxP = ConvertToRestWithoutDefaults(s.ssIsCorporativoCxP, false);
AttrCorporativoRegionId = ConvertToRestWithoutDefaults(s.ssCorporativoRegionId, 0L);
  } else {
AttrAppRolesListText = s.ssAppRolesListText;
AttrTelcelDirectionsListText = s.ssTelcelDirectionsListText;
AttrIsCorporativoCxP = (bool?) s.ssIsCorporativoCxP;
AttrCorporativoRegionId = (long?) s.ssCorporativoRegionId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_4eba0035378aebca97affd4e1528379d, RC_4eba0035378aebca97affd4e1528379d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_4eba0035378aebca97affd4e1528379d s) => ToStructure(s, config);
}
public static RC_4eba0035378aebca97affd4e1528379d ToStructure(ssConectaProveedores.RestRecords.JSONRC_4eba0035378aebca97affd4e1528379d obj, IBehaviorsConfiguration config) { 
  RC_4eba0035378aebca97affd4e1528379d s = new RC_4eba0035378aebca97affd4e1528379d();
  if(obj != null) {
  s.ssAppRolesListText = obj.AttrAppRolesListText == null ? "" : obj.AttrAppRolesListText;
  s.ssTelcelDirectionsListText = obj.AttrTelcelDirectionsListText == null ? "" : obj.AttrTelcelDirectionsListText;
  s.ssIsCorporativoCxP = obj.AttrIsCorporativoCxP == null ? false : obj.AttrIsCorporativoCxP.Value;
  s.ssCorporativoRegionId = obj.AttrCorporativoRegionId == null ? 0L : obj.AttrCorporativoRegionId.Value;
  }
  return s;
}

public static Func<RC_4eba0035378aebca97affd4e1528379d, ssConectaProveedores.RestRecords.JSONRC_4eba0035378aebca97affd4e1528379d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4eba0035378aebca97affd4e1528379d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_4eba0035378aebca97affd4e1528379d FromStructure(RC_4eba0035378aebca97affd4e1528379d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_4eba0035378aebca97affd4e1528379d(s, config);
}

}


