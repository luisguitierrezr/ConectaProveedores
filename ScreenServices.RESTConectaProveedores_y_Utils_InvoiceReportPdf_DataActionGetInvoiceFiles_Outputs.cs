using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("FilesString")]
public string outParamFilesString;


    public static RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamFilesString) {RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Outputs result = new RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Outputs();
result.outParamFilesString = outParamFilesString;
return result;
}


    public static ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Model ToModel(RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Outputs variables) {ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Model result = new ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Model();
result.outParamFilesString = variables == null || variables.outParamFilesString == null ? "" : variables.outParamFilesString;
return result;
}


    public static RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Outputs result = new RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Outputs();
result.outParamFilesString = screenModel.outParamFilesString;
return result;
}

}
