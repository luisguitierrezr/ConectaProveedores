namespace ssConectaProveedores;

public partial class Actions {
public class lcvValidateLineByDocAndYear : VarsBag {
public string inParamI_DocNumber;
public int inParami_Year;
public RL_759d79b1f4cfae069cc62371125fee8f queryResGetProposalLinesByNDoc_outParamList = new RL_759d79b1f4cfae069cc62371125fee8f();
public long queryResGetProposalLinesByNDoc_outParamCount = 0L;

public lcvValidateLineByDocAndYear(string inParamI_DocNumber, int inParami_Year) {
this.inParamI_DocNumber = inParamI_DocNumber;
this.inParami_Year = inParami_Year;
}
}
public class lcoValidateLineByDocAndYear : VarsBag {
public bool outParamo_IsValid = true;

public lcoValidateLineByDocAndYear() {
}
}
/// <summary>
/// Action <code>ValidateLineByDocAndYear</code> that represents the Service Studio action
///  <code>ValidateLineByDocAndYear</code> <p> Description: Validate 54 documento per N doc and fisca
/// l year</p>
/// </summary>
public static async Task<bool> ActionValidateLineByDocAndYear(IRequestContext requestContext,string inParamI_DocNumber,int inParami_Year,CancellationToken cancellationToken) {
bool outParamo_IsValid = default;
lcoValidateLineByDocAndYear result = new lcoValidateLineByDocAndYear();
lcvValidateLineByDocAndYear localVars = new lcvValidateLineByDocAndYear(inParamI_DocNumber, inParami_Year);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ValidateLineByDocAndYear", "e85908a4-0ab4-4500-9284-b69a713b8842"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ValidateLineByDocAndYear", "e85908a4-0ab4-4500-9284-b69a713b8842", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetProposalLinesByNDoc
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalLinesByNDoc_maxRecords = 0;
int datasetGetProposalLinesByNDoc_startIndex = 0;(localVars.queryResGetProposalLinesByNDoc_outParamList,localVars.queryResGetProposalLinesByNDoc_outParamCount) = await FuncActionValidateLineByDocAndYear.datasetGetProposalLinesByNDoc(requestContext,datasetGetProposalLinesByNDoc_maxRecords,datasetGetProposalLinesByNDoc_startIndex,IterationMultiplicity.Never,localVars.inParamI_DocNumber,localVars.inParami_Year,cancellationToken);

// o_IsValid = GetProposalLinesByNDoc.List.Empty
result.outParamo_IsValid=localVars.queryResGetProposalLinesByNDoc_outParamList.Empty;
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsValid = result.outParamo_IsValid;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsValid;
}

public static class FuncActionValidateLineByDocAndYear {

private static async Task<RC_05f5be3a1430a1bea3f80a8be6d08c9b> datasetGetProposalLinesByNDocReadDbAsync(RC_05f5be3a1430a1bea3f80a8be6d08c9b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalLine.Read( r, ref index);
return rec;
}
// Query Function "GetProposalLinesByNDoc" 8qyK8bXw2EyU9Jf9wwVU3w of Action "ValidateLineByDocAndYear"
public static async Task<(RL_759d79b1f4cfae069cc62371125fee8f,long)> datasetGetProposalLinesByNDoc(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteProposalLine_N_doc_,int qpinProposalLine_Fe_contab_,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ValidateLineByDocAndYear.GetProposalLinesByNDoc", "f18aacf2-f0b5-4cd8-94f4-97fdc30554df");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ValidateLineByDocAndYear.GetProposalLinesByNDoc", "f18aacf2-f0b5-4cd8-94f4-97fdc30554df", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pAhZ6LQKAEWShLaacTuIQg/NodesNotShownInESpaceTree.8qyK8bXw2EyU9Jf9wwVU3w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45");
fromBuilder.Append(" FROM ({ProposalLine} \"enproposalline9\" Left JOIN {Proposal} \"enproposal14\" ON (\"enproposalline9\".\"proposalid\" = \"enproposal14\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enproposalline9\".\"n_doc_\" = @qpteProposalLine_N_doc_) AND ((extract(year from \"enproposalline9\".\"fe_contab_\"::timestamptz)) = @qpinProposalLine_Fe_contab_) AND ((\"enproposal14\".\"proposalstatusid\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId);
whereBuilder.Append(") AND (\"enproposal14\".\"proposalstatusid\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId);
whereBuilder.Append("))");
sqlCmd.CreateParameterWithoutReplacements("@qpteProposalLine_N_doc_", DbType.String, qpteProposalLine_N_doc_);
sqlCmd.CreateParameterWithoutReplacements("@qpinProposalLine_Fe_contab_", DbType.Int32, qpinProposalLine_Fe_contab_);
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
RL_759d79b1f4cfae069cc62371125fee8f outParamList = new RL_759d79b1f4cfae069cc62371125fee8f();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalLinesByNDocReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ValidateLineByDocAndYear.GetProposalLinesByNDoc.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_759d79b1f4cfae069cc62371125fee8f _tmp = new RL_759d79b1f4cfae069cc62371125fee8f();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalLinesByNDocReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ValidateLineByDocAndYear.GetProposalLinesByNDoc.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_759d79b1f4cfae069cc62371125fee8f)_tmp;
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
