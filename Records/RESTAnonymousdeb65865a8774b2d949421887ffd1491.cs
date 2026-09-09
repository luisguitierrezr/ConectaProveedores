using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// KeyValueRecord
public class RESTRC_7f1c9fb0e9d8bbf714e27d72e2b97691 : AbstractRESTStructure<RC_7f1c9fb0e9d8bbf714e27d72e2b97691> {
[JsonProperty("KeyValue")]
public ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure AttrKeyValue;

public RESTRC_7f1c9fb0e9d8bbf714e27d72e2b97691() { }

public RESTRC_7f1c9fb0e9d8bbf714e27d72e2b97691 (RC_7f1c9fb0e9d8bbf714e27d72e2b97691 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrKeyValue = ConvertToRestWithoutDefaults(s.ssSTKeyValue, new ST_714c559a98f1e1080cbf60de3228e843Structure(), ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure.FromStructure, config);
  } else {
AttrKeyValue = ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure.FromStructure(s.ssSTKeyValue, config);
  }
}

public static RC_7f1c9fb0e9d8bbf714e27d72e2b97691 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7f1c9fb0e9d8bbf714e27d72e2b97691 obj) { 
  RC_7f1c9fb0e9d8bbf714e27d72e2b97691 s = new RC_7f1c9fb0e9d8bbf714e27d72e2b97691();
  if(obj != null) {
  s.ssSTKeyValue = ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure.ToStructure(obj.AttrKeyValue);
  }
  return s;
}

public static Func<RC_7f1c9fb0e9d8bbf714e27d72e2b97691, ssConectaProveedores.RestRecords.RESTRC_7f1c9fb0e9d8bbf714e27d72e2b97691> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7f1c9fb0e9d8bbf714e27d72e2b97691 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7f1c9fb0e9d8bbf714e27d72e2b97691 FromStructure(RC_7f1c9fb0e9d8bbf714e27d72e2b97691 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7f1c9fb0e9d8bbf714e27d72e2b97691(s, config);
}

}


