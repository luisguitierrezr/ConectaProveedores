using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalFolioFolioApprovalLevelOrderMainApplicationRoleRecord
public class JSONRC_c4212a2ad9aed3b4ecb882ed30f5e868 : AbstractRESTStructure<RC_c4212a2ad9aed3b4ecb882ed30f5e868> {
[JsonProperty("FolioApproval")]
[JsonPropertyName("FolioApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioApprovalLevel")]
[JsonPropertyName("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public JSONRC_c4212a2ad9aed3b4ecb882ed30f5e868() { }

public JSONRC_c4212a2ad9aed3b4ecb882ed30f5e868 (RC_c4212a2ad9aed3b4ecb882ed30f5e868 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c4212a2ad9aed3b4ecb882ed30f5e868, RC_c4212a2ad9aed3b4ecb882ed30f5e868> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c4212a2ad9aed3b4ecb882ed30f5e868 s) => ToStructure(s, config);
}
public static RC_c4212a2ad9aed3b4ecb882ed30f5e868 ToStructure(ssConectaProveedores.RestRecords.JSONRC_c4212a2ad9aed3b4ecb882ed30f5e868 obj, IBehaviorsConfiguration config) { 
  RC_c4212a2ad9aed3b4ecb882ed30f5e868 s = new RC_c4212a2ad9aed3b4ecb882ed30f5e868();
  if(obj != null) {
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  }
  return s;
}

public static Func<RC_c4212a2ad9aed3b4ecb882ed30f5e868, ssConectaProveedores.RestRecords.JSONRC_c4212a2ad9aed3b4ecb882ed30f5e868> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c4212a2ad9aed3b4ecb882ed30f5e868 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c4212a2ad9aed3b4ecb882ed30f5e868 FromStructure(RC_c4212a2ad9aed3b4ecb882ed30f5e868 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c4212a2ad9aed3b4ecb882ed30f5e868(s, config);
}

}


