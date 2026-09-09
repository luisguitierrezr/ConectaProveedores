using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileCommentRecord
public class JSONRC_003b51eef272cce91f55924f504b1b11 : AbstractRESTStructure<RC_003b51eef272cce91f55924f504b1b11> {
[JsonProperty("OrderRequestFileComment")]
[JsonPropertyName("OrderRequestFileComment")]
public ssConectaProveedores.RestRecords.JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord AttrOrderRequestFileComment;

public JSONRC_003b51eef272cce91f55924f504b1b11() { }

public JSONRC_003b51eef272cce91f55924f504b1b11 (RC_003b51eef272cce91f55924f504b1b11 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFileComment = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileComment, new EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord.FromStructure, config);
  } else {
AttrOrderRequestFileComment = ssConectaProveedores.RestRecords.JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord.FromStructure(s.ssENOrderRequestFileComment, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_003b51eef272cce91f55924f504b1b11, RC_003b51eef272cce91f55924f504b1b11> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_003b51eef272cce91f55924f504b1b11 s) => ToStructure(s, config);
}
public static RC_003b51eef272cce91f55924f504b1b11 ToStructure(ssConectaProveedores.RestRecords.JSONRC_003b51eef272cce91f55924f504b1b11 obj, IBehaviorsConfiguration config) { 
  RC_003b51eef272cce91f55924f504b1b11 s = new RC_003b51eef272cce91f55924f504b1b11();
  if(obj != null) {
  s.ssENOrderRequestFileComment = ssConectaProveedores.RestRecords.JSONEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord.ToStructure(obj.AttrOrderRequestFileComment, config);
  }
  return s;
}

public static Func<RC_003b51eef272cce91f55924f504b1b11, ssConectaProveedores.RestRecords.JSONRC_003b51eef272cce91f55924f504b1b11> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_003b51eef272cce91f55924f504b1b11 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_003b51eef272cce91f55924f504b1b11 FromStructure(RC_003b51eef272cce91f55924f504b1b11 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_003b51eef272cce91f55924f504b1b11(s, config);
}

}


