using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioStatusRecord
public class RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2 : AbstractRESTStructure<RC_c75df7b2e7c6e74a3a45dda7bd7b93e2> {
[JsonProperty("FolioStatus")]
public ssConectaProveedores.RestRecords.RESTEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord AttrFolioStatus;

public RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2() { }

public RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2 (RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioStatus = ConvertToRestWithoutDefaults(s.ssENFolioStatus, new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.FromStructure, config);
  } else {
AttrFolioStatus = ssConectaProveedores.RestRecords.RESTEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.FromStructure(s.ssENFolioStatus, config);
  }
}

public static RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 ToStructure(ssConectaProveedores.RestRecords.RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2 obj) { 
  RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 s = new RC_c75df7b2e7c6e74a3a45dda7bd7b93e2();
  if(obj != null) {
  s.ssENFolioStatus = ssConectaProveedores.RestRecords.RESTEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.ToStructure(obj.AttrFolioStatus);
  }
  return s;
}

public static Func<RC_c75df7b2e7c6e74a3a45dda7bd7b93e2, ssConectaProveedores.RestRecords.RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2 FromStructure(RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2(s, config);
}

}


