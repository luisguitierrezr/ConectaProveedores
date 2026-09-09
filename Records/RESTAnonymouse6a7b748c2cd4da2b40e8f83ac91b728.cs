using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserApplicationRoleTempRegionRecord
public class RESTRC_8bdff63e403435425d3da06733f0b39f : AbstractRESTStructure<RC_8bdff63e403435425d3da06733f0b39f> {
[JsonProperty("UserApplicationRoleTemp")]
public ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord AttrUserApplicationRoleTemp;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_8bdff63e403435425d3da06733f0b39f() { }

public RESTRC_8bdff63e403435425d3da06733f0b39f (RC_8bdff63e403435425d3da06733f0b39f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserApplicationRoleTemp = ConvertToRestWithoutDefaults(s.ssENUserApplicationRoleTemp, new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrUserApplicationRoleTemp = ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure(s.ssENUserApplicationRoleTemp, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_8bdff63e403435425d3da06733f0b39f ToStructure(ssConectaProveedores.RestRecords.RESTRC_8bdff63e403435425d3da06733f0b39f obj) { 
  RC_8bdff63e403435425d3da06733f0b39f s = new RC_8bdff63e403435425d3da06733f0b39f();
  if(obj != null) {
  s.ssENUserApplicationRoleTemp = ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.ToStructure(obj.AttrUserApplicationRoleTemp);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_8bdff63e403435425d3da06733f0b39f, ssConectaProveedores.RestRecords.RESTRC_8bdff63e403435425d3da06733f0b39f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8bdff63e403435425d3da06733f0b39f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8bdff63e403435425d3da06733f0b39f FromStructure(RC_8bdff63e403435425d3da06733f0b39f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8bdff63e403435425d3da06733f0b39f(s, config);
}

}


