namespace ssConectaProveedores;

public partial class Actions {
public class lcvCancelSAECAndNotify : VarsBag {
public long inParamOrderMainId;
public int inParamPosition;
public string inParamCancelationMotive;
public string inParamGeneralCancelationMotive;
public RL_898e2ae93bd7a88073ace16e8010d5ee queryResGetFoliosByOrderId_outParamList = new RL_898e2ae93bd7a88073ace16e8010d5ee();
public long queryResGetFoliosByOrderId_outParamCount = 0L;

public Actions.lcoFolioCancelFromAPI resFolioCancelFromAPI =  new Actions.lcoFolioCancelFromAPI();
public lcvCancelSAECAndNotify(long inParamOrderMainId, int inParamPosition, string inParamCancelationMotive, string inParamGeneralCancelationMotive) {
this.inParamOrderMainId = inParamOrderMainId;
this.inParamPosition = inParamPosition;
this.inParamCancelationMotive = inParamCancelationMotive;
this.inParamGeneralCancelationMotive = inParamGeneralCancelationMotive;
}
}
/// <summary>
/// Action <code>CancelSAECAndNotify</code> that represents the Service Studio action
///  <code>CancelSAECAndNotify</code> <p> Description: </p>
/// </summary>
public static async Task ActionCancelSAECAndNotify(IRequestContext requestContext,long inParamOrderMainId,int inParamPosition,string inParamCancelationMotive,string inParamGeneralCancelationMotive,CancellationToken cancellationToken) {
lcvCancelSAECAndNotify localVars = new lcvCancelSAECAndNotify(inParamOrderMainId, inParamPosition, inParamCancelationMotive, inParamGeneralCancelationMotive);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CancelSAECAndNotify", "0cc44db8-81e6-4cb3-8248-c3f194846fc1"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CancelSAECAndNotify", "0cc44db8-81e6-4cb3-8248-c3f194846fc1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// LogMessage
await ExtendedActions.LogMessage(requestContext,((((((("Cancel folios from OrderId: "+BuiltInFunction.LongIntegerToText(localVars.inParamOrderMainId))+" with position: ")+Convert.ToString(localVars.inParamPosition))+" because: ")+localVars.inParamGeneralCancelationMotive)+" & ")+localVars.inParamCancelationMotive),"Order Update",cancellationToken);

// Query datasetGetFoliosByOrderId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFoliosByOrderId_maxRecords = 0;
int datasetGetFoliosByOrderId_startIndex = 0;(localVars.queryResGetFoliosByOrderId_outParamList,localVars.queryResGetFoliosByOrderId_outParamCount) = await FuncActionCancelSAECAndNotify.datasetGetFoliosByOrderId(requestContext,datasetGetFoliosByOrderId_maxRecords,datasetGetFoliosByOrderId_startIndex,IterationMultiplicity.Single,localVars.inParamOrderMainId,localVars.inParamPosition,cancellationToken);

// Foreach GetFoliosByOrderId.List
localVars.queryResGetFoliosByOrderId_outParamList.StartIteration();
try {while (!((localVars.queryResGetFoliosByOrderId_outParamList.Eof))) {
// FolioCancelFromAPI
localVars.resFolioCancelFromAPI.outParamo_Output = await Actions.ActionFolioCancelFromAPI(requestContext,localVars.queryResGetFoliosByOrderId_outParamList.CurrentRec.ssId,localVars.inParamCancelationMotive,localVars.inParamGeneralCancelationMotive,cancellationToken);

localVars.queryResGetFoliosByOrderId_outParamList.Advance();
}

} finally {
localVars.queryResGetFoliosByOrderId_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionCancelSAECAndNotify {

// Query Function "GetFoliosByOrderId" DYZrWN6TVU6R0Vog+6ab_w of Action "CancelSAECAndNotify"
public static async Task<(RL_898e2ae93bd7a88073ace16e8010d5ee,long)> datasetGetFoliosByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporFolio_OrderId,int qpinOrderMainItem_Position,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CancelSAECAndNotify.GetFoliosByOrderId", "586b860d-93de-4e55-91d1-5a20fba69bff");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CancelSAECAndNotify.GetFoliosByOrderId", "586b860d-93de-4e55-91d1-5a20fba69bff", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.uE3EDOaBs0yCSMPxlIRvwQ/NodesNotShownInESpaceTree.DYZrWN6TVU6R0Vog+6ab_w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio1\".\"id\" \"id\"");
fromBuilder.Append(" FROM ((({Folio} \"enfolio1\" Inner JOIN {OrderMain} \"enordermain1\" ON (\"enfolio1\".\"orderid\" = \"enordermain1\".\"id\"))  Left JOIN {FolioSAPData} \"enfoliosapdata\" ON (\"enfolio1\".\"id\" = \"enfoliosapdata\".\"folioid\"))  Left JOIN ({FolioItems} \"enfolioitems\" Left JOIN {OrderMainItem} \"enordermainitem\" ON (\"enfolioitems\".\"ordermainitemid\" = \"enordermainitem\".\"id\"))  ON (\"enfolio1\".\"id\" = \"enfolioitems\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qporFolio_OrderId != 0) {
whereBuilder.Append("((\"enfolio1\".\"orderid\" = @qporFolio_OrderId) AND (\"enfolio1\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporFolio_OrderId", DbType.Int64, qporFolio_OrderId);
} else {
whereBuilder.Append("(\"enfolio1\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (((\"enfolio1\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId);
whereBuilder.Append(") AND (\"enfolio1\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId);
whereBuilder.Append(")) AND (\"enfolio1\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("QxrbM7PI8EeSs3w6T0KALg"))).ssId);
whereBuilder.Append(")) AND ((\"enfoliosapdata\".\"id\" IS NULL) OR ((trim(\"enfoliosapdata\".\"po_documento_material_em\")) = '')) AND ((CASE WHEN (@qpinOrderMainItem_Position <> 0) THEN (CASE WHEN (\"enordermainitem\".\"position\" = @qpinOrderMainItem_Position) THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
groupByBuilder.Append(" GROUP BY \"enfolio1\".\"id\"");
sqlCmd.CreateParameterWithoutReplacements("@qpinOrderMainItem_Position", DbType.Int32, qpinOrderMainItem_Position);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_898e2ae93bd7a88073ace16e8010d5ee outParamList = new RL_898e2ae93bd7a88073ace16e8010d5ee();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CancelSAECAndNotify.GetFoliosByOrderId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_898e2ae93bd7a88073ace16e8010d5ee _tmp = new RL_898e2ae93bd7a88073ace16e8010d5ee();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CancelSAECAndNotify.GetFoliosByOrderId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_898e2ae93bd7a88073ace16e8010d5ee)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}



}


}
