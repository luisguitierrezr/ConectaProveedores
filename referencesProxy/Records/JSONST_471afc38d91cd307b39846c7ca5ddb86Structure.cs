using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EM_COSMOZ_Request
public class JSONST_471afc38d91cd307b39846c7ca5ddb86Structure : AbstractRESTStructure<ST_471afc38d91cd307b39846c7ca5ddb86Structure> {
[JsonProperty("ZMXMIMMF_EM_COSMOZ")]
[JsonPropertyName("ZMXMIMMF_EM_COSMOZ")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure AttrEM_COSMOZ_Request_Struct;

public JSONST_471afc38d91cd307b39846c7ca5ddb86Structure() { }

public JSONST_471afc38d91cd307b39846c7ca5ddb86Structure (ST_471afc38d91cd307b39846c7ca5ddb86Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_COSMOZ_Request_Struct = ConvertToRestWithoutDefaults(s.ssEM_COSMOZ_Request_Struct, new ST_54b441362fa983751bf9575ed6b668beStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure.FromStructure, config);
  } else {
AttrEM_COSMOZ_Request_Struct = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure.FromStructure(s.ssEM_COSMOZ_Request_Struct, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_471afc38d91cd307b39846c7ca5ddb86Structure, ST_471afc38d91cd307b39846c7ca5ddb86Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_471afc38d91cd307b39846c7ca5ddb86Structure s) => ToStructure(s, config);
}
public static ST_471afc38d91cd307b39846c7ca5ddb86Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_471afc38d91cd307b39846c7ca5ddb86Structure obj, IBehaviorsConfiguration config) { 
  ST_471afc38d91cd307b39846c7ca5ddb86Structure s = new ST_471afc38d91cd307b39846c7ca5ddb86Structure();
  if(obj != null) {
  s.ssEM_COSMOZ_Request_Struct = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure.ToStructure(obj.AttrEM_COSMOZ_Request_Struct, config);
  }
  return s;
}

public static Func<ST_471afc38d91cd307b39846c7ca5ddb86Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_471afc38d91cd307b39846c7ca5ddb86Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_471afc38d91cd307b39846c7ca5ddb86Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_471afc38d91cd307b39846c7ca5ddb86Structure FromStructure(ST_471afc38d91cd307b39846c7ca5ddb86Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_471afc38d91cd307b39846c7ca5ddb86Structure(s, config);
}

}


