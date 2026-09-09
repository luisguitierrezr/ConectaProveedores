using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_xml")]
public string outParamo_xml;
[JsonProperty("o_Filename")]
public string outParamo_Filename;
[JsonProperty("o_Binary")]
public byte[] outParamo_Binary;


    public static RESTConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamo_xml, string outParamo_Filename, byte[] outParamo_Binary) {RESTConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Outputs result = new RESTConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Outputs();
result.outParamo_xml = outParamo_xml;
result.outParamo_Filename = outParamo_Filename;
result.outParamo_Binary = outParamo_Binary;
return result;
}


    public static ConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Model ToModel(RESTConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Outputs variables) {ConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Model result = new ConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Model();
result.outParamo_xml = variables == null || variables.outParamo_xml == null ? "" : variables.outParamo_xml;
result.outParamo_Filename = variables == null || variables.outParamo_Filename == null ? "" : variables.outParamo_Filename;
result.outParamo_Binary = variables == null || variables.outParamo_Binary == null ? new byte[] {} : variables.outParamo_Binary;
return result;
}


    public static RESTConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Outputs result = new RESTConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Outputs();
result.outParamo_xml = screenModel.outParamo_xml;
result.outParamo_Filename = screenModel.outParamo_Filename;
result.outParamo_Binary = screenModel.outParamo_Binary;
return result;
}

}
