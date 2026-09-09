using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FileImportLogRecord
public class JSONRC_1d614602032ba1d6426327cab15c1a37 : AbstractRESTStructure<RC_1d614602032ba1d6426327cab15c1a37> {
[JsonProperty("FileImportLog")]
[JsonPropertyName("FileImportLog")]
public ssConectaProveedores.RestRecords.JSONEN_57456f779b1d12573357da68381e59ceEntityRecord AttrFileImportLog;

public JSONRC_1d614602032ba1d6426327cab15c1a37() { }

public JSONRC_1d614602032ba1d6426327cab15c1a37 (RC_1d614602032ba1d6426327cab15c1a37 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFileImportLog = ConvertToRestWithoutDefaults(s.ssENFileImportLog, new EN_57456f779b1d12573357da68381e59ceEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_57456f779b1d12573357da68381e59ceEntityRecord.FromStructure, config);
  } else {
AttrFileImportLog = ssConectaProveedores.RestRecords.JSONEN_57456f779b1d12573357da68381e59ceEntityRecord.FromStructure(s.ssENFileImportLog, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1d614602032ba1d6426327cab15c1a37, RC_1d614602032ba1d6426327cab15c1a37> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1d614602032ba1d6426327cab15c1a37 s) => ToStructure(s, config);
}
public static RC_1d614602032ba1d6426327cab15c1a37 ToStructure(ssConectaProveedores.RestRecords.JSONRC_1d614602032ba1d6426327cab15c1a37 obj, IBehaviorsConfiguration config) { 
  RC_1d614602032ba1d6426327cab15c1a37 s = new RC_1d614602032ba1d6426327cab15c1a37();
  if(obj != null) {
  s.ssENFileImportLog = ssConectaProveedores.RestRecords.JSONEN_57456f779b1d12573357da68381e59ceEntityRecord.ToStructure(obj.AttrFileImportLog, config);
  }
  return s;
}

public static Func<RC_1d614602032ba1d6426327cab15c1a37, ssConectaProveedores.RestRecords.JSONRC_1d614602032ba1d6426327cab15c1a37> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1d614602032ba1d6426327cab15c1a37 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1d614602032ba1d6426327cab15c1a37 FromStructure(RC_1d614602032ba1d6426327cab15c1a37 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1d614602032ba1d6426327cab15c1a37(s, config);
}

}


