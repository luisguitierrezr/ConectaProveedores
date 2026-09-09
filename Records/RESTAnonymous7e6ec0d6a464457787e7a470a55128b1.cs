using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserFileImportLogRecord
public class RESTRC_30fde7bd8b6b69ef09faede048f7361d : AbstractRESTStructure<RC_30fde7bd8b6b69ef09faede048f7361d> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("FileImportLog")]
public ssConectaProveedores.RestRecords.RESTEN_57456f779b1d12573357da68381e59ceEntityRecord AttrFileImportLog;

public RESTRC_30fde7bd8b6b69ef09faede048f7361d() { }

public RESTRC_30fde7bd8b6b69ef09faede048f7361d (RC_30fde7bd8b6b69ef09faede048f7361d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrFileImportLog = ConvertToRestWithoutDefaults(s.ssENFileImportLog, new EN_57456f779b1d12573357da68381e59ceEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_57456f779b1d12573357da68381e59ceEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrFileImportLog = ssConectaProveedores.RestRecords.RESTEN_57456f779b1d12573357da68381e59ceEntityRecord.FromStructure(s.ssENFileImportLog, config);
  }
}

public static RC_30fde7bd8b6b69ef09faede048f7361d ToStructure(ssConectaProveedores.RestRecords.RESTRC_30fde7bd8b6b69ef09faede048f7361d obj) { 
  RC_30fde7bd8b6b69ef09faede048f7361d s = new RC_30fde7bd8b6b69ef09faede048f7361d();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENFileImportLog = ssConectaProveedores.RestRecords.RESTEN_57456f779b1d12573357da68381e59ceEntityRecord.ToStructure(obj.AttrFileImportLog);
  }
  return s;
}

public static Func<RC_30fde7bd8b6b69ef09faede048f7361d, ssConectaProveedores.RestRecords.RESTRC_30fde7bd8b6b69ef09faede048f7361d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_30fde7bd8b6b69ef09faede048f7361d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_30fde7bd8b6b69ef09faede048f7361d FromStructure(RC_30fde7bd8b6b69ef09faede048f7361d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_30fde7bd8b6b69ef09faede048f7361d(s, config);
}

}


