using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CargaCFDResultWrapperRecord
public class JSONRC_b05c1a7fbd8c144fd1f2755c12f1733a : AbstractRESTStructure<RC_b05c1a7fbd8c144fd1f2755c12f1733a> {
[JsonProperty("CargaCFDResultWrapper")]
[JsonPropertyName("CargaCFDResultWrapper")]
public ssConectaProveedores.RestRecords.JSONST_3feabb059aa2546826b3076d3b237751Structure AttrCargaCFDResultWrapper;

public JSONRC_b05c1a7fbd8c144fd1f2755c12f1733a() { }

public JSONRC_b05c1a7fbd8c144fd1f2755c12f1733a (RC_b05c1a7fbd8c144fd1f2755c12f1733a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCargaCFDResultWrapper = ConvertToRestWithoutDefaults(s.ssSTCargaCFDResultWrapper, new ST_3feabb059aa2546826b3076d3b237751Structure(), ssConectaProveedores.RestRecords.JSONST_3feabb059aa2546826b3076d3b237751Structure.FromStructure, config);
  } else {
AttrCargaCFDResultWrapper = ssConectaProveedores.RestRecords.JSONST_3feabb059aa2546826b3076d3b237751Structure.FromStructure(s.ssSTCargaCFDResultWrapper, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b05c1a7fbd8c144fd1f2755c12f1733a, RC_b05c1a7fbd8c144fd1f2755c12f1733a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b05c1a7fbd8c144fd1f2755c12f1733a s) => ToStructure(s, config);
}
public static RC_b05c1a7fbd8c144fd1f2755c12f1733a ToStructure(ssConectaProveedores.RestRecords.JSONRC_b05c1a7fbd8c144fd1f2755c12f1733a obj, IBehaviorsConfiguration config) { 
  RC_b05c1a7fbd8c144fd1f2755c12f1733a s = new RC_b05c1a7fbd8c144fd1f2755c12f1733a();
  if(obj != null) {
  s.ssSTCargaCFDResultWrapper = ssConectaProveedores.RestRecords.JSONST_3feabb059aa2546826b3076d3b237751Structure.ToStructure(obj.AttrCargaCFDResultWrapper, config);
  }
  return s;
}

public static Func<RC_b05c1a7fbd8c144fd1f2755c12f1733a, ssConectaProveedores.RestRecords.JSONRC_b05c1a7fbd8c144fd1f2755c12f1733a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b05c1a7fbd8c144fd1f2755c12f1733a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b05c1a7fbd8c144fd1f2755c12f1733a FromStructure(RC_b05c1a7fbd8c144fd1f2755c12f1733a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b05c1a7fbd8c144fd1f2755c12f1733a(s, config);
}

}


