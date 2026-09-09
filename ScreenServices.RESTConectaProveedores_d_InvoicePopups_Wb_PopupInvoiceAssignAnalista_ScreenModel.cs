using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetEligebleUsers")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_77956dae907db5f208e8a848dc366336> ScreenDataSetGetEligebleUsers;
[JsonProperty("l_InvoiceApprovalLevelList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_7d9af3f1351b60af34cc932af3010814> inParaml_InvoiceApprovalLevelList;
[JsonProperty("l_IsBusy")]
public bool? varLcl_IsBusy;
[JsonProperty("l_UserSelected")]
public string varLcl_UserSelected;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_ScreenModel ToModel() {RL_09457db01df0de3852b9312cdd42fb2a inParaml_InvoiceApprovalLevelList = RL_09457db01df0de3852b9312cdd42fb2a.FromRestList(variables.inParaml_InvoiceApprovalLevelList, ssConectaProveedores.RestRecords.RESTRC_7d9af3f1351b60af34cc932af3010814.ToStructure);
bool varLcl_IsBusy = variables.varLcl_IsBusy == null ? false : variables.varLcl_IsBusy.Value;
string varLcl_UserSelected = variables.varLcl_UserSelected == null ? "" : variables.varLcl_UserSelected;
AggregateRecord<RL_f518d708e7bb15a03a65b75b9f603096> _ScreenDataSetGetEligebleUsers = (variables.ScreenDataSetGetEligebleUsers != null) ? variables.ScreenDataSetGetEligebleUsers.FromJS((array) => {
return RL_f518d708e7bb15a03a65b75b9f603096.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_77956dae907db5f208e8a848dc366336.ToStructure);
}
) : null;
ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_ScreenModel screenModel = new ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceAssignAnalista_ScreenModel(inParaml_InvoiceApprovalLevelList, varLcl_IsBusy, varLcl_UserSelected, _ScreenDataSetGetEligebleUsers, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
