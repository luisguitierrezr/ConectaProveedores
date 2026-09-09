using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// GetCountByRoleAndRegionId
public class RESTST_03d295412275516fd72842ddfab4d69aStructure : AbstractRESTStructure<ST_03d295412275516fd72842ddfab4d69aStructure> {
[JsonProperty("Count")]
public int? AttrCount;

[JsonProperty("ApplicationRoleID")]
public long? AttrApplicationRoleID;

[JsonProperty("RegionId")]
public long? AttrRegionId;

public RESTST_03d295412275516fd72842ddfab4d69aStructure() { }

public RESTST_03d295412275516fd72842ddfab4d69aStructure (ST_03d295412275516fd72842ddfab4d69aStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCount = ConvertToRestWithoutDefaults(s.ssCount, 0);
AttrApplicationRoleID = ConvertToRestWithoutDefaults(s.ssApplicationRoleID, 0L);
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
  } else {
AttrCount = (int?) s.ssCount;
AttrApplicationRoleID = (long?) s.ssApplicationRoleID;
AttrRegionId = (long?) s.ssRegionId;
  }
}

public static ST_03d295412275516fd72842ddfab4d69aStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_03d295412275516fd72842ddfab4d69aStructure obj) { 
  ST_03d295412275516fd72842ddfab4d69aStructure s = new ST_03d295412275516fd72842ddfab4d69aStructure();
  if(obj != null) {
  s.ssCount = obj.AttrCount == null ? 0 : obj.AttrCount.Value;
  s.ssApplicationRoleID = obj.AttrApplicationRoleID == null ? 0L : obj.AttrApplicationRoleID.Value;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  }
  return s;
}

public static Func<ST_03d295412275516fd72842ddfab4d69aStructure, ssConectaProveedores.RestRecords.RESTST_03d295412275516fd72842ddfab4d69aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_03d295412275516fd72842ddfab4d69aStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_03d295412275516fd72842ddfab4d69aStructure FromStructure(ST_03d295412275516fd72842ddfab4d69aStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_03d295412275516fd72842ddfab4d69aStructure(s, config);
}

}


