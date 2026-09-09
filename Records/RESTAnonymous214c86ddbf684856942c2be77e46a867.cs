using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ManualsRecord
public class RESTRC_5a839548c2b6676209dad9fb179bc76c : AbstractRESTStructure<RC_5a839548c2b6676209dad9fb179bc76c> {
[JsonProperty("Manuals")]
public ssConectaProveedores.RestRecords.RESTEN_f9557b941e05ea8155a182da4f23a896EntityRecord AttrManuals;

public RESTRC_5a839548c2b6676209dad9fb179bc76c() { }

public RESTRC_5a839548c2b6676209dad9fb179bc76c (RC_5a839548c2b6676209dad9fb179bc76c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrManuals = ConvertToRestWithoutDefaults(s.ssENManuals, new EN_f9557b941e05ea8155a182da4f23a896EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f9557b941e05ea8155a182da4f23a896EntityRecord.FromStructure, config);
  } else {
AttrManuals = ssConectaProveedores.RestRecords.RESTEN_f9557b941e05ea8155a182da4f23a896EntityRecord.FromStructure(s.ssENManuals, config);
  }
}

public static RC_5a839548c2b6676209dad9fb179bc76c ToStructure(ssConectaProveedores.RestRecords.RESTRC_5a839548c2b6676209dad9fb179bc76c obj) { 
  RC_5a839548c2b6676209dad9fb179bc76c s = new RC_5a839548c2b6676209dad9fb179bc76c();
  if(obj != null) {
  s.ssENManuals = ssConectaProveedores.RestRecords.RESTEN_f9557b941e05ea8155a182da4f23a896EntityRecord.ToStructure(obj.AttrManuals);
  }
  return s;
}

public static Func<RC_5a839548c2b6676209dad9fb179bc76c, ssConectaProveedores.RestRecords.RESTRC_5a839548c2b6676209dad9fb179bc76c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5a839548c2b6676209dad9fb179bc76c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5a839548c2b6676209dad9fb179bc76c FromStructure(RC_5a839548c2b6676209dad9fb179bc76c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5a839548c2b6676209dad9fb179bc76c(s, config);
}

}


