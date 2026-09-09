using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RegionsDropdown
public class JSONST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure : AbstractRESTStructure<ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure> {
[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public long? AttrRegionId;

[JsonProperty("RegionCode")]
[JsonPropertyName("RegionCode")]
public string AttrRegionCode;

[JsonProperty("RegionName")]
[JsonPropertyName("RegionName")]
public string AttrRegionName;

public JSONST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure() { }

public JSONST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure (ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
AttrRegionCode = ConvertToRestWithoutDefaults(s.ssRegionCode, "");
AttrRegionName = ConvertToRestWithoutDefaults(s.ssRegionName, "");
  } else {
AttrRegionId = (long?) s.ssRegionId;
AttrRegionCode = s.ssRegionCode;
AttrRegionName = s.ssRegionName;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure, ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure s) => ToStructure(s, config);
}
public static ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure obj, IBehaviorsConfiguration config) { 
  ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure s = new ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure();
  if(obj != null) {
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  s.ssRegionCode = obj.AttrRegionCode == null ? "" : obj.AttrRegionCode;
  s.ssRegionName = obj.AttrRegionName == null ? "" : obj.AttrRegionName;
  }
  return s;
}

public static Func<ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure, ssConectaProveedores.RestRecords.JSONST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure FromStructure(ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure(s, config);
}

}


