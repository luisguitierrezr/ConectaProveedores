using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("StringListIds")]
public string inParamStringListIds;
[JsonProperty("OrderIdList")]
public RestList<ssConectaProveedores.RestRecords.RESTSTTextStructure> varLcOrderIdList;
[JsonProperty("GetOrders")]
public RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Outputs varLcGetOrders;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ScreenModel ToModel() {string inParamStringListIds = variables.inParamStringListIds == null ? "" : variables.inParamStringListIds;
RLTextList varLcOrderIdList = RLTextList.FromRestList(variables.varLcOrderIdList, ssConectaProveedores.RestRecords.RESTSTTextStructure.ToStructure);
ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Model _varLcGetOrders = (variables.varLcGetOrders != null) ? RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Outputs.ToModel(variables.varLcGetOrders) : null;
ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ScreenModel screenModel = new ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ScreenModel(inParamStringListIds, varLcOrderIdList, _varLcGetOrders, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
