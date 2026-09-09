using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserProposalLogsRecord
public class RESTRC_38bf7bcb20a8b257cedfd0071956fdaa : AbstractRESTStructure<RC_38bf7bcb20a8b257cedfd0071956fdaa> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("ProposalLogs")]
public ssConectaProveedores.RestRecords.RESTEN_013f76cfa3062515b73935963b1697b0EntityRecord AttrProposalLogs;

public RESTRC_38bf7bcb20a8b257cedfd0071956fdaa() { }

public RESTRC_38bf7bcb20a8b257cedfd0071956fdaa (RC_38bf7bcb20a8b257cedfd0071956fdaa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrProposalLogs = ConvertToRestWithoutDefaults(s.ssENProposalLogs, new EN_013f76cfa3062515b73935963b1697b0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_013f76cfa3062515b73935963b1697b0EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrProposalLogs = ssConectaProveedores.RestRecords.RESTEN_013f76cfa3062515b73935963b1697b0EntityRecord.FromStructure(s.ssENProposalLogs, config);
  }
}

public static RC_38bf7bcb20a8b257cedfd0071956fdaa ToStructure(ssConectaProveedores.RestRecords.RESTRC_38bf7bcb20a8b257cedfd0071956fdaa obj) { 
  RC_38bf7bcb20a8b257cedfd0071956fdaa s = new RC_38bf7bcb20a8b257cedfd0071956fdaa();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENProposalLogs = ssConectaProveedores.RestRecords.RESTEN_013f76cfa3062515b73935963b1697b0EntityRecord.ToStructure(obj.AttrProposalLogs);
  }
  return s;
}

public static Func<RC_38bf7bcb20a8b257cedfd0071956fdaa, ssConectaProveedores.RestRecords.RESTRC_38bf7bcb20a8b257cedfd0071956fdaa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_38bf7bcb20a8b257cedfd0071956fdaa s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_38bf7bcb20a8b257cedfd0071956fdaa FromStructure(RC_38bf7bcb20a8b257cedfd0071956fdaa s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_38bf7bcb20a8b257cedfd0071956fdaa(s, config);
}

}


