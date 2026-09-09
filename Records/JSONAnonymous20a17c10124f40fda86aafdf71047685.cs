using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserFolioFolioLogRecord
public class JSONRC_bbf6ac66012cd4c117435ee07fe47293 : AbstractRESTStructure<RC_bbf6ac66012cd4c117435ee07fe47293> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioLog")]
[JsonPropertyName("FolioLog")]
public ssConectaProveedores.RestRecords.JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord AttrFolioLog;

public JSONRC_bbf6ac66012cd4c117435ee07fe47293() { }

public JSONRC_bbf6ac66012cd4c117435ee07fe47293 (RC_bbf6ac66012cd4c117435ee07fe47293 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioLog = ConvertToRestWithoutDefaults(s.ssENFolioLog, new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioLog = ssConectaProveedores.RestRecords.JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.FromStructure(s.ssENFolioLog, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_bbf6ac66012cd4c117435ee07fe47293, RC_bbf6ac66012cd4c117435ee07fe47293> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_bbf6ac66012cd4c117435ee07fe47293 s) => ToStructure(s, config);
}
public static RC_bbf6ac66012cd4c117435ee07fe47293 ToStructure(ssConectaProveedores.RestRecords.JSONRC_bbf6ac66012cd4c117435ee07fe47293 obj, IBehaviorsConfiguration config) { 
  RC_bbf6ac66012cd4c117435ee07fe47293 s = new RC_bbf6ac66012cd4c117435ee07fe47293();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENFolioLog = ssConectaProveedores.RestRecords.JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.ToStructure(obj.AttrFolioLog, config);
  }
  return s;
}

public static Func<RC_bbf6ac66012cd4c117435ee07fe47293, ssConectaProveedores.RestRecords.JSONRC_bbf6ac66012cd4c117435ee07fe47293> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bbf6ac66012cd4c117435ee07fe47293 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_bbf6ac66012cd4c117435ee07fe47293 FromStructure(RC_bbf6ac66012cd4c117435ee07fe47293 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_bbf6ac66012cd4c117435ee07fe47293(s, config);
}

}


