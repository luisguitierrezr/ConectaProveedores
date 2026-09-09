using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserFolioLogRecord
public class RESTRC_9f9ef21ffaabef46bdddd7ca965685a7 : AbstractRESTStructure<RC_9f9ef21ffaabef46bdddd7ca965685a7> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("FolioLog")]
public ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord AttrFolioLog;

public RESTRC_9f9ef21ffaabef46bdddd7ca965685a7() { }

public RESTRC_9f9ef21ffaabef46bdddd7ca965685a7 (RC_9f9ef21ffaabef46bdddd7ca965685a7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrFolioLog = ConvertToRestWithoutDefaults(s.ssENFolioLog, new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrFolioLog = ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.FromStructure(s.ssENFolioLog, config);
  }
}

public static RC_9f9ef21ffaabef46bdddd7ca965685a7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_9f9ef21ffaabef46bdddd7ca965685a7 obj) { 
  RC_9f9ef21ffaabef46bdddd7ca965685a7 s = new RC_9f9ef21ffaabef46bdddd7ca965685a7();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENFolioLog = ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.ToStructure(obj.AttrFolioLog);
  }
  return s;
}

public static Func<RC_9f9ef21ffaabef46bdddd7ca965685a7, ssConectaProveedores.RestRecords.RESTRC_9f9ef21ffaabef46bdddd7ca965685a7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9f9ef21ffaabef46bdddd7ca965685a7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9f9ef21ffaabef46bdddd7ca965685a7 FromStructure(RC_9f9ef21ffaabef46bdddd7ca965685a7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9f9ef21ffaabef46bdddd7ca965685a7(s, config);
}

}


