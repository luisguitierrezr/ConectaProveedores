import {ApplicationInfo} from "@outsystems/runtime-core-js";

function buildURL(url) {
var basePath = ApplicationInfo.getBasePath();
basePath = basePath.replace(/\/$/, "");
if(url) {
return ((basePath + "/") + url);
} else {
return basePath;
}

};
export const ROUTER_INFO = [{
get pathname() {return buildURL();
},
screenName: "a_Main.Homepage",
forDefaultPath: true,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.a_Main.Homepage.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("UnsuccessfulEntries");
},
screenName: "k_Deviations.UnsuccessfulEntries",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.k_Deviations.UnsuccessfulEntries.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("UnsuccessfulEntries2");
},
screenName: "k_Deviations.UnsuccessfulEntries2",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.k_Deviations.UnsuccessfulEntries2.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("RecoverPasswordReset");
},
screenName: "a_Common.RecoverPasswordReset",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.a_Common.RecoverPasswordReset.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("Login");
},
screenName: "a_Common.Login",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.a_Common.Login.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("InvalidPermissions");
},
screenName: "a_Common.InvalidPermissions",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.a_Common.InvalidPermissions.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("RecoverPasswordRequest");
},
screenName: "a_Common.RecoverPasswordRequest",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.a_Common.RecoverPasswordRequest.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("UserProfile_DEPRECATED");
},
screenName: "a_Common.UserProfile_DEPRECATED",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.a_Common.UserProfile_DEPRECATED.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("InvalidSession");
},
screenName: "a_Common.InvalidSession",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.a_Common.InvalidSession.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("UserProfile");
},
screenName: "a_Common.UserProfile",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.a_Common.UserProfile.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ChangePassword");
},
screenName: "a_Common.ChangePassword",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.a_Common.ChangePassword.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("SupplierInvoicesReport");
},
screenName: "g_Reports.SupplierInvoicesReport",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.g_Reports.SupplierInvoicesReport.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("RequestsReport");
},
screenName: "g_Reports.RequestsReport",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.g_Reports.RequestsReport.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("LinesReport");
},
screenName: "g_Reports.LinesReport",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.g_Reports.LinesReport.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("FoliosSAECReport");
},
screenName: "g_Reports.FoliosSAECReport",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.g_Reports.FoliosSAECReport.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("DocumentExtration");
},
screenName: "g_Reports.DocumentExtration",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.g_Reports.DocumentExtration.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("Invoices");
},
screenName: "d_Invoices.Invoices",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.d_Invoices.Invoices.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("Invoices_Detail");
},
screenName: "d_Invoices.Invoices_Detail",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.d_Invoices.Invoices_Detail.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("OrdersToApprove");
},
screenName: "e_Orders.OrdersToApprove",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.e_Orders.OrdersToApprove.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("OrdersRequestErrorDistribution");
},
screenName: "e_Orders.OrdersRequestErrorDistribution",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.e_Orders.OrdersRequestErrorDistribution.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("OrdersInComplement");
},
screenName: "e_Orders.OrdersInComplement",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.e_Orders.OrdersInComplement.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("Orders");
},
screenName: "e_Orders.Orders",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.e_Orders.Orders.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("AllOrders");
},
screenName: "e_Orders.AllOrders",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.e_Orders.AllOrders.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("OrderDetail");
},
screenName: "e_Orders.OrderDetail",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.e_Orders.OrderDetail.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("OrdersApproved");
},
screenName: "e_Orders.OrdersApproved",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.e_Orders.OrdersApproved.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("OrdersToComplement");
},
screenName: "e_Orders.OrdersToComplement",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.e_Orders.OrdersToComplement.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("OrderDetailView");
},
screenName: "e_Orders.OrderDetailView",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.e_Orders.OrderDetailView.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ProviderOrderList");
},
screenName: "e_Orders.ProviderOrderList",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.e_Orders.ProviderOrderList.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ReportCurrentAccount");
},
screenName: "c_Proveedor.ReportCurrentAccount",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.c_Proveedor.ReportCurrentAccount.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("AccountStatus");
},
screenName: "c_Proveedor.AccountStatus",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.c_Proveedor.AccountStatus.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("StorageDeleted");
},
screenName: "s_Storage.StorageDeleted",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.s_Storage.StorageDeleted.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("StorageList");
},
screenName: "s_Storage.StorageList",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.s_Storage.StorageList.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("OrderDistributionConfigDetails");
},
screenName: "h_OrderDistributionConfig.OrderDistributionConfigDetails",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfigDetails.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("OrderDistributionConfig");
},
screenName: "h_OrderDistributionConfig.OrderDistributionConfig",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.h_OrderDistributionConfig.OrderDistributionConfig.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("Requisitions");
},
screenName: "c_Requisitions.Requisitions",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.c_Requisitions.Requisitions.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("RequisitionDetail");
},
screenName: "c_Requisitions.RequisitionDetail",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.c_Requisitions.RequisitionDetail.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("HotfixOrderApprover");
},
screenName: "z_Hotfix.HotfixOrderApprover",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.z_Hotfix.HotfixOrderApprover.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ApprovalCommissionsandLeases");
},
screenName: "b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.ApprovalCommissionsandLeases.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("TableDownloadFolioScreenPDF");
},
screenName: "z_TableDownloadsPDF.TableDownloadFolioScreenPDF",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.z_TableDownloadsPDF.TableDownloadFolioScreenPDF.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("TableDownloadInvoiceScreenPDF");
},
screenName: "z_TableDownloadsPDF.TableDownloadInvoiceScreenPDF",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.z_TableDownloadsPDF.TableDownloadInvoiceScreenPDF.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("TableDownloadRequisitionsListInternalScreenPDF");
},
screenName: "z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("TableDownloadOrderPDF");
},
screenName: "z_TableDownloadsPDF.TableDownloadOrderPDF",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.z_TableDownloadsPDF.TableDownloadOrderPDF.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("InvoiceReportPdf");
},
screenName: "y_Utils.InvoiceReportPdf",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.y_Utils.InvoiceReportPdf.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("InvoicesFilesAudit");
},
screenName: "d_InvoiceAudit.InvoicesFilesAudit",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.d_InvoiceAudit.InvoicesFilesAudit.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("InvoicesAudit");
},
screenName: "d_InvoiceAudit.InvoicesAudit",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.d_InvoiceAudit.InvoicesAudit.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("SpecialCharValidations");
},
screenName: "z_Testing.SpecialCharValidations",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.z_Testing.SpecialCharValidations.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ProposalsTreasury");
},
screenName: "b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ProposalDetailTreasury");
},
screenName: "b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("Homepage");
},
screenName: "a_Main.Homepage",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.a_Main.Homepage.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("Dashboard");
},
screenName: "a_Main.Dashboard",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.a_Main.Dashboard.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("Help");
},
screenName: "m_Manuals.Help",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.m_Manuals.Help.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("OrderRequestFilesApproval");
},
screenName: "e_OrdersRequestFiles.OrderRequestFilesApproval",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.e_OrdersRequestFiles.OrderRequestFilesApproval.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("InvoicesFCP");
},
screenName: "d_Invoices_FCP.InvoicesFCP",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.d_Invoices_FCP.InvoicesFCP.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ProposalManualUpload");
},
screenName: "b_CyA_AdminCommissionsLeasing.ProposalManualUpload",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalManualUpload.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ProposalsList");
},
screenName: "b_CyA_AdminCommissionsLeasing.ProposalsList",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsList.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("DocumentList");
},
screenName: "b_CyA_AdminCommissionsLeasing.DocumentList",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.b_CyA_AdminCommissionsLeasing.DocumentList.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ProposalDetailError");
},
screenName: "b_CyA_AdminCommissionsLeasing.ProposalDetailError",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ProposalsListViewer");
},
screenName: "b_CyA_AdminCommissionsLeasing.ProposalsListViewer",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalsListViewer.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ProposalDetail");
},
screenName: "b_CyA_AdminCommissionsLeasing.ProposalDetail",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("Reassignments");
},
screenName: "a_Reassignments.Reassignments",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.a_Reassignments.Reassignments.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("FolioSAE_Details");
},
screenName: "j_FoliosSAE.FolioSAE_Details",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.FolioSAE_Details.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("CheckDirectReports");
},
screenName: "j_FoliosSAE.CheckDirectReports",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.CheckDirectReports.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("EditFolioSAE");
},
screenName: "j_FoliosSAE.EditFolioSAE",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.EditFolioSAE.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("FoliosSAEApproved");
},
screenName: "j_FoliosSAE.FoliosSAEApproved",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.FoliosSAEApproved.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("FoliosContabilizationSAPStatus");
},
screenName: "j_FoliosSAE.FoliosContabilizationSAPStatus",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.FoliosContabilizationSAPStatus.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ForeignInvoicesPendingValidation");
},
screenName: "j_FoliosSAE.ForeignInvoicesPendingValidation",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.ForeignInvoicesPendingValidation.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("PreApprovalFolios");
},
screenName: "j_FoliosSAE.PreApprovalFolios",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.PreApprovalFolios.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("FoliosSAEforReassignment");
},
screenName: "j_FoliosSAE.FoliosSAEforReassignment",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.FoliosSAEforReassignment.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("FolioSAE_Proveedor");
},
screenName: "j_FoliosSAE.FolioSAE_Proveedor",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.FolioSAE_Proveedor.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("FoliosList");
},
screenName: "j_FoliosSAE.FoliosList",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.FoliosList.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("FoliosSAEForApproval");
},
screenName: "j_FoliosSAE.FoliosSAEForApproval",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.FoliosSAEForApproval.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("PreApprovalFolioDetail");
},
screenName: "j_FoliosSAE.PreApprovalFolioDetail",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.PreApprovalFolioDetail.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("FoliosSAEForApprovalold");
},
screenName: "j_FoliosSAE.FoliosSAEForApprovalold",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.FoliosSAEForApprovalold.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("NewFolioSAE");
},
screenName: "j_FoliosSAE.NewFolioSAE",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.NewFolioSAE.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("NewMassiveFolioSAE");
},
screenName: "j_FoliosSAE.NewMassiveFolioSAE",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.NewMassiveFolioSAE.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("ForeignInvoicesForReassignment");
},
screenName: "j_FoliosSAE.ForeignInvoicesForReassignment",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.ForeignInvoicesForReassignment.mvc$screen.js");
}
}
}, {
get pathname() {return buildURL("FoliosSAERejected");
},
screenName: "j_FoliosSAE.FoliosSAERejected",
forDefaultPath: false,
lazyComponentInfo: {
shallSaveStateOnLeave: true,
importer: function () {
return import("./ConectaProveedores.j_FoliosSAE.FoliosSAERejected.mvc$screen.js");
}
}
}];
export const SPLASH_SCREEN_ROUTE = null;
