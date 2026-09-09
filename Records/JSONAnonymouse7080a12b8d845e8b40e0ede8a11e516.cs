using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioFolioApprovalLevelRecord
public class JSONRC_ab183c41bd8594296e7d4471350fb29f : AbstractRESTStructure<RC_ab183c41bd8594296e7d4471350fb29f> {
[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioApprovalLevel")]
[JsonPropertyName("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

public JSONRC_ab183c41bd8594296e7d4471350fb29f() { }

public JSONRC_ab183c41bd8594296e7d4471350fb29f (RC_ab183c41bd8594296e7d4471350fb29f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
  } else {
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ab183c41bd8594296e7d4471350fb29f, RC_ab183c41bd8594296e7d4471350fb29f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ab183c41bd8594296e7d4471350fb29f s) => ToStructure(s, config);
}
public static RC_ab183c41bd8594296e7d4471350fb29f ToStructure(ssConectaProveedores.RestRecords.JSONRC_ab183c41bd8594296e7d4471350fb29f obj, IBehaviorsConfiguration config) { 
  RC_ab183c41bd8594296e7d4471350fb29f s = new RC_ab183c41bd8594296e7d4471350fb29f();
  if(obj != null) {
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel, config);
  }
  return s;
}

public static Func<RC_ab183c41bd8594296e7d4471350fb29f, ssConectaProveedores.RestRecords.JSONRC_ab183c41bd8594296e7d4471350fb29f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ab183c41bd8594296e7d4471350fb29f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ab183c41bd8594296e7d4471350fb29f FromStructure(RC_ab183c41bd8594296e7d4471350fb29f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ab183c41bd8594296e7d4471350fb29f(s, config);
}

}


