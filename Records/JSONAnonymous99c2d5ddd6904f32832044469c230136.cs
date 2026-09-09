using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// dataoutput2Record
public class JSONRC_66f7e325389c77502effc220cef9c6fe : AbstractRESTStructure<RC_66f7e325389c77502effc220cef9c6fe> {
[JsonProperty("dataoutput2")]
[JsonPropertyName("dataoutput2")]
public ssConectaProveedores.RestRecords.JSONST_91300ad987a75a51816ab4149ce29870Structure Attrdataoutput2;

public JSONRC_66f7e325389c77502effc220cef9c6fe() { }

public JSONRC_66f7e325389c77502effc220cef9c6fe (RC_66f7e325389c77502effc220cef9c6fe s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrdataoutput2 = ConvertToRestWithoutDefaults(s.ssSTdataoutput2, new ST_91300ad987a75a51816ab4149ce29870Structure(), ssConectaProveedores.RestRecords.JSONST_91300ad987a75a51816ab4149ce29870Structure.FromStructure, config);
  } else {
Attrdataoutput2 = ssConectaProveedores.RestRecords.JSONST_91300ad987a75a51816ab4149ce29870Structure.FromStructure(s.ssSTdataoutput2, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_66f7e325389c77502effc220cef9c6fe, RC_66f7e325389c77502effc220cef9c6fe> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_66f7e325389c77502effc220cef9c6fe s) => ToStructure(s, config);
}
public static RC_66f7e325389c77502effc220cef9c6fe ToStructure(ssConectaProveedores.RestRecords.JSONRC_66f7e325389c77502effc220cef9c6fe obj, IBehaviorsConfiguration config) { 
  RC_66f7e325389c77502effc220cef9c6fe s = new RC_66f7e325389c77502effc220cef9c6fe();
  if(obj != null) {
  s.ssSTdataoutput2 = ssConectaProveedores.RestRecords.JSONST_91300ad987a75a51816ab4149ce29870Structure.ToStructure(obj.Attrdataoutput2, config);
  }
  return s;
}

public static Func<RC_66f7e325389c77502effc220cef9c6fe, ssConectaProveedores.RestRecords.JSONRC_66f7e325389c77502effc220cef9c6fe> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_66f7e325389c77502effc220cef9c6fe s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_66f7e325389c77502effc220cef9c6fe FromStructure(RC_66f7e325389c77502effc220cef9c6fe s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_66f7e325389c77502effc220cef9c6fe(s, config);
}

}


