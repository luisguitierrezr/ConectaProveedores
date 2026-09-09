using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SubdirectionRecord
public class JSONRC_896ad3137023f533323e3fc3a800f331 : AbstractRESTStructure<RC_896ad3137023f533323e3fc3a800f331> {
[JsonProperty("Subdirection")]
[JsonPropertyName("Subdirection")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord AttrSubdirection;

public JSONRC_896ad3137023f533323e3fc3a800f331() { }

public JSONRC_896ad3137023f533323e3fc3a800f331 (RC_896ad3137023f533323e3fc3a800f331 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSubdirection = ConvertToRestWithoutDefaults(s.ssENSubdirection, new EN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord.FromStructure, config);
  } else {
AttrSubdirection = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord.FromStructure(s.ssENSubdirection, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_896ad3137023f533323e3fc3a800f331, RC_896ad3137023f533323e3fc3a800f331> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_896ad3137023f533323e3fc3a800f331 s) => ToStructure(s, config);
}
public static RC_896ad3137023f533323e3fc3a800f331 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_896ad3137023f533323e3fc3a800f331 obj, IBehaviorsConfiguration config) { 
  RC_896ad3137023f533323e3fc3a800f331 s = new RC_896ad3137023f533323e3fc3a800f331();
  if(obj != null) {
  s.ssENSubdirection = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord.ToStructure(obj.AttrSubdirection, config);
  }
  return s;
}

public static Func<RC_896ad3137023f533323e3fc3a800f331, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_896ad3137023f533323e3fc3a800f331> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_896ad3137023f533323e3fc3a800f331 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_896ad3137023f533323e3fc3a800f331 FromStructure(RC_896ad3137023f533323e3fc3a800f331 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_896ad3137023f533323e3fc3a800f331(s, config);
}

}


