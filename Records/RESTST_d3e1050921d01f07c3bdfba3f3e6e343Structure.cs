using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// GetGroupsResponse
public class RESTST_d3e1050921d01f07c3bdfba3f3e6e343Structure : AbstractRESTStructure<ST_d3e1050921d01f07c3bdfba3f3e6e343Structure> {
[JsonProperty("odata_context")]
public string Attrodata_context;

[JsonProperty("odata_nextLink")]
public string Attrodata_nextLink;

[JsonProperty("Value")]
public RestList<ssConectaProveedores.RestRecords.RESTST_7d9cb56357295234b770124829cebf1bStructure> AttrValue;

public RESTST_d3e1050921d01f07c3bdfba3f3e6e343Structure() { }

public RESTST_d3e1050921d01f07c3bdfba3f3e6e343Structure (ST_d3e1050921d01f07c3bdfba3f3e6e343Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrodata_context = ConvertToRestWithoutDefaults(s.ssodata_context, "");
Attrodata_nextLink = ConvertToRestWithoutDefaults(s.ssodata_nextLink, "");
AttrValue = s.ssValue.Length == 0 ? null : s.ssValue.ToRestList<ssConectaProveedores.RestRecords.RESTST_7d9cb56357295234b770124829cebf1bStructure>(ssConectaProveedores.RestRecords.RESTST_7d9cb56357295234b770124829cebf1bStructure.FromStructureDelegate(config));
  } else {
Attrodata_context = s.ssodata_context;
Attrodata_nextLink = s.ssodata_nextLink;
AttrValue = s.ssValue.ToRestList<ssConectaProveedores.RestRecords.RESTST_7d9cb56357295234b770124829cebf1bStructure>(ssConectaProveedores.RestRecords.RESTST_7d9cb56357295234b770124829cebf1bStructure.FromStructureDelegate(config));
  }
}

public static ST_d3e1050921d01f07c3bdfba3f3e6e343Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_d3e1050921d01f07c3bdfba3f3e6e343Structure obj) { 
  ST_d3e1050921d01f07c3bdfba3f3e6e343Structure s = new ST_d3e1050921d01f07c3bdfba3f3e6e343Structure();
  if(obj != null) {
  s.ssodata_context = obj.Attrodata_context == null ? "" : obj.Attrodata_context;
  s.ssodata_nextLink = obj.Attrodata_nextLink == null ? "" : obj.Attrodata_nextLink;
  s.ssValue = RL_ae05fe34dabbae8c8aefa197aab938f8.FromRestList(obj.AttrValue, ssConectaProveedores.RestRecords.RESTST_7d9cb56357295234b770124829cebf1bStructure.ToStructure);
  }
  return s;
}

public static Func<ST_d3e1050921d01f07c3bdfba3f3e6e343Structure, ssConectaProveedores.RestRecords.RESTST_d3e1050921d01f07c3bdfba3f3e6e343Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d3e1050921d01f07c3bdfba3f3e6e343Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_d3e1050921d01f07c3bdfba3f3e6e343Structure FromStructure(ST_d3e1050921d01f07c3bdfba3f3e6e343Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_d3e1050921d01f07c3bdfba3f3e6e343Structure(s, config);
}

}


