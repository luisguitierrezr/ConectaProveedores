using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalFolioApprovalLevelRecord
public class JSONRC_131b941598d8581e5466dbb966f5f0a8 : AbstractRESTStructure<RC_131b941598d8581e5466dbb966f5f0a8> {
[JsonProperty("FolioApproval")]
[JsonPropertyName("FolioApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

[JsonProperty("FolioApprovalLevel")]
[JsonPropertyName("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

public JSONRC_131b941598d8581e5466dbb966f5f0a8() { }

public JSONRC_131b941598d8581e5466dbb966f5f0a8 (RC_131b941598d8581e5466dbb966f5f0a8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
  } else {
AttrFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_131b941598d8581e5466dbb966f5f0a8, RC_131b941598d8581e5466dbb966f5f0a8> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_131b941598d8581e5466dbb966f5f0a8 s) => ToStructure(s, config);
}
public static RC_131b941598d8581e5466dbb966f5f0a8 ToStructure(ssConectaProveedores.RestRecords.JSONRC_131b941598d8581e5466dbb966f5f0a8 obj, IBehaviorsConfiguration config) { 
  RC_131b941598d8581e5466dbb966f5f0a8 s = new RC_131b941598d8581e5466dbb966f5f0a8();
  if(obj != null) {
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval, config);
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel, config);
  }
  return s;
}

public static Func<RC_131b941598d8581e5466dbb966f5f0a8, ssConectaProveedores.RestRecords.JSONRC_131b941598d8581e5466dbb966f5f0a8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_131b941598d8581e5466dbb966f5f0a8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_131b941598d8581e5466dbb966f5f0a8 FromStructure(RC_131b941598d8581e5466dbb966f5f0a8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_131b941598d8581e5466dbb966f5f0a8(s, config);
}

}


