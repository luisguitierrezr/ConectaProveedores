using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesScreenTableStructure
public class JSONST_3c6142d371d14231f5ddee7b64c28681Structure : AbstractRESTStructure<ST_3c6142d371d14231f5ddee7b64c28681Structure> {
[JsonProperty("InvoiceId")]
[JsonPropertyName("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("InvoiceApprovalLevelId")]
[JsonPropertyName("InvoiceApprovalLevelId")]
public long? AttrInvoiceApprovalLevelId;

[JsonProperty("InvoiceName")]
[JsonPropertyName("InvoiceName")]
public string AttrInvoiceName;

[JsonProperty("InvoiceStatus")]
[JsonPropertyName("InvoiceStatus")]
public string AttrInvoiceStatus;

[JsonProperty("RequisitionName")]
[JsonPropertyName("RequisitionName")]
public string AttrRequisitionName;

[JsonProperty("SupplierName")]
[JsonPropertyName("SupplierName")]
public string AttrSupplierName;

[JsonProperty("SupplierNumber")]
[JsonPropertyName("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public string AttrTotalAmount;

[JsonProperty("UploadDate")]
[JsonPropertyName("UploadDate")]
public string AttrUploadDate;

[JsonProperty("AssignedTo")]
[JsonPropertyName("AssignedTo")]
public string AttrAssignedTo;

[JsonProperty("Action")]
[JsonPropertyName("Action")]
public string AttrAction;

public JSONST_3c6142d371d14231f5ddee7b64c28681Structure() { }

public JSONST_3c6142d371d14231f5ddee7b64c28681Structure (ST_3c6142d371d14231f5ddee7b64c28681Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrInvoiceApprovalLevelId = ConvertToRestWithoutDefaults(s.ssInvoiceApprovalLevelId, 0L);
AttrInvoiceName = ConvertToRestWithoutDefaults(s.ssInvoiceName, "");
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssInvoiceStatus, "");
AttrRequisitionName = ConvertToRestWithoutDefaults(s.ssRequisitionName, "");
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, "");
AttrUploadDate = ConvertToRestWithoutDefaults(s.ssUploadDate, "");
AttrAssignedTo = ConvertToRestWithoutDefaults(s.ssAssignedTo, "");
AttrAction = ConvertToRestWithoutDefaults(s.ssAction, "");
  } else {
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrInvoiceApprovalLevelId = (long?) s.ssInvoiceApprovalLevelId;
AttrInvoiceName = s.ssInvoiceName;
AttrInvoiceStatus = s.ssInvoiceStatus;
AttrRequisitionName = s.ssRequisitionName;
AttrSupplierName = s.ssSupplierName;
AttrSupplierNumber = s.ssSupplierNumber;
AttrTotalAmount = s.ssTotalAmount;
AttrUploadDate = s.ssUploadDate;
AttrAssignedTo = s.ssAssignedTo;
AttrAction = s.ssAction;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_3c6142d371d14231f5ddee7b64c28681Structure, ST_3c6142d371d14231f5ddee7b64c28681Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_3c6142d371d14231f5ddee7b64c28681Structure s) => ToStructure(s, config);
}
public static ST_3c6142d371d14231f5ddee7b64c28681Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_3c6142d371d14231f5ddee7b64c28681Structure obj, IBehaviorsConfiguration config) { 
  ST_3c6142d371d14231f5ddee7b64c28681Structure s = new ST_3c6142d371d14231f5ddee7b64c28681Structure();
  if(obj != null) {
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssInvoiceApprovalLevelId = obj.AttrInvoiceApprovalLevelId == null ? 0L : obj.AttrInvoiceApprovalLevelId.Value;
  s.ssInvoiceName = obj.AttrInvoiceName == null ? "" : obj.AttrInvoiceName;
  s.ssInvoiceStatus = obj.AttrInvoiceStatus == null ? "" : obj.AttrInvoiceStatus;
  s.ssRequisitionName = obj.AttrRequisitionName == null ? "" : obj.AttrRequisitionName;
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? "" : obj.AttrTotalAmount;
  s.ssUploadDate = obj.AttrUploadDate == null ? "" : obj.AttrUploadDate;
  s.ssAssignedTo = obj.AttrAssignedTo == null ? "" : obj.AttrAssignedTo;
  s.ssAction = obj.AttrAction == null ? "" : obj.AttrAction;
  }
  return s;
}

public static Func<ST_3c6142d371d14231f5ddee7b64c28681Structure, ssConectaProveedores.RestRecords.JSONST_3c6142d371d14231f5ddee7b64c28681Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3c6142d371d14231f5ddee7b64c28681Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_3c6142d371d14231f5ddee7b64c28681Structure FromStructure(ST_3c6142d371d14231f5ddee7b64c28681Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_3c6142d371d14231f5ddee7b64c28681Structure(s, config);
}

}


