using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CargaCFDResultWrapperRecord
public class RESTRC_b05c1a7fbd8c144fd1f2755c12f1733a : AbstractRESTStructure<RC_b05c1a7fbd8c144fd1f2755c12f1733a> {
[JsonProperty("CargaCFDResultWrapper")]
public ssConectaProveedores.RestRecords.RESTST_3feabb059aa2546826b3076d3b237751Structure AttrCargaCFDResultWrapper;

public RESTRC_b05c1a7fbd8c144fd1f2755c12f1733a() { }

public RESTRC_b05c1a7fbd8c144fd1f2755c12f1733a (RC_b05c1a7fbd8c144fd1f2755c12f1733a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCargaCFDResultWrapper = ConvertToRestWithoutDefaults(s.ssSTCargaCFDResultWrapper, new ST_3feabb059aa2546826b3076d3b237751Structure(), ssConectaProveedores.RestRecords.RESTST_3feabb059aa2546826b3076d3b237751Structure.FromStructure, config);
  } else {
AttrCargaCFDResultWrapper = ssConectaProveedores.RestRecords.RESTST_3feabb059aa2546826b3076d3b237751Structure.FromStructure(s.ssSTCargaCFDResultWrapper, config);
  }
}

public static RC_b05c1a7fbd8c144fd1f2755c12f1733a ToStructure(ssConectaProveedores.RestRecords.RESTRC_b05c1a7fbd8c144fd1f2755c12f1733a obj) { 
  RC_b05c1a7fbd8c144fd1f2755c12f1733a s = new RC_b05c1a7fbd8c144fd1f2755c12f1733a();
  if(obj != null) {
  s.ssSTCargaCFDResultWrapper = ssConectaProveedores.RestRecords.RESTST_3feabb059aa2546826b3076d3b237751Structure.ToStructure(obj.AttrCargaCFDResultWrapper);
  }
  return s;
}

public static Func<RC_b05c1a7fbd8c144fd1f2755c12f1733a, ssConectaProveedores.RestRecords.RESTRC_b05c1a7fbd8c144fd1f2755c12f1733a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b05c1a7fbd8c144fd1f2755c12f1733a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b05c1a7fbd8c144fd1f2755c12f1733a FromStructure(RC_b05c1a7fbd8c144fd1f2755c12f1733a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b05c1a7fbd8c144fd1f2755c12f1733a(s, config);
}

}


