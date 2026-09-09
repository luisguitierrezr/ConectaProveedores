using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProgressBarOptionalConfigsRecord
public class JSONRC_3554b1e2806a5b827c457cdecc492d4a : AbstractRESTStructure<RC_3554b1e2806a5b827c457cdecc492d4a> {
[JsonProperty("ProgressBarOptionalConfigs")]
[JsonPropertyName("ProgressBarOptionalConfigs")]
public ssConectaProveedores.RestRecords.JSONST_8391f9d0c6b78f74493c47987669deecStructure AttrProgressBarOptionalConfigs;

public JSONRC_3554b1e2806a5b827c457cdecc492d4a() { }

public JSONRC_3554b1e2806a5b827c457cdecc492d4a (RC_3554b1e2806a5b827c457cdecc492d4a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProgressBarOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTProgressBarOptionalConfigs, new ST_8391f9d0c6b78f74493c47987669deecStructure(), ssConectaProveedores.RestRecords.JSONST_8391f9d0c6b78f74493c47987669deecStructure.FromStructure, config);
  } else {
AttrProgressBarOptionalConfigs = ssConectaProveedores.RestRecords.JSONST_8391f9d0c6b78f74493c47987669deecStructure.FromStructure(s.ssSTProgressBarOptionalConfigs, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3554b1e2806a5b827c457cdecc492d4a, RC_3554b1e2806a5b827c457cdecc492d4a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3554b1e2806a5b827c457cdecc492d4a s) => ToStructure(s, config);
}
public static RC_3554b1e2806a5b827c457cdecc492d4a ToStructure(ssConectaProveedores.RestRecords.JSONRC_3554b1e2806a5b827c457cdecc492d4a obj, IBehaviorsConfiguration config) { 
  RC_3554b1e2806a5b827c457cdecc492d4a s = new RC_3554b1e2806a5b827c457cdecc492d4a();
  if(obj != null) {
  s.ssSTProgressBarOptionalConfigs = ssConectaProveedores.RestRecords.JSONST_8391f9d0c6b78f74493c47987669deecStructure.ToStructure(obj.AttrProgressBarOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_3554b1e2806a5b827c457cdecc492d4a, ssConectaProveedores.RestRecords.JSONRC_3554b1e2806a5b827c457cdecc492d4a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3554b1e2806a5b827c457cdecc492d4a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3554b1e2806a5b827c457cdecc492d4a FromStructure(RC_3554b1e2806a5b827c457cdecc492d4a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3554b1e2806a5b827c457cdecc492d4a(s, config);
}

}


