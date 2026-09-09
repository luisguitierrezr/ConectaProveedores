using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("FolioQList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_118fe20454dd0bf1f0e6d925e7d7544bStructure> varLcFolioQList;
[JsonProperty("NumberOfRecords")]
public int? varLcNumberOfRecords;
[JsonProperty("NumberWithErrors")]
public int? varLcNumberWithErrors;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> varLcFilesList;
[JsonProperty("HelpPopup")]
public bool? varLcHelpPopup;
[JsonProperty("l_OrderMainID")]
public long? varLcl_OrderMainID;
[JsonProperty("l_FolioAccData")]
public ssConectaProveedores.RestRecords.RESTST_6dc39d329f4b959722daa75bc2f62c1fStructure varLcl_FolioAccData;
[JsonProperty("GetSupplierName")]
public RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Outputs varLcGetSupplierName;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ScreenModel ToModel() {RL_f4ab0a048438c19ab1537693fa69f7c4 varLcFolioQList = RL_f4ab0a048438c19ab1537693fa69f7c4.FromRestList(variables.varLcFolioQList, ssConectaProveedores.RestRecords.RESTST_118fe20454dd0bf1f0e6d925e7d7544bStructure.ToStructure);
int varLcNumberOfRecords = variables.varLcNumberOfRecords == null ? 0 : variables.varLcNumberOfRecords.Value;
int varLcNumberWithErrors = variables.varLcNumberWithErrors == null ? 0 : variables.varLcNumberWithErrors.Value;
RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
bool varLcHelpPopup = variables.varLcHelpPopup == null ? false : variables.varLcHelpPopup.Value;
long varLcl_OrderMainID = variables.varLcl_OrderMainID == null ? 0L : variables.varLcl_OrderMainID.Value;
ST_6dc39d329f4b959722daa75bc2f62c1fStructure varLcl_FolioAccData = ssConectaProveedores.RestRecords.RESTST_6dc39d329f4b959722daa75bc2f62c1fStructure.ToStructure(variables.varLcl_FolioAccData);
ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Model _varLcGetSupplierName = (variables.varLcGetSupplierName != null) ? RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Outputs.ToModel(variables.varLcGetSupplierName) : null;
ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ScreenModel(varLcFolioQList, varLcNumberOfRecords, varLcNumberWithErrors, varLcFilesList, varLcHelpPopup, varLcl_OrderMainID, varLcl_FolioAccData, _varLcGetSupplierName, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
