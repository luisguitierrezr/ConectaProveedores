namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioResetApprovProcess : VarsBag {
public long inParami_FolioId;
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate3 =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate2 =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public Actions.lcoFolioApprovalCreateOrUpdate resFolioApprovalCreateOrUpdate =  new Actions.lcoFolioApprovalCreateOrUpdate();
public RL_ae9182bb38290e8d92b0cbd2d4f71569 resIsInvoiceApproval_outParamFilteredList = new RL_ae9182bb38290e8d92b0cbd2d4f71569();

public RL_ae9182bb38290e8d92b0cbd2d4f71569 queryResGetFolioById_outParamList = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
public long queryResGetFolioById_outParamCount = 0L;

public lcvFolioResetApprovProcess(long inParami_FolioId) {
this.inParami_FolioId = inParami_FolioId;
}
}
/// <summary>
/// Action <code>FolioResetApprovProcess</code> that represents the Service Studio action
///  <code>FolioResetApprovProcess</code> <p> Description: </p>
/// </summary>
public static async Task ActionFolioResetApprovProcess(IRequestContext requestContext,long inParami_FolioId,CancellationToken cancellationToken) {
lcvFolioResetApprovProcess localVars = new lcvFolioResetApprovProcess(inParami_FolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioResetApprovProcess", "9a4b37c4-6585-421a-ac13-7484ac931fbb"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioResetApprovProcess", "9a4b37c4-6585-421a-ac13-7484ac931fbb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionFolioResetApprovProcess.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Multiple,localVars.inParami_FolioId,cancellationToken);

// Is construction?
if(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssApprovalProcessTypeId==1))) {
// IsInvoiceApproval
localVars.resIsInvoiceApproval_outParamFilteredList = (((RL_ae9182bb38290e8d92b0cbd2d4f71569)await  localVars.queryResGetFolioById_outParamList.FilterAsync(async (p, cancellationToken) => p.ssENFolioApprovalLevel.ssIsInvoiceApproval, cancellationToken)));

// LevelNumber
await ExtendedActions.ListSort(requestContext,localVars.resIsInvoiceApproval_outParamFilteredList,async (p, cancellationToken) => p.ssENFolioApprovalLevel.ssLevelNumber,true,cancellationToken);

// Foreach IsInvoiceApproval.FilteredList
localVars.resIsInvoiceApproval_outParamFilteredList.StartIteration();
try {while (!((localVars.resIsInvoiceApproval_outParamFilteredList.Eof))) {
// FolioApprovalLevelDelete3
await Actions.ActionFolioApprovalLevelDelete(requestContext,localVars.resIsInvoiceApproval_outParamFilteredList.CurrentRec.ssENFolioApprovalLevel.ssId,cancellationToken);

localVars.resIsInvoiceApproval_outParamFilteredList.Advance();
}

} finally {
localVars.resIsInvoiceApproval_outParamFilteredList.EndIteration();
}

// PendingApprovalAccounting
// GetFolioById.List.Current.Folio.FolioStatusId = PendingApprovalAccounting
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("ZfpLpTdXy0CRfRTjg6qPeA"))).ssId;
} else {
// LevelNumber2
await ExtendedActions.ListSort(requestContext,localVars.queryResGetFolioById_outParamList,async (p, cancellationToken) => p.ssENFolioApprovalLevel.ssLevelNumber,true,cancellationToken);

// Hierarchical flow?
if(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssApprovalProcessTypeId==4))) {
// Foreach GetFolioById.List
localVars.queryResGetFolioById_outParamList.StartIteration();
try {while (!((localVars.queryResGetFolioById_outParamList.Eof))) {
// Not first element?
if(((localVars.queryResGetFolioById_outParamList.CurrentRowNumber!=0))) {
// FolioApprovalLevelDelete
await Actions.ActionFolioApprovalLevelDelete(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssId,cancellationToken);

} else {
// GetFolioById.List.Current.FolioApproval.CurrentLevel = GetFolioById.List.Current.FolioApprovalLevel.LevelNumber
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssCurrentLevel = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssLevelNumber;

// GetFolioById.List.Current.FolioApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// GetFolioById.List.Current.FolioApprovalLevel.ApprovedBy = NullTextIdentifier
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovedBy = BuiltInFunction.NullTextIdentifier ();

// GetFolioById.List.Current.FolioApprovalLevel.ApprovedOn = NullDate
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovedOn = BuiltInFunction.NullDate ();

// GetFolioById.List.Current.FolioApprovalLevel.CanceledBy = NullTextIdentifier
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssCanceledBy = BuiltInFunction.NullTextIdentifier ();

// GetFolioById.List.Current.FolioApprovalLevel.CanceledOn = NullDate
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssCanceledOn = BuiltInFunction.NullDate ();

// GetFolioById.List.Current.FolioApprovalLevel.RejectedBy = NullTextIdentifier
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssRejectedBy = BuiltInFunction.NullTextIdentifier ();

// GetFolioById.List.Current.FolioApprovalLevel.RejectedOn = NullDate
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssRejectedOn = BuiltInFunction.NullDate ();
// FolioApprovalLevelCreateOrUpdate2
localVars.resFolioApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

}

localVars.queryResGetFolioById_outParamList.Advance();
}

} finally {
localVars.queryResGetFolioById_outParamList.EndIteration();
}

} else {
// Foreach GetFolioById.List
localVars.queryResGetFolioById_outParamList.StartIteration();
try {while (!((localVars.queryResGetFolioById_outParamList.Eof))) {
// IsInvoiceApproval?
if((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssIsInvoiceApproval)) {
// FolioApprovalLevelDelete2
await Actions.ActionFolioApprovalLevelDelete(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssId,cancellationToken);

} else {
// GetFolioById.List.Current.FolioApproval.CurrentLevel = If
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssCurrentLevel = (((localVars.queryResGetFolioById_outParamList.CurrentRowNumber==0)) ? (localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssLevelNumber) : (localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssCurrentLevel));

// GetFolioById.List.Current.FolioApprovalLevel.ApprovalStatusId = If
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId = (((localVars.queryResGetFolioById_outParamList.CurrentRowNumber==0)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId));

// GetFolioById.List.Current.FolioApprovalLevel.ApprovedBy = NullTextIdentifier
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovedBy = BuiltInFunction.NullTextIdentifier ();

// GetFolioById.List.Current.FolioApprovalLevel.ApprovedOn = NullDate
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovedOn = BuiltInFunction.NullDate ();

// GetFolioById.List.Current.FolioApprovalLevel.CanceledBy = NullTextIdentifier
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssCanceledBy = BuiltInFunction.NullTextIdentifier ();

// GetFolioById.List.Current.FolioApprovalLevel.CanceledOn = NullDate
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssCanceledOn = BuiltInFunction.NullDate ();

// GetFolioById.List.Current.FolioApprovalLevel.RejectedBy = NullTextIdentifier
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssRejectedBy = BuiltInFunction.NullTextIdentifier ();

// GetFolioById.List.Current.FolioApprovalLevel.RejectedOn = NullDate
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssRejectedOn = BuiltInFunction.NullDate ();

// GetFolioById.List.Current.FolioApprovalLevel.AssignedTo = NullTextIdentifier
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo = BuiltInFunction.NullTextIdentifier ();
// FolioApprovalLevelCreateOrUpdate3
localVars.resFolioApprovalLevelCreateOrUpdate3.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

}

localVars.queryResGetFolioById_outParamList.Advance();
}

} finally {
localVars.queryResGetFolioById_outParamList.EndIteration();
}

}

// PendingApproval
// GetFolioById.List.Current.Folio.FolioStatusId = PendingApproval
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId;
}

// FolioApprovalCreateOrUpdate
localVars.resFolioApprovalCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval,cancellationToken);

// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionFolioResetApprovProcess {

private static async Task<RC_1b390f8e281aa018cfe8a81d34cdb757> datasetGetFolioByIdReadDbAsync(RC_1b390f8e281aa018cfe8a81d34cdb757 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" qt9g4wQVKUKz11GvlwfA3A of Action "FolioResetApprovProcess"
public static async Task<(RL_ae9182bb38290e8d92b0cbd2d4f71569,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioResetApprovProcess.GetFolioById", "e360dfaa-1504-4229-b3d7-51af9707c0dc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioResetApprovProcess.GetFolioById", "e360dfaa-1504-4229-b3d7-51af9707c0dc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.xDdLmoVlGkKsE3SErJMfuw/NodesNotShownInESpaceTree.qt9g4wQVKUKz11GvlwfA3A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio35\".\"id\" o0, \"enfolio35\".\"isdraft\" o1, \"enfolio35\".\"folionumber\" o2, \"enfolio35\".\"canproveedorcancel\" o3, \"enfolio35\".\"orderid\" o4, \"enfolio35\".\"supplierid\" o5, \"enfolio35\".\"companyid\" o6, \"enfolio35\".\"foliostatusid\" o7, trim_scale(\"enfolio35\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio35\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio35\".\"partialamount\"::numeric) o10, \"enfolio35\".\"currencyid\" o11, \"enfolio35\".\"firstapproveruserid\" o12, \"enfolio35\".\"approvalprocesstypeid\" o13, \"enfolio35\".\"sapentryerror\" o14, \"enfolio35\".\"createdby\" o15, \"enfolio35\".\"createdon\" o16, \"enfolio35\".\"updatedby\" o17, \"enfolio35\".\"updatedon\" o18, \"enfolio35\".\"minuteselected\" o19, \"enfolioapproval18\".\"id\" o20, \"enfolioapproval18\".\"folioid\" o21, \"enfolioapproval18\".\"approvalprocessid\" o22, \"enfolioapproval18\".\"processtypecode\" o23, \"enfolioapproval18\".\"approvalprocessversion\" o24, \"enfolioapproval18\".\"currentlevel\" o25, \"enfolioapproval18\".\"maxlevel\" o26, \"enfolioapproval18\".\"startedon\" o27, \"enfolioapproval18\".\"finishedon\" o28, \"enfolioapproval18\".\"regionid\" o29, \"enfolioapprovallevel17\".\"id\" o30, \"enfolioapprovallevel17\".\"folioapprovalid\" o31, \"enfolioapprovallevel17\".\"levelnumber\" o32, \"enfolioapprovallevel17\".\"applicationroleid\" o33, \"enfolioapprovallevel17\".\"entrajobtitle\" o34, \"enfolioapprovallevel17\".\"entraroleid\" o35, \"enfolioapprovallevel17\".\"departmentid\" o36, \"enfolioapprovallevel17\".\"assignedto\" o37, \"enfolioapprovallevel17\".\"approvalstatusid\" o38, \"enfolioapprovallevel17\".\"ismandatory\" o39, \"enfolioapprovallevel17\".\"isreassigned\" o40, \"enfolioapprovallevel17\".\"approvedby\" o41, \"enfolioapprovallevel17\".\"approvedon\" o42, \"enfolioapprovallevel17\".\"canceledby\" o43, \"enfolioapprovallevel17\".\"canceledon\" o44, \"enfolioapprovallevel17\".\"rejectedby\" o45, \"enfolioapprovallevel17\".\"rejectedon\" o46, \"enfolioapprovallevel17\".\"issubstitutefor\" o47, \"enfolioapprovallevel17\".\"rejectreason\" o48, \"enfolioapprovallevel17\".\"isinvoiceapproval\" o49");
fromBuilder.Append(" FROM (({Folio} \"enfolio35\" Left JOIN {FolioApproval} \"enfolioapproval18\" ON (\"enfolio35\".\"id\" = \"enfolioapproval18\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel17\" ON (\"enfolioapproval18\".\"id\" = \"enfolioapprovallevel17\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio35\".\"id\" = @qpfoFolio_Id) AND (\"enfolio35\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio35\".\"id\" IS NULL)");
}
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
RL_ae9182bb38290e8d92b0cbd2d4f71569 outParamList = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioResetApprovProcess.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ae9182bb38290e8d92b0cbd2d4f71569 _tmp = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioResetApprovProcess.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ae9182bb38290e8d92b0cbd2d4f71569)_tmp;
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
