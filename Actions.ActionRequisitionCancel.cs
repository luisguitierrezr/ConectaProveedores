namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionCancel : VarsBag {
public long inParami_RequisitionId;
public long inParami_RequisitionApprovalLevelId;
public string inParami_CancelReason;
public string inParami_GetUserId;
public Actions.lcoRequisitionApprovalCreateOrUpdate resRequisitionApprovalCreateOrUpdate =  new Actions.lcoRequisitionApprovalCreateOrUpdate();
public RL_1f3e9ea72dc7b010c56ee9146ee277c5 queryResGetRequisitionById_outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
public long queryResGetRequisitionById_outParamCount = 0L;

public Actions.lcoRequisitionCommentCreateOrUpdate resRequisitionCommentCreateOrUpdate =  new Actions.lcoRequisitionCommentCreateOrUpdate();
public Actions.lcoRequisitonStatusHistoryCreateOrUpdate resRequisitonStatusHistoryCreateOrUpdate =  new Actions.lcoRequisitonStatusHistoryCreateOrUpdate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate =  new Actions.lcoRequisitionCreateOrUpdate();
public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public lcvRequisitionCancel(long inParami_RequisitionId, long inParami_RequisitionApprovalLevelId, string inParami_CancelReason, string inParami_GetUserId) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_RequisitionApprovalLevelId = inParami_RequisitionApprovalLevelId;
this.inParami_CancelReason = inParami_CancelReason;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoRequisitionCancel : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoRequisitionCancel() {
}
}
/// <summary>
/// Action <code>RequisitionCancel</code> that represents the Service Studio action
///  <code>RequisitionCancel</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionRequisitionCancel(IRequestContext requestContext,long inParami_RequisitionId,long inParami_RequisitionApprovalLevelId,string inParami_CancelReason,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoRequisitionCancel result = new lcoRequisitionCancel();
lcvRequisitionCancel localVars = new lcvRequisitionCancel(inParami_RequisitionId, inParami_RequisitionApprovalLevelId, inParami_CancelReason, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionCancel", "01f1538f-b892-4923-9da1-2d68a8666f63"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionCancel", "01f1538f-b892-4923-9da1-2d68a8666f63", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionRequisitionCancel.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionApprovalLevelId,localVars.inParami_RequisitionId,cancellationToken);

// empty?
if((localVars.queryResGetRequisitionById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Requisition not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("lZmfTps38EOucFs8k59isQ#Value.50351344.1", "Requisition not found!");
} else {
// status check
if(((((localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId==(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("wpdx_Qw3wEmfndGLo0VZ+Q"))).ssId)||(localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId==(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("1_RsQxcxokySProxyWT5mw"))).ssId))||(localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId==(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("Mh9oh8XO1EONnOOs1HKCZA"))).ssId)))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Requisition's current status does not allow a cancellation to be made!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("8aSIEGN_k0ONF7433i7u5g#Value.-1852481902.1", "Requisition's current status does not allow a cancellation to be made!");
} else {
// GetRequisitionById.List.Current.RequisitionApproval.FinishedOn = CurrDateTime
localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisitionApproval.ssFinishedOn = BuiltInFunction.CurrDateTime ();

// GetRequisitionById.List.Current.RequisitionApprovalLevel.ApprovalStatusId = Canceled
localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("YBJlnXS8SkKRSq9aruxhkg"))).ssId;

// GetRequisitionById.List.Current.RequisitionApprovalLevel.CanceledBy = If
localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssCanceledBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()));

// GetRequisitionById.List.Current.RequisitionApprovalLevel.CanceledOn_ = CurrDateTime
localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssCanceledOn_ = BuiltInFunction.CurrDateTime ();

// GetRequisitionById.List.Current.Requisition.RequisitionStatusId = Canceled
localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("1_RsQxcxokySProxyWT5mw"))).ssId;

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// has approval?
if(((localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisitionApproval.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RequisitionCommentCreateOrUpdate
localVars.resRequisitionCommentCreateOrUpdate.outParamId = await Actions.ActionRequisitionCommentCreateOrUpdate(requestContext,new EN_cbeb601b681344342c8de0161d058f87EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssCommentTypeId = (ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("qajvy+SdnE6bqldjFZvPIg"))).ssId, ssRequisitionId = localVars.inParami_RequisitionId, ssRequisitionApprovalLevelId = localVars.inParami_RequisitionApprovalLevelId, ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssMessage = localVars.inParami_CancelReason },cancellationToken);

// RequisitionApprovalLevelCreateOrUpdate
localVars.resRequisitionApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisitionApprovalLevel,cancellationToken);

// RequisitionApprovalCreateOrUpdate
localVars.resRequisitionApprovalCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalCreateOrUpdate(requestContext,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisitionApproval,cancellationToken);

}

// RequisitionCreateOrUpdate
localVars.resRequisitionCreateOrUpdate.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition,cancellationToken);

// RequisitonStatusHistoryCreateOrUpdate
localVars.resRequisitonStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionRequisitonStatusHistoryCreateOrUpdate(requestContext,new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssRequisitionStatusId = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

// RequisitionLogAdd
localVars.resRequisitionLogAdd.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((((((AppUtils.GetStringResource("ZX6j3HLLU0KZ9dAuot_V3g#Value.2063792252.1", "Requisition")+" ")+localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("ZX6j3HLLU0KZ9dAuot_V3g#Value.1923066730.1", "manually cancelled."))+" \r\n")+AppUtils.GetStringResource("ZX6j3HLLU0KZ9dAuot_V3g#Value.-2142134646.1", "Cancel reason"))+":")+" ")+localVars.inParami_CancelReason) },cancellationToken);

// has approval?
if(((localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisitionApproval.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// SendCanceledRequisitionEmails
await Actions.ActionSendCanceledRequisitionEmails(requestContext,localVars.inParami_RequisitionId,localVars.inParami_CancelReason,cancellationToken);

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionRequisitionCancel {

private static async Task<RC_11c2ac4c5bdce01960ee8371ad40d262> datasetGetRequisitionByIdReadDbAsync(RC_11c2ac4c5bdce01960ee8371ad40d262 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" ngfzWrBDxkyhhhqaRmRBXw of Action "RequisitionCancel"
public static async Task<(RL_1f3e9ea72dc7b010c56ee9146ee277c5,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApprovalLevel_Id,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RequisitionCancel.GetRequisitionById", "5af3079e-43b0-4cc6-a186-1a9a4664415f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RequisitionCancel.GetRequisitionById", "5af3079e-43b0-4cc6-a186-1a9a4664415f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.j1PxAZK4I0mdoS1oqGZvYw/NodesNotShownInESpaceTree.ngfzWrBDxkyhhhqaRmRBXw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisition1\".\"id\" o0, \"enrequisition1\".\"name\" o1, \"enrequisition1\".\"counter\" o2, \"enrequisition1\".\"requisitionstatusid\" o3, \"enrequisition1\".\"supplierid\" o4, \"enrequisition1\".\"regionid\" o5, \"enrequisition1\".\"accountingregionid\" o6, \"enrequisition1\".\"applicantid\" o7, \"enrequisition1\".\"maxdatefinishcapture\" o8, \"enrequisition1\".\"projectassetserviceid\" o9, \"enrequisition1\".\"projectassetservice\" o10, \"enrequisition1\".\"projectdescription\" o11, \"enrequisition1\".\"frequencyid\" o12, \"enrequisition1\".\"issustainability\" o13, \"enrequisition1\".\"sustainabilityid\" o14, \"enrequisition1\".\"businessvaluecategoryid\" o15, \"enrequisition1\".\"businessvaluesubcategoryid\" o16, trim_scale(\"enrequisition1\".\"totalamount\"::numeric) o17, \"enrequisition1\".\"currencyid\" o18, \"enrequisition1\".\"distributionid\" o19, \"enrequisition1\".\"costcenterid\" o20, \"enrequisition1\".\"hascontract\" o21, \"enrequisition1\".\"iscontractpending\" o22, \"enrequisition1\".\"hasdeposit\" o23, \"enrequisition1\".\"hasinsurance\" o24, \"enrequisition1\".\"hasadvancepayment\" o25, \"enrequisition1\".\"accountingservicetypeid_depr\" o26, \"enrequisition1\".\"servicedescription_deprec\" o27, \"enrequisition1\".\"invoiceusageid_deprec\" o28, \"enrequisition1\".\"serviceformatid\" o29, \"enrequisition1\".\"companyid\" o30, trim_scale(\"enrequisition1\".\"retentionrate\"::numeric) o31, trim_scale(\"enrequisition1\".\"negotiatedexchangerate\"::numeric) o32, \"enrequisition1\".\"paymentmethodid\" o33, \"enrequisition1\".\"paymenttermsid\" o34, \"enrequisition1\".\"isautomaticaccounting\" o35, \"enrequisition1\".\"createdby\" o36, \"enrequisition1\".\"createdon\" o37, \"enrequisition1\".\"updatedon\" o38, \"enrequisition1\".\"updatedby\" o39, \"enrequisition1\".\"createdbyapplicationrole\" o40, \"enrequisition1\".\"dateofcommitment\" o41, \"enrequisition1\".\"hascontractfileuploaded\" o42, \"enrequisition1\".\"hasupdateddateofcommitment\" o43, \"enrequisition1\".\"submittedon\" o44, \"enrequisition1\".\"isdonation\" o45, \"enrequisition1\".\"advwithoutinvoice\" o46, \"enrequisition1\".\"wasadvwithoutinvoice\" o47, \"enrequisition1\".\"isadvanced\" o48, \"enrequisition1\".\"documenttypeid\" o49, \"enrequisition1\".\"iscreatedbyanassistente\" o50, \"enrequisition1\".\"telceldirectionid\" o51, \"enrequisition1\".\"hasmultiupload\" o52, \"enrequisition1\".\"accountingdate\" o53, \"enrequisition1\".\"paymentoptionsid\" o54, \"enrequisition1\".\"paymentwaysid\" o55, \"enrequisition1\".\"buydocnumber\" o56, \"enrequisition1\".\"buydocposition\" o57, \"enrequisitionapproval2\".\"id\" o58, \"enrequisitionapproval2\".\"requisitionid\" o59, \"enrequisitionapproval2\".\"aprovalprocessid\" o60, \"enrequisitionapproval2\".\"processtypecode\" o61, \"enrequisitionapproval2\".\"approvalprocessversion\" o62, \"enrequisitionapproval2\".\"currentlevel\" o63, \"enrequisitionapproval2\".\"maxlevel\" o64, \"enrequisitionapproval2\".\"startedon\" o65, \"enrequisitionapproval2\".\"finishedon\" o66, \"enrequisitionapproval2\".\"hasstartedaccounting\" o67, \"enrequisitionapprovallevel2\".\"id\" o68, \"enrequisitionapprovallevel2\".\"requisitionapprovalid\" o69, \"enrequisitionapprovallevel2\".\"levelnumber\" o70, \"enrequisitionapprovallevel2\".\"applicationroleid\" o71, \"enrequisitionapprovallevel2\".\"entrajobtitle\" o72, \"enrequisitionapprovallevel2\".\"departmentid\" o73, \"enrequisitionapprovallevel2\".\"managementid\" o74, \"enrequisitionapprovallevel2\".\"subdirectionid\" o75, \"enrequisitionapprovallevel2\".\"entraroleid\" o76, \"enrequisitionapprovallevel2\".\"entrausername\" o77, \"enrequisitionapprovallevel2\".\"assignedto\" o78, \"enrequisitionapprovallevel2\".\"needscontract\" o79, \"enrequisitionapprovallevel2\".\"approvalstatusid\" o80, \"enrequisitionapprovallevel2\".\"approvedby\" o81, \"enrequisitionapprovallevel2\".\"approvedon\" o82, \"enrequisitionapprovallevel2\".\"requesttomodifyby\" o83, \"enrequisitionapprovallevel2\".\"requesttomodifyon\" o84, \"enrequisitionapprovallevel2\".\"canceledby\" o85, \"enrequisitionapprovallevel2\".\"canceledon_deprec\" o86, \"enrequisitionapprovallevel2\".\"isaccounting\" o87, \"enrequisitionapprovallevel2\".\"isstartaccounting\" o88, \"enrequisitionapprovallevel2\".\"canceledon_\" o89, \"enrequisitionapprovallevel2\".\"approveasareausuaria\" o90, \"enrequisitionapprovallevel2\".\"ismandatory\" o91, \"enrequisitionapprovallevel2\".\"isreassigned\" o92, \"enrequisitionapprovallevel2\".\"issubstitutefor\" o93");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition1\" Left JOIN {RequisitionApproval} \"enrequisitionapproval2\" ON (\"enrequisition1\".\"id\" = \"enrequisitionapproval2\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel2\" ON (\"enrequisitionapproval2\".\"id\" = \"enrequisitionapprovallevel2\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition1\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition1\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpreRequisitionApprovalLevel_Id <> 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApprovalLevel_Id", DbType.Int64, qpreRequisitionApprovalLevel_Id);
if (qpreRequisitionApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enrequisitionapprovallevel2\".\"id\" = @qpreRequisitionApprovalLevel_Id) AND (\"enrequisitionapprovallevel2\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApprovalLevel_Id", DbType.Int64, qpreRequisitionApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel2\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RequisitionCancel.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f3e9ea72dc7b010c56ee9146ee277c5 _tmp = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RequisitionCancel.GetRequisitionById.List", cancellationToken: cancellationToken);
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
