using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DirectoryRole
public class RESTST_2d127d12a9d7c02aac84eb45d06f36fbStructure : AbstractRESTStructure<ST_2d127d12a9d7c02aac84eb45d06f36fbStructure> {
[JsonProperty("odata_context")]
public string Attrodata_context;

[JsonProperty("Value")]
public RestList<ssConectaProveedores.RestRecords.RESTST_7103e60d503e9a31fa1ef77b9f0699a9Structure> AttrValue;

public RESTST_2d127d12a9d7c02aac84eb45d06f36fbStructure() { }

public RESTST_2d127d12a9d7c02aac84eb45d06f36fbStructure (ST_2d127d12a9d7c02aac84eb45d06f36fbStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrodata_context = ConvertToRestWithoutDefaults(s.ssodata_context, "");
AttrValue = s.ssValue.Length == 0 ? null : s.ssValue.ToRestList<ssConectaProveedores.RestRecords.RESTST_7103e60d503e9a31fa1ef77b9f0699a9Structure>(ssConectaProveedores.RestRecords.RESTST_7103e60d503e9a31fa1ef77b9f0699a9Structure.FromStructureDelegate(config));
  } else {
Attrodata_context = s.ssodata_context;
AttrValue = s.ssValue.ToRestList<ssConectaProveedores.RestRecords.RESTST_7103e60d503e9a31fa1ef77b9f0699a9Structure>(ssConectaProveedores.RestRecords.RESTST_7103e60d503e9a31fa1ef77b9f0699a9Structure.FromStructureDelegate(config));
  }
}

public static ST_2d127d12a9d7c02aac84eb45d06f36fbStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_2d127d12a9d7c02aac84eb45d06f36fbStructure obj) { 
  ST_2d127d12a9d7c02aac84eb45d06f36fbStructure s = new ST_2d127d12a9d7c02aac84eb45d06f36fbStructure();
  if(obj != null) {
  s.ssodata_context = obj.Attrodata_context == null ? "" : obj.Attrodata_context;
  s.ssValue = RL_02734d484762896f3a74099335d4c25d.FromRestList(obj.AttrValue, ssConectaProveedores.RestRecords.RESTST_7103e60d503e9a31fa1ef77b9f0699a9Structure.ToStructure);
  }
  return s;
}

public static Func<ST_2d127d12a9d7c02aac84eb45d06f36fbStructure, ssConectaProveedores.RestRecords.RESTST_2d127d12a9d7c02aac84eb45d06f36fbStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2d127d12a9d7c02aac84eb45d06f36fbStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_2d127d12a9d7c02aac84eb45d06f36fbStructure FromStructure(ST_2d127d12a9d7c02aac84eb45d06f36fbStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_2d127d12a9d7c02aac84eb45d06f36fbStructure(s, config);
}

}


