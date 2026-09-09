namespace ssConectaProveedores;

public partial class Actions {
public class lcvFilteredProposalsExport : VarsBag {
public decimal inParami_AmountMLFrom_Filter;
public decimal inParami_AmountMLTo_Filter;
public long inParami_Bank_Filter;
public DateTime inParami_PaymentDate_FilterFrom;
public DateTime inParami_PaymentDate_FilterTo;
public string inParami_Region_Filter;
public string inParami_Status_Filter;
public string inParami_Currency_Filter;
public string inParami_TableSort;
public string inParami_Search_Filter;
public int inParami_UploadType;
public int inParami_ProposalTypeId;
/// <summary>
/// Variable <code>l_ExportedProposalList</code> that represents the Service Studio
///  ExportDisplayedProposalsStructList <code>l_ExportedProposalList</code> <p>Description: Proposa
/// l List variable to ajust excel columns.</p>
/// </summary>
public RL_a47850dd2118e9d03f96b793e5fcd15c varLcl_ExportedProposalList = new RL_a47850dd2118e9d03f96b793e5fcd15c();

public RL_edee1bf5e5c171ee5ed6daf5087975b0 queryResGetProposals_outParamList = new RL_edee1bf5e5c171ee5ed6daf5087975b0();
public long queryResGetProposals_outParamCount = 0L;

public bool resCheckComissionesArrendamientosAdminRole_outParamHasRole = false;

public byte[] resRecordListToExcel1_outParamOut = new byte[] {};
public lcvFilteredProposalsExport(decimal inParami_AmountMLFrom_Filter, decimal inParami_AmountMLTo_Filter, long inParami_Bank_Filter, DateTime inParami_PaymentDate_FilterFrom, DateTime inParami_PaymentDate_FilterTo, string inParami_Region_Filter, string inParami_Status_Filter, string inParami_Currency_Filter, string inParami_TableSort, string inParami_Search_Filter, int inParami_UploadType, int inParami_ProposalTypeId) {
this.inParami_AmountMLFrom_Filter = inParami_AmountMLFrom_Filter;
this.inParami_AmountMLTo_Filter = inParami_AmountMLTo_Filter;
this.inParami_Bank_Filter = inParami_Bank_Filter;
this.inParami_PaymentDate_FilterFrom = inParami_PaymentDate_FilterFrom;
this.inParami_PaymentDate_FilterTo = inParami_PaymentDate_FilterTo;
this.inParami_Region_Filter = inParami_Region_Filter;
this.inParami_Status_Filter = inParami_Status_Filter;
this.inParami_Currency_Filter = inParami_Currency_Filter;
this.inParami_TableSort = inParami_TableSort;
this.inParami_Search_Filter = inParami_Search_Filter;
this.inParami_UploadType = inParami_UploadType;
this.inParami_ProposalTypeId = inParami_ProposalTypeId;
}
}
public class lcoFilteredProposalsExport : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = new ST_a158c76eb93396680623c04244f48b6cStructure();

public lcoFilteredProposalsExport() {
}
}
/// <summary>
/// Action <code>FilteredProposalsExport</code> that represents the Service Studio action
///  <code>FilteredProposalsExport</code> <p> Description: Export all proposals filtered in proposal
/// s list screen.</p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,ST_a158c76eb93396680623c04244f48b6cStructure)> ActionFilteredProposalsExport(IRequestContext requestContext,decimal inParami_AmountMLFrom_Filter,decimal inParami_AmountMLTo_Filter,long inParami_Bank_Filter,DateTime inParami_PaymentDate_FilterFrom,DateTime inParami_PaymentDate_FilterTo,string inParami_Region_Filter,string inParami_Status_Filter,string inParami_Currency_Filter,string inParami_TableSort,string inParami_Search_Filter,int inParami_UploadType,int inParami_ProposalTypeId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = default;
lcoFilteredProposalsExport result = new lcoFilteredProposalsExport();
lcvFilteredProposalsExport localVars = new lcvFilteredProposalsExport(inParami_AmountMLFrom_Filter, inParami_AmountMLTo_Filter, inParami_Bank_Filter, inParami_PaymentDate_FilterFrom, inParami_PaymentDate_FilterTo, inParami_Region_Filter, inParami_Status_Filter, inParami_Currency_Filter, inParami_TableSort, inParami_Search_Filter, inParami_UploadType, inParami_ProposalTypeId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FilteredProposalsExport", "71963288-4c2b-4847-b111-cf8921d76a40"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FilteredProposalsExport", "71963288-4c2b-4847-b111-cf8921d76a40", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CheckComissionesArrendamientosAdminRole
localVars.resCheckComissionesArrendamientosAdminRole_outParamHasRole = await ExtendedActions.CheckComissionesArrendamientosAdminRole(requestContext,"",cancellationToken);

// has role?
if((localVars.resCheckComissionesArrendamientosAdminRole_outParamHasRole)) {
// Query QueryGetProposals
cancellationToken.ThrowIfCancellationRequested();
int QueryGetProposals_maxRecords = 0;
int QueryGetProposals_startIndex = 0;(localVars.queryResGetProposals_outParamList,localVars.queryResGetProposals_outParamCount) = await FuncActionFilteredProposalsExport.QueryGetProposals(requestContext,QueryGetProposals_maxRecords,QueryGetProposals_startIndex,IterationMultiplicity.Multiple,(("("+localVars.inParami_Region_Filter)+")"),localVars.inParami_Bank_Filter,localVars.inParami_AmountMLFrom_Filter,localVars.inParami_AmountMLTo_Filter,localVars.inParami_PaymentDate_FilterFrom,localVars.inParami_PaymentDate_FilterTo,(("("+localVars.inParami_Status_Filter)+")"),(("("+localVars.inParami_Currency_Filter)+")"),localVars.inParami_Search_Filter,localVars.inParami_UploadType,localVars.inParami_ProposalTypeId,BuiltInFunction.NullDate (),(await Functions.ActionEncodeSortForSQL(requestContext,localVars.inParami_TableSort,cancellationToken)),cancellationToken);

// Empty?
if((localVars.queryResGetProposals_outParamList.Empty)) {
// Result
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Download not possible due to no records."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("3SlXxIZssEa0HbY3wjpqJg#Value.-1265885444.1", "Download not possible due to no records.");
} else {
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_ExportedProposalList,(await RL_a47850dd2118e9d03f96b793e5fcd15c.ConvertAsync(localVars.queryResGetProposals_outParamList, new RL_a47850dd2118e9d03f96b793e5fcd15c(), async (RC_ab84a2ae7d846dd330e85891435fa3cb source, ST_1c87550db65690e27fa2476539c804c3Structure target, CancellationToken cancellationToken) => {
target.ssProposalName = source.ssENProposal.ssName;
target.ssProposalType = source.ssENProposalType.ssLabel;
target.ssUploadedDate = BuiltInFunction.DateTimeToDate(source.ssENProposal.ssCreatedOn);
target.ssUploadedby = (((source.ssENUploadedBy.ssId==BuiltInFunction.NullTextIdentifier ())) ? ("API") : (source.ssENUploadedBy.ssName));
target.ssPaymentDate = source.ssENProposal.ssPaymentDate;
target.ssBank = source.ssENBank.ssName;
target.ssRegion = source.ssENRegion.ssName;
target.ssAmountML = source.ssENProposal.ssTotalValueML;
target.ssAmountMD = source.ssENProposal.ssTotalValueMD;
target.ssCurrency = source.ssENCurrency.ssCode;
target.ssStatus = source.ssENProposalStatus.ssLabel;
target.ssUploadType = source.ssENFileImportLog.ssImportType;
return target;
}, cancellationToken)),cancellationToken);

// RecordListToExcel RLToExcelFilteredProposalsExportRecordListToExcel1
localVars.resRecordListToExcel1_outParamOut = await FuncActionFilteredProposalsExport.RLToExcelFilteredProposalsExportRecordListToExcel1(requestContext,localVars.varLcl_ExportedProposalList,cancellationToken);

// Result
// o_File.Name = "ProposalsReport" + ".xlsx"
result.outParamo_File.ssName = (AppUtils.GetStringResource("xmM9DngA30O9xMSiGgmEtw#Value.336549941.1", "ProposalsReport")+".xlsx");

// o_File.BinaryData = RecordListToExcel1
result.outParamo_File.ssBinaryData = localVars.resRecordListToExcel1_outParamOut;

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_Output.Message = "Download completed with success."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("+ro1fq5l8UqYz49hQY9C6A#Value.1296943640.1", "Download completed with success.");
}

} else {
// o_Result
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "No permission. Contact administrator."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("yzb_PeCU6UesrSXACd6atA#Value.-1409656127.1", "No permission. Contact administrator.");
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

public static class FuncActionFilteredProposalsExport {

private static async Task<RC_ab84a2ae7d846dd330e85891435fa3cb> QueryGetProposalsReadDbAsync(RC_ab84a2ae7d846dd330e85891435fa3cb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFileExtended.Read(r, ref index);
rec.ssENBank.Read(r, ref index);
rec.ssENCurrency.Read(r, ref index);
rec.ssENProposal.Read(r, ref index);
rec.ssENProposalStatus.Read(r, ref index);
rec.ssENProposalType.Read(r, ref index);
rec.ssENRegion.Read(r, ref index);
rec.ssENUploadedBy.Read(r, ref index);
rec.ssENFileImportLog.Read(r, ref index);
return rec;
}
// Query Function "GetProposals" OeXwppg5+EaIS52PHMcsag of Action "FilteredProposalsExport"
public static async Task<(RL_edee1bf5e5c171ee5ed6daf5087975b0,long)> QueryGetProposals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteProposals_Region,long qpbaProposals_Bank,decimal qpcuProposals_AmountMLFrom,decimal qpcuProposals_AmountMLTo,DateTime qpdaProposals_PaymentDateFrom,DateTime qpdaProposals_PaymentDateTo,string qpteProposals_Status,string qpteProposals_Currency,string qpteProposals_ProposalSearch,int qpinProposals_UploadType,int qpprProposals_Type,DateTime qpdaNulldate,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("FilteredProposalsExport.GetProposals", "a6f0e539-3998-46f8-884b-9d8f1cc72c6a");
using var queryActivity = activitySource.CreateSqlQueryActivity("FilteredProposalsExport.GetProposals", "a6f0e539-3998-46f8-884b-9d8f1cc72c6a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityFileExtended = AppUtils.Instance.RuntimeEntityReplace("FileExtended");
string entityBank = AppUtils.Instance.RuntimeEntityReplace("Bank");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityProposalStatus = AppUtils.Instance.RuntimeEntityReplace("ProposalStatus");
string entityProposalType = AppUtils.Instance.RuntimeEntityReplace("ProposalType");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityFileImportLog = AppUtils.Instance.RuntimeEntityReplace("FileImportLog");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
sqlCmd.CreateParameter("@qpteProposals_Region", DbType.String, qpteProposals_Region);
sqlCmd.CreateParameter("@qpbaProposals_Bank", DbType.Int64, qpbaProposals_Bank);
sqlCmd.CreateParameter("@qpcuProposals_AmountMLFrom", DbType.Decimal, qpcuProposals_AmountMLFrom);
sqlCmd.CreateParameter("@qpcuProposals_AmountMLTo", DbType.Decimal, qpcuProposals_AmountMLTo);
sqlCmd.CreateParameter("@qpdaProposals_PaymentDateFrom", DbType.DateTime, qpdaProposals_PaymentDateFrom);
sqlCmd.CreateParameter("@qpdaNulldate", DbType.DateTime, qpdaNulldate);
sqlCmd.CreateParameter("@qpdaProposals_PaymentDateTo", DbType.DateTime, qpdaProposals_PaymentDateTo);
sqlCmd.CreateParameter("@qpteProposals_Status", DbType.String, qpteProposals_Status);
sqlCmd.CreateParameter("@qpteProposals_Currency", DbType.String, qpteProposals_Currency);
sqlCmd.CreateParameter("@qpteProposals_ProposalSearch", DbType.String, qpteProposals_ProposalSearch);
sqlCmd.CreateParameter("@qpinProposals_UploadType", DbType.Int32, qpinProposals_UploadType);
sqlCmd.CreateParameter("@qpprProposals_Type", DbType.Int32, qpprProposals_Type);
string sql = "";
string advSql = "SELECT \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"filename\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"isprocessed\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"haserror\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"errormessage\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedon\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"shortname\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"order\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"symbol\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"minorunitdecimals\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"isactive\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaldate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"bankid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"fileid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalproposallines\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvaluemd\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"currencyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"lastupdatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"maxdatepaymentchanges\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"assignedtoid\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"class\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"is_active\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"is_active\"") + ",    \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"divisionfi\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"centrortp\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"commissionregion\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isfsp\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isfcp\"") + ", \n    UploadedBy.*, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileImportLog,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileImportLog,".\"fileid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileImportLog,".\"timestamp\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileImportLog,".\"importtype\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileImportLog,".\"importedby\"") + " \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " AS UploadedBy \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + " = UploadedBy.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"fileid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"bankid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"currencyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileImportLog,"") + " \n    on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"id\"") + "=  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileImportLog,".\"fileid\"") + " \nWHERE \n    ( \n      @qpteProposals_Region::text = '()' \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + " = ANY( \n            string_to_array(trim(both '()' from @qpteProposals_Region::text), ',')::int[] \n         ) \n    ) \n \n    AND ( \n      @qpbaProposals_Bank::int = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"bankid\"") + " = @qpbaProposals_Bank::int \n    ) \n \n    AND ( \n      @qpcuProposals_AmountMLFrom::numeric = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + " >= @qpcuProposals_AmountMLFrom::numeric \n    ) \n \n    AND ( \n      @qpcuProposals_AmountMLTo::numeric = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + " <= @qpcuProposals_AmountMLTo::numeric \n    ) \n \n    AND ( \n      ( @qpdaProposals_PaymentDateFrom::timestamp = @qpdaNulldate::timestamp \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + " >= @qpdaProposals_PaymentDateFrom::timestamp ) \n      AND \n      ( @qpdaProposals_PaymentDateTo::timestamp =@qpdaNulldate::timestamp \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + " <= @qpdaProposals_PaymentDateTo::timestamp ) \n    ) \n \n    AND \n    ( \n      @qpteProposals_Status::text = '()' \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " = ANY( \n            string_to_array(trim(both '()' from @qpteProposals_Status::text), ',')::int[] \n         ) \n    ) \n \n    AND  ( \n      @qpteProposals_Currency::text  = '()' \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"currencyid\"") + " = ANY( \n            string_to_array(trim(both '()' from @qpteProposals_Currency::text), ',')::text[] \n         ) \n    ) \n \n    AND ( \n        @qpteProposals_ProposalSearch::text = '' \n        OR LOWER( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"name\"") + " COLLATE \"C\") LIKE LOWER(('%' || @qpteProposals_ProposalSearch::text || '%') COLLATE \"C\") \n    ) \n \n    AND ( \n      @qpinProposals_UploadType::int = 0 \n      OR ( @qpinProposals_UploadType::int = 2 AND COALESCE( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + "::text, '') = '') \n      OR ( @qpinProposals_UploadType::int = 1 AND COALESCE( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + "::text, '') <> '') \n    ) \n \n    AND ( \n      @qpprProposals_Type::int = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + " = @qpprProposals_Type::int \n    ) \n \n    ORDER BY  " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qpteTableSort)) + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"order\"") + " ASC";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_edee1bf5e5c171ee5ed6daf5087975b0 outParamList = new RL_edee1bf5e5c171ee5ed6daf5087975b0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = QueryGetProposalsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false});
opt[6] = new BitArray(new bool[] {false, false, false, false, false});
opt[7] = new BitArray(new bool[] {false, false, false, false, false});
opt[8] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FilteredProposalsExport.GetProposals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_edee1bf5e5c171ee5ed6daf5087975b0 _tmp = new RL_edee1bf5e5c171ee5ed6daf5087975b0();
_tmp.AlternateReadDbMethodAsync = QueryGetProposalsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FilteredProposalsExport.GetProposals.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_edee1bf5e5c171ee5ed6daf5087975b0)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetProposals in FilteredProposalsExport in ConectaProveedores (SELECT      {FileExtended}.*,      {Bank}.*,      {Currency}.*,      {Proposal}.*,      {ProposalStatus}.*,      {ProposalType}.*,         {Region}.*,      UploadedBy.*,      {FileImportLog}.*  FROM {FileExtended}  LEFT JOIN {User} AS UploadedBy      ON {FileExtended}.[UploadedBy] = UploadedBy.[Id]  LEFT JOIN {Proposal}      ON {FileExtended}.[Id] = {Proposal}.[FileId]  LEFT JOIN {ProposalType}      ON {Proposal}.[ProposalTypeId] = {ProposalType}.[Id]  LEFT JOIN {ProposalStatus}      ON {Proposal}.[ProposalStatusId] = {ProposalStatus}.[Id]  LEFT JOIN {Bank}      ON {Proposal}.[BankId] = {Bank}.[Id]  LEFT JOIN {Region}      ON {Proposal}.[RegionId] = {Region}.[Id]  LEFT JOIN {Currency}      ON {Proposal}.[CurrencyId] = {Currency}.[Code]  LEFT JOIN {FileImportLog}      on {FileExtended}.[Id]= {FileImportLog}.[FileId]  WHERE      (        @Proposals_Region::text = '()'        OR {Proposal}.[RegionId] = ANY(              string_to_array(trim(both '()' from @Proposals_Region::text), ',')::i ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProposals in FilteredProposalsExport in ConectaProveedores (SELECT      {FileExtended}.*,      {Bank}.*,      {Currency}.*,      {Proposal}.*,      {ProposalStatus}.*,      {ProposalType}.*,         {Region}.*,      UploadedBy.*,      {FileImportLog}.*  FROM {FileExtended}  LEFT JOIN {User} AS UploadedBy      ON {FileExtended}.[UploadedBy] = UploadedBy.[Id]  LEFT JOIN {Proposal}      ON {FileExtended}.[Id] = {Proposal}.[FileId]  LEFT JOIN {ProposalType}      ON {Proposal}.[ProposalTypeId] = {ProposalType}.[Id]  LEFT JOIN {ProposalStatus}      ON {Proposal}.[ProposalStatusId] = {ProposalStatus}.[Id]  LEFT JOIN {Bank}      ON {Proposal}.[BankId] = {Bank}.[Id]  LEFT JOIN {Region}      ON {Proposal}.[RegionId] = {Region}.[Id]  LEFT JOIN {Currency}      ON {Proposal}.[CurrencyId] = {Currency}.[Code]  LEFT JOIN {FileImportLog}      on {FileExtended}.[Id]= {FileImportLog}.[FileId]  WHERE      (        @Proposals_Region::text = '()'        OR {Proposal}.[RegionId] = ANY(              string_to_array(trim(both '()' from @Proposals_Region::text), ',')::i ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProposals in FilteredProposalsExport in ConectaProveedores (SELECT      {FileExtended}.*,      {Bank}.*,      {Currency}.*,      {Proposal}.*,      {ProposalStatus}.*,      {ProposalType}.*,         {Region}.*,      UploadedBy.*,      {FileImportLog}.*  FROM {FileExtended}  LEFT JOIN {User} AS UploadedBy      ON {FileExtended}.[UploadedBy] = UploadedBy.[Id]  LEFT JOIN {Proposal}      ON {FileExtended}.[Id] = {Proposal}.[FileId]  LEFT JOIN {ProposalType}      ON {Proposal}.[ProposalTypeId] = {ProposalType}.[Id]  LEFT JOIN {ProposalStatus}      ON {Proposal}.[ProposalStatusId] = {ProposalStatus}.[Id]  LEFT JOIN {Bank}      ON {Proposal}.[BankId] = {Bank}.[Id]  LEFT JOIN {Region}      ON {Proposal}.[RegionId] = {Region}.[Id]  LEFT JOIN {Currency}      ON {Proposal}.[CurrencyId] = {Currency}.[Code]  LEFT JOIN {FileImportLog}      on {FileExtended}.[Id]= {FileImportLog}.[FileId]  WHERE      (        @Proposals_Region::text = '()'        OR {Proposal}.[RegionId] = ANY(              string_to_array(trim(both '()' from @Proposals_Region::text), ',')::i ...): " + aqExcep.Message));
}
}
}


/// <summary>
/// RecordList To Excel: RLToExcelFilteredProposalsExportRecordListToExcel1 (KYVuf1KLa7UiHgh9m24OtFA)
///  of Action "FilteredProposalsExport"
/// </summary>
public static async Task<byte[]> RLToExcelFilteredProposalsExportRecordListToExcel1(IRequestContext requestContext,RL_a47850dd2118e9d03f96b793e5fcd15c ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(12, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Nombre de la propuesta");
excel.CreateCell("Tipo de propuesta");
excel.CreateCell("Fecha de carga");
excel.CreateCell("Subido por");
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
excel.CreateCell(ssRecordList.CurrentRec.ssUploadedby);
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
