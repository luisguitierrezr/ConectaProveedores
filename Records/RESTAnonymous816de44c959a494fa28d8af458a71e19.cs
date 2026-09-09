using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// users2Record
public class RESTRC_e71ee504a150cc1126ba54fe808d49c0 : AbstractRESTStructure<RC_e71ee504a150cc1126ba54fe808d49c0> {
[JsonProperty("users2")]
public ssConectaProveedores.RestRecords.RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure Attrusers2;

public RESTRC_e71ee504a150cc1126ba54fe808d49c0() { }

public RESTRC_e71ee504a150cc1126ba54fe808d49c0 (RC_e71ee504a150cc1126ba54fe808d49c0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrusers2 = ConvertToRestWithoutDefaults(s.ssSTusers2, new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure(), ssConectaProveedores.RestRecords.RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure.FromStructure, config);
  } else {
Attrusers2 = ssConectaProveedores.RestRecords.RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure.FromStructure(s.ssSTusers2, config);
  }
}

public static RC_e71ee504a150cc1126ba54fe808d49c0 ToStructure(ssConectaProveedores.RestRecords.RESTRC_e71ee504a150cc1126ba54fe808d49c0 obj) { 
  RC_e71ee504a150cc1126ba54fe808d49c0 s = new RC_e71ee504a150cc1126ba54fe808d49c0();
  if(obj != null) {
  s.ssSTusers2 = ssConectaProveedores.RestRecords.RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure.ToStructure(obj.Attrusers2);
  }
  return s;
}

public static Func<RC_e71ee504a150cc1126ba54fe808d49c0, ssConectaProveedores.RestRecords.RESTRC_e71ee504a150cc1126ba54fe808d49c0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e71ee504a150cc1126ba54fe808d49c0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e71ee504a150cc1126ba54fe808d49c0 FromStructure(RC_e71ee504a150cc1126ba54fe808d49c0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e71ee504a150cc1126ba54fe808d49c0(s, config);
}

}


