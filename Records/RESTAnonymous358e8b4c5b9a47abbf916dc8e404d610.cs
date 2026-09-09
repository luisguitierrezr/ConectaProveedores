using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DirectReportsRecord
public class RESTRC_2d1ccecb35012738626c275d8a3d3a9f : AbstractRESTStructure<RC_2d1ccecb35012738626c275d8a3d3a9f> {
[JsonProperty("DirectReports")]
public ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure AttrDirectReports;

public RESTRC_2d1ccecb35012738626c275d8a3d3a9f() { }

public RESTRC_2d1ccecb35012738626c275d8a3d3a9f (RC_2d1ccecb35012738626c275d8a3d3a9f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDirectReports = ConvertToRestWithoutDefaults(s.ssSTDirectReports, new ST_7d99a0be08bc4d3199f250548e6c4016Structure(), ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure.FromStructure, config);
  } else {
AttrDirectReports = ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure.FromStructure(s.ssSTDirectReports, config);
  }
}

public static RC_2d1ccecb35012738626c275d8a3d3a9f ToStructure(ssConectaProveedores.RestRecords.RESTRC_2d1ccecb35012738626c275d8a3d3a9f obj) { 
  RC_2d1ccecb35012738626c275d8a3d3a9f s = new RC_2d1ccecb35012738626c275d8a3d3a9f();
  if(obj != null) {
  s.ssSTDirectReports = ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure.ToStructure(obj.AttrDirectReports);
  }
  return s;
}

public static Func<RC_2d1ccecb35012738626c275d8a3d3a9f, ssConectaProveedores.RestRecords.RESTRC_2d1ccecb35012738626c275d8a3d3a9f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2d1ccecb35012738626c275d8a3d3a9f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2d1ccecb35012738626c275d8a3d3a9f FromStructure(RC_2d1ccecb35012738626c275d8a3d3a9f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2d1ccecb35012738626c275d8a3d3a9f(s, config);
}

}


