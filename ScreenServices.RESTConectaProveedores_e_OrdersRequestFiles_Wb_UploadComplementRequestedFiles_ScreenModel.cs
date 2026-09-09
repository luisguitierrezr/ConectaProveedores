using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("i_OrderId")]
public long? inParami_OrderId;
[JsonProperty("l_RequestFileId")]
public long? varLcl_RequestFileId;
[JsonProperty("ShowPopup")]
public bool? varLcShowPopup;
[JsonProperty("GetOrderRequestFiles")]
public RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Outputs varLcGetOrderRequestFiles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_ScreenModel ToModel() {long inParami_OrderId = variables.inParami_OrderId == null ? 0L : variables.inParami_OrderId.Value;
long varLcl_RequestFileId = variables.varLcl_RequestFileId == null ? 0L : variables.varLcl_RequestFileId.Value;
bool varLcShowPopup = variables.varLcShowPopup == null ? false : variables.varLcShowPopup.Value;
ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Model _varLcGetOrderRequestFiles = (variables.varLcGetOrderRequestFiles != null) ? RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Outputs.ToModel(variables.varLcGetOrderRequestFiles) : null;
ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_ScreenModel screenModel = new ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_ScreenModel(inParami_OrderId, varLcl_RequestFileId, varLcShowPopup, _varLcGetOrderRequestFiles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
