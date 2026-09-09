using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ValueItemRecord
public class JSONRC_c06f8a0170c6518f22bc1e9645ee082e : AbstractRESTStructure<RC_c06f8a0170c6518f22bc1e9645ee082e> {
[JsonProperty("ValueItem")]
[JsonPropertyName("ValueItem")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d32097d2629a99529d77b865dae9fb0cStructure AttrValueItem;

public JSONRC_c06f8a0170c6518f22bc1e9645ee082e() { }

public JSONRC_c06f8a0170c6518f22bc1e9645ee082e (RC_c06f8a0170c6518f22bc1e9645ee082e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValueItem = ConvertToRestWithoutDefaults(s.ssSTValueItem, new ST_d32097d2629a99529d77b865dae9fb0cStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d32097d2629a99529d77b865dae9fb0cStructure.FromStructure, config);
  } else {
AttrValueItem = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d32097d2629a99529d77b865dae9fb0cStructure.FromStructure(s.ssSTValueItem, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c06f8a0170c6518f22bc1e9645ee082e, RC_c06f8a0170c6518f22bc1e9645ee082e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c06f8a0170c6518f22bc1e9645ee082e s) => ToStructure(s, config);
}
public static RC_c06f8a0170c6518f22bc1e9645ee082e ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c06f8a0170c6518f22bc1e9645ee082e obj, IBehaviorsConfiguration config) { 
  RC_c06f8a0170c6518f22bc1e9645ee082e s = new RC_c06f8a0170c6518f22bc1e9645ee082e();
  if(obj != null) {
  s.ssSTValueItem = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_d32097d2629a99529d77b865dae9fb0cStructure.ToStructure(obj.AttrValueItem, config);
  }
  return s;
}

public static Func<RC_c06f8a0170c6518f22bc1e9645ee082e, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c06f8a0170c6518f22bc1e9645ee082e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c06f8a0170c6518f22bc1e9645ee082e s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c06f8a0170c6518f22bc1e9645ee082e FromStructure(RC_c06f8a0170c6518f22bc1e9645ee082e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c06f8a0170c6518f22bc1e9645ee082e(s, config);
}

}


