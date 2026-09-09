using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_m_Manuals_Help_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_m_Manuals_Help_ScreenModel).Namespace);

    public string varLcKeyword;
public string varLcTableSort;
public int varLcStartIndex;
public int varLcMaxRecords;
public bool varLcShowPopup;
public long varLcl_ManualId;
public AggregateRecord<RL_c03a84418d2a4ae38f50fab5e2cc796f> ScreenDataSetGetManuals;
public ConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Model varLcGetUserInfo;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_m_Manuals_Help_ScreenModel() {
}



    public ConectaProveedores_m_Manuals_Help_ScreenModel(string varLcKeyword, string varLcTableSort, int varLcStartIndex, int varLcMaxRecords, bool varLcShowPopup, long varLcl_ManualId, AggregateRecord<RL_c03a84418d2a4ae38f50fab5e2cc796f> ScreenDataSetGetManuals, ConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Model varLcGetUserInfo, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"Keyword", "TableSort", "StartIndex", "MaxRecords", "ShowPopup", "l_ManualId", "GetManuals", "GetUserInfo", "ClientVars"}, new string[] {"varLcKeyword", "varLcTableSort", "varLcStartIndex", "varLcMaxRecords", "varLcShowPopup", "varLcl_ManualId", "ScreenDataSetGetManuals", "varLcGetUserInfo", "clientVariables"});
this.varLcKeyword = varLcKeyword;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.varLcShowPopup = varLcShowPopup;
this.varLcl_ManualId = varLcl_ManualId;
this.ScreenDataSetGetManuals = ScreenDataSetGetManuals;
this.varLcGetUserInfo = varLcGetUserInfo;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_5e1572d574f8fe1e39bbadd50daaa59c> datasetGetManualsReadDbAsync(RC_5e1572d574f8fe1e39bbadd50daaa59c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssDescription = r.ReadText(index++, "DescriptionShortDescriptionTitleIsVideoStarIdRecord.Description", "");
rec.ssId = r.ReadEntityReferenceLongInteger(index++, "DescriptionShortDescriptionTitleIsVideoStarIdRecord.Id", 0L);
rec.ssIsVideo = r.ReadBoolean(index++, "DescriptionShortDescriptionTitleIsVideoStarIdRecord.IsVideo", false);
rec.ssShortDescription = r.ReadText(index++, "DescriptionShortDescriptionTitleIsVideoStarIdRecord.ShortDescription", "");
rec.ssStar = r.ReadBoolean(index++, "DescriptionShortDescriptionTitleIsVideoStarIdRecord.Star", false);
rec.ssTitle = r.ReadText(index++, "DescriptionShortDescriptionTitleIsVideoStarIdRecord.Title", "");
return rec;
}
// Query Function "GetManuals" FFqZTD2sjkyJ9XwpIQ6YrA of Action "Help"
public static async Task<(RL_c03a84418d2a4ae38f50fab5e2cc796f,long)> datasetGetManuals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckProveedorRole,bool qpboIsAreaCxP,string qpteKeyword,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("m_Manuals.Help.GetManuals", "4c995a14-ac3d-4c8e-89f5-7c29210e98ac");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Help","m_Manuals.Help.GetManuals");
// Query Iterations: Multiple
// Refresh Query vnmLylpkuEiZSGh5SKkL3A Iterations: Multiple
// Refresh Query NcFGg9l8fUyUlGobkuIROQ Iterations: Multiple
// Refresh Query QMsxjBTGu0awrWNKYy+xfA Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string sql = "";
string sqlCount = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.89mnu6g_g02tRDJNYbRrPw/NodesShownInESpaceTree.nX9nPvUhYkK8GVQHF0O49w/ScreenDataSets.FFqZTD2sjkyJ9XwpIQ6YrA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enmanuals1\".\"description\" \"description\", \"enmanuals1\".\"id\" \"id\", \"enmanuals1\".\"isvideo\" \"isvideo\", \"enmanuals1\".\"shortdescription\" \"shortdescription\", \"enmanuals1\".\"star\" \"star\", \"enmanuals1\".\"title\" \"title\"");
fromBuilder.Append(" FROM ((({Manuals} \"enmanuals1\" Left JOIN {Concept} \"enconcept1\" ON (\"enmanuals1\".\"conceptid\" = \"enconcept1\".\"id\"))  Left JOIN {AppConcept} \"enappconcept1\" ON (\"enmanuals1\".\"appconceptid\" = \"enappconcept1\".\"id\"))  Left JOIN {ManualUserArea} \"enmanualuserarea1\" ON (\"enmanuals1\".\"id\" = \"enmanualuserarea1\".\"manualid\")) ");
whereBuilder.Append(" WHERE (1 = 1) AND (\"enmanuals1\".\"appconceptid\" = ");
whereBuilder.Append(1
);
whereBuilder.Append(") AND ");
if (qpteKeyword != "" && qpteKeyword != "" && qpteKeyword != "") {
whereBuilder.Append("((caseaccent_normalize(\"enmanuals1\".\"title\" collate \"default\") like caseaccent_normalize((('%' || @qpteKeyword) || '%') collate \"default\")) OR (caseaccent_normalize(\"enmanuals1\".\"shortdescription\" collate \"default\") like caseaccent_normalize((('%' || @qpteKeyword) || '%') collate \"default\"))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteKeyword", DbType.String, qpteKeyword);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteKeyword", DbType.String, qpteKeyword);
}
whereBuilder.Append("(((@qpboCheckProveedorRole = 1) AND (\"enmanualuserarea1\".\"userareaid\" = ");
whereBuilder.Append(3
);
whereBuilder.Append(")) OR ((NOT (@qpboCheckProveedorRole = 1)) AND (((@qpboIsAreaCxP = 1) AND (\"enmanualuserarea1\".\"userareaid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(")) OR (\"enmanualuserarea1\".\"userareaid\" = ");
whereBuilder.Append(1
);
whereBuilder.Append("))))");
groupByBuilder.Append(" GROUP BY \"enmanuals1\".\"id\", \"enmanuals1\".\"isvideo\", \"enmanuals1\".\"title\", \"enmanuals1\".\"description\", \"enmanuals1\".\"star\", \"enmanuals1\".\"shortdescription\"");
orderByBuilder.Append(" ORDER BY 1 ASC");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckProveedorRole", DbType.Boolean, qpboCheckProveedorRole);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckProveedorRole", DbType.Boolean, qpboCheckProveedorRole);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsAreaCxP", DbType.Boolean, qpboIsAreaCxP);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsAreaCxP", DbType.Boolean, qpboIsAreaCxP);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
if (startIndex > 0) {
orderByBuilder.Append(" OFFSET ");
orderByBuilder.Append(startIndex);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCount = "SELECT COUNT(1) FROM (SELECT 1 as cnt " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString() + ") cnt";
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_c03a84418d2a4ae38f50fab5e2cc796f outParamList = new RL_c03a84418d2a4ae38f50fab5e2cc796f();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetManualsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query m_Manuals.Help.GetManuals.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query m_Manuals.Help.GetManuals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c03a84418d2a4ae38f50fab5e2cc796f _tmp = new RL_c03a84418d2a4ae38f50fab5e2cc796f();
_tmp.AlternateReadDbMethodAsync = datasetGetManualsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query m_Manuals.Help.GetManuals.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c03a84418d2a4ae38f50fab5e2cc796f)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query m_Manuals.Help.GetManuals.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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


    public class lcvGetUserInfo : VarsBag {
public Actions.lcoGetIsUserCxP resGetIsUserCxP =  new Actions.lcoGetIsUserCxP();
public lcvGetUserInfo() {
}
}
public class lcoGetUserInfo : VarsBag {
public bool outParamIsAreaCxP = false;

public lcoGetUserInfo() {
}
}
/// <summary>
/// Action <code>GetUserInfo</code> that represents the Service Studio action <code>GetUserInfo</code>
///  <p> Description: </p>
/// </summary>
public async Task<bool> DataActionGetUserInfo(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsAreaCxP = default;
lcoGetUserInfo result = new lcoGetUserInfo();
lcvGetUserInfo localVars = new lcvGetUserInfo();
ConectaProveedores_m_Manuals_Help_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserInfo", "d447e269-4cf9-4eb3-9f32-e30dc3c85195"))
using (activitySource.CreateScreenDataActionActivity("Help", "GetUserInfo")){
// GetIsUserCxP
localVars.resGetIsUserCxP.outParamo_Value = await Actions.ActionGetIsUserCxP(requestContext,cancellationToken);

// IsAreaCxP = GetIsUserCxP.o_Value
result.outParamIsAreaCxP=localVars.resGetIsUserCxP.outParamo_Value;
} //close CreateActionActivity using block
} // try

finally {
outParamIsAreaCxP = result.outParamIsAreaCxP;
} // inner-finally
RETURN_STATEMENT:
return outParamIsAreaCxP;
}


    public static class FuncDataActionGetUserInfo {
}


}
