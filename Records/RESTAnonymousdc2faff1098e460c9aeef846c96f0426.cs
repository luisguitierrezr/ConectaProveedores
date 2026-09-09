using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// GetGroupsResponseRecord
public class RESTRC_b7a8ca64723e51be7fabec3ceba0b1cb : AbstractRESTStructure<RC_b7a8ca64723e51be7fabec3ceba0b1cb> {
[JsonProperty("GetGroupsResponse")]
public ssConectaProveedores.RestRecords.RESTST_d3e1050921d01f07c3bdfba3f3e6e343Structure AttrGetGroupsResponse;

public RESTRC_b7a8ca64723e51be7fabec3ceba0b1cb() { }

public RESTRC_b7a8ca64723e51be7fabec3ceba0b1cb (RC_b7a8ca64723e51be7fabec3ceba0b1cb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGetGroupsResponse = ConvertToRestWithoutDefaults(s.ssSTGetGroupsResponse, new ST_d3e1050921d01f07c3bdfba3f3e6e343Structure(), ssConectaProveedores.RestRecords.RESTST_d3e1050921d01f07c3bdfba3f3e6e343Structure.FromStructure, config);
  } else {
AttrGetGroupsResponse = ssConectaProveedores.RestRecords.RESTST_d3e1050921d01f07c3bdfba3f3e6e343Structure.FromStructure(s.ssSTGetGroupsResponse, config);
  }
}

public static RC_b7a8ca64723e51be7fabec3ceba0b1cb ToStructure(ssConectaProveedores.RestRecords.RESTRC_b7a8ca64723e51be7fabec3ceba0b1cb obj) { 
  RC_b7a8ca64723e51be7fabec3ceba0b1cb s = new RC_b7a8ca64723e51be7fabec3ceba0b1cb();
  if(obj != null) {
  s.ssSTGetGroupsResponse = ssConectaProveedores.RestRecords.RESTST_d3e1050921d01f07c3bdfba3f3e6e343Structure.ToStructure(obj.AttrGetGroupsResponse);
  }
  return s;
}

public static Func<RC_b7a8ca64723e51be7fabec3ceba0b1cb, ssConectaProveedores.RestRecords.RESTRC_b7a8ca64723e51be7fabec3ceba0b1cb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b7a8ca64723e51be7fabec3ceba0b1cb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b7a8ca64723e51be7fabec3ceba0b1cb FromStructure(RC_b7a8ca64723e51be7fabec3ceba0b1cb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b7a8ca64723e51be7fabec3ceba0b1cb(s, config);
}

}


