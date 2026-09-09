using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesReport48
public class JSONST_c882e4a9305466afcdc9cd6a9ad70f15Structure : AbstractRESTStructure<ST_c882e4a9305466afcdc9cd6a9ad70f15Structure> {
[JsonProperty("Region")]
[JsonPropertyName("Region")]
public string AttrRegion;

[JsonProperty("SupplierNumber")]
[JsonPropertyName("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public string AttrSupplier;

[JsonProperty("SupplierRFC")]
[JsonPropertyName("SupplierRFC")]
public string AttrSupplierRFC;

[JsonProperty("RequisitonName")]
[JsonPropertyName("RequisitonName")]
public string AttrRequisitonName;

[JsonProperty("RequisitionCreatedOn")]
[JsonPropertyName("RequisitionCreatedOn")]
public string AttrRequisitionCreatedOn;

[JsonProperty("InvoiceSerie")]
[JsonPropertyName("InvoiceSerie")]
public string AttrInvoiceSerie;

[JsonProperty("InvoiceNumber")]
[JsonPropertyName("InvoiceNumber")]
public string AttrInvoiceNumber;

[JsonProperty("InvoiceEmissionDate")]
[JsonPropertyName("InvoiceEmissionDate")]
public string AttrInvoiceEmissionDate;

[JsonProperty("Subtotal")]
[JsonPropertyName("Subtotal")]
public string AttrSubtotal;

[JsonProperty("IVA")]
[JsonPropertyName("IVA")]
public string AttrIVA;

[JsonProperty("RetentionIVA")]
[JsonPropertyName("RetentionIVA")]
public string AttrRetentionIVA;

[JsonProperty("ISRRetention")]
[JsonPropertyName("ISRRetention")]
public string AttrISRRetention;

[JsonProperty("Expenditures")]
[JsonPropertyName("Expenditures")]
public string AttrExpenditures;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public string AttrTotalAmount;

[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public string AttrCurrency;

[JsonProperty("Status")]
[JsonPropertyName("Status")]
public string AttrStatus;

[JsonProperty("AssignedUser")]
[JsonPropertyName("AssignedUser")]
public string AttrAssignedUser;

[JsonProperty("InvoiceCreationDate")]
[JsonPropertyName("InvoiceCreationDate")]
public string AttrInvoiceCreationDate;

[JsonProperty("InvoiceExpirationDate")]
[JsonPropertyName("InvoiceExpirationDate")]
public string AttrInvoiceExpirationDate;

[JsonProperty("InvoicePaymentDate")]
[JsonPropertyName("InvoicePaymentDate")]
public string AttrInvoicePaymentDate;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("CentrodeAtencion")]
[JsonPropertyName("CentrodeAtencion")]
public string AttrCentrodeAtencion;

[JsonProperty("Street")]
[JsonPropertyName("Street")]
public string AttrStreet;

[JsonProperty("DoorNumber")]
[JsonPropertyName("DoorNumber")]
public string AttrDoorNumber;

[JsonProperty("PostalCode")]
[JsonPropertyName("PostalCode")]
public string AttrPostalCode;

[JsonProperty("ImportTraslado")]
[JsonPropertyName("ImportTraslado")]
public string AttrImportTraslado;

[JsonProperty("PdfName")]
[JsonPropertyName("PdfName")]
public string AttrPdfName;

[JsonProperty("XmlName")]
[JsonPropertyName("XmlName")]
public string AttrXmlName;

[JsonProperty("UUID")]
[JsonPropertyName("UUID")]
public string AttrUUID;

[JsonProperty("IDCeCo")]
[JsonPropertyName("IDCeCo")]
public string AttrIDCeCo;

[JsonProperty("CostCenters")]
[JsonPropertyName("CostCenters")]
public string AttrCostCenters;

[JsonProperty("IDCeBe")]
[JsonPropertyName("IDCeBe")]
public string AttrIDCeBe;

[JsonProperty("ApprovingUsers")]
[JsonPropertyName("ApprovingUsers")]
public string AttrApprovingUsers;

[JsonProperty("InvoiceApprovalDate")]
[JsonPropertyName("InvoiceApprovalDate")]
public string AttrInvoiceApprovalDate;

[JsonProperty("ProjectPeriod")]
[JsonPropertyName("ProjectPeriod")]
public string AttrProjectPeriod;

[JsonProperty("Project")]
[JsonPropertyName("Project")]
public string AttrProject;

[JsonProperty("Frequency")]
[JsonPropertyName("Frequency")]
public string AttrFrequency;

[JsonProperty("SAPNumber")]
[JsonPropertyName("SAPNumber")]
public string AttrSAPNumber;

[JsonProperty("SAPRegisterDate")]
[JsonPropertyName("SAPRegisterDate")]
public string AttrSAPRegisterDate;

[JsonProperty("ApprovalArea")]
[JsonPropertyName("ApprovalArea")]
public string AttrApprovalArea;

[JsonProperty("AccountingUser")]
[JsonPropertyName("AccountingUser")]
public string AttrAccountingUser;

public JSONST_c882e4a9305466afcdc9cd6a9ad70f15Structure() { }

public JSONST_c882e4a9305466afcdc9cd6a9ad70f15Structure (ST_c882e4a9305466afcdc9cd6a9ad70f15Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrSupplier = ConvertToRestWithoutDefaults(s.ssSupplier, "");
AttrSupplierRFC = ConvertToRestWithoutDefaults(s.ssSupplierRFC, "");
AttrRequisitonName = ConvertToRestWithoutDefaults(s.ssRequisitonName, "");
AttrRequisitionCreatedOn = ConvertToRestWithoutDefaults(s.ssRequisitionCreatedOn, "");
AttrInvoiceSerie = ConvertToRestWithoutDefaults(s.ssInvoiceSerie, "");
AttrInvoiceNumber = ConvertToRestWithoutDefaults(s.ssInvoiceNumber, "");
AttrInvoiceEmissionDate = ConvertToRestWithoutDefaults(s.ssInvoiceEmissionDate, "");
AttrSubtotal = ConvertToRestWithoutDefaults(s.ssSubtotal, "");
AttrIVA = ConvertToRestWithoutDefaults(s.ssIVA, "");
AttrRetentionIVA = ConvertToRestWithoutDefaults(s.ssRetentionIVA, "");
AttrISRRetention = ConvertToRestWithoutDefaults(s.ssISRRetention, "");
AttrExpenditures = ConvertToRestWithoutDefaults(s.ssExpenditures, "");
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, "");
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrStatus = ConvertToRestWithoutDefaults(s.ssStatus, "");
AttrAssignedUser = ConvertToRestWithoutDefaults(s.ssAssignedUser, "");
AttrInvoiceCreationDate = ConvertToRestWithoutDefaults(s.ssInvoiceCreationDate, "");
AttrInvoiceExpirationDate = ConvertToRestWithoutDefaults(s.ssInvoiceExpirationDate, "");
AttrInvoicePaymentDate = ConvertToRestWithoutDefaults(s.ssInvoicePaymentDate, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrCentrodeAtencion = ConvertToRestWithoutDefaults(s.ssCentrodeAtencion, "");
AttrStreet = ConvertToRestWithoutDefaults(s.ssStreet, "");
AttrDoorNumber = ConvertToRestWithoutDefaults(s.ssDoorNumber, "");
AttrPostalCode = ConvertToRestWithoutDefaults(s.ssPostalCode, "");
AttrImportTraslado = ConvertToRestWithoutDefaults(s.ssImportTraslado, "");
AttrPdfName = ConvertToRestWithoutDefaults(s.ssPdfName, "");
AttrXmlName = ConvertToRestWithoutDefaults(s.ssXmlName, "");
AttrUUID = ConvertToRestWithoutDefaults(s.ssUUID, "");
AttrIDCeCo = ConvertToRestWithoutDefaults(s.ssIDCeCo, "");
AttrCostCenters = ConvertToRestWithoutDefaults(s.ssCostCenters, "");
AttrIDCeBe = ConvertToRestWithoutDefaults(s.ssIDCeBe, "");
AttrApprovingUsers = ConvertToRestWithoutDefaults(s.ssApprovingUsers, "");
AttrInvoiceApprovalDate = ConvertToRestWithoutDefaults(s.ssInvoiceApprovalDate, "");
AttrProjectPeriod = ConvertToRestWithoutDefaults(s.ssProjectPeriod, "");
AttrProject = ConvertToRestWithoutDefaults(s.ssProject, "");
AttrFrequency = ConvertToRestWithoutDefaults(s.ssFrequency, "");
AttrSAPNumber = ConvertToRestWithoutDefaults(s.ssSAPNumber, "");
AttrSAPRegisterDate = ConvertToRestWithoutDefaults(s.ssSAPRegisterDate, "");
AttrApprovalArea = ConvertToRestWithoutDefaults(s.ssApprovalArea, "");
AttrAccountingUser = ConvertToRestWithoutDefaults(s.ssAccountingUser, "");
  } else {
AttrRegion = s.ssRegion;
AttrSupplierNumber = s.ssSupplierNumber;
AttrSupplier = s.ssSupplier;
AttrSupplierRFC = s.ssSupplierRFC;
AttrRequisitonName = s.ssRequisitonName;
AttrRequisitionCreatedOn = s.ssRequisitionCreatedOn;
AttrInvoiceSerie = s.ssInvoiceSerie;
AttrInvoiceNumber = s.ssInvoiceNumber;
AttrInvoiceEmissionDate = s.ssInvoiceEmissionDate;
AttrSubtotal = s.ssSubtotal;
AttrIVA = s.ssIVA;
AttrRetentionIVA = s.ssRetentionIVA;
AttrISRRetention = s.ssISRRetention;
AttrExpenditures = s.ssExpenditures;
AttrTotalAmount = s.ssTotalAmount;
AttrCurrency = s.ssCurrency;
AttrStatus = s.ssStatus;
AttrAssignedUser = s.ssAssignedUser;
AttrInvoiceCreationDate = s.ssInvoiceCreationDate;
AttrInvoiceExpirationDate = s.ssInvoiceExpirationDate;
AttrInvoicePaymentDate = s.ssInvoicePaymentDate;
AttrDescription = s.ssDescription;
AttrCentrodeAtencion = s.ssCentrodeAtencion;
AttrStreet = s.ssStreet;
AttrDoorNumber = s.ssDoorNumber;
AttrPostalCode = s.ssPostalCode;
AttrImportTraslado = s.ssImportTraslado;
AttrPdfName = s.ssPdfName;
AttrXmlName = s.ssXmlName;
AttrUUID = s.ssUUID;
AttrIDCeCo = s.ssIDCeCo;
AttrCostCenters = s.ssCostCenters;
AttrIDCeBe = s.ssIDCeBe;
AttrApprovingUsers = s.ssApprovingUsers;
AttrInvoiceApprovalDate = s.ssInvoiceApprovalDate;
AttrProjectPeriod = s.ssProjectPeriod;
AttrProject = s.ssProject;
AttrFrequency = s.ssFrequency;
AttrSAPNumber = s.ssSAPNumber;
AttrSAPRegisterDate = s.ssSAPRegisterDate;
AttrApprovalArea = s.ssApprovalArea;
AttrAccountingUser = s.ssAccountingUser;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_c882e4a9305466afcdc9cd6a9ad70f15Structure, ST_c882e4a9305466afcdc9cd6a9ad70f15Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_c882e4a9305466afcdc9cd6a9ad70f15Structure s) => ToStructure(s, config);
}
public static ST_c882e4a9305466afcdc9cd6a9ad70f15Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_c882e4a9305466afcdc9cd6a9ad70f15Structure obj, IBehaviorsConfiguration config) { 
  ST_c882e4a9305466afcdc9cd6a9ad70f15Structure s = new ST_c882e4a9305466afcdc9cd6a9ad70f15Structure();
  if(obj != null) {
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssSupplier = obj.AttrSupplier == null ? "" : obj.AttrSupplier;
  s.ssSupplierRFC = obj.AttrSupplierRFC == null ? "" : obj.AttrSupplierRFC;
  s.ssRequisitonName = obj.AttrRequisitonName == null ? "" : obj.AttrRequisitonName;
  s.ssRequisitionCreatedOn = obj.AttrRequisitionCreatedOn == null ? "" : obj.AttrRequisitionCreatedOn;
  s.ssInvoiceSerie = obj.AttrInvoiceSerie == null ? "" : obj.AttrInvoiceSerie;
  s.ssInvoiceNumber = obj.AttrInvoiceNumber == null ? "" : obj.AttrInvoiceNumber;
  s.ssInvoiceEmissionDate = obj.AttrInvoiceEmissionDate == null ? "" : obj.AttrInvoiceEmissionDate;
  s.ssSubtotal = obj.AttrSubtotal == null ? "" : obj.AttrSubtotal;
  s.ssIVA = obj.AttrIVA == null ? "" : obj.AttrIVA;
  s.ssRetentionIVA = obj.AttrRetentionIVA == null ? "" : obj.AttrRetentionIVA;
  s.ssISRRetention = obj.AttrISRRetention == null ? "" : obj.AttrISRRetention;
  s.ssExpenditures = obj.AttrExpenditures == null ? "" : obj.AttrExpenditures;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? "" : obj.AttrTotalAmount;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssStatus = obj.AttrStatus == null ? "" : obj.AttrStatus;
  s.ssAssignedUser = obj.AttrAssignedUser == null ? "" : obj.AttrAssignedUser;
  s.ssInvoiceCreationDate = obj.AttrInvoiceCreationDate == null ? "" : obj.AttrInvoiceCreationDate;
  s.ssInvoiceExpirationDate = obj.AttrInvoiceExpirationDate == null ? "" : obj.AttrInvoiceExpirationDate;
  s.ssInvoicePaymentDate = obj.AttrInvoicePaymentDate == null ? "" : obj.AttrInvoicePaymentDate;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssCentrodeAtencion = obj.AttrCentrodeAtencion == null ? "" : obj.AttrCentrodeAtencion;
  s.ssStreet = obj.AttrStreet == null ? "" : obj.AttrStreet;
  s.ssDoorNumber = obj.AttrDoorNumber == null ? "" : obj.AttrDoorNumber;
  s.ssPostalCode = obj.AttrPostalCode == null ? "" : obj.AttrPostalCode;
  s.ssImportTraslado = obj.AttrImportTraslado == null ? "" : obj.AttrImportTraslado;
  s.ssPdfName = obj.AttrPdfName == null ? "" : obj.AttrPdfName;
  s.ssXmlName = obj.AttrXmlName == null ? "" : obj.AttrXmlName;
  s.ssUUID = obj.AttrUUID == null ? "" : obj.AttrUUID;
  s.ssIDCeCo = obj.AttrIDCeCo == null ? "" : obj.AttrIDCeCo;
  s.ssCostCenters = obj.AttrCostCenters == null ? "" : obj.AttrCostCenters;
  s.ssIDCeBe = obj.AttrIDCeBe == null ? "" : obj.AttrIDCeBe;
  s.ssApprovingUsers = obj.AttrApprovingUsers == null ? "" : obj.AttrApprovingUsers;
  s.ssInvoiceApprovalDate = obj.AttrInvoiceApprovalDate == null ? "" : obj.AttrInvoiceApprovalDate;
  s.ssProjectPeriod = obj.AttrProjectPeriod == null ? "" : obj.AttrProjectPeriod;
  s.ssProject = obj.AttrProject == null ? "" : obj.AttrProject;
  s.ssFrequency = obj.AttrFrequency == null ? "" : obj.AttrFrequency;
  s.ssSAPNumber = obj.AttrSAPNumber == null ? "" : obj.AttrSAPNumber;
  s.ssSAPRegisterDate = obj.AttrSAPRegisterDate == null ? "" : obj.AttrSAPRegisterDate;
  s.ssApprovalArea = obj.AttrApprovalArea == null ? "" : obj.AttrApprovalArea;
  s.ssAccountingUser = obj.AttrAccountingUser == null ? "" : obj.AttrAccountingUser;
  }
  return s;
}

public static Func<ST_c882e4a9305466afcdc9cd6a9ad70f15Structure, ssConectaProveedores.RestRecords.JSONST_c882e4a9305466afcdc9cd6a9ad70f15Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_c882e4a9305466afcdc9cd6a9ad70f15Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_c882e4a9305466afcdc9cd6a9ad70f15Structure FromStructure(ST_c882e4a9305466afcdc9cd6a9ad70f15Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_c882e4a9305466afcdc9cd6a9ad70f15Structure(s, config);
}

}


