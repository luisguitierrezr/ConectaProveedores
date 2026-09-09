using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// GetCountByRoleAndRegionIdRecord
public class JSONRC_78d280d051de27b530ad92d3c1147e6a : AbstractRESTStructure<RC_78d280d051de27b530ad92d3c1147e6a> {
[JsonProperty("GetCountByRoleAndRegionId")]
[JsonPropertyName("GetCountByRoleAndRegionId")]
public ssConectaProveedores.RestRecords.JSONST_03d295412275516fd72842ddfab4d69aStructure AttrGetCountByRoleAndRegionId;

public JSONRC_78d280d051de27b530ad92d3c1147e6a() { }

public JSONRC_78d280d051de27b530ad92d3c1147e6a (RC_78d280d051de27b530ad92d3c1147e6a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGetCountByRoleAndRegionId = ConvertToRestWithoutDefaults(s.ssSTGetCountByRoleAndRegionId, new ST_03d295412275516fd72842ddfab4d69aStructure(), ssConectaProveedores.RestRecords.JSONST_03d295412275516fd72842ddfab4d69aStructure.FromStructure, config);
  } else {
AttrGetCountByRoleAndRegionId = ssConectaProveedores.RestRecords.JSONST_03d295412275516fd72842ddfab4d69aStructure.FromStructure(s.ssSTGetCountByRoleAndRegionId, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_78d280d051de27b530ad92d3c1147e6a, RC_78d280d051de27b530ad92d3c1147e6a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_78d280d051de27b530ad92d3c1147e6a s) => ToStructure(s, config);
}
public static RC_78d280d051de27b530ad92d3c1147e6a ToStructure(ssConectaProveedores.RestRecords.JSONRC_78d280d051de27b530ad92d3c1147e6a obj, IBehaviorsConfiguration config) { 
  RC_78d280d051de27b530ad92d3c1147e6a s = new RC_78d280d051de27b530ad92d3c1147e6a();
  if(obj != null) {
  s.ssSTGetCountByRoleAndRegionId = ssConectaProveedores.RestRecords.JSONST_03d295412275516fd72842ddfab4d69aStructure.ToStructure(obj.AttrGetCountByRoleAndRegionId, config);
  }
  return s;
}

public static Func<RC_78d280d051de27b530ad92d3c1147e6a, ssConectaProveedores.RestRecords.JSONRC_78d280d051de27b530ad92d3c1147e6a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_78d280d051de27b530ad92d3c1147e6a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_78d280d051de27b530ad92d3c1147e6a FromStructure(RC_78d280d051de27b530ad92d3c1147e6a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_78d280d051de27b530ad92d3c1147e6a(s, config);
}

}


