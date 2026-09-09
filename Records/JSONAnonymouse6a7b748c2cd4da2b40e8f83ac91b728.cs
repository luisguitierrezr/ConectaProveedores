using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserApplicationRoleTempRegionRecord
public class JSONRC_8bdff63e403435425d3da06733f0b39f : AbstractRESTStructure<RC_8bdff63e403435425d3da06733f0b39f> {
[JsonProperty("UserApplicationRoleTemp")]
[JsonPropertyName("UserApplicationRoleTemp")]
public ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord AttrUserApplicationRoleTemp;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_8bdff63e403435425d3da06733f0b39f() { }

public JSONRC_8bdff63e403435425d3da06733f0b39f (RC_8bdff63e403435425d3da06733f0b39f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserApplicationRoleTemp = ConvertToRestWithoutDefaults(s.ssENUserApplicationRoleTemp, new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrUserApplicationRoleTemp = ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure(s.ssENUserApplicationRoleTemp, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8bdff63e403435425d3da06733f0b39f, RC_8bdff63e403435425d3da06733f0b39f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8bdff63e403435425d3da06733f0b39f s) => ToStructure(s, config);
}
public static RC_8bdff63e403435425d3da06733f0b39f ToStructure(ssConectaProveedores.RestRecords.JSONRC_8bdff63e403435425d3da06733f0b39f obj, IBehaviorsConfiguration config) { 
  RC_8bdff63e403435425d3da06733f0b39f s = new RC_8bdff63e403435425d3da06733f0b39f();
  if(obj != null) {
  s.ssENUserApplicationRoleTemp = ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.ToStructure(obj.AttrUserApplicationRoleTemp, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_8bdff63e403435425d3da06733f0b39f, ssConectaProveedores.RestRecords.JSONRC_8bdff63e403435425d3da06733f0b39f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8bdff63e403435425d3da06733f0b39f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8bdff63e403435425d3da06733f0b39f FromStructure(RC_8bdff63e403435425d3da06733f0b39f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8bdff63e403435425d3da06733f0b39f(s, config);
}

}


