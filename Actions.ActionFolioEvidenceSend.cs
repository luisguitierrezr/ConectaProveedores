namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioEvidenceSend : VarsBag {
public long inParami_FolioId;
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAdd2 =  new Actions.lcoFolioLogAdd();
public RL_ae9182bb38290e8d92b0cbd2d4f71569 queryResGetFolioApprovalLevelEvidRequested_outParamList = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
public long queryResGetFolioApprovalLevelEvidRequested_outParamCount = 0L;

public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public lcvFolioEvidenceSend(long inParami_FolioId) {
this.inParami_FolioId = inParami_FolioId;
}
}
public class lcoFolioEvidenceSend : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoFolioEvidenceSend() {
}
}
/// <summary>
/// Action <code>FolioEvidenceSend</code> that represents the Service Studio action
///  <code>FolioEvidenceSend</code> <p> Description: Action to Evidence Send Folio.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionFolioEvidenceSend(IRequestContext requestContext,long inParami_FolioId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoFolioEvidenceSend result = new lcoFolioEvidenceSend();
lcvFolioEvidenceSend localVars = new lcvFolioEvidenceSend(inParami_FolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioEvidenceSend", "a9c9615c-5a3d-4172-a978-7f78fa73bbd1"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioEvidenceSend", "a9c9615c-5a3d-4172-a978-7f78fa73bbd1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioApprovalLevelEvidRequested
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioApprovalLevelEvidRequested_maxRecords = 1;
if (datasetGetFolioApprovalLevelEvidRequested_maxRecords < 1) datasetGetFolioApprovalLevelEvidRequested_maxRecords = 1;
int datasetGetFolioApprovalLevelEvidRequested_startIndex = 0;(localVars.queryResGetFolioApprovalLevelEvidRequested_outParamList,localVars.queryResGetFolioApprovalLevelEvidRequested_outParamCount) = await FuncActionFolioEvidenceSend.datasetGetFolioApprovalLevelEvidRequested(requestContext,datasetGetFolioApprovalLevelEvidRequested_maxRecords,datasetGetFolioApprovalLevelEvidRequested_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// Not found?
if((localVars.queryResGetFolioApprovalLevelEvidRequested_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Evidence cannot be submitted!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("5M+VjtweXEyMN_a2X1Z0VQ#Value.-14711761.1", "Evidence cannot be submitted!");
} else {
// GetFolioApprovalLevelEvidRequested.List.Current.FolioApprovalLevel.ApprovalStatusId = EvidenceReview
localVars.queryResGetFolioApprovalLevelEvidRequested_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId;

// GetFolioApprovalLevelEvidRequested.List.Current.Folio.FolioStatusId = EvidenceReview
localVars.queryResGetFolioApprovalLevelEvidRequested_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("vQbNAb5X2kaiyrG3Zsu2KA"))).ssId;
// FolioLogAdd2
localVars.resFolioLogAdd2.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (AppUtils.GetStringResource("16pMbcDR+kC6Qq5MJJw2UQ#Value.-1731416159.1", "Evidence sent")+"."), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

// FolioApprovalLevelCreateOrUpdate
localVars.resFolioApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFolioApprovalLevelEvidRequested_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioApprovalLevelEvidRequested_outParamList.CurrentRec.ssENFolio,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((AppUtils.GetStringResource("0v5_B7QOak+AXZLClCSucg#Value.68060425.1", "Folio")+" ")+localVars.queryResGetFolioApprovalLevelEvidRequested_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("0v5_B7QOak+AXZLClCSucg#Value.226872627.1", "updated to status Evidence Review"))+"."), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// SendEmailApprover_ReviewEvidence
await Actions.ActionSendEmailApprover_ReviewEvidence(requestContext,localVars.inParami_FolioId,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionFolioEvidenceSend {

private static async Task<RC_1b390f8e281aa018cfe8a81d34cdb757> datasetGetFolioApprovalLevelEvidRequestedReadDbAsync(RC_1b390f8e281aa018cfe8a81d34cdb757 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalLevelEvidRequested" jzqx0iO+kkG6_W8IFxUBIA of Action "FolioEvidenceSend"
public static async Task<(RL_ae9182bb38290e8d92b0cbd2d4f71569,long)> datasetGetFolioApprovalLevelEvidRequested(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioEvidenceSend.GetFolioApprovalLevelEvidRequested", "d2b13a8f-be23-4192-bafd-6f0817150120");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioEvidenceSend.GetFolioApprovalLevelEvidRequested", "d2b13a8f-be23-4192-bafd-6f0817150120", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
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
selectBuilder.Append("/* /UserActions.XGHJqT1ackGpeH94+nO70Q/NodesNotShownInESpaceTree.jzqx0iO+kkG6_W8IFxUBIA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio40\".\"id\" o0, \"enfolio40\".\"isdraft\" o1, \"enfolio40\".\"folionumber\" o2, \"enfolio40\".\"canproveedorcancel\" o3, \"enfolio40\".\"orderid\" o4, \"enfolio40\".\"supplierid\" o5, \"enfolio40\".\"companyid\" o6, \"enfolio40\".\"foliostatusid\" o7, trim_scale(\"enfolio40\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio40\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio40\".\"partialamount\"::numeric) o10, \"enfolio40\".\"currencyid\" o11, \"enfolio40\".\"firstapproveruserid\" o12, \"enfolio40\".\"approvalprocesstypeid\" o13, \"enfolio40\".\"sapentryerror\" o14, \"enfolio40\".\"createdby\" o15, \"enfolio40\".\"createdon\" o16, \"enfolio40\".\"updatedby\" o17, \"enfolio40\".\"updatedon\" o18, \"enfolio40\".\"minuteselected\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"enfolioapprovallevel21\".\"id\" o30, \"enfolioapprovallevel21\".\"folioapprovalid\" o31, \"enfolioapprovallevel21\".\"levelnumber\" o32, \"enfolioapprovallevel21\".\"applicationroleid\" o33, \"enfolioapprovallevel21\".\"entrajobtitle\" o34, \"enfolioapprovallevel21\".\"entraroleid\" o35, \"enfolioapprovallevel21\".\"departmentid\" o36, \"enfolioapprovallevel21\".\"assignedto\" o37, \"enfolioapprovallevel21\".\"approvalstatusid\" o38, \"enfolioapprovallevel21\".\"ismandatory\" o39, \"enfolioapprovallevel21\".\"isreassigned\" o40, \"enfolioapprovallevel21\".\"approvedby\" o41, \"enfolioapprovallevel21\".\"approvedon\" o42, \"enfolioapprovallevel21\".\"canceledby\" o43, \"enfolioapprovallevel21\".\"canceledon\" o44, \"enfolioapprovallevel21\".\"rejectedby\" o45, \"enfolioapprovallevel21\".\"rejectedon\" o46, \"enfolioapprovallevel21\".\"issubstitutefor\" o47, \"enfolioapprovallevel21\".\"rejectreason\" o48, \"enfolioapprovallevel21\".\"isinvoiceapproval\" o49");
fromBuilder.Append(" FROM (({Folio} \"enfolio40\" Left JOIN {FolioApproval} \"enfolioapproval22\" ON (\"enfolio40\".\"id\" = \"enfolioapproval22\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel21\" ON (\"enfolioapproval22\".\"id\" = \"enfolioapprovallevel21\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio40\".\"id\" = @qpfoFolio_Id) AND (\"enfolio40\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio40\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel21\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("w+wMayzP1kit5Zcgfd05+g"))).ssId);
whereBuilder.Append(")");
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
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelEvidRequestedReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioEvidenceSend.GetFolioApprovalLevelEvidRequested.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ae9182bb38290e8d92b0cbd2d4f71569 _tmp = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelEvidRequestedReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioEvidenceSend.GetFolioApprovalLevelEvidRequested.List", cancellationToken: cancellationToken);
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
