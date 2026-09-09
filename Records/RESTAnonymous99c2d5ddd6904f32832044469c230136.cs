using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// dataoutput2Record
public class RESTRC_66f7e325389c77502effc220cef9c6fe : AbstractRESTStructure<RC_66f7e325389c77502effc220cef9c6fe> {
[JsonProperty("dataoutput2")]
public ssConectaProveedores.RestRecords.RESTST_91300ad987a75a51816ab4149ce29870Structure Attrdataoutput2;

public RESTRC_66f7e325389c77502effc220cef9c6fe() { }

public RESTRC_66f7e325389c77502effc220cef9c6fe (RC_66f7e325389c77502effc220cef9c6fe s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrdataoutput2 = ConvertToRestWithoutDefaults(s.ssSTdataoutput2, new ST_91300ad987a75a51816ab4149ce29870Structure(), ssConectaProveedores.RestRecords.RESTST_91300ad987a75a51816ab4149ce29870Structure.FromStructure, config);
  } else {
Attrdataoutput2 = ssConectaProveedores.RestRecords.RESTST_91300ad987a75a51816ab4149ce29870Structure.FromStructure(s.ssSTdataoutput2, config);
  }
}

public static RC_66f7e325389c77502effc220cef9c6fe ToStructure(ssConectaProveedores.RestRecords.RESTRC_66f7e325389c77502effc220cef9c6fe obj) { 
  RC_66f7e325389c77502effc220cef9c6fe s = new RC_66f7e325389c77502effc220cef9c6fe();
  if(obj != null) {
  s.ssSTdataoutput2 = ssConectaProveedores.RestRecords.RESTST_91300ad987a75a51816ab4149ce29870Structure.ToStructure(obj.Attrdataoutput2);
  }
  return s;
}

public static Func<RC_66f7e325389c77502effc220cef9c6fe, ssConectaProveedores.RestRecords.RESTRC_66f7e325389c77502effc220cef9c6fe> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_66f7e325389c77502effc220cef9c6fe s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_66f7e325389c77502effc220cef9c6fe FromStructure(RC_66f7e325389c77502effc220cef9c6fe s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_66f7e325389c77502effc220cef9c6fe(s, config);
}

}


