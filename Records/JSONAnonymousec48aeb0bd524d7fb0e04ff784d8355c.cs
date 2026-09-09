using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CommentTypeOrderRequestFileCommentRecord
public class JSONRC_45b72d53609a7a1da4a98878c5ec7590 : AbstractRESTStructure<RC_45b72d53609a7a1da4a98878c5ec7590> {
[JsonProperty("CommentType")]
[JsonPropertyName("CommentType")]
public ssConectaProveedores.RestRecords.JSONEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord AttrCommentType;

[JsonProperty("OrderRequestFileComment")]
[JsonPropertyName("OrderRequestFileComment")]
public ssConectaProveedores.RestRecords.JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord AttrOrderRequestFileComment;

public JSONRC_45b72d53609a7a1da4a98878c5ec7590() { }

public JSONRC_45b72d53609a7a1da4a98878c5ec7590 (RC_45b72d53609a7a1da4a98878c5ec7590 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCommentType = ConvertToRestWithoutDefaults(s.ssENCommentType, new EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.FromStructure, config);
AttrOrderRequestFileComment = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileComment, new EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord.FromStructure, config);
  } else {
AttrCommentType = ssConectaProveedores.RestRecords.JSONEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.FromStructure(s.ssENCommentType, config);
AttrOrderRequestFileComment = ssConectaProveedores.RestRecords.JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord.FromStructure(s.ssENOrderRequestFileComment, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_45b72d53609a7a1da4a98878c5ec7590, RC_45b72d53609a7a1da4a98878c5ec7590> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_45b72d53609a7a1da4a98878c5ec7590 s) => ToStructure(s, config);
}
public static RC_45b72d53609a7a1da4a98878c5ec7590 ToStructure(ssConectaProveedores.RestRecords.JSONRC_45b72d53609a7a1da4a98878c5ec7590 obj, IBehaviorsConfiguration config) { 
  RC_45b72d53609a7a1da4a98878c5ec7590 s = new RC_45b72d53609a7a1da4a98878c5ec7590();
  if(obj != null) {
  s.ssENCommentType = ssConectaProveedores.RestRecords.JSONEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.ToStructure(obj.AttrCommentType, config);
  s.ssENOrderRequestFileComment = ssConectaProveedores.RestRecords.JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord.ToStructure(obj.AttrOrderRequestFileComment, config);
  }
  return s;
}

public static Func<RC_45b72d53609a7a1da4a98878c5ec7590, ssConectaProveedores.RestRecords.JSONRC_45b72d53609a7a1da4a98878c5ec7590> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_45b72d53609a7a1da4a98878c5ec7590 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_45b72d53609a7a1da4a98878c5ec7590 FromStructure(RC_45b72d53609a7a1da4a98878c5ec7590 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_45b72d53609a7a1da4a98878c5ec7590(s, config);
}

}


