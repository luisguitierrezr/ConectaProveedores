using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserFolioApprovalFolioApprovalLevelRecord
public class JSONRC_eecf597d9aac604956ae34e0eea91058 : AbstractRESTStructure<RC_eecf597d9aac604956ae34e0eea91058> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("FolioApproval")]
[JsonPropertyName("FolioApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

[JsonProperty("FolioApprovalLevel")]
[JsonPropertyName("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

public JSONRC_eecf597d9aac604956ae34e0eea91058() { }

public JSONRC_eecf597d9aac604956ae34e0eea91058 (RC_eecf597d9aac604956ae34e0eea91058 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_eecf597d9aac604956ae34e0eea91058, RC_eecf597d9aac604956ae34e0eea91058> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_eecf597d9aac604956ae34e0eea91058 s) => ToStructure(s, config);
}
public static RC_eecf597d9aac604956ae34e0eea91058 ToStructure(ssConectaProveedores.RestRecords.JSONRC_eecf597d9aac604956ae34e0eea91058 obj, IBehaviorsConfiguration config) { 
  RC_eecf597d9aac604956ae34e0eea91058 s = new RC_eecf597d9aac604956ae34e0eea91058();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval, config);
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel, config);
  }
  return s;
}

public static Func<RC_eecf597d9aac604956ae34e0eea91058, ssConectaProveedores.RestRecords.JSONRC_eecf597d9aac604956ae34e0eea91058> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_eecf597d9aac604956ae34e0eea91058 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_eecf597d9aac604956ae34e0eea91058 FromStructure(RC_eecf597d9aac604956ae34e0eea91058 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_eecf597d9aac604956ae34e0eea91058(s, config);
}

}


