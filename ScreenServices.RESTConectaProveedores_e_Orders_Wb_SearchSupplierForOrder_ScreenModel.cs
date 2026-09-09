using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetSupplierById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e> ScreenDataSetGetSupplierById;
[JsonProperty("GetOrderById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_b944c231fcedefdc49a0fe2c36d0fb8a> ScreenDataSetGetOrderById;
[JsonProperty("GetSuppliers")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e> ScreenDataSetGetSuppliers;
[JsonProperty("SupplierId")]
public long? inParamSupplierId;
[JsonProperty("IsEnabled")]
public bool? inParamIsEnabled;
[JsonProperty("OrderMainId")]
public long? inParamOrderMainId;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel ToModel() {long inParamSupplierId = variables.inParamSupplierId == null ? 0L : variables.inParamSupplierId.Value;
bool inParamIsEnabled = variables.inParamIsEnabled == null ? false : variables.inParamIsEnabled.Value;
long inParamOrderMainId = variables.inParamOrderMainId == null ? 0L : variables.inParamOrderMainId.Value;
AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> _ScreenDataSetGetSupplierById = (variables.ScreenDataSetGetSupplierById != null) ? variables.ScreenDataSetGetSupplierById.FromJS((array) => {
return RL_f647e8c4990b814587d1a017e4c9dd44.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e.ToStructure);
}
) : null;
AggregateRecord<RL_03c4be65764ae68c963db8500f2f1711> _ScreenDataSetGetOrderById = (variables.ScreenDataSetGetOrderById != null) ? variables.ScreenDataSetGetOrderById.FromJS((array) => {
return RL_03c4be65764ae68c963db8500f2f1711.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_b944c231fcedefdc49a0fe2c36d0fb8a.ToStructure);
}
) : null;
AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> _ScreenDataSetGetSuppliers = (variables.ScreenDataSetGetSuppliers != null) ? variables.ScreenDataSetGetSuppliers.FromJS((array) => {
return RL_f647e8c4990b814587d1a017e4c9dd44.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel screenModel = new ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_ScreenModel(inParamSupplierId, inParamIsEnabled, inParamOrderMainId, _ScreenDataSetGetSupplierById, _ScreenDataSetGetOrderById, _ScreenDataSetGetSuppliers, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
