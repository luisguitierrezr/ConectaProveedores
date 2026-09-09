using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionContractFileFinanceRequisitionFile2FinanceRecord
public class JSONRC_818bd4b46f7dc615b92986d5f58cbcb9 : AbstractRESTStructure<RC_818bd4b46f7dc615b92986d5f58cbcb9> {
[JsonProperty("RequisitionContractFileFinance")]
[JsonPropertyName("RequisitionContractFileFinance")]
public ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord AttrRequisitionContractFileFinance;

[JsonProperty("RequisitionFile2Finance")]
[JsonPropertyName("RequisitionFile2Finance")]
public ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord AttrRequisitionFile2Finance;

public JSONRC_818bd4b46f7dc615b92986d5f58cbcb9() { }

public JSONRC_818bd4b46f7dc615b92986d5f58cbcb9 (RC_818bd4b46f7dc615b92986d5f58cbcb9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionContractFileFinance = ConvertToRestWithoutDefaults(s.ssENRequisitionContractFileFinance, new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure, config);
AttrRequisitionFile2Finance = ConvertToRestWithoutDefaults(s.ssENRequisitionFile2Finance, new EN_4cce425e15647f937e21de4e52849889EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure, config);
  } else {
AttrRequisitionContractFileFinance = ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure(s.ssENRequisitionContractFileFinance, config);
AttrRequisitionFile2Finance = ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure(s.ssENRequisitionFile2Finance, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_818bd4b46f7dc615b92986d5f58cbcb9, RC_818bd4b46f7dc615b92986d5f58cbcb9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_818bd4b46f7dc615b92986d5f58cbcb9 s) => ToStructure(s, config);
}
public static RC_818bd4b46f7dc615b92986d5f58cbcb9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_818bd4b46f7dc615b92986d5f58cbcb9 obj, IBehaviorsConfiguration config) { 
  RC_818bd4b46f7dc615b92986d5f58cbcb9 s = new RC_818bd4b46f7dc615b92986d5f58cbcb9();
  if(obj != null) {
  s.ssENRequisitionContractFileFinance = ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.ToStructure(obj.AttrRequisitionContractFileFinance, config);
  s.ssENRequisitionFile2Finance = ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.ToStructure(obj.AttrRequisitionFile2Finance, config);
  }
  return s;
}

public static Func<RC_818bd4b46f7dc615b92986d5f58cbcb9, ssConectaProveedores.RestRecords.JSONRC_818bd4b46f7dc615b92986d5f58cbcb9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_818bd4b46f7dc615b92986d5f58cbcb9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_818bd4b46f7dc615b92986d5f58cbcb9 FromStructure(RC_818bd4b46f7dc615b92986d5f58cbcb9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_818bd4b46f7dc615b92986d5f58cbcb9(s, config);
}

}


