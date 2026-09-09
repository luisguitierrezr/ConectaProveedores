using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioLogRecord
public class JSONRC_d1c5afe2a83250ad8e254ef5d2a29b01 : AbstractRESTStructure<RC_d1c5afe2a83250ad8e254ef5d2a29b01> {
[JsonProperty("FolioLog")]
[JsonPropertyName("FolioLog")]
public ssConectaProveedores.RestRecords.JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord AttrFolioLog;

public JSONRC_d1c5afe2a83250ad8e254ef5d2a29b01() { }

public JSONRC_d1c5afe2a83250ad8e254ef5d2a29b01 (RC_d1c5afe2a83250ad8e254ef5d2a29b01 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioLog = ConvertToRestWithoutDefaults(s.ssENFolioLog, new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.FromStructure, config);
  } else {
AttrFolioLog = ssConectaProveedores.RestRecords.JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.FromStructure(s.ssENFolioLog, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d1c5afe2a83250ad8e254ef5d2a29b01, RC_d1c5afe2a83250ad8e254ef5d2a29b01> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d1c5afe2a83250ad8e254ef5d2a29b01 s) => ToStructure(s, config);
}
public static RC_d1c5afe2a83250ad8e254ef5d2a29b01 ToStructure(ssConectaProveedores.RestRecords.JSONRC_d1c5afe2a83250ad8e254ef5d2a29b01 obj, IBehaviorsConfiguration config) { 
  RC_d1c5afe2a83250ad8e254ef5d2a29b01 s = new RC_d1c5afe2a83250ad8e254ef5d2a29b01();
  if(obj != null) {
  s.ssENFolioLog = ssConectaProveedores.RestRecords.JSONEN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord.ToStructure(obj.AttrFolioLog, config);
  }
  return s;
}

public static Func<RC_d1c5afe2a83250ad8e254ef5d2a29b01, ssConectaProveedores.RestRecords.JSONRC_d1c5afe2a83250ad8e254ef5d2a29b01> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d1c5afe2a83250ad8e254ef5d2a29b01 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d1c5afe2a83250ad8e254ef5d2a29b01 FromStructure(RC_d1c5afe2a83250ad8e254ef5d2a29b01 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d1c5afe2a83250ad8e254ef5d2a29b01(s, config);
}

}


