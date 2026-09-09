using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalFolioApprovalLevelFolioCommentRecord
public class RESTRC_9af5a4e48bf7682fd78edcb92b1adec9 : AbstractRESTStructure<RC_9af5a4e48bf7682fd78edcb92b1adec9> {
[JsonProperty("FolioApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

[JsonProperty("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

[JsonProperty("FolioComment")]
public ssConectaProveedores.RestRecords.RESTEN_a75639301080da49357fc03810b8d65fEntityRecord AttrFolioComment;

public RESTRC_9af5a4e48bf7682fd78edcb92b1adec9() { }

public RESTRC_9af5a4e48bf7682fd78edcb92b1adec9 (RC_9af5a4e48bf7682fd78edcb92b1adec9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
AttrFolioComment = ConvertToRestWithoutDefaults(s.ssENFolioComment, new EN_a75639301080da49357fc03810b8d65fEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a75639301080da49357fc03810b8d65fEntityRecord.FromStructure, config);
  } else {
AttrFolioApproval = ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
AttrFolioComment = ssConectaProveedores.RestRecords.RESTEN_a75639301080da49357fc03810b8d65fEntityRecord.FromStructure(s.ssENFolioComment, config);
  }
}

public static RC_9af5a4e48bf7682fd78edcb92b1adec9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_9af5a4e48bf7682fd78edcb92b1adec9 obj) { 
  RC_9af5a4e48bf7682fd78edcb92b1adec9 s = new RC_9af5a4e48bf7682fd78edcb92b1adec9();
  if(obj != null) {
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval);
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel);
  s.ssENFolioComment = ssConectaProveedores.RestRecords.RESTEN_a75639301080da49357fc03810b8d65fEntityRecord.ToStructure(obj.AttrFolioComment);
  }
  return s;
}

public static Func<RC_9af5a4e48bf7682fd78edcb92b1adec9, ssConectaProveedores.RestRecords.RESTRC_9af5a4e48bf7682fd78edcb92b1adec9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9af5a4e48bf7682fd78edcb92b1adec9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9af5a4e48bf7682fd78edcb92b1adec9 FromStructure(RC_9af5a4e48bf7682fd78edcb92b1adec9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9af5a4e48bf7682fd78edcb92b1adec9(s, config);
}

}


