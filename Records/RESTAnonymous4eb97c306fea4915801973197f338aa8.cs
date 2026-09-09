using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionAccConceptsRecord
public class RESTRC_e33b49261cecfe02249fd0f5f57f5dbc : AbstractRESTStructure<RC_e33b49261cecfe02249fd0f5f57f5dbc> {
[JsonProperty("RequisitionAccConcepts")]
public ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord AttrRequisitionAccConcepts;

public RESTRC_e33b49261cecfe02249fd0f5f57f5dbc() { }

public RESTRC_e33b49261cecfe02249fd0f5f57f5dbc (RC_e33b49261cecfe02249fd0f5f57f5dbc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionAccConcepts = ConvertToRestWithoutDefaults(s.ssENRequisitionAccConcepts, new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure, config);
  } else {
AttrRequisitionAccConcepts = ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure(s.ssENRequisitionAccConcepts, config);
  }
}

public static RC_e33b49261cecfe02249fd0f5f57f5dbc ToStructure(ssConectaProveedores.RestRecords.RESTRC_e33b49261cecfe02249fd0f5f57f5dbc obj) { 
  RC_e33b49261cecfe02249fd0f5f57f5dbc s = new RC_e33b49261cecfe02249fd0f5f57f5dbc();
  if(obj != null) {
  s.ssENRequisitionAccConcepts = ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.ToStructure(obj.AttrRequisitionAccConcepts);
  }
  return s;
}

public static Func<RC_e33b49261cecfe02249fd0f5f57f5dbc, ssConectaProveedores.RestRecords.RESTRC_e33b49261cecfe02249fd0f5f57f5dbc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e33b49261cecfe02249fd0f5f57f5dbc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e33b49261cecfe02249fd0f5f57f5dbc FromStructure(RC_e33b49261cecfe02249fd0f5f57f5dbc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e33b49261cecfe02249fd0f5f57f5dbc(s, config);
}

}


