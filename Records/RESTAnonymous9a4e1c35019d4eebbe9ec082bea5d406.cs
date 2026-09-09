using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderFileRecord
public class RESTRC_a7394a353dc1b7f636aaced209e66116 : AbstractRESTStructure<RC_a7394a353dc1b7f636aaced209e66116> {
[JsonProperty("OrderFile")]
public ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord AttrOrderFile;

public RESTRC_a7394a353dc1b7f636aaced209e66116() { }

public RESTRC_a7394a353dc1b7f636aaced209e66116 (RC_a7394a353dc1b7f636aaced209e66116 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderFile = ConvertToRestWithoutDefaults(s.ssENOrderFile, new EN_096339be3ef098b3762e8897e3a1c095EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure, config);
  } else {
AttrOrderFile = ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure(s.ssENOrderFile, config);
  }
}

public static RC_a7394a353dc1b7f636aaced209e66116 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a7394a353dc1b7f636aaced209e66116 obj) { 
  RC_a7394a353dc1b7f636aaced209e66116 s = new RC_a7394a353dc1b7f636aaced209e66116();
  if(obj != null) {
  s.ssENOrderFile = ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.ToStructure(obj.AttrOrderFile);
  }
  return s;
}

public static Func<RC_a7394a353dc1b7f636aaced209e66116, ssConectaProveedores.RestRecords.RESTRC_a7394a353dc1b7f636aaced209e66116> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a7394a353dc1b7f636aaced209e66116 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a7394a353dc1b7f636aaced209e66116 FromStructure(RC_a7394a353dc1b7f636aaced209e66116 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a7394a353dc1b7f636aaced209e66116(s, config);
}

}


