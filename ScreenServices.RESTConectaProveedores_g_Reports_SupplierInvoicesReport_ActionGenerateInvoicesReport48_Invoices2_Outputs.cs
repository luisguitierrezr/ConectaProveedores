using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Invoices2_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("File")]
public ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure outParamFile;


    public static RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Invoices2_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_a158c76eb93396680623c04244f48b6cStructure outParamFile) {RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Invoices2_Outputs result = new RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Invoices2_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamFile to the result.outParamFile
result.outParamFile = new ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure();
result.outParamFile.AttrName = outParamFile.ssName;
result.outParamFile.AttrBinaryData = outParamFile.ssBinaryData;
return result;
}


    

    
}
