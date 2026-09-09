using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Users3
public class JSONST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure : AbstractRESTStructure<ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure> {
[JsonProperty("@odata.context")]
[JsonPropertyName("@odata.context")]
public string Attrodata_context;

[JsonProperty("@odata.nextLink")]
[JsonPropertyName("@odata.nextLink")]
public string Attrodata_nextLink;

[JsonProperty("value")]
[JsonPropertyName("value")]
public ssConectaProveedores.RestRecords.JSONST_d32097d2629a99529d77b865dae9fb0cStructure[] AttrValue;

public JSONST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure() { }

public JSONST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure (ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrodata_context = ConvertToRestWithoutDefaults(s.ssodata_context, "");
Attrodata_nextLink = ConvertToRestWithoutDefaults(s.ssodata_nextLink, "");
AttrValue = s.ssValue.Length == 0 ? null : s.ssValue.ToArray<ssConectaProveedores.RestRecords.JSONST_d32097d2629a99529d77b865dae9fb0cStructure>(ssConectaProveedores.RestRecords.JSONST_d32097d2629a99529d77b865dae9fb0cStructure.FromStructureDelegate(config));
  } else {
Attrodata_context = s.ssodata_context;
Attrodata_nextLink = s.ssodata_nextLink;
AttrValue = s.ssValue.ToArray<ssConectaProveedores.RestRecords.JSONST_d32097d2629a99529d77b865dae9fb0cStructure>(ssConectaProveedores.RestRecords.JSONST_d32097d2629a99529d77b865dae9fb0cStructure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure, ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure s) => ToStructure(s, config);
}
public static ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure obj, IBehaviorsConfiguration config) { 
  ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure s = new ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure();
  if(obj != null) {
  s.ssodata_context = obj.Attrodata_context == null ? "" : obj.Attrodata_context;
  s.ssodata_nextLink = obj.Attrodata_nextLink == null ? "" : obj.Attrodata_nextLink;
  s.ssValue = RL_c68f8e92ccdada3f2f3589e091be34b8.ToList(obj.AttrValue, ssConectaProveedores.RestRecords.JSONST_d32097d2629a99529d77b865dae9fb0cStructure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure, ssConectaProveedores.RestRecords.JSONST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure FromStructure(ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure(s, config);
}

}


