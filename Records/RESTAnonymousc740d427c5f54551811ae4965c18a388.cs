using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserDetailRecord
public class RESTRC_9282d2ea82843f3ec15beba5c474f7e7 : AbstractRESTStructure<RC_9282d2ea82843f3ec15beba5c474f7e7> {
[JsonProperty("UserDetail")]
public ssConectaProveedores.RestRecords.RESTST_3d98fcbf952bf72084dad4104cc8c43fStructure AttrUserDetail;

public RESTRC_9282d2ea82843f3ec15beba5c474f7e7() { }

public RESTRC_9282d2ea82843f3ec15beba5c474f7e7 (RC_9282d2ea82843f3ec15beba5c474f7e7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserDetail = ConvertToRestWithoutDefaults(s.ssSTUserDetail, new ST_3d98fcbf952bf72084dad4104cc8c43fStructure(), ssConectaProveedores.RestRecords.RESTST_3d98fcbf952bf72084dad4104cc8c43fStructure.FromStructure, config);
  } else {
AttrUserDetail = ssConectaProveedores.RestRecords.RESTST_3d98fcbf952bf72084dad4104cc8c43fStructure.FromStructure(s.ssSTUserDetail, config);
  }
}

public static RC_9282d2ea82843f3ec15beba5c474f7e7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_9282d2ea82843f3ec15beba5c474f7e7 obj) { 
  RC_9282d2ea82843f3ec15beba5c474f7e7 s = new RC_9282d2ea82843f3ec15beba5c474f7e7();
  if(obj != null) {
  s.ssSTUserDetail = ssConectaProveedores.RestRecords.RESTST_3d98fcbf952bf72084dad4104cc8c43fStructure.ToStructure(obj.AttrUserDetail);
  }
  return s;
}

public static Func<RC_9282d2ea82843f3ec15beba5c474f7e7, ssConectaProveedores.RestRecords.RESTRC_9282d2ea82843f3ec15beba5c474f7e7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9282d2ea82843f3ec15beba5c474f7e7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9282d2ea82843f3ec15beba5c474f7e7 FromStructure(RC_9282d2ea82843f3ec15beba5c474f7e7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9282d2ea82843f3ec15beba5c474f7e7(s, config);
}

}


