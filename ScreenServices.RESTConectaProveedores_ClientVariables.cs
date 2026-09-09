using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_ClientVariables : ScreenServicesApiController.Payload.IDataPayload {
	[JsonProperty("FolioForApproval_FolioNumber")]
public string ssFolioForApproval_FolioNumber;
[JsonProperty("FolioApproved_FolioNumber")]
public string ssFolioApproved_FolioNumber;
[JsonProperty("Proposals_Region")]
public long? ssProposals_Region;
[JsonProperty("TimeToWarning")]
public String ssTimeToWarning;
[JsonProperty("Report60_StatusId")]
public int? ssReport60_StatusId;
[JsonProperty("FolioForApproval_StatusId")]
public int? ssFolioForApproval_StatusId;
[JsonProperty("Proposals_Currency")]
public string ssProposals_Currency;
[JsonProperty("InvReport48_InvoiceStatusId")]
public int? ssInvReport48_InvoiceStatusId;
[JsonProperty("PreApprovalFolios_CreatedOn")]
public String ssPreApprovalFolios_CreatedOn;
[JsonProperty("AccountStatus_InvoiceName")]
public string ssAccountStatus_InvoiceName;
[JsonProperty("FolioContabilization_Filters_BusinessValueCategory")]
public string ssFolioContabilization_Filters_BusinessValueCategory;
[JsonProperty("Proposal_DocumentYear")]
public int? ssProposal_DocumentYear;
[JsonProperty("MaxRecords")]
public int? ssMaxRecords;
[JsonProperty("ForeignInvoicesForReassignment_OrderNumber")]
public string ssForeignInvoicesForReassignment_OrderNumber;
[JsonProperty("Report63_SupplierId")]
public long? ssReport63_SupplierId;
[JsonProperty("ForeignInvoicesForReassignment_TargetUserId")]
public string ssForeignInvoicesForReassignment_TargetUserId;
[JsonProperty("Proposals_PaymentDateFrom")]
public String ssProposals_PaymentDateFrom;
[JsonProperty("Requisitions_AmountFrom")]
public decimal? ssRequisitions_AmountFrom;
[JsonProperty("Proposals_Bank")]
public long? ssProposals_Bank;
[JsonProperty("Orders_DateTo")]
public String ssOrders_DateTo;
[JsonProperty("Requisitions_ProveedorFilter_UploadDateFrom")]
public String ssRequisitions_ProveedorFilter_UploadDateFrom;
[JsonProperty("FoliosSAERejected_OrderNumber")]
public string ssFoliosSAERejected_OrderNumber;
[JsonProperty("Report63_EndDate")]
public String ssReport63_EndDate;
[JsonProperty("ApplicationRole")]
public string ssApplicationRole;
[JsonProperty("TimeToLogout")]
public String ssTimeToLogout;
[JsonProperty("FoliosForReassignment_OriginalUserId")]
public string ssFoliosForReassignment_OriginalUserId;
[JsonProperty("OrderDistributionConfig_Role")]
public string ssOrderDistributionConfig_Role;
[JsonProperty("Requisitions_RequisitionSearch")]
public string ssRequisitions_RequisitionSearch;
[JsonProperty("FolioForApproval_CreatedToDate")]
public String ssFolioForApproval_CreatedToDate;
[JsonProperty("Orders_SupplierId")]
public long? ssOrders_SupplierId;
[JsonProperty("FolioApproved_OrderNumber")]
public string ssFolioApproved_OrderNumber;
[JsonProperty("FolioApproved_CreatedOnDate")]
public String ssFolioApproved_CreatedOnDate;
[JsonProperty("FolioContabilization_Filters_PaidOn")]
public String ssFolioContabilization_Filters_PaidOn;
[JsonProperty("FoliosSAERejected_FolioNumber")]
public string ssFoliosSAERejected_FolioNumber;
[JsonProperty("Supplier_Fechaanticiposinicio")]
public String ssSupplier_Fechaanticiposinicio;
[JsonProperty("Report60_AreaId")]
public long? ssReport60_AreaId;
[JsonProperty("AccountStatus_DateFrom")]
public String ssAccountStatus_DateFrom;
[JsonProperty("FolioApproved_SupplierId")]
public long? ssFolioApproved_SupplierId;
[JsonProperty("InvoicesFCP_Name")]
public string ssInvoicesFCP_Name;
[JsonProperty("OrderToApprove_Days")]
public int? ssOrderToApprove_Days;
[JsonProperty("FolioContabilization_Filters_FolioCreatedOn")]
public String ssFolioContabilization_Filters_FolioCreatedOn;
[JsonProperty("FolioForApproval_SupplierId")]
public long? ssFolioForApproval_SupplierId;
[JsonProperty("Commision_Leases_AmountMLTo")]
public decimal? ssCommision_Leases_AmountMLTo;
[JsonProperty("FolioContabilization_Filters_SpecialApprovalId")]
public int? ssFolioContabilization_Filters_SpecialApprovalId;
[JsonProperty("FolioForApproval_CreatedOnDate")]
public String ssFolioForApproval_CreatedOnDate;
[JsonProperty("Report63_Applicant")]
public string ssReport63_Applicant;
[JsonProperty("Proposals_AmountMLTo")]
public decimal? ssProposals_AmountMLTo;
[JsonProperty("Commision_Operator_AmountML")]
public string ssCommision_Operator_AmountML;
[JsonProperty("Commision_Leases_AssignedTo")]
public long? ssCommision_Leases_AssignedTo;
[JsonProperty("Commision_Leases_TypeId")]
public int? ssCommision_Leases_TypeId;
[JsonProperty("Invoice_ApprovalStatusId")]
public int? ssInvoice_ApprovalStatusId;
[JsonProperty("OrderApproved_Number")]
public string ssOrderApproved_Number;
[JsonProperty("Orders_DateFrom")]
public String ssOrders_DateFrom;
[JsonProperty("PreApprovalFolios_SupplierId")]
public long? ssPreApprovalFolios_SupplierId;
[JsonProperty("Treasury_PaymentDate")]
public String ssTreasury_PaymentDate;
[JsonProperty("Report60_Applicant")]
public string ssReport60_Applicant;
[JsonProperty("UserPhotoURL")]
public string ssUserPhotoURL;
[JsonProperty("OrderDistributionConfig_Direction")]
public string ssOrderDistributionConfig_Direction;
[JsonProperty("InvReport48_InvoiceName")]
public string ssInvReport48_InvoiceName;
[JsonProperty("PreApprovalFolios_FolioNumber")]
public string ssPreApprovalFolios_FolioNumber;
[JsonProperty("AccountStatus_InvoiceStatus")]
public int? ssAccountStatus_InvoiceStatus;
[JsonProperty("ForeignInvoicesPendingValidation_FolioNumber")]
public string ssForeignInvoicesPendingValidation_FolioNumber;
[JsonProperty("LastURL")]
public string ssLastURL;
[JsonProperty("Treasury_Status")]
public int? ssTreasury_Status;
[JsonProperty("Supplier_Fechacompensadasfin")]
public String ssSupplier_Fechacompensadasfin;
[JsonProperty("InvoicesFCP_SupplierId")]
public long? ssInvoicesFCP_SupplierId;
[JsonProperty("FoliosForReassignment_OrderNumber")]
public string ssFoliosForReassignment_OrderNumber;
[JsonProperty("Commision_Leases_CompanyId")]
public long? ssCommision_Leases_CompanyId;
[JsonProperty("Report63_StartDate")]
public String ssReport63_StartDate;
[JsonProperty("InvReport48_DateTo")]
public String ssInvReport48_DateTo;
[JsonProperty("Requisitions_RegionId")]
public long? ssRequisitions_RegionId;
[JsonProperty("OffsetUtc")]
public int? ssOffsetUtc;
[JsonProperty("Report62_RegionId")]
public long? ssReport62_RegionId;
[JsonProperty("FolioContabilization_Filters_Project")]
public string ssFolioContabilization_Filters_Project;
[JsonProperty("FolioContabilization_Filters_AmountTo")]
public decimal? ssFolioContabilization_Filters_AmountTo;
[JsonProperty("Treasury_ProposalSearch")]
public string ssTreasury_ProposalSearch;
[JsonProperty("Orders_RegionId")]
public long? ssOrders_RegionId;
[JsonProperty("Invoice_CompanyId")]
public long? ssInvoice_CompanyId;
[JsonProperty("Report63_OrderNumber")]
public string ssReport63_OrderNumber;
[JsonProperty("Report62_SupplierId")]
public long? ssReport62_SupplierId;
[JsonProperty("Requisitions_CompanyId")]
public long? ssRequisitions_CompanyId;
[JsonProperty("UserName")]
public string ssUserName;
[JsonProperty("OrderDistributionConfig_ApplicantDescription")]
public string ssOrderDistributionConfig_ApplicantDescription;
[JsonProperty("OrderToComplement_SupplierId")]
public long? ssOrderToComplement_SupplierId;
[JsonProperty("Requisitions_ApprovalStatusId")]
public int? ssRequisitions_ApprovalStatusId;
[JsonProperty("InvoicesFCP_FolioNumber")]
public string ssInvoicesFCP_FolioNumber;
[JsonProperty("Commision_Leases_AmountMLFrom")]
public decimal? ssCommision_Leases_AmountMLFrom;
[JsonProperty("Invoice_UploadDateFrom")]
public String ssInvoice_UploadDateFrom;
[JsonProperty("OrderInComplement_SupplierId")]
public long? ssOrderInComplement_SupplierId;
[JsonProperty("Supplier_Fechapartidasabiertas")]
public String ssSupplier_Fechapartidasabiertas;
[JsonProperty("FoliosSAERejected_SupplierId")]
public long? ssFoliosSAERejected_SupplierId;
[JsonProperty("Requisitions_RequisitionsStatusId")]
public int? ssRequisitions_RequisitionsStatusId;
[JsonProperty("Enviroment")]
public string ssEnviroment;
[JsonProperty("OrderInComplement_Number")]
public string ssOrderInComplement_Number;
[JsonProperty("Invoice_SupplierId")]
public long? ssInvoice_SupplierId;
[JsonProperty("Report60_SupplierId")]
public long? ssReport60_SupplierId;
[JsonProperty("Treasury_AmountMLTo")]
public decimal? ssTreasury_AmountMLTo;
[JsonProperty("Report60_RegionId")]
public long? ssReport60_RegionId;
[JsonProperty("FolioForApproval_RegionId")]
public long? ssFolioForApproval_RegionId;
[JsonProperty("Commision_Leases_UploadDate")]
public String ssCommision_Leases_UploadDate;
[JsonProperty("FolioContabilization_Filters_FolioNumber")]
public string ssFolioContabilization_Filters_FolioNumber;
[JsonProperty("Proposals_Statuses")]
public string ssProposals_Statuses;
[JsonProperty("OrderInComplement_Days")]
public int? ssOrderInComplement_Days;
[JsonProperty("Treasury_Operator_AmountML")]
public string ssTreasury_Operator_AmountML;
[JsonProperty("Requisitions_ProjectId")]
public long? ssRequisitions_ProjectId;
[JsonProperty("UnsuccessfulEntries_SAPError")]
public string ssUnsuccessfulEntries_SAPError;
[JsonProperty("UnsuccessfulEntries_FolioNumber")]
public string ssUnsuccessfulEntries_FolioNumber;
[JsonProperty("Report60_StartDate")]
public String ssReport60_StartDate;
[JsonProperty("Report60_EndDate")]
public String ssReport60_EndDate;
[JsonProperty("Invoice_ProjectId")]
public long? ssInvoice_ProjectId;
[JsonProperty("OrderDistributionConfig_Division")]
public string ssOrderDistributionConfig_Division;
[JsonProperty("ForeignInvoicesPendingValidation_StatusId")]
public int? ssForeignInvoicesPendingValidation_StatusId;
[JsonProperty("Supplier_Fechacompensadasinicio")]
public String ssSupplier_Fechacompensadasinicio;
[JsonProperty("OrderWithErrors_Days")]
public int? ssOrderWithErrors_Days;
[JsonProperty("FolioContabilization_Filters_InvoiceStatusId")]
public int? ssFolioContabilization_Filters_InvoiceStatusId;
[JsonProperty("FolioApproved_StatusId")]
public int? ssFolioApproved_StatusId;
[JsonProperty("AccountStatus_DateTo")]
public String ssAccountStatus_DateTo;
[JsonProperty("FolioContabilization_Filters_OrderMainNumber")]
public string ssFolioContabilization_Filters_OrderMainNumber;
[JsonProperty("Requisitions_UploadDate")]
public String ssRequisitions_UploadDate;
[JsonProperty("InvReport48_RegionId")]
public long? ssInvReport48_RegionId;
[JsonProperty("FolioForApproval_AssignedToMe")]
public bool? ssFolioForApproval_AssignedToMe;
[JsonProperty("Report60_OrderNumber")]
public string ssReport60_OrderNumber;
[JsonProperty("UnsuccessfulEntries_OrderNumber")]
public string ssUnsuccessfulEntries_OrderNumber;
[JsonProperty("OrderApproved_SupplierId")]
public long? ssOrderApproved_SupplierId;
[JsonProperty("PreApprovalFolios_OrderNumber")]
public string ssPreApprovalFolios_OrderNumber;
[JsonProperty("UnsuccessfulEntries_FolioStatus")]
public int? ssUnsuccessfulEntries_FolioStatus;
[JsonProperty("ForeignInvoicesForReassignment_FolioNumber")]
public string ssForeignInvoicesForReassignment_FolioNumber;
[JsonProperty("Treasury_Region")]
public long? ssTreasury_Region;
[JsonProperty("FolioContabilization_Filters_Period")]
public string ssFolioContabilization_Filters_Period;
[JsonProperty("ForeignInvoicesPendingValidation_OrderNumber")]
public string ssForeignInvoicesPendingValidation_OrderNumber;
[JsonProperty("FolioContabilization_Filters_AssignedTo")]
public string ssFolioContabilization_Filters_AssignedTo;
[JsonProperty("FoliosForReassignment_FolioNumber")]
public string ssFoliosForReassignment_FolioNumber;
[JsonProperty("FolioContabilization_Filters_FrequencyId")]
public int? ssFolioContabilization_Filters_FrequencyId;
[JsonProperty("Treasury_Assigned")]
public string ssTreasury_Assigned;
[JsonProperty("Invoice_UploadDateTo")]
public String ssInvoice_UploadDateTo;
[JsonProperty("InvoicesFCP_TotalAmount")]
public int? ssInvoicesFCP_TotalAmount;
[JsonProperty("OrderWithErrors_SupplierId")]
public long? ssOrderWithErrors_SupplierId;
[JsonProperty("OrderWithErrors_Number")]
public string ssOrderWithErrors_Number;
[JsonProperty("OrderToApprove_Number")]
public string ssOrderToApprove_Number;
[JsonProperty("OrderToApprove_SupplierId")]
public long? ssOrderToApprove_SupplierId;
[JsonProperty("Supplier_Sociedad")]
public long? ssSupplier_Sociedad;
[JsonProperty("Proposals_Operator_AmountML")]
public string ssProposals_Operator_AmountML;
[JsonProperty("Invoice_InvoiceName")]
public string ssInvoice_InvoiceName;
[JsonProperty("Proposals_UploadType")]
public int? ssProposals_UploadType;
[JsonProperty("Proposals_Type")]
public int? ssProposals_Type;
[JsonProperty("Commision_Leases_PaymentDate")]
public String ssCommision_Leases_PaymentDate;
[JsonProperty("Proposals_Status")]
public int? ssProposals_Status;
[JsonProperty("Invoice_RequisitionName")]
public string ssInvoice_RequisitionName;
[JsonProperty("InvReport48_DateFrom")]
public String ssInvReport48_DateFrom;
[JsonProperty("Report63_RegionId")]
public long? ssReport63_RegionId;
[JsonProperty("Commision_Leases_ProposalSearch")]
public string ssCommision_Leases_ProposalSearch;
[JsonProperty("Proposals_Regions")]
public string ssProposals_Regions;
[JsonProperty("Treasury_CreationDate")]
public String ssTreasury_CreationDate;
[JsonProperty("Commision_Leases_BankId")]
public long? ssCommision_Leases_BankId;
[JsonProperty("Report62_DateTo")]
public String ssReport62_DateTo;
[JsonProperty("Proposals_Currencies")]
public string ssProposals_Currencies;
[JsonProperty("PreApprovalFolios_RegionId")]
public long? ssPreApprovalFolios_RegionId;
[JsonProperty("FolioContabilization_Filters_AmountFrom")]
public int? ssFolioContabilization_Filters_AmountFrom;
[JsonProperty("Orders_Number")]
public string ssOrders_Number;
[JsonProperty("FolioContabilization_Filters_SupplierId")]
public long? ssFolioContabilization_Filters_SupplierId;
[JsonProperty("Commision_Leases_SupplierId")]
public long? ssCommision_Leases_SupplierId;
[JsonProperty("Report60_SociedadId")]
public long? ssReport60_SociedadId;
[JsonProperty("Supplier_Fechaanticiposfin")]
public String ssSupplier_Fechaanticiposfin;
[JsonProperty("Commision_Leases_RegionId")]
public long? ssCommision_Leases_RegionId;
[JsonProperty("OrderDistributionConfig_Applicant")]
public string ssOrderDistributionConfig_Applicant;
[JsonProperty("FolioForApproval_OrderNumber")]
public string ssFolioForApproval_OrderNumber;
[JsonProperty("InvReport48_SupplierId")]
public long? ssInvReport48_SupplierId;
[JsonProperty("Proposals_PaymentDateTo")]
public String ssProposals_PaymentDateTo;
[JsonProperty("Requisitions_SupplierId")]
public long? ssRequisitions_SupplierId;
[JsonProperty("Proposals_AmountMLFrom")]
public decimal? ssProposals_AmountMLFrom;
[JsonProperty("FolioContabilization_Filters_InvoiceCreatedOn")]
public String ssFolioContabilization_Filters_InvoiceCreatedOn;
[JsonProperty("Report62_DateFrom")]
public String ssReport62_DateFrom;
[JsonProperty("ForeignInvoicesForReassignment_OriginalUserId")]
public string ssForeignInvoicesForReassignment_OriginalUserId;
[JsonProperty("Proposal_DocumentNumber")]
public string ssProposal_DocumentNumber;
[JsonProperty("FolioApproved_RegionId")]
public long? ssFolioApproved_RegionId;
[JsonProperty("InvoicesFCP_UploadDate")]
public String ssInvoicesFCP_UploadDate;
[JsonProperty("OrderToComplement_Days")]
public int? ssOrderToComplement_Days;
[JsonProperty("ForeignInvoicesPendingValidation_SupplierId")]
public long? ssForeignInvoicesPendingValidation_SupplierId;
[JsonProperty("Report63_SociedadId")]
public long? ssReport63_SociedadId;
[JsonProperty("Requisitions_CostCenterId")]
public long? ssRequisitions_CostCenterId;
[JsonProperty("FolioContabilization_Filters_AccountingTypeId")]
public int? ssFolioContabilization_Filters_AccountingTypeId;
[JsonProperty("FolioContabilization_Filters_BusinessValueSubCateg")]
public string ssFolioContabilization_Filters_BusinessValueSubCateg;
[JsonProperty("Requisitions_ProveedorFilter_UploadDateTo")]
public String ssRequisitions_ProveedorFilter_UploadDateTo;
[JsonProperty("Treasury_Bank")]
public long? ssTreasury_Bank;
[JsonProperty("OrderToComplement_Number")]
public string ssOrderToComplement_Number;
[JsonProperty("Proposals_ProposalSearch")]
public string ssProposals_ProposalSearch;
[JsonProperty("Requisitions_AmountTo")]
public decimal? ssRequisitions_AmountTo;
[JsonProperty("FolioApproved_CreatedToDate")]
public String ssFolioApproved_CreatedToDate;
[JsonProperty("Orders_OrderStatusId")]
public int? ssOrders_OrderStatusId;
[JsonProperty("UnsuccessfulEntries_SupplierId")]
public long? ssUnsuccessfulEntries_SupplierId;
[JsonProperty("InvoicesFCP_OrderNumber")]
public string ssInvoicesFCP_OrderNumber;
[JsonProperty("FoliosForReassignment_TargetUserId")]
public string ssFoliosForReassignment_TargetUserId;
[JsonProperty("Commision_Leases_ApprovalStatusId")]
public int? ssCommision_Leases_ApprovalStatusId;
[JsonProperty("AccountStatus_RegionId")]
public long? ssAccountStatus_RegionId;
[JsonProperty("Treasury_AmountMLFrom")]
public decimal? ssTreasury_AmountMLFrom;
[JsonProperty("OrderProviderList_Number")]
public string ssOrderProviderList_Number;
[JsonProperty("FolioContabilization_Filters_InvoiceName")]
public string ssFolioContabilization_Filters_InvoiceName;
[JsonProperty("FolioContabilization_Filters_CurrencyId")]
public string ssFolioContabilization_Filters_CurrencyId;


    public static RESTConectaProveedores_ClientVariables FromJSON(JObject clientVars, JsonSerializer settings) {if((clientVars == null)) {
return null;
}

RESTConectaProveedores_ClientVariables result = clientVars.ToObject<RESTConectaProveedores_ClientVariables>(settings);
return result;
}


    public ConectaProveedores_ClientVariables ToModel() {string ssFolioForApproval_FolioNumber = this.ssFolioForApproval_FolioNumber == null ? "" : this.ssFolioForApproval_FolioNumber;
string ssFolioApproved_FolioNumber = this.ssFolioApproved_FolioNumber == null ? "" : this.ssFolioApproved_FolioNumber;
long ssProposals_Region = this.ssProposals_Region == null ? 0L : this.ssProposals_Region.Value;
DateTime ssTimeToWarning = this.ssTimeToWarning == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(this.ssTimeToWarning, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
int ssReport60_StatusId = this.ssReport60_StatusId == null ? 0 : this.ssReport60_StatusId.Value;
int ssFolioForApproval_StatusId = this.ssFolioForApproval_StatusId == null ? 0 : this.ssFolioForApproval_StatusId.Value;
string ssProposals_Currency = this.ssProposals_Currency == null ? "" : this.ssProposals_Currency;
int ssInvReport48_InvoiceStatusId = this.ssInvReport48_InvoiceStatusId == null ? 0 : this.ssInvReport48_InvoiceStatusId.Value;
DateTime ssPreApprovalFolios_CreatedOn = this.ssPreApprovalFolios_CreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssPreApprovalFolios_CreatedOn);
string ssAccountStatus_InvoiceName = this.ssAccountStatus_InvoiceName == null ? "" : this.ssAccountStatus_InvoiceName;
string ssFolioContabilization_Filters_BusinessValueCategory = this.ssFolioContabilization_Filters_BusinessValueCategory == null ? "" : this.ssFolioContabilization_Filters_BusinessValueCategory;
int ssProposal_DocumentYear = this.ssProposal_DocumentYear == null ? 0 : this.ssProposal_DocumentYear.Value;
int ssMaxRecords = this.ssMaxRecords == null ? 0 : this.ssMaxRecords.Value;
string ssForeignInvoicesForReassignment_OrderNumber = this.ssForeignInvoicesForReassignment_OrderNumber == null ? "" : this.ssForeignInvoicesForReassignment_OrderNumber;
long ssReport63_SupplierId = this.ssReport63_SupplierId == null ? 0L : this.ssReport63_SupplierId.Value;
string ssForeignInvoicesForReassignment_TargetUserId = this.ssForeignInvoicesForReassignment_TargetUserId == null ? "" : this.ssForeignInvoicesForReassignment_TargetUserId;
DateTime ssProposals_PaymentDateFrom = this.ssProposals_PaymentDateFrom == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssProposals_PaymentDateFrom);
decimal ssRequisitions_AmountFrom = this.ssRequisitions_AmountFrom == null ? 0.0M : this.ssRequisitions_AmountFrom.Value;
long ssProposals_Bank = this.ssProposals_Bank == null ? 0L : this.ssProposals_Bank.Value;
DateTime ssOrders_DateTo = this.ssOrders_DateTo == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssOrders_DateTo);
DateTime ssRequisitions_ProveedorFilter_UploadDateFrom = this.ssRequisitions_ProveedorFilter_UploadDateFrom == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssRequisitions_ProveedorFilter_UploadDateFrom);
string ssFoliosSAERejected_OrderNumber = this.ssFoliosSAERejected_OrderNumber == null ? "" : this.ssFoliosSAERejected_OrderNumber;
DateTime ssReport63_EndDate = this.ssReport63_EndDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssReport63_EndDate);
string ssApplicationRole = this.ssApplicationRole == null ? "" : this.ssApplicationRole;
DateTime ssTimeToLogout = this.ssTimeToLogout == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(this.ssTimeToLogout, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
string ssFoliosForReassignment_OriginalUserId = this.ssFoliosForReassignment_OriginalUserId == null ? "" : this.ssFoliosForReassignment_OriginalUserId;
string ssOrderDistributionConfig_Role = this.ssOrderDistributionConfig_Role == null ? "" : this.ssOrderDistributionConfig_Role;
string ssRequisitions_RequisitionSearch = this.ssRequisitions_RequisitionSearch == null ? "" : this.ssRequisitions_RequisitionSearch;
DateTime ssFolioForApproval_CreatedToDate = this.ssFolioForApproval_CreatedToDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssFolioForApproval_CreatedToDate);
long ssOrders_SupplierId = this.ssOrders_SupplierId == null ? 0L : this.ssOrders_SupplierId.Value;
string ssFolioApproved_OrderNumber = this.ssFolioApproved_OrderNumber == null ? "" : this.ssFolioApproved_OrderNumber;
DateTime ssFolioApproved_CreatedOnDate = this.ssFolioApproved_CreatedOnDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssFolioApproved_CreatedOnDate);
DateTime ssFolioContabilization_Filters_PaidOn = this.ssFolioContabilization_Filters_PaidOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssFolioContabilization_Filters_PaidOn);
string ssFoliosSAERejected_FolioNumber = this.ssFoliosSAERejected_FolioNumber == null ? "" : this.ssFoliosSAERejected_FolioNumber;
DateTime ssSupplier_Fechaanticiposinicio = this.ssSupplier_Fechaanticiposinicio == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssSupplier_Fechaanticiposinicio);
long ssReport60_AreaId = this.ssReport60_AreaId == null ? 0L : this.ssReport60_AreaId.Value;
DateTime ssAccountStatus_DateFrom = this.ssAccountStatus_DateFrom == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssAccountStatus_DateFrom);
long ssFolioApproved_SupplierId = this.ssFolioApproved_SupplierId == null ? 0L : this.ssFolioApproved_SupplierId.Value;
string ssInvoicesFCP_Name = this.ssInvoicesFCP_Name == null ? "" : this.ssInvoicesFCP_Name;
int ssOrderToApprove_Days = this.ssOrderToApprove_Days == null ? 0 : this.ssOrderToApprove_Days.Value;
DateTime ssFolioContabilization_Filters_FolioCreatedOn = this.ssFolioContabilization_Filters_FolioCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssFolioContabilization_Filters_FolioCreatedOn);
long ssFolioForApproval_SupplierId = this.ssFolioForApproval_SupplierId == null ? 0L : this.ssFolioForApproval_SupplierId.Value;
decimal ssCommision_Leases_AmountMLTo = this.ssCommision_Leases_AmountMLTo == null ? 0.0M : this.ssCommision_Leases_AmountMLTo.Value;
int ssFolioContabilization_Filters_SpecialApprovalId = this.ssFolioContabilization_Filters_SpecialApprovalId == null ? 0 : this.ssFolioContabilization_Filters_SpecialApprovalId.Value;
DateTime ssFolioForApproval_CreatedOnDate = this.ssFolioForApproval_CreatedOnDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssFolioForApproval_CreatedOnDate);
string ssReport63_Applicant = this.ssReport63_Applicant == null ? "" : this.ssReport63_Applicant;
decimal ssProposals_AmountMLTo = this.ssProposals_AmountMLTo == null ? 0.0M : this.ssProposals_AmountMLTo.Value;
string ssCommision_Operator_AmountML = this.ssCommision_Operator_AmountML == null ? "" : this.ssCommision_Operator_AmountML;
long ssCommision_Leases_AssignedTo = this.ssCommision_Leases_AssignedTo == null ? 0L : this.ssCommision_Leases_AssignedTo.Value;
int ssCommision_Leases_TypeId = this.ssCommision_Leases_TypeId == null ? 0 : this.ssCommision_Leases_TypeId.Value;
int ssInvoice_ApprovalStatusId = this.ssInvoice_ApprovalStatusId == null ? 0 : this.ssInvoice_ApprovalStatusId.Value;
string ssOrderApproved_Number = this.ssOrderApproved_Number == null ? "" : this.ssOrderApproved_Number;
DateTime ssOrders_DateFrom = this.ssOrders_DateFrom == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssOrders_DateFrom);
long ssPreApprovalFolios_SupplierId = this.ssPreApprovalFolios_SupplierId == null ? 0L : this.ssPreApprovalFolios_SupplierId.Value;
DateTime ssTreasury_PaymentDate = this.ssTreasury_PaymentDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssTreasury_PaymentDate);
string ssReport60_Applicant = this.ssReport60_Applicant == null ? "" : this.ssReport60_Applicant;
string ssUserPhotoURL = this.ssUserPhotoURL == null ? "" : this.ssUserPhotoURL;
string ssOrderDistributionConfig_Direction = this.ssOrderDistributionConfig_Direction == null ? "" : this.ssOrderDistributionConfig_Direction;
string ssInvReport48_InvoiceName = this.ssInvReport48_InvoiceName == null ? "" : this.ssInvReport48_InvoiceName;
string ssPreApprovalFolios_FolioNumber = this.ssPreApprovalFolios_FolioNumber == null ? "" : this.ssPreApprovalFolios_FolioNumber;
int ssAccountStatus_InvoiceStatus = this.ssAccountStatus_InvoiceStatus == null ? 0 : this.ssAccountStatus_InvoiceStatus.Value;
string ssForeignInvoicesPendingValidation_FolioNumber = this.ssForeignInvoicesPendingValidation_FolioNumber == null ? "" : this.ssForeignInvoicesPendingValidation_FolioNumber;
string ssLastURL = this.ssLastURL == null ? "" : this.ssLastURL;
int ssTreasury_Status = this.ssTreasury_Status == null ? 0 : this.ssTreasury_Status.Value;
DateTime ssSupplier_Fechacompensadasfin = this.ssSupplier_Fechacompensadasfin == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssSupplier_Fechacompensadasfin);
long ssInvoicesFCP_SupplierId = this.ssInvoicesFCP_SupplierId == null ? 0L : this.ssInvoicesFCP_SupplierId.Value;
string ssFoliosForReassignment_OrderNumber = this.ssFoliosForReassignment_OrderNumber == null ? "" : this.ssFoliosForReassignment_OrderNumber;
long ssCommision_Leases_CompanyId = this.ssCommision_Leases_CompanyId == null ? 0L : this.ssCommision_Leases_CompanyId.Value;
DateTime ssReport63_StartDate = this.ssReport63_StartDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssReport63_StartDate);
DateTime ssInvReport48_DateTo = this.ssInvReport48_DateTo == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssInvReport48_DateTo);
long ssRequisitions_RegionId = this.ssRequisitions_RegionId == null ? 0L : this.ssRequisitions_RegionId.Value;
int ssOffsetUtc = this.ssOffsetUtc == null ? 0 : this.ssOffsetUtc.Value;
long ssReport62_RegionId = this.ssReport62_RegionId == null ? 0L : this.ssReport62_RegionId.Value;
string ssFolioContabilization_Filters_Project = this.ssFolioContabilization_Filters_Project == null ? "" : this.ssFolioContabilization_Filters_Project;
decimal ssFolioContabilization_Filters_AmountTo = this.ssFolioContabilization_Filters_AmountTo == null ? 0.0M : this.ssFolioContabilization_Filters_AmountTo.Value;
string ssTreasury_ProposalSearch = this.ssTreasury_ProposalSearch == null ? "" : this.ssTreasury_ProposalSearch;
long ssOrders_RegionId = this.ssOrders_RegionId == null ? 0L : this.ssOrders_RegionId.Value;
long ssInvoice_CompanyId = this.ssInvoice_CompanyId == null ? 0L : this.ssInvoice_CompanyId.Value;
string ssReport63_OrderNumber = this.ssReport63_OrderNumber == null ? "" : this.ssReport63_OrderNumber;
long ssReport62_SupplierId = this.ssReport62_SupplierId == null ? 0L : this.ssReport62_SupplierId.Value;
long ssRequisitions_CompanyId = this.ssRequisitions_CompanyId == null ? 0L : this.ssRequisitions_CompanyId.Value;
string ssUserName = this.ssUserName == null ? "" : this.ssUserName;
string ssOrderDistributionConfig_ApplicantDescription = this.ssOrderDistributionConfig_ApplicantDescription == null ? "" : this.ssOrderDistributionConfig_ApplicantDescription;
long ssOrderToComplement_SupplierId = this.ssOrderToComplement_SupplierId == null ? 0L : this.ssOrderToComplement_SupplierId.Value;
int ssRequisitions_ApprovalStatusId = this.ssRequisitions_ApprovalStatusId == null ? 0 : this.ssRequisitions_ApprovalStatusId.Value;
string ssInvoicesFCP_FolioNumber = this.ssInvoicesFCP_FolioNumber == null ? "" : this.ssInvoicesFCP_FolioNumber;
decimal ssCommision_Leases_AmountMLFrom = this.ssCommision_Leases_AmountMLFrom == null ? 0.0M : this.ssCommision_Leases_AmountMLFrom.Value;
DateTime ssInvoice_UploadDateFrom = this.ssInvoice_UploadDateFrom == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssInvoice_UploadDateFrom);
long ssOrderInComplement_SupplierId = this.ssOrderInComplement_SupplierId == null ? 0L : this.ssOrderInComplement_SupplierId.Value;
DateTime ssSupplier_Fechapartidasabiertas = this.ssSupplier_Fechapartidasabiertas == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssSupplier_Fechapartidasabiertas);
long ssFoliosSAERejected_SupplierId = this.ssFoliosSAERejected_SupplierId == null ? 0L : this.ssFoliosSAERejected_SupplierId.Value;
int ssRequisitions_RequisitionsStatusId = this.ssRequisitions_RequisitionsStatusId == null ? 0 : this.ssRequisitions_RequisitionsStatusId.Value;
string ssEnviroment = this.ssEnviroment == null ? "" : this.ssEnviroment;
string ssOrderInComplement_Number = this.ssOrderInComplement_Number == null ? "" : this.ssOrderInComplement_Number;
long ssInvoice_SupplierId = this.ssInvoice_SupplierId == null ? 0L : this.ssInvoice_SupplierId.Value;
long ssReport60_SupplierId = this.ssReport60_SupplierId == null ? 0L : this.ssReport60_SupplierId.Value;
decimal ssTreasury_AmountMLTo = this.ssTreasury_AmountMLTo == null ? 0.0M : this.ssTreasury_AmountMLTo.Value;
long ssReport60_RegionId = this.ssReport60_RegionId == null ? 0L : this.ssReport60_RegionId.Value;
long ssFolioForApproval_RegionId = this.ssFolioForApproval_RegionId == null ? 0L : this.ssFolioForApproval_RegionId.Value;
DateTime ssCommision_Leases_UploadDate = this.ssCommision_Leases_UploadDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssCommision_Leases_UploadDate);
string ssFolioContabilization_Filters_FolioNumber = this.ssFolioContabilization_Filters_FolioNumber == null ? "" : this.ssFolioContabilization_Filters_FolioNumber;
string ssProposals_Statuses = this.ssProposals_Statuses == null ? "" : this.ssProposals_Statuses;
int ssOrderInComplement_Days = this.ssOrderInComplement_Days == null ? 0 : this.ssOrderInComplement_Days.Value;
string ssTreasury_Operator_AmountML = this.ssTreasury_Operator_AmountML == null ? "" : this.ssTreasury_Operator_AmountML;
long ssRequisitions_ProjectId = this.ssRequisitions_ProjectId == null ? 0L : this.ssRequisitions_ProjectId.Value;
string ssUnsuccessfulEntries_SAPError = this.ssUnsuccessfulEntries_SAPError == null ? "" : this.ssUnsuccessfulEntries_SAPError;
string ssUnsuccessfulEntries_FolioNumber = this.ssUnsuccessfulEntries_FolioNumber == null ? "" : this.ssUnsuccessfulEntries_FolioNumber;
DateTime ssReport60_StartDate = this.ssReport60_StartDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssReport60_StartDate);
DateTime ssReport60_EndDate = this.ssReport60_EndDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssReport60_EndDate);
long ssInvoice_ProjectId = this.ssInvoice_ProjectId == null ? 0L : this.ssInvoice_ProjectId.Value;
string ssOrderDistributionConfig_Division = this.ssOrderDistributionConfig_Division == null ? "" : this.ssOrderDistributionConfig_Division;
int ssForeignInvoicesPendingValidation_StatusId = this.ssForeignInvoicesPendingValidation_StatusId == null ? 0 : this.ssForeignInvoicesPendingValidation_StatusId.Value;
DateTime ssSupplier_Fechacompensadasinicio = this.ssSupplier_Fechacompensadasinicio == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssSupplier_Fechacompensadasinicio);
int ssOrderWithErrors_Days = this.ssOrderWithErrors_Days == null ? 0 : this.ssOrderWithErrors_Days.Value;
int ssFolioContabilization_Filters_InvoiceStatusId = this.ssFolioContabilization_Filters_InvoiceStatusId == null ? 0 : this.ssFolioContabilization_Filters_InvoiceStatusId.Value;
int ssFolioApproved_StatusId = this.ssFolioApproved_StatusId == null ? 0 : this.ssFolioApproved_StatusId.Value;
DateTime ssAccountStatus_DateTo = this.ssAccountStatus_DateTo == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssAccountStatus_DateTo);
string ssFolioContabilization_Filters_OrderMainNumber = this.ssFolioContabilization_Filters_OrderMainNumber == null ? "" : this.ssFolioContabilization_Filters_OrderMainNumber;
DateTime ssRequisitions_UploadDate = this.ssRequisitions_UploadDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssRequisitions_UploadDate);
long ssInvReport48_RegionId = this.ssInvReport48_RegionId == null ? 0L : this.ssInvReport48_RegionId.Value;
bool ssFolioForApproval_AssignedToMe = this.ssFolioForApproval_AssignedToMe == null ? true : this.ssFolioForApproval_AssignedToMe.Value;
string ssReport60_OrderNumber = this.ssReport60_OrderNumber == null ? "" : this.ssReport60_OrderNumber;
string ssUnsuccessfulEntries_OrderNumber = this.ssUnsuccessfulEntries_OrderNumber == null ? "" : this.ssUnsuccessfulEntries_OrderNumber;
long ssOrderApproved_SupplierId = this.ssOrderApproved_SupplierId == null ? 0L : this.ssOrderApproved_SupplierId.Value;
string ssPreApprovalFolios_OrderNumber = this.ssPreApprovalFolios_OrderNumber == null ? "" : this.ssPreApprovalFolios_OrderNumber;
int ssUnsuccessfulEntries_FolioStatus = this.ssUnsuccessfulEntries_FolioStatus == null ? 0 : this.ssUnsuccessfulEntries_FolioStatus.Value;
string ssForeignInvoicesForReassignment_FolioNumber = this.ssForeignInvoicesForReassignment_FolioNumber == null ? "" : this.ssForeignInvoicesForReassignment_FolioNumber;
long ssTreasury_Region = this.ssTreasury_Region == null ? 0L : this.ssTreasury_Region.Value;
string ssFolioContabilization_Filters_Period = this.ssFolioContabilization_Filters_Period == null ? "" : this.ssFolioContabilization_Filters_Period;
string ssForeignInvoicesPendingValidation_OrderNumber = this.ssForeignInvoicesPendingValidation_OrderNumber == null ? "" : this.ssForeignInvoicesPendingValidation_OrderNumber;
string ssFolioContabilization_Filters_AssignedTo = this.ssFolioContabilization_Filters_AssignedTo == null ? "" : this.ssFolioContabilization_Filters_AssignedTo;
string ssFoliosForReassignment_FolioNumber = this.ssFoliosForReassignment_FolioNumber == null ? "" : this.ssFoliosForReassignment_FolioNumber;
int ssFolioContabilization_Filters_FrequencyId = this.ssFolioContabilization_Filters_FrequencyId == null ? 0 : this.ssFolioContabilization_Filters_FrequencyId.Value;
string ssTreasury_Assigned = this.ssTreasury_Assigned == null ? "" : this.ssTreasury_Assigned;
DateTime ssInvoice_UploadDateTo = this.ssInvoice_UploadDateTo == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssInvoice_UploadDateTo);
int ssInvoicesFCP_TotalAmount = this.ssInvoicesFCP_TotalAmount == null ? 0 : this.ssInvoicesFCP_TotalAmount.Value;
long ssOrderWithErrors_SupplierId = this.ssOrderWithErrors_SupplierId == null ? 0L : this.ssOrderWithErrors_SupplierId.Value;
string ssOrderWithErrors_Number = this.ssOrderWithErrors_Number == null ? "" : this.ssOrderWithErrors_Number;
string ssOrderToApprove_Number = this.ssOrderToApprove_Number == null ? "" : this.ssOrderToApprove_Number;
long ssOrderToApprove_SupplierId = this.ssOrderToApprove_SupplierId == null ? 0L : this.ssOrderToApprove_SupplierId.Value;
long ssSupplier_Sociedad = this.ssSupplier_Sociedad == null ? 0L : this.ssSupplier_Sociedad.Value;
string ssProposals_Operator_AmountML = this.ssProposals_Operator_AmountML == null ? "" : this.ssProposals_Operator_AmountML;
string ssInvoice_InvoiceName = this.ssInvoice_InvoiceName == null ? "" : this.ssInvoice_InvoiceName;
int ssProposals_UploadType = this.ssProposals_UploadType == null ? 0 : this.ssProposals_UploadType.Value;
int ssProposals_Type = this.ssProposals_Type == null ? 0 : this.ssProposals_Type.Value;
DateTime ssCommision_Leases_PaymentDate = this.ssCommision_Leases_PaymentDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssCommision_Leases_PaymentDate);
int ssProposals_Status = this.ssProposals_Status == null ? 0 : this.ssProposals_Status.Value;
string ssInvoice_RequisitionName = this.ssInvoice_RequisitionName == null ? "" : this.ssInvoice_RequisitionName;
DateTime ssInvReport48_DateFrom = this.ssInvReport48_DateFrom == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssInvReport48_DateFrom);
long ssReport63_RegionId = this.ssReport63_RegionId == null ? 0L : this.ssReport63_RegionId.Value;
string ssCommision_Leases_ProposalSearch = this.ssCommision_Leases_ProposalSearch == null ? "" : this.ssCommision_Leases_ProposalSearch;
string ssProposals_Regions = this.ssProposals_Regions == null ? "" : this.ssProposals_Regions;
DateTime ssTreasury_CreationDate = this.ssTreasury_CreationDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssTreasury_CreationDate);
long ssCommision_Leases_BankId = this.ssCommision_Leases_BankId == null ? 0L : this.ssCommision_Leases_BankId.Value;
DateTime ssReport62_DateTo = this.ssReport62_DateTo == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssReport62_DateTo);
string ssProposals_Currencies = this.ssProposals_Currencies == null ? "" : this.ssProposals_Currencies;
long ssPreApprovalFolios_RegionId = this.ssPreApprovalFolios_RegionId == null ? 0L : this.ssPreApprovalFolios_RegionId.Value;
int ssFolioContabilization_Filters_AmountFrom = this.ssFolioContabilization_Filters_AmountFrom == null ? 0 : this.ssFolioContabilization_Filters_AmountFrom.Value;
string ssOrders_Number = this.ssOrders_Number == null ? "" : this.ssOrders_Number;
long ssFolioContabilization_Filters_SupplierId = this.ssFolioContabilization_Filters_SupplierId == null ? 0L : this.ssFolioContabilization_Filters_SupplierId.Value;
long ssCommision_Leases_SupplierId = this.ssCommision_Leases_SupplierId == null ? 0L : this.ssCommision_Leases_SupplierId.Value;
long ssReport60_SociedadId = this.ssReport60_SociedadId == null ? 0L : this.ssReport60_SociedadId.Value;
DateTime ssSupplier_Fechaanticiposfin = this.ssSupplier_Fechaanticiposfin == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssSupplier_Fechaanticiposfin);
long ssCommision_Leases_RegionId = this.ssCommision_Leases_RegionId == null ? 0L : this.ssCommision_Leases_RegionId.Value;
string ssOrderDistributionConfig_Applicant = this.ssOrderDistributionConfig_Applicant == null ? "" : this.ssOrderDistributionConfig_Applicant;
string ssFolioForApproval_OrderNumber = this.ssFolioForApproval_OrderNumber == null ? "" : this.ssFolioForApproval_OrderNumber;
long ssInvReport48_SupplierId = this.ssInvReport48_SupplierId == null ? 0L : this.ssInvReport48_SupplierId.Value;
DateTime ssProposals_PaymentDateTo = this.ssProposals_PaymentDateTo == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssProposals_PaymentDateTo);
long ssRequisitions_SupplierId = this.ssRequisitions_SupplierId == null ? 0L : this.ssRequisitions_SupplierId.Value;
decimal ssProposals_AmountMLFrom = this.ssProposals_AmountMLFrom == null ? 0.0M : this.ssProposals_AmountMLFrom.Value;
DateTime ssFolioContabilization_Filters_InvoiceCreatedOn = this.ssFolioContabilization_Filters_InvoiceCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssFolioContabilization_Filters_InvoiceCreatedOn);
DateTime ssReport62_DateFrom = this.ssReport62_DateFrom == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssReport62_DateFrom);
string ssForeignInvoicesForReassignment_OriginalUserId = this.ssForeignInvoicesForReassignment_OriginalUserId == null ? "" : this.ssForeignInvoicesForReassignment_OriginalUserId;
string ssProposal_DocumentNumber = this.ssProposal_DocumentNumber == null ? "" : this.ssProposal_DocumentNumber;
long ssFolioApproved_RegionId = this.ssFolioApproved_RegionId == null ? 0L : this.ssFolioApproved_RegionId.Value;
DateTime ssInvoicesFCP_UploadDate = this.ssInvoicesFCP_UploadDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssInvoicesFCP_UploadDate);
int ssOrderToComplement_Days = this.ssOrderToComplement_Days == null ? 0 : this.ssOrderToComplement_Days.Value;
long ssForeignInvoicesPendingValidation_SupplierId = this.ssForeignInvoicesPendingValidation_SupplierId == null ? 0L : this.ssForeignInvoicesPendingValidation_SupplierId.Value;
long ssReport63_SociedadId = this.ssReport63_SociedadId == null ? 0L : this.ssReport63_SociedadId.Value;
long ssRequisitions_CostCenterId = this.ssRequisitions_CostCenterId == null ? 0L : this.ssRequisitions_CostCenterId.Value;
int ssFolioContabilization_Filters_AccountingTypeId = this.ssFolioContabilization_Filters_AccountingTypeId == null ? 0 : this.ssFolioContabilization_Filters_AccountingTypeId.Value;
string ssFolioContabilization_Filters_BusinessValueSubCateg = this.ssFolioContabilization_Filters_BusinessValueSubCateg == null ? "" : this.ssFolioContabilization_Filters_BusinessValueSubCateg;
DateTime ssRequisitions_ProveedorFilter_UploadDateTo = this.ssRequisitions_ProveedorFilter_UploadDateTo == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssRequisitions_ProveedorFilter_UploadDateTo);
long ssTreasury_Bank = this.ssTreasury_Bank == null ? 0L : this.ssTreasury_Bank.Value;
string ssOrderToComplement_Number = this.ssOrderToComplement_Number == null ? "" : this.ssOrderToComplement_Number;
string ssProposals_ProposalSearch = this.ssProposals_ProposalSearch == null ? "" : this.ssProposals_ProposalSearch;
decimal ssRequisitions_AmountTo = this.ssRequisitions_AmountTo == null ? 0.0M : this.ssRequisitions_AmountTo.Value;
DateTime ssFolioApproved_CreatedToDate = this.ssFolioApproved_CreatedToDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(this.ssFolioApproved_CreatedToDate);
int ssOrders_OrderStatusId = this.ssOrders_OrderStatusId == null ? 0 : this.ssOrders_OrderStatusId.Value;
long ssUnsuccessfulEntries_SupplierId = this.ssUnsuccessfulEntries_SupplierId == null ? 0L : this.ssUnsuccessfulEntries_SupplierId.Value;
string ssInvoicesFCP_OrderNumber = this.ssInvoicesFCP_OrderNumber == null ? "" : this.ssInvoicesFCP_OrderNumber;
string ssFoliosForReassignment_TargetUserId = this.ssFoliosForReassignment_TargetUserId == null ? "" : this.ssFoliosForReassignment_TargetUserId;
int ssCommision_Leases_ApprovalStatusId = this.ssCommision_Leases_ApprovalStatusId == null ? 0 : this.ssCommision_Leases_ApprovalStatusId.Value;
long ssAccountStatus_RegionId = this.ssAccountStatus_RegionId == null ? 0L : this.ssAccountStatus_RegionId.Value;
decimal ssTreasury_AmountMLFrom = this.ssTreasury_AmountMLFrom == null ? 0.0M : this.ssTreasury_AmountMLFrom.Value;
string ssOrderProviderList_Number = this.ssOrderProviderList_Number == null ? "" : this.ssOrderProviderList_Number;
string ssFolioContabilization_Filters_InvoiceName = this.ssFolioContabilization_Filters_InvoiceName == null ? "" : this.ssFolioContabilization_Filters_InvoiceName;
string ssFolioContabilization_Filters_CurrencyId = this.ssFolioContabilization_Filters_CurrencyId == null ? "" : this.ssFolioContabilization_Filters_CurrencyId;
ConectaProveedores_ClientVariables clientVariablesModel = new ConectaProveedores_ClientVariables(ssFolioForApproval_FolioNumber, ssFolioApproved_FolioNumber, ssProposals_Region, ssTimeToWarning, ssReport60_StatusId, ssFolioForApproval_StatusId, ssProposals_Currency, ssInvReport48_InvoiceStatusId, ssPreApprovalFolios_CreatedOn, ssAccountStatus_InvoiceName, ssFolioContabilization_Filters_BusinessValueCategory, ssProposal_DocumentYear, ssMaxRecords, ssForeignInvoicesForReassignment_OrderNumber, ssReport63_SupplierId, ssForeignInvoicesForReassignment_TargetUserId, ssProposals_PaymentDateFrom, ssRequisitions_AmountFrom, ssProposals_Bank, ssOrders_DateTo, ssRequisitions_ProveedorFilter_UploadDateFrom, ssFoliosSAERejected_OrderNumber, ssReport63_EndDate, ssApplicationRole, ssTimeToLogout, ssFoliosForReassignment_OriginalUserId, ssOrderDistributionConfig_Role, ssRequisitions_RequisitionSearch, ssFolioForApproval_CreatedToDate, ssOrders_SupplierId, ssFolioApproved_OrderNumber, ssFolioApproved_CreatedOnDate, ssFolioContabilization_Filters_PaidOn, ssFoliosSAERejected_FolioNumber, ssSupplier_Fechaanticiposinicio, ssReport60_AreaId, ssAccountStatus_DateFrom, ssFolioApproved_SupplierId, ssInvoicesFCP_Name, ssOrderToApprove_Days, ssFolioContabilization_Filters_FolioCreatedOn, ssFolioForApproval_SupplierId, ssCommision_Leases_AmountMLTo, ssFolioContabilization_Filters_SpecialApprovalId, ssFolioForApproval_CreatedOnDate, ssReport63_Applicant, ssProposals_AmountMLTo, ssCommision_Operator_AmountML, ssCommision_Leases_AssignedTo, ssCommision_Leases_TypeId, ssInvoice_ApprovalStatusId, ssOrderApproved_Number, ssOrders_DateFrom, ssPreApprovalFolios_SupplierId, ssTreasury_PaymentDate, ssReport60_Applicant, ssUserPhotoURL, ssOrderDistributionConfig_Direction, ssInvReport48_InvoiceName, ssPreApprovalFolios_FolioNumber, ssAccountStatus_InvoiceStatus, ssForeignInvoicesPendingValidation_FolioNumber, ssLastURL, ssTreasury_Status, ssSupplier_Fechacompensadasfin, ssInvoicesFCP_SupplierId, ssFoliosForReassignment_OrderNumber, ssCommision_Leases_CompanyId, ssReport63_StartDate, ssInvReport48_DateTo, ssRequisitions_RegionId, ssOffsetUtc, ssReport62_RegionId, ssFolioContabilization_Filters_Project, ssFolioContabilization_Filters_AmountTo, ssTreasury_ProposalSearch, ssOrders_RegionId, ssInvoice_CompanyId, ssReport63_OrderNumber, ssReport62_SupplierId, ssRequisitions_CompanyId, ssUserName, ssOrderDistributionConfig_ApplicantDescription, ssOrderToComplement_SupplierId, ssRequisitions_ApprovalStatusId, ssInvoicesFCP_FolioNumber, ssCommision_Leases_AmountMLFrom, ssInvoice_UploadDateFrom, ssOrderInComplement_SupplierId, ssSupplier_Fechapartidasabiertas, ssFoliosSAERejected_SupplierId, ssRequisitions_RequisitionsStatusId, ssEnviroment, ssOrderInComplement_Number, ssInvoice_SupplierId, ssReport60_SupplierId, ssTreasury_AmountMLTo, ssReport60_RegionId, ssFolioForApproval_RegionId, ssCommision_Leases_UploadDate, ssFolioContabilization_Filters_FolioNumber, ssProposals_Statuses, ssOrderInComplement_Days, ssTreasury_Operator_AmountML, ssRequisitions_ProjectId, ssUnsuccessfulEntries_SAPError, ssUnsuccessfulEntries_FolioNumber, ssReport60_StartDate, ssReport60_EndDate, ssInvoice_ProjectId, ssOrderDistributionConfig_Division, ssForeignInvoicesPendingValidation_StatusId, ssSupplier_Fechacompensadasinicio, ssOrderWithErrors_Days, ssFolioContabilization_Filters_InvoiceStatusId, ssFolioApproved_StatusId, ssAccountStatus_DateTo, ssFolioContabilization_Filters_OrderMainNumber, ssRequisitions_UploadDate, ssInvReport48_RegionId, ssFolioForApproval_AssignedToMe, ssReport60_OrderNumber, ssUnsuccessfulEntries_OrderNumber, ssOrderApproved_SupplierId, ssPreApprovalFolios_OrderNumber, ssUnsuccessfulEntries_FolioStatus, ssForeignInvoicesForReassignment_FolioNumber, ssTreasury_Region, ssFolioContabilization_Filters_Period, ssForeignInvoicesPendingValidation_OrderNumber, ssFolioContabilization_Filters_AssignedTo, ssFoliosForReassignment_FolioNumber, ssFolioContabilization_Filters_FrequencyId, ssTreasury_Assigned, ssInvoice_UploadDateTo, ssInvoicesFCP_TotalAmount, ssOrderWithErrors_SupplierId, ssOrderWithErrors_Number, ssOrderToApprove_Number, ssOrderToApprove_SupplierId, ssSupplier_Sociedad, ssProposals_Operator_AmountML, ssInvoice_InvoiceName, ssProposals_UploadType, ssProposals_Type, ssCommision_Leases_PaymentDate, ssProposals_Status, ssInvoice_RequisitionName, ssInvReport48_DateFrom, ssReport63_RegionId, ssCommision_Leases_ProposalSearch, ssProposals_Regions, ssTreasury_CreationDate, ssCommision_Leases_BankId, ssReport62_DateTo, ssProposals_Currencies, ssPreApprovalFolios_RegionId, ssFolioContabilization_Filters_AmountFrom, ssOrders_Number, ssFolioContabilization_Filters_SupplierId, ssCommision_Leases_SupplierId, ssReport60_SociedadId, ssSupplier_Fechaanticiposfin, ssCommision_Leases_RegionId, ssOrderDistributionConfig_Applicant, ssFolioForApproval_OrderNumber, ssInvReport48_SupplierId, ssProposals_PaymentDateTo, ssRequisitions_SupplierId, ssProposals_AmountMLFrom, ssFolioContabilization_Filters_InvoiceCreatedOn, ssReport62_DateFrom, ssForeignInvoicesForReassignment_OriginalUserId, ssProposal_DocumentNumber, ssFolioApproved_RegionId, ssInvoicesFCP_UploadDate, ssOrderToComplement_Days, ssForeignInvoicesPendingValidation_SupplierId, ssReport63_SociedadId, ssRequisitions_CostCenterId, ssFolioContabilization_Filters_AccountingTypeId, ssFolioContabilization_Filters_BusinessValueSubCateg, ssRequisitions_ProveedorFilter_UploadDateTo, ssTreasury_Bank, ssOrderToComplement_Number, ssProposals_ProposalSearch, ssRequisitions_AmountTo, ssFolioApproved_CreatedToDate, ssOrders_OrderStatusId, ssUnsuccessfulEntries_SupplierId, ssInvoicesFCP_OrderNumber, ssFoliosForReassignment_TargetUserId, ssCommision_Leases_ApprovalStatusId, ssAccountStatus_RegionId, ssTreasury_AmountMLFrom, ssOrderProviderList_Number, ssFolioContabilization_Filters_InvoiceName, ssFolioContabilization_Filters_CurrencyId);
return clientVariablesModel;
}

}
