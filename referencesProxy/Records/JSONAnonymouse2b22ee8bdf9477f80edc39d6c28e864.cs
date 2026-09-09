using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// OcrResultRecord
public class JSONRC_f92e28910a28340f3e2c5d63e6bdfe4a : AbstractRESTStructure<RC_f92e28910a28340f3e2c5d63e6bdfe4a> {
[JsonProperty("OcrResult")]
[JsonPropertyName("OcrResult")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ce06f43cf108d98e4f79c0106fcfd0acStructure AttrOcrResult;

public JSONRC_f92e28910a28340f3e2c5d63e6bdfe4a() { }

public JSONRC_f92e28910a28340f3e2c5d63e6bdfe4a (RC_f92e28910a28340f3e2c5d63e6bdfe4a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOcrResult = ConvertToRestWithoutDefaults(s.ssSTOcrResult, new ST_ce06f43cf108d98e4f79c0106fcfd0acStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ce06f43cf108d98e4f79c0106fcfd0acStructure.FromStructure, config);
  } else {
AttrOcrResult = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ce06f43cf108d98e4f79c0106fcfd0acStructure.FromStructure(s.ssSTOcrResult, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f92e28910a28340f3e2c5d63e6bdfe4a, RC_f92e28910a28340f3e2c5d63e6bdfe4a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f92e28910a28340f3e2c5d63e6bdfe4a s) => ToStructure(s, config);
}
public static RC_f92e28910a28340f3e2c5d63e6bdfe4a ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f92e28910a28340f3e2c5d63e6bdfe4a obj, IBehaviorsConfiguration config) { 
  RC_f92e28910a28340f3e2c5d63e6bdfe4a s = new RC_f92e28910a28340f3e2c5d63e6bdfe4a();
  if(obj != null) {
  s.ssSTOcrResult = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ce06f43cf108d98e4f79c0106fcfd0acStructure.ToStructure(obj.AttrOcrResult, config);
  }
  return s;
}

public static Func<RC_f92e28910a28340f3e2c5d63e6bdfe4a, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f92e28910a28340f3e2c5d63e6bdfe4a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f92e28910a28340f3e2c5d63e6bdfe4a s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f92e28910a28340f3e2c5d63e6bdfe4a FromStructure(RC_f92e28910a28340f3e2c5d63e6bdfe4a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f92e28910a28340f3e2c5d63e6bdfe4a(s, config);
}

}


