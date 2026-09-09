using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoiceApprovalsCurrentApprover")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_0c929027c696b201a1aceb2f23c1d74d> ScreenDataSetGetInvoiceApprovalsCurrentApprover;
[JsonProperty("InvoiceId")]
public long? inParamInvoiceId;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_ScreenModel ToModel() {long inParamInvoiceId = variables.inParamInvoiceId == null ? 0L : variables.inParamInvoiceId.Value;
AggregateRecord<RL_bed92cf49c584b7d4ab2b8923c043fa1> _ScreenDataSetGetInvoiceApprovalsCurrentApprover = (variables.ScreenDataSetGetInvoiceApprovalsCurrentApprover != null) ? variables.ScreenDataSetGetInvoiceApprovalsCurrentApprover.FromJS((array) => {
return RL_bed92cf49c584b7d4ab2b8923c043fa1.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_0c929027c696b201a1aceb2f23c1d74d.ToStructure);
}
) : null;
ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_ScreenModel screenModel = new ConectaProveedores_d_Invoices_Wb_InvoicesCurrentApprover_ScreenModel(inParamInvoiceId, _ScreenDataSetGetInvoiceApprovalsCurrentApprover, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
