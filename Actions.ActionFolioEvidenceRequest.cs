namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioEvidenceRequest : VarsBag {
public long inParami_FolioId;
public long inParami_FolioApprovalLevelId;
public string inParami_Comment;
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoFolioCommentCreateOrUpdate resFolioCommentCreateOrUpdate =  new Actions.lcoFolioCommentCreateOrUpdate();
public RL_ae9182bb38290e8d92b0cbd2d4f71569 queryResGetFolioById_outParamList = new RL_ae9182bb38290e8d92b0cbd2d4f71569();
public long queryResGetFolioById_outParamCount = 0L;

public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public Actions.lcoGetUserEntraRoleName resGetUserEntraRoleName =  new Actions.lcoGetUserEntraRoleName();
public lcvFolioEvidenceRequest(long inParami_FolioId, long inParami_FolioApprovalLevelId, string inParami_Comment) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_FolioApprovalLevelId = inParami_FolioApprovalLevelId;
this.inParami_Comment = inParami_Comment;
}
}
public class lcoFolioEvidenceRequest : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoFolioEvidenceRequest() {
}
}
/// <summary>
/// Action <code>FolioEvidenceRequest</code> that represents the Service Studio action
///  <code>FolioEvidenceRequest</code> <p> Description: Action to Evidence Request Folio.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionFolioEvidenceRequest(IRequestContext requestContext,long inParami_FolioId,long inParami_FolioApprovalLevelId,string inParami_Comment,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoFolioEvidenceRequest result = new lcoFolioEvidenceRequest();
lcvFolioEvidenceRequest localVars = new lcvFolioEvidenceRequest(inParami_FolioId, inParami_FolioApprovalLevelId, inParami_Comment);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioEvidenceRequest", "d2a4d1e9-1901-4546-b1a5-89ff1d18543e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioEvidenceRequest", "d2a4d1e9-1901-4546-b1a5-89ff1d18543e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionFolioEvidenceRequest.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioApprovalLevelId,localVars.inParami_FolioId,cancellationToken);

// Empty?
if((localVars.queryResGetFolioById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("QJCa3wwc_k2xWjB+lmkSWg#Value.1482511939.1", "Folio not found!");
} else {
// Level Not Approved?
if((((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId)&&(localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId)))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("fs0tRDX8IEudMK_0boQKwg#Value.1911675613.1", "Folio cannot be updated!");
} else {
// GetUserEntraRoleName
localVars.resGetUserEntraRoleName.outParamo_EntraRoleName = await Actions.ActionGetUserEntraRoleName(requestContext,"",cancellationToken);

// Folio Fields
// GetFolioById.List.Current.Folio.FolioStatusId = EvidenceRequested
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("WhiUWVQy5E68vtmKmJU0KA"))).ssId;

// GetFolioById.List.Current.FolioApprovalLevel.ApprovalStatusId = EvidenceRequested
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("w+wMayzP1kit5Zcgfd05+g"))).ssId;

// GetFolioById.List.Current.FolioApprovalLevel.EntraJobTitle = GetUserEntraRoleName.o_EntraRoleName
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraJobTitle = localVars.resGetUserEntraRoleName.outParamo_EntraRoleName;

// GetFolioById.List.Current.FolioApprovalLevel.AssignedTo = If
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo = (((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo==BuiltInFunction.NullTextIdentifier ())) ? (BuiltInFunction.GetUserId ()) : (localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo));
// FolioApprovalLevelCreateOrUpdate
localVars.resFolioApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio,cancellationToken);

// FolioCommentCreateOrUpdate
localVars.resFolioCommentCreateOrUpdate.outParamId = await Actions.ActionFolioCommentCreateOrUpdate(requestContext,new EN_a75639301080da49357fc03810b8d65fEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssFolioApprovalLevelId = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssId, ssCommentTypeId = (ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("fWPpinJz1EuuskuhosoYJA"))).ssId, ssApplicationRoleId = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApplicationRoleId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId (), ssMessage = localVars.inParami_Comment, ssIsPublic = true },cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = ((((((((AppUtils.GetStringResource("7zVIBvFyt0eX7+uZfyKmtA#Value.68060425.1", "Folio")+" ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("7zVIBvFyt0eX7+uZfyKmtA#Value.1571395813.1", "evidence requested"))+". ")+AppUtils.GetStringResource("7zVIBvFyt0eX7+uZfyKmtA#Value.-1679915457.1", "Comment"))+": ")+localVars.inParami_Comment), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

// ClearOtherPossibleApprovers3
await Actions.ActionClearOtherPossibleApprovers(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssId,localVars.inParami_FolioApprovalLevelId,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssLevelNumber,cancellationToken);

// SendEmailSupplier_FolioEvidenceRequest
await Actions.ActionSendEmailSupplier_FolioEvidenceRequest(requestContext,localVars.inParami_FolioId,BuiltInFunction.GetUserId (),localVars.inParami_Comment,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
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

public static class FuncActionFolioEvidenceRequest {

private static async Task<RC_1b390f8e281aa018cfe8a81d34cdb757> datasetGetFolioByIdReadDbAsync(RC_1b390f8e281aa018cfe8a81d34cdb757 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" 09wTn0V0jU2IiyBxjX3Dpg of Action "FolioEvidenceRequest"
public static async Task<(RL_ae9182bb38290e8d92b0cbd2d4f71569,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApprovalLevel_Id,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioEvidenceRequest.GetFolioById", "9f13dcd3-7445-4d8d-888b-20718d7dc3a6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioEvidenceRequest.GetFolioById", "9f13dcd3-7445-4d8d-888b-20718d7dc3a6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.6dGk0gEZRkWxpYn_HRhUPg/NodesNotShownInESpaceTree.09wTn0V0jU2IiyBxjX3Dpg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio54\".\"id\" o0, \"enfolio54\".\"isdraft\" o1, \"enfolio54\".\"folionumber\" o2, \"enfolio54\".\"canproveedorcancel\" o3, \"enfolio54\".\"orderid\" o4, \"enfolio54\".\"supplierid\" o5, \"enfolio54\".\"companyid\" o6, \"enfolio54\".\"foliostatusid\" o7, trim_scale(\"enfolio54\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio54\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio54\".\"partialamount\"::numeric) o10, \"enfolio54\".\"currencyid\" o11, \"enfolio54\".\"firstapproveruserid\" o12, \"enfolio54\".\"approvalprocesstypeid\" o13, \"enfolio54\".\"sapentryerror\" o14, \"enfolio54\".\"createdby\" o15, \"enfolio54\".\"createdon\" o16, \"enfolio54\".\"updatedby\" o17, \"enfolio54\".\"updatedon\" o18, \"enfolio54\".\"minuteselected\" o19, \"enfolioapproval30\".\"id\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"enfolioapprovallevel27\".\"id\" o30, \"enfolioapprovallevel27\".\"folioapprovalid\" o31, \"enfolioapprovallevel27\".\"levelnumber\" o32, \"enfolioapprovallevel27\".\"applicationroleid\" o33, \"enfolioapprovallevel27\".\"entrajobtitle\" o34, \"enfolioapprovallevel27\".\"entraroleid\" o35, \"enfolioapprovallevel27\".\"departmentid\" o36, \"enfolioapprovallevel27\".\"assignedto\" o37, \"enfolioapprovallevel27\".\"approvalstatusid\" o38, \"enfolioapprovallevel27\".\"ismandatory\" o39, \"enfolioapprovallevel27\".\"isreassigned\" o40, \"enfolioapprovallevel27\".\"approvedby\" o41, \"enfolioapprovallevel27\".\"approvedon\" o42, \"enfolioapprovallevel27\".\"canceledby\" o43, \"enfolioapprovallevel27\".\"canceledon\" o44, \"enfolioapprovallevel27\".\"rejectedby\" o45, \"enfolioapprovallevel27\".\"rejectedon\" o46, \"enfolioapprovallevel27\".\"issubstitutefor\" o47, \"enfolioapprovallevel27\".\"rejectreason\" o48, \"enfolioapprovallevel27\".\"isinvoiceapproval\" o49");
fromBuilder.Append(" FROM (({Folio} \"enfolio54\" Left JOIN {FolioApproval} \"enfolioapproval30\" ON (\"enfolio54\".\"id\" = \"enfolioapproval30\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel27\" ON (\"enfolioapproval30\".\"id\" = \"enfolioapprovallevel27\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio54\".\"id\" = @qpfoFolio_Id) AND (\"enfolio54\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio54\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpfoFolioApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enfolioapprovallevel27\".\"id\" = @qpfoFolioApprovalLevel_Id) AND (\"enfolioapprovallevel27\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApprovalLevel_Id", DbType.Int64, qpfoFolioApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enfolioapprovallevel27\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioEvidenceRequest.GetFolioById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioEvidenceRequest.GetFolioById.List", cancellationToken: cancellationToken);
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
