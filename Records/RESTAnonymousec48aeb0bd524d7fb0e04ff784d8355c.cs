using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CommentTypeOrderRequestFileCommentRecord
public class RESTRC_45b72d53609a7a1da4a98878c5ec7590 : AbstractRESTStructure<RC_45b72d53609a7a1da4a98878c5ec7590> {
[JsonProperty("CommentType")]
public ssConectaProveedores.RestRecords.RESTEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord AttrCommentType;

[JsonProperty("OrderRequestFileComment")]
public ssConectaProveedores.RestRecords.RESTEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord AttrOrderRequestFileComment;

public RESTRC_45b72d53609a7a1da4a98878c5ec7590() { }

public RESTRC_45b72d53609a7a1da4a98878c5ec7590 (RC_45b72d53609a7a1da4a98878c5ec7590 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCommentType = ConvertToRestWithoutDefaults(s.ssENCommentType, new EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.FromStructure, config);
AttrOrderRequestFileComment = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileComment, new EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord.FromStructure, config);
  } else {
AttrCommentType = ssConectaProveedores.RestRecords.RESTEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.FromStructure(s.ssENCommentType, config);
AttrOrderRequestFileComment = ssConectaProveedores.RestRecords.RESTEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord.FromStructure(s.ssENOrderRequestFileComment, config);
  }
}

public static RC_45b72d53609a7a1da4a98878c5ec7590 ToStructure(ssConectaProveedores.RestRecords.RESTRC_45b72d53609a7a1da4a98878c5ec7590 obj) { 
  RC_45b72d53609a7a1da4a98878c5ec7590 s = new RC_45b72d53609a7a1da4a98878c5ec7590();
  if(obj != null) {
  s.ssENCommentType = ssConectaProveedores.RestRecords.RESTEN_4a2f5f1859128b4b2b0510202ed51258EntityRecord.ToStructure(obj.AttrCommentType);
  s.ssENOrderRequestFileComment = ssConectaProveedores.RestRecords.RESTEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord.ToStructure(obj.AttrOrderRequestFileComment);
  }
  return s;
}

public static Func<RC_45b72d53609a7a1da4a98878c5ec7590, ssConectaProveedores.RestRecords.RESTRC_45b72d53609a7a1da4a98878c5ec7590> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_45b72d53609a7a1da4a98878c5ec7590 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_45b72d53609a7a1da4a98878c5ec7590 FromStructure(RC_45b72d53609a7a1da4a98878c5ec7590 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_45b72d53609a7a1da4a98878c5ec7590(s, config);
}

}


