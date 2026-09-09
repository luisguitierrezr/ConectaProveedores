using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalCommentFile
public class JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord : AbstractRESTStructure<EN_7db82b55fc996c1dcfda575a9310d307EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("CommentId")]
[JsonPropertyName("CommentId")]
public long? AttrCommentId;

[JsonProperty("Filename")]
[JsonPropertyName("Filename")]
public string AttrFilename;

[JsonProperty("Binary")]
[JsonPropertyName("Binary")]
public byte[] AttrBinary;

[JsonProperty("_BinaryURL")]
public string _BinaryURL;

public JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord() { }

public JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord (EN_7db82b55fc996c1dcfda575a9310d307EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
if (!config.IsRESTRequest && config.IncludeBinariesURL && s.ssId != 0) {
if((s.ssId != 0L)) {
_BinaryURL = BinaryContentUtils.GetDatabaseBinaryRestPath(AppInfo.GetAppInfo().eSpaceName, "6dONWMH_kUW9Ti9X5sMIKA*v_SpzTBXxEiueJkFhUJIrQ", "Binary", s.ssId.ToString(), AppInfo.GetAppInfo().RequestContext.Session.UserId, s.ssBinary);
}

if (config.OptimizeBinaries) {
s.ssBinary = config.BinariesUsed.Contains("6dONWMH_kUW9Ti9X5sMIKA*VvUncA+Bh0+FahupO+IR8w") ? s.ssBinary : new byte[] { };
}
}
AttrId = (long?) s.ssId;
AttrCommentId = ConvertToRestWithoutDefaults(s.ssCommentId, 0L);
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrBinary = ConvertToRestWithoutDefaults(s.ssBinary);
  } else {
if (!config.IsRESTRequest && config.IncludeBinariesURL && s.ssId != 0) {
if((s.ssId != 0L)) {
_BinaryURL = BinaryContentUtils.GetDatabaseBinaryRestPath(AppInfo.GetAppInfo().eSpaceName, "6dONWMH_kUW9Ti9X5sMIKA*v_SpzTBXxEiueJkFhUJIrQ", "Binary", s.ssId.ToString(), AppInfo.GetAppInfo().RequestContext.Session.UserId, s.ssBinary);
}

if (config.OptimizeBinaries) {
s.ssBinary = config.BinariesUsed.Contains("6dONWMH_kUW9Ti9X5sMIKA*VvUncA+Bh0+FahupO+IR8w") ? s.ssBinary : new byte[] { };
}
}
AttrId = (long?) s.ssId;
AttrCommentId = (long?) s.ssCommentId;
AttrFilename = s.ssFilename;
AttrBinary = s.ssBinary;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord, EN_7db82b55fc996c1dcfda575a9310d307EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord s) => ToStructure(s, config);
}
public static EN_7db82b55fc996c1dcfda575a9310d307EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_7db82b55fc996c1dcfda575a9310d307EntityRecord s = new EN_7db82b55fc996c1dcfda575a9310d307EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssCommentId = obj.AttrCommentId == null ? 0L : obj.AttrCommentId.Value;
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssBinary = obj.AttrBinary == null ? new byte[] {} : obj.AttrBinary;
  }
  return s;
}

public static Func<EN_7db82b55fc996c1dcfda575a9310d307EntityRecord, ssConectaProveedores.RestRecords.JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7db82b55fc996c1dcfda575a9310d307EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord FromStructure(EN_7db82b55fc996c1dcfda575a9310d307EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord(s, config);
}

}


