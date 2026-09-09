using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LegendLayoutRecord
public class RESTRC_250abb7806127d6d6c565bcd6bd8fd6f : AbstractRESTStructure<RC_250abb7806127d6d6c565bcd6bd8fd6f> {
[JsonProperty("LegendLayout")]
public ssConectaProveedores.RestRecords.RESTEN_f2ce8f552d142202c9a955104f8986e7EntityRecord AttrLegendLayout;

public RESTRC_250abb7806127d6d6c565bcd6bd8fd6f() { }

public RESTRC_250abb7806127d6d6c565bcd6bd8fd6f (RC_250abb7806127d6d6c565bcd6bd8fd6f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLegendLayout = ConvertToRestWithoutDefaults(s.ssENLegendLayout, new EN_f2ce8f552d142202c9a955104f8986e7EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f2ce8f552d142202c9a955104f8986e7EntityRecord.FromStructure, config);
  } else {
AttrLegendLayout = ssConectaProveedores.RestRecords.RESTEN_f2ce8f552d142202c9a955104f8986e7EntityRecord.FromStructure(s.ssENLegendLayout, config);
  }
}

public static RC_250abb7806127d6d6c565bcd6bd8fd6f ToStructure(ssConectaProveedores.RestRecords.RESTRC_250abb7806127d6d6c565bcd6bd8fd6f obj) { 
  RC_250abb7806127d6d6c565bcd6bd8fd6f s = new RC_250abb7806127d6d6c565bcd6bd8fd6f();
  if(obj != null) {
  s.ssENLegendLayout = ssConectaProveedores.RestRecords.RESTEN_f2ce8f552d142202c9a955104f8986e7EntityRecord.ToStructure(obj.AttrLegendLayout);
  }
  return s;
}

public static Func<RC_250abb7806127d6d6c565bcd6bd8fd6f, ssConectaProveedores.RestRecords.RESTRC_250abb7806127d6d6c565bcd6bd8fd6f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_250abb7806127d6d6c565bcd6bd8fd6f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_250abb7806127d6d6c565bcd6bd8fd6f FromStructure(RC_250abb7806127d6d6c565bcd6bd8fd6f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_250abb7806127d6d6c565bcd6bd8fd6f(s, config);
}

}


