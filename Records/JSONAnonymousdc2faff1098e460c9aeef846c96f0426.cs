using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// GetGroupsResponseRecord
public class JSONRC_b7a8ca64723e51be7fabec3ceba0b1cb : AbstractRESTStructure<RC_b7a8ca64723e51be7fabec3ceba0b1cb> {
[JsonProperty("GetGroupsResponse")]
[JsonPropertyName("GetGroupsResponse")]
public ssConectaProveedores.RestRecords.JSONST_d3e1050921d01f07c3bdfba3f3e6e343Structure AttrGetGroupsResponse;

public JSONRC_b7a8ca64723e51be7fabec3ceba0b1cb() { }

public JSONRC_b7a8ca64723e51be7fabec3ceba0b1cb (RC_b7a8ca64723e51be7fabec3ceba0b1cb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGetGroupsResponse = ConvertToRestWithoutDefaults(s.ssSTGetGroupsResponse, new ST_d3e1050921d01f07c3bdfba3f3e6e343Structure(), ssConectaProveedores.RestRecords.JSONST_d3e1050921d01f07c3bdfba3f3e6e343Structure.FromStructure, config);
  } else {
AttrGetGroupsResponse = ssConectaProveedores.RestRecords.JSONST_d3e1050921d01f07c3bdfba3f3e6e343Structure.FromStructure(s.ssSTGetGroupsResponse, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b7a8ca64723e51be7fabec3ceba0b1cb, RC_b7a8ca64723e51be7fabec3ceba0b1cb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b7a8ca64723e51be7fabec3ceba0b1cb s) => ToStructure(s, config);
}
public static RC_b7a8ca64723e51be7fabec3ceba0b1cb ToStructure(ssConectaProveedores.RestRecords.JSONRC_b7a8ca64723e51be7fabec3ceba0b1cb obj, IBehaviorsConfiguration config) { 
  RC_b7a8ca64723e51be7fabec3ceba0b1cb s = new RC_b7a8ca64723e51be7fabec3ceba0b1cb();
  if(obj != null) {
  s.ssSTGetGroupsResponse = ssConectaProveedores.RestRecords.JSONST_d3e1050921d01f07c3bdfba3f3e6e343Structure.ToStructure(obj.AttrGetGroupsResponse, config);
  }
  return s;
}

public static Func<RC_b7a8ca64723e51be7fabec3ceba0b1cb, ssConectaProveedores.RestRecords.JSONRC_b7a8ca64723e51be7fabec3ceba0b1cb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b7a8ca64723e51be7fabec3ceba0b1cb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b7a8ca64723e51be7fabec3ceba0b1cb FromStructure(RC_b7a8ca64723e51be7fabec3ceba0b1cb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b7a8ca64723e51be7fabec3ceba0b1cb(s, config);
}

}


