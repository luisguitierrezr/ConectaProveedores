using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;
using ssConectaProveedores.RestRecords;

namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIServiceOrder_GetDataInput {
[JsonProperty("OrderNumber")]
public string inParamOrderNumber;
public S4PIServiceOrder_GetDataInput(string inParamOrderNumber) {
this.inParamOrderNumber = inParamOrderNumber;
}

}

public class S4PIServiceOrder_GetDataOutput {
[JsonProperty("Response")]
public JSONST_77e33f0a47d2ef32eb85177e44c9b70fStructure outParamResponse;
public S4PIServiceOrder_GetDataOutput(JSONST_77e33f0a47d2ef32eb85177e44c9b70fStructure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

[HttpPost()]
[Route("serviceapi/serviceorder_getdata")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceOrder_GetData", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceOrder_GetData(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceOrder_GetDataInput, S4PIServiceOrder_GetDataOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
ST_77e33f0a47d2ef32eb85177e44c9b70fStructure outParamResponse;
S4PIServiceOrder_GetDataInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamOrderNumber == null)) {
validationErrors["OrderNumber"]=new string[] {"The OrderNumber mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamResponse = await Flows.ActionServiceOrder_GetData(context,inputs.inParamOrderNumber,ctx);

return new S4PIServiceOrder_GetDataOutput(JSONST_77e33f0a47d2ef32eb85177e44c9b70fStructure.FromStructure(outParamResponse, behaviorsConfiguration));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceOrder_GetData : VarsBag {
public string inParamOrderNumber;
public RL_45a2a678e0c897a57aacb30f6fec9213 queryResGetOrders_outParamList = new RL_45a2a678e0c897a57aacb30f6fec9213();
public long queryResGetOrders_outParamCount = 0L;

public lcvServiceOrder_GetData(string inParamOrderNumber) {
this.inParamOrderNumber = inParamOrderNumber;
}
}
public class lcoServiceOrder_GetData : VarsBag {
public ST_77e33f0a47d2ef32eb85177e44c9b70fStructure outParamResponse = new ST_77e33f0a47d2ef32eb85177e44c9b70fStructure();

public lcoServiceOrder_GetData() {
}
}
/// <summary>
/// Action <code>ServiceOrder_GetData</code> that represents the Service Studio action
///  <code>ServiceOrder_GetData</code> <p> Description: GetOrderRequest</p>
/// </summary>
public static async Task<ST_77e33f0a47d2ef32eb85177e44c9b70fStructure> ActionServiceOrder_GetData(IRequestContext requestContext,string inParamOrderNumber,CancellationToken cancellationToken) {
ST_77e33f0a47d2ef32eb85177e44c9b70fStructure outParamResponse = default;
lcoServiceOrder_GetData result = new lcoServiceOrder_GetData();
lcvServiceOrder_GetData localVars = new lcvServiceOrder_GetData(inParamOrderNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceOrder_GetData", "c49688ff-010e-40a0-aa2d-d84c84921b66"))
using (activitySource.CreateServiceActionActivity("ServiceOrder_GetData")){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query QueryGetOrders
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrders_maxRecords = 1;
if (QueryGetOrders_maxRecords < 1) QueryGetOrders_maxRecords = 1;
int QueryGetOrders_startIndex = 0;(localVars.queryResGetOrders_outParamList,localVars.queryResGetOrders_outParamCount) = await FuncActionServiceOrder_GetData.QueryGetOrders(requestContext,QueryGetOrders_maxRecords,QueryGetOrders_startIndex,IterationMultiplicity.Never,localVars.inParamOrderNumber,BuiltInFunction.NullDate (),cancellationToken);

// empty?
if((localVars.queryResGetOrders_outParamList.Empty)) {
// Response = GetOrders.List.Current
result.outParamResponse=(await RecordUtils.ConvertAsync(localVars.queryResGetOrders_outParamList.CurrentRec, new ST_77e33f0a47d2ef32eb85177e44c9b70fStructure(), async (RC_35113aa55a750ad2c238c201c4253736 source, ST_77e33f0a47d2ef32eb85177e44c9b70fStructure target, CancellationToken cancellationToken) => {
target.ssSuccess = true;
target.ssMessage = (((((AppUtils.GetStringResource("QnaFlWQrjk6UteFDKyBzGw.#SourceValue#Value.76453678.1", "Order")+" ")+localVars.inParamOrderNumber)+" ")+AppUtils.GetStringResource("QnaFlWQrjk6UteFDKyBzGw.#SourceValue#Value.-585904394.1", "not available in Conecta portal"))+".");
return target;
}, cancellationToken));
} else {
// GetOrders.List.Current.Order.FirstLevelUserName = If
localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssFirstLevelUserName = (((localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssFirstLevelUserName!="")) ? (localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssFirstLevelUserName) : ("-"));

// GetOrders.List.Current.Order.FirstLevelJobTitle = If
localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssFirstLevelJobTitle = (((localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssFirstLevelJobTitle!="")) ? (localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssFirstLevelJobTitle) : ("-"));

// GetOrders.List.Current.Order.FirstEntraRoleName = If
localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssFirstEntraRoleName = (((localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssFirstEntraRoleName!="")) ? (localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssFirstEntraRoleName) : ("-"));

// GetOrders.List.Current.Order.CurrLevelUserName = If
localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssCurrLevelUserName = (((localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssCurrLevelUserName!="")) ? (localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssCurrLevelUserName) : ("-"));

// GetOrders.List.Current.Order.CurrLevelJobTitle = If
localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssCurrLevelJobTitle = (((localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssCurrLevelJobTitle!="")) ? (localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssCurrLevelJobTitle) : ("-"));

// GetOrders.List.Current.Order.CurrEntraRoleName = If
localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssCurrEntraRoleName = (((localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssCurrEntraRoleName!="")) ? (localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrder.ssCurrEntraRoleName) : ("-"));
// Response = GetOrders.List.Current
result.outParamResponse=(await RecordUtils.ConvertAsync(localVars.queryResGetOrders_outParamList.CurrentRec, new ST_77e33f0a47d2ef32eb85177e44c9b70fStructure(), async (RC_35113aa55a750ad2c238c201c4253736 source, ST_77e33f0a47d2ef32eb85177e44c9b70fStructure target, CancellationToken cancellationToken) => {
target.ssSuccess = true;
target.ssMessage = (((((AppUtils.GetStringResource("YOsvN4Sz+EOoIhQZjvZ8+Q.#SourceValue#Value.76453678.1", "Order")+" ")+localVars.inParamOrderNumber)+" ")+AppUtils.GetStringResource("YOsvN4Sz+EOoIhQZjvZ8+Q.#SourceValue#Value.-120160301.1", "info retrieved with success"))+".");
target.ssOrderInfo_API = source.ssSTOrder;
return target;
}, cancellationToken));
}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// Response.Success = False
result.outParamResponse.ssSuccess = false;

// Response.Message = "CONECTA API ERROR - Please try again later."
result.outParamResponse.ssMessage = "CONECTA API ERROR - Please try again later.";
goto RETURN_STATEMENT;

} // Catch
finally {
outParamResponse = result.outParamResponse;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamResponse;
}

        public static class FuncActionServiceOrder_GetData {
            
// Query Function "GetOrders" IaNKJb8QIkyjVJ9Cm1TJCg of Action "ServiceOrder_GetData"
public static async Task<(RL_45a2a678e0c897a57aacb30f6fec9213,long)> QueryGetOrders(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrders_Number,DateTime qpdaNullDate,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("ServiceOrder_GetData.GetOrders", "254aa321-10bf-4c22-a354-9f429b54c90a");
using var queryActivity = activitySource.CreateSqlQueryActivity("ServiceOrder_GetData.GetOrders", "254aa321-10bf-4c22-a354-9f429b54c90a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityOrderStatus = AppUtils.Instance.RuntimeEntityReplace("OrderStatus");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityOrderApproval = AppUtils.Instance.RuntimeEntityReplace("OrderApproval");
string entityOrderApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("OrderApprovalLevel");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityUser_Extended_Internal = AppUtils.Instance.RuntimeEntityReplace("User_Extended_Internal");
string entityEntraRole = AppUtils.Instance.RuntimeEntityReplace("EntraRole");
sqlCmd.CreateParameter("@qpdaNullDate", DbType.DateTime, qpdaNullDate);
sqlCmd.CreateParameter("@qpteOrders_Number", DbType.String, qpteOrders_Number);
string sql = "";
string advSql = "SELECT \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + "  AS OrderNumber, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + "    AS OrderDate, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"label\"") + "      AS OrderStatus, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + "            AS Region,  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"name\"") + "          AS SupplierName, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + "        AS SupplierNumber, \n    User_First.\"name\"          AS FirstLevelUserName, \n    User_First.\"email\"         AS FirstLevelEmail, \n    UserExt_First.\"jobtitle\"   AS FirstLevelJobTitle, \n    EntraRole_First.\"rolename\" AS FirstEntraRoleName,  \n    User_Curr.\"name\"           AS CurrLevelUserName, \n    User_Curr.\"email\"          AS CurrLevelEmail, \n    UserExt_Curr.\"jobtitle\"    AS CurrLevelJobTitle, \n    EntraRole_Curr.\"rolename\"  AS CurrEntraRoleName,  \n    CASE \n    WHEN OrderApprovalLevel_Curr.\"assignedon\" = @qpdaNullDate \n        THEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"updatedon\"") + " \n    ELSE OrderApprovalLevel_Curr.\"assignedon\" \n    END AS AssignedOn \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,"") + " \n \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"orderid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"regionid\"") + " \n \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " OrderApprovalLevel_Curr ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"id\"") + " = OrderApprovalLevel_Curr.\"orderapprovalid\" AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"currentlevel\"") + " = OrderApprovalLevel_Curr.\"levelnumber\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Curr ON OrderApprovalLevel_Curr.\"assignedto\" = User_Curr.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " UserExt_Curr ON User_Curr.\"id\" = UserExt_Curr.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,"") + " EntraRole_Curr ON OrderApprovalLevel_Curr.\"entraroleid\" = EntraRole_Curr.\"id\" \n \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " OrderApprovalLevel_First ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"id\"") + " = OrderApprovalLevel_First.\"orderapprovalid\" AND OrderApprovalLevel_First.\"levelnumber\" = 1 \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_First ON OrderApprovalLevel_First.\"assignedto\" = User_First.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " UserExt_First ON User_First.\"id\" = UserExt_First.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,"") + " EntraRole_First ON OrderApprovalLevel_First.\"entraroleid\" = EntraRole_First.\"id\" \n \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + " = @qpteOrders_Number";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_45a2a678e0c897a57aacb30f6fec9213 outParamList = new RL_45a2a678e0c897a57aacb30f6fec9213();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceOrder_GetData.GetOrders.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_45a2a678e0c897a57aacb30f6fec9213 _tmp = new RL_45a2a678e0c897a57aacb30f6fec9213();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceOrder_GetData.GetOrders.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_45a2a678e0c897a57aacb30f6fec9213)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrders in ServiceOrder_GetData in ConectaProveedores (SELECT      {OrderMain}.[OrderNumber]  AS OrderNumber,      {OrderMain}.[OrderDate]    AS OrderDate,      {OrderStatus}.[Label]      AS OrderStatus,      {Region}.[Code]            AS Region,       {Supplier}.[Name]          AS SupplierName,      {Supplier}.[Number]        AS SupplierNumber,      User_First.[Name]          AS FirstLevelUserName,      User_First.[Email]         AS FirstLevelEmail,      UserExt_First.[JobTitle]   AS FirstLevelJobTitle,      EntraRole_First.[RoleName] AS FirstEntraRoleName,       User_Curr.[Name]           AS CurrLevelUserName,      User_Curr.[Email]          AS CurrLevelEmail,      UserExt_Curr.[JobTitle]    AS CurrLevelJobTitle,      EntraRole_Curr.[RoleName]  AS CurrEntraRoleName,       CASE      WHEN OrderApprovalLevel_Curr.[AssignedOn] = @NullDate          THEN {OrderMain}.[UpdatedOn]      ELSE OrderApprovalLevel_Curr.[AssignedOn]      END AS AssignedOn  FROM {OrderApproval}    INNER JOIN {OrderMain} ON {OrderApproval}.[OrderId] = {OrderMain}.[Id]  L ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrders in ServiceOrder_GetData in ConectaProveedores (SELECT      {OrderMain}.[OrderNumber]  AS OrderNumber,      {OrderMain}.[OrderDate]    AS OrderDate,      {OrderStatus}.[Label]      AS OrderStatus,      {Region}.[Code]            AS Region,       {Supplier}.[Name]          AS SupplierName,      {Supplier}.[Number]        AS SupplierNumber,      User_First.[Name]          AS FirstLevelUserName,      User_First.[Email]         AS FirstLevelEmail,      UserExt_First.[JobTitle]   AS FirstLevelJobTitle,      EntraRole_First.[RoleName] AS FirstEntraRoleName,       User_Curr.[Name]           AS CurrLevelUserName,      User_Curr.[Email]          AS CurrLevelEmail,      UserExt_Curr.[JobTitle]    AS CurrLevelJobTitle,      EntraRole_Curr.[RoleName]  AS CurrEntraRoleName,       CASE      WHEN OrderApprovalLevel_Curr.[AssignedOn] = @NullDate          THEN {OrderMain}.[UpdatedOn]      ELSE OrderApprovalLevel_Curr.[AssignedOn]      END AS AssignedOn  FROM {OrderApproval}    INNER JOIN {OrderMain} ON {OrderApproval}.[OrderId] = {OrderMain}.[Id]  L ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrders in ServiceOrder_GetData in ConectaProveedores (SELECT      {OrderMain}.[OrderNumber]  AS OrderNumber,      {OrderMain}.[OrderDate]    AS OrderDate,      {OrderStatus}.[Label]      AS OrderStatus,      {Region}.[Code]            AS Region,       {Supplier}.[Name]          AS SupplierName,      {Supplier}.[Number]        AS SupplierNumber,      User_First.[Name]          AS FirstLevelUserName,      User_First.[Email]         AS FirstLevelEmail,      UserExt_First.[JobTitle]   AS FirstLevelJobTitle,      EntraRole_First.[RoleName] AS FirstEntraRoleName,       User_Curr.[Name]           AS CurrLevelUserName,      User_Curr.[Email]          AS CurrLevelEmail,      UserExt_Curr.[JobTitle]    AS CurrLevelJobTitle,      EntraRole_Curr.[RoleName]  AS CurrEntraRoleName,       CASE      WHEN OrderApprovalLevel_Curr.[AssignedOn] = @NullDate          THEN {OrderMain}.[UpdatedOn]      ELSE OrderApprovalLevel_Curr.[AssignedOn]      END AS AssignedOn  FROM {OrderApproval}    INNER JOIN {OrderMain} ON {OrderApproval}.[OrderId] = {OrderMain}.[Id]  L ...): " + aqExcep.Message));
}
}
}

        }
    }
}
