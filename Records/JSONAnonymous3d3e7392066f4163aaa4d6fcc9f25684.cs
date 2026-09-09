using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalStatusHistoryRecord
public class JSONRC_e6d370b8387bb43d90dc90a766ecdf20 : AbstractRESTStructure<RC_e6d370b8387bb43d90dc90a766ecdf20> {
[JsonProperty("ProposalStatusHistory")]
[JsonPropertyName("ProposalStatusHistory")]
public ssConectaProveedores.RestRecords.JSONEN_f6d34ae04169ae9164103e8797ea11d4EntityRecord AttrProposalStatusHistory;

public JSONRC_e6d370b8387bb43d90dc90a766ecdf20() { }

public JSONRC_e6d370b8387bb43d90dc90a766ecdf20 (RC_e6d370b8387bb43d90dc90a766ecdf20 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalStatusHistory = ConvertToRestWithoutDefaults(s.ssENProposalStatusHistory, new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f6d34ae04169ae9164103e8797ea11d4EntityRecord.FromStructure, config);
  } else {
AttrProposalStatusHistory = ssConectaProveedores.RestRecords.JSONEN_f6d34ae04169ae9164103e8797ea11d4EntityRecord.FromStructure(s.ssENProposalStatusHistory, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e6d370b8387bb43d90dc90a766ecdf20, RC_e6d370b8387bb43d90dc90a766ecdf20> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e6d370b8387bb43d90dc90a766ecdf20 s) => ToStructure(s, config);
}
public static RC_e6d370b8387bb43d90dc90a766ecdf20 ToStructure(ssConectaProveedores.RestRecords.JSONRC_e6d370b8387bb43d90dc90a766ecdf20 obj, IBehaviorsConfiguration config) { 
  RC_e6d370b8387bb43d90dc90a766ecdf20 s = new RC_e6d370b8387bb43d90dc90a766ecdf20();
  if(obj != null) {
  s.ssENProposalStatusHistory = ssConectaProveedores.RestRecords.JSONEN_f6d34ae04169ae9164103e8797ea11d4EntityRecord.ToStructure(obj.AttrProposalStatusHistory, config);
  }
  return s;
}

public static Func<RC_e6d370b8387bb43d90dc90a766ecdf20, ssConectaProveedores.RestRecords.JSONRC_e6d370b8387bb43d90dc90a766ecdf20> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e6d370b8387bb43d90dc90a766ecdf20 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e6d370b8387bb43d90dc90a766ecdf20 FromStructure(RC_e6d370b8387bb43d90dc90a766ecdf20 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e6d370b8387bb43d90dc90a766ecdf20(s, config);
}

}


