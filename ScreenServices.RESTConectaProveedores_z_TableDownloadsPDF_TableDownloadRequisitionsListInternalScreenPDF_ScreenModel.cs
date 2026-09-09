using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("StringListIds")]
public string inParamStringListIds;
[JsonProperty("StringListLevelIds")]
public string inParamStringListLevelIds;
[JsonProperty("RequisitionIdList")]
public RestList<ssConectaProveedores.RestRecords.RESTSTTextStructure> varLcRequisitionIdList;
[JsonProperty("RequisitionLevelIdList")]
public RestList<ssConectaProveedores.RestRecords.RESTSTTextStructure> varLcRequisitionLevelIdList;
[JsonProperty("GetRequisitions")]
public RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_DataActionGetRequisitions_Outputs varLcGetRequisitions;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_ScreenModel ToModel() {string inParamStringListIds = variables.inParamStringListIds == null ? "" : variables.inParamStringListIds;
string inParamStringListLevelIds = variables.inParamStringListLevelIds == null ? "" : variables.inParamStringListLevelIds;
RLTextList varLcRequisitionIdList = RLTextList.FromRestList(variables.varLcRequisitionIdList, ssConectaProveedores.RestRecords.RESTSTTextStructure.ToStructure);
RLTextList varLcRequisitionLevelIdList = RLTextList.FromRestList(variables.varLcRequisitionLevelIdList, ssConectaProveedores.RestRecords.RESTSTTextStructure.ToStructure);
ConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_DataActionGetRequisitions_Model _varLcGetRequisitions = (variables.varLcGetRequisitions != null) ? RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_DataActionGetRequisitions_Outputs.ToModel(variables.varLcGetRequisitions) : null;
ConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_ScreenModel screenModel = new ConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_ScreenModel(inParamStringListIds, inParamStringListLevelIds, varLcRequisitionIdList, varLcRequisitionLevelIdList, _varLcGetRequisitions, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
