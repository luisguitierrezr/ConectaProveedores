using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ReassignNotificationContentRecord
public class RESTRC_375b15daf8a41c077766480dd582bf2b : AbstractRESTStructure<RC_375b15daf8a41c077766480dd582bf2b> {
[JsonProperty("ReassignNotificationContent")]
public ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure AttrReassignNotificationContent;

public RESTRC_375b15daf8a41c077766480dd582bf2b() { }

public RESTRC_375b15daf8a41c077766480dd582bf2b (RC_375b15daf8a41c077766480dd582bf2b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrReassignNotificationContent = ConvertToRestWithoutDefaults(s.ssSTReassignNotificationContent, new ST_6fc999fa8f6e0055c73f2f167c4bad19Structure(), ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure.FromStructure, config);
  } else {
AttrReassignNotificationContent = ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure.FromStructure(s.ssSTReassignNotificationContent, config);
  }
}

public static RC_375b15daf8a41c077766480dd582bf2b ToStructure(ssConectaProveedores.RestRecords.RESTRC_375b15daf8a41c077766480dd582bf2b obj) { 
  RC_375b15daf8a41c077766480dd582bf2b s = new RC_375b15daf8a41c077766480dd582bf2b();
  if(obj != null) {
  s.ssSTReassignNotificationContent = ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure.ToStructure(obj.AttrReassignNotificationContent);
  }
  return s;
}

public static Func<RC_375b15daf8a41c077766480dd582bf2b, ssConectaProveedores.RestRecords.RESTRC_375b15daf8a41c077766480dd582bf2b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_375b15daf8a41c077766480dd582bf2b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_375b15daf8a41c077766480dd582bf2b FromStructure(RC_375b15daf8a41c077766480dd582bf2b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_375b15daf8a41c077766480dd582bf2b(s, config);
}

}


