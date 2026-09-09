using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_COSMOZ_Request_Struct
public class RESTST_54b441362fa983751bf9575ed6b668beStructure : AbstractRESTStructure<ST_54b441362fa983751bf9575ed6b668beStructure> {
[JsonProperty("PI_HEADER")]
public ssConectaProveedores.RestRecords.RESTST_1186519ca5bb238ab9fc7126d4696469Structure AttrPI_HEADER;

[JsonProperty("PI_ITEM")]
public ssConectaProveedores.RestRecords.RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure AttrPI_ITEM;

public RESTST_54b441362fa983751bf9575ed6b668beStructure() { }

public RESTST_54b441362fa983751bf9575ed6b668beStructure (ST_54b441362fa983751bf9575ed6b668beStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ConvertToRestWithoutDefaults(s.ssPI_HEADER, new ST_1186519ca5bb238ab9fc7126d4696469Structure(), ssConectaProveedores.RestRecords.RESTST_1186519ca5bb238ab9fc7126d4696469Structure.FromStructure, config);
AttrPI_ITEM = ConvertToRestWithoutDefaults(s.ssPI_ITEM, new ST_5f3e5a981bd9e9a45ed03e989538932dStructure(), ssConectaProveedores.RestRecords.RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure.FromStructure, config);
  } else {
AttrPI_HEADER = ssConectaProveedores.RestRecords.RESTST_1186519ca5bb238ab9fc7126d4696469Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM = ssConectaProveedores.RestRecords.RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure.FromStructure(s.ssPI_ITEM, config);
  }
}

public static ST_54b441362fa983751bf9575ed6b668beStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_54b441362fa983751bf9575ed6b668beStructure obj) { 
  ST_54b441362fa983751bf9575ed6b668beStructure s = new ST_54b441362fa983751bf9575ed6b668beStructure();
  if(obj != null) {
  s.ssPI_HEADER = ssConectaProveedores.RestRecords.RESTST_1186519ca5bb238ab9fc7126d4696469Structure.ToStructure(obj.AttrPI_HEADER);
  s.ssPI_ITEM = ssConectaProveedores.RestRecords.RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure.ToStructure(obj.AttrPI_ITEM);
  }
  return s;
}

public static Func<ST_54b441362fa983751bf9575ed6b668beStructure, ssConectaProveedores.RestRecords.RESTST_54b441362fa983751bf9575ed6b668beStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_54b441362fa983751bf9575ed6b668beStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_54b441362fa983751bf9575ed6b668beStructure FromStructure(ST_54b441362fa983751bf9575ed6b668beStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_54b441362fa983751bf9575ed6b668beStructure(s, config);
}

}


