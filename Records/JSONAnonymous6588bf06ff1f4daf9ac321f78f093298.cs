using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserProposalLogsRecord
public class JSONRC_38bf7bcb20a8b257cedfd0071956fdaa : AbstractRESTStructure<RC_38bf7bcb20a8b257cedfd0071956fdaa> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("ProposalLogs")]
[JsonPropertyName("ProposalLogs")]
public ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord AttrProposalLogs;

public JSONRC_38bf7bcb20a8b257cedfd0071956fdaa() { }

public JSONRC_38bf7bcb20a8b257cedfd0071956fdaa (RC_38bf7bcb20a8b257cedfd0071956fdaa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrProposalLogs = ConvertToRestWithoutDefaults(s.ssENProposalLogs, new EN_013f76cfa3062515b73935963b1697b0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrProposalLogs = ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord.FromStructure(s.ssENProposalLogs, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_38bf7bcb20a8b257cedfd0071956fdaa, RC_38bf7bcb20a8b257cedfd0071956fdaa> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_38bf7bcb20a8b257cedfd0071956fdaa s) => ToStructure(s, config);
}
public static RC_38bf7bcb20a8b257cedfd0071956fdaa ToStructure(ssConectaProveedores.RestRecords.JSONRC_38bf7bcb20a8b257cedfd0071956fdaa obj, IBehaviorsConfiguration config) { 
  RC_38bf7bcb20a8b257cedfd0071956fdaa s = new RC_38bf7bcb20a8b257cedfd0071956fdaa();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENProposalLogs = ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord.ToStructure(obj.AttrProposalLogs, config);
  }
  return s;
}

public static Func<RC_38bf7bcb20a8b257cedfd0071956fdaa, ssConectaProveedores.RestRecords.JSONRC_38bf7bcb20a8b257cedfd0071956fdaa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_38bf7bcb20a8b257cedfd0071956fdaa s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_38bf7bcb20a8b257cedfd0071956fdaa FromStructure(RC_38bf7bcb20a8b257cedfd0071956fdaa s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_38bf7bcb20a8b257cedfd0071956fdaa(s, config);
}

}


