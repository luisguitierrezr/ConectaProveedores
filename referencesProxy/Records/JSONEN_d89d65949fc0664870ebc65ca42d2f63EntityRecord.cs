using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ManualFile
public class JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord : AbstractRESTStructure<EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Filename")]
[JsonPropertyName("Filename")]
public string AttrFilename;

[JsonProperty("File")]
[JsonPropertyName("File")]
public byte[] AttrFile;

[JsonProperty("_FileURL")]
public string _FileURL;

[JsonProperty("VideoLink")]
[JsonPropertyName("VideoLink")]
public string AttrVideoLink;

public JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord() { }

public JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord (EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
if (!config.IsRESTRequest && config.IncludeBinariesURL && s.ssId != 0) {
if((s.ssId != 0L)) {
_FileURL = BinaryContentUtils.GetDatabaseBinaryRestPath(AppInfo.GetAppInfo().eSpaceName, "z+Hr3img9k6c__DgH+2OBw*pXgAFsf0cEybJIcgXrwPqQ", "File", s.ssId.ToString(), AppInfo.GetAppInfo().RequestContext.Session.UserId, s.ssFile);
}

if (config.OptimizeBinaries) {
s.ssFile = config.BinariesUsed.Contains("z+Hr3img9k6c__DgH+2OBw*VDGRDQQiqkqTlAP6HdCOlA") ? s.ssFile : new byte[] { };
}
}
AttrId = (long?) s.ssId;
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrFile = ConvertToRestWithoutDefaults(s.ssFile);
AttrVideoLink = ConvertToRestWithoutDefaults(s.ssVideoLink, "");
  } else {
if (!config.IsRESTRequest && config.IncludeBinariesURL && s.ssId != 0) {
if((s.ssId != 0L)) {
_FileURL = BinaryContentUtils.GetDatabaseBinaryRestPath(AppInfo.GetAppInfo().eSpaceName, "z+Hr3img9k6c__DgH+2OBw*pXgAFsf0cEybJIcgXrwPqQ", "File", s.ssId.ToString(), AppInfo.GetAppInfo().RequestContext.Session.UserId, s.ssFile);
}

if (config.OptimizeBinaries) {
s.ssFile = config.BinariesUsed.Contains("z+Hr3img9k6c__DgH+2OBw*VDGRDQQiqkqTlAP6HdCOlA") ? s.ssFile : new byte[] { };
}
}
AttrId = (long?) s.ssId;
AttrFilename = s.ssFilename;
AttrFile = s.ssFile;
AttrVideoLink = s.ssVideoLink;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord, EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord s) => ToStructure(s, config);
}
public static EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord s = new EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssFile = obj.AttrFile == null ? new byte[] {} : obj.AttrFile;
  s.ssVideoLink = obj.AttrVideoLink == null ? "" : obj.AttrVideoLink;
  }
  return s;
}

public static Func<EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord FromStructure(EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d89d65949fc0664870ebc65ca42d2f63EntityRecord(s, config);
}

}


