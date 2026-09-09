using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileCommentRecord
public class RESTRC_003b51eef272cce91f55924f504b1b11 : AbstractRESTStructure<RC_003b51eef272cce91f55924f504b1b11> {
[JsonProperty("OrderRequestFileComment")]
public ssConectaProveedores.RestRecords.RESTEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord AttrOrderRequestFileComment;

public RESTRC_003b51eef272cce91f55924f504b1b11() { }

public RESTRC_003b51eef272cce91f55924f504b1b11 (RC_003b51eef272cce91f55924f504b1b11 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFileComment = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileComment, new EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord.FromStructure, config);
  } else {
AttrOrderRequestFileComment = ssConectaProveedores.RestRecords.RESTEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord.FromStructure(s.ssENOrderRequestFileComment, config);
  }
}

public static RC_003b51eef272cce91f55924f504b1b11 ToStructure(ssConectaProveedores.RestRecords.RESTRC_003b51eef272cce91f55924f504b1b11 obj) { 
  RC_003b51eef272cce91f55924f504b1b11 s = new RC_003b51eef272cce91f55924f504b1b11();
  if(obj != null) {
  s.ssENOrderRequestFileComment = ssConectaProveedores.RestRecords.RESTEN_4cb32cdf21d9078134019b8cfde83f76EntityRecord.ToStructure(obj.AttrOrderRequestFileComment);
  }
  return s;
}

public static Func<RC_003b51eef272cce91f55924f504b1b11, ssConectaProveedores.RestRecords.RESTRC_003b51eef272cce91f55924f504b1b11> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_003b51eef272cce91f55924f504b1b11 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_003b51eef272cce91f55924f504b1b11 FromStructure(RC_003b51eef272cce91f55924f504b1b11 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_003b51eef272cce91f55924f504b1b11(s, config);
}

}


