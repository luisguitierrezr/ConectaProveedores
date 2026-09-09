using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LinesReport62Record
public class RESTRC_649e4584946d534f750cbe1a016bfe86 : AbstractRESTStructure<RC_649e4584946d534f750cbe1a016bfe86> {
[JsonProperty("LinesReport62")]
public ssConectaProveedores.RestRecords.RESTST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure AttrLinesReport62;

public RESTRC_649e4584946d534f750cbe1a016bfe86() { }

public RESTRC_649e4584946d534f750cbe1a016bfe86 (RC_649e4584946d534f750cbe1a016bfe86 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLinesReport62 = ConvertToRestWithoutDefaults(s.ssSTLinesReport62, new ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure(), ssConectaProveedores.RestRecords.RESTST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure.FromStructure, config);
  } else {
AttrLinesReport62 = ssConectaProveedores.RestRecords.RESTST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure.FromStructure(s.ssSTLinesReport62, config);
  }
}

public static RC_649e4584946d534f750cbe1a016bfe86 ToStructure(ssConectaProveedores.RestRecords.RESTRC_649e4584946d534f750cbe1a016bfe86 obj) { 
  RC_649e4584946d534f750cbe1a016bfe86 s = new RC_649e4584946d534f750cbe1a016bfe86();
  if(obj != null) {
  s.ssSTLinesReport62 = ssConectaProveedores.RestRecords.RESTST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure.ToStructure(obj.AttrLinesReport62);
  }
  return s;
}

public static Func<RC_649e4584946d534f750cbe1a016bfe86, ssConectaProveedores.RestRecords.RESTRC_649e4584946d534f750cbe1a016bfe86> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_649e4584946d534f750cbe1a016bfe86 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_649e4584946d534f750cbe1a016bfe86 FromStructure(RC_649e4584946d534f750cbe1a016bfe86 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_649e4584946d534f750cbe1a016bfe86(s, config);
}

}


