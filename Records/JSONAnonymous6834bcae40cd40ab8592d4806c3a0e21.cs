using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalFolioApprovalLevelFolioCommentRecord
public class JSONRC_9af5a4e48bf7682fd78edcb92b1adec9 : AbstractRESTStructure<RC_9af5a4e48bf7682fd78edcb92b1adec9> {
[JsonProperty("FolioApproval")]
[JsonPropertyName("FolioApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

[JsonProperty("FolioApprovalLevel")]
[JsonPropertyName("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

[JsonProperty("FolioComment")]
[JsonPropertyName("FolioComment")]
public ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord AttrFolioComment;

public JSONRC_9af5a4e48bf7682fd78edcb92b1adec9() { }

public JSONRC_9af5a4e48bf7682fd78edcb92b1adec9 (RC_9af5a4e48bf7682fd78edcb92b1adec9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
AttrFolioComment = ConvertToRestWithoutDefaults(s.ssENFolioComment, new EN_a75639301080da49357fc03810b8d65fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord.FromStructure, config);
  } else {
AttrFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
AttrFolioComment = ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord.FromStructure(s.ssENFolioComment, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_9af5a4e48bf7682fd78edcb92b1adec9, RC_9af5a4e48bf7682fd78edcb92b1adec9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_9af5a4e48bf7682fd78edcb92b1adec9 s) => ToStructure(s, config);
}
public static RC_9af5a4e48bf7682fd78edcb92b1adec9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_9af5a4e48bf7682fd78edcb92b1adec9 obj, IBehaviorsConfiguration config) { 
  RC_9af5a4e48bf7682fd78edcb92b1adec9 s = new RC_9af5a4e48bf7682fd78edcb92b1adec9();
  if(obj != null) {
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval, config);
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel, config);
  s.ssENFolioComment = ssConectaProveedores.RestRecords.JSONEN_a75639301080da49357fc03810b8d65fEntityRecord.ToStructure(obj.AttrFolioComment, config);
  }
  return s;
}

public static Func<RC_9af5a4e48bf7682fd78edcb92b1adec9, ssConectaProveedores.RestRecords.JSONRC_9af5a4e48bf7682fd78edcb92b1adec9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9af5a4e48bf7682fd78edcb92b1adec9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_9af5a4e48bf7682fd78edcb92b1adec9 FromStructure(RC_9af5a4e48bf7682fd78edcb92b1adec9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_9af5a4e48bf7682fd78edcb92b1adec9(s, config);
}

}


