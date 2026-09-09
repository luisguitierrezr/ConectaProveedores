using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionAccConceptsRequisitionAccountingRecord
public class RESTRC_6b7fc732cea9431ac6d7f95245acde2b : AbstractRESTStructure<RC_6b7fc732cea9431ac6d7f95245acde2b> {
[JsonProperty("RequisitionAccConcepts")]
public ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord AttrRequisitionAccConcepts;

[JsonProperty("RequisitionAccounting")]
public ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord AttrRequisitionAccounting;

public RESTRC_6b7fc732cea9431ac6d7f95245acde2b() { }

public RESTRC_6b7fc732cea9431ac6d7f95245acde2b (RC_6b7fc732cea9431ac6d7f95245acde2b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionAccConcepts = ConvertToRestWithoutDefaults(s.ssENRequisitionAccConcepts, new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure, config);
AttrRequisitionAccounting = ConvertToRestWithoutDefaults(s.ssENRequisitionAccounting, new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure, config);
  } else {
AttrRequisitionAccConcepts = ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure(s.ssENRequisitionAccConcepts, config);
AttrRequisitionAccounting = ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure(s.ssENRequisitionAccounting, config);
  }
}

public static RC_6b7fc732cea9431ac6d7f95245acde2b ToStructure(ssConectaProveedores.RestRecords.RESTRC_6b7fc732cea9431ac6d7f95245acde2b obj) { 
  RC_6b7fc732cea9431ac6d7f95245acde2b s = new RC_6b7fc732cea9431ac6d7f95245acde2b();
  if(obj != null) {
  s.ssENRequisitionAccConcepts = ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.ToStructure(obj.AttrRequisitionAccConcepts);
  s.ssENRequisitionAccounting = ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.ToStructure(obj.AttrRequisitionAccounting);
  }
  return s;
}

public static Func<RC_6b7fc732cea9431ac6d7f95245acde2b, ssConectaProveedores.RestRecords.RESTRC_6b7fc732cea9431ac6d7f95245acde2b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6b7fc732cea9431ac6d7f95245acde2b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_6b7fc732cea9431ac6d7f95245acde2b FromStructure(RC_6b7fc732cea9431ac6d7f95245acde2b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_6b7fc732cea9431ac6d7f95245acde2b(s, config);
}

}


