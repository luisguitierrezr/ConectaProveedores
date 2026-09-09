using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserFolioFolioLogRecord
public class RESTRC_bbf6ac66012cd4c117435ee07fe47293 : AbstractRESTStructure<RC_bbf6ac66012cd4c117435ee07fe47293> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioLog")]
public ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord AttrFolioLog;

public RESTRC_bbf6ac66012cd4c117435ee07fe47293() { }

public RESTRC_bbf6ac66012cd4c117435ee07fe47293 (RC_bbf6ac66012cd4c117435ee07fe47293 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioLog = ConvertToRestWithoutDefaults(s.ssENFolioLog, new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioLog = ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.FromStructure(s.ssENFolioLog, config);
  }
}

public static RC_bbf6ac66012cd4c117435ee07fe47293 ToStructure(ssConectaProveedores.RestRecords.RESTRC_bbf6ac66012cd4c117435ee07fe47293 obj) { 
  RC_bbf6ac66012cd4c117435ee07fe47293 s = new RC_bbf6ac66012cd4c117435ee07fe47293();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENFolioLog = ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.ToStructure(obj.AttrFolioLog);
  }
  return s;
}

public static Func<RC_bbf6ac66012cd4c117435ee07fe47293, ssConectaProveedores.RestRecords.RESTRC_bbf6ac66012cd4c117435ee07fe47293> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bbf6ac66012cd4c117435ee07fe47293 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_bbf6ac66012cd4c117435ee07fe47293 FromStructure(RC_bbf6ac66012cd4c117435ee07fe47293 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_bbf6ac66012cd4c117435ee07fe47293(s, config);
}

}


