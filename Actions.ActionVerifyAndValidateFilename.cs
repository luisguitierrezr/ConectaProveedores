namespace ssConectaProveedores;

public partial class Actions {
public class lcvVerifyAndValidateFilename : VarsBag {
public string inParami_Filename;
public bool inParami_IsCommission;
public bool inParami_IsComissionUnknown;
public byte[] inParami_Binary;
public bool resRegex_SearchRegion_outParamFound = false;
public string resRegex_SearchRegion_outParamPatternResult = "";
public int resRegex_SearchRegion_outParamFirstIndex = 0;

public RL_c7f89ca4df2a001749d1cb52057abd7c queryResGetFileExtendedsByFilename_outParamList = new RL_c7f89ca4df2a001749d1cb52057abd7c();
public long queryResGetFileExtendedsByFilename_outParamCount = 0L;

public bool resRegex_SearchName_outParamFound = false;
public string resRegex_SearchName_outParamPatternResult = "";
public int resRegex_SearchName_outParamFirstIndex = 0;

public RL_1353a59e0688582d82bbddc41b47193e queryResGetCurrencyByCode_outParamList = new RL_1353a59e0688582d82bbddc41b47193e();
public long queryResGetCurrencyByCode_outParamCount = 0L;

public Actions.lcoVerifyWholeFilename resVerifyWholeFilename =  new Actions.lcoVerifyWholeFilename();
public RL_0fc5fa92a15115f6e97a1071c9876bcd queryResGetBanksByName_outParamList = new RL_0fc5fa92a15115f6e97a1071c9876bcd();
public long queryResGetBanksByName_outParamCount = 0L;

public bool resRegex_SearchBank_outParamFound = false;
public string resRegex_SearchBank_outParamPatternResult = "";
public int resRegex_SearchBank_outParamFirstIndex = 0;

public RL_82cb75d019380779df8a0b07571373a2 resListFilter_outParamFilteredList = new RL_82cb75d019380779df8a0b07571373a2();

public bool resRegex_SearchDate_outParamFound = false;
public string resRegex_SearchDate_outParamPatternResult = "";
public int resRegex_SearchDate_outParamFirstIndex = 0;

public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegionsByCommissionRegion_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegionsByCommissionRegion_outParamCount = 0L;

public RL_82cb75d019380779df8a0b07571373a2 resExcelToRecordList_outParamOut = new RL_82cb75d019380779df8a0b07571373a2();
public lcvVerifyAndValidateFilename(string inParami_Filename, bool inParami_IsCommission, bool inParami_IsComissionUnknown, byte[] inParami_Binary) {
this.inParami_Filename = inParami_Filename;
this.inParami_IsCommission = inParami_IsCommission;
this.inParami_IsComissionUnknown = inParami_IsComissionUnknown;
this.inParami_Binary = inParami_Binary;
}
}
public class lcoVerifyAndValidateFilename : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public ST_ba28fce29317fb1a65969ecb0fce5c4bStructure outParamo_ProposalTempData = new ST_ba28fce29317fb1a65969ecb0fce5c4bStructure();

public lcoVerifyAndValidateFilename() {
}
}
/// <summary>
/// Action <code>VerifyAndValidateFilename</code> that represents the Service Studio action
///  <code>VerifyAndValidateFilename</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,ST_ba28fce29317fb1a65969ecb0fce5c4bStructure)> ActionVerifyAndValidateFilename(IRequestContext requestContext,string inParami_Filename,bool inParami_IsCommission,bool inParami_IsComissionUnknown,byte[] inParami_Binary,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
ST_ba28fce29317fb1a65969ecb0fce5c4bStructure outParamo_ProposalTempData = default;
lcoVerifyAndValidateFilename result = new lcoVerifyAndValidateFilename();
lcvVerifyAndValidateFilename localVars = new lcvVerifyAndValidateFilename(inParami_Filename, inParami_IsCommission, inParami_IsComissionUnknown, inParami_Binary);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("VerifyAndValidateFilename", "c445672d-f209-4376-9c0a-a5729eaa6891"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("VerifyAndValidateFilename", "c445672d-f209-4376-9c0a-a5729eaa6891", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// VerifyWholeFilename
localVars.resVerifyWholeFilename.outParamo_Output = await Actions.ActionVerifyWholeFilename(requestContext,localVars.inParami_Filename,localVars.inParami_IsCommission,localVars.inParami_IsComissionUnknown,cancellationToken);

if((localVars.resVerifyWholeFilename.outParamo_Output.ssIsSuccess)) {
// Query datasetGetFileExtendedsByFilename
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFileExtendedsByFilename_maxRecords = 1;
if (datasetGetFileExtendedsByFilename_maxRecords < 1) datasetGetFileExtendedsByFilename_maxRecords = 1;
int datasetGetFileExtendedsByFilename_startIndex = 0;(localVars.queryResGetFileExtendedsByFilename_outParamList,localVars.queryResGetFileExtendedsByFilename_outParamCount) = await FuncActionVerifyAndValidateFilename.datasetGetFileExtendedsByFilename(requestContext,datasetGetFileExtendedsByFilename_maxRecords,datasetGetFileExtendedsByFilename_startIndex,IterationMultiplicity.Never,localVars.inParami_Filename,cancellationToken);

if((localVars.queryResGetFileExtendedsByFilename_outParamList.Empty)) {
// Regex_SearchName
(localVars.resRegex_SearchName_outParamFound,localVars.resRegex_SearchName_outParamPatternResult,localVars.resRegex_SearchName_outParamFirstIndex) = await Actions.ActionRegex_Search(requestContext,localVars.inParami_Filename,"_(BA|BC)[0-9]+_",false,false,false,cancellationToken);

if((localVars.resRegex_SearchName_outParamFound)) {
// Regex_SearchRegion
(localVars.resRegex_SearchRegion_outParamFound,localVars.resRegex_SearchRegion_outParamPatternResult,localVars.resRegex_SearchRegion_outParamFirstIndex) = await Actions.ActionRegex_Search(requestContext,localVars.inParami_Filename,"_R[0-9]+_",false,false,false,cancellationToken);

// Query datasetGetRegionsByCommissionRegion
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegionsByCommissionRegion_maxRecords = 1;
if (datasetGetRegionsByCommissionRegion_maxRecords < 1) datasetGetRegionsByCommissionRegion_maxRecords = 1;
int datasetGetRegionsByCommissionRegion_startIndex = 0;(localVars.queryResGetRegionsByCommissionRegion_outParamList,localVars.queryResGetRegionsByCommissionRegion_outParamCount) = await FuncActionVerifyAndValidateFilename.datasetGetRegionsByCommissionRegion(requestContext,datasetGetRegionsByCommissionRegion_maxRecords,datasetGetRegionsByCommissionRegion_startIndex,IterationMultiplicity.Never,localVars.resRegex_SearchRegion_outParamPatternResult,cancellationToken);

if((localVars.queryResGetRegionsByCommissionRegion_outParamList.Empty)) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "No se encontró la región en nuestra base de datos."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("d1kmOLc1yE+VlxO5veBQ_Q#Value.-1863225134.1", "No se encontró la región en nuestra base de datos.");
} else {
// Regex_SearchBank
(localVars.resRegex_SearchBank_outParamFound,localVars.resRegex_SearchBank_outParamPatternResult,localVars.resRegex_SearchBank_outParamFirstIndex) = await Actions.ActionRegex_Search(requestContext,localVars.inParami_Filename,"(BBVA|INBURSA|Inbursa)",false,false,false,cancellationToken);

// Query datasetGetBanksByName
cancellationToken.ThrowIfCancellationRequested();
int datasetGetBanksByName_maxRecords = 1;
if (datasetGetBanksByName_maxRecords < 1) datasetGetBanksByName_maxRecords = 1;
int datasetGetBanksByName_startIndex = 0;(localVars.queryResGetBanksByName_outParamList,localVars.queryResGetBanksByName_outParamCount) = await FuncActionVerifyAndValidateFilename.datasetGetBanksByName(requestContext,datasetGetBanksByName_maxRecords,datasetGetBanksByName_startIndex,IterationMultiplicity.Never,localVars.resRegex_SearchBank_outParamPatternResult,cancellationToken);

if((localVars.queryResGetBanksByName_outParamList.Empty)) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "No se encontró el banco en nuestra base de datos."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("YM+fMjOwtkCD7N7vuwHHzg#Value.1957457059.1", "No se encontró el banco en nuestra base de datos.");
} else {
// ExcelToRecordList ExcelToRLVerifyAndValidateFilenameExcelToRecordList
FuncActionVerifyAndValidateFilename.ExcelToRLVerifyAndValidateFilenameExcelToRecordList(requestContext,localVars.inParami_Binary,"",out localVars.resExcelToRecordList_outParamOut);
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_82cb75d019380779df8a0b07571373a2)await  localVars.resExcelToRecordList_outParamOut.FilterAsync(async (p, cancellationToken) => (p.ssSTCommissionsAndLeasesFileStruct.ssCuenta!=""), cancellationToken)));

if((localVars.resListFilter_outParamFilteredList.Empty)) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "El archivo está vacío."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("5gn4t3WxQ0mTsq+bcUwbdw#Value.-1923994964.1", "El archivo está vacío.");
} else {
// Foreach ListFilter.FilteredList
localVars.resListFilter_outParamFilteredList.StartIteration();
try {while (!((localVars.resListFilter_outParamFilteredList.Eof))) {
// o_ProposalTempData.TotalValueML = o_ProposalTempData.TotalValueML + TextToDecimal
result.outParamo_ProposalTempData.ssTotalValueML = (result.outParamo_ProposalTempData.ssTotalValueML+BuiltInFunction.TextToDecimal (localVars.resListFilter_outParamFilteredList.CurrentRec.ssSTCommissionsAndLeasesFileStruct.ssImporteEnML));

// o_ProposalTempData.TotalValueMD = o_ProposalTempData.TotalValueMD + TextToDecimal
result.outParamo_ProposalTempData.ssTotalValueMD = (result.outParamo_ProposalTempData.ssTotalValueMD+BuiltInFunction.TextToDecimal (localVars.resListFilter_outParamFilteredList.CurrentRec.ssSTCommissionsAndLeasesFileStruct.ssImporteEnMD));

// o_ProposalTempData.PaymentDate = If
result.outParamo_ProposalTempData.ssPaymentDate = BuiltInFunction.DateTimeToDate((((result.outParamo_ProposalTempData.ssPaymentDate!=BuiltInFunction.NullDate ())) ? (result.outParamo_ProposalTempData.ssPaymentDate) : (BuiltInFunction.TextToDateTime (localVars.resListFilter_outParamFilteredList.CurrentRec.ssSTCommissionsAndLeasesFileStruct.ssFeContab))));

// o_ProposalTempData.PaymentDateText = If
result.outParamo_ProposalTempData.ssPaymentDateText = (((result.outParamo_ProposalTempData.ssPaymentDate!=BuiltInFunction.NullDate ())) ? (BuiltInFunction.FormatDateTime (result.outParamo_ProposalTempData.ssPaymentDate, "dd/MM/yyyy")) : (BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDateTime (localVars.resListFilter_outParamFilteredList.CurrentRec.ssSTCommissionsAndLeasesFileStruct.ssFeContab), "dd/MM/yyyy")));
localVars.resListFilter_outParamFilteredList.Advance();
}

} finally {
localVars.resListFilter_outParamFilteredList.EndIteration();
}

// Query datasetGetCurrencyByCode
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCurrencyByCode_maxRecords = 1;
if (datasetGetCurrencyByCode_maxRecords < 1) datasetGetCurrencyByCode_maxRecords = 1;
int datasetGetCurrencyByCode_startIndex = 0;(localVars.queryResGetCurrencyByCode_outParamList,localVars.queryResGetCurrencyByCode_outParamCount) = await FuncActionVerifyAndValidateFilename.datasetGetCurrencyByCode(requestContext,datasetGetCurrencyByCode_maxRecords,datasetGetCurrencyByCode_startIndex,IterationMultiplicity.Never,localVars.resListFilter_outParamFilteredList.CurrentRec.ssSTCommissionsAndLeasesFileStruct.ssML,cancellationToken);

// Regex_SearchDate
(localVars.resRegex_SearchDate_outParamFound,localVars.resRegex_SearchDate_outParamPatternResult,localVars.resRegex_SearchDate_outParamFirstIndex) = await Actions.ActionRegex_Search(requestContext,localVars.inParami_Filename,"(\\d{8})",true,false,false,cancellationToken);

// o_ProposalTempData.ProposalTypeId = If
result.outParamo_ProposalTempData.ssProposalTypeId = (((BuiltInFunction.IndexSC (localVars.inParami_Filename, "COMISIONES", 0, false, true)==(-1))) ? ((await Functions.ssGetProposalType(requestContext,(ENProposalTypeEntity.GetRecordByKey(ObjectKey.Parse("+yIDjJu2pUaWuy5b+63dBA"))).ssId,cancellationToken)).ssENProposalType.ssId) : ((await Functions.ssGetProposalType(requestContext,(ENProposalTypeEntity.GetRecordByKey(ObjectKey.Parse("GVjPmq9Y3UikKDjYWKOleg"))).ssId,cancellationToken)).ssENProposalType.ssId));

// o_ProposalTempData.ProposalType = If
result.outParamo_ProposalTempData.ssProposalType = (((BuiltInFunction.IndexSC (localVars.inParami_Filename, "COMISIONES", 0, false, true)==(-1))) ? ((await Functions.ssGetProposalType(requestContext,(ENProposalTypeEntity.GetRecordByKey(ObjectKey.Parse("+yIDjJu2pUaWuy5b+63dBA"))).ssId,cancellationToken)).ssENProposalType.ssLabel) : ((await Functions.ssGetProposalType(requestContext,(ENProposalTypeEntity.GetRecordByKey(ObjectKey.Parse("GVjPmq9Y3UikKDjYWKOleg"))).ssId,cancellationToken)).ssENProposalType.ssLabel));

// o_ProposalTempData.ProposalDate = TextToDateTime
result.outParamo_ProposalTempData.ssProposalDate = BuiltInFunction.DateTimeToDate(BuiltInFunction.TextToDateTime (((((BuiltInFunction.SubstrSC (localVars.resRegex_SearchDate_outParamPatternResult, 0, 4)+"-")+BuiltInFunction.SubstrSC (localVars.resRegex_SearchDate_outParamPatternResult, 4, 2))+"-")+BuiltInFunction.SubstrSC (localVars.resRegex_SearchDate_outParamPatternResult, 6, 2))));

// o_ProposalTempData.Name = Substr
result.outParamo_ProposalTempData.ssName = BuiltInFunction.SubstrSC (localVars.resRegex_SearchName_outParamPatternResult, 1, (BuiltInFunction.LengthSC (localVars.resRegex_SearchName_outParamPatternResult)-2));

// o_ProposalTempData.BankCode = GetBanksByName.List.Current.Bank.Code
result.outParamo_ProposalTempData.ssBankCode = localVars.queryResGetBanksByName_outParamList.CurrentRec.ssENBank.ssCode;

// o_ProposalTempData.BankId = GetBanksByName.List.Current.Bank.Id
result.outParamo_ProposalTempData.ssBankId = localVars.queryResGetBanksByName_outParamList.CurrentRec.ssENBank.ssId;

// o_ProposalTempData.Region = GetRegionsByCommissionRegion.List.Current.Region.CommissionRegion
result.outParamo_ProposalTempData.ssRegion = localVars.queryResGetRegionsByCommissionRegion_outParamList.CurrentRec.ssENRegion.ssCommissionRegion;

// o_ProposalTempData.RegionId = GetRegionsByCommissionRegion.List.Current.Region.Id
result.outParamo_ProposalTempData.ssRegionId = localVars.queryResGetRegionsByCommissionRegion_outParamList.CurrentRec.ssENRegion.ssId;

// o_ProposalTempData.DivisionFI = GetRegionsByCommissionRegion.List.Current.Region.DivisionFI
result.outParamo_ProposalTempData.ssDivisionFI = localVars.queryResGetRegionsByCommissionRegion_outParamList.CurrentRec.ssENRegion.ssDivisionFI;

// o_ProposalTempData.TotalProposalLines = ListFilter.FilteredList.Length
result.outParamo_ProposalTempData.ssTotalProposalLines = localVars.resListFilter_outParamFilteredList.Length;

// o_ProposalTempData.CurrencyId = GetCurrencyByCode.List.Current.Currency.Code
result.outParamo_ProposalTempData.ssCurrencyId = localVars.queryResGetCurrencyByCode_outParamList.CurrentRec.ssENCurrency.ssCode;

// o_ProposalTempData.CurrencyCode = GetCurrencyByCode.List.Current.Currency.Code
result.outParamo_ProposalTempData.ssCurrencyCode = localVars.queryResGetCurrencyByCode_outParamList.CurrentRec.ssENCurrency.ssCode;

// o_ProposalTempData.CommissionsAndLeasesFileStructList = ListFilter.FilteredList
result.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList = (await RL_238f83286c67570510312c00ff7c1c1b.ConvertAsync(localVars.resListFilter_outParamFilteredList, new RL_238f83286c67570510312c00ff7c1c1b(), async (RC_47bfaf4bccb1bd03e97cb30148a93f4e source, ST_0a2958ff44247d7464fd88ba7a80597cStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
if((!(((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipDateValidationProposalsUpload])))))) {
if((!(((BuiltInFunction.Month (BuiltInFunction.TextToDateTime (((((BuiltInFunction.SubstrSC (localVars.resRegex_SearchDate_outParamPatternResult, 0, 4)+"-")+BuiltInFunction.SubstrSC (localVars.resRegex_SearchDate_outParamPatternResult, 4, 2))+"-")+BuiltInFunction.SubstrSC (localVars.resRegex_SearchDate_outParamPatternResult, 6, 2))))==BuiltInFunction.Month (BuiltInFunction.CurrDate ()))&&(BuiltInFunction.Year (BuiltInFunction.TextToDateTime (((((BuiltInFunction.SubstrSC (localVars.resRegex_SearchDate_outParamPatternResult, 0, 4)+"-")+BuiltInFunction.SubstrSC (localVars.resRegex_SearchDate_outParamPatternResult, 4, 2))+"-")+BuiltInFunction.SubstrSC (localVars.resRegex_SearchDate_outParamPatternResult, 6, 2))))==BuiltInFunction.Year (BuiltInFunction.CurrDate ())))))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "La fecha de la propuesta no coincide con el mes actual."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("YDkKnpsWEESkdXuPsigD6A#Value.-370950762.1", "La fecha de la propuesta no coincide con el mes actual.");
goto RETURN_STATEMENT;

}

}

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

}

}

} else {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "No se encontró el número de propuesta."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("r3DJ7Jh1HEejWYdJMhojuA#Value.-1161295515.1", "No se encontró el número de propuesta.");
}

} else {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Este archivo ya está siendo procesado en otra propuesta."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("lJ6YaIlJVEqY8YQuGbSryw#Value.304900098.1", "Este archivo ya está siendo procesado en otra propuesta.");
}

} else {
// o_Output = VerifyWholeFilename.o_Output
result.outParamo_Output=localVars.resVerifyWholeFilename.outParamo_Output;
}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Error al verificar y validar el nombre del archivo y su contenido."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("UbBkUoBDV0qCoHseJE_5fg#Value.62888153.1", "Error al verificar y validar el nombre del archivo y su contenido.");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
outParamo_ProposalTempData = result.outParamo_ProposalTempData;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamo_ProposalTempData);
}

public static class FuncActionVerifyAndValidateFilename {

private static async Task<RC_2a29aed0a2b753b8e46cbcb586392c66> datasetGetFileExtendedsByFilenameReadDbAsync(RC_2a29aed0a2b753b8e46cbcb586392c66 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFileExtended.Read( r, ref index);
rec.ssENProposal.Read( r, ref index);
return rec;
}
// Query Function "GetFileExtendedsByFilename" DJoyJ9jPP0GxkWxy49FFng of Action "VerifyAndValidateFilename"
public static async Task<(RL_c7f89ca4df2a001749d1cb52057abd7c,long)> datasetGetFileExtendedsByFilename(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteFileExtended_Filename,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("VerifyAndValidateFilename.GetFileExtendedsByFilename", "27329a0c-cfd8-413f-b191-6c72e3d1459e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("VerifyAndValidateFilename.GetFileExtendedsByFilename", "27329a0c-cfd8-413f-b191-6c72e3d1459e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.LWdFxAnydkOcCqVynqpokQ/NodesNotShownInESpaceTree.DJoyJ9jPP0GxkWxy49FFng, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM ({FileExtended} \"enfileextended2\" Inner JOIN {Proposal} \"enproposal8\" ON (\"enfileextended2\".\"id\" = \"enproposal8\".\"fileid\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize(\"enfileextended2\".\"filename\" collate \"default\") like caseaccent_normalize(@qpteFileExtended_Filename collate \"default\")) AND ((\"enproposal8\".\"proposalstatusid\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId);
whereBuilder.Append(") AND (\"enproposal8\".\"proposalstatusid\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId);
whereBuilder.Append("))");
sqlCmd.CreateParameterWithoutReplacements("@qpteFileExtended_Filename", DbType.String, qpteFileExtended_Filename);
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
RL_c7f89ca4df2a001749d1cb52057abd7c outParamList = new RL_c7f89ca4df2a001749d1cb52057abd7c();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFileExtendedsByFilenameReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query VerifyAndValidateFilename.GetFileExtendedsByFilename.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c7f89ca4df2a001749d1cb52057abd7c _tmp = new RL_c7f89ca4df2a001749d1cb52057abd7c();
_tmp.AlternateReadDbMethodAsync = datasetGetFileExtendedsByFilenameReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query VerifyAndValidateFilename.GetFileExtendedsByFilename.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c7f89ca4df2a001749d1cb52057abd7c)_tmp;
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

// Query Function "GetCurrencyByCode" ioaZWSRozUaqJW3FWTiltw of Action "VerifyAndValidateFilename"
public static async Task<(RL_1353a59e0688582d82bbddc41b47193e,long)> datasetGetCurrencyByCode(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteCode,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("VerifyAndValidateFilename.GetCurrencyByCode", "5999868a-6824-46cd-aa25-6dc55938a5b7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("VerifyAndValidateFilename.GetCurrencyByCode", "5999868a-6824-46cd-aa25-6dc55938a5b7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.LWdFxAnydkOcCqVynqpokQ/NodesNotShownInESpaceTree.ioaZWSRozUaqJW3FWTiltw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency4\".\"code\" o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {Currency} \"encurrency4\"");
whereBuilder.Append(" WHERE (\"encurrency4\".\"isactive\" = 1) AND (\"encurrency4\".\"code\" = (@qpteCode))");
sqlCmd.CreateParameterWithoutReplacements("@qpteCode", DbType.String, qpteCode);
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
RL_1353a59e0688582d82bbddc41b47193e outParamList = new RL_1353a59e0688582d82bbddc41b47193e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query VerifyAndValidateFilename.GetCurrencyByCode.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1353a59e0688582d82bbddc41b47193e _tmp = new RL_1353a59e0688582d82bbddc41b47193e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query VerifyAndValidateFilename.GetCurrencyByCode.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1353a59e0688582d82bbddc41b47193e)_tmp;
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

// Query Function "GetBanksByName" dsuXfrm9lUCtyanvMNwIEw of Action "VerifyAndValidateFilename"
public static async Task<(RL_0fc5fa92a15115f6e97a1071c9876bcd,long)> datasetGetBanksByName(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("VerifyAndValidateFilename.GetBanksByName", "7e97cb76-bdb9-4095-adc9-a9ef30dc0813");
using var queryActivity = activitySource.CreateAggregateQueryActivity("VerifyAndValidateFilename.GetBanksByName", "7e97cb76-bdb9-4095-adc9-a9ef30dc0813", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.LWdFxAnydkOcCqVynqpokQ/NodesNotShownInESpaceTree.dsuXfrm9lUCtyanvMNwIEw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enbank\".\"id\" o0, NULL o1, NULL o2, \"enbank\".\"code\" o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {Bank} \"enbank\"");
whereBuilder.Append(" WHERE ((Upper(\"enbank\".\"name\")) = (Upper(@qpteName)))");
orderByBuilder.Append(" ORDER BY \"enbank\".\"order\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpteName", DbType.String, qpteName);
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
RL_0fc5fa92a15115f6e97a1071c9876bcd outParamList = new RL_0fc5fa92a15115f6e97a1071c9876bcd();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query VerifyAndValidateFilename.GetBanksByName.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0fc5fa92a15115f6e97a1071c9876bcd _tmp = new RL_0fc5fa92a15115f6e97a1071c9876bcd();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query VerifyAndValidateFilename.GetBanksByName.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0fc5fa92a15115f6e97a1071c9876bcd)_tmp;
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

// Query Function "GetRegionsByCommissionRegion" Akvi68NFhUqBx4RoygAvcw of Action "VerifyAndValidateFilename"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegionsByCommissionRegion(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qptePatternResult,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("VerifyAndValidateFilename.GetRegionsByCommissionRegion", "ebe24b02-45c3-4a85-81c7-8468ca002f73");
using var queryActivity = activitySource.CreateAggregateQueryActivity("VerifyAndValidateFilename.GetRegionsByCommissionRegion", "ebe24b02-45c3-4a85-81c7-8468ca002f73", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.LWdFxAnydkOcCqVynqpokQ/NodesNotShownInESpaceTree.Akvi68NFhUqBx4RoygAvcw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion51\".\"id\" o0, NULL o1, NULL o2, \"enregion51\".\"divisionfi\" o3, NULL o4, \"enregion51\".\"commissionregion\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion51\"");
whereBuilder.Append(" WHERE (\"enregion51\".\"commissionregion\" = (substring(@qptePatternResult from (1) + 1 for ((length(@qptePatternResult)) - 2))))");
orderByBuilder.Append(" ORDER BY \"enregion51\".\"code\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qptePatternResult", DbType.String, qptePatternResult);
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, false, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query VerifyAndValidateFilename.GetRegionsByCommissionRegion.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query VerifyAndValidateFilename.GetRegionsByCommissionRegion.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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


/// <summary>
/// Excel To RecordList: ExcelToRLVerifyAndValidateFilenameExcelToRecordList (KzTLY9L78zE2GU8UGw1MAVA)
///  of Action "VerifyAndValidateFilename"
/// </summary>
public static void ExcelToRLVerifyAndValidateFilenameExcelToRecordList(IRequestContext requestContext,byte[] excelContent,string tableName,out RL_82cb75d019380779df8a0b07571373a2 outParamOut) {

if(excelContent.GetLength(0) == 0) {
    throw InvalidExcelErrorsHelper.EmptyExcelFile();
}
var service = ServiceLocator.GetService<ISpreadsheetService>();
var reader = service.GetReader(
    excelContent, 
    tableName, 
    new Type[] {
        typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string)
    },
    new string[] {
        "FeContab", 
"EjMes", 
"Cuenta", 
"Referencia", 
"Nombre1", 
"Nombre2", 
"NDoc", 
"ImporteEnML", 
"ML", 
"ImporteEnMD", 
"Mon", 
"Soc", 
"Div", 
"LibMayor", 
"TextoCabDocumento", 
"DocComp"
    },
    new string[] {
        "Fe Contab", 
"Ej Mes", 
"Cuenta", 
"Referencia", 
"Nombre 1", 
"Nombre 2", 
"N Doc", 
"Importe En ML", 
"ML", 
"Importe En MD", 
"Mon", 
"Soc", 
"Div", 
"Lib Mayor", 
"Texto Cab Documento", 
"Doc Comp"
    },
    new string[] {
        "FeContab", 
"EjMes", 
"Cuenta", 
"Referencia", 
"Nombre1", 
"Nombre2", 
"NDoc", 
"ImporteEnML", 
"ML", 
"ImporteEnMD", 
"Mon", 
"Soc", 
"Div", 
"LibMayor", 
"TextoCabDocumento", 
"DocComp"
    },
    new string[] {
        "Fe Contab", 
"Ej Mes", 
"Cuenta", 
"Referencia", 
"Nombre 1", 
"Nombre 2", 
"N Doc", 
"Importe En ML", 
"ML", 
"Importe En MD", 
"Mon", 
"Soc", 
"Div", 
"Lib Mayor", 
"Texto Cab Documento", 
"Doc Comp"
    });

RL_82cb75d019380779df8a0b07571373a2 tmp = new();
tmp.Reader = reader;

outParamOut = (RL_82cb75d019380779df8a0b07571373a2)tmp.Duplicate();
}


}


}
