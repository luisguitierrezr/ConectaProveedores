using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ReportSAPStatus_Item
public class RESTST_fc6debbee6469de53c667334dded1d22Structure : AbstractRESTStructure<ST_fc6debbee6469de53c667334dded1d22Structure> {
[JsonProperty("SupplierName")]
public string AttrSupplierName;

[JsonProperty("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("InvoiceName")]
public string AttrInvoiceName;

[JsonProperty("FolioNumber")]
public string AttrFolioNumber;

[JsonProperty("InvoiceStatus")]
public string AttrInvoiceStatus;

[JsonProperty("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("AssignedTo")]
public string AttrAssignedTo;

[JsonProperty("AssetServiceDescription")]
public string AttrAssetServiceDescription;

[JsonProperty("IssueDate")]
public string AttrIssueDate;

[JsonProperty("Frequency")]
public string AttrFrequency;

[JsonProperty("BusinessValueCategory")]
public string AttrBusinessValueCategory;

[JsonProperty("BusinessValueSubCategory")]
public string AttrBusinessValueSubCategory;

[JsonProperty("PaidOn")]
public string AttrPaidOn;

[JsonProperty("TotalAmount")]
public decimal? AttrTotalAmount;

[JsonProperty("InvoiceDate")]
public string AttrInvoiceDate;

[JsonProperty("Currency")]
public string AttrCurrency;

[JsonProperty("InvoiceCreatedOn")]
public string AttrInvoiceCreatedOn;

[JsonProperty("SpecialApproval")]
public string AttrSpecialApproval;

[JsonProperty("Tags")]
public string AttrTags;

[JsonProperty("TypeCFDI")]
public string AttrTypeCFDI;

[JsonProperty("AvailableTasks")]
public string AttrAvailableTasks;

[JsonProperty("IsSelected")]
public bool? AttrIsSelected;

public RESTST_fc6debbee6469de53c667334dded1d22Structure() { }

public RESTST_fc6debbee6469de53c667334dded1d22Structure (ST_fc6debbee6469de53c667334dded1d22Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrInvoiceName = ConvertToRestWithoutDefaults(s.ssInvoiceName, "");
AttrFolioNumber = ConvertToRestWithoutDefaults(s.ssFolioNumber, "");
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssInvoiceStatus, "");
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrAssignedTo = ConvertToRestWithoutDefaults(s.ssAssignedTo, "");
AttrAssetServiceDescription = ConvertToRestWithoutDefaults(s.ssAssetServiceDescription, "");
AttrIssueDate = ConvertToRestWithoutDefaults(s.ssIssueDate, "");
AttrFrequency = ConvertToRestWithoutDefaults(s.ssFrequency, "");
AttrBusinessValueCategory = ConvertToRestWithoutDefaults(s.ssBusinessValueCategory, "");
AttrBusinessValueSubCategory = ConvertToRestWithoutDefaults(s.ssBusinessValueSubCategory, "");
AttrPaidOn = ConvertToRestWithoutDefaults(s.ssPaidOn, "");
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
AttrInvoiceDate = ConvertToRestWithoutDefaults(s.ssInvoiceDate, "");
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrInvoiceCreatedOn = ConvertToRestWithoutDefaults(s.ssInvoiceCreatedOn, "");
AttrSpecialApproval = ConvertToRestWithoutDefaults(s.ssSpecialApproval, "");
AttrTags = ConvertToRestWithoutDefaults(s.ssTags, "");
AttrTypeCFDI = ConvertToRestWithoutDefaults(s.ssTypeCFDI, "");
AttrAvailableTasks = ConvertToRestWithoutDefaults(s.ssAvailableTasks, "");
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
  } else {
AttrSupplierName = s.ssSupplierName;
AttrSupplierNumber = s.ssSupplierNumber;
AttrInvoiceName = s.ssInvoiceName;
AttrFolioNumber = s.ssFolioNumber;
AttrInvoiceStatus = s.ssInvoiceStatus;
AttrOrderNumber = s.ssOrderNumber;
AttrAssignedTo = s.ssAssignedTo;
AttrAssetServiceDescription = s.ssAssetServiceDescription;
AttrIssueDate = s.ssIssueDate;
AttrFrequency = s.ssFrequency;
AttrBusinessValueCategory = s.ssBusinessValueCategory;
AttrBusinessValueSubCategory = s.ssBusinessValueSubCategory;
AttrPaidOn = s.ssPaidOn;
AttrTotalAmount = (decimal?) s.ssTotalAmount;
AttrInvoiceDate = s.ssInvoiceDate;
AttrCurrency = s.ssCurrency;
AttrInvoiceCreatedOn = s.ssInvoiceCreatedOn;
AttrSpecialApproval = s.ssSpecialApproval;
AttrTags = s.ssTags;
AttrTypeCFDI = s.ssTypeCFDI;
AttrAvailableTasks = s.ssAvailableTasks;
AttrIsSelected = (bool?) s.ssIsSelected;
  }
}

public static ST_fc6debbee6469de53c667334dded1d22Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_fc6debbee6469de53c667334dded1d22Structure obj) { 
  ST_fc6debbee6469de53c667334dded1d22Structure s = new ST_fc6debbee6469de53c667334dded1d22Structure();
  if(obj != null) {
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssInvoiceName = obj.AttrInvoiceName == null ? "" : obj.AttrInvoiceName;
  s.ssFolioNumber = obj.AttrFolioNumber == null ? "" : obj.AttrFolioNumber;
  s.ssInvoiceStatus = obj.AttrInvoiceStatus == null ? "" : obj.AttrInvoiceStatus;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssAssignedTo = obj.AttrAssignedTo == null ? "" : obj.AttrAssignedTo;
  s.ssAssetServiceDescription = obj.AttrAssetServiceDescription == null ? "" : obj.AttrAssetServiceDescription;
  s.ssIssueDate = obj.AttrIssueDate == null ? "" : obj.AttrIssueDate;
  s.ssFrequency = obj.AttrFrequency == null ? "" : obj.AttrFrequency;
  s.ssBusinessValueCategory = obj.AttrBusinessValueCategory == null ? "" : obj.AttrBusinessValueCategory;
  s.ssBusinessValueSubCategory = obj.AttrBusinessValueSubCategory == null ? "" : obj.AttrBusinessValueSubCategory;
  s.ssPaidOn = obj.AttrPaidOn == null ? "" : obj.AttrPaidOn;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  s.ssInvoiceDate = obj.AttrInvoiceDate == null ? "" : obj.AttrInvoiceDate;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssInvoiceCreatedOn = obj.AttrInvoiceCreatedOn == null ? "" : obj.AttrInvoiceCreatedOn;
  s.ssSpecialApproval = obj.AttrSpecialApproval == null ? "" : obj.AttrSpecialApproval;
  s.ssTags = obj.AttrTags == null ? "" : obj.AttrTags;
  s.ssTypeCFDI = obj.AttrTypeCFDI == null ? "" : obj.AttrTypeCFDI;
  s.ssAvailableTasks = obj.AttrAvailableTasks == null ? "" : obj.AttrAvailableTasks;
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  }
  return s;
}

public static Func<ST_fc6debbee6469de53c667334dded1d22Structure, ssConectaProveedores.RestRecords.RESTST_fc6debbee6469de53c667334dded1d22Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_fc6debbee6469de53c667334dded1d22Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_fc6debbee6469de53c667334dded1d22Structure FromStructure(ST_fc6debbee6469de53c667334dded1d22Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_fc6debbee6469de53c667334dded1d22Structure(s, config);
}

}


