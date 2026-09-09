namespace ssConectaProveedores;

public partial class Actions {
public class lcvPreviousMonthProposalsExport : VarsBag {
/// <summary>
/// Variable <code>l_ExportedProposalList</code> that represents the Service Studio
///  ExportDisplayedProposalsStructList <code>l_ExportedProposalList</code> <p>Description: Proposa
/// l List variable to ajust excel columns.</p>
/// </summary>
public RL_a47850dd2118e9d03f96b793e5fcd15c varLcl_ExportedProposalList = new RL_a47850dd2118e9d03f96b793e5fcd15c();

public byte[] resRecordListToExcel_outParamOut = new byte[] {};
public RL_9bdbb2510ba9631c463489d3cd2e112b queryResGetProposals_outParamList = new RL_9bdbb2510ba9631c463489d3cd2e112b();
public long queryResGetProposals_outParamCount = 0L;

public bool resCheckComissionesArrendamientosAdminRole_outParamHasRole = false;

public lcvPreviousMonthProposalsExport() {
}
}
public class lcoPreviousMonthProposalsExport : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = new ST_a158c76eb93396680623c04244f48b6cStructure();

public lcoPreviousMonthProposalsExport() {
}
}
/// <summary>
/// Action <code>PreviousMonthProposalsExport</code> that represents the Service Studio action
///  <code>PreviousMonthProposalsExport</code> <p> Description: Export all proposals from the previou
/// s month.</p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,ST_a158c76eb93396680623c04244f48b6cStructure)> ActionPreviousMonthProposalsExport(IRequestContext requestContext,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = default;
lcoPreviousMonthProposalsExport result = new lcoPreviousMonthProposalsExport();
lcvPreviousMonthProposalsExport localVars = new lcvPreviousMonthProposalsExport();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("PreviousMonthProposalsExport", "934fab42-6008-4256-9274-4d6153cf20b6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("PreviousMonthProposalsExport", "934fab42-6008-4256-9274-4d6153cf20b6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CheckComissionesArrendamientosAdminRole
localVars.resCheckComissionesArrendamientosAdminRole_outParamHasRole = await ExtendedActions.CheckComissionesArrendamientosAdminRole(requestContext,"",cancellationToken);

// has role?
if((localVars.resCheckComissionesArrendamientosAdminRole_outParamHasRole)) {
// Query QueryGetProposals
cancellationToken.ThrowIfCancellationRequested();
int QueryGetProposals_maxRecords = 999999999;
if (QueryGetProposals_maxRecords < 1) QueryGetProposals_maxRecords = 1;
int QueryGetProposals_startIndex = 0;(localVars.queryResGetProposals_outParamList,localVars.queryResGetProposals_outParamCount) = await FuncActionPreviousMonthProposalsExport.QueryGetProposals(requestContext,QueryGetProposals_maxRecords,QueryGetProposals_startIndex,IterationMultiplicity.Multiple,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("t1jXoCYmMkuMIabV4nC9iA"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId,BuiltInFunction.NullTextIdentifier (),(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("WSrbHwGzvEKPytCj7doVWw"))).ssId,cancellationToken);

// Empty?
if((localVars.queryResGetProposals_outParamList.Empty)) {
// Result
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Download not possible due to no records."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("0coaITQDhEG5u4lFmRcBVA#Value.-1265885444.1", "Download not possible due to no records.");
} else {
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_ExportedProposalList,(await RL_a47850dd2118e9d03f96b793e5fcd15c.ConvertAsync(localVars.queryResGetProposals_outParamList, new RL_a47850dd2118e9d03f96b793e5fcd15c(), async (RC_1cb14075fc17c6595e88321dd320acf3 source, ST_1c87550db65690e27fa2476539c804c3Structure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),cancellationToken);

// RecordListToExcel RLToExcelPreviousMonthProposalsExportRecordListToExcel
localVars.resRecordListToExcel_outParamOut = await FuncActionPreviousMonthProposalsExport.RLToExcelPreviousMonthProposalsExportRecordListToExcel(requestContext,localVars.varLcl_ExportedProposalList,cancellationToken);

// Result
// o_File.Name = "PreviousMonthProposalsReport" + ".xlsx"
result.outParamo_File.ssName = (AppUtils.GetStringResource("WCbE9sZR20eq2yXPx5rIeQ#Value.-1343371412.1", "PreviousMonthProposalsReport")+".xlsx");

// o_File.BinaryData = RecordListToExcel
result.outParamo_File.ssBinaryData = localVars.resRecordListToExcel_outParamOut;

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_Output.Message = "Download completed with success."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("HNdXVrzImU2iOM9dLCJ8Pg#Value.1296943640.1", "Download completed with success.");
}

} else {
// o_Result
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "No permission. Contact administrator."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("VchvAr58j0m3r6AwhdHcVQ#Value.-1409656127.1", "No permission. Contact administrator.");
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

public static class FuncActionPreviousMonthProposalsExport {

// Query Function "GetProposals" mjCdpw8PsUWd2RAm8ht_lg of Action "PreviousMonthProposalsExport"
public static async Task<(RL_9bdbb2510ba9631c463489d3cd2e112b,long)> QueryGetProposals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpprProposalStatusPaid,int qpprProposalStatusPartiallyPaid,string qpteNullTextIdentifier,int qpapProposalLinePaid,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("PreviousMonthProposalsExport.GetProposals", "a79d309a-0f0f-45b1-9dd9-1026f21b7f96");
using var queryActivity = activitySource.CreateSqlQueryActivity("PreviousMonthProposalsExport.GetProposals", "a79d309a-0f0f-45b1-9dd9-1026f21b7f96", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityProposalLine = AppUtils.Instance.RuntimeEntityReplace("ProposalLine");
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityProposalType = AppUtils.Instance.RuntimeEntityReplace("ProposalType");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityBank = AppUtils.Instance.RuntimeEntityReplace("Bank");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityProposalStatus = AppUtils.Instance.RuntimeEntityReplace("ProposalStatus");
string entityFileImportLog = AppUtils.Instance.RuntimeEntityReplace("FileImportLog");
string entityFileExtended = AppUtils.Instance.RuntimeEntityReplace("FileExtended");
sqlCmd.CreateParameter("@qpapProposalLinePaid", DbType.Int32, qpapProposalLinePaid);
sqlCmd.CreateParameter("@qpteNullTextIdentifier", DbType.String, qpteNullTextIdentifier);
sqlCmd.CreateParameter("@qpprProposalStatusPaid", DbType.Int32, qpprProposalStatusPaid);
sqlCmd.CreateParameter("@qpprProposalStatusPartiallyPaid", DbType.Int32, qpprProposalStatusPartiallyPaid);
string sql = "";
string advSql = "WITH ProposalLinesAmount AS ( \n    SELECT \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"proposalid\"") + " AS ProposalId, \n        SUM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"importeenml\"") + ") AS ImporteenML, \n        SUM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"importeenmd\"") + ") AS ImporteenMD \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,"") + "  \n    WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"approvalstatusid\"") + " <> @qpapProposalLinePaid::int \n    GROUP BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"proposalid\"") + " \n) \n \nSELECT \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"name\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"label\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"createdon\"") + ", \n    ( \n    CASE \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"id\"") + " = @qpteNullTextIdentifier::text \n        THEN 'API' \n        ELSE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"name\"") + " \n    END \n    ), \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"name\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"name\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + " - COALESCE(ProposalLinesAmount.ImporteenML, 0), \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + " - COALESCE(ProposalLinesAmount.ImporteenMD, 0), \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"name\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"label\"") + ", \n    ( \n    CASE \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileImportLog,".\"importtype\"") + " <> '' \n        THEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileImportLog,".\"importtype\"") + " \n        ELSE 'Automatic' \n    END \n    ) \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"fileid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileImportLog,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileImportLog,".\"fileid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"currencyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"bankid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + " \nLEFT JOIN ProposalLinesAmount ON ProposalLinesAmount.ProposalId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"id\"") + " \nWHERE \n     \n    EXTRACT(MONTH FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + ") = \n        EXTRACT(MONTH FROM CURRENT_DATE - INTERVAL '1 month') \n    AND \n    EXTRACT(YEAR FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + ") = \n        EXTRACT(YEAR FROM CURRENT_DATE - INTERVAL '1 month') \n    AND \n    ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " = @qpprProposalStatusPaid::int OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " = @qpprProposalStatusPartiallyPaid::int) \nORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"order\"") + "";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_9bdbb2510ba9631c463489d3cd2e112b outParamList = new RL_9bdbb2510ba9631c463489d3cd2e112b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query PreviousMonthProposalsExport.GetProposals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9bdbb2510ba9631c463489d3cd2e112b _tmp = new RL_9bdbb2510ba9631c463489d3cd2e112b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query PreviousMonthProposalsExport.GetProposals.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9bdbb2510ba9631c463489d3cd2e112b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetProposals in PreviousMonthProposalsExport in ConectaProveedores (WITH ProposalLinesAmount AS (      SELECT          {ProposalLine}.[ProposalId] AS ProposalId,          SUM({ProposalLine}.[ImporteenML]) AS ImporteenML,          SUM({ProposalLine}.[ImporteenMD]) AS ImporteenMD      FROM {ProposalLine}       WHERE {ProposalLine}.[ApprovalStatusId] <> @ProposalLinePaid::int      GROUP BY {ProposalLine}.[ProposalId]  )    SELECT      {Proposal}.[Name],      {ProposalType}.[Label],      {Proposal}.[CreatedOn],      (      CASE          WHEN {User}.[Id] = @NullTextIdentifier::text          THEN 'API'          ELSE {User}.[Name]      END      ),      {Proposal}.[PaymentDate],      {Bank}.[Name],      {Region}.[Name],      {Proposal}.[TotalValueML] - COALESCE(ProposalLinesAmount.ImporteenML, 0),      {Proposal}.[TotalValueML] - COALESCE(ProposalLinesAmount.ImporteenMD, 0),      {Currency}.[Name],      {ProposalStatus}.[Label],      (      CASE          WHEN {FileImportLog}.[ImportType] <> ''          THEN {FileImportLog}.[ImportType]          ELSE 'Automatic ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProposals in PreviousMonthProposalsExport in ConectaProveedores (WITH ProposalLinesAmount AS (      SELECT          {ProposalLine}.[ProposalId] AS ProposalId,          SUM({ProposalLine}.[ImporteenML]) AS ImporteenML,          SUM({ProposalLine}.[ImporteenMD]) AS ImporteenMD      FROM {ProposalLine}       WHERE {ProposalLine}.[ApprovalStatusId] <> @ProposalLinePaid::int      GROUP BY {ProposalLine}.[ProposalId]  )    SELECT      {Proposal}.[Name],      {ProposalType}.[Label],      {Proposal}.[CreatedOn],      (      CASE          WHEN {User}.[Id] = @NullTextIdentifier::text          THEN 'API'          ELSE {User}.[Name]      END      ),      {Proposal}.[PaymentDate],      {Bank}.[Name],      {Region}.[Name],      {Proposal}.[TotalValueML] - COALESCE(ProposalLinesAmount.ImporteenML, 0),      {Proposal}.[TotalValueML] - COALESCE(ProposalLinesAmount.ImporteenMD, 0),      {Currency}.[Name],      {ProposalStatus}.[Label],      (      CASE          WHEN {FileImportLog}.[ImportType] <> ''          THEN {FileImportLog}.[ImportType]          ELSE 'Automatic ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProposals in PreviousMonthProposalsExport in ConectaProveedores (WITH ProposalLinesAmount AS (      SELECT          {ProposalLine}.[ProposalId] AS ProposalId,          SUM({ProposalLine}.[ImporteenML]) AS ImporteenML,          SUM({ProposalLine}.[ImporteenMD]) AS ImporteenMD      FROM {ProposalLine}       WHERE {ProposalLine}.[ApprovalStatusId] <> @ProposalLinePaid::int      GROUP BY {ProposalLine}.[ProposalId]  )    SELECT      {Proposal}.[Name],      {ProposalType}.[Label],      {Proposal}.[CreatedOn],      (      CASE          WHEN {User}.[Id] = @NullTextIdentifier::text          THEN 'API'          ELSE {User}.[Name]      END      ),      {Proposal}.[PaymentDate],      {Bank}.[Name],      {Region}.[Name],      {Proposal}.[TotalValueML] - COALESCE(ProposalLinesAmount.ImporteenML, 0),      {Proposal}.[TotalValueML] - COALESCE(ProposalLinesAmount.ImporteenMD, 0),      {Currency}.[Name],      {ProposalStatus}.[Label],      (      CASE          WHEN {FileImportLog}.[ImportType] <> ''          THEN {FileImportLog}.[ImportType]          ELSE 'Automatic ...): " + aqExcep.Message));
}
}
}


/// <summary>
/// RecordList To Excel: RLToExcelPreviousMonthProposalsExportRecordListToExcel
///  (Ku9NaftHHVEyd3FuF5Eo2Yg) of Action "PreviousMonthProposalsExport"
/// </summary>
public static async Task<byte[]> RLToExcelPreviousMonthProposalsExportRecordListToExcel(IRequestContext requestContext,RL_a47850dd2118e9d03f96b793e5fcd15c ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(11, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Nombre de la propuesta");
excel.CreateCell("Tipo de propuesta");
excel.CreateCell("Fecha de carga");
excel.CreateCell("Fecha de pago");
excel.CreateCell("Banco");
excel.CreateCell("Región");
excel.CreateCell("Importe ML");
excel.CreateCell("Importe MD");
excel.CreateCell("Moneda");
excel.CreateCell("Estatus");
excel.CreateCell("Carga");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssProposalName);
excel.CreateCell(ssRecordList.CurrentRec.ssProposalType);
excel.CreateCellDate(ssRecordList.CurrentRec.ssUploadedDate);
excel.CreateCellDate(ssRecordList.CurrentRec.ssPaymentDate);
excel.CreateCell(ssRecordList.CurrentRec.ssBank);
excel.CreateCell(ssRecordList.CurrentRec.ssRegion);
excel.CreateCell(ssRecordList.CurrentRec.ssAmountML);
excel.CreateCell(ssRecordList.CurrentRec.ssAmountMD);
excel.CreateCell(ssRecordList.CurrentRec.ssCurrency);
excel.CreateCell(ssRecordList.CurrentRec.ssStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssUploadType);

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
