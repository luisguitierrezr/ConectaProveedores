using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Wb_OrderFilesPreview_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderRequestFileById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_73d8126c722e2b4dd662dab2bf1a72d1> ScreenDataSetGetOrderRequestFileById;
[JsonProperty("OrderRequestFileId")]
public long? inParamOrderRequestFileId;
[JsonProperty("IsOpenPopupOtherFiles")]
public bool? varLcIsOpenPopupOtherFiles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_Wb_OrderFilesPreview_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_Wb_OrderFilesPreview_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_Wb_OrderFilesPreview_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_Wb_OrderFilesPreview_ScreenModel ToModel() {long inParamOrderRequestFileId = variables.inParamOrderRequestFileId == null ? 0L : variables.inParamOrderRequestFileId.Value;
bool varLcIsOpenPopupOtherFiles = variables.varLcIsOpenPopupOtherFiles == null ? false : variables.varLcIsOpenPopupOtherFiles.Value;
AggregateRecord<RL_d258c3d50d870257794347fdeb7cc218> _ScreenDataSetGetOrderRequestFileById = (variables.ScreenDataSetGetOrderRequestFileById != null) ? variables.ScreenDataSetGetOrderRequestFileById.FromJS((array) => {
return RL_d258c3d50d870257794347fdeb7cc218.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_73d8126c722e2b4dd662dab2bf1a72d1.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_Wb_OrderFilesPreview_ScreenModel screenModel = new ConectaProveedores_e_Orders_Wb_OrderFilesPreview_ScreenModel(inParamOrderRequestFileId, varLcIsOpenPopupOtherFiles, _ScreenDataSetGetOrderRequestFileById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
