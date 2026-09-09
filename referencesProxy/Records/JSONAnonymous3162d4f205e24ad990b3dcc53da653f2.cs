using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// InsuranceTypeRecord
public class JSONRC_e16f126ae5f7407d32d4a429fb32ca9a : AbstractRESTStructure<RC_e16f126ae5f7407d32d4a429fb32ca9a> {
[JsonProperty("InsuranceType")]
[JsonPropertyName("InsuranceType")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord AttrInsuranceType;

public JSONRC_e16f126ae5f7407d32d4a429fb32ca9a() { }

public JSONRC_e16f126ae5f7407d32d4a429fb32ca9a (RC_e16f126ae5f7407d32d4a429fb32ca9a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInsuranceType = ConvertToRestWithoutDefaults(s.ssENInsuranceType, new EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord.FromStructure, config);
  } else {
AttrInsuranceType = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord.FromStructure(s.ssENInsuranceType, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e16f126ae5f7407d32d4a429fb32ca9a, RC_e16f126ae5f7407d32d4a429fb32ca9a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e16f126ae5f7407d32d4a429fb32ca9a s) => ToStructure(s, config);
}
public static RC_e16f126ae5f7407d32d4a429fb32ca9a ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e16f126ae5f7407d32d4a429fb32ca9a obj, IBehaviorsConfiguration config) { 
  RC_e16f126ae5f7407d32d4a429fb32ca9a s = new RC_e16f126ae5f7407d32d4a429fb32ca9a();
  if(obj != null) {
  s.ssENInsuranceType = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord.ToStructure(obj.AttrInsuranceType, config);
  }
  return s;
}

public static Func<RC_e16f126ae5f7407d32d4a429fb32ca9a, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e16f126ae5f7407d32d4a429fb32ca9a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e16f126ae5f7407d32d4a429fb32ca9a s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e16f126ae5f7407d32d4a429fb32ca9a FromStructure(RC_e16f126ae5f7407d32d4a429fb32ca9a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e16f126ae5f7407d32d4a429fb32ca9a(s, config);
}

}


