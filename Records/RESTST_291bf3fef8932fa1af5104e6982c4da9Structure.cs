using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionsListInternalTableStructure
public class RESTST_291bf3fef8932fa1af5104e6982c4da9Structure : AbstractRESTStructure<ST_291bf3fef8932fa1af5104e6982c4da9Structure> {
[JsonProperty("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("RequisitionApprovalLevelId")]
public long? AttrRequisitionApprovalLevelId;

[JsonProperty("RequisitionName")]
public string AttrRequisitionName;

[JsonProperty("RequisitionStatus")]
public string AttrRequisitionStatus;

[JsonProperty("CreationDate")]
public string AttrCreationDate;

[JsonProperty("LastChange")]
public string AttrLastChange;

[JsonProperty("Requester")]
public string AttrRequester;

[JsonProperty("Project")]
public string AttrProject;

[JsonProperty("Supplier")]
public string AttrSupplier;

[JsonProperty("Region")]
public string AttrRegion;

[JsonProperty("Amount")]
public string AttrAmount;

[JsonProperty("Currency")]
public string AttrCurrency;

[JsonProperty("CostCenter")]
public string AttrCostCenter;

[JsonProperty("Company")]
public string AttrCompany;

[JsonProperty("LastApprover")]
public string AttrLastApprover;

[JsonProperty("LastApproverApprovedOn")]
public string AttrLastApproverApprovedOn;

[JsonProperty("PolizaSAP_SentWhen")]
public string AttrPolizaSAP_SentWhen;

[JsonProperty("Action")]
public string AttrAction;

public RESTST_291bf3fef8932fa1af5104e6982c4da9Structure() { }

public RESTST_291bf3fef8932fa1af5104e6982c4da9Structure (ST_291bf3fef8932fa1af5104e6982c4da9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionId = ConvertToRestWithoutDefaults(s.ssRequisitionId, 0L);
AttrRequisitionApprovalLevelId = ConvertToRestWithoutDefaults(s.ssRequisitionApprovalLevelId, 0L);
AttrRequisitionName = ConvertToRestWithoutDefaults(s.ssRequisitionName, "");
AttrRequisitionStatus = ConvertToRestWithoutDefaults(s.ssRequisitionStatus, "");
AttrCreationDate = ConvertToRestWithoutDefaults(s.ssCreationDate, "");
AttrLastChange = ConvertToRestWithoutDefaults(s.ssLastChange, "");
AttrRequester = ConvertToRestWithoutDefaults(s.ssRequester, "");
AttrProject = ConvertToRestWithoutDefaults(s.ssProject, "");
AttrSupplier = ConvertToRestWithoutDefaults(s.ssSupplier, "");
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
AttrAmount = ConvertToRestWithoutDefaults(s.ssAmount, "");
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrCostCenter = ConvertToRestWithoutDefaults(s.ssCostCenter, "");
AttrCompany = ConvertToRestWithoutDefaults(s.ssCompany, "");
AttrLastApprover = ConvertToRestWithoutDefaults(s.ssLastApprover, "");
AttrLastApproverApprovedOn = ConvertToRestWithoutDefaults(s.ssLastApproverApprovedOn, "");
AttrPolizaSAP_SentWhen = ConvertToRestWithoutDefaults(s.ssPolizaSAP_SentWhen, "");
AttrAction = ConvertToRestWithoutDefaults(s.ssAction, "");
  } else {
AttrRequisitionId = (long?) s.ssRequisitionId;
AttrRequisitionApprovalLevelId = (long?) s.ssRequisitionApprovalLevelId;
AttrRequisitionName = s.ssRequisitionName;
AttrRequisitionStatus = s.ssRequisitionStatus;
AttrCreationDate = s.ssCreationDate;
AttrLastChange = s.ssLastChange;
AttrRequester = s.ssRequester;
AttrProject = s.ssProject;
AttrSupplier = s.ssSupplier;
AttrRegion = s.ssRegion;
AttrAmount = s.ssAmount;
AttrCurrency = s.ssCurrency;
AttrCostCenter = s.ssCostCenter;
AttrCompany = s.ssCompany;
AttrLastApprover = s.ssLastApprover;
AttrLastApproverApprovedOn = s.ssLastApproverApprovedOn;
AttrPolizaSAP_SentWhen = s.ssPolizaSAP_SentWhen;
AttrAction = s.ssAction;
  }
}

public static ST_291bf3fef8932fa1af5104e6982c4da9Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_291bf3fef8932fa1af5104e6982c4da9Structure obj) { 
  ST_291bf3fef8932fa1af5104e6982c4da9Structure s = new ST_291bf3fef8932fa1af5104e6982c4da9Structure();
  if(obj != null) {
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssRequisitionApprovalLevelId = obj.AttrRequisitionApprovalLevelId == null ? 0L : obj.AttrRequisitionApprovalLevelId.Value;
  s.ssRequisitionName = obj.AttrRequisitionName == null ? "" : obj.AttrRequisitionName;
  s.ssRequisitionStatus = obj.AttrRequisitionStatus == null ? "" : obj.AttrRequisitionStatus;
  s.ssCreationDate = obj.AttrCreationDate == null ? "" : obj.AttrCreationDate;
  s.ssLastChange = obj.AttrLastChange == null ? "" : obj.AttrLastChange;
  s.ssRequester = obj.AttrRequester == null ? "" : obj.AttrRequester;
  s.ssProject = obj.AttrProject == null ? "" : obj.AttrProject;
  s.ssSupplier = obj.AttrSupplier == null ? "" : obj.AttrSupplier;
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  s.ssAmount = obj.AttrAmount == null ? "" : obj.AttrAmount;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssCostCenter = obj.AttrCostCenter == null ? "" : obj.AttrCostCenter;
  s.ssCompany = obj.AttrCompany == null ? "" : obj.AttrCompany;
  s.ssLastApprover = obj.AttrLastApprover == null ? "" : obj.AttrLastApprover;
  s.ssLastApproverApprovedOn = obj.AttrLastApproverApprovedOn == null ? "" : obj.AttrLastApproverApprovedOn;
  s.ssPolizaSAP_SentWhen = obj.AttrPolizaSAP_SentWhen == null ? "" : obj.AttrPolizaSAP_SentWhen;
  s.ssAction = obj.AttrAction == null ? "" : obj.AttrAction;
  }
  return s;
}

public static Func<ST_291bf3fef8932fa1af5104e6982c4da9Structure, ssConectaProveedores.RestRecords.RESTST_291bf3fef8932fa1af5104e6982c4da9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_291bf3fef8932fa1af5104e6982c4da9Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_291bf3fef8932fa1af5104e6982c4da9Structure FromStructure(ST_291bf3fef8932fa1af5104e6982c4da9Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_291bf3fef8932fa1af5104e6982c4da9Structure(s, config);
}

}


