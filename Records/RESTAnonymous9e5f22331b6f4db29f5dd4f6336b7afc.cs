using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AppRolesListTextTelcelDirectionsListTextIsCorporativoCxPCorporativoRegionIdRecord
public class RESTRC_4eba0035378aebca97affd4e1528379d : AbstractRESTStructure<RC_4eba0035378aebca97affd4e1528379d> {
[JsonProperty("AppRolesListText")]
public string AttrAppRolesListText;

[JsonProperty("TelcelDirectionsListText")]
public string AttrTelcelDirectionsListText;

[JsonProperty("IsCorporativoCxP")]
public bool? AttrIsCorporativoCxP;

[JsonProperty("CorporativoRegionId")]
public long? AttrCorporativoRegionId;

public RESTRC_4eba0035378aebca97affd4e1528379d() { }

public RESTRC_4eba0035378aebca97affd4e1528379d (RC_4eba0035378aebca97affd4e1528379d s, IBehaviorsConfiguration config) {
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

public static RC_4eba0035378aebca97affd4e1528379d ToStructure(ssConectaProveedores.RestRecords.RESTRC_4eba0035378aebca97affd4e1528379d obj) { 
  RC_4eba0035378aebca97affd4e1528379d s = new RC_4eba0035378aebca97affd4e1528379d();
  if(obj != null) {
  s.ssAppRolesListText = obj.AttrAppRolesListText == null ? "" : obj.AttrAppRolesListText;
  s.ssTelcelDirectionsListText = obj.AttrTelcelDirectionsListText == null ? "" : obj.AttrTelcelDirectionsListText;
  s.ssIsCorporativoCxP = obj.AttrIsCorporativoCxP == null ? false : obj.AttrIsCorporativoCxP.Value;
  s.ssCorporativoRegionId = obj.AttrCorporativoRegionId == null ? 0L : obj.AttrCorporativoRegionId.Value;
  }
  return s;
}

public static Func<RC_4eba0035378aebca97affd4e1528379d, ssConectaProveedores.RestRecords.RESTRC_4eba0035378aebca97affd4e1528379d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4eba0035378aebca97affd4e1528379d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_4eba0035378aebca97affd4e1528379d FromStructure(RC_4eba0035378aebca97affd4e1528379d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_4eba0035378aebca97affd4e1528379d(s, config);
}

}


