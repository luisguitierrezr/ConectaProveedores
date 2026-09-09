using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoiceWaybill")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_79b8311427bcbe4ce4ecbe042bf03773> ScreenDataSetGetInvoiceWaybill;
[JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_ExtendedClass")]
public string inParami_ExtendedClass;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_ScreenModel ToModel() {long inParami_InvoiceId = variables.inParami_InvoiceId == null ? 0L : variables.inParami_InvoiceId.Value;
string inParami_ExtendedClass = variables.inParami_ExtendedClass == null ? "" : variables.inParami_ExtendedClass;
AggregateRecord<RL_14eea858c7edac2969e2f91a68030ca7> _ScreenDataSetGetInvoiceWaybill = (variables.ScreenDataSetGetInvoiceWaybill != null) ? variables.ScreenDataSetGetInvoiceWaybill.FromJS((array) => {
return RL_14eea858c7edac2969e2f91a68030ca7.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_79b8311427bcbe4ce4ecbe042bf03773.ToStructure);
}
) : null;
ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_ScreenModel screenModel = new ConectaProveedores_d_Invoices_Wb_i_InvoiceAccountingWaybill_ScreenModel(inParami_InvoiceId, inParami_ExtendedClass, _ScreenDataSetGetInvoiceWaybill, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
