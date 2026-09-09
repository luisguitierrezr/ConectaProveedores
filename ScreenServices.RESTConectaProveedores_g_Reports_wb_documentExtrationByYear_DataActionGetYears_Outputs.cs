using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_wb_documentExtrationByYear_DataActionGetYears_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<int> outParamList;


    public static RESTConectaProveedores_g_Reports_wb_documentExtrationByYear_DataActionGetYears_Outputs FromOutputs(IBehaviorsConfiguration conf, BasicTypeList<int> outParamList) {RESTConectaProveedores_g_Reports_wb_documentExtrationByYear_DataActionGetYears_Outputs result = new RESTConectaProveedores_g_Reports_wb_documentExtrationByYear_DataActionGetYears_Outputs();
result.outParamList = outParamList.ToRestList();
return result;
}


    public static ConectaProveedores_g_Reports_wb_documentExtrationByYear_DataActionGetYears_Model ToModel(RESTConectaProveedores_g_Reports_wb_documentExtrationByYear_DataActionGetYears_Outputs variables) {ConectaProveedores_g_Reports_wb_documentExtrationByYear_DataActionGetYears_Model result = new ConectaProveedores_g_Reports_wb_documentExtrationByYear_DataActionGetYears_Model();
result.outParamList = variables == null ? new BasicTypeList<int>() : BasicTypeList<int>.FromRestList(variables.outParamList);
return result;
}


    public static RESTConectaProveedores_g_Reports_wb_documentExtrationByYear_DataActionGetYears_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_g_Reports_wb_documentExtrationByYear_DataActionGetYears_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_g_Reports_wb_documentExtrationByYear_DataActionGetYears_Outputs result = new RESTConectaProveedores_g_Reports_wb_documentExtrationByYear_DataActionGetYears_Outputs();
result.outParamList = screenModel.outParamList.ToRestList();
return result;
}

}
