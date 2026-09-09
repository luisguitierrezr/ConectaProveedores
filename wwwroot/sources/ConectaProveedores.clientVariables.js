import { Injector as OS$Injector, ServiceNames as OS$ServiceNames, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";

var clientVarsService;
class ClientVariables {
constructor() {
clientVarsService = OS$Injector.resolve(OS$ServiceNames.ClientVariablesService);
}

getFolioForApproval_FolioNumber() {
return clientVarsService.getVariable("FolioForApproval_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFolioForApproval_FolioNumber(value) {
return clientVarsService.setVariable("FolioForApproval_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getFolioApproved_FolioNumber() {
return clientVarsService.getVariable("FolioApproved_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFolioApproved_FolioNumber(value) {
return clientVarsService.setVariable("FolioApproved_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getProposals_Region() {
return clientVarsService.getVariable("Proposals_Region", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setProposals_Region(value) {
return clientVarsService.setVariable("Proposals_Region", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getTimeToWarning() {
return clientVarsService.getVariable("TimeToWarning", "ConectaProveedores", OS$DataTypes.DataTypes.DateTime);
}

setTimeToWarning(value) {
return clientVarsService.setVariable("TimeToWarning", "ConectaProveedores", OS$DataTypes.DataTypes.DateTime, value);
}

getReport60_StatusId() {
return clientVarsService.getVariable("Report60_StatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setReport60_StatusId(value) {
return clientVarsService.setVariable("Report60_StatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getFolioForApproval_StatusId() {
return clientVarsService.getVariable("FolioForApproval_StatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setFolioForApproval_StatusId(value) {
return clientVarsService.setVariable("FolioForApproval_StatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getProposals_Currency() {
return clientVarsService.getVariable("Proposals_Currency", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setProposals_Currency(value) {
return clientVarsService.setVariable("Proposals_Currency", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getInvReport48_InvoiceStatusId() {
return clientVarsService.getVariable("InvReport48_InvoiceStatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setInvReport48_InvoiceStatusId(value) {
return clientVarsService.setVariable("InvReport48_InvoiceStatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getPreApprovalFolios_CreatedOn() {
return clientVarsService.getVariable("PreApprovalFolios_CreatedOn", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setPreApprovalFolios_CreatedOn(value) {
return clientVarsService.setVariable("PreApprovalFolios_CreatedOn", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getAccountStatus_InvoiceName() {
return clientVarsService.getVariable("AccountStatus_InvoiceName", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setAccountStatus_InvoiceName(value) {
return clientVarsService.setVariable("AccountStatus_InvoiceName", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getFolioContabilization_Filters_BusinessValueCategory() {
return clientVarsService.getVariable("FolioContabilization_Filters_BusinessValueCategory", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFolioContabilization_Filters_BusinessValueCategory(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_BusinessValueCategory", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getProposal_DocumentYear() {
return clientVarsService.getVariable("Proposal_DocumentYear", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setProposal_DocumentYear(value) {
return clientVarsService.setVariable("Proposal_DocumentYear", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getMaxRecords() {
return clientVarsService.getVariable("MaxRecords", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setMaxRecords(value) {
return clientVarsService.setVariable("MaxRecords", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getForeignInvoicesForReassignment_OrderNumber() {
return clientVarsService.getVariable("ForeignInvoicesForReassignment_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setForeignInvoicesForReassignment_OrderNumber(value) {
return clientVarsService.setVariable("ForeignInvoicesForReassignment_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getReport63_SupplierId() {
return clientVarsService.getVariable("Report63_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setReport63_SupplierId(value) {
return clientVarsService.setVariable("Report63_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getForeignInvoicesForReassignment_TargetUserId() {
return clientVarsService.getVariable("ForeignInvoicesForReassignment_TargetUserId", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setForeignInvoicesForReassignment_TargetUserId(value) {
return clientVarsService.setVariable("ForeignInvoicesForReassignment_TargetUserId", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getProposals_PaymentDateFrom() {
return clientVarsService.getVariable("Proposals_PaymentDateFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setProposals_PaymentDateFrom(value) {
return clientVarsService.setVariable("Proposals_PaymentDateFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getRequisitions_AmountFrom() {
return clientVarsService.getVariable("Requisitions_AmountFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal);
}

setRequisitions_AmountFrom(value) {
return clientVarsService.setVariable("Requisitions_AmountFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal, value);
}

getProposals_Bank() {
return clientVarsService.getVariable("Proposals_Bank", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setProposals_Bank(value) {
return clientVarsService.setVariable("Proposals_Bank", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getOrders_DateTo() {
return clientVarsService.getVariable("Orders_DateTo", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setOrders_DateTo(value) {
return clientVarsService.setVariable("Orders_DateTo", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getRequisitions_ProveedorFilter_UploadDateFrom() {
return clientVarsService.getVariable("Requisitions_ProveedorFilter_UploadDateFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setRequisitions_ProveedorFilter_UploadDateFrom(value) {
return clientVarsService.setVariable("Requisitions_ProveedorFilter_UploadDateFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getFoliosSAERejected_OrderNumber() {
return clientVarsService.getVariable("FoliosSAERejected_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFoliosSAERejected_OrderNumber(value) {
return clientVarsService.setVariable("FoliosSAERejected_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getReport63_EndDate() {
return clientVarsService.getVariable("Report63_EndDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setReport63_EndDate(value) {
return clientVarsService.setVariable("Report63_EndDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getApplicationRole() {
return clientVarsService.getVariable("ApplicationRole", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setApplicationRole(value) {
return clientVarsService.setVariable("ApplicationRole", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getTimeToLogout() {
return clientVarsService.getVariable("TimeToLogout", "ConectaProveedores", OS$DataTypes.DataTypes.DateTime);
}

setTimeToLogout(value) {
return clientVarsService.setVariable("TimeToLogout", "ConectaProveedores", OS$DataTypes.DataTypes.DateTime, value);
}

getFoliosForReassignment_OriginalUserId() {
return clientVarsService.getVariable("FoliosForReassignment_OriginalUserId", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFoliosForReassignment_OriginalUserId(value) {
return clientVarsService.setVariable("FoliosForReassignment_OriginalUserId", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getOrderDistributionConfig_Role() {
return clientVarsService.getVariable("OrderDistributionConfig_Role", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setOrderDistributionConfig_Role(value) {
return clientVarsService.setVariable("OrderDistributionConfig_Role", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getRequisitions_RequisitionSearch() {
return clientVarsService.getVariable("Requisitions_RequisitionSearch", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setRequisitions_RequisitionSearch(value) {
return clientVarsService.setVariable("Requisitions_RequisitionSearch", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getFolioForApproval_CreatedToDate() {
return clientVarsService.getVariable("FolioForApproval_CreatedToDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setFolioForApproval_CreatedToDate(value) {
return clientVarsService.setVariable("FolioForApproval_CreatedToDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getOrders_SupplierId() {
return clientVarsService.getVariable("Orders_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setOrders_SupplierId(value) {
return clientVarsService.setVariable("Orders_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getFolioApproved_OrderNumber() {
return clientVarsService.getVariable("FolioApproved_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFolioApproved_OrderNumber(value) {
return clientVarsService.setVariable("FolioApproved_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getFolioApproved_CreatedOnDate() {
return clientVarsService.getVariable("FolioApproved_CreatedOnDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setFolioApproved_CreatedOnDate(value) {
return clientVarsService.setVariable("FolioApproved_CreatedOnDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getFolioContabilization_Filters_PaidOn() {
return clientVarsService.getVariable("FolioContabilization_Filters_PaidOn", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setFolioContabilization_Filters_PaidOn(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_PaidOn", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getFoliosSAERejected_FolioNumber() {
return clientVarsService.getVariable("FoliosSAERejected_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFoliosSAERejected_FolioNumber(value) {
return clientVarsService.setVariable("FoliosSAERejected_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getSupplier_Fechaanticiposinicio() {
return clientVarsService.getVariable("Supplier_Fechaanticiposinicio", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setSupplier_Fechaanticiposinicio(value) {
return clientVarsService.setVariable("Supplier_Fechaanticiposinicio", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getReport60_AreaId() {
return clientVarsService.getVariable("Report60_AreaId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setReport60_AreaId(value) {
return clientVarsService.setVariable("Report60_AreaId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getAccountStatus_DateFrom() {
return clientVarsService.getVariable("AccountStatus_DateFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setAccountStatus_DateFrom(value) {
return clientVarsService.setVariable("AccountStatus_DateFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getFolioApproved_SupplierId() {
return clientVarsService.getVariable("FolioApproved_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setFolioApproved_SupplierId(value) {
return clientVarsService.setVariable("FolioApproved_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getInvoicesFCP_Name() {
return clientVarsService.getVariable("InvoicesFCP_Name", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setInvoicesFCP_Name(value) {
return clientVarsService.setVariable("InvoicesFCP_Name", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getOrderToApprove_Days() {
return clientVarsService.getVariable("OrderToApprove_Days", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setOrderToApprove_Days(value) {
return clientVarsService.setVariable("OrderToApprove_Days", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getFolioContabilization_Filters_FolioCreatedOn() {
return clientVarsService.getVariable("FolioContabilization_Filters_FolioCreatedOn", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setFolioContabilization_Filters_FolioCreatedOn(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_FolioCreatedOn", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getFolioForApproval_SupplierId() {
return clientVarsService.getVariable("FolioForApproval_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setFolioForApproval_SupplierId(value) {
return clientVarsService.setVariable("FolioForApproval_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getCommision_Leases_AmountMLTo() {
return clientVarsService.getVariable("Commision_Leases_AmountMLTo", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal);
}

setCommision_Leases_AmountMLTo(value) {
return clientVarsService.setVariable("Commision_Leases_AmountMLTo", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal, value);
}

getFolioContabilization_Filters_SpecialApprovalId() {
return clientVarsService.getVariable("FolioContabilization_Filters_SpecialApprovalId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setFolioContabilization_Filters_SpecialApprovalId(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_SpecialApprovalId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getFolioForApproval_CreatedOnDate() {
return clientVarsService.getVariable("FolioForApproval_CreatedOnDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setFolioForApproval_CreatedOnDate(value) {
return clientVarsService.setVariable("FolioForApproval_CreatedOnDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getReport63_Applicant() {
return clientVarsService.getVariable("Report63_Applicant", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setReport63_Applicant(value) {
return clientVarsService.setVariable("Report63_Applicant", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getProposals_AmountMLTo() {
return clientVarsService.getVariable("Proposals_AmountMLTo", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal);
}

setProposals_AmountMLTo(value) {
return clientVarsService.setVariable("Proposals_AmountMLTo", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal, value);
}

getCommision_Operator_AmountML() {
return clientVarsService.getVariable("Commision_Operator_AmountML", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setCommision_Operator_AmountML(value) {
return clientVarsService.setVariable("Commision_Operator_AmountML", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getCommision_Leases_AssignedTo() {
return clientVarsService.getVariable("Commision_Leases_AssignedTo", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setCommision_Leases_AssignedTo(value) {
return clientVarsService.setVariable("Commision_Leases_AssignedTo", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getCommision_Leases_TypeId() {
return clientVarsService.getVariable("Commision_Leases_TypeId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setCommision_Leases_TypeId(value) {
return clientVarsService.setVariable("Commision_Leases_TypeId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getInvoice_ApprovalStatusId() {
return clientVarsService.getVariable("Invoice_ApprovalStatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setInvoice_ApprovalStatusId(value) {
return clientVarsService.setVariable("Invoice_ApprovalStatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getOrderApproved_Number() {
return clientVarsService.getVariable("OrderApproved_Number", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setOrderApproved_Number(value) {
return clientVarsService.setVariable("OrderApproved_Number", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getOrders_DateFrom() {
return clientVarsService.getVariable("Orders_DateFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setOrders_DateFrom(value) {
return clientVarsService.setVariable("Orders_DateFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getPreApprovalFolios_SupplierId() {
return clientVarsService.getVariable("PreApprovalFolios_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setPreApprovalFolios_SupplierId(value) {
return clientVarsService.setVariable("PreApprovalFolios_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getTreasury_PaymentDate() {
return clientVarsService.getVariable("Treasury_PaymentDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setTreasury_PaymentDate(value) {
return clientVarsService.setVariable("Treasury_PaymentDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getReport60_Applicant() {
return clientVarsService.getVariable("Report60_Applicant", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setReport60_Applicant(value) {
return clientVarsService.setVariable("Report60_Applicant", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getUserPhotoURL() {
return clientVarsService.getVariable("UserPhotoURL", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setUserPhotoURL(value) {
return clientVarsService.setVariable("UserPhotoURL", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getOrderDistributionConfig_Direction() {
return clientVarsService.getVariable("OrderDistributionConfig_Direction", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setOrderDistributionConfig_Direction(value) {
return clientVarsService.setVariable("OrderDistributionConfig_Direction", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getInvReport48_InvoiceName() {
return clientVarsService.getVariable("InvReport48_InvoiceName", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setInvReport48_InvoiceName(value) {
return clientVarsService.setVariable("InvReport48_InvoiceName", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getPreApprovalFolios_FolioNumber() {
return clientVarsService.getVariable("PreApprovalFolios_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setPreApprovalFolios_FolioNumber(value) {
return clientVarsService.setVariable("PreApprovalFolios_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getAccountStatus_InvoiceStatus() {
return clientVarsService.getVariable("AccountStatus_InvoiceStatus", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setAccountStatus_InvoiceStatus(value) {
return clientVarsService.setVariable("AccountStatus_InvoiceStatus", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getForeignInvoicesPendingValidation_FolioNumber() {
return clientVarsService.getVariable("ForeignInvoicesPendingValidation_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setForeignInvoicesPendingValidation_FolioNumber(value) {
return clientVarsService.setVariable("ForeignInvoicesPendingValidation_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getLastURL() {
return clientVarsService.getVariable("LastURL", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setLastURL(value) {
return clientVarsService.setVariable("LastURL", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getTreasury_Status() {
return clientVarsService.getVariable("Treasury_Status", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setTreasury_Status(value) {
return clientVarsService.setVariable("Treasury_Status", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getSupplier_Fechacompensadasfin() {
return clientVarsService.getVariable("Supplier_Fechacompensadasfin", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setSupplier_Fechacompensadasfin(value) {
return clientVarsService.setVariable("Supplier_Fechacompensadasfin", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getInvoicesFCP_SupplierId() {
return clientVarsService.getVariable("InvoicesFCP_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setInvoicesFCP_SupplierId(value) {
return clientVarsService.setVariable("InvoicesFCP_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getFoliosForReassignment_OrderNumber() {
return clientVarsService.getVariable("FoliosForReassignment_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFoliosForReassignment_OrderNumber(value) {
return clientVarsService.setVariable("FoliosForReassignment_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getCommision_Leases_CompanyId() {
return clientVarsService.getVariable("Commision_Leases_CompanyId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setCommision_Leases_CompanyId(value) {
return clientVarsService.setVariable("Commision_Leases_CompanyId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getReport63_StartDate() {
return clientVarsService.getVariable("Report63_StartDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setReport63_StartDate(value) {
return clientVarsService.setVariable("Report63_StartDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getInvReport48_DateTo() {
return clientVarsService.getVariable("InvReport48_DateTo", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setInvReport48_DateTo(value) {
return clientVarsService.setVariable("InvReport48_DateTo", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getRequisitions_RegionId() {
return clientVarsService.getVariable("Requisitions_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setRequisitions_RegionId(value) {
return clientVarsService.setVariable("Requisitions_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getOffsetUtc() {
return clientVarsService.getVariable("OffsetUtc", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, 0);
}

setOffsetUtc(value) {
return clientVarsService.setVariable("OffsetUtc", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getReport62_RegionId() {
return clientVarsService.getVariable("Report62_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setReport62_RegionId(value) {
return clientVarsService.setVariable("Report62_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getFolioContabilization_Filters_Project() {
return clientVarsService.getVariable("FolioContabilization_Filters_Project", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFolioContabilization_Filters_Project(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_Project", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getFolioContabilization_Filters_AmountTo() {
return clientVarsService.getVariable("FolioContabilization_Filters_AmountTo", "ConectaProveedores", OS$DataTypes.DataTypes.Currency);
}

setFolioContabilization_Filters_AmountTo(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_AmountTo", "ConectaProveedores", OS$DataTypes.DataTypes.Currency, value);
}

getTreasury_ProposalSearch() {
return clientVarsService.getVariable("Treasury_ProposalSearch", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setTreasury_ProposalSearch(value) {
return clientVarsService.setVariable("Treasury_ProposalSearch", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getOrders_RegionId() {
return clientVarsService.getVariable("Orders_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setOrders_RegionId(value) {
return clientVarsService.setVariable("Orders_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getInvoice_CompanyId() {
return clientVarsService.getVariable("Invoice_CompanyId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setInvoice_CompanyId(value) {
return clientVarsService.setVariable("Invoice_CompanyId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getReport63_OrderNumber() {
return clientVarsService.getVariable("Report63_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setReport63_OrderNumber(value) {
return clientVarsService.setVariable("Report63_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getReport62_SupplierId() {
return clientVarsService.getVariable("Report62_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setReport62_SupplierId(value) {
return clientVarsService.setVariable("Report62_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getRequisitions_CompanyId() {
return clientVarsService.getVariable("Requisitions_CompanyId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setRequisitions_CompanyId(value) {
return clientVarsService.setVariable("Requisitions_CompanyId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getUserName() {
return clientVarsService.getVariable("UserName", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setUserName(value) {
return clientVarsService.setVariable("UserName", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getOrderDistributionConfig_ApplicantDescription() {
return clientVarsService.getVariable("OrderDistributionConfig_ApplicantDescription", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setOrderDistributionConfig_ApplicantDescription(value) {
return clientVarsService.setVariable("OrderDistributionConfig_ApplicantDescription", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getOrderToComplement_SupplierId() {
return clientVarsService.getVariable("OrderToComplement_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setOrderToComplement_SupplierId(value) {
return clientVarsService.setVariable("OrderToComplement_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getRequisitions_ApprovalStatusId() {
return clientVarsService.getVariable("Requisitions_ApprovalStatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setRequisitions_ApprovalStatusId(value) {
return clientVarsService.setVariable("Requisitions_ApprovalStatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getInvoicesFCP_FolioNumber() {
return clientVarsService.getVariable("InvoicesFCP_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setInvoicesFCP_FolioNumber(value) {
return clientVarsService.setVariable("InvoicesFCP_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getCommision_Leases_AmountMLFrom() {
return clientVarsService.getVariable("Commision_Leases_AmountMLFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal);
}

setCommision_Leases_AmountMLFrom(value) {
return clientVarsService.setVariable("Commision_Leases_AmountMLFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal, value);
}

getInvoice_UploadDateFrom() {
return clientVarsService.getVariable("Invoice_UploadDateFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setInvoice_UploadDateFrom(value) {
return clientVarsService.setVariable("Invoice_UploadDateFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getOrderInComplement_SupplierId() {
return clientVarsService.getVariable("OrderInComplement_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setOrderInComplement_SupplierId(value) {
return clientVarsService.setVariable("OrderInComplement_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getSupplier_Fechapartidasabiertas() {
return clientVarsService.getVariable("Supplier_Fechapartidasabiertas", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setSupplier_Fechapartidasabiertas(value) {
return clientVarsService.setVariable("Supplier_Fechapartidasabiertas", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getFoliosSAERejected_SupplierId() {
return clientVarsService.getVariable("FoliosSAERejected_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setFoliosSAERejected_SupplierId(value) {
return clientVarsService.setVariable("FoliosSAERejected_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getRequisitions_RequisitionsStatusId() {
return clientVarsService.getVariable("Requisitions_RequisitionsStatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setRequisitions_RequisitionsStatusId(value) {
return clientVarsService.setVariable("Requisitions_RequisitionsStatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getEnviroment() {
return clientVarsService.getVariable("Enviroment", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setEnviroment(value) {
return clientVarsService.setVariable("Enviroment", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getOrderInComplement_Number() {
return clientVarsService.getVariable("OrderInComplement_Number", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setOrderInComplement_Number(value) {
return clientVarsService.setVariable("OrderInComplement_Number", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getInvoice_SupplierId() {
return clientVarsService.getVariable("Invoice_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setInvoice_SupplierId(value) {
return clientVarsService.setVariable("Invoice_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getReport60_SupplierId() {
return clientVarsService.getVariable("Report60_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setReport60_SupplierId(value) {
return clientVarsService.setVariable("Report60_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getTreasury_AmountMLTo() {
return clientVarsService.getVariable("Treasury_AmountMLTo", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal);
}

setTreasury_AmountMLTo(value) {
return clientVarsService.setVariable("Treasury_AmountMLTo", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal, value);
}

getReport60_RegionId() {
return clientVarsService.getVariable("Report60_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setReport60_RegionId(value) {
return clientVarsService.setVariable("Report60_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getFolioForApproval_RegionId() {
return clientVarsService.getVariable("FolioForApproval_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setFolioForApproval_RegionId(value) {
return clientVarsService.setVariable("FolioForApproval_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getCommision_Leases_UploadDate() {
return clientVarsService.getVariable("Commision_Leases_UploadDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setCommision_Leases_UploadDate(value) {
return clientVarsService.setVariable("Commision_Leases_UploadDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getFolioContabilization_Filters_FolioNumber() {
return clientVarsService.getVariable("FolioContabilization_Filters_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFolioContabilization_Filters_FolioNumber(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getProposals_Statuses() {
return clientVarsService.getVariable("Proposals_Statuses", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setProposals_Statuses(value) {
return clientVarsService.setVariable("Proposals_Statuses", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getOrderInComplement_Days() {
return clientVarsService.getVariable("OrderInComplement_Days", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setOrderInComplement_Days(value) {
return clientVarsService.setVariable("OrderInComplement_Days", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getTreasury_Operator_AmountML() {
return clientVarsService.getVariable("Treasury_Operator_AmountML", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setTreasury_Operator_AmountML(value) {
return clientVarsService.setVariable("Treasury_Operator_AmountML", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getRequisitions_ProjectId() {
return clientVarsService.getVariable("Requisitions_ProjectId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setRequisitions_ProjectId(value) {
return clientVarsService.setVariable("Requisitions_ProjectId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getUnsuccessfulEntries_SAPError() {
return clientVarsService.getVariable("UnsuccessfulEntries_SAPError", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setUnsuccessfulEntries_SAPError(value) {
return clientVarsService.setVariable("UnsuccessfulEntries_SAPError", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getUnsuccessfulEntries_FolioNumber() {
return clientVarsService.getVariable("UnsuccessfulEntries_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setUnsuccessfulEntries_FolioNumber(value) {
return clientVarsService.setVariable("UnsuccessfulEntries_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getReport60_StartDate() {
return clientVarsService.getVariable("Report60_StartDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setReport60_StartDate(value) {
return clientVarsService.setVariable("Report60_StartDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getReport60_EndDate() {
return clientVarsService.getVariable("Report60_EndDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setReport60_EndDate(value) {
return clientVarsService.setVariable("Report60_EndDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getInvoice_ProjectId() {
return clientVarsService.getVariable("Invoice_ProjectId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setInvoice_ProjectId(value) {
return clientVarsService.setVariable("Invoice_ProjectId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getOrderDistributionConfig_Division() {
return clientVarsService.getVariable("OrderDistributionConfig_Division", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setOrderDistributionConfig_Division(value) {
return clientVarsService.setVariable("OrderDistributionConfig_Division", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getForeignInvoicesPendingValidation_StatusId() {
return clientVarsService.getVariable("ForeignInvoicesPendingValidation_StatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setForeignInvoicesPendingValidation_StatusId(value) {
return clientVarsService.setVariable("ForeignInvoicesPendingValidation_StatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getSupplier_Fechacompensadasinicio() {
return clientVarsService.getVariable("Supplier_Fechacompensadasinicio", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setSupplier_Fechacompensadasinicio(value) {
return clientVarsService.setVariable("Supplier_Fechacompensadasinicio", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getOrderWithErrors_Days() {
return clientVarsService.getVariable("OrderWithErrors_Days", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setOrderWithErrors_Days(value) {
return clientVarsService.setVariable("OrderWithErrors_Days", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getFolioContabilization_Filters_InvoiceStatusId() {
return clientVarsService.getVariable("FolioContabilization_Filters_InvoiceStatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setFolioContabilization_Filters_InvoiceStatusId(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_InvoiceStatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getFolioApproved_StatusId() {
return clientVarsService.getVariable("FolioApproved_StatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setFolioApproved_StatusId(value) {
return clientVarsService.setVariable("FolioApproved_StatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getAccountStatus_DateTo() {
return clientVarsService.getVariable("AccountStatus_DateTo", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setAccountStatus_DateTo(value) {
return clientVarsService.setVariable("AccountStatus_DateTo", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getFolioContabilization_Filters_OrderMainNumber() {
return clientVarsService.getVariable("FolioContabilization_Filters_OrderMainNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFolioContabilization_Filters_OrderMainNumber(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_OrderMainNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getRequisitions_UploadDate() {
return clientVarsService.getVariable("Requisitions_UploadDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setRequisitions_UploadDate(value) {
return clientVarsService.setVariable("Requisitions_UploadDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getInvReport48_RegionId() {
return clientVarsService.getVariable("InvReport48_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setInvReport48_RegionId(value) {
return clientVarsService.setVariable("InvReport48_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getFolioForApproval_AssignedToMe() {
return clientVarsService.getVariable("FolioForApproval_AssignedToMe", "ConectaProveedores", OS$DataTypes.DataTypes.Boolean, true);
}

setFolioForApproval_AssignedToMe(value) {
return clientVarsService.setVariable("FolioForApproval_AssignedToMe", "ConectaProveedores", OS$DataTypes.DataTypes.Boolean, value);
}

getReport60_OrderNumber() {
return clientVarsService.getVariable("Report60_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setReport60_OrderNumber(value) {
return clientVarsService.setVariable("Report60_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getUnsuccessfulEntries_OrderNumber() {
return clientVarsService.getVariable("UnsuccessfulEntries_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setUnsuccessfulEntries_OrderNumber(value) {
return clientVarsService.setVariable("UnsuccessfulEntries_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getOrderApproved_SupplierId() {
return clientVarsService.getVariable("OrderApproved_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setOrderApproved_SupplierId(value) {
return clientVarsService.setVariable("OrderApproved_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getPreApprovalFolios_OrderNumber() {
return clientVarsService.getVariable("PreApprovalFolios_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setPreApprovalFolios_OrderNumber(value) {
return clientVarsService.setVariable("PreApprovalFolios_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getUnsuccessfulEntries_FolioStatus() {
return clientVarsService.getVariable("UnsuccessfulEntries_FolioStatus", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setUnsuccessfulEntries_FolioStatus(value) {
return clientVarsService.setVariable("UnsuccessfulEntries_FolioStatus", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getForeignInvoicesForReassignment_FolioNumber() {
return clientVarsService.getVariable("ForeignInvoicesForReassignment_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setForeignInvoicesForReassignment_FolioNumber(value) {
return clientVarsService.setVariable("ForeignInvoicesForReassignment_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getTreasury_Region() {
return clientVarsService.getVariable("Treasury_Region", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setTreasury_Region(value) {
return clientVarsService.setVariable("Treasury_Region", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getFolioContabilization_Filters_Period() {
return clientVarsService.getVariable("FolioContabilization_Filters_Period", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFolioContabilization_Filters_Period(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_Period", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getForeignInvoicesPendingValidation_OrderNumber() {
return clientVarsService.getVariable("ForeignInvoicesPendingValidation_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setForeignInvoicesPendingValidation_OrderNumber(value) {
return clientVarsService.setVariable("ForeignInvoicesPendingValidation_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getFolioContabilization_Filters_AssignedTo() {
return clientVarsService.getVariable("FolioContabilization_Filters_AssignedTo", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFolioContabilization_Filters_AssignedTo(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_AssignedTo", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getFoliosForReassignment_FolioNumber() {
return clientVarsService.getVariable("FoliosForReassignment_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFoliosForReassignment_FolioNumber(value) {
return clientVarsService.setVariable("FoliosForReassignment_FolioNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getFolioContabilization_Filters_FrequencyId() {
return clientVarsService.getVariable("FolioContabilization_Filters_FrequencyId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setFolioContabilization_Filters_FrequencyId(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_FrequencyId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getTreasury_Assigned() {
return clientVarsService.getVariable("Treasury_Assigned", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setTreasury_Assigned(value) {
return clientVarsService.setVariable("Treasury_Assigned", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getInvoice_UploadDateTo() {
return clientVarsService.getVariable("Invoice_UploadDateTo", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setInvoice_UploadDateTo(value) {
return clientVarsService.setVariable("Invoice_UploadDateTo", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getInvoicesFCP_TotalAmount() {
return clientVarsService.getVariable("InvoicesFCP_TotalAmount", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setInvoicesFCP_TotalAmount(value) {
return clientVarsService.setVariable("InvoicesFCP_TotalAmount", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getOrderWithErrors_SupplierId() {
return clientVarsService.getVariable("OrderWithErrors_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setOrderWithErrors_SupplierId(value) {
return clientVarsService.setVariable("OrderWithErrors_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getOrderWithErrors_Number() {
return clientVarsService.getVariable("OrderWithErrors_Number", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setOrderWithErrors_Number(value) {
return clientVarsService.setVariable("OrderWithErrors_Number", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getOrderToApprove_Number() {
return clientVarsService.getVariable("OrderToApprove_Number", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setOrderToApprove_Number(value) {
return clientVarsService.setVariable("OrderToApprove_Number", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getOrderToApprove_SupplierId() {
return clientVarsService.getVariable("OrderToApprove_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setOrderToApprove_SupplierId(value) {
return clientVarsService.setVariable("OrderToApprove_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getSupplier_Sociedad() {
return clientVarsService.getVariable("Supplier_Sociedad", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setSupplier_Sociedad(value) {
return clientVarsService.setVariable("Supplier_Sociedad", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getProposals_Operator_AmountML() {
return clientVarsService.getVariable("Proposals_Operator_AmountML", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setProposals_Operator_AmountML(value) {
return clientVarsService.setVariable("Proposals_Operator_AmountML", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getInvoice_InvoiceName() {
return clientVarsService.getVariable("Invoice_InvoiceName", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setInvoice_InvoiceName(value) {
return clientVarsService.setVariable("Invoice_InvoiceName", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getProposals_UploadType() {
return clientVarsService.getVariable("Proposals_UploadType", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setProposals_UploadType(value) {
return clientVarsService.setVariable("Proposals_UploadType", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getProposals_Type() {
return clientVarsService.getVariable("Proposals_Type", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setProposals_Type(value) {
return clientVarsService.setVariable("Proposals_Type", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getCommision_Leases_PaymentDate() {
return clientVarsService.getVariable("Commision_Leases_PaymentDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setCommision_Leases_PaymentDate(value) {
return clientVarsService.setVariable("Commision_Leases_PaymentDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getProposals_Status() {
return clientVarsService.getVariable("Proposals_Status", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setProposals_Status(value) {
return clientVarsService.setVariable("Proposals_Status", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getInvoice_RequisitionName() {
return clientVarsService.getVariable("Invoice_RequisitionName", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setInvoice_RequisitionName(value) {
return clientVarsService.setVariable("Invoice_RequisitionName", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getInvReport48_DateFrom() {
return clientVarsService.getVariable("InvReport48_DateFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setInvReport48_DateFrom(value) {
return clientVarsService.setVariable("InvReport48_DateFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getReport63_RegionId() {
return clientVarsService.getVariable("Report63_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setReport63_RegionId(value) {
return clientVarsService.setVariable("Report63_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getCommision_Leases_ProposalSearch() {
return clientVarsService.getVariable("Commision_Leases_ProposalSearch", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setCommision_Leases_ProposalSearch(value) {
return clientVarsService.setVariable("Commision_Leases_ProposalSearch", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getProposals_Regions() {
return clientVarsService.getVariable("Proposals_Regions", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setProposals_Regions(value) {
return clientVarsService.setVariable("Proposals_Regions", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getTreasury_CreationDate() {
return clientVarsService.getVariable("Treasury_CreationDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setTreasury_CreationDate(value) {
return clientVarsService.setVariable("Treasury_CreationDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getCommision_Leases_BankId() {
return clientVarsService.getVariable("Commision_Leases_BankId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setCommision_Leases_BankId(value) {
return clientVarsService.setVariable("Commision_Leases_BankId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getReport62_DateTo() {
return clientVarsService.getVariable("Report62_DateTo", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setReport62_DateTo(value) {
return clientVarsService.setVariable("Report62_DateTo", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getProposals_Currencies() {
return clientVarsService.getVariable("Proposals_Currencies", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setProposals_Currencies(value) {
return clientVarsService.setVariable("Proposals_Currencies", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getPreApprovalFolios_RegionId() {
return clientVarsService.getVariable("PreApprovalFolios_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setPreApprovalFolios_RegionId(value) {
return clientVarsService.setVariable("PreApprovalFolios_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getFolioContabilization_Filters_AmountFrom() {
return clientVarsService.getVariable("FolioContabilization_Filters_AmountFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setFolioContabilization_Filters_AmountFrom(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_AmountFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getOrders_Number() {
return clientVarsService.getVariable("Orders_Number", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setOrders_Number(value) {
return clientVarsService.setVariable("Orders_Number", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getFolioContabilization_Filters_SupplierId() {
return clientVarsService.getVariable("FolioContabilization_Filters_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setFolioContabilization_Filters_SupplierId(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getCommision_Leases_SupplierId() {
return clientVarsService.getVariable("Commision_Leases_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setCommision_Leases_SupplierId(value) {
return clientVarsService.setVariable("Commision_Leases_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getReport60_SociedadId() {
return clientVarsService.getVariable("Report60_SociedadId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setReport60_SociedadId(value) {
return clientVarsService.setVariable("Report60_SociedadId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getSupplier_Fechaanticiposfin() {
return clientVarsService.getVariable("Supplier_Fechaanticiposfin", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setSupplier_Fechaanticiposfin(value) {
return clientVarsService.setVariable("Supplier_Fechaanticiposfin", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getCommision_Leases_RegionId() {
return clientVarsService.getVariable("Commision_Leases_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setCommision_Leases_RegionId(value) {
return clientVarsService.setVariable("Commision_Leases_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getOrderDistributionConfig_Applicant() {
return clientVarsService.getVariable("OrderDistributionConfig_Applicant", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setOrderDistributionConfig_Applicant(value) {
return clientVarsService.setVariable("OrderDistributionConfig_Applicant", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getFolioForApproval_OrderNumber() {
return clientVarsService.getVariable("FolioForApproval_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFolioForApproval_OrderNumber(value) {
return clientVarsService.setVariable("FolioForApproval_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getInvReport48_SupplierId() {
return clientVarsService.getVariable("InvReport48_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setInvReport48_SupplierId(value) {
return clientVarsService.setVariable("InvReport48_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getProposals_PaymentDateTo() {
return clientVarsService.getVariable("Proposals_PaymentDateTo", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setProposals_PaymentDateTo(value) {
return clientVarsService.setVariable("Proposals_PaymentDateTo", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getRequisitions_SupplierId() {
return clientVarsService.getVariable("Requisitions_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setRequisitions_SupplierId(value) {
return clientVarsService.setVariable("Requisitions_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getProposals_AmountMLFrom() {
return clientVarsService.getVariable("Proposals_AmountMLFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal);
}

setProposals_AmountMLFrom(value) {
return clientVarsService.setVariable("Proposals_AmountMLFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal, value);
}

getFolioContabilization_Filters_InvoiceCreatedOn() {
return clientVarsService.getVariable("FolioContabilization_Filters_InvoiceCreatedOn", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setFolioContabilization_Filters_InvoiceCreatedOn(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_InvoiceCreatedOn", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getReport62_DateFrom() {
return clientVarsService.getVariable("Report62_DateFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setReport62_DateFrom(value) {
return clientVarsService.setVariable("Report62_DateFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getForeignInvoicesForReassignment_OriginalUserId() {
return clientVarsService.getVariable("ForeignInvoicesForReassignment_OriginalUserId", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setForeignInvoicesForReassignment_OriginalUserId(value) {
return clientVarsService.setVariable("ForeignInvoicesForReassignment_OriginalUserId", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getProposal_DocumentNumber() {
return clientVarsService.getVariable("Proposal_DocumentNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setProposal_DocumentNumber(value) {
return clientVarsService.setVariable("Proposal_DocumentNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getFolioApproved_RegionId() {
return clientVarsService.getVariable("FolioApproved_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setFolioApproved_RegionId(value) {
return clientVarsService.setVariable("FolioApproved_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getInvoicesFCP_UploadDate() {
return clientVarsService.getVariable("InvoicesFCP_UploadDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setInvoicesFCP_UploadDate(value) {
return clientVarsService.setVariable("InvoicesFCP_UploadDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getOrderToComplement_Days() {
return clientVarsService.getVariable("OrderToComplement_Days", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setOrderToComplement_Days(value) {
return clientVarsService.setVariable("OrderToComplement_Days", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getForeignInvoicesPendingValidation_SupplierId() {
return clientVarsService.getVariable("ForeignInvoicesPendingValidation_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setForeignInvoicesPendingValidation_SupplierId(value) {
return clientVarsService.setVariable("ForeignInvoicesPendingValidation_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getReport63_SociedadId() {
return clientVarsService.getVariable("Report63_SociedadId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setReport63_SociedadId(value) {
return clientVarsService.setVariable("Report63_SociedadId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getRequisitions_CostCenterId() {
return clientVarsService.getVariable("Requisitions_CostCenterId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setRequisitions_CostCenterId(value) {
return clientVarsService.setVariable("Requisitions_CostCenterId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getFolioContabilization_Filters_AccountingTypeId() {
return clientVarsService.getVariable("FolioContabilization_Filters_AccountingTypeId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setFolioContabilization_Filters_AccountingTypeId(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_AccountingTypeId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getFolioContabilization_Filters_BusinessValueSubCateg() {
return clientVarsService.getVariable("FolioContabilization_Filters_BusinessValueSubCateg", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFolioContabilization_Filters_BusinessValueSubCateg(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_BusinessValueSubCateg", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getRequisitions_ProveedorFilter_UploadDateTo() {
return clientVarsService.getVariable("Requisitions_ProveedorFilter_UploadDateTo", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setRequisitions_ProveedorFilter_UploadDateTo(value) {
return clientVarsService.setVariable("Requisitions_ProveedorFilter_UploadDateTo", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getTreasury_Bank() {
return clientVarsService.getVariable("Treasury_Bank", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setTreasury_Bank(value) {
return clientVarsService.setVariable("Treasury_Bank", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getOrderToComplement_Number() {
return clientVarsService.getVariable("OrderToComplement_Number", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setOrderToComplement_Number(value) {
return clientVarsService.setVariable("OrderToComplement_Number", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getProposals_ProposalSearch() {
return clientVarsService.getVariable("Proposals_ProposalSearch", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setProposals_ProposalSearch(value) {
return clientVarsService.setVariable("Proposals_ProposalSearch", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getRequisitions_AmountTo() {
return clientVarsService.getVariable("Requisitions_AmountTo", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal);
}

setRequisitions_AmountTo(value) {
return clientVarsService.setVariable("Requisitions_AmountTo", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal, value);
}

getFolioApproved_CreatedToDate() {
return clientVarsService.getVariable("FolioApproved_CreatedToDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date);
}

setFolioApproved_CreatedToDate(value) {
return clientVarsService.setVariable("FolioApproved_CreatedToDate", "ConectaProveedores", OS$DataTypes.DataTypes.Date, value);
}

getOrders_OrderStatusId() {
return clientVarsService.getVariable("Orders_OrderStatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setOrders_OrderStatusId(value) {
return clientVarsService.setVariable("Orders_OrderStatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getUnsuccessfulEntries_SupplierId() {
return clientVarsService.getVariable("UnsuccessfulEntries_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setUnsuccessfulEntries_SupplierId(value) {
return clientVarsService.setVariable("UnsuccessfulEntries_SupplierId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getInvoicesFCP_OrderNumber() {
return clientVarsService.getVariable("InvoicesFCP_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setInvoicesFCP_OrderNumber(value) {
return clientVarsService.setVariable("InvoicesFCP_OrderNumber", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getFoliosForReassignment_TargetUserId() {
return clientVarsService.getVariable("FoliosForReassignment_TargetUserId", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFoliosForReassignment_TargetUserId(value) {
return clientVarsService.setVariable("FoliosForReassignment_TargetUserId", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getCommision_Leases_ApprovalStatusId() {
return clientVarsService.getVariable("Commision_Leases_ApprovalStatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer);
}

setCommision_Leases_ApprovalStatusId(value) {
return clientVarsService.setVariable("Commision_Leases_ApprovalStatusId", "ConectaProveedores", OS$DataTypes.DataTypes.Integer, value);
}

getAccountStatus_RegionId() {
return clientVarsService.getVariable("AccountStatus_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger);
}

setAccountStatus_RegionId(value) {
return clientVarsService.setVariable("AccountStatus_RegionId", "ConectaProveedores", OS$DataTypes.DataTypes.LongInteger, value);
}

getTreasury_AmountMLFrom() {
return clientVarsService.getVariable("Treasury_AmountMLFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal);
}

setTreasury_AmountMLFrom(value) {
return clientVarsService.setVariable("Treasury_AmountMLFrom", "ConectaProveedores", OS$DataTypes.DataTypes.Decimal, value);
}

getOrderProviderList_Number() {
return clientVarsService.getVariable("OrderProviderList_Number", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setOrderProviderList_Number(value) {
return clientVarsService.setVariable("OrderProviderList_Number", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getFolioContabilization_Filters_InvoiceName() {
return clientVarsService.getVariable("FolioContabilization_Filters_InvoiceName", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFolioContabilization_Filters_InvoiceName(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_InvoiceName", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

getFolioContabilization_Filters_CurrencyId() {
return clientVarsService.getVariable("FolioContabilization_Filters_CurrencyId", "ConectaProveedores", OS$DataTypes.DataTypes.Text);
}

setFolioContabilization_Filters_CurrencyId(value) {
return clientVarsService.setVariable("FolioContabilization_Filters_CurrencyId", "ConectaProveedores", OS$DataTypes.DataTypes.Text, value);
}

serialize() {
return {
FolioForApproval_FolioNumber: OS$DataConversion.ServerDataConverter.to(this.getFolioForApproval_FolioNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
FolioApproved_FolioNumber: OS$DataConversion.ServerDataConverter.to(this.getFolioApproved_FolioNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Proposals_Region: OS$DataConversion.ServerDataConverter.to(this.getProposals_Region(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
TimeToWarning: OS$DataConversion.ServerDataConverter.to(this.getTimeToWarning(), {
dataType: OS$DataTypes.DataTypes.DateTime
}),
Report60_StatusId: OS$DataConversion.ServerDataConverter.to(this.getReport60_StatusId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
FolioForApproval_StatusId: OS$DataConversion.ServerDataConverter.to(this.getFolioForApproval_StatusId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
Proposals_Currency: OS$DataConversion.ServerDataConverter.to(this.getProposals_Currency(), {
dataType: OS$DataTypes.DataTypes.Text
}),
InvReport48_InvoiceStatusId: OS$DataConversion.ServerDataConverter.to(this.getInvReport48_InvoiceStatusId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
PreApprovalFolios_CreatedOn: OS$DataConversion.ServerDataConverter.to(this.getPreApprovalFolios_CreatedOn(), {
dataType: OS$DataTypes.DataTypes.Date
}),
AccountStatus_InvoiceName: OS$DataConversion.ServerDataConverter.to(this.getAccountStatus_InvoiceName(), {
dataType: OS$DataTypes.DataTypes.Text
}),
FolioContabilization_Filters_BusinessValueCategory: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_BusinessValueCategory(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Proposal_DocumentYear: OS$DataConversion.ServerDataConverter.to(this.getProposal_DocumentYear(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
MaxRecords: OS$DataConversion.ServerDataConverter.to(this.getMaxRecords(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
ForeignInvoicesForReassignment_OrderNumber: OS$DataConversion.ServerDataConverter.to(this.getForeignInvoicesForReassignment_OrderNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Report63_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getReport63_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
ForeignInvoicesForReassignment_TargetUserId: OS$DataConversion.ServerDataConverter.to(this.getForeignInvoicesForReassignment_TargetUserId(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Proposals_PaymentDateFrom: OS$DataConversion.ServerDataConverter.to(this.getProposals_PaymentDateFrom(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Requisitions_AmountFrom: OS$DataConversion.ServerDataConverter.to(this.getRequisitions_AmountFrom(), {
dataType: OS$DataTypes.DataTypes.Decimal
}),
Proposals_Bank: OS$DataConversion.ServerDataConverter.to(this.getProposals_Bank(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Orders_DateTo: OS$DataConversion.ServerDataConverter.to(this.getOrders_DateTo(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Requisitions_ProveedorFilter_UploadDateFrom: OS$DataConversion.ServerDataConverter.to(this.getRequisitions_ProveedorFilter_UploadDateFrom(), {
dataType: OS$DataTypes.DataTypes.Date
}),
FoliosSAERejected_OrderNumber: OS$DataConversion.ServerDataConverter.to(this.getFoliosSAERejected_OrderNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Report63_EndDate: OS$DataConversion.ServerDataConverter.to(this.getReport63_EndDate(), {
dataType: OS$DataTypes.DataTypes.Date
}),
ApplicationRole: OS$DataConversion.ServerDataConverter.to(this.getApplicationRole(), {
dataType: OS$DataTypes.DataTypes.Text
}),
TimeToLogout: OS$DataConversion.ServerDataConverter.to(this.getTimeToLogout(), {
dataType: OS$DataTypes.DataTypes.DateTime
}),
FoliosForReassignment_OriginalUserId: OS$DataConversion.ServerDataConverter.to(this.getFoliosForReassignment_OriginalUserId(), {
dataType: OS$DataTypes.DataTypes.Text
}),
OrderDistributionConfig_Role: OS$DataConversion.ServerDataConverter.to(this.getOrderDistributionConfig_Role(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Requisitions_RequisitionSearch: OS$DataConversion.ServerDataConverter.to(this.getRequisitions_RequisitionSearch(), {
dataType: OS$DataTypes.DataTypes.Text
}),
FolioForApproval_CreatedToDate: OS$DataConversion.ServerDataConverter.to(this.getFolioForApproval_CreatedToDate(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Orders_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getOrders_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
FolioApproved_OrderNumber: OS$DataConversion.ServerDataConverter.to(this.getFolioApproved_OrderNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
FolioApproved_CreatedOnDate: OS$DataConversion.ServerDataConverter.to(this.getFolioApproved_CreatedOnDate(), {
dataType: OS$DataTypes.DataTypes.Date
}),
FolioContabilization_Filters_PaidOn: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_PaidOn(), {
dataType: OS$DataTypes.DataTypes.Date
}),
FoliosSAERejected_FolioNumber: OS$DataConversion.ServerDataConverter.to(this.getFoliosSAERejected_FolioNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Supplier_Fechaanticiposinicio: OS$DataConversion.ServerDataConverter.to(this.getSupplier_Fechaanticiposinicio(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Report60_AreaId: OS$DataConversion.ServerDataConverter.to(this.getReport60_AreaId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
AccountStatus_DateFrom: OS$DataConversion.ServerDataConverter.to(this.getAccountStatus_DateFrom(), {
dataType: OS$DataTypes.DataTypes.Date
}),
FolioApproved_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getFolioApproved_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
InvoicesFCP_Name: OS$DataConversion.ServerDataConverter.to(this.getInvoicesFCP_Name(), {
dataType: OS$DataTypes.DataTypes.Text
}),
OrderToApprove_Days: OS$DataConversion.ServerDataConverter.to(this.getOrderToApprove_Days(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
FolioContabilization_Filters_FolioCreatedOn: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_FolioCreatedOn(), {
dataType: OS$DataTypes.DataTypes.Date
}),
FolioForApproval_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getFolioForApproval_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Commision_Leases_AmountMLTo: OS$DataConversion.ServerDataConverter.to(this.getCommision_Leases_AmountMLTo(), {
dataType: OS$DataTypes.DataTypes.Decimal
}),
FolioContabilization_Filters_SpecialApprovalId: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_SpecialApprovalId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
FolioForApproval_CreatedOnDate: OS$DataConversion.ServerDataConverter.to(this.getFolioForApproval_CreatedOnDate(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Report63_Applicant: OS$DataConversion.ServerDataConverter.to(this.getReport63_Applicant(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Proposals_AmountMLTo: OS$DataConversion.ServerDataConverter.to(this.getProposals_AmountMLTo(), {
dataType: OS$DataTypes.DataTypes.Decimal
}),
Commision_Operator_AmountML: OS$DataConversion.ServerDataConverter.to(this.getCommision_Operator_AmountML(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Commision_Leases_AssignedTo: OS$DataConversion.ServerDataConverter.to(this.getCommision_Leases_AssignedTo(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Commision_Leases_TypeId: OS$DataConversion.ServerDataConverter.to(this.getCommision_Leases_TypeId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
Invoice_ApprovalStatusId: OS$DataConversion.ServerDataConverter.to(this.getInvoice_ApprovalStatusId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
OrderApproved_Number: OS$DataConversion.ServerDataConverter.to(this.getOrderApproved_Number(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Orders_DateFrom: OS$DataConversion.ServerDataConverter.to(this.getOrders_DateFrom(), {
dataType: OS$DataTypes.DataTypes.Date
}),
PreApprovalFolios_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getPreApprovalFolios_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Treasury_PaymentDate: OS$DataConversion.ServerDataConverter.to(this.getTreasury_PaymentDate(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Report60_Applicant: OS$DataConversion.ServerDataConverter.to(this.getReport60_Applicant(), {
dataType: OS$DataTypes.DataTypes.Text
}),
UserPhotoURL: OS$DataConversion.ServerDataConverter.to(this.getUserPhotoURL(), {
dataType: OS$DataTypes.DataTypes.Text
}),
OrderDistributionConfig_Direction: OS$DataConversion.ServerDataConverter.to(this.getOrderDistributionConfig_Direction(), {
dataType: OS$DataTypes.DataTypes.Text
}),
InvReport48_InvoiceName: OS$DataConversion.ServerDataConverter.to(this.getInvReport48_InvoiceName(), {
dataType: OS$DataTypes.DataTypes.Text
}),
PreApprovalFolios_FolioNumber: OS$DataConversion.ServerDataConverter.to(this.getPreApprovalFolios_FolioNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
AccountStatus_InvoiceStatus: OS$DataConversion.ServerDataConverter.to(this.getAccountStatus_InvoiceStatus(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
ForeignInvoicesPendingValidation_FolioNumber: OS$DataConversion.ServerDataConverter.to(this.getForeignInvoicesPendingValidation_FolioNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
LastURL: OS$DataConversion.ServerDataConverter.to(this.getLastURL(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Treasury_Status: OS$DataConversion.ServerDataConverter.to(this.getTreasury_Status(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
Supplier_Fechacompensadasfin: OS$DataConversion.ServerDataConverter.to(this.getSupplier_Fechacompensadasfin(), {
dataType: OS$DataTypes.DataTypes.Date
}),
InvoicesFCP_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getInvoicesFCP_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
FoliosForReassignment_OrderNumber: OS$DataConversion.ServerDataConverter.to(this.getFoliosForReassignment_OrderNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Commision_Leases_CompanyId: OS$DataConversion.ServerDataConverter.to(this.getCommision_Leases_CompanyId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Report63_StartDate: OS$DataConversion.ServerDataConverter.to(this.getReport63_StartDate(), {
dataType: OS$DataTypes.DataTypes.Date
}),
InvReport48_DateTo: OS$DataConversion.ServerDataConverter.to(this.getInvReport48_DateTo(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Requisitions_RegionId: OS$DataConversion.ServerDataConverter.to(this.getRequisitions_RegionId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
OffsetUtc: OS$DataConversion.ServerDataConverter.to(this.getOffsetUtc(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
Report62_RegionId: OS$DataConversion.ServerDataConverter.to(this.getReport62_RegionId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
FolioContabilization_Filters_Project: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_Project(), {
dataType: OS$DataTypes.DataTypes.Text
}),
FolioContabilization_Filters_AmountTo: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_AmountTo(), {
dataType: OS$DataTypes.DataTypes.Currency
}),
Treasury_ProposalSearch: OS$DataConversion.ServerDataConverter.to(this.getTreasury_ProposalSearch(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Orders_RegionId: OS$DataConversion.ServerDataConverter.to(this.getOrders_RegionId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Invoice_CompanyId: OS$DataConversion.ServerDataConverter.to(this.getInvoice_CompanyId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Report63_OrderNumber: OS$DataConversion.ServerDataConverter.to(this.getReport63_OrderNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Report62_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getReport62_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Requisitions_CompanyId: OS$DataConversion.ServerDataConverter.to(this.getRequisitions_CompanyId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
UserName: OS$DataConversion.ServerDataConverter.to(this.getUserName(), {
dataType: OS$DataTypes.DataTypes.Text
}),
OrderDistributionConfig_ApplicantDescription: OS$DataConversion.ServerDataConverter.to(this.getOrderDistributionConfig_ApplicantDescription(), {
dataType: OS$DataTypes.DataTypes.Text
}),
OrderToComplement_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getOrderToComplement_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Requisitions_ApprovalStatusId: OS$DataConversion.ServerDataConverter.to(this.getRequisitions_ApprovalStatusId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
InvoicesFCP_FolioNumber: OS$DataConversion.ServerDataConverter.to(this.getInvoicesFCP_FolioNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Commision_Leases_AmountMLFrom: OS$DataConversion.ServerDataConverter.to(this.getCommision_Leases_AmountMLFrom(), {
dataType: OS$DataTypes.DataTypes.Decimal
}),
Invoice_UploadDateFrom: OS$DataConversion.ServerDataConverter.to(this.getInvoice_UploadDateFrom(), {
dataType: OS$DataTypes.DataTypes.Date
}),
OrderInComplement_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getOrderInComplement_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Supplier_Fechapartidasabiertas: OS$DataConversion.ServerDataConverter.to(this.getSupplier_Fechapartidasabiertas(), {
dataType: OS$DataTypes.DataTypes.Date
}),
FoliosSAERejected_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getFoliosSAERejected_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Requisitions_RequisitionsStatusId: OS$DataConversion.ServerDataConverter.to(this.getRequisitions_RequisitionsStatusId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
Enviroment: OS$DataConversion.ServerDataConverter.to(this.getEnviroment(), {
dataType: OS$DataTypes.DataTypes.Text
}),
OrderInComplement_Number: OS$DataConversion.ServerDataConverter.to(this.getOrderInComplement_Number(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Invoice_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getInvoice_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Report60_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getReport60_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Treasury_AmountMLTo: OS$DataConversion.ServerDataConverter.to(this.getTreasury_AmountMLTo(), {
dataType: OS$DataTypes.DataTypes.Decimal
}),
Report60_RegionId: OS$DataConversion.ServerDataConverter.to(this.getReport60_RegionId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
FolioForApproval_RegionId: OS$DataConversion.ServerDataConverter.to(this.getFolioForApproval_RegionId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Commision_Leases_UploadDate: OS$DataConversion.ServerDataConverter.to(this.getCommision_Leases_UploadDate(), {
dataType: OS$DataTypes.DataTypes.Date
}),
FolioContabilization_Filters_FolioNumber: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_FolioNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Proposals_Statuses: OS$DataConversion.ServerDataConverter.to(this.getProposals_Statuses(), {
dataType: OS$DataTypes.DataTypes.Text
}),
OrderInComplement_Days: OS$DataConversion.ServerDataConverter.to(this.getOrderInComplement_Days(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
Treasury_Operator_AmountML: OS$DataConversion.ServerDataConverter.to(this.getTreasury_Operator_AmountML(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Requisitions_ProjectId: OS$DataConversion.ServerDataConverter.to(this.getRequisitions_ProjectId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
UnsuccessfulEntries_SAPError: OS$DataConversion.ServerDataConverter.to(this.getUnsuccessfulEntries_SAPError(), {
dataType: OS$DataTypes.DataTypes.Text
}),
UnsuccessfulEntries_FolioNumber: OS$DataConversion.ServerDataConverter.to(this.getUnsuccessfulEntries_FolioNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Report60_StartDate: OS$DataConversion.ServerDataConverter.to(this.getReport60_StartDate(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Report60_EndDate: OS$DataConversion.ServerDataConverter.to(this.getReport60_EndDate(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Invoice_ProjectId: OS$DataConversion.ServerDataConverter.to(this.getInvoice_ProjectId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
OrderDistributionConfig_Division: OS$DataConversion.ServerDataConverter.to(this.getOrderDistributionConfig_Division(), {
dataType: OS$DataTypes.DataTypes.Text
}),
ForeignInvoicesPendingValidation_StatusId: OS$DataConversion.ServerDataConverter.to(this.getForeignInvoicesPendingValidation_StatusId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
Supplier_Fechacompensadasinicio: OS$DataConversion.ServerDataConverter.to(this.getSupplier_Fechacompensadasinicio(), {
dataType: OS$DataTypes.DataTypes.Date
}),
OrderWithErrors_Days: OS$DataConversion.ServerDataConverter.to(this.getOrderWithErrors_Days(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
FolioContabilization_Filters_InvoiceStatusId: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_InvoiceStatusId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
FolioApproved_StatusId: OS$DataConversion.ServerDataConverter.to(this.getFolioApproved_StatusId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
AccountStatus_DateTo: OS$DataConversion.ServerDataConverter.to(this.getAccountStatus_DateTo(), {
dataType: OS$DataTypes.DataTypes.Date
}),
FolioContabilization_Filters_OrderMainNumber: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_OrderMainNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Requisitions_UploadDate: OS$DataConversion.ServerDataConverter.to(this.getRequisitions_UploadDate(), {
dataType: OS$DataTypes.DataTypes.Date
}),
InvReport48_RegionId: OS$DataConversion.ServerDataConverter.to(this.getInvReport48_RegionId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
FolioForApproval_AssignedToMe: OS$DataConversion.ServerDataConverter.to(this.getFolioForApproval_AssignedToMe(), {
dataType: OS$DataTypes.DataTypes.Boolean
}),
Report60_OrderNumber: OS$DataConversion.ServerDataConverter.to(this.getReport60_OrderNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
UnsuccessfulEntries_OrderNumber: OS$DataConversion.ServerDataConverter.to(this.getUnsuccessfulEntries_OrderNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
OrderApproved_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getOrderApproved_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
PreApprovalFolios_OrderNumber: OS$DataConversion.ServerDataConverter.to(this.getPreApprovalFolios_OrderNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
UnsuccessfulEntries_FolioStatus: OS$DataConversion.ServerDataConverter.to(this.getUnsuccessfulEntries_FolioStatus(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
ForeignInvoicesForReassignment_FolioNumber: OS$DataConversion.ServerDataConverter.to(this.getForeignInvoicesForReassignment_FolioNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Treasury_Region: OS$DataConversion.ServerDataConverter.to(this.getTreasury_Region(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
FolioContabilization_Filters_Period: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_Period(), {
dataType: OS$DataTypes.DataTypes.Text
}),
ForeignInvoicesPendingValidation_OrderNumber: OS$DataConversion.ServerDataConverter.to(this.getForeignInvoicesPendingValidation_OrderNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
FolioContabilization_Filters_AssignedTo: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_AssignedTo(), {
dataType: OS$DataTypes.DataTypes.Text
}),
FoliosForReassignment_FolioNumber: OS$DataConversion.ServerDataConverter.to(this.getFoliosForReassignment_FolioNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
FolioContabilization_Filters_FrequencyId: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_FrequencyId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
Treasury_Assigned: OS$DataConversion.ServerDataConverter.to(this.getTreasury_Assigned(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Invoice_UploadDateTo: OS$DataConversion.ServerDataConverter.to(this.getInvoice_UploadDateTo(), {
dataType: OS$DataTypes.DataTypes.Date
}),
InvoicesFCP_TotalAmount: OS$DataConversion.ServerDataConverter.to(this.getInvoicesFCP_TotalAmount(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
OrderWithErrors_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getOrderWithErrors_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
OrderWithErrors_Number: OS$DataConversion.ServerDataConverter.to(this.getOrderWithErrors_Number(), {
dataType: OS$DataTypes.DataTypes.Text
}),
OrderToApprove_Number: OS$DataConversion.ServerDataConverter.to(this.getOrderToApprove_Number(), {
dataType: OS$DataTypes.DataTypes.Text
}),
OrderToApprove_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getOrderToApprove_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Supplier_Sociedad: OS$DataConversion.ServerDataConverter.to(this.getSupplier_Sociedad(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Proposals_Operator_AmountML: OS$DataConversion.ServerDataConverter.to(this.getProposals_Operator_AmountML(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Invoice_InvoiceName: OS$DataConversion.ServerDataConverter.to(this.getInvoice_InvoiceName(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Proposals_UploadType: OS$DataConversion.ServerDataConverter.to(this.getProposals_UploadType(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
Proposals_Type: OS$DataConversion.ServerDataConverter.to(this.getProposals_Type(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
Commision_Leases_PaymentDate: OS$DataConversion.ServerDataConverter.to(this.getCommision_Leases_PaymentDate(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Proposals_Status: OS$DataConversion.ServerDataConverter.to(this.getProposals_Status(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
Invoice_RequisitionName: OS$DataConversion.ServerDataConverter.to(this.getInvoice_RequisitionName(), {
dataType: OS$DataTypes.DataTypes.Text
}),
InvReport48_DateFrom: OS$DataConversion.ServerDataConverter.to(this.getInvReport48_DateFrom(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Report63_RegionId: OS$DataConversion.ServerDataConverter.to(this.getReport63_RegionId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Commision_Leases_ProposalSearch: OS$DataConversion.ServerDataConverter.to(this.getCommision_Leases_ProposalSearch(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Proposals_Regions: OS$DataConversion.ServerDataConverter.to(this.getProposals_Regions(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Treasury_CreationDate: OS$DataConversion.ServerDataConverter.to(this.getTreasury_CreationDate(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Commision_Leases_BankId: OS$DataConversion.ServerDataConverter.to(this.getCommision_Leases_BankId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Report62_DateTo: OS$DataConversion.ServerDataConverter.to(this.getReport62_DateTo(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Proposals_Currencies: OS$DataConversion.ServerDataConverter.to(this.getProposals_Currencies(), {
dataType: OS$DataTypes.DataTypes.Text
}),
PreApprovalFolios_RegionId: OS$DataConversion.ServerDataConverter.to(this.getPreApprovalFolios_RegionId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
FolioContabilization_Filters_AmountFrom: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_AmountFrom(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
Orders_Number: OS$DataConversion.ServerDataConverter.to(this.getOrders_Number(), {
dataType: OS$DataTypes.DataTypes.Text
}),
FolioContabilization_Filters_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Commision_Leases_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getCommision_Leases_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Report60_SociedadId: OS$DataConversion.ServerDataConverter.to(this.getReport60_SociedadId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Supplier_Fechaanticiposfin: OS$DataConversion.ServerDataConverter.to(this.getSupplier_Fechaanticiposfin(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Commision_Leases_RegionId: OS$DataConversion.ServerDataConverter.to(this.getCommision_Leases_RegionId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
OrderDistributionConfig_Applicant: OS$DataConversion.ServerDataConverter.to(this.getOrderDistributionConfig_Applicant(), {
dataType: OS$DataTypes.DataTypes.Text
}),
FolioForApproval_OrderNumber: OS$DataConversion.ServerDataConverter.to(this.getFolioForApproval_OrderNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
InvReport48_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getInvReport48_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Proposals_PaymentDateTo: OS$DataConversion.ServerDataConverter.to(this.getProposals_PaymentDateTo(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Requisitions_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getRequisitions_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Proposals_AmountMLFrom: OS$DataConversion.ServerDataConverter.to(this.getProposals_AmountMLFrom(), {
dataType: OS$DataTypes.DataTypes.Decimal
}),
FolioContabilization_Filters_InvoiceCreatedOn: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_InvoiceCreatedOn(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Report62_DateFrom: OS$DataConversion.ServerDataConverter.to(this.getReport62_DateFrom(), {
dataType: OS$DataTypes.DataTypes.Date
}),
ForeignInvoicesForReassignment_OriginalUserId: OS$DataConversion.ServerDataConverter.to(this.getForeignInvoicesForReassignment_OriginalUserId(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Proposal_DocumentNumber: OS$DataConversion.ServerDataConverter.to(this.getProposal_DocumentNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
FolioApproved_RegionId: OS$DataConversion.ServerDataConverter.to(this.getFolioApproved_RegionId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
InvoicesFCP_UploadDate: OS$DataConversion.ServerDataConverter.to(this.getInvoicesFCP_UploadDate(), {
dataType: OS$DataTypes.DataTypes.Date
}),
OrderToComplement_Days: OS$DataConversion.ServerDataConverter.to(this.getOrderToComplement_Days(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
ForeignInvoicesPendingValidation_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getForeignInvoicesPendingValidation_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Report63_SociedadId: OS$DataConversion.ServerDataConverter.to(this.getReport63_SociedadId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Requisitions_CostCenterId: OS$DataConversion.ServerDataConverter.to(this.getRequisitions_CostCenterId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
FolioContabilization_Filters_AccountingTypeId: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_AccountingTypeId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
FolioContabilization_Filters_BusinessValueSubCateg: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_BusinessValueSubCateg(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Requisitions_ProveedorFilter_UploadDateTo: OS$DataConversion.ServerDataConverter.to(this.getRequisitions_ProveedorFilter_UploadDateTo(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Treasury_Bank: OS$DataConversion.ServerDataConverter.to(this.getTreasury_Bank(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
OrderToComplement_Number: OS$DataConversion.ServerDataConverter.to(this.getOrderToComplement_Number(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Proposals_ProposalSearch: OS$DataConversion.ServerDataConverter.to(this.getProposals_ProposalSearch(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Requisitions_AmountTo: OS$DataConversion.ServerDataConverter.to(this.getRequisitions_AmountTo(), {
dataType: OS$DataTypes.DataTypes.Decimal
}),
FolioApproved_CreatedToDate: OS$DataConversion.ServerDataConverter.to(this.getFolioApproved_CreatedToDate(), {
dataType: OS$DataTypes.DataTypes.Date
}),
Orders_OrderStatusId: OS$DataConversion.ServerDataConverter.to(this.getOrders_OrderStatusId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
UnsuccessfulEntries_SupplierId: OS$DataConversion.ServerDataConverter.to(this.getUnsuccessfulEntries_SupplierId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
InvoicesFCP_OrderNumber: OS$DataConversion.ServerDataConverter.to(this.getInvoicesFCP_OrderNumber(), {
dataType: OS$DataTypes.DataTypes.Text
}),
FoliosForReassignment_TargetUserId: OS$DataConversion.ServerDataConverter.to(this.getFoliosForReassignment_TargetUserId(), {
dataType: OS$DataTypes.DataTypes.Text
}),
Commision_Leases_ApprovalStatusId: OS$DataConversion.ServerDataConverter.to(this.getCommision_Leases_ApprovalStatusId(), {
dataType: OS$DataTypes.DataTypes.Integer
}),
AccountStatus_RegionId: OS$DataConversion.ServerDataConverter.to(this.getAccountStatus_RegionId(), {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
Treasury_AmountMLFrom: OS$DataConversion.ServerDataConverter.to(this.getTreasury_AmountMLFrom(), {
dataType: OS$DataTypes.DataTypes.Decimal
}),
OrderProviderList_Number: OS$DataConversion.ServerDataConverter.to(this.getOrderProviderList_Number(), {
dataType: OS$DataTypes.DataTypes.Text
}),
FolioContabilization_Filters_InvoiceName: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_InvoiceName(), {
dataType: OS$DataTypes.DataTypes.Text
}),
FolioContabilization_Filters_CurrencyId: OS$DataConversion.ServerDataConverter.to(this.getFolioContabilization_Filters_CurrencyId(), {
dataType: OS$DataTypes.DataTypes.Text
})
};
}

}

export default new ClientVariables();


