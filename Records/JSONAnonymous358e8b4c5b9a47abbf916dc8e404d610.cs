using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DirectReportsRecord
public class JSONRC_2d1ccecb35012738626c275d8a3d3a9f : AbstractRESTStructure<RC_2d1ccecb35012738626c275d8a3d3a9f> {
[JsonProperty("DirectReports")]
[JsonPropertyName("DirectReports")]
public ssConectaProveedores.RestRecords.JSONST_7d99a0be08bc4d3199f250548e6c4016Structure AttrDirectReports;

public JSONRC_2d1ccecb35012738626c275d8a3d3a9f() { }

public JSONRC_2d1ccecb35012738626c275d8a3d3a9f (RC_2d1ccecb35012738626c275d8a3d3a9f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirectReports = ConvertToRestWithoutDefaults(s.ssSTDirectReports, new ST_7d99a0be08bc4d3199f250548e6c4016Structure(), ssConectaProveedores.RestRecords.JSONST_7d99a0be08bc4d3199f250548e6c4016Structure.FromStructure, config);
  } else {
AttrDirectReports = ssConectaProveedores.RestRecords.JSONST_7d99a0be08bc4d3199f250548e6c4016Structure.FromStructure(s.ssSTDirectReports, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2d1ccecb35012738626c275d8a3d3a9f, RC_2d1ccecb35012738626c275d8a3d3a9f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2d1ccecb35012738626c275d8a3d3a9f s) => ToStructure(s, config);
}
public static RC_2d1ccecb35012738626c275d8a3d3a9f ToStructure(ssConectaProveedores.RestRecords.JSONRC_2d1ccecb35012738626c275d8a3d3a9f obj, IBehaviorsConfiguration config) { 
  RC_2d1ccecb35012738626c275d8a3d3a9f s = new RC_2d1ccecb35012738626c275d8a3d3a9f();
  if(obj != null) {
  s.ssSTDirectReports = ssConectaProveedores.RestRecords.JSONST_7d99a0be08bc4d3199f250548e6c4016Structure.ToStructure(obj.AttrDirectReports, config);
  }
  return s;
}

public static Func<RC_2d1ccecb35012738626c275d8a3d3a9f, ssConectaProveedores.RestRecords.JSONRC_2d1ccecb35012738626c275d8a3d3a9f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2d1ccecb35012738626c275d8a3d3a9f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2d1ccecb35012738626c275d8a3d3a9f FromStructure(RC_2d1ccecb35012738626c275d8a3d3a9f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2d1ccecb35012738626c275d8a3d3a9f(s, config);
}

}


