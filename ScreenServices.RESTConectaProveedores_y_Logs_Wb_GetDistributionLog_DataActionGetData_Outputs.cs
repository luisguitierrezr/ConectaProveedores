using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Logs_Wb_GetDistributionLog_DataActionGetData_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("AuditList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure> outParamAuditList;
[JsonProperty("Count")]
public long? outParamCount;


    public static RESTConectaProveedores_y_Logs_Wb_GetDistributionLog_DataActionGetData_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_d271bd6e591b75c186c4ae8d222dee55 outParamAuditList, long outParamCount) {RESTConectaProveedores_y_Logs_Wb_GetDistributionLog_DataActionGetData_Outputs result = new RESTConectaProveedores_y_Logs_Wb_GetDistributionLog_DataActionGetData_Outputs();
// Write the needed fields of the list outParamAuditList to the result.outParamAuditList
ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure tmpoutParamAuditListElement;
if(outParamAuditList.Empty) {
// Write the needed fields of the record outParamAuditList.CurrentRec to the tmpoutParamAuditListElement
tmpoutParamAuditListElement = new ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure();
// Write optimized tmpoutParamAuditListElement.AttrId
tmpoutParamAuditListElement.AttrId = (long?) 0L;
// Write optimized tmpoutParamAuditListElement.AttrOrigin
tmpoutParamAuditListElement.AttrOrigin = "";
// Write optimized tmpoutParamAuditListElement.AttrIdentifier
tmpoutParamAuditListElement.AttrIdentifier = (long?) 0L;
tmpoutParamAuditListElement.AttrMessage = outParamAuditList.CurrentRec.ssMessage;
tmpoutParamAuditListElement.AttrOriginalJSON = outParamAuditList.CurrentRec.ssOriginalJSON;
tmpoutParamAuditListElement.AttrChangeJSON = outParamAuditList.CurrentRec.ssChangeJSON;
tmpoutParamAuditListElement.AttrOccurrenceDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamAuditList.CurrentRec.ssOccurrenceDateTime, conf.DateTimeFormat);
tmpoutParamAuditListElement.AttrOccurrenceUser = outParamAuditList.CurrentRec.ssOccurrenceUser;
tmpoutParamAuditListElement.AttrIsError = (bool?) outParamAuditList.CurrentRec.ssIsError;
result.outParamAuditList = new RestList<ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure>(new ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure[] {}, tmpoutParamAuditListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure>
 tmpoutParamAuditList1List = new List<ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure>
();
try {outParamAuditList.StartIteration();
while (!(outParamAuditList.Eof)) {
// Write the needed fields of the record outParamAuditList.CurrentRec to the tmpoutParamAuditListElement
tmpoutParamAuditListElement = new ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure();
// Write optimized tmpoutParamAuditListElement.AttrId
tmpoutParamAuditListElement.AttrId = (long?) 0L;
// Write optimized tmpoutParamAuditListElement.AttrOrigin
tmpoutParamAuditListElement.AttrOrigin = "";
// Write optimized tmpoutParamAuditListElement.AttrIdentifier
tmpoutParamAuditListElement.AttrIdentifier = (long?) 0L;
tmpoutParamAuditListElement.AttrMessage = outParamAuditList.CurrentRec.ssMessage;
tmpoutParamAuditListElement.AttrOriginalJSON = outParamAuditList.CurrentRec.ssOriginalJSON;
tmpoutParamAuditListElement.AttrChangeJSON = outParamAuditList.CurrentRec.ssChangeJSON;
tmpoutParamAuditListElement.AttrOccurrenceDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamAuditList.CurrentRec.ssOccurrenceDateTime, conf.DateTimeFormat);
tmpoutParamAuditListElement.AttrOccurrenceUser = outParamAuditList.CurrentRec.ssOccurrenceUser;
tmpoutParamAuditListElement.AttrIsError = (bool?) outParamAuditList.CurrentRec.ssIsError;
tmpoutParamAuditList1List.Add(tmpoutParamAuditListElement);
outParamAuditList.Advance();
}

} finally {
outParamAuditList.EndIteration();
}

result.outParamAuditList = new RestList<ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure>(tmpoutParamAuditList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure));
}

// Write optimized result.outParamCount
result.outParamCount = (long?) 0L;
return result;
}


    public static ConectaProveedores_y_Logs_Wb_GetDistributionLog_DataActionGetData_Model ToModel(RESTConectaProveedores_y_Logs_Wb_GetDistributionLog_DataActionGetData_Outputs variables) {ConectaProveedores_y_Logs_Wb_GetDistributionLog_DataActionGetData_Model result = new ConectaProveedores_y_Logs_Wb_GetDistributionLog_DataActionGetData_Model();
result.outParamAuditList = variables == null ? new RL_d271bd6e591b75c186c4ae8d222dee55() : RL_d271bd6e591b75c186c4ae8d222dee55.FromRestList(variables.outParamAuditList, ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure.ToStructure);
result.outParamCount = variables == null || variables.outParamCount == null ? 0L : variables.outParamCount.Value;
return result;
}


    public static RESTConectaProveedores_y_Logs_Wb_GetDistributionLog_DataActionGetData_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_y_Logs_Wb_GetDistributionLog_DataActionGetData_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Logs_Wb_GetDistributionLog_DataActionGetData_Outputs result = new RESTConectaProveedores_y_Logs_Wb_GetDistributionLog_DataActionGetData_Outputs();
result.outParamAuditList = screenModel.outParamAuditList.ToRestList<ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure>(ssConectaProveedores.RestRecords.RESTST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure.FromStructureDelegate(conf));
result.outParamCount = (long?) screenModel.outParamCount;
return result;
}

}
