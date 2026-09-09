namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetFolioCountDaily : VarsBag {
public string inParami_UserId;
public RL_0b9ed344d44b60e0112a22c99132ee6b queryResGetFoliosCounts_outParamList = new RL_0b9ed344d44b60e0112a22c99132ee6b();
public long queryResGetFoliosCounts_outParamCount = 0L;

public lcvGetFolioCountDaily(string inParami_UserId) {
this.inParami_UserId = inParami_UserId;
}
}
public class lcoGetFolioCountDaily : VarsBag {
public RL_95e11a982864fe07082eb4aea44bdce2 outParamHomepageKPI = new RL_95e11a982864fe07082eb4aea44bdce2();

public lcoGetFolioCountDaily() {
}
}
/// <summary>
/// Action <code>GetFolioCountDaily</code> that represents the Service Studio action
///  <code>GetFolioCountDaily</code> <p> Description: </p>
/// </summary>
public static async Task<RL_95e11a982864fe07082eb4aea44bdce2> ActionGetFolioCountDaily(IRequestContext requestContext,string inParami_UserId,CancellationToken cancellationToken) {
RL_95e11a982864fe07082eb4aea44bdce2 outParamHomepageKPI = default;
lcoGetFolioCountDaily result = new lcoGetFolioCountDaily();
lcvGetFolioCountDaily localVars = new lcvGetFolioCountDaily(inParami_UserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetFolioCountDaily", "746220d7-1df4-4372-92b4-189faf4c6f4d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetFolioCountDaily", "746220d7-1df4-4372-92b4-189faf4c6f4d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query QueryGetFoliosCounts
cancellationToken.ThrowIfCancellationRequested();
int QueryGetFoliosCounts_maxRecords = 0;
int QueryGetFoliosCounts_startIndex = 0;(localVars.queryResGetFoliosCounts_outParamList,localVars.queryResGetFoliosCounts_outParamCount) = await FuncActionGetFolioCountDaily.QueryGetFoliosCounts(requestContext,QueryGetFoliosCounts_maxRecords,QueryGetFoliosCounts_startIndex,IterationMultiplicity.Multiple,localVars.inParami_UserId,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId,(await Functions.ActionGetUserEntraRoleId(requestContext,BuiltInFunction.GetUserId (),cancellationToken)),(await Functions.ActionGetUserTelcelDirectionId(requestContext,"",cancellationToken)),cancellationToken);

// HomepageKPI = GetFoliosCounts.List
result.outParamHomepageKPI=(await RL_95e11a982864fe07082eb4aea44bdce2.ConvertAsync(localVars.queryResGetFoliosCounts_outParamList, new RL_95e11a982864fe07082eb4aea44bdce2(), async (RC_073e413c5402df3d82c2d65d0628594a source, ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure target, CancellationToken cancellationToken) => {
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

public static class FuncActionGetFolioCountDaily {

// Query Function "GetFoliosCounts" TOC1dPmvxEi1Tu1JDFDqOg of Action "GetFolioCountDaily"
public static async Task<(RL_0b9ed344d44b60e0112a22c99132ee6b,long)> QueryGetFoliosCounts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusi_UserId,int qpapi_NotApprovedStatus,long qprei_RegionId,int qpapi_PendingStatus,long qpeni_UserEntraRoleId,long qptei_UserTelcelDirectionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("GetFolioCountDaily.GetFoliosCounts", "74b5e04c-aff9-48c4-b54e-ed490c50ea3a");
using var queryActivity = activitySource.CreateSqlQueryActivity("GetFolioCountDaily.GetFoliosCounts", "74b5e04c-aff9-48c4-b54e-ed490c50ea3a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityFolioApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("FolioApprovalLevel");
string entityFolioApproval = AppUtils.Instance.RuntimeEntityReplace("FolioApproval");
string entityFolio = AppUtils.Instance.RuntimeEntityReplace("Folio");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
sqlCmd.CreateParameter("@qpusi_UserId", DbType.String, qpusi_UserId);
sqlCmd.CreateParameter("@qpapi_PendingStatus", DbType.Int32, qpapi_PendingStatus);
sqlCmd.CreateParameter("@qpeni_UserEntraRoleId", DbType.Int64, qpeni_UserEntraRoleId);
sqlCmd.CreateParameter("@qprei_RegionId", DbType.Int64, qprei_RegionId);
sqlCmd.CreateParameter("@qptei_UserTelcelDirectionId", DbType.Int64, qptei_UserTelcelDirectionId);
sqlCmd.CreateParameter("@qpapi_NotApprovedStatus", DbType.Int32, qpapi_NotApprovedStatus);
string sql = "";
string advSql = "SELECT  \n    COUNT(fal.Id) AS ApprovalCount, \n    asl.Label AS ApprovalStatusLabel \nFROM \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,"") + " fal \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApproval,"") + " fa ON fal.FolioApprovalId = fa.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " fol ON fa.FolioId = fol.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " asl ON fal.ApprovalStatusId = asl.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " ord ON ord.Id = fol.OrderId \nWHERE \n    ( \n        fal.AssignedTo = @qpusi_UserId \n        AND fal.ApprovalStatusId <> @qpapi_PendingStatus \n    ) \n    OR ( \n        fal.EntraRoleId = @qpeni_UserEntraRoleId \n        AND ord.RegionId = @qprei_RegionId \n        AND ord.TelcelDirectionId = @qptei_UserTelcelDirectionId \n        AND (fal.ApprovalStatusId = @qpapi_NotApprovedStatus) \n    ) \nGROUP BY \n    asl.Label, \n    asl.\"order\" \nORDER BY  \n    asl.\"order\" ASC;";
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetFolioCountDaily.GetFoliosCounts.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetFolioCountDaily.GetFoliosCounts.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0b9ed344d44b60e0112a22c99132ee6b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetFoliosCounts in GetFolioCountDaily in ConectaProveedores (SELECT       COUNT(fal.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {FolioApprovalLevel} fal  INNER JOIN {FolioApproval} fa ON fal.FolioApprovalId = fa.Id  INNER JOIN {Folio} fol ON fa.FolioId = fol.Id  INNER JOIN {ApprovalStatus} asl ON fal.ApprovalStatusId = asl.Id  INNER JOIN {OrderMain} ord ON ord.Id = fol.OrderId  WHERE      (          fal.AssignedTo = @i_UserId          AND fal.ApprovalStatusId <> @i_PendingStatus      )      OR (          fal.EntraRoleId = @i_UserEntraRoleId          AND ord.RegionId = @i_RegionId          AND ord.TelcelDirectionId = @i_UserTelcelDirectionId          AND (fal.ApprovalStatusId = @i_NotApprovedStatus)      )  GROUP BY      asl.Label,      asl.[Order]  ORDER BY       asl.[Order] ASC;): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetFoliosCounts in GetFolioCountDaily in ConectaProveedores (SELECT       COUNT(fal.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {FolioApprovalLevel} fal  INNER JOIN {FolioApproval} fa ON fal.FolioApprovalId = fa.Id  INNER JOIN {Folio} fol ON fa.FolioId = fol.Id  INNER JOIN {ApprovalStatus} asl ON fal.ApprovalStatusId = asl.Id  INNER JOIN {OrderMain} ord ON ord.Id = fol.OrderId  WHERE      (          fal.AssignedTo = @i_UserId          AND fal.ApprovalStatusId <> @i_PendingStatus      )      OR (          fal.EntraRoleId = @i_UserEntraRoleId          AND ord.RegionId = @i_RegionId          AND ord.TelcelDirectionId = @i_UserTelcelDirectionId          AND (fal.ApprovalStatusId = @i_NotApprovedStatus)      )  GROUP BY      asl.Label,      asl.[Order]  ORDER BY       asl.[Order] ASC;): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetFoliosCounts in GetFolioCountDaily in ConectaProveedores (SELECT       COUNT(fal.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {FolioApprovalLevel} fal  INNER JOIN {FolioApproval} fa ON fal.FolioApprovalId = fa.Id  INNER JOIN {Folio} fol ON fa.FolioId = fol.Id  INNER JOIN {ApprovalStatus} asl ON fal.ApprovalStatusId = asl.Id  INNER JOIN {OrderMain} ord ON ord.Id = fol.OrderId  WHERE      (          fal.AssignedTo = @i_UserId          AND fal.ApprovalStatusId <> @i_PendingStatus      )      OR (          fal.EntraRoleId = @i_UserEntraRoleId          AND ord.RegionId = @i_RegionId          AND ord.TelcelDirectionId = @i_UserTelcelDirectionId          AND (fal.ApprovalStatusId = @i_NotApprovedStatus)      )  GROUP BY      asl.Label,      asl.[Order]  ORDER BY       asl.[Order] ASC;): " + aqExcep.Message));
}
}
}



}


}
