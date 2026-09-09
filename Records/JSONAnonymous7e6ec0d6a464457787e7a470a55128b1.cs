using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserFileImportLogRecord
public class JSONRC_30fde7bd8b6b69ef09faede048f7361d : AbstractRESTStructure<RC_30fde7bd8b6b69ef09faede048f7361d> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("FileImportLog")]
[JsonPropertyName("FileImportLog")]
public ssConectaProveedores.RestRecords.JSONEN_57456f779b1d12573357da68381e59ceEntityRecord AttrFileImportLog;

public JSONRC_30fde7bd8b6b69ef09faede048f7361d() { }

public JSONRC_30fde7bd8b6b69ef09faede048f7361d (RC_30fde7bd8b6b69ef09faede048f7361d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrFileImportLog = ConvertToRestWithoutDefaults(s.ssENFileImportLog, new EN_57456f779b1d12573357da68381e59ceEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_57456f779b1d12573357da68381e59ceEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrFileImportLog = ssConectaProveedores.RestRecords.JSONEN_57456f779b1d12573357da68381e59ceEntityRecord.FromStructure(s.ssENFileImportLog, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_30fde7bd8b6b69ef09faede048f7361d, RC_30fde7bd8b6b69ef09faede048f7361d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_30fde7bd8b6b69ef09faede048f7361d s) => ToStructure(s, config);
}
public static RC_30fde7bd8b6b69ef09faede048f7361d ToStructure(ssConectaProveedores.RestRecords.JSONRC_30fde7bd8b6b69ef09faede048f7361d obj, IBehaviorsConfiguration config) { 
  RC_30fde7bd8b6b69ef09faede048f7361d s = new RC_30fde7bd8b6b69ef09faede048f7361d();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENFileImportLog = ssConectaProveedores.RestRecords.JSONEN_57456f779b1d12573357da68381e59ceEntityRecord.ToStructure(obj.AttrFileImportLog, config);
  }
  return s;
}

public static Func<RC_30fde7bd8b6b69ef09faede048f7361d, ssConectaProveedores.RestRecords.JSONRC_30fde7bd8b6b69ef09faede048f7361d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_30fde7bd8b6b69ef09faede048f7361d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_30fde7bd8b6b69ef09faede048f7361d FromStructure(RC_30fde7bd8b6b69ef09faede048f7361d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_30fde7bd8b6b69ef09faede048f7361d(s, config);
}

}


