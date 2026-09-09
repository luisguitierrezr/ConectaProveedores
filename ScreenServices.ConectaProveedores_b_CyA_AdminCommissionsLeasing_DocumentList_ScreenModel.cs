using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_ScreenModel).Namespace);

    public string varLcl_TableSort;
public int varLcl_StartIndex;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetProposalLines;
public ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Model varLcGetProposalLines;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_ScreenModel() {
}



    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_ScreenModel(string varLcl_TableSort, int varLcl_StartIndex, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetProposalLines, ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Model varLcGetProposalLines, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_TableSort", "l_StartIndex", "l_ReInvokeToggler", "l_ColumnJSONVarGetProposalLines", "GetProposalLines", "ClientVars"}, new string[] {"varLcl_TableSort", "varLcl_StartIndex", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetProposalLines", "varLcGetProposalLines", "clientVariables"});
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetProposalLines = varLcl_ColumnJSONVarGetProposalLines;
this.varLcGetProposalLines = varLcGetProposalLines;
this.clientVariables = clientVariables;
}



    

    public class lcvGetProposalLines : VarsBag {
public RL_3d7f0e13438b1662f16b29b5c58fbf9f queryResGetProposals_outParamList = new RL_3d7f0e13438b1662f16b29b5c58fbf9f();
public long queryResGetProposals_outParamCount = 0L;

public RLIntegerLiteralRecordList queryResGetProposalsCount_outParamList = new RLIntegerLiteralRecordList();
public long queryResGetProposalsCount_outParamCount = 0L;

public lcvGetProposalLines() {
}
}
public class lcoGetProposalLines : VarsBag {
public RL_3d7f0e13438b1662f16b29b5c58fbf9f outParamList = new RL_3d7f0e13438b1662f16b29b5c58fbf9f();

public long outParamCount = 0L;

public lcoGetProposalLines() {
}
}
/// <summary>
/// Action <code>GetProposalLines</code> that represents the Service Studio action
///  <code>GetProposalLines</code> <p> Description: </p>
/// </summary>
public async Task<(RL_3d7f0e13438b1662f16b29b5c58fbf9f,long)> DataActionGetProposalLines(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_3d7f0e13438b1662f16b29b5c58fbf9f outParamList = default;
long outParamCount = default;
lcoGetProposalLines result = new lcoGetProposalLines();
lcvGetProposalLines localVars = new lcvGetProposalLines();
ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetProposalLines", "f18e6278-d88d-480e-a4a2-ed57805ca5ca"))
using (activitySource.CreateScreenDataActionActivity("DocumentList", "GetProposalLines")){
// Query QueryGetProposals
cancellationToken.ThrowIfCancellationRequested();
int QueryGetProposals_maxRecords = 0;
int QueryGetProposals_startIndex = 0;(localVars.queryResGetProposals_outParamList,localVars.queryResGetProposals_outParamCount) = await FuncDataActionGetProposalLines.QueryGetProposals(requestContext,QueryGetProposals_maxRecords,QueryGetProposals_startIndex,IterationMultiplicity.Multiple,model.clientVariables.ssProposal_DocumentNumber,model.clientVariables.ssProposal_DocumentYear,model.clientVariables.ssMaxRecords,varLcl_StartIndex,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId,(await Functions.ActionEncodeSortForSQL(requestContext,varLcl_TableSort,cancellationToken)),cancellationToken);

// Query QueryGetProposalsCount
cancellationToken.ThrowIfCancellationRequested();
int QueryGetProposalsCount_maxRecords = 0;
int QueryGetProposalsCount_startIndex = 0;(localVars.queryResGetProposalsCount_outParamList,localVars.queryResGetProposalsCount_outParamCount) = await FuncDataActionGetProposalLines.QueryGetProposalsCount(requestContext,QueryGetProposalsCount_maxRecords,QueryGetProposalsCount_startIndex,IterationMultiplicity.Never,model.clientVariables.ssProposal_DocumentNumber,model.clientVariables.ssProposal_DocumentYear,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId,cancellationToken);

// List = GetProposals.List
result.outParamList=localVars.queryResGetProposals_outParamList;

// Count = GetProposalsCount.List.Current.IntegerLiteral.Value
result.outParamCount=localVars.queryResGetProposalsCount_outParamList.CurrentRec.ssSTIntegerLiteral.ssValue;
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
outParamCount = result.outParamCount;
} // inner-finally
RETURN_STATEMENT:
return (outParamList,outParamCount);
}


    public static class FuncDataActionGetProposalLines {

private static async Task<RC_ad5e17bc33d6c36e94593cff1d9300bb> QueryGetProposalsReadDbAsync(RC_ad5e17bc33d6c36e94593cff1d9300bb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposalLine.Read(r, ref index);
rec.ssENProposal.Read(r, ref index);
rec.ssENProposalStatus.Read(r, ref index);
rec.ssENApprovalStatus.Read(r, ref index);
rec.ssENProposalType.Read(r, ref index);
return rec;
}
// Query Function "GetProposals" 4iJRySLNGkuRCrm5o5eKcA of Action "GetProposalLines"
public static async Task<(RL_3d7f0e13438b1662f16b29b5c58fbf9f,long)> QueryGetProposals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteProposal_DocumentNumber,int qpinProposal_DocumentYear,int qpinMaxRecords,int qpinIndex,int qpprErrorAPI,int qpprCanceled,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("b_CyA_AdminCommissionsLeasing.DocumentList.GetProposalLines.GetProposals", "c95122e2-cd22-4b1a-910a-b9b9a3978a70");
using var queryActivity = activitySource.CreateSqlQueryActivity("b_CyA_AdminCommissionsLeasing.DocumentList.GetProposalLines.GetProposals", "c95122e2-cd22-4b1a-910a-b9b9a3978a70", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityProposalLine = AppUtils.Instance.RuntimeEntityReplace("ProposalLine");
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityProposalStatus = AppUtils.Instance.RuntimeEntityReplace("ProposalStatus");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityProposalType = AppUtils.Instance.RuntimeEntityReplace("ProposalType");
string entityProposalLineApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("ProposalLineApprovalLevel");
string entityProposalApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("ProposalApprovalLevel");
string entityProposalApproval = AppUtils.Instance.RuntimeEntityReplace("ProposalApproval");
sqlCmd.CreateParameter("@qpprErrorAPI", DbType.Int32, qpprErrorAPI);
sqlCmd.CreateParameter("@qpprCanceled", DbType.Int32, qpprCanceled);
sqlCmd.CreateParameter("@qpteProposal_DocumentNumber", DbType.String, qpteProposal_DocumentNumber);
sqlCmd.CreateParameter("@qpinProposal_DocumentYear", DbType.Int32, qpinProposal_DocumentYear);
sqlCmd.CreateParameter("@qpinMaxRecords", DbType.Int32, qpinMaxRecords);
sqlCmd.CreateParameter("@qpinIndex", DbType.Int32, qpinIndex);
string sql = "";
string advSql = "SELECT \n    " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"proposalid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"approvalstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"companyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"supplierid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"fe_contab_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"ej__mes\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"cuenta\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"referencia\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"nombre1\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"nombre2\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"n_doc_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"n_doctype\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"importeenml\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"ml\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"importeenmd\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"mon_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"soc_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"div_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"lib_mayor\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"textocab_documento\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"doc_comp_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"paidby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"paidon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"unpaidby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"unpaidon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"haserrors\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"errormessage\"") + ", \n    " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaldate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"bankid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"fileid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalproposallines\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvaluemd\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"currencyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"lastupdatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"maxdatepaymentchanges\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"assignedtoid\"") + ", \n    " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"class\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"is_active\"") + ", \n    " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"class\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"is_active\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"iscya\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"iscyaapproval\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"isreq\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"isinv\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"labeles\"") + ", \n    " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"is_active\"") + " \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,"") + " \n inner JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"proposallineid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"id\"") + " \n inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"proposalapprovallevelid\"") + "  and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,".\"levelnumber\"") + " = (SELECT MAX(PAL2.\"levelnumber\") \n                                                                                                                                                                                FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,"") + " PLAL2 \n                                                                                                                                                                                INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,"") + " PAL2  \n                                                                                                                                                                                    ON PAL2.\"id\" = PLAL2.\"proposalapprovallevelid\" \n                                                                                                                                                                                WHERE PLAL2.\"proposallineid\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"id\"") + " \n                                                                                                                                                                            ) \n inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApproval,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApproval,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,".\"proposalapprovalid\"") + " \n inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApproval,".\"proposalid\"") + " and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " <> @qpprErrorAPI AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " <> @qpprCanceled) \n left join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".Id") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " \n left join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvalstatusid\"") + " \n left join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + " \n     \nWHERE \n    ( \n      @qpteProposal_DocumentNumber::text = '' \n      OR ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"n_doc_\"") + "::text COLLATE \"C\") LIKE (('%' || @qpteProposal_DocumentNumber::text || '%') COLLATE \"C\") \n    ) \n    AND \n    ( \n       @qpinProposal_DocumentYear = 0  \n       OR EXTRACT(YEAR FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"fe_contab_\"") + ") = @qpinProposal_DocumentYear \n    ) \n \n    AND NOT ( \n        @qpinProposal_DocumentYear = 0 \n        AND @qpteProposal_DocumentNumber = '' \n    ) \n \n \n    ORDER BY  " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qpteTableSort)) + " \n    LIMIT @qpinMaxRecords::int \n    OFFSET @qpinIndex::int;";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_3d7f0e13438b1662f16b29b5c58fbf9f outParamList = new RL_3d7f0e13438b1662f16b29b5c58fbf9f();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = QueryGetProposalsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.DocumentList.GetProposalLines.GetProposals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3d7f0e13438b1662f16b29b5c58fbf9f _tmp = new RL_3d7f0e13438b1662f16b29b5c58fbf9f();
_tmp.AlternateReadDbMethodAsync = QueryGetProposalsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.DocumentList.GetProposalLines.GetProposals.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3d7f0e13438b1662f16b29b5c58fbf9f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetProposals in GetProposalLines in DocumentList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT     {ProposalLine}.*,     {Proposal}.*,     {ProposalStatus}.*,     {ApprovalStatus}.*,     {ProposalType}.*    FROM {ProposalLine}   inner JOIN {ProposalLineApprovalLevel} on {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]   inner join {ProposalApprovalLevel} on {ProposalApprovalLevel}.[Id] = {ProposalLineApprovalLevel}.[ProposalApprovalLevelId]  and {ProposalApprovalLevel}.[LevelNumber] = (SELECT MAX(PAL2.[LevelNumber])                                                                                                                                                                                  FROM {ProposalLineApprovalLevel} PLAL2                                                                                                                                                                                  INNER JOIN {ProposalApprovalLevel} PAL2                                                                                                                     ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProposals in GetProposalLines in DocumentList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT     {ProposalLine}.*,     {Proposal}.*,     {ProposalStatus}.*,     {ApprovalStatus}.*,     {ProposalType}.*    FROM {ProposalLine}   inner JOIN {ProposalLineApprovalLevel} on {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]   inner join {ProposalApprovalLevel} on {ProposalApprovalLevel}.[Id] = {ProposalLineApprovalLevel}.[ProposalApprovalLevelId]  and {ProposalApprovalLevel}.[LevelNumber] = (SELECT MAX(PAL2.[LevelNumber])                                                                                                                                                                                  FROM {ProposalLineApprovalLevel} PLAL2                                                                                                                                                                                  INNER JOIN {ProposalApprovalLevel} PAL2                                                                                                                     ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProposals in GetProposalLines in DocumentList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT     {ProposalLine}.*,     {Proposal}.*,     {ProposalStatus}.*,     {ApprovalStatus}.*,     {ProposalType}.*    FROM {ProposalLine}   inner JOIN {ProposalLineApprovalLevel} on {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]   inner join {ProposalApprovalLevel} on {ProposalApprovalLevel}.[Id] = {ProposalLineApprovalLevel}.[ProposalApprovalLevelId]  and {ProposalApprovalLevel}.[LevelNumber] = (SELECT MAX(PAL2.[LevelNumber])                                                                                                                                                                                  FROM {ProposalLineApprovalLevel} PLAL2                                                                                                                                                                                  INNER JOIN {ProposalApprovalLevel} PAL2                                                                                                                     ...): " + aqExcep.Message));
}
}
}

// Query Function "GetProposalsCount" +YPT+08r0E2prEVbtHCt6Q of Action "GetProposalLines"
public static async Task<(RLIntegerLiteralRecordList,long)> QueryGetProposalsCount(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteProposal_DocumentNumber,int qpinProposal_DocumentYear,int qpprErrorAPI,int qpprCanceled,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("b_CyA_AdminCommissionsLeasing.DocumentList.GetProposalLines.GetProposalsCount", "fbd383f9-2b4f-4dd0-a9ac-455bb470ade9");
using var queryActivity = activitySource.CreateSqlQueryActivity("b_CyA_AdminCommissionsLeasing.DocumentList.GetProposalLines.GetProposalsCount", "fbd383f9-2b4f-4dd0-a9ac-455bb470ade9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityProposalLine = AppUtils.Instance.RuntimeEntityReplace("ProposalLine");
string entityProposalLineApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("ProposalLineApprovalLevel");
string entityProposalApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("ProposalApprovalLevel");
string entityProposalApproval = AppUtils.Instance.RuntimeEntityReplace("ProposalApproval");
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityProposalStatus = AppUtils.Instance.RuntimeEntityReplace("ProposalStatus");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
sqlCmd.CreateParameter("@qpprErrorAPI", DbType.Int32, qpprErrorAPI);
sqlCmd.CreateParameter("@qpprCanceled", DbType.Int32, qpprCanceled);
sqlCmd.CreateParameter("@qpteProposal_DocumentNumber", DbType.String, qpteProposal_DocumentNumber);
sqlCmd.CreateParameter("@qpinProposal_DocumentYear", DbType.Int32, qpinProposal_DocumentYear);
string sql = "";
string advSql = "SELECT count(1) \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,"") + " \n inner JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"proposallineid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"id\"") + " \n inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"proposalapprovallevelid\"") + "  and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,".\"levelnumber\"") + " = (SELECT MAX(PAL2.\"levelnumber\") \n                                                                                                                                                                                FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,"") + " PLAL2 \n                                                                                                                                                                                INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,"") + " PAL2  \n                                                                                                                                                                                    ON PAL2.\"id\" = PLAL2.\"proposalapprovallevelid\" \n                                                                                                                                                                                WHERE PLAL2.\"proposallineid\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"id\"") + " \n                                                                                                                                                                            ) \n inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApproval,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApproval,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,".\"proposalapprovalid\"") + " \n inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApproval,".\"proposalid\"") + " and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " <> @qpprErrorAPI AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " <> @qpprCanceled) \n left join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".Id") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " \n left join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvalstatusid\"") + " \n     \nWHERE \n    ( \n      @qpteProposal_DocumentNumber::text = '' \n      OR ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"n_doc_\"") + "::text COLLATE \"C\") LIKE (('%' || @qpteProposal_DocumentNumber::text || '%') COLLATE \"C\") \n    ) \n    AND \n    ( \n       @qpinProposal_DocumentYear = 0  \n       OR EXTRACT(YEAR FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"fe_contab_\"") + ") = @qpinProposal_DocumentYear \n    ) \n \n    AND NOT ( \n        @qpinProposal_DocumentYear = 0 \n        AND @qpteProposal_DocumentNumber = '' \n    );";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RLIntegerLiteralRecordList outParamList = new RLIntegerLiteralRecordList();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.DocumentList.GetProposalLines.GetProposalsCount.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RLIntegerLiteralRecordList _tmp = new RLIntegerLiteralRecordList();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.DocumentList.GetProposalLines.GetProposalsCount.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RLIntegerLiteralRecordList)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetProposalsCount in GetProposalLines in DocumentList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT count(1)    FROM {ProposalLine}   inner JOIN {ProposalLineApprovalLevel} on {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]   inner join {ProposalApprovalLevel} on {ProposalApprovalLevel}.[Id] = {ProposalLineApprovalLevel}.[ProposalApprovalLevelId]  and {ProposalApprovalLevel}.[LevelNumber] = (SELECT MAX(PAL2.[LevelNumber])                                                                                                                                                                                  FROM {ProposalLineApprovalLevel} PLAL2                                                                                                                                                                                  INNER JOIN {ProposalApprovalLevel} PAL2                                                                                                                                                                                       ON PAL2.[Id] = PLAL2.[ProposalApp ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProposalsCount in GetProposalLines in DocumentList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT count(1)    FROM {ProposalLine}   inner JOIN {ProposalLineApprovalLevel} on {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]   inner join {ProposalApprovalLevel} on {ProposalApprovalLevel}.[Id] = {ProposalLineApprovalLevel}.[ProposalApprovalLevelId]  and {ProposalApprovalLevel}.[LevelNumber] = (SELECT MAX(PAL2.[LevelNumber])                                                                                                                                                                                  FROM {ProposalLineApprovalLevel} PLAL2                                                                                                                                                                                  INNER JOIN {ProposalApprovalLevel} PAL2                                                                                                                                                                                       ON PAL2.[Id] = PLAL2.[ProposalApp ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProposalsCount in GetProposalLines in DocumentList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT count(1)    FROM {ProposalLine}   inner JOIN {ProposalLineApprovalLevel} on {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]   inner join {ProposalApprovalLevel} on {ProposalApprovalLevel}.[Id] = {ProposalLineApprovalLevel}.[ProposalApprovalLevelId]  and {ProposalApprovalLevel}.[LevelNumber] = (SELECT MAX(PAL2.[LevelNumber])                                                                                                                                                                                  FROM {ProposalLineApprovalLevel} PLAL2                                                                                                                                                                                  INNER JOIN {ProposalApprovalLevel} PAL2                                                                                                                                                                                       ON PAL2.[Id] = PLAL2.[ProposalApp ...): " + aqExcep.Message));
}
}
}
}


}
