using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderCommentRecord
public class RESTRC_cd61721ee82121e78e4055ba4deb1fa6 : AbstractRESTStructure<RC_cd61721ee82121e78e4055ba4deb1fa6> {
[JsonProperty("OrderComment")]
public ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord AttrOrderComment;

public RESTRC_cd61721ee82121e78e4055ba4deb1fa6() { }

public RESTRC_cd61721ee82121e78e4055ba4deb1fa6 (RC_cd61721ee82121e78e4055ba4deb1fa6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderComment = ConvertToRestWithoutDefaults(s.ssENOrderComment, new EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.FromStructure, config);
  } else {
AttrOrderComment = ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.FromStructure(s.ssENOrderComment, config);
  }
}

public static RC_cd61721ee82121e78e4055ba4deb1fa6 ToStructure(ssConectaProveedores.RestRecords.RESTRC_cd61721ee82121e78e4055ba4deb1fa6 obj) { 
  RC_cd61721ee82121e78e4055ba4deb1fa6 s = new RC_cd61721ee82121e78e4055ba4deb1fa6();
  if(obj != null) {
  s.ssENOrderComment = ssConectaProveedores.RestRecords.RESTEN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord.ToStructure(obj.AttrOrderComment);
  }
  return s;
}

public static Func<RC_cd61721ee82121e78e4055ba4deb1fa6, ssConectaProveedores.RestRecords.RESTRC_cd61721ee82121e78e4055ba4deb1fa6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cd61721ee82121e78e4055ba4deb1fa6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_cd61721ee82121e78e4055ba4deb1fa6 FromStructure(RC_cd61721ee82121e78e4055ba4deb1fa6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_cd61721ee82121e78e4055ba4deb1fa6(s, config);
}

}


