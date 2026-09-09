using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NotificationContentStructRecord
public class RESTRC_816307516ffd7bb138a54e5a7369bd0c : AbstractRESTStructure<RC_816307516ffd7bb138a54e5a7369bd0c> {
[JsonProperty("NotificationContentStruct")]
public ssConectaProveedores.RestRecords.RESTST_6ac87b97c676cd17082ba2063283d4baStructure AttrNotificationContentStruct;

public RESTRC_816307516ffd7bb138a54e5a7369bd0c() { }

public RESTRC_816307516ffd7bb138a54e5a7369bd0c (RC_816307516ffd7bb138a54e5a7369bd0c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNotificationContentStruct = ConvertToRestWithoutDefaults(s.ssSTNotificationContentStruct, new ST_6ac87b97c676cd17082ba2063283d4baStructure(), ssConectaProveedores.RestRecords.RESTST_6ac87b97c676cd17082ba2063283d4baStructure.FromStructure, config);
  } else {
AttrNotificationContentStruct = ssConectaProveedores.RestRecords.RESTST_6ac87b97c676cd17082ba2063283d4baStructure.FromStructure(s.ssSTNotificationContentStruct, config);
  }
}

public static RC_816307516ffd7bb138a54e5a7369bd0c ToStructure(ssConectaProveedores.RestRecords.RESTRC_816307516ffd7bb138a54e5a7369bd0c obj) { 
  RC_816307516ffd7bb138a54e5a7369bd0c s = new RC_816307516ffd7bb138a54e5a7369bd0c();
  if(obj != null) {
  s.ssSTNotificationContentStruct = ssConectaProveedores.RestRecords.RESTST_6ac87b97c676cd17082ba2063283d4baStructure.ToStructure(obj.AttrNotificationContentStruct);
  }
  return s;
}

public static Func<RC_816307516ffd7bb138a54e5a7369bd0c, ssConectaProveedores.RestRecords.RESTRC_816307516ffd7bb138a54e5a7369bd0c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_816307516ffd7bb138a54e5a7369bd0c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_816307516ffd7bb138a54e5a7369bd0c FromStructure(RC_816307516ffd7bb138a54e5a7369bd0c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_816307516ffd7bb138a54e5a7369bd0c(s, config);
}

}


