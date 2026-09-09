using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// HomepageKPIRecord
public class JSONRC_073e413c5402df3d82c2d65d0628594a : AbstractRESTStructure<RC_073e413c5402df3d82c2d65d0628594a> {
[JsonProperty("HomepageKPI")]
[JsonPropertyName("HomepageKPI")]
public ssConectaProveedores.RestRecords.JSONST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure AttrHomepageKPI;

public JSONRC_073e413c5402df3d82c2d65d0628594a() { }

public JSONRC_073e413c5402df3d82c2d65d0628594a (RC_073e413c5402df3d82c2d65d0628594a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHomepageKPI = ConvertToRestWithoutDefaults(s.ssSTHomepageKPI, new ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure(), ssConectaProveedores.RestRecords.JSONST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure.FromStructure, config);
  } else {
AttrHomepageKPI = ssConectaProveedores.RestRecords.JSONST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure.FromStructure(s.ssSTHomepageKPI, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_073e413c5402df3d82c2d65d0628594a, RC_073e413c5402df3d82c2d65d0628594a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_073e413c5402df3d82c2d65d0628594a s) => ToStructure(s, config);
}
public static RC_073e413c5402df3d82c2d65d0628594a ToStructure(ssConectaProveedores.RestRecords.JSONRC_073e413c5402df3d82c2d65d0628594a obj, IBehaviorsConfiguration config) { 
  RC_073e413c5402df3d82c2d65d0628594a s = new RC_073e413c5402df3d82c2d65d0628594a();
  if(obj != null) {
  s.ssSTHomepageKPI = ssConectaProveedores.RestRecords.JSONST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure.ToStructure(obj.AttrHomepageKPI, config);
  }
  return s;
}

public static Func<RC_073e413c5402df3d82c2d65d0628594a, ssConectaProveedores.RestRecords.JSONRC_073e413c5402df3d82c2d65d0628594a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_073e413c5402df3d82c2d65d0628594a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_073e413c5402df3d82c2d65d0628594a FromStructure(RC_073e413c5402df3d82c2d65d0628594a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_073e413c5402df3d82c2d65d0628594a(s, config);
}

}


