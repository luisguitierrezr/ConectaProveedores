using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioStatusRecord
public class JSONRC_c75df7b2e7c6e74a3a45dda7bd7b93e2 : AbstractRESTStructure<RC_c75df7b2e7c6e74a3a45dda7bd7b93e2> {
[JsonProperty("FolioStatus")]
[JsonPropertyName("FolioStatus")]
public ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord AttrFolioStatus;

public JSONRC_c75df7b2e7c6e74a3a45dda7bd7b93e2() { }

public JSONRC_c75df7b2e7c6e74a3a45dda7bd7b93e2 (RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioStatus = ConvertToRestWithoutDefaults(s.ssENFolioStatus, new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.FromStructure, config);
  } else {
AttrFolioStatus = ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.FromStructure(s.ssENFolioStatus, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c75df7b2e7c6e74a3a45dda7bd7b93e2, RC_c75df7b2e7c6e74a3a45dda7bd7b93e2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c75df7b2e7c6e74a3a45dda7bd7b93e2 s) => ToStructure(s, config);
}
public static RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 ToStructure(ssConectaProveedores.RestRecords.JSONRC_c75df7b2e7c6e74a3a45dda7bd7b93e2 obj, IBehaviorsConfiguration config) { 
  RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 s = new RC_c75df7b2e7c6e74a3a45dda7bd7b93e2();
  if(obj != null) {
  s.ssENFolioStatus = ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.ToStructure(obj.AttrFolioStatus, config);
  }
  return s;
}

public static Func<RC_c75df7b2e7c6e74a3a45dda7bd7b93e2, ssConectaProveedores.RestRecords.JSONRC_c75df7b2e7c6e74a3a45dda7bd7b93e2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c75df7b2e7c6e74a3a45dda7bd7b93e2 FromStructure(RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c75df7b2e7c6e74a3a45dda7bd7b93e2(s, config);
}

}


