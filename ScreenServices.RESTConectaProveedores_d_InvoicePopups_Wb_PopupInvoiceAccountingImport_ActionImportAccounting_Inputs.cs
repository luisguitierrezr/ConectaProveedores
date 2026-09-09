using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_ActionImportAccounting_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_File")]
public ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure inParami_File;
[JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_SupplierNumber")]
public string inParami_SupplierNumber;
[JsonProperty("i_TotalAmount")]
public decimal? inParami_TotalAmount;
[JsonProperty("i_InvoiceAccountingId")]
public long? inParami_InvoiceAccountingId;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_ActionImportAccounting_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_ActionImportAccounting_Inputs result = inputParameters.ToObject<RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_ActionImportAccounting_Inputs>(settings);
return result;
}


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_ActionImportAccounting_Model ToModel() {ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_ActionImportAccounting_Model result = new ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_ActionImportAccounting_Model();
result.inParami_File = ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure.ToStructure(inParami_File);
result.inParami_InvoiceId = inParami_InvoiceId == null ? 0L : inParami_InvoiceId.Value;
result.inParami_SupplierNumber = inParami_SupplierNumber == null ? "" : inParami_SupplierNumber;
result.inParami_TotalAmount = inParami_TotalAmount == null ? 0.0M : inParami_TotalAmount.Value;
result.inParami_InvoiceAccountingId = inParami_InvoiceAccountingId == null ? 0L : inParami_InvoiceAccountingId.Value;
return result;
}

}
