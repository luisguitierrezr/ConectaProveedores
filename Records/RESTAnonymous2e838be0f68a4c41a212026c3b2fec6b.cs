using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionContractFileFinanceRequisitionFile2FinanceRecord
public class RESTRC_818bd4b46f7dc615b92986d5f58cbcb9 : AbstractRESTStructure<RC_818bd4b46f7dc615b92986d5f58cbcb9> {
[JsonProperty("RequisitionContractFileFinance")]
public ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord AttrRequisitionContractFileFinance;

[JsonProperty("RequisitionFile2Finance")]
public ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord AttrRequisitionFile2Finance;

public RESTRC_818bd4b46f7dc615b92986d5f58cbcb9() { }

public RESTRC_818bd4b46f7dc615b92986d5f58cbcb9 (RC_818bd4b46f7dc615b92986d5f58cbcb9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionContractFileFinance = ConvertToRestWithoutDefaults(s.ssENRequisitionContractFileFinance, new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure, config);
AttrRequisitionFile2Finance = ConvertToRestWithoutDefaults(s.ssENRequisitionFile2Finance, new EN_4cce425e15647f937e21de4e52849889EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure, config);
  } else {
AttrRequisitionContractFileFinance = ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure(s.ssENRequisitionContractFileFinance, config);
AttrRequisitionFile2Finance = ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure(s.ssENRequisitionFile2Finance, config);
  }
}

public static RC_818bd4b46f7dc615b92986d5f58cbcb9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_818bd4b46f7dc615b92986d5f58cbcb9 obj) { 
  RC_818bd4b46f7dc615b92986d5f58cbcb9 s = new RC_818bd4b46f7dc615b92986d5f58cbcb9();
  if(obj != null) {
  s.ssENRequisitionContractFileFinance = ssConectaProveedores.RestRecords.RESTEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.ToStructure(obj.AttrRequisitionContractFileFinance);
  s.ssENRequisitionFile2Finance = ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.ToStructure(obj.AttrRequisitionFile2Finance);
  }
  return s;
}

public static Func<RC_818bd4b46f7dc615b92986d5f58cbcb9, ssConectaProveedores.RestRecords.RESTRC_818bd4b46f7dc615b92986d5f58cbcb9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_818bd4b46f7dc615b92986d5f58cbcb9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_818bd4b46f7dc615b92986d5f58cbcb9 FromStructure(RC_818bd4b46f7dc615b92986d5f58cbcb9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_818bd4b46f7dc615b92986d5f58cbcb9(s, config);
}

}


