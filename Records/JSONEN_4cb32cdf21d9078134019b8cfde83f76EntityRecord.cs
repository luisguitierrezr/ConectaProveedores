using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileComment
public class JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord : AbstractRESTStructure<EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("OrderRequestFileId")]
[JsonPropertyName("OrderRequestFileId")]
public long? AttrOrderRequestFileId;

[JsonProperty("CommentTypeId")]
[JsonPropertyName("CommentTypeId")]
public int? AttrCommentTypeId;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

public JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord() { }

public JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord (EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderRequestFileId = ConvertToRestWithoutDefaults(s.ssOrderRequestFileId, 0L);
AttrCommentTypeId = ConvertToRestWithoutDefaults(s.ssCommentTypeId, 0);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrId = (long?) s.ssId;
AttrOrderRequestFileId = (long?) s.ssOrderRequestFileId;
AttrCommentTypeId = (int?) s.ssCommentTypeId;
AttrCreatedBy = s.ssCreatedBy;
AttrMessage = s.ssMessage;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord, EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord s) => ToStructure(s, config);
}
public static EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord s = new EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderRequestFileId = obj.AttrOrderRequestFileId == null ? 0L : obj.AttrOrderRequestFileId.Value;
  s.ssCommentTypeId = obj.AttrCommentTypeId == null ? 0 : obj.AttrCommentTypeId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord, ssConectaProveedores.RestRecords.JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord FromStructure(EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord(s, config);
}

}


