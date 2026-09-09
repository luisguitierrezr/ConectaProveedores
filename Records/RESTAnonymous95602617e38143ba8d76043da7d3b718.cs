using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// VirtualSelectConfigsRecord
public class RESTRC_a34c029579f872c2fbb90741544ea7c6 : AbstractRESTStructure<RC_a34c029579f872c2fbb90741544ea7c6> {
[JsonProperty("VirtualSelectConfigs")]
public ssConectaProveedores.RestRecords.RESTST_ee4d16d56cd7c489ec094cc9fa0cd607Structure AttrVirtualSelectConfigs;

public RESTRC_a34c029579f872c2fbb90741544ea7c6() { }

public RESTRC_a34c029579f872c2fbb90741544ea7c6 (RC_a34c029579f872c2fbb90741544ea7c6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrVirtualSelectConfigs = ConvertToRestWithoutDefaults(s.ssSTVirtualSelectConfigs, new ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure(), ssConectaProveedores.RestRecords.RESTST_ee4d16d56cd7c489ec094cc9fa0cd607Structure.FromStructure, config);
  } else {
AttrVirtualSelectConfigs = ssConectaProveedores.RestRecords.RESTST_ee4d16d56cd7c489ec094cc9fa0cd607Structure.FromStructure(s.ssSTVirtualSelectConfigs, config);
  }
}

public static RC_a34c029579f872c2fbb90741544ea7c6 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a34c029579f872c2fbb90741544ea7c6 obj) { 
  RC_a34c029579f872c2fbb90741544ea7c6 s = new RC_a34c029579f872c2fbb90741544ea7c6();
  if(obj != null) {
  s.ssSTVirtualSelectConfigs = ssConectaProveedores.RestRecords.RESTST_ee4d16d56cd7c489ec094cc9fa0cd607Structure.ToStructure(obj.AttrVirtualSelectConfigs);
  }
  return s;
}

public static Func<RC_a34c029579f872c2fbb90741544ea7c6, ssConectaProveedores.RestRecords.RESTRC_a34c029579f872c2fbb90741544ea7c6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a34c029579f872c2fbb90741544ea7c6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a34c029579f872c2fbb90741544ea7c6 FromStructure(RC_a34c029579f872c2fbb90741544ea7c6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a34c029579f872c2fbb90741544ea7c6(s, config);
}

}


