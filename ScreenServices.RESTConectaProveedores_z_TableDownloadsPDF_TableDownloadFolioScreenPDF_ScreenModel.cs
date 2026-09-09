using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("StringListIds")]
public string inParamStringListIds;
[JsonProperty("FolioIdsList")]
public RestList<ssConectaProveedores.RestRecords.RESTSTTextStructure> varLcFolioIdsList;
[JsonProperty("GetFolios")]
public RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Outputs varLcGetFolios;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ScreenModel ToModel() {string inParamStringListIds = variables.inParamStringListIds == null ? "" : variables.inParamStringListIds;
RLTextList varLcFolioIdsList = RLTextList.FromRestList(variables.varLcFolioIdsList, ssConectaProveedores.RestRecords.RESTSTTextStructure.ToStructure);
ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Model _varLcGetFolios = (variables.varLcGetFolios != null) ? RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Outputs.ToModel(variables.varLcGetFolios) : null;
ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ScreenModel screenModel = new ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ScreenModel(inParamStringListIds, varLcFolioIdsList, _varLcGetFolios, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
