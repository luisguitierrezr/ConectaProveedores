using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_OrdersApproved_ActionScreenTableDownloadOrderScreen_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_IsCSV")]
public bool? inParami_IsCSV;
[JsonProperty("i_IsPDF")]
public bool? inParami_IsPDF;
[JsonProperty("i_IsXLS")]
public bool? inParami_IsXLS;
[JsonProperty("l_OrderScreenTableStructure")]
public RestList<ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure> inParaml_OrderScreenTableStructure;


    public static RESTConectaProveedores_e_Orders_OrdersApproved_ActionScreenTableDownloadOrderScreen_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_e_Orders_OrdersApproved_ActionScreenTableDownloadOrderScreen_Inputs result = inputParameters.ToObject<RESTConectaProveedores_e_Orders_OrdersApproved_ActionScreenTableDownloadOrderScreen_Inputs>(settings);
return result;
}


    public ConectaProveedores_e_Orders_OrdersApproved_ActionScreenTableDownloadOrderScreen_Model ToModel() {ConectaProveedores_e_Orders_OrdersApproved_ActionScreenTableDownloadOrderScreen_Model result = new ConectaProveedores_e_Orders_OrdersApproved_ActionScreenTableDownloadOrderScreen_Model();
result.inParami_IsCSV = inParami_IsCSV == null ? false : inParami_IsCSV.Value;
result.inParami_IsPDF = inParami_IsPDF == null ? false : inParami_IsPDF.Value;
result.inParami_IsXLS = inParami_IsXLS == null ? false : inParami_IsXLS.Value;
result.inParaml_OrderScreenTableStructure = RL_68002bbb4e227fd5533d460e5a56bbd4.FromRestList(inParaml_OrderScreenTableStructure, ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure.ToStructure);
return result;
}

}
