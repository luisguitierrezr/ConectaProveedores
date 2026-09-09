namespace ssConectaProveedores;

public partial class Actions {
public class lcvTimerExpireDataCaptureRequisitions : VarsBag {
public Actions.lcoRequisitonStatusHistoryCreateOrUpdate resRequisitonStatusHistoryCreateOrUpdate =  new Actions.lcoRequisitonStatusHistoryCreateOrUpdate();
public RL_0ad79b64673379e41188da81c3628c0f queryResGetRequisitions_outParamList = new RL_0ad79b64673379e41188da81c3628c0f();
public long queryResGetRequisitions_outParamCount = 0L;

public Actions.lcoRequisitionLogAdd resRequisitionLogAdd =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate =  new Actions.lcoRequisitionCreateOrUpdate();
public lcvTimerExpireDataCaptureRequisitions() {
}
}
/// <summary>
/// Action <code>TimerExpireDataCaptureRequisitions</code> that represents the Service Studio action
///  <code>TimerExpireDataCaptureRequisitions</code> <p> Description: </p>
/// </summary>
public static async Task ActionTimerExpireDataCaptureRequisitions(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvTimerExpireDataCaptureRequisitions localVars = new lcvTimerExpireDataCaptureRequisitions();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("TimerExpireDataCaptureRequisitions", "3d522073-9fb9-460b-899e-a36b03dc6991"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("TimerExpireDataCaptureRequisitions", "3d522073-9fb9-460b-899e-a36b03dc6991", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetRequisitions
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitions_maxRecords = 0;
int datasetGetRequisitions_startIndex = 0;(localVars.queryResGetRequisitions_outParamList,localVars.queryResGetRequisitions_outParamCount) = await FuncActionTimerExpireDataCaptureRequisitions.datasetGetRequisitions(requestContext,datasetGetRequisitions_maxRecords,datasetGetRequisitions_startIndex,IterationMultiplicity.Single,cancellationToken);

// Foreach GetRequisitions.List
localVars.queryResGetRequisitions_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitions_outParamList.Eof))) {
// GetRequisitions.List.Current.Requisition.RequisitionStatusId = Expired
localVars.queryResGetRequisitions_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("wpdx_Qw3wEmfndGLo0VZ+Q"))).ssId;
// RequisitionCreateOrUpdate
localVars.resRequisitionCreateOrUpdate.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.queryResGetRequisitions_outParamList.CurrentRec.ssENRequisition,cancellationToken);

// RequisitonStatusHistoryCreateOrUpdate
localVars.resRequisitonStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionRequisitonStatusHistoryCreateOrUpdate(requestContext,new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.queryResGetRequisitions_outParamList.CurrentRec.ssENRequisition.ssId, ssRequisitionStatusId = localVars.queryResGetRequisitions_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.NullTextIdentifier () },cancellationToken);

// RequisitionLogAdd
localVars.resRequisitionLogAdd.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.queryResGetRequisitions_outParamList.CurrentRec.ssENRequisition.ssId, ssCreatedBy = BuiltInFunction.NullTextIdentifier (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = "La requisición se actualizó automáticamente al estado Caducada debido a que se superó el límite de 72 horas para su captura." },cancellationToken);

localVars.queryResGetRequisitions_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitions_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionTimerExpireDataCaptureRequisitions {

// Query Function "GetRequisitions" hnJTpQF2CUaD1hq8L8xHxg of Action "TimerExpireDataCaptureRequisitions"
public static async Task<(RL_0ad79b64673379e41188da81c3628c0f,long)> datasetGetRequisitions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("TimerExpireDataCaptureRequisitions.GetRequisitions", "a5537286-7601-4609-83d6-1abc2fcc47c6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("TimerExpireDataCaptureRequisitions.GetRequisitions", "a5537286-7601-4609-83d6-1abc2fcc47c6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.cyBSPbmfC0aJnqNrA9xpkQ/NodesNotShownInESpaceTree.hnJTpQF2CUaD1hq8L8xHxg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisition17\".\"id\" o0, \"enrequisition17\".\"name\" o1, \"enrequisition17\".\"counter\" o2, \"enrequisition17\".\"requisitionstatusid\" o3, \"enrequisition17\".\"supplierid\" o4, \"enrequisition17\".\"regionid\" o5, \"enrequisition17\".\"accountingregionid\" o6, \"enrequisition17\".\"applicantid\" o7, \"enrequisition17\".\"maxdatefinishcapture\" o8, \"enrequisition17\".\"projectassetserviceid\" o9, \"enrequisition17\".\"projectassetservice\" o10, \"enrequisition17\".\"projectdescription\" o11, \"enrequisition17\".\"frequencyid\" o12, \"enrequisition17\".\"issustainability\" o13, \"enrequisition17\".\"sustainabilityid\" o14, \"enrequisition17\".\"businessvaluecategoryid\" o15, \"enrequisition17\".\"businessvaluesubcategoryid\" o16, trim_scale(\"enrequisition17\".\"totalamount\"::numeric) o17, \"enrequisition17\".\"currencyid\" o18, \"enrequisition17\".\"distributionid\" o19, \"enrequisition17\".\"costcenterid\" o20, \"enrequisition17\".\"hascontract\" o21, \"enrequisition17\".\"iscontractpending\" o22, \"enrequisition17\".\"hasdeposit\" o23, \"enrequisition17\".\"hasinsurance\" o24, \"enrequisition17\".\"hasadvancepayment\" o25, \"enrequisition17\".\"accountingservicetypeid_depr\" o26, \"enrequisition17\".\"servicedescription_deprec\" o27, \"enrequisition17\".\"invoiceusageid_deprec\" o28, \"enrequisition17\".\"serviceformatid\" o29, \"enrequisition17\".\"companyid\" o30, trim_scale(\"enrequisition17\".\"retentionrate\"::numeric) o31, trim_scale(\"enrequisition17\".\"negotiatedexchangerate\"::numeric) o32, \"enrequisition17\".\"paymentmethodid\" o33, \"enrequisition17\".\"paymenttermsid\" o34, \"enrequisition17\".\"isautomaticaccounting\" o35, \"enrequisition17\".\"createdby\" o36, \"enrequisition17\".\"createdon\" o37, \"enrequisition17\".\"updatedon\" o38, \"enrequisition17\".\"updatedby\" o39, \"enrequisition17\".\"createdbyapplicationrole\" o40, \"enrequisition17\".\"dateofcommitment\" o41, \"enrequisition17\".\"hascontractfileuploaded\" o42, \"enrequisition17\".\"hasupdateddateofcommitment\" o43, \"enrequisition17\".\"submittedon\" o44, \"enrequisition17\".\"isdonation\" o45, \"enrequisition17\".\"advwithoutinvoice\" o46, \"enrequisition17\".\"wasadvwithoutinvoice\" o47, \"enrequisition17\".\"isadvanced\" o48, \"enrequisition17\".\"documenttypeid\" o49, \"enrequisition17\".\"iscreatedbyanassistente\" o50, \"enrequisition17\".\"telceldirectionid\" o51, \"enrequisition17\".\"hasmultiupload\" o52, \"enrequisition17\".\"accountingdate\" o53, \"enrequisition17\".\"paymentoptionsid\" o54, \"enrequisition17\".\"paymentwaysid\" o55, \"enrequisition17\".\"buydocnumber\" o56, \"enrequisition17\".\"buydocposition\" o57");
fromBuilder.Append(" FROM {Requisition} \"enrequisition17\"");
whereBuilder.Append(" WHERE (\"enrequisition17\".\"requisitionstatusid\" = ");
whereBuilder.Append((ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId);
whereBuilder.Append(") AND ((\"enrequisition17\".\"maxdatefinishcapture\"::date <> (date '1900-01-01')::date) AND (\"enrequisition17\".\"maxdatefinishcapture\" < ((to_timestamp(@qepCurrdatetime, 'YYYY-MM-DD HH24:MI:SS')))))");
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdatetime", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
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
RL_0ad79b64673379e41188da81c3628c0f outParamList = new RL_0ad79b64673379e41188da81c3628c0f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TimerExpireDataCaptureRequisitions.GetRequisitions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0ad79b64673379e41188da81c3628c0f _tmp = new RL_0ad79b64673379e41188da81c3628c0f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TimerExpireDataCaptureRequisitions.GetRequisitions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0ad79b64673379e41188da81c3628c0f)_tmp;
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
