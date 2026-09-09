using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FileImportLogRecord
public class RESTRC_1d614602032ba1d6426327cab15c1a37 : AbstractRESTStructure<RC_1d614602032ba1d6426327cab15c1a37> {
[JsonProperty("FileImportLog")]
public ssConectaProveedores.RestRecords.RESTEN_57456f779b1d12573357da68381e59ceEntityRecord AttrFileImportLog;

public RESTRC_1d614602032ba1d6426327cab15c1a37() { }

public RESTRC_1d614602032ba1d6426327cab15c1a37 (RC_1d614602032ba1d6426327cab15c1a37 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFileImportLog = ConvertToRestWithoutDefaults(s.ssENFileImportLog, new EN_57456f779b1d12573357da68381e59ceEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_57456f779b1d12573357da68381e59ceEntityRecord.FromStructure, config);
  } else {
AttrFileImportLog = ssConectaProveedores.RestRecords.RESTEN_57456f779b1d12573357da68381e59ceEntityRecord.FromStructure(s.ssENFileImportLog, config);
  }
}

public static RC_1d614602032ba1d6426327cab15c1a37 ToStructure(ssConectaProveedores.RestRecords.RESTRC_1d614602032ba1d6426327cab15c1a37 obj) { 
  RC_1d614602032ba1d6426327cab15c1a37 s = new RC_1d614602032ba1d6426327cab15c1a37();
  if(obj != null) {
  s.ssENFileImportLog = ssConectaProveedores.RestRecords.RESTEN_57456f779b1d12573357da68381e59ceEntityRecord.ToStructure(obj.AttrFileImportLog);
  }
  return s;
}

public static Func<RC_1d614602032ba1d6426327cab15c1a37, ssConectaProveedores.RestRecords.RESTRC_1d614602032ba1d6426327cab15c1a37> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1d614602032ba1d6426327cab15c1a37 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1d614602032ba1d6426327cab15c1a37 FromStructure(RC_1d614602032ba1d6426327cab15c1a37 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1d614602032ba1d6426327cab15c1a37(s, config);
}

}


