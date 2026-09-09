using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DropdownItemRecord
public class RESTRC_56805fdef6332e01f13c0f9217357dbc : AbstractRESTStructure<RC_56805fdef6332e01f13c0f9217357dbc> {
[JsonProperty("DropdownItem")]
public ssConectaProveedores.RestRecords.RESTST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure AttrDropdownItem;

public RESTRC_56805fdef6332e01f13c0f9217357dbc() { }

public RESTRC_56805fdef6332e01f13c0f9217357dbc (RC_56805fdef6332e01f13c0f9217357dbc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownItem = ConvertToRestWithoutDefaults(s.ssSTDropdownItem, new ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure(), ssConectaProveedores.RestRecords.RESTST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure.FromStructure, config);
  } else {
AttrDropdownItem = ssConectaProveedores.RestRecords.RESTST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure.FromStructure(s.ssSTDropdownItem, config);
  }
}

public static RC_56805fdef6332e01f13c0f9217357dbc ToStructure(ssConectaProveedores.RestRecords.RESTRC_56805fdef6332e01f13c0f9217357dbc obj) { 
  RC_56805fdef6332e01f13c0f9217357dbc s = new RC_56805fdef6332e01f13c0f9217357dbc();
  if(obj != null) {
  s.ssSTDropdownItem = ssConectaProveedores.RestRecords.RESTST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure.ToStructure(obj.AttrDropdownItem);
  }
  return s;
}

public static Func<RC_56805fdef6332e01f13c0f9217357dbc, ssConectaProveedores.RestRecords.RESTRC_56805fdef6332e01f13c0f9217357dbc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_56805fdef6332e01f13c0f9217357dbc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_56805fdef6332e01f13c0f9217357dbc FromStructure(RC_56805fdef6332e01f13c0f9217357dbc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_56805fdef6332e01f13c0f9217357dbc(s, config);
}

}


