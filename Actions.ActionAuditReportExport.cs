namespace ssConectaProveedores;

public partial class Actions {
public class lcvAuditReportExport : VarsBag {
public decimal inParami_AmountMLFrom_Filter;
public decimal inParami_AmountMLTo_Filter;
public long inParami_Bank_Filter;
public DateTime inParami_PaymentDate_FilterFrom;
public DateTime inParami_PaymentDate_FilterTo;
public string inParami_Region_Filter;
public string inParami_Status_Filter;
public int inParami_ProposalTypeId;
public string inParami_Currency_Filter;
public string inParami_Search_Filter;
public byte[] resRecordListToExcel_outParamOut = new byte[] {};
public RL_ac6f2bf176d0c2d218c3125f52f96430 queryResGetAuditProposalLines_outParamList = new RL_ac6f2bf176d0c2d218c3125f52f96430();
public long queryResGetAuditProposalLines_outParamCount = 0L;

public bool resCheckComissionesArrendamientosAdminRole_outParamHasRole = false;

public lcvAuditReportExport(decimal inParami_AmountMLFrom_Filter, decimal inParami_AmountMLTo_Filter, long inParami_Bank_Filter, DateTime inParami_PaymentDate_FilterFrom, DateTime inParami_PaymentDate_FilterTo, string inParami_Region_Filter, string inParami_Status_Filter, int inParami_ProposalTypeId, string inParami_Currency_Filter, string inParami_Search_Filter) {
this.inParami_AmountMLFrom_Filter = inParami_AmountMLFrom_Filter;
this.inParami_AmountMLTo_Filter = inParami_AmountMLTo_Filter;
this.inParami_Bank_Filter = inParami_Bank_Filter;
this.inParami_PaymentDate_FilterFrom = inParami_PaymentDate_FilterFrom;
this.inParami_PaymentDate_FilterTo = inParami_PaymentDate_FilterTo;
this.inParami_Region_Filter = inParami_Region_Filter;
this.inParami_Status_Filter = inParami_Status_Filter;
this.inParami_ProposalTypeId = inParami_ProposalTypeId;
this.inParami_Currency_Filter = inParami_Currency_Filter;
this.inParami_Search_Filter = inParami_Search_Filter;
}
}
public class lcoAuditReportExport : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = new ST_a158c76eb93396680623c04244f48b6cStructure();

public lcoAuditReportExport() {
}
}
/// <summary>
/// Action <code>AuditReportExport</code> that represents the Service Studio action
///  <code>AuditReportExport</code> <p> Description: Export all proposal lines audit including scree
/// n filters.</p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,ST_a158c76eb93396680623c04244f48b6cStructure)> ActionAuditReportExport(IRequestContext requestContext,decimal inParami_AmountMLFrom_Filter,decimal inParami_AmountMLTo_Filter,long inParami_Bank_Filter,DateTime inParami_PaymentDate_FilterFrom,DateTime inParami_PaymentDate_FilterTo,string inParami_Region_Filter,string inParami_Status_Filter,int inParami_ProposalTypeId,string inParami_Currency_Filter,string inParami_Search_Filter,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = default;
lcoAuditReportExport result = new lcoAuditReportExport();
lcvAuditReportExport localVars = new lcvAuditReportExport(inParami_AmountMLFrom_Filter, inParami_AmountMLTo_Filter, inParami_Bank_Filter, inParami_PaymentDate_FilterFrom, inParami_PaymentDate_FilterTo, inParami_Region_Filter, inParami_Status_Filter, inParami_ProposalTypeId, inParami_Currency_Filter, inParami_Search_Filter);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("AuditReportExport", "17387ea4-03ef-43c8-b865-f80d6b42bc81"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("AuditReportExport", "17387ea4-03ef-43c8-b865-f80d6b42bc81", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CheckComissionesArrendamientosAdminRole
localVars.resCheckComissionesArrendamientosAdminRole_outParamHasRole = await ExtendedActions.CheckComissionesArrendamientosAdminRole(requestContext,"",cancellationToken);

// has role?
if((localVars.resCheckComissionesArrendamientosAdminRole_outParamHasRole)) {
// Query QueryGetAuditProposalLines
cancellationToken.ThrowIfCancellationRequested();
int QueryGetAuditProposalLines_maxRecords = 0;
int QueryGetAuditProposalLines_startIndex = 0;(localVars.queryResGetAuditProposalLines_outParamList,localVars.queryResGetAuditProposalLines_outParamCount) = await FuncActionAuditReportExport.QueryGetAuditProposalLines(requestContext,QueryGetAuditProposalLines_maxRecords,QueryGetAuditProposalLines_startIndex,IterationMultiplicity.Single,localVars.inParami_AmountMLFrom_Filter,localVars.inParami_AmountMLTo_Filter,localVars.inParami_Bank_Filter,localVars.inParami_PaymentDate_FilterFrom,localVars.inParami_PaymentDate_FilterTo,localVars.inParami_Region_Filter,localVars.inParami_Status_Filter,localVars.inParami_Currency_Filter,localVars.inParami_Search_Filter,BuiltInFunction.NullDate (),(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId,localVars.inParami_ProposalTypeId,cancellationToken);

// Empty?
if((localVars.queryResGetAuditProposalLines_outParamList.Empty)) {
// Result
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Download not possible due to no records."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("k62d4WhZdkCsAYrGT3NemQ#Value.-1265885444.1", "Download not possible due to no records.");
} else {
// RecordListToExcel RLToExcelAuditReportExportRecordListToExcel
localVars.resRecordListToExcel_outParamOut = await FuncActionAuditReportExport.RLToExcelAuditReportExportRecordListToExcel(requestContext,localVars.queryResGetAuditProposalLines_outParamList,cancellationToken);

// Result
// o_File.Name = "ProposalsAuditoryReport" + ".xlsx"
result.outParamo_File.ssName = (AppUtils.GetStringResource("o39syb_rhUieMK_ycgVxHg#Value.-1272030128.1", "ProposalsAuditoryReport")+".xlsx");

// o_File.BinaryData = RecordListToExcel
result.outParamo_File.ssBinaryData = localVars.resRecordListToExcel_outParamOut;

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_Output.Message = "Download completed with success."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("0By1twHBXk6qMxLCq7rdZw#Value.1296943640.1", "Download completed with success.");
}

} else {
// o_Result
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "No permission. Contact administrator."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("VU1GsrwbzUqJGVDDk2u1Bg#Value.-1409656127.1", "No permission. Contact administrator.");
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
outParamo_File = result.outParamo_File;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamo_File);
}

public static class FuncActionAuditReportExport {

// Query Function "GetAuditProposalLines" VFtTZC0Hp06zW7reHbwSUA of Action "AuditReportExport"
public static async Task<(RL_ac6f2bf176d0c2d218c3125f52f96430,long)> QueryGetAuditProposalLines(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,decimal qpdei_AmountMLFrom_Filter,decimal qpdei_AmountMLTo_Filter,long qpbai_Bank_Filter,DateTime qpdai_PaymentDate_FilterFrom,DateTime qpdai_PaymentDate_FilterTo,string qptei_Region_Filter,string qptei_ProposalStatus_Filter,string qptei_Currency_Filter,string qptei_Search_Filter,DateTime qpdai_NullDate,int qppri_CanceledProposalStatus,int qppri_ErrorAPIStatus,int qppri_ProposalTypeId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("AuditReportExport.GetAuditProposalLines", "64535b54-072d-4ea7-b35b-bade1dbc1250");
using var queryActivity = activitySource.CreateSqlQueryActivity("AuditReportExport.GetAuditProposalLines", "64535b54-072d-4ea7-b35b-bade1dbc1250", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityProposalLine = AppUtils.Instance.RuntimeEntityReplace("ProposalLine");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityProposalType = AppUtils.Instance.RuntimeEntityReplace("ProposalType");
string entityProposalStatus = AppUtils.Instance.RuntimeEntityReplace("ProposalStatus");
string entityFileImportLog = AppUtils.Instance.RuntimeEntityReplace("FileImportLog");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityProposalLineApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("ProposalLineApprovalLevel");
string entityProposalApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("ProposalApprovalLevel");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
sqlCmd.CreateParameter("@qpdai_NullDate", DbType.DateTime, qpdai_NullDate);
sqlCmd.CreateParameter("@qppri_CanceledProposalStatus", DbType.Int32, qppri_CanceledProposalStatus);
sqlCmd.CreateParameter("@qppri_ErrorAPIStatus", DbType.Int32, qppri_ErrorAPIStatus);
sqlCmd.CreateParameter("@qpbai_Bank_Filter", DbType.Int64, qpbai_Bank_Filter);
sqlCmd.CreateParameter("@qpdei_AmountMLFrom_Filter", DbType.Decimal, qpdei_AmountMLFrom_Filter);
sqlCmd.CreateParameter("@qpdei_AmountMLTo_Filter", DbType.Decimal, qpdei_AmountMLTo_Filter);
sqlCmd.CreateParameter("@qpdai_PaymentDate_FilterFrom", DbType.DateTime, qpdai_PaymentDate_FilterFrom);
sqlCmd.CreateParameter("@qpdai_PaymentDate_FilterTo", DbType.DateTime, qpdai_PaymentDate_FilterTo);
sqlCmd.CreateParameter("@qptei_Region_Filter", DbType.String, qptei_Region_Filter);
sqlCmd.CreateParameter("@qptei_ProposalStatus_Filter", DbType.String, qptei_ProposalStatus_Filter);
sqlCmd.CreateParameter("@qptei_Currency_Filter", DbType.String, qptei_Currency_Filter);
sqlCmd.CreateParameter("@qppri_ProposalTypeId", DbType.Int32, qppri_ProposalTypeId);
sqlCmd.CreateParameter("@qptei_Search_Filter", DbType.String, qptei_Search_Filter);
string sql = "";
string advSql = "SELECT \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"soc_\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"name\"") + "                               AS Region, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"div_\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"referencia\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"name\"") + "                             AS ProposalName, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"label\"") + "                        AS ProposalType, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"label\"") + "                      AS ProposalStatus, \n    DATE( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"fe_contab_\"") + ")             AS PaymentDate, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"cuenta\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"nombre1\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"n_doc_\"") + ", \n    CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"importeenml\"") + " AS DECIMAL(18,2)), \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"ml\"") + ", \n    CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"importeenmd\"") + " AS DECIMAL(18,2)), \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"mon_\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileImportLog,".\"importtype\"") + "                  AS Upload, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"label\"") + "                      AS LineStatus, \n    Level1User.\"name\"                             AS Level1ApprovedBy, \n    CASE \n        WHEN Level1Approval.\"approvedon\"  = @qpdai_NullDate \n        THEN NULL \n        ELSE Level1Approval.\"approvedon\"  \n    END                                           AS Level1ApprovedOn, \n    Level2User.\"name\"                             AS Level2ApprovedBy, \n    CASE \n        WHEN Level2Approval.\"approvedon\"  = @qpdai_NullDate \n        THEN NULL \n        ELSE Level2Approval.\"approvedon\"  \n    END                                           AS Level2ApprovedOn, \n    Level3User.\"name\"                             AS Level3ApprovedBy, \n    CASE \n        WHEN Level3Approval.\"approvedon\"  = @qpdai_NullDate \n        THEN NULL \n    ELSE Level3Approval.\"approvedon\"  \n    END                                           AS Level3ApprovedOn, \n    PaidBy.\"name\"                                 AS PaidBy, \n    CASE \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"paidon\"") + " = @qpdai_NullDate \n        THEN NULL \n        ELSE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"paidon\"") + " \n    END                                           AS PaidOn \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileImportLog,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileImportLog,".\"fileid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"fileid\"") + " \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"proposalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"id\"") + " \n \n \nLEFT JOIN ( \n    SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"proposallineid\"") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvedby\"") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvedon\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,"") + " \n    JOIN   " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,"") + " \n        ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"proposalapprovallevelid\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,".\"levelnumber\"") + " = 1 \n) Level1Approval ON Level1Approval.\"proposallineid\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"id\"") + "  \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " Level1User \n    ON Level1User.\"id\" = Level1Approval.\"approvedby\" \n \n \n \nLEFT JOIN ( \n    SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"proposallineid\"") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvedby\"") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvedon\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,"") + " \n    JOIN   " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,"") + " \n        ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"proposalapprovallevelid\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,".\"levelnumber\"") + " = 2 \n) Level2Approval ON Level2Approval.\"proposallineid\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"id\"") + "  \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " Level2User \n    ON Level2User.\"id\" = Level2Approval.\"approvedby\" \n \n \n \nLEFT JOIN ( \n    SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"proposallineid\"") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvedby\"") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvedon\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,"") + " \n    JOIN   " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,"") + " \n        ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"proposalapprovallevelid\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalApprovalLevel,".\"levelnumber\"") + " = 3 \n) Level3Approval ON Level3Approval.\"proposallineid\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"id\"") + "  \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " Level3User \n    ON Level3User.\"id\" = Level3Approval.\"approvedby\" \n \n \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"approvalstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " PaidBy \n    ON PaidBy.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"paidby\"") + " \nWHERE  \n    ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " <> @qppri_CanceledProposalStatus OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " <> @qppri_ErrorAPIStatus) AND \n    (@qpbai_Bank_Filter = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"bankid\"") + " = @qpbai_Bank_Filter) AND \n    (@qpdei_AmountMLFrom_Filter = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + " >= @qpdei_AmountMLFrom_Filter) AND \n    (@qpdei_AmountMLTo_Filter = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + " <= @qpdei_AmountMLTo_Filter) AND \n    (@qpdai_PaymentDate_FilterFrom = @qpdai_NullDate OR CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + " AS DATE) >= @qpdai_PaymentDate_FilterFrom) AND (@qpdai_PaymentDate_FilterTo = @qpdai_NullDate OR CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + " AS DATE) <= @qpdai_PaymentDate_FilterTo) AND \n    (@qptei_Region_Filter::text = '()' OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + " = ANY(string_to_array(trim(both '()' from @qptei_Region_Filter::text), ',')::int[])) and \n    (@qptei_ProposalStatus_Filter::text = '()' OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " = ANY(string_to_array(trim(both '()' from @qptei_ProposalStatus_Filter::text), ',')::int[])) and \n    (@qptei_Currency_Filter::text  = '()' OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"currencyid\"") + " = ANY(string_to_array(trim(both '()' from @qptei_Currency_Filter::text), ',')::text[])) and \n    (@qppri_ProposalTypeId = 0 OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + " = @qppri_ProposalTypeId) AND \n    ( \n        @qptei_Search_Filter::text = '' \n        OR LOWER( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"name\"") + " COLLATE \"C\") LIKE LOWER(('%' || @qptei_Search_Filter::text || '%') COLLATE \"C\") \n    )";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_ac6f2bf176d0c2d218c3125f52f96430 outParamList = new RL_ac6f2bf176d0c2d218c3125f52f96430();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query AuditReportExport.GetAuditProposalLines.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ac6f2bf176d0c2d218c3125f52f96430 _tmp = new RL_ac6f2bf176d0c2d218c3125f52f96430();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query AuditReportExport.GetAuditProposalLines.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ac6f2bf176d0c2d218c3125f52f96430)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetAuditProposalLines in AuditReportExport in ConectaProveedores (SELECT      {ProposalLine}.[Soc_],      {Region}.[Name]                               AS Region,      {ProposalLine}.[Div_],      {ProposalLine}.[Referencia],      {Proposal}.[Name]                             AS ProposalName,      {ProposalType}.[Label]                        AS ProposalType,      {ProposalStatus}.[Label]                      AS ProposalStatus,      DATE({ProposalLine}.[Fe_contab_])             AS PaymentDate,      {ProposalLine}.[Cuenta],      {ProposalLine}.[Nombre1],      {ProposalLine}.[N_doc_],      CAST({ProposalLine}.[ImporteenML] AS DECIMAL(18,2)),      {ProposalLine}.[ML],      CAST({ProposalLine}.[ImporteenMD] AS DECIMAL(18,2)),      {ProposalLine}.[Mon_],      {FileImportLog}.[ImportType]                  AS Upload,      {ApprovalStatus}.[Label]                      AS LineStatus,      Level1User.[Name]                             AS Level1ApprovedBy,      CASE          WHEN Level1Approval.[ApprovedOn]  = @i_NullDate          THEN NULL          ELSE Level1A ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetAuditProposalLines in AuditReportExport in ConectaProveedores (SELECT      {ProposalLine}.[Soc_],      {Region}.[Name]                               AS Region,      {ProposalLine}.[Div_],      {ProposalLine}.[Referencia],      {Proposal}.[Name]                             AS ProposalName,      {ProposalType}.[Label]                        AS ProposalType,      {ProposalStatus}.[Label]                      AS ProposalStatus,      DATE({ProposalLine}.[Fe_contab_])             AS PaymentDate,      {ProposalLine}.[Cuenta],      {ProposalLine}.[Nombre1],      {ProposalLine}.[N_doc_],      CAST({ProposalLine}.[ImporteenML] AS DECIMAL(18,2)),      {ProposalLine}.[ML],      CAST({ProposalLine}.[ImporteenMD] AS DECIMAL(18,2)),      {ProposalLine}.[Mon_],      {FileImportLog}.[ImportType]                  AS Upload,      {ApprovalStatus}.[Label]                      AS LineStatus,      Level1User.[Name]                             AS Level1ApprovedBy,      CASE          WHEN Level1Approval.[ApprovedOn]  = @i_NullDate          THEN NULL          ELSE Level1A ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetAuditProposalLines in AuditReportExport in ConectaProveedores (SELECT      {ProposalLine}.[Soc_],      {Region}.[Name]                               AS Region,      {ProposalLine}.[Div_],      {ProposalLine}.[Referencia],      {Proposal}.[Name]                             AS ProposalName,      {ProposalType}.[Label]                        AS ProposalType,      {ProposalStatus}.[Label]                      AS ProposalStatus,      DATE({ProposalLine}.[Fe_contab_])             AS PaymentDate,      {ProposalLine}.[Cuenta],      {ProposalLine}.[Nombre1],      {ProposalLine}.[N_doc_],      CAST({ProposalLine}.[ImporteenML] AS DECIMAL(18,2)),      {ProposalLine}.[ML],      CAST({ProposalLine}.[ImporteenMD] AS DECIMAL(18,2)),      {ProposalLine}.[Mon_],      {FileImportLog}.[ImportType]                  AS Upload,      {ApprovalStatus}.[Label]                      AS LineStatus,      Level1User.[Name]                             AS Level1ApprovedBy,      CASE          WHEN Level1Approval.[ApprovedOn]  = @i_NullDate          THEN NULL          ELSE Level1A ...): " + aqExcep.Message));
}
}
}


/// <summary>
/// RecordList To Excel: RLToExcelAuditReportExportRecordListToExcel (KRRIvTiu9bU6Eoq14UXC1BQ) of
///  Action "AuditReportExport"
/// </summary>
public static async Task<byte[]> RLToExcelAuditReportExportRecordListToExcel(IRequestContext requestContext,RL_ac6f2bf176d0c2d218c3125f52f96430 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(25, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Soc.");
excel.CreateCell("Región");
excel.CreateCell("Div.");
excel.CreateCell("Ref");
excel.CreateCell("Nombre de la Propuesta");
excel.CreateCell("Tipo de Propuesta");
excel.CreateCell("Estado de Propuesta");
excel.CreateCell("Fecha de pago");
excel.CreateCell("Cuenta");
excel.CreateCell("Nombre Proveedor");
excel.CreateCell("N.doc.");
excel.CreateCell("Importe en ML");
excel.CreateCell("Moneda ML");
excel.CreateCell("Importe en MD");
excel.CreateCell("Moneda MD");
excel.CreateCell("Carga");
excel.CreateCell("Estatus pagado");
excel.CreateCell("Usuario Aprobador Nivel 1");
excel.CreateCell("Fecha Aprobacion Nivel 1");
excel.CreateCell("Usuario Aprobador Nivel 2");
excel.CreateCell("Fecha Aprobacion Nivel 2");
excel.CreateCell("Usuario Aprobador Nivel 3");
excel.CreateCell("Fecha Aprobacion Nivel 3");
excel.CreateCell("Usuario Tesorería");
excel.CreateCell("Fecha Tesorería");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssSoc_);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssRegion);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssDiv_);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssRef);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssProposalName);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssProposalType);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssProposalStatus);
excel.CreateCellDate(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssPaymentDate);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssCuenta);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssSupplierName);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssN_doc_);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssImporteenML);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssML);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssImporteenMD);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssMD);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssUpload);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssAppovedByUserLevel1);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssApprovedOnLevel1);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssAppovedByUserLevel2);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssApprovedOnLevel2);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssAppovedByUserLevel3);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssApprovedOnLevel3);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssTreasuryUser);
excel.CreateCell(ssRecordList.CurrentRec.ssSTAuditProposalsReportExportStruct.ssPaidOn);

            ssRecordList.Advance(); 
		}
	} finally {
		ssRecordList.EndIteration();
	}
}

return await excel.SaveAsync(cancellationToken);
}


}


}
