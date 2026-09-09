using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioLogRecord
public class RESTRC_d1c5afe2a83250ad8e254ef5d2a29b01 : AbstractRESTStructure<RC_d1c5afe2a83250ad8e254ef5d2a29b01> {
[JsonProperty("FolioLog")]
public ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord AttrFolioLog;

public RESTRC_d1c5afe2a83250ad8e254ef5d2a29b01() { }

public RESTRC_d1c5afe2a83250ad8e254ef5d2a29b01 (RC_d1c5afe2a83250ad8e254ef5d2a29b01 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioLog = ConvertToRestWithoutDefaults(s.ssENFolioLog, new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.FromStructure, config);
  } else {
AttrFolioLog = ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.FromStructure(s.ssENFolioLog, config);
  }
}

public static RC_d1c5afe2a83250ad8e254ef5d2a29b01 ToStructure(ssConectaProveedores.RestRecords.RESTRC_d1c5afe2a83250ad8e254ef5d2a29b01 obj) { 
  RC_d1c5afe2a83250ad8e254ef5d2a29b01 s = new RC_d1c5afe2a83250ad8e254ef5d2a29b01();
  if(obj != null) {
  s.ssENFolioLog = ssConectaProveedores.RestRecords.RESTEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.ToStructure(obj.AttrFolioLog);
  }
  return s;
}

public static Func<RC_d1c5afe2a83250ad8e254ef5d2a29b01, ssConectaProveedores.RestRecords.RESTRC_d1c5afe2a83250ad8e254ef5d2a29b01> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d1c5afe2a83250ad8e254ef5d2a29b01 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d1c5afe2a83250ad8e254ef5d2a29b01 FromStructure(RC_d1c5afe2a83250ad8e254ef5d2a29b01 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d1c5afe2a83250ad8e254ef5d2a29b01(s, config);
}

}


