namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionAccountingRequest_OnSuccess : VarsBag {
public long inParamRequisitionId;
public Actions.lcoRequisitionApprovalCreateOrUpdate resRequisitionApprovalCreateOrUpdate =  new Actions.lcoRequisitionApprovalCreateOrUpdate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAddApprove =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate2 =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd =  new Actions.lcoRequisitionLogAdd();
public RL_1f3e9ea72dc7b010c56ee9146ee277c5 queryResGetRequisitionApprovalLevel_outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
public long queryResGetRequisitionApprovalLevel_outParamCount = 0L;

public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate =  new Actions.lcoRequisitionCreateOrUpdate();
public Actions.lcoRequisitonStatusHistoryCreateOrUpdate resRequisitonStatusHistoryCreateOrUpdate =  new Actions.lcoRequisitonStatusHistoryCreateOrUpdate();
public lcvRequisitionAccountingRequest_OnSuccess(long inParamRequisitionId) {
this.inParamRequisitionId = inParamRequisitionId;
}
}
public class lcoRequisitionAccountingRequest_OnSuccess : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoRequisitionAccountingRequest_OnSuccess() {
}
}
/// <summary>
/// Action <code>RequisitionAccountingRequest_OnSuccess</code> that represents the Service Studio
///  action <code>RequisitionAccountingRequest_OnSuccess</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionRequisitionAccountingRequest_OnSuccess(IRequestContext requestContext,long inParamRequisitionId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoRequisitionAccountingRequest_OnSuccess result = new lcoRequisitionAccountingRequest_OnSuccess();
lcvRequisitionAccountingRequest_OnSuccess localVars = new lcvRequisitionAccountingRequest_OnSuccess(inParamRequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionAccountingRequest_OnSuccess", "96d15fbe-fd2b-4bca-af4f-4073fbb853d3"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionAccountingRequest_OnSuccess", "96d15fbe-fd2b-4bca-af4f-4073fbb853d3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApprovalLevel_maxRecords = 1;
if (datasetGetRequisitionApprovalLevel_maxRecords < 1) datasetGetRequisitionApprovalLevel_maxRecords = 1;
int datasetGetRequisitionApprovalLevel_startIndex = 0;(localVars.queryResGetRequisitionApprovalLevel_outParamList,localVars.queryResGetRequisitionApprovalLevel_outParamCount) = await FuncActionRequisitionAccountingRequest_OnSuccess.datasetGetRequisitionApprovalLevel(requestContext,datasetGetRequisitionApprovalLevel_maxRecords,datasetGetRequisitionApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParamRequisitionId,cancellationToken);

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovedBy = GetUserId
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedBy = BuiltInFunction.GetUserId ();

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovalStatusId = Approved
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId;

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.AssignedTo = If
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo = (((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo) : (BuiltInFunction.GetUserId ()));

// GetRequisitionApprovalLevel.List.Current.Requisition.AccountingDate = CurrDate
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssAccountingDate = BuiltInFunction.CurrDate ();

// GetRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.EntraJobTitle = GetUserEntraRoleName()
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssEntraJobTitle = (await Functions.ActionGetUserEntraRoleName(requestContext,"",cancellationToken));
// RequisitionApprovalLevelCreateOrUpdate2
localVars.resRequisitionApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel,cancellationToken);

// RequisitionLogAddApprove
localVars.resRequisitionLogAddApprove.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParamRequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((AppUtils.GetStringResource("NmDAIbs_F0akhCXmK9zlmA#Value.2063792252.1", "Requisition")+" ")+localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("NmDAIbs_F0akhCXmK9zlmA#Value.1185244855.1", "approved"))+(((localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? ((" "+AppUtils.GetStringResource("NmDAIbs_F0akhCXmK9zlmA#Value.182414732.1", "by a substitute."))) : ("."))) },cancellationToken);

// GetRequisitionApprovalLevel.List.Current.RequisitionApproval.FinishedOn = CurrDateTime
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();

// GetRequisitionApprovalLevel.List.Current.Requisition.RequisitionStatusId = Approved
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("Mh9oh8XO1EONnOOs1HKCZA"))).ssId;

// GetRequisitionApprovalLevel.List.Current.RequisitionApproval.MaxLevel = GetRequisitionApprovalLevel.List.Current.RequisitionApproval.CurrentLevel
localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssMaxLevel = localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssCurrentLevel;
// RequisitionApprovalCreateOrUpdate
localVars.resRequisitionApprovalCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval,cancellationToken);

// RequisitionCreateOrUpdate
localVars.resRequisitionCreateOrUpdate.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition,cancellationToken);

// RequisitionLogAdd
localVars.resRequisitionLogAdd.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParamRequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("U6rRtOjQ_0m3r_L4sAW5YA#Value.2063792252.1", "Requisition")+" ")+localVars.queryResGetRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("U6rRtOjQ_0m3r_L4sAW5YA#Value.-1625364909.1", "updated to Approved status.")) },cancellationToken);

// RequisitonStatusHistoryCreateOrUpdate
localVars.resRequisitonStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionRequisitonStatusHistoryCreateOrUpdate(requestContext,new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParamRequisitionId, ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("Mh9oh8XO1EONnOOs1HKCZA"))).ssId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// SendReqApprovedEmail
await Actions.ActionSendReqApprovedEmail(requestContext,localVars.inParamRequisitionId,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionRequisitionAccountingRequest_OnSuccess {

private static async Task<RC_11c2ac4c5bdce01960ee8371ad40d262> datasetGetRequisitionApprovalLevelReadDbAsync(RC_11c2ac4c5bdce01960ee8371ad40d262 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionApprovalLevel" FyFY4u2suEuVetnfv50WMg of Action "RequisitionAccountingRequest_OnSuccess"
public static async Task<(RL_1f3e9ea72dc7b010c56ee9146ee277c5,long)> datasetGetRequisitionApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RequisitionAccountingRequest_OnSuccess.GetRequisitionApprovalLevel", "e2582117-aced-4bb8-957a-d9dfbf9d1632");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RequisitionAccountingRequest_OnSuccess.GetRequisitionApprovalLevel", "e2582117-aced-4bb8-957a-d9dfbf9d1632", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.vl_Rliv9ykuvT0Bz+7hT0w/NodesNotShownInESpaceTree.FyFY4u2suEuVetnfv50WMg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisition40\".\"id\" o0, \"enrequisition40\".\"name\" o1, \"enrequisition40\".\"counter\" o2, \"enrequisition40\".\"requisitionstatusid\" o3, \"enrequisition40\".\"supplierid\" o4, \"enrequisition40\".\"regionid\" o5, \"enrequisition40\".\"accountingregionid\" o6, \"enrequisition40\".\"applicantid\" o7, \"enrequisition40\".\"maxdatefinishcapture\" o8, \"enrequisition40\".\"projectassetserviceid\" o9, \"enrequisition40\".\"projectassetservice\" o10, \"enrequisition40\".\"projectdescription\" o11, \"enrequisition40\".\"frequencyid\" o12, \"enrequisition40\".\"issustainability\" o13, \"enrequisition40\".\"sustainabilityid\" o14, \"enrequisition40\".\"businessvaluecategoryid\" o15, \"enrequisition40\".\"businessvaluesubcategoryid\" o16, trim_scale(\"enrequisition40\".\"totalamount\"::numeric) o17, \"enrequisition40\".\"currencyid\" o18, \"enrequisition40\".\"distributionid\" o19, \"enrequisition40\".\"costcenterid\" o20, \"enrequisition40\".\"hascontract\" o21, \"enrequisition40\".\"iscontractpending\" o22, \"enrequisition40\".\"hasdeposit\" o23, \"enrequisition40\".\"hasinsurance\" o24, \"enrequisition40\".\"hasadvancepayment\" o25, \"enrequisition40\".\"accountingservicetypeid_depr\" o26, \"enrequisition40\".\"servicedescription_deprec\" o27, \"enrequisition40\".\"invoiceusageid_deprec\" o28, \"enrequisition40\".\"serviceformatid\" o29, \"enrequisition40\".\"companyid\" o30, trim_scale(\"enrequisition40\".\"retentionrate\"::numeric) o31, trim_scale(\"enrequisition40\".\"negotiatedexchangerate\"::numeric) o32, \"enrequisition40\".\"paymentmethodid\" o33, \"enrequisition40\".\"paymenttermsid\" o34, \"enrequisition40\".\"isautomaticaccounting\" o35, \"enrequisition40\".\"createdby\" o36, \"enrequisition40\".\"createdon\" o37, \"enrequisition40\".\"updatedon\" o38, \"enrequisition40\".\"updatedby\" o39, \"enrequisition40\".\"createdbyapplicationrole\" o40, \"enrequisition40\".\"dateofcommitment\" o41, \"enrequisition40\".\"hascontractfileuploaded\" o42, \"enrequisition40\".\"hasupdateddateofcommitment\" o43, \"enrequisition40\".\"submittedon\" o44, \"enrequisition40\".\"isdonation\" o45, \"enrequisition40\".\"advwithoutinvoice\" o46, \"enrequisition40\".\"wasadvwithoutinvoice\" o47, \"enrequisition40\".\"isadvanced\" o48, \"enrequisition40\".\"documenttypeid\" o49, \"enrequisition40\".\"iscreatedbyanassistente\" o50, \"enrequisition40\".\"telceldirectionid\" o51, \"enrequisition40\".\"hasmultiupload\" o52, \"enrequisition40\".\"accountingdate\" o53, \"enrequisition40\".\"paymentoptionsid\" o54, \"enrequisition40\".\"paymentwaysid\" o55, \"enrequisition40\".\"buydocnumber\" o56, \"enrequisition40\".\"buydocposition\" o57, \"enrequisitionapproval14\".\"id\" o58, \"enrequisitionapproval14\".\"requisitionid\" o59, \"enrequisitionapproval14\".\"aprovalprocessid\" o60, \"enrequisitionapproval14\".\"processtypecode\" o61, \"enrequisitionapproval14\".\"approvalprocessversion\" o62, \"enrequisitionapproval14\".\"currentlevel\" o63, \"enrequisitionapproval14\".\"maxlevel\" o64, \"enrequisitionapproval14\".\"startedon\" o65, \"enrequisitionapproval14\".\"finishedon\" o66, \"enrequisitionapproval14\".\"hasstartedaccounting\" o67, \"enrequisitionapprovallevel12\".\"id\" o68, \"enrequisitionapprovallevel12\".\"requisitionapprovalid\" o69, \"enrequisitionapprovallevel12\".\"levelnumber\" o70, \"enrequisitionapprovallevel12\".\"applicationroleid\" o71, \"enrequisitionapprovallevel12\".\"entrajobtitle\" o72, \"enrequisitionapprovallevel12\".\"departmentid\" o73, \"enrequisitionapprovallevel12\".\"managementid\" o74, \"enrequisitionapprovallevel12\".\"subdirectionid\" o75, \"enrequisitionapprovallevel12\".\"entraroleid\" o76, \"enrequisitionapprovallevel12\".\"entrausername\" o77, \"enrequisitionapprovallevel12\".\"assignedto\" o78, \"enrequisitionapprovallevel12\".\"needscontract\" o79, \"enrequisitionapprovallevel12\".\"approvalstatusid\" o80, \"enrequisitionapprovallevel12\".\"approvedby\" o81, \"enrequisitionapprovallevel12\".\"approvedon\" o82, \"enrequisitionapprovallevel12\".\"requesttomodifyby\" o83, \"enrequisitionapprovallevel12\".\"requesttomodifyon\" o84, \"enrequisitionapprovallevel12\".\"canceledby\" o85, \"enrequisitionapprovallevel12\".\"canceledon_deprec\" o86, \"enrequisitionapprovallevel12\".\"isaccounting\" o87, \"enrequisitionapprovallevel12\".\"isstartaccounting\" o88, \"enrequisitionapprovallevel12\".\"canceledon_\" o89, \"enrequisitionapprovallevel12\".\"approveasareausuaria\" o90, \"enrequisitionapprovallevel12\".\"ismandatory\" o91, \"enrequisitionapprovallevel12\".\"isreassigned\" o92, \"enrequisitionapprovallevel12\".\"issubstitutefor\" o93");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition40\" Left JOIN {RequisitionApproval} \"enrequisitionapproval14\" ON (\"enrequisition40\".\"id\" = \"enrequisitionapproval14\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel12\" ON (\"enrequisitionapproval14\".\"id\" = \"enrequisitionapprovallevel12\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition40\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition40\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition40\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionapprovallevel12\".\"levelnumber\" = \"enrequisitionapproval14\".\"currentlevel\")");
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
RL_1f3e9ea72dc7b010c56ee9146ee277c5 outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RequisitionAccountingRequest_OnSuccess.GetRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f3e9ea72dc7b010c56ee9146ee277c5 _tmp = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RequisitionAccountingRequest_OnSuccess.GetRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1f3e9ea72dc7b010c56ee9146ee277c5)_tmp;
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
