using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NotificationContentStructRecord
public class JSONRC_816307516ffd7bb138a54e5a7369bd0c : AbstractRESTStructure<RC_816307516ffd7bb138a54e5a7369bd0c> {
[JsonProperty("NotificationContentStruct")]
[JsonPropertyName("NotificationContentStruct")]
public ssConectaProveedores.RestRecords.JSONST_6ac87b97c676cd17082ba2063283d4baStructure AttrNotificationContentStruct;

public JSONRC_816307516ffd7bb138a54e5a7369bd0c() { }

public JSONRC_816307516ffd7bb138a54e5a7369bd0c (RC_816307516ffd7bb138a54e5a7369bd0c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNotificationContentStruct = ConvertToRestWithoutDefaults(s.ssSTNotificationContentStruct, new ST_6ac87b97c676cd17082ba2063283d4baStructure(), ssConectaProveedores.RestRecords.JSONST_6ac87b97c676cd17082ba2063283d4baStructure.FromStructure, config);
  } else {
AttrNotificationContentStruct = ssConectaProveedores.RestRecords.JSONST_6ac87b97c676cd17082ba2063283d4baStructure.FromStructure(s.ssSTNotificationContentStruct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_816307516ffd7bb138a54e5a7369bd0c, RC_816307516ffd7bb138a54e5a7369bd0c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_816307516ffd7bb138a54e5a7369bd0c s) => ToStructure(s, config);
}
public static RC_816307516ffd7bb138a54e5a7369bd0c ToStructure(ssConectaProveedores.RestRecords.JSONRC_816307516ffd7bb138a54e5a7369bd0c obj, IBehaviorsConfiguration config) { 
  RC_816307516ffd7bb138a54e5a7369bd0c s = new RC_816307516ffd7bb138a54e5a7369bd0c();
  if(obj != null) {
  s.ssSTNotificationContentStruct = ssConectaProveedores.RestRecords.JSONST_6ac87b97c676cd17082ba2063283d4baStructure.ToStructure(obj.AttrNotificationContentStruct, config);
  }
  return s;
}

public static Func<RC_816307516ffd7bb138a54e5a7369bd0c, ssConectaProveedores.RestRecords.JSONRC_816307516ffd7bb138a54e5a7369bd0c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_816307516ffd7bb138a54e5a7369bd0c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_816307516ffd7bb138a54e5a7369bd0c FromStructure(RC_816307516ffd7bb138a54e5a7369bd0c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_816307516ffd7bb138a54e5a7369bd0c(s, config);
}

}


