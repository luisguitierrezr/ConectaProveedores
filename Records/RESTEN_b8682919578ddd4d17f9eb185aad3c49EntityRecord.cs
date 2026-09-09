using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ColumnSettings
public class RESTEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord : AbstractRESTStructure<EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("TableName")]
public string AttrTableName;

[JsonProperty("JSONData")]
public byte[] AttrJSONData;

[JsonProperty("_JSONDataURL")]
public string _JSONDataURL;

[JsonProperty("UserId")]
public string AttrUserId;

public RESTEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord() { }

public RESTEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord (EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
if (!config.IsRESTRequest && config.IncludeBinariesURL && s.ssId != 0) {
if((s.ssId != 0L)) {
_JSONDataURL = BinaryContentUtils.GetDatabaseBinaryRestPath(AppInfo.GetAppInfo().eSpaceName, "6dONWMH_kUW9Ti9X5sMIKA*unRGEm2Bf0ST5hVARClOFQ", "JSONData", s.ssId.ToString(), AppInfo.GetAppInfo().RequestContext.Session.UserId, s.ssJSONData);
}

if (config.OptimizeBinaries) {
s.ssJSONData = config.BinariesUsed.Contains("6dONWMH_kUW9Ti9X5sMIKA*M6gCkW6BYEWGI02g9wkc9Q") ? s.ssJSONData : new byte[] { };
}
}
AttrId = (long?) s.ssId;
AttrTableName = ConvertToRestWithoutDefaults(s.ssTableName, "");
AttrJSONData = ConvertToRestWithoutDefaults(s.ssJSONData);
AttrUserId = ConvertToRestWithoutDefaults(s.ssUserId, "");
  } else {
if (!config.IsRESTRequest && config.IncludeBinariesURL && s.ssId != 0) {
if((s.ssId != 0L)) {
_JSONDataURL = BinaryContentUtils.GetDatabaseBinaryRestPath(AppInfo.GetAppInfo().eSpaceName, "6dONWMH_kUW9Ti9X5sMIKA*unRGEm2Bf0ST5hVARClOFQ", "JSONData", s.ssId.ToString(), AppInfo.GetAppInfo().RequestContext.Session.UserId, s.ssJSONData);
}

if (config.OptimizeBinaries) {
s.ssJSONData = config.BinariesUsed.Contains("6dONWMH_kUW9Ti9X5sMIKA*M6gCkW6BYEWGI02g9wkc9Q") ? s.ssJSONData : new byte[] { };
}
}
AttrId = (long?) s.ssId;
AttrTableName = s.ssTableName;
AttrJSONData = s.ssJSONData;
AttrUserId = s.ssUserId;
  }
}

public static EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord obj) { 
  EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord s = new EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssTableName = obj.AttrTableName == null ? "" : obj.AttrTableName;
  s.ssJSONData = obj.AttrJSONData == null ? new byte[] {} : obj.AttrJSONData;
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  }
  return s;
}

public static Func<EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord, ssConectaProveedores.RestRecords.RESTEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord FromStructure(EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_b8682919578ddd4d17f9eb185aad3c49EntityRecord(s, config);
}

}


