using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionListExport_Struct
public class JSONST_4b0669d4e8a5d503dc5477cdc7b3957dStructure : AbstractRESTStructure<ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure> {
[JsonProperty("RequisitionId")]
[JsonPropertyName("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("RequisitionApprovalLevelId")]
[JsonPropertyName("RequisitionApprovalLevelId")]
public long? AttrRequisitionApprovalLevelId;

[JsonProperty("RequisitionName")]
[JsonPropertyName("RequisitionName")]
public string AttrRequisitionName;

[JsonProperty("RequisitionStatusId")]
[JsonPropertyName("RequisitionStatusId")]
public int? AttrRequisitionStatusId;

[JsonProperty("RequisitionStatus")]
[JsonPropertyName("RequisitionStatus")]
public string AttrRequisitionStatus;

[JsonProperty("ApprovalStatusId")]
[JsonPropertyName("ApprovalStatusId")]
public int? AttrApprovalStatusId;

[JsonProperty("ApprovalStatus")]
[JsonPropertyName("ApprovalStatus")]
public string AttrApprovalStatus;

[JsonProperty("ApprovalStatusClass")]
[JsonPropertyName("ApprovalStatusClass")]
public string AttrApprovalStatusClass;

[JsonProperty("ApplicantId")]
[JsonPropertyName("ApplicantId")]
public string AttrApplicantId;

[JsonProperty("ApplicantName")]
[JsonPropertyName("ApplicantName")]
public string AttrApplicantName;

[JsonProperty("ProjectDescription")]
[JsonPropertyName("ProjectDescription")]
public string AttrProjectDescription;

[JsonProperty("SupplierName")]
[JsonPropertyName("SupplierName")]
public string AttrSupplierName;

[JsonProperty("SupplierNumber")]
[JsonPropertyName("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public long? AttrRegionId;

[JsonProperty("RegionCode")]
[JsonPropertyName("RegionCode")]
public string AttrRegionCode;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public decimal? AttrTotalAmount;

[JsonProperty("CurrencyCode")]
[JsonPropertyName("CurrencyCode")]
public string AttrCurrencyCode;

[JsonProperty("CostCenterSAPDenominacion")]
[JsonPropertyName("CostCenterSAPDenominacion")]
public string AttrCostCenterSAPDenominacion;

[JsonProperty("CompanyDescription")]
[JsonPropertyName("CompanyDescription")]
public string AttrCompanyDescription;

[JsonProperty("AdvWithoutInvoice")]
[JsonPropertyName("AdvWithoutInvoice")]
public bool? AttrAdvWithoutInvoice;

[JsonProperty("IsAccounting")]
[JsonPropertyName("IsAccounting")]
public bool? AttrIsAccounting;

[JsonProperty("AccountingRegionId")]
[JsonPropertyName("AccountingRegionId")]
public long? AttrAccountingRegionId;

[JsonProperty("AssignedTo")]
[JsonPropertyName("AssignedTo")]
public string AttrAssignedTo;

[JsonProperty("IsContractPending")]
[JsonPropertyName("IsContractPending")]
public bool? AttrIsContractPending;

[JsonProperty("HasContractFileUploaded")]
[JsonPropertyName("HasContractFileUploaded")]
public bool? AttrHasContractFileUploaded;

[JsonProperty("ApproveAsAreaUsuaria")]
[JsonPropertyName("ApproveAsAreaUsuaria")]
public bool? AttrApproveAsAreaUsuaria;

[JsonProperty("LastApproverName")]
[JsonPropertyName("LastApproverName")]
public string AttrLastApproverName;

[JsonProperty("LastApproverApprovedOn")]
[JsonPropertyName("LastApproverApprovedOn")]
public String AttrLastApproverApprovedOn;

[JsonProperty("PolizaSAP_SentWhen")]
[JsonPropertyName("PolizaSAP_SentWhen")]
public string AttrPolizaSAP_SentWhen;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("DontShowAction")]
[JsonPropertyName("DontShowAction")]
public bool? AttrDontShowAction;

public JSONST_4b0669d4e8a5d503dc5477cdc7b3957dStructure() { }

public JSONST_4b0669d4e8a5d503dc5477cdc7b3957dStructure (ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONST_4b0669d4e8a5d503dc5477cdc7b3957dStructure, ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_4b0669d4e8a5d503dc5477cdc7b3957dStructure s) => ToStructure(s, config);
}
public static ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_4b0669d4e8a5d503dc5477cdc7b3957dStructure obj, IBehaviorsConfiguration config) { 
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
  s.ssLastApproverApprovedOn = obj.AttrLastApproverApprovedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrLastApproverApprovedOn, config.DateTimeFormat);
  s.ssPolizaSAP_SentWhen = obj.AttrPolizaSAP_SentWhen == null ? "" : obj.AttrPolizaSAP_SentWhen;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssDontShowAction = obj.AttrDontShowAction == null ? false : obj.AttrDontShowAction.Value;
  }
  return s;
}

public static Func<ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure, ssConectaProveedores.RestRecords.JSONST_4b0669d4e8a5d503dc5477cdc7b3957dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_4b0669d4e8a5d503dc5477cdc7b3957dStructure FromStructure(ST_4b0669d4e8a5d503dc5477cdc7b3957dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_4b0669d4e8a5d503dc5477cdc7b3957dStructure(s, config);
}

}


