using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_ActionGetAccountingLayoutFile_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_File")]
public ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure outParamo_File;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_ActionGetAccountingLayoutFile_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_ActionGetAccountingLayoutFile_Outputs result = new RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAccountingImport_ActionGetAccountingLayoutFile_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamo_File to the result.outParamo_File
result.outParamo_File = new ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure();
result.outParamo_File.AttrName = outParamo_File.ssName;
result.outParamo_File.AttrBinaryData = outParamo_File.ssBinaryData;
return result;
}


    

    
}
