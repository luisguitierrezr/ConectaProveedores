using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SubdirectionRecord
public class RESTRC_896ad3137023f533323e3fc3a800f331 : AbstractRESTStructure<RC_896ad3137023f533323e3fc3a800f331> {
[JsonProperty("Subdirection")]
public ssConectaProveedores.RestRecords.RESTEN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord AttrSubdirection;

public RESTRC_896ad3137023f533323e3fc3a800f331() { }

public RESTRC_896ad3137023f533323e3fc3a800f331 (RC_896ad3137023f533323e3fc3a800f331 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSubdirection = ConvertToRestWithoutDefaults(s.ssENSubdirection, new EN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord.FromStructure, config);
  } else {
AttrSubdirection = ssConectaProveedores.RestRecords.RESTEN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord.FromStructure(s.ssENSubdirection, config);
  }
}

public static RC_896ad3137023f533323e3fc3a800f331 ToStructure(ssConectaProveedores.RestRecords.RESTRC_896ad3137023f533323e3fc3a800f331 obj) { 
  RC_896ad3137023f533323e3fc3a800f331 s = new RC_896ad3137023f533323e3fc3a800f331();
  if(obj != null) {
  s.ssENSubdirection = ssConectaProveedores.RestRecords.RESTEN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord.ToStructure(obj.AttrSubdirection);
  }
  return s;
}

public static Func<RC_896ad3137023f533323e3fc3a800f331, ssConectaProveedores.RestRecords.RESTRC_896ad3137023f533323e3fc3a800f331> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_896ad3137023f533323e3fc3a800f331 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_896ad3137023f533323e3fc3a800f331 FromStructure(RC_896ad3137023f533323e3fc3a800f331 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_896ad3137023f533323e3fc3a800f331(s, config);
}

}


