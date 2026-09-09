using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RegionsDropdownRecord
public class JSONRC_961fb69f34436852965350a75ed3c8b8 : AbstractRESTStructure<RC_961fb69f34436852965350a75ed3c8b8> {
[JsonProperty("RegionsDropdown")]
[JsonPropertyName("RegionsDropdown")]
public ssConectaProveedores.RestRecords.JSONST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure AttrRegionsDropdown;

public JSONRC_961fb69f34436852965350a75ed3c8b8() { }

public JSONRC_961fb69f34436852965350a75ed3c8b8 (RC_961fb69f34436852965350a75ed3c8b8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRegionsDropdown = ConvertToRestWithoutDefaults(s.ssSTRegionsDropdown, new ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure(), ssConectaProveedores.RestRecords.JSONST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure.FromStructure, config);
  } else {
AttrRegionsDropdown = ssConectaProveedores.RestRecords.JSONST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure.FromStructure(s.ssSTRegionsDropdown, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_961fb69f34436852965350a75ed3c8b8, RC_961fb69f34436852965350a75ed3c8b8> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_961fb69f34436852965350a75ed3c8b8 s) => ToStructure(s, config);
}
public static RC_961fb69f34436852965350a75ed3c8b8 ToStructure(ssConectaProveedores.RestRecords.JSONRC_961fb69f34436852965350a75ed3c8b8 obj, IBehaviorsConfiguration config) { 
  RC_961fb69f34436852965350a75ed3c8b8 s = new RC_961fb69f34436852965350a75ed3c8b8();
  if(obj != null) {
  s.ssSTRegionsDropdown = ssConectaProveedores.RestRecords.JSONST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure.ToStructure(obj.AttrRegionsDropdown, config);
  }
  return s;
}

public static Func<RC_961fb69f34436852965350a75ed3c8b8, ssConectaProveedores.RestRecords.JSONRC_961fb69f34436852965350a75ed3c8b8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_961fb69f34436852965350a75ed3c8b8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_961fb69f34436852965350a75ed3c8b8 FromStructure(RC_961fb69f34436852965350a75ed3c8b8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_961fb69f34436852965350a75ed3c8b8(s, config);
}

}


