using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DropdownItemRecord
public class JSONRC_56805fdef6332e01f13c0f9217357dbc : AbstractRESTStructure<RC_56805fdef6332e01f13c0f9217357dbc> {
[JsonProperty("DropdownItem")]
[JsonPropertyName("DropdownItem")]
public ssConectaProveedores.RestRecords.JSONST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure AttrDropdownItem;

public JSONRC_56805fdef6332e01f13c0f9217357dbc() { }

public JSONRC_56805fdef6332e01f13c0f9217357dbc (RC_56805fdef6332e01f13c0f9217357dbc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownItem = ConvertToRestWithoutDefaults(s.ssSTDropdownItem, new ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure(), ssConectaProveedores.RestRecords.JSONST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure.FromStructure, config);
  } else {
AttrDropdownItem = ssConectaProveedores.RestRecords.JSONST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure.FromStructure(s.ssSTDropdownItem, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_56805fdef6332e01f13c0f9217357dbc, RC_56805fdef6332e01f13c0f9217357dbc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_56805fdef6332e01f13c0f9217357dbc s) => ToStructure(s, config);
}
public static RC_56805fdef6332e01f13c0f9217357dbc ToStructure(ssConectaProveedores.RestRecords.JSONRC_56805fdef6332e01f13c0f9217357dbc obj, IBehaviorsConfiguration config) { 
  RC_56805fdef6332e01f13c0f9217357dbc s = new RC_56805fdef6332e01f13c0f9217357dbc();
  if(obj != null) {
  s.ssSTDropdownItem = ssConectaProveedores.RestRecords.JSONST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure.ToStructure(obj.AttrDropdownItem, config);
  }
  return s;
}

public static Func<RC_56805fdef6332e01f13c0f9217357dbc, ssConectaProveedores.RestRecords.JSONRC_56805fdef6332e01f13c0f9217357dbc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_56805fdef6332e01f13c0f9217357dbc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_56805fdef6332e01f13c0f9217357dbc FromStructure(RC_56805fdef6332e01f13c0f9217357dbc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_56805fdef6332e01f13c0f9217357dbc(s, config);
}

}


