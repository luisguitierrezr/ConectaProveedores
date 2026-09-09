using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// KeyValueRecord
public class JSONRC_7f1c9fb0e9d8bbf714e27d72e2b97691 : AbstractRESTStructure<RC_7f1c9fb0e9d8bbf714e27d72e2b97691> {
[JsonProperty("KeyValue")]
[JsonPropertyName("KeyValue")]
public ssConectaProveedores.RestRecords.JSONST_714c559a98f1e1080cbf60de3228e843Structure AttrKeyValue;

public JSONRC_7f1c9fb0e9d8bbf714e27d72e2b97691() { }

public JSONRC_7f1c9fb0e9d8bbf714e27d72e2b97691 (RC_7f1c9fb0e9d8bbf714e27d72e2b97691 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrKeyValue = ConvertToRestWithoutDefaults(s.ssSTKeyValue, new ST_714c559a98f1e1080cbf60de3228e843Structure(), ssConectaProveedores.RestRecords.JSONST_714c559a98f1e1080cbf60de3228e843Structure.FromStructure, config);
  } else {
AttrKeyValue = ssConectaProveedores.RestRecords.JSONST_714c559a98f1e1080cbf60de3228e843Structure.FromStructure(s.ssSTKeyValue, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7f1c9fb0e9d8bbf714e27d72e2b97691, RC_7f1c9fb0e9d8bbf714e27d72e2b97691> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7f1c9fb0e9d8bbf714e27d72e2b97691 s) => ToStructure(s, config);
}
public static RC_7f1c9fb0e9d8bbf714e27d72e2b97691 ToStructure(ssConectaProveedores.RestRecords.JSONRC_7f1c9fb0e9d8bbf714e27d72e2b97691 obj, IBehaviorsConfiguration config) { 
  RC_7f1c9fb0e9d8bbf714e27d72e2b97691 s = new RC_7f1c9fb0e9d8bbf714e27d72e2b97691();
  if(obj != null) {
  s.ssSTKeyValue = ssConectaProveedores.RestRecords.JSONST_714c559a98f1e1080cbf60de3228e843Structure.ToStructure(obj.AttrKeyValue, config);
  }
  return s;
}

public static Func<RC_7f1c9fb0e9d8bbf714e27d72e2b97691, ssConectaProveedores.RestRecords.JSONRC_7f1c9fb0e9d8bbf714e27d72e2b97691> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7f1c9fb0e9d8bbf714e27d72e2b97691 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7f1c9fb0e9d8bbf714e27d72e2b97691 FromStructure(RC_7f1c9fb0e9d8bbf714e27d72e2b97691 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7f1c9fb0e9d8bbf714e27d72e2b97691(s, config);
}

}


