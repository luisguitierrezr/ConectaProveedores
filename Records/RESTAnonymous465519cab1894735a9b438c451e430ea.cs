using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValueItemRecord
public class RESTRC_c06f8a0170c6518f22bc1e9645ee082e : AbstractRESTStructure<RC_c06f8a0170c6518f22bc1e9645ee082e> {
[JsonProperty("ValueItem")]
public ssConectaProveedores.RestRecords.RESTST_d32097d2629a99529d77b865dae9fb0cStructure AttrValueItem;

public RESTRC_c06f8a0170c6518f22bc1e9645ee082e() { }

public RESTRC_c06f8a0170c6518f22bc1e9645ee082e (RC_c06f8a0170c6518f22bc1e9645ee082e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValueItem = ConvertToRestWithoutDefaults(s.ssSTValueItem, new ST_d32097d2629a99529d77b865dae9fb0cStructure(), ssConectaProveedores.RestRecords.RESTST_d32097d2629a99529d77b865dae9fb0cStructure.FromStructure, config);
  } else {
AttrValueItem = ssConectaProveedores.RestRecords.RESTST_d32097d2629a99529d77b865dae9fb0cStructure.FromStructure(s.ssSTValueItem, config);
  }
}

public static RC_c06f8a0170c6518f22bc1e9645ee082e ToStructure(ssConectaProveedores.RestRecords.RESTRC_c06f8a0170c6518f22bc1e9645ee082e obj) { 
  RC_c06f8a0170c6518f22bc1e9645ee082e s = new RC_c06f8a0170c6518f22bc1e9645ee082e();
  if(obj != null) {
  s.ssSTValueItem = ssConectaProveedores.RestRecords.RESTST_d32097d2629a99529d77b865dae9fb0cStructure.ToStructure(obj.AttrValueItem);
  }
  return s;
}

public static Func<RC_c06f8a0170c6518f22bc1e9645ee082e, ssConectaProveedores.RestRecords.RESTRC_c06f8a0170c6518f22bc1e9645ee082e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c06f8a0170c6518f22bc1e9645ee082e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c06f8a0170c6518f22bc1e9645ee082e FromStructure(RC_c06f8a0170c6518f22bc1e9645ee082e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c06f8a0170c6518f22bc1e9645ee082e(s, config);
}

}


