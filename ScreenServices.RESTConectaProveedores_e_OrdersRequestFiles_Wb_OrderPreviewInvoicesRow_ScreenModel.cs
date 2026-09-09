using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrderPreviewInvoicesRow_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoiceFilesByInvoiceId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0> ScreenDataSetGetInvoiceFilesByInvoiceId;
[JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrderPreviewInvoicesRow_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrderPreviewInvoicesRow_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrderPreviewInvoicesRow_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_OrdersRequestFiles_Wb_OrderPreviewInvoicesRow_ScreenModel ToModel() {long inParami_InvoiceId = variables.inParami_InvoiceId == null ? 0L : variables.inParami_InvoiceId.Value;
AggregateRecord<RL_e40371698c3bd2f83f525cf47c117634> _ScreenDataSetGetInvoiceFilesByInvoiceId = (variables.ScreenDataSetGetInvoiceFilesByInvoiceId != null) ? variables.ScreenDataSetGetInvoiceFilesByInvoiceId.FromJS((array) => {
return RL_e40371698c3bd2f83f525cf47c117634.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_7cb091de697d14a1ce465208aa77fcb0.ToStructure);
}
) : null;
ConectaProveedores_e_OrdersRequestFiles_Wb_OrderPreviewInvoicesRow_ScreenModel screenModel = new ConectaProveedores_e_OrdersRequestFiles_Wb_OrderPreviewInvoicesRow_ScreenModel(inParami_InvoiceId, _ScreenDataSetGetInvoiceFilesByInvoiceId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
