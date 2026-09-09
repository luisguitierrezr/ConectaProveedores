namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetOrderCountDaily : VarsBag {
public string inParami_UserId;
public RL_0b9ed344d44b60e0112a22c99132ee6b queryResGetOrderCounts_outParamList = new RL_0b9ed344d44b60e0112a22c99132ee6b();
public long queryResGetOrderCounts_outParamCount = 0L;

public lcvGetOrderCountDaily(string inParami_UserId) {
this.inParami_UserId = inParami_UserId;
}
}
public class lcoGetOrderCountDaily : VarsBag {
public RL_95e11a982864fe07082eb4aea44bdce2 outParamHomepageKPI = new RL_95e11a982864fe07082eb4aea44bdce2();

public lcoGetOrderCountDaily() {
}
}
/// <summary>
/// Action <code>GetOrderCountDaily</code> that represents the Service Studio action
///  <code>GetOrderCountDaily</code> <p> Description: </p>
/// </summary>
public static async Task<RL_95e11a982864fe07082eb4aea44bdce2> ActionGetOrderCountDaily(IRequestContext requestContext,string inParami_UserId,CancellationToken cancellationToken) {
RL_95e11a982864fe07082eb4aea44bdce2 outParamHomepageKPI = default;
lcoGetOrderCountDaily result = new lcoGetOrderCountDaily();
lcvGetOrderCountDaily localVars = new lcvGetOrderCountDaily(inParami_UserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetOrderCountDaily", "18e09da0-2d63-47ca-859a-070d0cf1b24c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetOrderCountDaily", "18e09da0-2d63-47ca-859a-070d0cf1b24c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query QueryGetOrderCounts
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrderCounts_maxRecords = 0;
int QueryGetOrderCounts_startIndex = 0;(localVars.queryResGetOrderCounts_outParamList,localVars.queryResGetOrderCounts_outParamCount) = await FuncActionGetOrderCountDaily.QueryGetOrderCounts(requestContext,QueryGetOrderCounts_maxRecords,QueryGetOrderCounts_startIndex,IterationMultiplicity.Multiple,localVars.inParami_UserId,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId,(await Functions.ActionGetUserEntraRoleId(requestContext,BuiltInFunction.GetUserId (),cancellationToken)),(await Functions.ActionGetUserTelcelDirectionId(requestContext,"",cancellationToken)),(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("bxcfUQnAU0CWvUsA+ZfAjw"))).ssId,cancellationToken);

// HomepageKPI = GetOrderCounts.List
result.outParamHomepageKPI=(await RL_95e11a982864fe07082eb4aea44bdce2.ConvertAsync(localVars.queryResGetOrderCounts_outParamList, new RL_95e11a982864fe07082eb4aea44bdce2(), async (RC_073e413c5402df3d82c2d65d0628594a source, ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamHomepageKPI = result.outParamHomepageKPI;
} // inner-finally
RETURN_STATEMENT:
return outParamHomepageKPI;
}

public static class FuncActionGetOrderCountDaily {

// Query Function "GetOrderCounts" f_JsTqZzEUG9Xm7ELyLYpg of Action "GetOrderCountDaily"
public static async Task<(RL_0b9ed344d44b60e0112a22c99132ee6b,long)> QueryGetOrderCounts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusi_UserId,int qpapi_NotApprovedStatus,long qprei_RegionId,int qpapi_PendingStatus,long qpeni_UserEntraRoleId,long qptei_UserTelcelDirectionId,int qpapi_ToComplementStatus,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("GetOrderCountDaily.GetOrderCounts", "4e6cf27f-73a6-4111-bd5e-6ec42f22d8a6");
using var queryActivity = activitySource.CreateSqlQueryActivity("GetOrderCountDaily.GetOrderCounts", "4e6cf27f-73a6-4111-bd5e-6ec42f22d8a6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("OrderApprovalLevel");
string entityOrderApproval = AppUtils.Instance.RuntimeEntityReplace("OrderApproval");
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
sqlCmd.CreateParameter("@qpusi_UserId", DbType.String, qpusi_UserId);
sqlCmd.CreateParameter("@qpapi_PendingStatus", DbType.Int32, qpapi_PendingStatus);
sqlCmd.CreateParameter("@qpeni_UserEntraRoleId", DbType.Int64, qpeni_UserEntraRoleId);
sqlCmd.CreateParameter("@qprei_RegionId", DbType.Int64, qprei_RegionId);
sqlCmd.CreateParameter("@qptei_UserTelcelDirectionId", DbType.Int64, qptei_UserTelcelDirectionId);
sqlCmd.CreateParameter("@qpapi_NotApprovedStatus", DbType.Int32, qpapi_NotApprovedStatus);
sqlCmd.CreateParameter("@qpapi_ToComplementStatus", DbType.Int32, qpapi_ToComplementStatus);
string sql = "";
string advSql = "SELECT  \n    COUNT(oal.Id) AS ApprovalCount, \n    asl.Label AS ApprovalStatusLabel \nFROM \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " oal \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,"") + " oa ON oal.OrderApprovalId = oa.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " ord ON oa.OrderId = ord.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " asl ON oal.ApprovalStatusId = asl.Id \nWHERE \n    ( \n        oal.AssignedTo = @qpusi_UserId \n        AND oal.ApprovalStatusId <> @qpapi_PendingStatus \n    ) \n    OR ( \n        oal.EntraRoleId = @qpeni_UserEntraRoleId \n        AND ord.RegionId = @qprei_RegionId \n        AND ord.TelcelDirectionId = @qptei_UserTelcelDirectionId \n        AND (oal.ApprovalStatusId = @qpapi_NotApprovedStatus OR oal.ApprovalStatusId = @qpapi_ToComplementStatus) \n    ) \nGROUP BY \n    asl.Label, \n    asl.\"order\" \nORDER BY  \n    asl.\"order\" ASC;";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0b9ed344d44b60e0112a22c99132ee6b outParamList = new RL_0b9ed344d44b60e0112a22c99132ee6b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetOrderCountDaily.GetOrderCounts.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0b9ed344d44b60e0112a22c99132ee6b _tmp = new RL_0b9ed344d44b60e0112a22c99132ee6b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetOrderCountDaily.GetOrderCounts.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0b9ed344d44b60e0112a22c99132ee6b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrderCounts in GetOrderCountDaily in ConectaProveedores (SELECT       COUNT(oal.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {OrderApprovalLevel} oal  INNER JOIN {OrderApproval} oa ON oal.OrderApprovalId = oa.Id  INNER JOIN {OrderMain} ord ON oa.OrderId = ord.Id  INNER JOIN {ApprovalStatus} asl ON oal.ApprovalStatusId = asl.Id  WHERE      (          oal.AssignedTo = @i_UserId          AND oal.ApprovalStatusId <> @i_PendingStatus      )      OR (          oal.EntraRoleId = @i_UserEntraRoleId          AND ord.RegionId = @i_RegionId          AND ord.TelcelDirectionId = @i_UserTelcelDirectionId          AND (oal.ApprovalStatusId = @i_NotApprovedStatus OR oal.ApprovalStatusId = @i_ToComplementStatus)      )  GROUP BY      asl.Label,      asl.[Order]  ORDER BY       asl.[Order] ASC;): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrderCounts in GetOrderCountDaily in ConectaProveedores (SELECT       COUNT(oal.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {OrderApprovalLevel} oal  INNER JOIN {OrderApproval} oa ON oal.OrderApprovalId = oa.Id  INNER JOIN {OrderMain} ord ON oa.OrderId = ord.Id  INNER JOIN {ApprovalStatus} asl ON oal.ApprovalStatusId = asl.Id  WHERE      (          oal.AssignedTo = @i_UserId          AND oal.ApprovalStatusId <> @i_PendingStatus      )      OR (          oal.EntraRoleId = @i_UserEntraRoleId          AND ord.RegionId = @i_RegionId          AND ord.TelcelDirectionId = @i_UserTelcelDirectionId          AND (oal.ApprovalStatusId = @i_NotApprovedStatus OR oal.ApprovalStatusId = @i_ToComplementStatus)      )  GROUP BY      asl.Label,      asl.[Order]  ORDER BY       asl.[Order] ASC;): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrderCounts in GetOrderCountDaily in ConectaProveedores (SELECT       COUNT(oal.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {OrderApprovalLevel} oal  INNER JOIN {OrderApproval} oa ON oal.OrderApprovalId = oa.Id  INNER JOIN {OrderMain} ord ON oa.OrderId = ord.Id  INNER JOIN {ApprovalStatus} asl ON oal.ApprovalStatusId = asl.Id  WHERE      (          oal.AssignedTo = @i_UserId          AND oal.ApprovalStatusId <> @i_PendingStatus      )      OR (          oal.EntraRoleId = @i_UserEntraRoleId          AND ord.RegionId = @i_RegionId          AND ord.TelcelDirectionId = @i_UserTelcelDirectionId          AND (oal.ApprovalStatusId = @i_NotApprovedStatus OR oal.ApprovalStatusId = @i_ToComplementStatus)      )  GROUP BY      asl.Label,      asl.[Order]  ORDER BY       asl.[Order] ASC;): " + aqExcep.Message));
}
}
}



}


}
