using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_QuantityDelivered_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFolioItemsByOrderMainItemId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d39c50b1f75893246aa84db474d82d50> ScreenDataSetGetFolioItemsByOrderMainItemId;
[JsonProperty("OrderMainItemID")]
public long? inParamOrderMainItemID;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_QuantityDelivered_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_QuantityDelivered_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_QuantityDelivered_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_QuantityDelivered_ScreenModel ToModel() {long inParamOrderMainItemID = variables.inParamOrderMainItemID == null ? 0L : variables.inParamOrderMainItemID.Value;
AggregateRecord<RL_f09a54b116410a7027db4eb30998df1e> _ScreenDataSetGetFolioItemsByOrderMainItemId = (variables.ScreenDataSetGetFolioItemsByOrderMainItemId != null) ? variables.ScreenDataSetGetFolioItemsByOrderMainItemId.FromJS((array) => {
return RL_f09a54b116410a7027db4eb30998df1e.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d39c50b1f75893246aa84db474d82d50.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_QuantityDelivered_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_QuantityDelivered_ScreenModel(inParamOrderMainItemID, _ScreenDataSetGetFolioItemsByOrderMainItemId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
