namespace ssConectaProveedores;

public partial class Actions {
public class lcvAddComment : VarsBag {
public EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord inParami_InvoiceComment;
public RL_bdfd519ca40e4329aaefd81b9f10ff89 queryResGetRoleConcept_outParamList = new RL_bdfd519ca40e4329aaefd81b9f10ff89();
public long queryResGetRoleConcept_outParamCount = 0L;

public Actions.lcoInvoiceCommentCreateOrUpdate resInvoiceCommentCreateOrUpdate =  new Actions.lcoInvoiceCommentCreateOrUpdate();
public lcvAddComment(EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord inParami_InvoiceComment) {
this.inParami_InvoiceComment = inParami_InvoiceComment;
}
}
public class lcoAddComment : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoAddComment() {
}
}
/// <summary>
/// Action <code>AddComment</code> that represents the Service Studio action <code>AddComment</code>
///  <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionAddComment(IRequestContext requestContext,EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord inParami_InvoiceComment,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoAddComment result = new lcoAddComment();
lcvAddComment localVars = new lcvAddComment(inParami_InvoiceComment);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("AddComment", "50e9bd3f-efad-4902-b737-8b22ea5dbb10"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("AddComment", "50e9bd3f-efad-4902-b737-8b22ea5dbb10", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 1;
if (datasetGetRoleConcept_maxRecords < 1) datasetGetRoleConcept_maxRecords = 1;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncActionAddComment.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// InvoiceCommentCreateOrUpdate
localVars.resInvoiceCommentCreateOrUpdate.outParamId = await Actions.ActionInvoiceCommentCreateOrUpdate(requestContext,new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceComment.ssInvoiceId, ssInvoiceApprovalLevelId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssApplicationRoleId = localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENRoleConcept.ssApplicationRoleId, ssMessage = localVars.inParami_InvoiceComment.ssMessage, ssIsPublic = localVars.inParami_InvoiceComment.ssIsPublic },cancellationToken);

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

public static class FuncActionAddComment {

private static async Task<RC_552c926b5ae43c594aa2b0762b255928> datasetGetRoleConceptReadDbAsync(RC_552c926b5ae43c594aa2b0762b255928 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetRoleConcept" 9QnbE6jGtEiAKEmSFioHWQ of Action "AddComment"
public static async Task<(RL_bdfd519ca40e4329aaefd81b9f10ff89,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("AddComment.GetRoleConcept", "13db09f5-c6a8-48b4-8028-4992162a0759");
using var queryActivity = activitySource.CreateAggregateQueryActivity("AddComment.GetRoleConcept", "13db09f5-c6a8-48b4-8028-4992162a0759", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.P73pUK3vAkm3N4si6l27EA/NodesNotShownInESpaceTree.9QnbE6jGtEiAKEmSFioHWQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enroleconcept2\".\"applicationroleid\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34");
fromBuilder.Append(" FROM ((({User_Extended_Internal} \"enuser_extended_internal32\" Inner JOIN {User} \"enuser54\" ON (\"enuser_extended_internal32\".\"id\" = \"enuser54\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole8\" ON (\"enuser_extended_internal32\".\"jobtitle\" = \"enentrarole8\".\"rolename\"))  Left JOIN {RoleConcept} \"enroleconcept2\" ON (\"enentrarole8\".\"id\" = \"enroleconcept2\".\"entraroleid\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser54\".\"id\" = @qpusUser_Id) AND (\"enuser54\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser54\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept2\".\"conceptid\" = ");
whereBuilder.Append(3
);
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
RL_bdfd519ca40e4329aaefd81b9f10ff89 outParamList = new RL_bdfd519ca40e4329aaefd81b9f10ff89();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query AddComment.GetRoleConcept.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bdfd519ca40e4329aaefd81b9f10ff89 _tmp = new RL_bdfd519ca40e4329aaefd81b9f10ff89();
_tmp.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query AddComment.GetRoleConcept.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bdfd519ca40e4329aaefd81b9f10ff89)_tmp;
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
