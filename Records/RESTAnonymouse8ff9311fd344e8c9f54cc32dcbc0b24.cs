using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NotificationErrorStructRecord
public class RESTRC_af7f929096d90ec76642e03604dc9f51 : AbstractRESTStructure<RC_af7f929096d90ec76642e03604dc9f51> {
[JsonProperty("NotificationErrorStruct")]
public ssConectaProveedores.RestRecords.RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure AttrNotificationErrorStruct;

public RESTRC_af7f929096d90ec76642e03604dc9f51() { }

public RESTRC_af7f929096d90ec76642e03604dc9f51 (RC_af7f929096d90ec76642e03604dc9f51 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNotificationErrorStruct = ConvertToRestWithoutDefaults(s.ssSTNotificationErrorStruct, new ST_bb4ffb4d3263f72e713312025a0e6fc7Structure(), ssConectaProveedores.RestRecords.RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure.FromStructure, config);
  } else {
AttrNotificationErrorStruct = ssConectaProveedores.RestRecords.RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure.FromStructure(s.ssSTNotificationErrorStruct, config);
  }
}

public static RC_af7f929096d90ec76642e03604dc9f51 ToStructure(ssConectaProveedores.RestRecords.RESTRC_af7f929096d90ec76642e03604dc9f51 obj) { 
  RC_af7f929096d90ec76642e03604dc9f51 s = new RC_af7f929096d90ec76642e03604dc9f51();
  if(obj != null) {
  s.ssSTNotificationErrorStruct = ssConectaProveedores.RestRecords.RESTST_bb4ffb4d3263f72e713312025a0e6fc7Structure.ToStructure(obj.AttrNotificationErrorStruct);
  }
  return s;
}

public static Func<RC_af7f929096d90ec76642e03604dc9f51, ssConectaProveedores.RestRecords.RESTRC_af7f929096d90ec76642e03604dc9f51> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_af7f929096d90ec76642e03604dc9f51 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_af7f929096d90ec76642e03604dc9f51 FromStructure(RC_af7f929096d90ec76642e03604dc9f51 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_af7f929096d90ec76642e03604dc9f51(s, config);
}

}


