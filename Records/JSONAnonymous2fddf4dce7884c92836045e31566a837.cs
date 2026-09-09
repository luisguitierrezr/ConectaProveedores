using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserFolioLogRecord
public class JSONRC_9f9ef21ffaabef46bdddd7ca965685a7 : AbstractRESTStructure<RC_9f9ef21ffaabef46bdddd7ca965685a7> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("FolioLog")]
[JsonPropertyName("FolioLog")]
public ssConectaProveedores.RestRecords.JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord AttrFolioLog;

public JSONRC_9f9ef21ffaabef46bdddd7ca965685a7() { }

public JSONRC_9f9ef21ffaabef46bdddd7ca965685a7 (RC_9f9ef21ffaabef46bdddd7ca965685a7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrFolioLog = ConvertToRestWithoutDefaults(s.ssENFolioLog, new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrFolioLog = ssConectaProveedores.RestRecords.JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.FromStructure(s.ssENFolioLog, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_9f9ef21ffaabef46bdddd7ca965685a7, RC_9f9ef21ffaabef46bdddd7ca965685a7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_9f9ef21ffaabef46bdddd7ca965685a7 s) => ToStructure(s, config);
}
public static RC_9f9ef21ffaabef46bdddd7ca965685a7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_9f9ef21ffaabef46bdddd7ca965685a7 obj, IBehaviorsConfiguration config) { 
  RC_9f9ef21ffaabef46bdddd7ca965685a7 s = new RC_9f9ef21ffaabef46bdddd7ca965685a7();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENFolioLog = ssConectaProveedores.RestRecords.JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.ToStructure(obj.AttrFolioLog, config);
  }
  return s;
}

public static Func<RC_9f9ef21ffaabef46bdddd7ca965685a7, ssConectaProveedores.RestRecords.JSONRC_9f9ef21ffaabef46bdddd7ca965685a7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9f9ef21ffaabef46bdddd7ca965685a7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_9f9ef21ffaabef46bdddd7ca965685a7 FromStructure(RC_9f9ef21ffaabef46bdddd7ca965685a7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_9f9ef21ffaabef46bdddd7ca965685a7(s, config);
}

}


