using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetSupplier_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ExpedicionFiscal")]
public string outParamExpedicionFiscal;
[JsonProperty("IsNational")]
public bool? outParamIsNational;
[JsonProperty("Name")]
public string outParamName;
[JsonProperty("RFC")]
public string outParamRFC;
[JsonProperty("Society")]
public string outParamSociety;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetSupplier_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamExpedicionFiscal, bool outParamIsNational, string outParamName, string outParamRFC, string outParamSociety) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetSupplier_Outputs result = new RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetSupplier_Outputs();
// Write optimized result.outParamExpedicionFiscal
result.outParamExpedicionFiscal = "";
// Write optimized result.outParamIsNational
result.outParamIsNational = (bool?) false;
// Write optimized result.outParamName
result.outParamName = "";
// Write optimized result.outParamRFC
result.outParamRFC = "";
// Write optimized result.outParamSociety
result.outParamSociety = "";
return result;
}


    public static ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetSupplier_Model ToModel(RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetSupplier_Outputs variables) {ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetSupplier_Model result = new ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetSupplier_Model();
result.outParamExpedicionFiscal = variables == null || variables.outParamExpedicionFiscal == null ? "" : variables.outParamExpedicionFiscal;
result.outParamIsNational = variables == null || variables.outParamIsNational == null ? false : variables.outParamIsNational.Value;
result.outParamName = variables == null || variables.outParamName == null ? "" : variables.outParamName;
result.outParamRFC = variables == null || variables.outParamRFC == null ? "" : variables.outParamRFC;
result.outParamSociety = variables == null || variables.outParamSociety == null ? "" : variables.outParamSociety;
return result;
}


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetSupplier_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetSupplier_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetSupplier_Outputs result = new RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultiple_DataActionGetSupplier_Outputs();
result.outParamExpedicionFiscal = screenModel.outParamExpedicionFiscal;
result.outParamIsNational = (bool?) screenModel.outParamIsNational;
result.outParamName = screenModel.outParamName;
result.outParamRFC = screenModel.outParamRFC;
result.outParamSociety = screenModel.outParamSociety;
return result;
}

}
