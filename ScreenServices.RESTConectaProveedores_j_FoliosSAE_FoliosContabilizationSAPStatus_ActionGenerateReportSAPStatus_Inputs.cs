using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionGenerateReportSAPStatus_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_OffsetUtc")]
public int? inParami_OffsetUtc;
[JsonProperty("i_SupplierId")]
public long? inParami_SupplierId;
[JsonProperty("i_InvoiceName")]
public string inParami_InvoiceName;
[JsonProperty("i_FolioNumber")]
public string inParami_FolioNumber;
[JsonProperty("i_InvoiceStatusId")]
public int? inParami_InvoiceStatusId;
[JsonProperty("i_OrderMainNumber")]
public string inParami_OrderMainNumber;
[JsonProperty("i_AssignedTo")]
public string inParami_AssignedTo;
[JsonProperty("i_Project")]
public string inParami_Project;
[JsonProperty("i_Period")]
public string inParami_Period;
[JsonProperty("i_FrequencyId")]
public int? inParami_FrequencyId;
[JsonProperty("i_BusinessValueCategory")]
public string inParami_BusinessValueCategory;
[JsonProperty("i_BusinessValueSubCateg")]
public string inParami_BusinessValueSubCateg;
[JsonProperty("i_PaidOn")]
public String inParami_PaidOn;
[JsonProperty("i_AmountFrom")]
public decimal? inParami_AmountFrom;
[JsonProperty("i_AmountTo")]
public decimal? inParami_AmountTo;
[JsonProperty("i_CurrencyId")]
public string inParami_CurrencyId;
[JsonProperty("i_InvoiceCreatedOn")]
public String inParami_InvoiceCreatedOn;
[JsonProperty("i_FolioCreatedOn")]
public String inParami_FolioCreatedOn;
[JsonProperty("i_SpecialApprovalId")]
public int? inParami_SpecialApprovalId;
[JsonProperty("i_CFDITypeId")]
public int? inParami_CFDITypeId;
[JsonProperty("i_IsSelectAll")]
public bool? inParami_IsSelectAll;
[JsonProperty("i_SelectedIds")]
public string inParami_SelectedIds;


    public static RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionGenerateReportSAPStatus_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionGenerateReportSAPStatus_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionGenerateReportSAPStatus_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionGenerateReportSAPStatus_Model ToModel() {ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionGenerateReportSAPStatus_Model result = new ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionGenerateReportSAPStatus_Model();
result.inParami_OffsetUtc = inParami_OffsetUtc == null ? 0 : inParami_OffsetUtc.Value;
result.inParami_SupplierId = inParami_SupplierId == null ? 0L : inParami_SupplierId.Value;
result.inParami_InvoiceName = inParami_InvoiceName == null ? "" : inParami_InvoiceName;
result.inParami_FolioNumber = inParami_FolioNumber == null ? "" : inParami_FolioNumber;
result.inParami_InvoiceStatusId = inParami_InvoiceStatusId == null ? 0 : inParami_InvoiceStatusId.Value;
result.inParami_OrderMainNumber = inParami_OrderMainNumber == null ? "" : inParami_OrderMainNumber;
result.inParami_AssignedTo = inParami_AssignedTo == null ? "" : inParami_AssignedTo;
result.inParami_Project = inParami_Project == null ? "" : inParami_Project;
result.inParami_Period = inParami_Period == null ? "" : inParami_Period;
result.inParami_FrequencyId = inParami_FrequencyId == null ? 0 : inParami_FrequencyId.Value;
result.inParami_BusinessValueCategory = inParami_BusinessValueCategory == null ? "" : inParami_BusinessValueCategory;
result.inParami_BusinessValueSubCateg = inParami_BusinessValueSubCateg == null ? "" : inParami_BusinessValueSubCateg;
result.inParami_PaidOn = inParami_PaidOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(inParami_PaidOn);
result.inParami_AmountFrom = inParami_AmountFrom == null ? 0.0M : inParami_AmountFrom.Value;
result.inParami_AmountTo = inParami_AmountTo == null ? 0.0M : inParami_AmountTo.Value;
result.inParami_CurrencyId = inParami_CurrencyId == null ? "" : inParami_CurrencyId;
result.inParami_InvoiceCreatedOn = inParami_InvoiceCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(inParami_InvoiceCreatedOn);
result.inParami_FolioCreatedOn = inParami_FolioCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(inParami_FolioCreatedOn);
result.inParami_SpecialApprovalId = inParami_SpecialApprovalId == null ? 0 : inParami_SpecialApprovalId.Value;
result.inParami_CFDITypeId = inParami_CFDITypeId == null ? 0 : inParami_CFDITypeId.Value;
result.inParami_IsSelectAll = inParami_IsSelectAll == null ? false : inParami_IsSelectAll.Value;
result.inParami_SelectedIds = inParami_SelectedIds == null ? "" : inParami_SelectedIds;
return result;
}

}
