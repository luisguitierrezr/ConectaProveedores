using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderRequestFileCommentsByOrderRequestFileId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_45b72d53609a7a1da4a98878c5ec7590> ScreenDataSetGetOrderRequestFileCommentsByOrderRequestFileId;
[JsonProperty("OrderRequestFilesId")]
public long? inParamOrderRequestFilesId;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_ScreenModel ToModel() {long inParamOrderRequestFilesId = variables.inParamOrderRequestFilesId == null ? 0L : variables.inParamOrderRequestFilesId.Value;
AggregateRecord<RL_520d7bdfa592e7631b7e51777aa739f1> _ScreenDataSetGetOrderRequestFileCommentsByOrderRequestFileId = (variables.ScreenDataSetGetOrderRequestFileCommentsByOrderRequestFileId != null) ? variables.ScreenDataSetGetOrderRequestFileCommentsByOrderRequestFileId.FromJS((array) => {
return RL_520d7bdfa592e7631b7e51777aa739f1.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_45b72d53609a7a1da4a98878c5ec7590.ToStructure);
}
) : null;
ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_ScreenModel screenModel = new ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_ScreenModel(inParamOrderRequestFilesId, _ScreenDataSetGetOrderRequestFileCommentsByOrderRequestFileId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
