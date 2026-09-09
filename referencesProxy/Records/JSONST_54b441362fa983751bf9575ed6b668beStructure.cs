using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EM_COSMOZ_Request_Struct
public class JSONST_54b441362fa983751bf9575ed6b668beStructure : AbstractRESTStructure<ST_54b441362fa983751bf9575ed6b668beStructure> {
[JsonProperty("PI_HEADER")]
[JsonPropertyName("PI_HEADER")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1186519ca5bb238ab9fc7126d4696469Structure AttrPI_HEADER;

[JsonProperty("PI_ITEM")]
[JsonPropertyName("PI_ITEM")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure AttrPI_ITEM;

public JSONST_54b441362fa983751bf9575ed6b668beStructure() { }

public JSONST_54b441362fa983751bf9575ed6b668beStructure (ST_54b441362fa983751bf9575ed6b668beStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ConvertToRestWithoutDefaults(s.ssPI_HEADER, new ST_1186519ca5bb238ab9fc7126d4696469Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1186519ca5bb238ab9fc7126d4696469Structure.FromStructure, config);
AttrPI_ITEM = ConvertToRestWithoutDefaults(s.ssPI_ITEM, new ST_5f3e5a981bd9e9a45ed03e989538932dStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure.FromStructure, config);
  } else {
AttrPI_HEADER = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1186519ca5bb238ab9fc7126d4696469Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure.FromStructure(s.ssPI_ITEM, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure, ST_54b441362fa983751bf9575ed6b668beStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure s) => ToStructure(s, config);
}
public static ST_54b441362fa983751bf9575ed6b668beStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure obj, IBehaviorsConfiguration config) { 
  ST_54b441362fa983751bf9575ed6b668beStructure s = new ST_54b441362fa983751bf9575ed6b668beStructure();
  if(obj != null) {
  s.ssPI_HEADER = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1186519ca5bb238ab9fc7126d4696469Structure.ToStructure(obj.AttrPI_HEADER, config);
  s.ssPI_ITEM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure.ToStructure(obj.AttrPI_ITEM, config);
  }
  return s;
}

public static Func<ST_54b441362fa983751bf9575ed6b668beStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_54b441362fa983751bf9575ed6b668beStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure FromStructure(ST_54b441362fa983751bf9575ed6b668beStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure(s, config);
}

}


