using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NotificationOutput2Record
public class JSONRC_829bb09686291c68d484c26edaf70252 : AbstractRESTStructure<RC_829bb09686291c68d484c26edaf70252> {
[JsonProperty("NotificationOutput2")]
[JsonPropertyName("NotificationOutput2")]
public ssConectaProveedores.RestRecords.JSONST_968b59b0d969f443f958cd852a31dcb5Structure AttrNotificationOutput2;

public JSONRC_829bb09686291c68d484c26edaf70252() { }

public JSONRC_829bb09686291c68d484c26edaf70252 (RC_829bb09686291c68d484c26edaf70252 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNotificationOutput2 = ConvertToRestWithoutDefaults(s.ssSTNotificationOutput2, new ST_968b59b0d969f443f958cd852a31dcb5Structure(), ssConectaProveedores.RestRecords.JSONST_968b59b0d969f443f958cd852a31dcb5Structure.FromStructure, config);
  } else {
AttrNotificationOutput2 = ssConectaProveedores.RestRecords.JSONST_968b59b0d969f443f958cd852a31dcb5Structure.FromStructure(s.ssSTNotificationOutput2, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_829bb09686291c68d484c26edaf70252, RC_829bb09686291c68d484c26edaf70252> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_829bb09686291c68d484c26edaf70252 s) => ToStructure(s, config);
}
public static RC_829bb09686291c68d484c26edaf70252 ToStructure(ssConectaProveedores.RestRecords.JSONRC_829bb09686291c68d484c26edaf70252 obj, IBehaviorsConfiguration config) { 
  RC_829bb09686291c68d484c26edaf70252 s = new RC_829bb09686291c68d484c26edaf70252();
  if(obj != null) {
  s.ssSTNotificationOutput2 = ssConectaProveedores.RestRecords.JSONST_968b59b0d969f443f958cd852a31dcb5Structure.ToStructure(obj.AttrNotificationOutput2, config);
  }
  return s;
}

public static Func<RC_829bb09686291c68d484c26edaf70252, ssConectaProveedores.RestRecords.JSONRC_829bb09686291c68d484c26edaf70252> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_829bb09686291c68d484c26edaf70252 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_829bb09686291c68d484c26edaf70252 FromStructure(RC_829bb09686291c68d484c26edaf70252 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_829bb09686291c68d484c26edaf70252(s, config);
}

}


