using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ManualsRecord
public class JSONRC_5a839548c2b6676209dad9fb179bc76c : AbstractRESTStructure<RC_5a839548c2b6676209dad9fb179bc76c> {
[JsonProperty("Manuals")]
[JsonPropertyName("Manuals")]
public ssConectaProveedores.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord AttrManuals;

public JSONRC_5a839548c2b6676209dad9fb179bc76c() { }

public JSONRC_5a839548c2b6676209dad9fb179bc76c (RC_5a839548c2b6676209dad9fb179bc76c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrManuals = ConvertToRestWithoutDefaults(s.ssENManuals, new EN_f9557b941e05ea8155a182da4f23a896EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord.FromStructure, config);
  } else {
AttrManuals = ssConectaProveedores.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord.FromStructure(s.ssENManuals, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_5a839548c2b6676209dad9fb179bc76c, RC_5a839548c2b6676209dad9fb179bc76c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_5a839548c2b6676209dad9fb179bc76c s) => ToStructure(s, config);
}
public static RC_5a839548c2b6676209dad9fb179bc76c ToStructure(ssConectaProveedores.RestRecords.JSONRC_5a839548c2b6676209dad9fb179bc76c obj, IBehaviorsConfiguration config) { 
  RC_5a839548c2b6676209dad9fb179bc76c s = new RC_5a839548c2b6676209dad9fb179bc76c();
  if(obj != null) {
  s.ssENManuals = ssConectaProveedores.RestRecords.JSONEN_f9557b941e05ea8155a182da4f23a896EntityRecord.ToStructure(obj.AttrManuals, config);
  }
  return s;
}

public static Func<RC_5a839548c2b6676209dad9fb179bc76c, ssConectaProveedores.RestRecords.JSONRC_5a839548c2b6676209dad9fb179bc76c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5a839548c2b6676209dad9fb179bc76c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_5a839548c2b6676209dad9fb179bc76c FromStructure(RC_5a839548c2b6676209dad9fb179bc76c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_5a839548c2b6676209dad9fb179bc76c(s, config);
}

}


