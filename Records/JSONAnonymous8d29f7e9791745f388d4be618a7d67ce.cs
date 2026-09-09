using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalFolioFolioApprovalLevelRecord
public class JSONRC_1b390f8e281aa018cfe8a81d34cdb757 : AbstractRESTStructure<RC_1b390f8e281aa018cfe8a81d34cdb757> {
[JsonProperty("FolioApproval")]
[JsonPropertyName("FolioApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioApprovalLevel")]
[JsonPropertyName("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

public JSONRC_1b390f8e281aa018cfe8a81d34cdb757() { }

public JSONRC_1b390f8e281aa018cfe8a81d34cdb757 (RC_1b390f8e281aa018cfe8a81d34cdb757 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
  } else {
AttrFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1b390f8e281aa018cfe8a81d34cdb757, RC_1b390f8e281aa018cfe8a81d34cdb757> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1b390f8e281aa018cfe8a81d34cdb757 s) => ToStructure(s, config);
}
public static RC_1b390f8e281aa018cfe8a81d34cdb757 ToStructure(ssConectaProveedores.RestRecords.JSONRC_1b390f8e281aa018cfe8a81d34cdb757 obj, IBehaviorsConfiguration config) { 
  RC_1b390f8e281aa018cfe8a81d34cdb757 s = new RC_1b390f8e281aa018cfe8a81d34cdb757();
  if(obj != null) {
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel, config);
  }
  return s;
}

public static Func<RC_1b390f8e281aa018cfe8a81d34cdb757, ssConectaProveedores.RestRecords.JSONRC_1b390f8e281aa018cfe8a81d34cdb757> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1b390f8e281aa018cfe8a81d34cdb757 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1b390f8e281aa018cfe8a81d34cdb757 FromStructure(RC_1b390f8e281aa018cfe8a81d34cdb757 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1b390f8e281aa018cfe8a81d34cdb757(s, config);
}

}


