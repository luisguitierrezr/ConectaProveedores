using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_y_Logs_Wb_GetAuditList_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_y_Logs_Wb_GetAuditList_ScreenModel).Namespace);

    public int inParamOriginId;
public DateTime inParamPeriodInit;
public DateTime inParamPeriodEnd;
public int inParamMaxRecords;
public bool inParamShowErrors;
public int varLcStartIndex;
public bool varLcShowPopup;
public string varLcJSON_After;
public string varLcJSON_Before;
public string varLcTableSort;
public ConectaProveedores_y_Logs_Wb_GetAuditList_DataActionGetData_Model varLcGetData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_y_Logs_Wb_GetAuditList_ScreenModel() {
}



    public ConectaProveedores_y_Logs_Wb_GetAuditList_ScreenModel(int inParamOriginId, DateTime inParamPeriodInit, DateTime inParamPeriodEnd, int inParamMaxRecords, bool inParamShowErrors, int varLcStartIndex, bool varLcShowPopup, string varLcJSON_After, string varLcJSON_Before, string varLcTableSort, ConectaProveedores_y_Logs_Wb_GetAuditList_DataActionGetData_Model varLcGetData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OriginId", "PeriodInit", "PeriodEnd", "MaxRecords", "ShowErrors", "StartIndex", "ShowPopup", "JSON_After", "JSON_Before", "TableSort", "GetData", "ClientVars"}, new string[] {"inParamOriginId", "inParamPeriodInit", "inParamPeriodEnd", "inParamMaxRecords", "inParamShowErrors", "varLcStartIndex", "varLcShowPopup", "varLcJSON_After", "varLcJSON_Before", "varLcTableSort", "varLcGetData", "clientVariables"});
this.inParamOriginId = inParamOriginId;
this.inParamPeriodInit = inParamPeriodInit;
this.inParamPeriodEnd = inParamPeriodEnd;
this.inParamMaxRecords = inParamMaxRecords;
this.inParamShowErrors = inParamShowErrors;
this.varLcStartIndex = varLcStartIndex;
this.varLcShowPopup = varLcShowPopup;
this.varLcJSON_After = varLcJSON_After;
this.varLcJSON_Before = varLcJSON_Before;
this.varLcTableSort = varLcTableSort;
this.varLcGetData = varLcGetData;
this.clientVariables = clientVariables;
}



    

    public class lcvGetData : VarsBag {
public RL_d271bd6e591b75c186c4ae8d222dee55 resServiceGetAuditsByOrigin4List_outParamAuditList = new RL_d271bd6e591b75c186c4ae8d222dee55();
public long resServiceGetAuditsByOrigin4List_outParamTotalCount = 0L;

public lcvGetData() {
}
}
public class lcoGetData : VarsBag {
public RL_d271bd6e591b75c186c4ae8d222dee55 outParamAuditList = new RL_d271bd6e591b75c186c4ae8d222dee55();

public long outParamCount = 0L;

public lcoGetData() {
}
}
/// <summary>
/// Action <code>GetData</code> that represents the Service Studio action <code>GetData</code> <p>
///  Description: </p>
/// </summary>
public async Task<(RL_d271bd6e591b75c186c4ae8d222dee55,long)> DataActionGetData(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_d271bd6e591b75c186c4ae8d222dee55 outParamAuditList = default;
long outParamCount = default;
lcoGetData result = new lcoGetData();
lcvGetData localVars = new lcvGetData();
ConectaProveedores_y_Logs_Wb_GetAuditList_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetData", "ee82b006-710e-4532-b3cc-eb509b912824"))
using (activitySource.CreateScreenDataActionActivity("Wb_GetAuditList", "GetData")){
// ServiceGetAuditsByOrigin4List
(localVars.resServiceGetAuditsByOrigin4List_outParamAuditList,localVars.resServiceGetAuditsByOrigin4List_outParamTotalCount) = await ServiceAPIs.ServiceAPIServiceGetAuditsByOrigin4List(requestContext,inParamOriginId,inParamPeriodInit,inParamPeriodEnd,inParamShowErrors,varLcStartIndex,inParamMaxRecords,varLcTableSort,cancellationToken);

// AuditList = ServiceGetAuditsByOrigin4List.AuditList
result.outParamAuditList=localVars.resServiceGetAuditsByOrigin4List_outParamAuditList;

// Count = ServiceGetAuditsByOrigin4List.TotalCount
result.outParamCount=localVars.resServiceGetAuditsByOrigin4List_outParamTotalCount;
} //close CreateActionActivity using block
} // try

finally {
outParamAuditList = result.outParamAuditList;
outParamCount = result.outParamCount;
} // inner-finally
RETURN_STATEMENT:
return (outParamAuditList,outParamCount);
}


    public static class FuncDataActionGetData {
}


}
