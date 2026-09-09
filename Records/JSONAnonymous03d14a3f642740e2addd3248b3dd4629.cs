using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalLevelRecord
public class JSONRC_0be8bae4cc285c0288822b663818cb6c : AbstractRESTStructure<RC_0be8bae4cc285c0288822b663818cb6c> {
[JsonProperty("FolioApprovalLevel")]
[JsonPropertyName("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

public JSONRC_0be8bae4cc285c0288822b663818cb6c() { }

public JSONRC_0be8bae4cc285c0288822b663818cb6c (RC_0be8bae4cc285c0288822b663818cb6c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
  } else {
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0be8bae4cc285c0288822b663818cb6c, RC_0be8bae4cc285c0288822b663818cb6c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0be8bae4cc285c0288822b663818cb6c s) => ToStructure(s, config);
}
public static RC_0be8bae4cc285c0288822b663818cb6c ToStructure(ssConectaProveedores.RestRecords.JSONRC_0be8bae4cc285c0288822b663818cb6c obj, IBehaviorsConfiguration config) { 
  RC_0be8bae4cc285c0288822b663818cb6c s = new RC_0be8bae4cc285c0288822b663818cb6c();
  if(obj != null) {
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel, config);
  }
  return s;
}

public static Func<RC_0be8bae4cc285c0288822b663818cb6c, ssConectaProveedores.RestRecords.JSONRC_0be8bae4cc285c0288822b663818cb6c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0be8bae4cc285c0288822b663818cb6c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0be8bae4cc285c0288822b663818cb6c FromStructure(RC_0be8bae4cc285c0288822b663818cb6c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0be8bae4cc285c0288822b663818cb6c(s, config);
}

}


