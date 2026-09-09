using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderFileById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_a7394a353dc1b7f636aaced209e66116> ScreenDataSetGetOrderFileById;
[JsonProperty("OrderFileId")]
public long? inParamOrderFileId;
[JsonProperty("IsOpenPopupOtherFiles")]
public bool? varLcIsOpenPopupOtherFiles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_ScreenModel ToModel() {long inParamOrderFileId = variables.inParamOrderFileId == null ? 0L : variables.inParamOrderFileId.Value;
bool varLcIsOpenPopupOtherFiles = variables.varLcIsOpenPopupOtherFiles == null ? false : variables.varLcIsOpenPopupOtherFiles.Value;
AggregateRecord<RL_1952495fe738735251c431fd1e1fd0f1> _ScreenDataSetGetOrderFileById = (variables.ScreenDataSetGetOrderFileById != null) ? variables.ScreenDataSetGetOrderFileById.FromJS((array) => {
return RL_1952495fe738735251c431fd1e1fd0f1.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_a7394a353dc1b7f636aaced209e66116.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_ScreenModel screenModel = new ConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_ScreenModel(inParamOrderFileId, varLcIsOpenPopupOtherFiles, _ScreenDataSetGetOrderFileById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
