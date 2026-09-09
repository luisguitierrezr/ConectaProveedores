using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Configuration2Record
public class JSONRC_5b70628cb77b3444c17eb14380b204e1 : AbstractRESTStructure<RC_5b70628cb77b3444c17eb14380b204e1> {
[JsonProperty("Configuration2")]
[JsonPropertyName("Configuration2")]
public ssConectaProveedores.RestRecords.JSONST_ba6d268a2af779386f4c1aef812147c5Structure AttrConfiguration2;

public JSONRC_5b70628cb77b3444c17eb14380b204e1() { }

public JSONRC_5b70628cb77b3444c17eb14380b204e1 (RC_5b70628cb77b3444c17eb14380b204e1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrConfiguration2 = ConvertToRestWithoutDefaults(s.ssSTConfiguration2, new ST_ba6d268a2af779386f4c1aef812147c5Structure(), ssConectaProveedores.RestRecords.JSONST_ba6d268a2af779386f4c1aef812147c5Structure.FromStructure, config);
  } else {
AttrConfiguration2 = ssConectaProveedores.RestRecords.JSONST_ba6d268a2af779386f4c1aef812147c5Structure.FromStructure(s.ssSTConfiguration2, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_5b70628cb77b3444c17eb14380b204e1, RC_5b70628cb77b3444c17eb14380b204e1> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_5b70628cb77b3444c17eb14380b204e1 s) => ToStructure(s, config);
}
public static RC_5b70628cb77b3444c17eb14380b204e1 ToStructure(ssConectaProveedores.RestRecords.JSONRC_5b70628cb77b3444c17eb14380b204e1 obj, IBehaviorsConfiguration config) { 
  RC_5b70628cb77b3444c17eb14380b204e1 s = new RC_5b70628cb77b3444c17eb14380b204e1();
  if(obj != null) {
  s.ssSTConfiguration2 = ssConectaProveedores.RestRecords.JSONST_ba6d268a2af779386f4c1aef812147c5Structure.ToStructure(obj.AttrConfiguration2, config);
  }
  return s;
}

public static Func<RC_5b70628cb77b3444c17eb14380b204e1, ssConectaProveedores.RestRecords.JSONRC_5b70628cb77b3444c17eb14380b204e1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5b70628cb77b3444c17eb14380b204e1 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_5b70628cb77b3444c17eb14380b204e1 FromStructure(RC_5b70628cb77b3444c17eb14380b204e1 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_5b70628cb77b3444c17eb14380b204e1(s, config);
}

}


