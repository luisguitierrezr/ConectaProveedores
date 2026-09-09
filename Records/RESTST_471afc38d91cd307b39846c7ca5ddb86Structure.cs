using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_COSMOZ_Request
public class RESTST_471afc38d91cd307b39846c7ca5ddb86Structure : AbstractRESTStructure<ST_471afc38d91cd307b39846c7ca5ddb86Structure> {
[JsonProperty("EM_COSMOZ_Request_Struct")]
public ssConectaProveedores.RestRecords.RESTST_54b441362fa983751bf9575ed6b668beStructure AttrEM_COSMOZ_Request_Struct;

public RESTST_471afc38d91cd307b39846c7ca5ddb86Structure() { }

public RESTST_471afc38d91cd307b39846c7ca5ddb86Structure (ST_471afc38d91cd307b39846c7ca5ddb86Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_COSMOZ_Request_Struct = ConvertToRestWithoutDefaults(s.ssEM_COSMOZ_Request_Struct, new ST_54b441362fa983751bf9575ed6b668beStructure(), ssConectaProveedores.RestRecords.RESTST_54b441362fa983751bf9575ed6b668beStructure.FromStructure, config);
  } else {
AttrEM_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.RESTST_54b441362fa983751bf9575ed6b668beStructure.FromStructure(s.ssEM_COSMOZ_Request_Struct, config);
  }
}

public static ST_471afc38d91cd307b39846c7ca5ddb86Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_471afc38d91cd307b39846c7ca5ddb86Structure obj) { 
  ST_471afc38d91cd307b39846c7ca5ddb86Structure s = new ST_471afc38d91cd307b39846c7ca5ddb86Structure();
  if(obj != null) {
  s.ssEM_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.RESTST_54b441362fa983751bf9575ed6b668beStructure.ToStructure(obj.AttrEM_COSMOZ_Request_Struct);
  }
  return s;
}

public static Func<ST_471afc38d91cd307b39846c7ca5ddb86Structure, ssConectaProveedores.RestRecords.RESTST_471afc38d91cd307b39846c7ca5ddb86Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_471afc38d91cd307b39846c7ca5ddb86Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_471afc38d91cd307b39846c7ca5ddb86Structure FromStructure(ST_471afc38d91cd307b39846c7ca5ddb86Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_471afc38d91cd307b39846c7ca5ddb86Structure(s, config);
}

}


