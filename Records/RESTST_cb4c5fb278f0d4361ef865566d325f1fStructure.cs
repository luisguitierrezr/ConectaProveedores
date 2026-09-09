using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Report60_FolioItems
public class RESTST_cb4c5fb278f0d4361ef865566d325f1fStructure : AbstractRESTStructure<ST_cb4c5fb278f0d4361ef865566d325f1fStructure> {
[JsonProperty("FolioStatus")]
public string AttrFolioStatus;

[JsonProperty("FolioId")]
public long? AttrFolioId;

[JsonProperty("FolioItemsId")]
public long? AttrFolioItemsId;

[JsonProperty("FolioNumber")]
public string AttrFolioNumber;

[JsonProperty("CreatedOn")]
public string AttrCreatedOn;

[JsonProperty("ApprovalFlowType")]
public string AttrApprovalFlowType;

[JsonProperty("ApprovalFlowName")]
public string AttrApprovalFlowName;

[JsonProperty("AssignedUsers")]
public string AttrAssignedUsers;

[JsonProperty("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("OrderDate")]
public string AttrOrderDate;

[JsonProperty("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("SupplierName")]
public string AttrSupplierName;

[JsonProperty("Applicant")]
public string AttrApplicant;

[JsonProperty("Inputation")]
public string AttrInputation;

[JsonProperty("Company")]
public string AttrCompany;

[JsonProperty("Region")]
public string AttrRegion;

[JsonProperty("OrderPosition")]
public string AttrOrderPosition;

[JsonProperty("SAPCode")]
public string AttrSAPCode;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("Quantity")]
public string AttrQuantity;

[JsonProperty("UMP")]
public string AttrUMP;

[JsonProperty("UnitPrice")]
public string AttrUnitPrice;

[JsonProperty("AuthorizedAmount")]
public string AttrAuthorizedAmount;

[JsonProperty("ImporteFolioSAEC")]
public string AttrImporteFolioSAEC;

[JsonProperty("CurrencyCode")]
public string AttrCurrencyCode;

[JsonProperty("ApproversPositionRolesList_AreaUsuaria")]
public string AttrApproversPositionRolesList_AreaUsuaria;

[JsonProperty("FirstApprover_AreaUsuaria")]
public string AttrFirstApprover_AreaUsuaria;

[JsonProperty("DaysInProcess")]
public string AttrDaysInProcess;

[JsonProperty("EntryNumber")]
public string AttrEntryNumber;

[JsonProperty("EntryDate")]
public string AttrEntryDate;

[JsonProperty("InvoiceNumber")]
public string AttrInvoiceNumber;

[JsonProperty("UUID")]
public string AttrUUID;

[JsonProperty("InvoiceDate")]
public string AttrInvoiceDate;

[JsonProperty("InvoiceCurrency")]
public string AttrInvoiceCurrency;

[JsonProperty("PEP")]
public string AttrPEP;

[JsonProperty("Iddelsitio")]
public string AttrIddelsitio;

[JsonProperty("EntryCancelation")]
public string AttrEntryCancelation;

[JsonProperty("EntryCancelationDate")]
public string AttrEntryCancelationDate;

[JsonProperty("Client")]
public string AttrClient;

[JsonProperty("CXPLiberationDate")]
public string AttrCXPLiberationDate;

[JsonProperty("DaysToCXPLiberation")]
public int? AttrDaysToCXPLiberation;

[JsonProperty("SISEAApprover")]
public string AttrSISEAApprover;

[JsonProperty("AttachedFiles_Extra")]
public string AttrAttachedFiles_Extra;

[JsonProperty("InvoiceXMLSerie")]
public string AttrInvoiceXMLSerie;

[JsonProperty("SubTotal")]
public string AttrSubTotal;

[JsonProperty("IVA")]
public string AttrIVA;

[JsonProperty("Retention")]
public string AttrRetention;

[JsonProperty("InvoiceStatus")]
public string AttrInvoiceStatus;

[JsonProperty("FolioFirstApproverPositionRole")]
public string AttrFolioFirstApproverPositionRole;

[JsonProperty("InvoiceDate2")]
public string AttrInvoiceDate2;

[JsonProperty("InvoiceDueDate")]
public string AttrInvoiceDueDate;

[JsonProperty("InvoicePDFName")]
public string AttrInvoicePDFName;

[JsonProperty("InvoiceXMLName")]
public string AttrInvoiceXMLName;

[JsonProperty("CostCenter")]
public string AttrCostCenter;

[JsonProperty("ApproversDetailedList_CxP")]
public string AttrApproversDetailedList_CxP;

[JsonProperty("Project")]
public string AttrProject;

[JsonProperty("Period")]
public string AttrPeriod;

[JsonProperty("Frequency")]
public string AttrFrequency;

[JsonProperty("Document51y56")]
public string AttrDocument51y56;

[JsonProperty("PolizaDate")]
public string AttrPolizaDate;

[JsonProperty("LastApproverPuestodelGerente_CxP")]
public string AttrLastApproverPuestodelGerente_CxP;

[JsonProperty("LastApproverPuestodelJefe_CxP")]
public string AttrLastApproverPuestodelJefe_CxP;

[JsonProperty("CurrentApprover")]
public string AttrCurrentApprover;

[JsonProperty("LastUpdateOrderSAP")]
public string AttrLastUpdateOrderSAP;

public RESTST_cb4c5fb278f0d4361ef865566d325f1fStructure() { }

public RESTST_cb4c5fb278f0d4361ef865566d325f1fStructure (ST_cb4c5fb278f0d4361ef865566d325f1fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioStatus = ConvertToRestWithoutDefaults(s.ssFolioStatus, "");
AttrFolioId = ConvertToRestWithoutDefaults(s.ssFolioId, 0L);
AttrFolioItemsId = ConvertToRestWithoutDefaults(s.ssFolioItemsId, 0L);
AttrFolioNumber = ConvertToRestWithoutDefaults(s.ssFolioNumber, "");
AttrCreatedOn = ConvertToRestWithoutDefaults(s.ssCreatedOn, "");
AttrApprovalFlowType = ConvertToRestWithoutDefaults(s.ssApprovalFlowType, "");
AttrApprovalFlowName = ConvertToRestWithoutDefaults(s.ssApprovalFlowName, "");
AttrAssignedUsers = ConvertToRestWithoutDefaults(s.ssAssignedUsers, "");
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrOrderDate = ConvertToRestWithoutDefaults(s.ssOrderDate, "");
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrApplicant = ConvertToRestWithoutDefaults(s.ssApplicant, "");
AttrInputation = ConvertToRestWithoutDefaults(s.ssInputation, "");
AttrCompany = ConvertToRestWithoutDefaults(s.ssCompany, "");
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
AttrOrderPosition = ConvertToRestWithoutDefaults(s.ssOrderPosition, "");
AttrSAPCode = ConvertToRestWithoutDefaults(s.ssSAPCode, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrQuantity = ConvertToRestWithoutDefaults(s.ssQuantity, "");
AttrUMP = ConvertToRestWithoutDefaults(s.ssUMP, "");
AttrUnitPrice = ConvertToRestWithoutDefaults(s.ssUnitPrice, "");
AttrAuthorizedAmount = ConvertToRestWithoutDefaults(s.ssAuthorizedAmount, "");
AttrImporteFolioSAEC = ConvertToRestWithoutDefaults(s.ssImporteFolioSAEC, "");
AttrCurrencyCode = ConvertToRestWithoutDefaults(s.ssCurrencyCode, "");
AttrApproversPositionRolesList_AreaUsuaria = ConvertToRestWithoutDefaults(s.ssApproversPositionRolesList_AreaUsuaria, "");
AttrFirstApprover_AreaUsuaria = ConvertToRestWithoutDefaults(s.ssFirstApprover_AreaUsuaria, "");
AttrDaysInProcess = ConvertToRestWithoutDefaults(s.ssDaysInProcess, "");
AttrEntryNumber = ConvertToRestWithoutDefaults(s.ssEntryNumber, "");
AttrEntryDate = ConvertToRestWithoutDefaults(s.ssEntryDate, "");
AttrInvoiceNumber = ConvertToRestWithoutDefaults(s.ssInvoiceNumber, "");
AttrUUID = ConvertToRestWithoutDefaults(s.ssUUID, "");
AttrInvoiceDate = ConvertToRestWithoutDefaults(s.ssInvoiceDate, "");
AttrInvoiceCurrency = ConvertToRestWithoutDefaults(s.ssInvoiceCurrency, "");
AttrPEP = ConvertToRestWithoutDefaults(s.ssPEP, "");
AttrIddelsitio = ConvertToRestWithoutDefaults(s.ssIddelsitio, "");
AttrEntryCancelation = ConvertToRestWithoutDefaults(s.ssEntryCancelation, "");
AttrEntryCancelationDate = ConvertToRestWithoutDefaults(s.ssEntryCancelationDate, "");
AttrClient = ConvertToRestWithoutDefaults(s.ssClient, "");
AttrCXPLiberationDate = ConvertToRestWithoutDefaults(s.ssCXPLiberationDate, "");
AttrDaysToCXPLiberation = ConvertToRestWithoutDefaults(s.ssDaysToCXPLiberation, 0);
AttrSISEAApprover = ConvertToRestWithoutDefaults(s.ssSISEAApprover, "");
AttrAttachedFiles_Extra = ConvertToRestWithoutDefaults(s.ssAttachedFiles_Extra, "");
AttrInvoiceXMLSerie = ConvertToRestWithoutDefaults(s.ssInvoiceXMLSerie, "");
AttrSubTotal = ConvertToRestWithoutDefaults(s.ssSubTotal, "");
AttrIVA = ConvertToRestWithoutDefaults(s.ssIVA, "");
AttrRetention = ConvertToRestWithoutDefaults(s.ssRetention, "");
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssInvoiceStatus, "");
AttrFolioFirstApproverPositionRole = ConvertToRestWithoutDefaults(s.ssFolioFirstApproverPositionRole, "");
AttrInvoiceDate2 = ConvertToRestWithoutDefaults(s.ssInvoiceDate2, "");
AttrInvoiceDueDate = ConvertToRestWithoutDefaults(s.ssInvoiceDueDate, "");
AttrInvoicePDFName = ConvertToRestWithoutDefaults(s.ssInvoicePDFName, "");
AttrInvoiceXMLName = ConvertToRestWithoutDefaults(s.ssInvoiceXMLName, "");
AttrCostCenter = ConvertToRestWithoutDefaults(s.ssCostCenter, "");
AttrApproversDetailedList_CxP = ConvertToRestWithoutDefaults(s.ssApproversDetailedList_CxP, "");
AttrProject = ConvertToRestWithoutDefaults(s.ssProject, "");
AttrPeriod = ConvertToRestWithoutDefaults(s.ssPeriod, "");
AttrFrequency = ConvertToRestWithoutDefaults(s.ssFrequency, "");
AttrDocument51y56 = ConvertToRestWithoutDefaults(s.ssDocument51y56, "");
AttrPolizaDate = ConvertToRestWithoutDefaults(s.ssPolizaDate, "");
AttrLastApproverPuestodelGerente_CxP = ConvertToRestWithoutDefaults(s.ssLastApproverPuestodelGerente_CxP, "");
AttrLastApproverPuestodelJefe_CxP = ConvertToRestWithoutDefaults(s.ssLastApproverPuestodelJefe_CxP, "");
AttrCurrentApprover = ConvertToRestWithoutDefaults(s.ssCurrentApprover, "");
AttrLastUpdateOrderSAP = ConvertToRestWithoutDefaults(s.ssLastUpdateOrderSAP, "");
  } else {
AttrFolioStatus = s.ssFolioStatus;
AttrFolioId = (long?) s.ssFolioId;
AttrFolioItemsId = (long?) s.ssFolioItemsId;
AttrFolioNumber = s.ssFolioNumber;
AttrCreatedOn = s.ssCreatedOn;
AttrApprovalFlowType = s.ssApprovalFlowType;
AttrApprovalFlowName = s.ssApprovalFlowName;
AttrAssignedUsers = s.ssAssignedUsers;
AttrOrderNumber = s.ssOrderNumber;
AttrOrderDate = s.ssOrderDate;
AttrSupplierNumber = s.ssSupplierNumber;
AttrSupplierName = s.ssSupplierName;
AttrApplicant = s.ssApplicant;
AttrInputation = s.ssInputation;
AttrCompany = s.ssCompany;
AttrRegion = s.ssRegion;
AttrOrderPosition = s.ssOrderPosition;
AttrSAPCode = s.ssSAPCode;
AttrDescription = s.ssDescription;
AttrQuantity = s.ssQuantity;
AttrUMP = s.ssUMP;
AttrUnitPrice = s.ssUnitPrice;
AttrAuthorizedAmount = s.ssAuthorizedAmount;
AttrImporteFolioSAEC = s.ssImporteFolioSAEC;
AttrCurrencyCode = s.ssCurrencyCode;
AttrApproversPositionRolesList_AreaUsuaria = s.ssApproversPositionRolesList_AreaUsuaria;
AttrFirstApprover_AreaUsuaria = s.ssFirstApprover_AreaUsuaria;
AttrDaysInProcess = s.ssDaysInProcess;
AttrEntryNumber = s.ssEntryNumber;
AttrEntryDate = s.ssEntryDate;
AttrInvoiceNumber = s.ssInvoiceNumber;
AttrUUID = s.ssUUID;
AttrInvoiceDate = s.ssInvoiceDate;
AttrInvoiceCurrency = s.ssInvoiceCurrency;
AttrPEP = s.ssPEP;
AttrIddelsitio = s.ssIddelsitio;
AttrEntryCancelation = s.ssEntryCancelation;
AttrEntryCancelationDate = s.ssEntryCancelationDate;
AttrClient = s.ssClient;
AttrCXPLiberationDate = s.ssCXPLiberationDate;
AttrDaysToCXPLiberation = (int?) s.ssDaysToCXPLiberation;
AttrSISEAApprover = s.ssSISEAApprover;
AttrAttachedFiles_Extra = s.ssAttachedFiles_Extra;
AttrInvoiceXMLSerie = s.ssInvoiceXMLSerie;
AttrSubTotal = s.ssSubTotal;
AttrIVA = s.ssIVA;
AttrRetention = s.ssRetention;
AttrInvoiceStatus = s.ssInvoiceStatus;
AttrFolioFirstApproverPositionRole = s.ssFolioFirstApproverPositionRole;
AttrInvoiceDate2 = s.ssInvoiceDate2;
AttrInvoiceDueDate = s.ssInvoiceDueDate;
AttrInvoicePDFName = s.ssInvoicePDFName;
AttrInvoiceXMLName = s.ssInvoiceXMLName;
AttrCostCenter = s.ssCostCenter;
AttrApproversDetailedList_CxP = s.ssApproversDetailedList_CxP;
AttrProject = s.ssProject;
AttrPeriod = s.ssPeriod;
AttrFrequency = s.ssFrequency;
AttrDocument51y56 = s.ssDocument51y56;
AttrPolizaDate = s.ssPolizaDate;
AttrLastApproverPuestodelGerente_CxP = s.ssLastApproverPuestodelGerente_CxP;
AttrLastApproverPuestodelJefe_CxP = s.ssLastApproverPuestodelJefe_CxP;
AttrCurrentApprover = s.ssCurrentApprover;
AttrLastUpdateOrderSAP = s.ssLastUpdateOrderSAP;
  }
}

public static ST_cb4c5fb278f0d4361ef865566d325f1fStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_cb4c5fb278f0d4361ef865566d325f1fStructure obj) { 
  ST_cb4c5fb278f0d4361ef865566d325f1fStructure s = new ST_cb4c5fb278f0d4361ef865566d325f1fStructure();
  if(obj != null) {
  s.ssFolioStatus = obj.AttrFolioStatus == null ? "" : obj.AttrFolioStatus;
  s.ssFolioId = obj.AttrFolioId == null ? 0L : obj.AttrFolioId.Value;
  s.ssFolioItemsId = obj.AttrFolioItemsId == null ? 0L : obj.AttrFolioItemsId.Value;
  s.ssFolioNumber = obj.AttrFolioNumber == null ? "" : obj.AttrFolioNumber;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? "" : obj.AttrCreatedOn;
  s.ssApprovalFlowType = obj.AttrApprovalFlowType == null ? "" : obj.AttrApprovalFlowType;
  s.ssApprovalFlowName = obj.AttrApprovalFlowName == null ? "" : obj.AttrApprovalFlowName;
  s.ssAssignedUsers = obj.AttrAssignedUsers == null ? "" : obj.AttrAssignedUsers;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssOrderDate = obj.AttrOrderDate == null ? "" : obj.AttrOrderDate;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssApplicant = obj.AttrApplicant == null ? "" : obj.AttrApplicant;
  s.ssInputation = obj.AttrInputation == null ? "" : obj.AttrInputation;
  s.ssCompany = obj.AttrCompany == null ? "" : obj.AttrCompany;
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  s.ssOrderPosition = obj.AttrOrderPosition == null ? "" : obj.AttrOrderPosition;
  s.ssSAPCode = obj.AttrSAPCode == null ? "" : obj.AttrSAPCode;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssQuantity = obj.AttrQuantity == null ? "" : obj.AttrQuantity;
  s.ssUMP = obj.AttrUMP == null ? "" : obj.AttrUMP;
  s.ssUnitPrice = obj.AttrUnitPrice == null ? "" : obj.AttrUnitPrice;
  s.ssAuthorizedAmount = obj.AttrAuthorizedAmount == null ? "" : obj.AttrAuthorizedAmount;
  s.ssImporteFolioSAEC = obj.AttrImporteFolioSAEC == null ? "" : obj.AttrImporteFolioSAEC;
  s.ssCurrencyCode = obj.AttrCurrencyCode == null ? "" : obj.AttrCurrencyCode;
  s.ssApproversPositionRolesList_AreaUsuaria = obj.AttrApproversPositionRolesList_AreaUsuaria == null ? "" : obj.AttrApproversPositionRolesList_AreaUsuaria;
  s.ssFirstApprover_AreaUsuaria = obj.AttrFirstApprover_AreaUsuaria == null ? "" : obj.AttrFirstApprover_AreaUsuaria;
  s.ssDaysInProcess = obj.AttrDaysInProcess == null ? "" : obj.AttrDaysInProcess;
  s.ssEntryNumber = obj.AttrEntryNumber == null ? "" : obj.AttrEntryNumber;
  s.ssEntryDate = obj.AttrEntryDate == null ? "" : obj.AttrEntryDate;
  s.ssInvoiceNumber = obj.AttrInvoiceNumber == null ? "" : obj.AttrInvoiceNumber;
  s.ssUUID = obj.AttrUUID == null ? "" : obj.AttrUUID;
  s.ssInvoiceDate = obj.AttrInvoiceDate == null ? "" : obj.AttrInvoiceDate;
  s.ssInvoiceCurrency = obj.AttrInvoiceCurrency == null ? "" : obj.AttrInvoiceCurrency;
  s.ssPEP = obj.AttrPEP == null ? "" : obj.AttrPEP;
  s.ssIddelsitio = obj.AttrIddelsitio == null ? "" : obj.AttrIddelsitio;
  s.ssEntryCancelation = obj.AttrEntryCancelation == null ? "" : obj.AttrEntryCancelation;
  s.ssEntryCancelationDate = obj.AttrEntryCancelationDate == null ? "" : obj.AttrEntryCancelationDate;
  s.ssClient = obj.AttrClient == null ? "" : obj.AttrClient;
  s.ssCXPLiberationDate = obj.AttrCXPLiberationDate == null ? "" : obj.AttrCXPLiberationDate;
  s.ssDaysToCXPLiberation = obj.AttrDaysToCXPLiberation == null ? 0 : obj.AttrDaysToCXPLiberation.Value;
  s.ssSISEAApprover = obj.AttrSISEAApprover == null ? "" : obj.AttrSISEAApprover;
  s.ssAttachedFiles_Extra = obj.AttrAttachedFiles_Extra == null ? "" : obj.AttrAttachedFiles_Extra;
  s.ssInvoiceXMLSerie = obj.AttrInvoiceXMLSerie == null ? "" : obj.AttrInvoiceXMLSerie;
  s.ssSubTotal = obj.AttrSubTotal == null ? "" : obj.AttrSubTotal;
  s.ssIVA = obj.AttrIVA == null ? "" : obj.AttrIVA;
  s.ssRetention = obj.AttrRetention == null ? "" : obj.AttrRetention;
  s.ssInvoiceStatus = obj.AttrInvoiceStatus == null ? "" : obj.AttrInvoiceStatus;
  s.ssFolioFirstApproverPositionRole = obj.AttrFolioFirstApproverPositionRole == null ? "" : obj.AttrFolioFirstApproverPositionRole;
  s.ssInvoiceDate2 = obj.AttrInvoiceDate2 == null ? "" : obj.AttrInvoiceDate2;
  s.ssInvoiceDueDate = obj.AttrInvoiceDueDate == null ? "" : obj.AttrInvoiceDueDate;
  s.ssInvoicePDFName = obj.AttrInvoicePDFName == null ? "" : obj.AttrInvoicePDFName;
  s.ssInvoiceXMLName = obj.AttrInvoiceXMLName == null ? "" : obj.AttrInvoiceXMLName;
  s.ssCostCenter = obj.AttrCostCenter == null ? "" : obj.AttrCostCenter;
  s.ssApproversDetailedList_CxP = obj.AttrApproversDetailedList_CxP == null ? "" : obj.AttrApproversDetailedList_CxP;
  s.ssProject = obj.AttrProject == null ? "" : obj.AttrProject;
  s.ssPeriod = obj.AttrPeriod == null ? "" : obj.AttrPeriod;
  s.ssFrequency = obj.AttrFrequency == null ? "" : obj.AttrFrequency;
  s.ssDocument51y56 = obj.AttrDocument51y56 == null ? "" : obj.AttrDocument51y56;
  s.ssPolizaDate = obj.AttrPolizaDate == null ? "" : obj.AttrPolizaDate;
  s.ssLastApproverPuestodelGerente_CxP = obj.AttrLastApproverPuestodelGerente_CxP == null ? "" : obj.AttrLastApproverPuestodelGerente_CxP;
  s.ssLastApproverPuestodelJefe_CxP = obj.AttrLastApproverPuestodelJefe_CxP == null ? "" : obj.AttrLastApproverPuestodelJefe_CxP;
  s.ssCurrentApprover = obj.AttrCurrentApprover == null ? "" : obj.AttrCurrentApprover;
  s.ssLastUpdateOrderSAP = obj.AttrLastUpdateOrderSAP == null ? "" : obj.AttrLastUpdateOrderSAP;
  }
  return s;
}

public static Func<ST_cb4c5fb278f0d4361ef865566d325f1fStructure, ssConectaProveedores.RestRecords.RESTST_cb4c5fb278f0d4361ef865566d325f1fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_cb4c5fb278f0d4361ef865566d325f1fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_cb4c5fb278f0d4361ef865566d325f1fStructure FromStructure(ST_cb4c5fb278f0d4361ef865566d325f1fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_cb4c5fb278f0d4361ef865566d325f1fStructure(s, config);
}

}


