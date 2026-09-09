using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ExpedicionFiscal")]
public string outParamExpedicionFiscal;
[JsonProperty("Name")]
public string outParamName;
[JsonProperty("RFC")]
public string outParamRFC;
[JsonProperty("Society")]
public string outParamSociety;
[JsonProperty("SupplierNr")]
public string outParamSupplierNr;
[JsonProperty("IsNational")]
public bool? outParamIsNational;
[JsonProperty("IsActiveDEV_TK395")]
public bool? outParamIsActiveDEV_TK395;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamExpedicionFiscal, string outParamName, string outParamRFC, string outParamSociety, string outParamSupplierNr, bool outParamIsNational, bool outParamIsActiveDEV_TK395) {RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Outputs();
// Write optimized result.outParamExpedicionFiscal
result.outParamExpedicionFiscal = "";
// Write optimized result.outParamName
result.outParamName = "";
// Write optimized result.outParamRFC
result.outParamRFC = "";
// Write optimized result.outParamSociety
result.outParamSociety = "";
// Write optimized result.outParamSupplierNr
result.outParamSupplierNr = "";
result.outParamIsNational = (bool?) outParamIsNational;
result.outParamIsActiveDEV_TK395 = (bool?) outParamIsActiveDEV_TK395;
return result;
}


    public static ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Model ToModel(RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Outputs variables) {ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Model result = new ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Model();
result.outParamExpedicionFiscal = variables == null || variables.outParamExpedicionFiscal == null ? "" : variables.outParamExpedicionFiscal;
result.outParamName = variables == null || variables.outParamName == null ? "" : variables.outParamName;
result.outParamRFC = variables == null || variables.outParamRFC == null ? "" : variables.outParamRFC;
result.outParamSociety = variables == null || variables.outParamSociety == null ? "" : variables.outParamSociety;
result.outParamSupplierNr = variables == null || variables.outParamSupplierNr == null ? "" : variables.outParamSupplierNr;
result.outParamIsNational = variables == null || variables.outParamIsNational == null ? false : variables.outParamIsNational.Value;
result.outParamIsActiveDEV_TK395 = variables == null || variables.outParamIsActiveDEV_TK395 == null ? false : variables.outParamIsActiveDEV_TK395.Value;
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Outputs();
result.outParamExpedicionFiscal = screenModel.outParamExpedicionFiscal;
result.outParamName = screenModel.outParamName;
result.outParamRFC = screenModel.outParamRFC;
result.outParamSociety = screenModel.outParamSociety;
result.outParamSupplierNr = screenModel.outParamSupplierNr;
result.outParamIsNational = (bool?) screenModel.outParamIsNational;
result.outParamIsActiveDEV_TK395 = (bool?) screenModel.outParamIsActiveDEV_TK395;
return result;
}

}
