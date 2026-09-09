using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalFolioApprovalLevelRecord
public class RESTRC_131b941598d8581e5466dbb966f5f0a8 : AbstractRESTStructure<RC_131b941598d8581e5466dbb966f5f0a8> {
[JsonProperty("FolioApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

[JsonProperty("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

public RESTRC_131b941598d8581e5466dbb966f5f0a8() { }

public RESTRC_131b941598d8581e5466dbb966f5f0a8 (RC_131b941598d8581e5466dbb966f5f0a8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
  } else {
AttrFolioApproval = ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
  }
}

public static RC_131b941598d8581e5466dbb966f5f0a8 ToStructure(ssConectaProveedores.RestRecords.RESTRC_131b941598d8581e5466dbb966f5f0a8 obj) { 
  RC_131b941598d8581e5466dbb966f5f0a8 s = new RC_131b941598d8581e5466dbb966f5f0a8();
  if(obj != null) {
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval);
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel);
  }
  return s;
}

public static Func<RC_131b941598d8581e5466dbb966f5f0a8, ssConectaProveedores.RestRecords.RESTRC_131b941598d8581e5466dbb966f5f0a8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_131b941598d8581e5466dbb966f5f0a8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_131b941598d8581e5466dbb966f5f0a8 FromStructure(RC_131b941598d8581e5466dbb966f5f0a8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_131b941598d8581e5466dbb966f5f0a8(s, config);
}

}


