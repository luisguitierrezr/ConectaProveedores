namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderApproval_Restart : VarsBag {
public long inParamOrderMainId;
public Actions.lcoOrderApprovalLevelCreateOrUpdate resOrderApprovalLevelCreateOrUpdate =  new Actions.lcoOrderApprovalLevelCreateOrUpdate();
public string resJSONSerialize1_outParamJSON = "";
public RL_3c2483fef931c35c62e6128a52ac9903 queryResGetOrderApprovalDistribution_outParamList = new RL_3c2483fef931c35c62e6128a52ac9903();
public long queryResGetOrderApprovalDistribution_outParamCount = 0L;

public string resJSONSerialize2_outParamJSON = "";
public int resListIndexOf_outParamPosition = 0;

public lcvOrderApproval_Restart(long inParamOrderMainId) {
this.inParamOrderMainId = inParamOrderMainId;
}
}
public class lcoOrderApproval_Restart : VarsBag {
public bool outParamo_NoApprovalFound = false;

public lcoOrderApproval_Restart() {
}
}
/// <summary>
/// Action <code>OrderApproval_Restart</code> that represents the Service Studio action
///  <code>OrderApproval_Restart</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionOrderApproval_Restart(IRequestContext requestContext,long inParamOrderMainId,CancellationToken cancellationToken) {
bool outParamo_NoApprovalFound = default;
lcoOrderApproval_Restart result = new lcoOrderApproval_Restart();
lcvOrderApproval_Restart localVars = new lcvOrderApproval_Restart(inParamOrderMainId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderApproval_Restart", "12510798-0fcb-4692-b4b9-43cbc32e2f83"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderApproval_Restart", "12510798-0fcb-4692-b4b9-43cbc32e2f83", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderApprovalDistribution
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderApprovalDistribution_maxRecords = 4;
if (datasetGetOrderApprovalDistribution_maxRecords < 1) datasetGetOrderApprovalDistribution_maxRecords = 1;
int datasetGetOrderApprovalDistribution_startIndex = 0;(localVars.queryResGetOrderApprovalDistribution_outParamList,localVars.queryResGetOrderApprovalDistribution_outParamCount) = await FuncActionOrderApproval_Restart.datasetGetOrderApprovalDistribution(requestContext,datasetGetOrderApprovalDistribution_maxRecords,datasetGetOrderApprovalDistribution_startIndex,IterationMultiplicity.Multiple,localVars.inParamOrderMainId,cancellationToken);

if((localVars.queryResGetOrderApprovalDistribution_outParamList.Empty)) {
// o_NoApprovalFound = True
result.outParamo_NoApprovalFound=true;
} else {
// JSON Serialize JsonSerializeOrderApproval_RestartJSONSerialize1
FuncActionOrderApproval_Restart.JsonSerializeOrderApproval_RestartJSONSerialize1(localVars.queryResGetOrderApprovalDistribution_outParamList[0].ssENOrderApproval, out localVars.resJSONSerialize1_outParamJSON);
// ControledLogMessage
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),("ChangeOrderApprovalPosition » Order Approval will be changed "+localVars.resJSONSerialize1_outParamJSON),"ChangeOrderApprovalPosition",cancellationToken);

// GoBackToComplement
await Actions.ActionGoBackToComplement(requestContext,localVars.inParamOrderMainId,cancellationToken);

// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetOrderApprovalDistribution_outParamList,async (p, cancellationToken) => p.ssENOrderApprovalLevel.ssIsComplement,cancellationToken);

// Not found?
if(((localVars.resListIndexOf_outParamPosition==(-1)))) {
// o_NoApprovalFound = True
result.outParamo_NoApprovalFound=true;
} else {
// Foreach GetOrderApprovalDistribution.List
localVars.queryResGetOrderApprovalDistribution_outParamList.StartIteration();
try {localVars.queryResGetOrderApprovalDistribution_outParamList.Advance((localVars.resListIndexOf_outParamPosition+1));
while (!((localVars.queryResGetOrderApprovalDistribution_outParamList.Eof))) {
// GetOrderApprovalDistribution.List.Current.OrderApprovalLevel.AssignedOn = NullDate
localVars.queryResGetOrderApprovalDistribution_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedOn = BuiltInFunction.NullDate ();

// GetOrderApprovalDistribution.List.Current.OrderApprovalLevel.ApprovalStatusId = Pending
localVars.queryResGetOrderApprovalDistribution_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId;

// GetOrderApprovalDistribution.List.Current.OrderApprovalLevel.WasCanceledBy = NullTextIdentifier
localVars.queryResGetOrderApprovalDistribution_outParamList.CurrentRec.ssENOrderApprovalLevel.ssWasCanceledBy = BuiltInFunction.NullTextIdentifier ();

// GetOrderApprovalDistribution.List.Current.OrderApprovalLevel.ToModifyOn = NullDate
localVars.queryResGetOrderApprovalDistribution_outParamList.CurrentRec.ssENOrderApprovalLevel.ssToModifyOn = BuiltInFunction.NullDate ();

// GetOrderApprovalDistribution.List.Current.OrderApprovalLevel.ToModifyBy = NullTextIdentifier
localVars.queryResGetOrderApprovalDistribution_outParamList.CurrentRec.ssENOrderApprovalLevel.ssToModifyBy = BuiltInFunction.NullTextIdentifier ();

// GetOrderApprovalDistribution.List.Current.OrderApprovalLevel.IsSubstituteFor = NullTextIdentifier
localVars.queryResGetOrderApprovalDistribution_outParamList.CurrentRec.ssENOrderApprovalLevel.ssIsSubstituteFor = BuiltInFunction.NullTextIdentifier ();

// GetOrderApprovalDistribution.List.Current.OrderApprovalLevel.IsReassigned = False
localVars.queryResGetOrderApprovalDistribution_outParamList.CurrentRec.ssENOrderApprovalLevel.ssIsReassigned = false;

// GetOrderApprovalDistribution.List.Current.OrderApprovalLevel.RejectedBy = NullTextIdentifier
localVars.queryResGetOrderApprovalDistribution_outParamList.CurrentRec.ssENOrderApprovalLevel.ssRejectedBy = BuiltInFunction.NullTextIdentifier ();

// GetOrderApprovalDistribution.List.Current.OrderApprovalLevel.RejectedOn = NullDate
localVars.queryResGetOrderApprovalDistribution_outParamList.CurrentRec.ssENOrderApprovalLevel.ssRejectedOn = BuiltInFunction.NullDate ();

// GetOrderApprovalDistribution.List.Current.OrderApprovalLevel.ApprovedOn = NullDate
localVars.queryResGetOrderApprovalDistribution_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedOn = BuiltInFunction.NullDate ();

// GetOrderApprovalDistribution.List.Current.OrderApprovalLevel.ApprovedBy = NullTextIdentifier
localVars.queryResGetOrderApprovalDistribution_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedBy = BuiltInFunction.NullTextIdentifier ();
// JSON Serialize JsonSerializeOrderApproval_RestartJSONSerialize2
FuncActionOrderApproval_Restart.JsonSerializeOrderApproval_RestartJSONSerialize2(localVars.queryResGetOrderApprovalDistribution_outParamList[0].ssENOrderApproval, out localVars.resJSONSerialize2_outParamJSON);
// ControledLogMessage2
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),("ChangeOrderApprovalPosition » Order Approval Level change "+localVars.resJSONSerialize2_outParamJSON),"ChangeOrderApprovalPosition",cancellationToken);

// OrderApprovalLevelCreateOrUpdate
localVars.resOrderApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionOrderApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetOrderApprovalDistribution_outParamList.CurrentRec.ssENOrderApprovalLevel,cancellationToken);

localVars.queryResGetOrderApprovalDistribution_outParamList.Advance();
}

} finally {
localVars.queryResGetOrderApprovalDistribution_outParamList.EndIteration();
}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_NoApprovalFound = result.outParamo_NoApprovalFound;
} // inner-finally
RETURN_STATEMENT:
return outParamo_NoApprovalFound;
}

public static class FuncActionOrderApproval_Restart {

private static async Task<RC_2929b54077988f623db253f22a62f498> datasetGetOrderApprovalDistributionReadDbAsync(RC_2929b54077988f623db253f22a62f498 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetOrderApprovalDistribution" 8hEChU34HkGbi3GxSssdIw of Action "OrderApproval_Restart"
public static async Task<(RL_3c2483fef931c35c62e6128a52ac9903,long)> datasetGetOrderApprovalDistribution(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderApproval_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrderApproval_Restart.GetOrderApprovalDistribution", "850211f2-f84d-411e-9b8b-71b14acb1d23");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrderApproval_Restart.GetOrderApprovalDistribution", "850211f2-f84d-411e-9b8b-71b14acb1d23", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.mAdREssPkka0uUPLwy4vgw/NodesNotShownInESpaceTree.8hEChU34HkGbi3GxSssdIw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderapproval1\".\"id\" o0, \"enorderapproval1\".\"orderid\" o1, \"enorderapproval1\".\"currentlevel\" o2, \"enorderapproval1\".\"maxlevel\" o3, \"enorderapproval1\".\"startedon\" o4, \"enorderapproval1\".\"finishedon\" o5, \"enorderapproval1\".\"lastapproverpuestodelgerente\" o6, \"enorderapproval1\".\"lastapproverpuestodeljefe\" o7, \"enorderapprovallevel1\".\"id\" o8, \"enorderapprovallevel1\".\"orderapprovalid\" o9, \"enorderapprovallevel1\".\"levelnumber\" o10, \"enorderapprovallevel1\".\"entraroleid\" o11, \"enorderapprovallevel1\".\"assignedto\" o12, \"enorderapprovallevel1\".\"assignedon\" o13, \"enorderapprovallevel1\".\"approvalstatusid\" o14, \"enorderapprovallevel1\".\"approvedby\" o15, \"enorderapprovallevel1\".\"approvedon\" o16, \"enorderapprovallevel1\".\"rejectedby\" o17, \"enorderapprovallevel1\".\"rejectedon\" o18, \"enorderapprovallevel1\".\"iscomplement\" o19, \"enorderapprovallevel1\".\"isreassigned\" o20, \"enorderapprovallevel1\".\"issubstitutefor\" o21, \"enorderapprovallevel1\".\"tomodifyby\" o22, \"enorderapprovallevel1\".\"tomodifyon\" o23, \"enorderapprovallevel1\".\"wascanceledby\" o24");
fromBuilder.Append(" FROM ({OrderApproval} \"enorderapproval1\" Left JOIN {OrderApprovalLevel} \"enorderapprovallevel1\" ON (\"enorderapproval1\".\"id\" = \"enorderapprovallevel1\".\"orderapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderApproval_OrderId != 0) {
whereBuilder.Append("((\"enorderapproval1\".\"orderid\" = @qporOrderApproval_OrderId) AND (\"enorderapproval1\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApproval_OrderId", DbType.Int64, qporOrderApproval_OrderId);
} else {
whereBuilder.Append("(\"enorderapproval1\".\"orderid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enorderapprovallevel1\".\"levelnumber\" ASC ");
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
RL_3c2483fef931c35c62e6128a52ac9903 outParamList = new RL_3c2483fef931c35c62e6128a52ac9903();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderApprovalDistributionReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrderApproval_Restart.GetOrderApprovalDistribution.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3c2483fef931c35c62e6128a52ac9903 _tmp = new RL_3c2483fef931c35c62e6128a52ac9903();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderApprovalDistributionReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrderApproval_Restart.GetOrderApprovalDistribution.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3c2483fef931c35c62e6128a52ac9903)_tmp;
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



/// <summary>
/// JSONSerialize: JsonSerializeOrderApproval_RestartJSONSerialize1 (Ky1ZbXrcdu0645cKw0HaCgg)  of
///  Action "OrderApproval_Restart"
/// </summary>
public static void JsonSerializeOrderApproval_RestartJSONSerialize1 (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

/// <summary>
/// JSONSerialize: JsonSerializeOrderApproval_RestartJSONSerialize2 (K0Tc6q8fS70OPc0wrScSizQ)  of
///  Action "OrderApproval_Restart"
/// </summary>
public static void JsonSerializeOrderApproval_RestartJSONSerialize2 (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

}


}
