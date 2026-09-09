using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InsuranceTypeRecord
public class RESTRC_e16f126ae5f7407d32d4a429fb32ca9a : AbstractRESTStructure<RC_e16f126ae5f7407d32d4a429fb32ca9a> {
[JsonProperty("InsuranceType")]
public ssConectaProveedores.RestRecords.RESTEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord AttrInsuranceType;

public RESTRC_e16f126ae5f7407d32d4a429fb32ca9a() { }

public RESTRC_e16f126ae5f7407d32d4a429fb32ca9a (RC_e16f126ae5f7407d32d4a429fb32ca9a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInsuranceType = ConvertToRestWithoutDefaults(s.ssENInsuranceType, new EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord.FromStructure, config);
  } else {
AttrInsuranceType = ssConectaProveedores.RestRecords.RESTEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord.FromStructure(s.ssENInsuranceType, config);
  }
}

public static RC_e16f126ae5f7407d32d4a429fb32ca9a ToStructure(ssConectaProveedores.RestRecords.RESTRC_e16f126ae5f7407d32d4a429fb32ca9a obj) { 
  RC_e16f126ae5f7407d32d4a429fb32ca9a s = new RC_e16f126ae5f7407d32d4a429fb32ca9a();
  if(obj != null) {
  s.ssENInsuranceType = ssConectaProveedores.RestRecords.RESTEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord.ToStructure(obj.AttrInsuranceType);
  }
  return s;
}

public static Func<RC_e16f126ae5f7407d32d4a429fb32ca9a, ssConectaProveedores.RestRecords.RESTRC_e16f126ae5f7407d32d4a429fb32ca9a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e16f126ae5f7407d32d4a429fb32ca9a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e16f126ae5f7407d32d4a429fb32ca9a FromStructure(RC_e16f126ae5f7407d32d4a429fb32ca9a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e16f126ae5f7407d32d4a429fb32ca9a(s, config);
}

}


