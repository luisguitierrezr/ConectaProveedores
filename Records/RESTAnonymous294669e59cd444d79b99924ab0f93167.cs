using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// GetCountByRoleAndRegionIdRecord
public class RESTRC_78d280d051de27b530ad92d3c1147e6a : AbstractRESTStructure<RC_78d280d051de27b530ad92d3c1147e6a> {
[JsonProperty("GetCountByRoleAndRegionId")]
public ssConectaProveedores.RestRecords.RESTST_03d295412275516fd72842ddfab4d69aStructure AttrGetCountByRoleAndRegionId;

public RESTRC_78d280d051de27b530ad92d3c1147e6a() { }

public RESTRC_78d280d051de27b530ad92d3c1147e6a (RC_78d280d051de27b530ad92d3c1147e6a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGetCountByRoleAndRegionId = ConvertToRestWithoutDefaults(s.ssSTGetCountByRoleAndRegionId, new ST_03d295412275516fd72842ddfab4d69aStructure(), ssConectaProveedores.RestRecords.RESTST_03d295412275516fd72842ddfab4d69aStructure.FromStructure, config);
  } else {
AttrGetCountByRoleAndRegionId = ssConectaProveedores.RestRecords.RESTST_03d295412275516fd72842ddfab4d69aStructure.FromStructure(s.ssSTGetCountByRoleAndRegionId, config);
  }
}

public static RC_78d280d051de27b530ad92d3c1147e6a ToStructure(ssConectaProveedores.RestRecords.RESTRC_78d280d051de27b530ad92d3c1147e6a obj) { 
  RC_78d280d051de27b530ad92d3c1147e6a s = new RC_78d280d051de27b530ad92d3c1147e6a();
  if(obj != null) {
  s.ssSTGetCountByRoleAndRegionId = ssConectaProveedores.RestRecords.RESTST_03d295412275516fd72842ddfab4d69aStructure.ToStructure(obj.AttrGetCountByRoleAndRegionId);
  }
  return s;
}

public static Func<RC_78d280d051de27b530ad92d3c1147e6a, ssConectaProveedores.RestRecords.RESTRC_78d280d051de27b530ad92d3c1147e6a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_78d280d051de27b530ad92d3c1147e6a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_78d280d051de27b530ad92d3c1147e6a FromStructure(RC_78d280d051de27b530ad92d3c1147e6a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_78d280d051de27b530ad92d3c1147e6a(s, config);
}

}


