using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// LegendLayoutRecord
public class JSONRC_250abb7806127d6d6c565bcd6bd8fd6f : AbstractRESTStructure<RC_250abb7806127d6d6c565bcd6bd8fd6f> {
[JsonProperty("LegendLayout")]
[JsonPropertyName("LegendLayout")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f2ce8f552d142202c9a955104f8986e7EntityRecord AttrLegendLayout;

public JSONRC_250abb7806127d6d6c565bcd6bd8fd6f() { }

public JSONRC_250abb7806127d6d6c565bcd6bd8fd6f (RC_250abb7806127d6d6c565bcd6bd8fd6f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLegendLayout = ConvertToRestWithoutDefaults(s.ssENLegendLayout, new EN_f2ce8f552d142202c9a955104f8986e7EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f2ce8f552d142202c9a955104f8986e7EntityRecord.FromStructure, config);
  } else {
AttrLegendLayout = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f2ce8f552d142202c9a955104f8986e7EntityRecord.FromStructure(s.ssENLegendLayout, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_250abb7806127d6d6c565bcd6bd8fd6f, RC_250abb7806127d6d6c565bcd6bd8fd6f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_250abb7806127d6d6c565bcd6bd8fd6f s) => ToStructure(s, config);
}
public static RC_250abb7806127d6d6c565bcd6bd8fd6f ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_250abb7806127d6d6c565bcd6bd8fd6f obj, IBehaviorsConfiguration config) { 
  RC_250abb7806127d6d6c565bcd6bd8fd6f s = new RC_250abb7806127d6d6c565bcd6bd8fd6f();
  if(obj != null) {
  s.ssENLegendLayout = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f2ce8f552d142202c9a955104f8986e7EntityRecord.ToStructure(obj.AttrLegendLayout, config);
  }
  return s;
}

public static Func<RC_250abb7806127d6d6c565bcd6bd8fd6f, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_250abb7806127d6d6c565bcd6bd8fd6f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_250abb7806127d6d6c565bcd6bd8fd6f s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_250abb7806127d6d6c565bcd6bd8fd6f FromStructure(RC_250abb7806127d6d6c565bcd6bd8fd6f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_250abb7806127d6d6c565bcd6bd8fd6f(s, config);
}

}


