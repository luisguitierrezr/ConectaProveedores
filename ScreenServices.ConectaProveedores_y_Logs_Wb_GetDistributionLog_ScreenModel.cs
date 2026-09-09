using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_y_Logs_Wb_GetDistributionLog_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_y_Logs_Wb_GetDistributionLog_ScreenModel).Namespace);

    public int inParamOriginId;
public DateTime inParamPeriodInit;
public DateTime inParamPeriodEnd;
public int inParamMaxRecords;
public bool inParamShowErrors;
public string inParami_Refresh;
public long inParamIdentifier;
public int varLcStartIndex;
public bool varLcShowPopup;
public string varLcJSON_After;
public string varLcJSON_Before;
public string varLcTableSort;
public ConectaProveedores_y_Logs_Wb_GetDistributionLog_DataActionGetData_Model varLcGetData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_y_Logs_Wb_GetDistributionLog_ScreenModel() {
}



    public ConectaProveedores_y_Logs_Wb_GetDistributionLog_ScreenModel(int inParamOriginId, DateTime inParamPeriodInit, DateTime inParamPeriodEnd, int inParamMaxRecords, bool inParamShowErrors, string inParami_Refresh, long inParamIdentifier, int varLcStartIndex, bool varLcShowPopup, string varLcJSON_After, string varLcJSON_Before, string varLcTableSort, ConectaProveedores_y_Logs_Wb_GetDistributionLog_DataActionGetData_Model varLcGetData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OriginId", "PeriodInit", "PeriodEnd", "MaxRecords", "ShowErrors", "i_Refresh", "Identifier", "StartIndex", "ShowPopup", "JSON_After", "JSON_Before", "TableSort", "GetData", "ClientVars"}, new string[] {"inParamOriginId", "inParamPeriodInit", "inParamPeriodEnd", "inParamMaxRecords", "inParamShowErrors", "inParami_Refresh", "inParamIdentifier", "varLcStartIndex", "varLcShowPopup", "varLcJSON_After", "varLcJSON_Before", "varLcTableSort", "varLcGetData", "clientVariables"});
this.inParamOriginId = inParamOriginId;
this.inParamPeriodInit = inParamPeriodInit;
this.inParamPeriodEnd = inParamPeriodEnd;
this.inParamMaxRecords = inParamMaxRecords;
this.inParamShowErrors = inParamShowErrors;
this.inParami_Refresh = inParami_Refresh;
this.inParamIdentifier = inParamIdentifier;
this.varLcStartIndex = varLcStartIndex;
this.varLcShowPopup = varLcShowPopup;
this.varLcJSON_After = varLcJSON_After;
this.varLcJSON_Before = varLcJSON_Before;
this.varLcTableSort = varLcTableSort;
this.varLcGetData = varLcGetData;
this.clientVariables = clientVariables;
}



    

    public class lcvGetData : VarsBag {
public RL_d271bd6e591b75c186c4ae8d222dee55 resServiceGetAuditsByIdentifier4List_outParamAuditList = new RL_d271bd6e591b75c186c4ae8d222dee55();
public long resServiceGetAuditsByIdentifier4List_outParamTotalCount = 0L;

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
ConectaProveedores_y_Logs_Wb_GetDistributionLog_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetData", "328a8c23-9365-4740-b3ed-0917066e6b1f"))
using (activitySource.CreateScreenDataActionActivity("Wb_GetDistributionLog", "GetData")){
if(((inParamIdentifier==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// ServiceGetAuditsByOrigin4List
(localVars.resServiceGetAuditsByOrigin4List_outParamAuditList,localVars.resServiceGetAuditsByOrigin4List_outParamTotalCount) = await ServiceAPIs.ServiceAPIServiceGetAuditsByOrigin4List(requestContext,inParamOriginId,inParamPeriodInit,inParamPeriodEnd,inParamShowErrors,varLcStartIndex,inParamMaxRecords,varLcTableSort,cancellationToken);

// AuditList = ServiceGetAuditsByOrigin4List.AuditList
result.outParamAuditList=localVars.resServiceGetAuditsByOrigin4List_outParamAuditList;

// Count = ServiceGetAuditsByOrigin4List.TotalCount
result.outParamCount=localVars.resServiceGetAuditsByOrigin4List_outParamTotalCount;
} else {
// ServiceGetAuditsByIdentifier4List
(localVars.resServiceGetAuditsByIdentifier4List_outParamAuditList,localVars.resServiceGetAuditsByIdentifier4List_outParamTotalCount) = await ServiceAPIs.ServiceAPIServiceGetAuditsByIdentifier4List(requestContext,inParamOriginId,inParamIdentifier,inParamShowErrors,varLcStartIndex,inParamMaxRecords,varLcTableSort,cancellationToken);

// AuditList = ServiceGetAuditsByIdentifier4List.AuditList
result.outParamAuditList=localVars.resServiceGetAuditsByIdentifier4List_outParamAuditList;

// Count = ServiceGetAuditsByIdentifier4List.TotalCount
result.outParamCount=localVars.resServiceGetAuditsByIdentifier4List_outParamTotalCount;
}

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
