using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// GetGroupsResponse
public class JSONST_d3e1050921d01f07c3bdfba3f3e6e343Structure : AbstractRESTStructure<ST_d3e1050921d01f07c3bdfba3f3e6e343Structure> {
[JsonProperty("@odata.context")]
[JsonPropertyName("@odata.context")]
public string Attrodata_context;

[JsonProperty("@odata.nextLink")]
[JsonPropertyName("@odata.nextLink")]
public string Attrodata_nextLink;

[JsonProperty("value")]
[JsonPropertyName("value")]
public ssConectaProveedores.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure[] AttrValue;

public JSONST_d3e1050921d01f07c3bdfba3f3e6e343Structure() { }

public JSONST_d3e1050921d01f07c3bdfba3f3e6e343Structure (ST_d3e1050921d01f07c3bdfba3f3e6e343Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrodata_context = ConvertToRestWithoutDefaults(s.ssodata_context, "");
Attrodata_nextLink = ConvertToRestWithoutDefaults(s.ssodata_nextLink, "");
AttrValue = s.ssValue.Length == 0 ? null : s.ssValue.ToArray<ssConectaProveedores.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure>(ssConectaProveedores.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure.FromStructureDelegate(config));
  } else {
Attrodata_context = s.ssodata_context;
Attrodata_nextLink = s.ssodata_nextLink;
AttrValue = s.ssValue.ToArray<ssConectaProveedores.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure>(ssConectaProveedores.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_d3e1050921d01f07c3bdfba3f3e6e343Structure, ST_d3e1050921d01f07c3bdfba3f3e6e343Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_d3e1050921d01f07c3bdfba3f3e6e343Structure s) => ToStructure(s, config);
}
public static ST_d3e1050921d01f07c3bdfba3f3e6e343Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_d3e1050921d01f07c3bdfba3f3e6e343Structure obj, IBehaviorsConfiguration config) { 
  ST_d3e1050921d01f07c3bdfba3f3e6e343Structure s = new ST_d3e1050921d01f07c3bdfba3f3e6e343Structure();
  if(obj != null) {
  s.ssodata_context = obj.Attrodata_context == null ? "" : obj.Attrodata_context;
  s.ssodata_nextLink = obj.Attrodata_nextLink == null ? "" : obj.Attrodata_nextLink;
  s.ssValue = RL_ae05fe34dabbae8c8aefa197aab938f8.ToList(obj.AttrValue, ssConectaProveedores.RestRecords.JSONST_7d9cb56357295234b770124829cebf1bStructure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_d3e1050921d01f07c3bdfba3f3e6e343Structure, ssConectaProveedores.RestRecords.JSONST_d3e1050921d01f07c3bdfba3f3e6e343Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d3e1050921d01f07c3bdfba3f3e6e343Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_d3e1050921d01f07c3bdfba3f3e6e343Structure FromStructure(ST_d3e1050921d01f07c3bdfba3f3e6e343Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_d3e1050921d01f07c3bdfba3f3e6e343Structure(s, config);
}

}


