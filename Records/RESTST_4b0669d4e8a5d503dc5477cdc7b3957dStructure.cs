using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionListExport_Struct
public class RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure : AbstractRESTStructure<ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure> {
[JsonProperty("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("RequisitionApprovalLevelId")]
public long? AttrRequisitionApprovalLevelId;

[JsonProperty("RequisitionName")]
public string AttrRequisitionName;

[JsonProperty("RequisitionStatusId")]
public int? AttrRequisitionStatusId;

[JsonProperty("RequisitionStatus")]
public string AttrRequisitionStatus;

[JsonProperty("ApprovalStatusId")]
public int? AttrApprovalStatusId;

[JsonProperty("ApprovalStatus")]
public string AttrApprovalStatus;

[JsonProperty("ApprovalStatusClass")]
public string AttrApprovalStatusClass;

[JsonProperty("ApplicantId")]
public string AttrApplicantId;

[JsonProperty("ApplicantName")]
public string AttrApplicantName;

[JsonProperty("ProjectDescription")]
public string AttrProjectDescription;

[JsonProperty("SupplierName")]
public string AttrSupplierName;

[JsonProperty("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("RegionId")]
public long? AttrRegionId;

[JsonProperty("RegionCode")]
public string AttrRegionCode;

[JsonProperty("TotalAmount")]
public decimal? AttrTotalAmount;

[JsonProperty("CurrencyCode")]
public string AttrCurrencyCode;

[JsonProperty("CostCenterSAPDenominacion")]
public string AttrCostCenterSAPDenominacion;

[JsonProperty("CompanyDescription")]
public string AttrCompanyDescription;

[JsonProperty("AdvWithoutInvoice")]
public bool? AttrAdvWithoutInvoice;

[JsonProperty("IsAccounting")]
public bool? AttrIsAccounting;

[JsonProperty("AccountingRegionId")]
public long? AttrAccountingRegionId;

[JsonProperty("AssignedTo")]
public string AttrAssignedTo;

[JsonProperty("IsContractPending")]
public bool? AttrIsContractPending;

[JsonProperty("HasContractFileUploaded")]
public bool? AttrHasContractFileUploaded;

[JsonProperty("ApproveAsAreaUsuaria")]
public bool? AttrApproveAsAreaUsuaria;

[JsonProperty("LastApproverName")]
public string AttrLastApproverName;

[JsonProperty("LastApproverApprovedOn")]
public String AttrLastApproverApprovedOn;

[JsonProperty("PolizaSAP_SentWhen")]
public string AttrPolizaSAP_SentWhen;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("DontShowAction")]
public bool? AttrDontShowAction;

public RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure() { }

public RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure (ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionId = ConvertToRestWithoutDefaults(s.ssRequisitionId, 0L);
AttrRequisitionApprovalLevelId = ConvertToRestWithoutDefaults(s.ssRequisitionApprovalLevelId, 0L);
AttrRequisitionName = ConvertToRestWithoutDefaults(s.ssRequisitionName, "");
AttrRequisitionStatusId = ConvertToRestWithoutDefaults(s.ssRequisitionStatusId, 0);
AttrRequisitionStatus = ConvertToRestWithoutDefaults(s.ssRequisitionStatus, "");
AttrApprovalStatusId = ConvertToRestWithoutDefaults(s.ssApprovalStatusId, 0);
AttrApprovalStatus = ConvertToRestWithoutDefaults(s.ssApprovalStatus, "");
AttrApprovalStatusClass = ConvertToRestWithoutDefaults(s.ssApprovalStatusClass, "");
AttrApplicantId = ConvertToRestWithoutDefaults(s.ssApplicantId, "");
AttrApplicantName = ConvertToRestWithoutDefaults(s.ssApplicantName, "");
AttrProjectDescription = ConvertToRestWithoutDefaults(s.ssProjectDescription, "");
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
AttrRegionCode = ConvertToRestWithoutDefaults(s.ssRegionCode, "");
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
AttrCurrencyCode = ConvertToRestWithoutDefaults(s.ssCurrencyCode, "");
AttrCostCenterSAPDenominacion = ConvertToRestWithoutDefaults(s.ssCostCenterSAPDenominacion, "");
AttrCompanyDescription = ConvertToRestWithoutDefaults(s.ssCompanyDescription, "");
AttrAdvWithoutInvoice = ConvertToRestWithoutDefaults(s.ssAdvWithoutInvoice, false);
AttrIsAccounting = ConvertToRestWithoutDefaults(s.ssIsAccounting, false);
AttrAccountingRegionId = ConvertToRestWithoutDefaults(s.ssAccountingRegionId, 0L);
AttrAssignedTo = ConvertToRestWithoutDefaults(s.ssAssignedTo, "");
AttrIsContractPending = ConvertToRestWithoutDefaults(s.ssIsContractPending, false);
AttrHasContractFileUploaded = ConvertToRestWithoutDefaults(s.ssHasContractFileUploaded, false);
AttrApproveAsAreaUsuaria = ConvertToRestWithoutDefaults(s.ssApproveAsAreaUsuaria, false);
AttrLastApproverName = ConvertToRestWithoutDefaults(s.ssLastApproverName, "");
AttrLastApproverApprovedOn = ConvertDateTimeToRestWithoutDefaults(s.ssLastApproverApprovedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrPolizaSAP_SentWhen = ConvertToRestWithoutDefaults(s.ssPolizaSAP_SentWhen, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrDontShowAction = ConvertToRestWithoutDefaults(s.ssDontShowAction, false);
  } else {
AttrRequisitionId = (long?) s.ssRequisitionId;
AttrRequisitionApprovalLevelId = (long?) s.ssRequisitionApprovalLevelId;
AttrRequisitionName = s.ssRequisitionName;
AttrRequisitionStatusId = (int?) s.ssRequisitionStatusId;
AttrRequisitionStatus = s.ssRequisitionStatus;
AttrApprovalStatusId = (int?) s.ssApprovalStatusId;
AttrApprovalStatus = s.ssApprovalStatus;
AttrApprovalStatusClass = s.ssApprovalStatusClass;
AttrApplicantId = s.ssApplicantId;
AttrApplicantName = s.ssApplicantName;
AttrProjectDescription = s.ssProjectDescription;
AttrSupplierName = s.ssSupplierName;
AttrSupplierNumber = s.ssSupplierNumber;
AttrRegionId = (long?) s.ssRegionId;
AttrRegionCode = s.ssRegionCode;
AttrTotalAmount = (decimal?) s.ssTotalAmount;
AttrCurrencyCode = s.ssCurrencyCode;
AttrCostCenterSAPDenominacion = s.ssCostCenterSAPDenominacion;
AttrCompanyDescription = s.ssCompanyDescription;
AttrAdvWithoutInvoice = (bool?) s.ssAdvWithoutInvoice;
AttrIsAccounting = (bool?) s.ssIsAccounting;
AttrAccountingRegionId = (long?) s.ssAccountingRegionId;
AttrAssignedTo = s.ssAssignedTo;
AttrIsContractPending = (bool?) s.ssIsContractPending;
AttrHasContractFileUploaded = (bool?) s.ssHasContractFileUploaded;
AttrApproveAsAreaUsuaria = (bool?) s.ssApproveAsAreaUsuaria;
AttrLastApproverName = s.ssLastApproverName;
AttrLastApproverApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssLastApproverApprovedOn, config.DateTimeFormat);
AttrPolizaSAP_SentWhen = s.ssPolizaSAP_SentWhen;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrDontShowAction = (bool?) s.ssDontShowAction;
  }
}

public static ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure obj) { 
  ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure s = new ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure();
  if(obj != null) {
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssRequisitionApprovalLevelId = obj.AttrRequisitionApprovalLevelId == null ? 0L : obj.AttrRequisitionApprovalLevelId.Value;
  s.ssRequisitionName = obj.AttrRequisitionName == null ? "" : obj.AttrRequisitionName;
  s.ssRequisitionStatusId = obj.AttrRequisitionStatusId == null ? 0 : obj.AttrRequisitionStatusId.Value;
  s.ssRequisitionStatus = obj.AttrRequisitionStatus == null ? "" : obj.AttrRequisitionStatus;
  s.ssApprovalStatusId = obj.AttrApprovalStatusId == null ? 0 : obj.AttrApprovalStatusId.Value;
  s.ssApprovalStatus = obj.AttrApprovalStatus == null ? "" : obj.AttrApprovalStatus;
  s.ssApprovalStatusClass = obj.AttrApprovalStatusClass == null ? "" : obj.AttrApprovalStatusClass;
  s.ssApplicantId = obj.AttrApplicantId == null ? "" : obj.AttrApplicantId;
  s.ssApplicantName = obj.AttrApplicantName == null ? "" : obj.AttrApplicantName;
  s.ssProjectDescription = obj.AttrProjectDescription == null ? "" : obj.AttrProjectDescription;
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  s.ssRegionCode = obj.AttrRegionCode == null ? "" : obj.AttrRegionCode;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  s.ssCurrencyCode = obj.AttrCurrencyCode == null ? "" : obj.AttrCurrencyCode;
  s.ssCostCenterSAPDenominacion = obj.AttrCostCenterSAPDenominacion == null ? "" : obj.AttrCostCenterSAPDenominacion;
  s.ssCompanyDescription = obj.AttrCompanyDescription == null ? "" : obj.AttrCompanyDescription;
  s.ssAdvWithoutInvoice = obj.AttrAdvWithoutInvoice == null ? false : obj.AttrAdvWithoutInvoice.Value;
  s.ssIsAccounting = obj.AttrIsAccounting == null ? false : obj.AttrIsAccounting.Value;
  s.ssAccountingRegionId = obj.AttrAccountingRegionId == null ? 0L : obj.AttrAccountingRegionId.Value;
  s.ssAssignedTo = obj.AttrAssignedTo == null ? "" : obj.AttrAssignedTo;
  s.ssIsContractPending = obj.AttrIsContractPending == null ? false : obj.AttrIsContractPending.Value;
  s.ssHasContractFileUploaded = obj.AttrHasContractFileUploaded == null ? false : obj.AttrHasContractFileUploaded.Value;
  s.ssApproveAsAreaUsuaria = obj.AttrApproveAsAreaUsuaria == null ? false : obj.AttrApproveAsAreaUsuaria.Value;
  s.ssLastApproverName = obj.AttrLastApproverName == null ? "" : obj.AttrLastApproverName;
  s.ssLastApproverApprovedOn = obj.AttrLastApproverApprovedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrLastApproverApprovedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssPolizaSAP_SentWhen = obj.AttrPolizaSAP_SentWhen == null ? "" : obj.AttrPolizaSAP_SentWhen;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssDontShowAction = obj.AttrDontShowAction == null ? false : obj.AttrDontShowAction.Value;
  }
  return s;
}

public static Func<ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure, ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure FromStructure(ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure(s, config);
}

}


