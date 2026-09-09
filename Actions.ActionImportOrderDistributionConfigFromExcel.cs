namespace ssConectaProveedores;

public partial class Actions {
public class lcvImportOrderDistributionConfigFromExcel : VarsBag {
public byte[] inParamFileContent;
/// <summary>
/// Variable <code>Source</code> that represents the Service Studio OrderDistributionConfig
///  <code>Source</code> <p>Description: </p>
/// </summary>
public EN_4ad0cdb13562998fda111463f2af9c31EntityRecord varLcSource = new EN_4ad0cdb13562998fda111463f2af9c31EntityRecord();

/// <summary>
/// Variable <code>AlreadyAdded</code> that represents the Service Studio
///  OrderDistributionImportStrucList <code>AlreadyAdded</code> <p>Description: </p>
/// </summary>
public RL_e5599d6b39ff4d762401f24c2e9326ab varLcAlreadyAdded = new RL_e5599d6b39ff4d762401f24c2e9326ab();

public RL_5d3a02aa993c7474297e33d992f39ad0 resgetRegionId_outParamFilteredList = new RL_5d3a02aa993c7474297e33d992f39ad0();

public Actions.lcoCreatePositionContacts resCreatePositionSecondContactValids =  new Actions.lcoCreatePositionContacts();
public Actions.lcoCreatePositionContacts resCreatePositionSecondContacts =  new Actions.lcoCreatePositionContacts();
public RL_084ec93001d810170970c8007b50b58f resgetPositionSecondApproverId_outParamFilteredList = new RL_084ec93001d810170970c8007b50b58f();

public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegions_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegions_outParamCount = 0L;

public RLAIItemRecordList queryResDeleteAll_outParamList = new RLAIItemRecordList();
public long queryResDeleteAll_outParamCount = 0L;

public Actions.lcoCreateOrUpdateOrderDistribution resCreateOrUpdateOrderDistribution =  new Actions.lcoCreateOrUpdateOrderDistribution();
public Actions.lcoCreatePositionContacts resCreatePositionFirstContacts =  new Actions.lcoCreatePositionContacts();
public RL_084ec93001d810170970c8007b50b58f resgetPositionFirstContactId_outParamFilteredList = new RL_084ec93001d810170970c8007b50b58f();

public Actions.lcoCreatePositionContacts resCreatePositionThirdContacts =  new Actions.lcoCreatePositionContacts();
public Actions.lcoCreateDirections resCreateDirections =  new Actions.lcoCreateDirections();
public RL_084ec93001d810170970c8007b50b58f resgetPositionFirstApproverValidId_outParamFilteredList = new RL_084ec93001d810170970c8007b50b58f();

public RL_24a7f9997087be4da8bf09ab1b655746 resExcelToRecordList1_outParamOut = new RL_24a7f9997087be4da8bf09ab1b655746();
public RL_f1511df7dc3042c2ebd8fe2fdc783908 queryResGetOrderDistributionConfigs_outParamList = new RL_f1511df7dc3042c2ebd8fe2fdc783908();
public long queryResGetOrderDistributionConfigs_outParamCount = 0L;

public RL_f1511df7dc3042c2ebd8fe2fdc783908 resListFilter_outParamFilteredList = new RL_f1511df7dc3042c2ebd8fe2fdc783908();

public RL_084ec93001d810170970c8007b50b58f resgetPositionSecondContactId_outParamFilteredList = new RL_084ec93001d810170970c8007b50b58f();

public RL_e5599d6b39ff4d762401f24c2e9326ab resListFilter2_outParamFilteredList = new RL_e5599d6b39ff4d762401f24c2e9326ab();

public RL_084ec93001d810170970c8007b50b58f queryResGetEntraRoles_outParamList = new RL_084ec93001d810170970c8007b50b58f();
public long queryResGetEntraRoles_outParamCount = 0L;

public RL_9895159eebcdcdaed80fbd832f52d838 queryResGetTelcelDirections_outParamList = new RL_9895159eebcdcdaed80fbd832f52d838();
public long queryResGetTelcelDirections_outParamCount = 0L;

public RL_9895159eebcdcdaed80fbd832f52d838 resgetDirectionId_outParamFilteredList = new RL_9895159eebcdcdaed80fbd832f52d838();

public string resJSONSerialize1_outParamJSON = "";
public lcvImportOrderDistributionConfigFromExcel(byte[] inParamFileContent) {
this.inParamFileContent = inParamFileContent;
}
}
public class lcoImportOrderDistributionConfigFromExcel : VarsBag {
public bool outParamHasSuccess = false;

public string outParamErrorMessage = "";

public lcoImportOrderDistributionConfigFromExcel() {
}
}
/// <summary>
/// Action <code>ImportOrderDistributionConfigFromExcel</code> that represents the Service Studio
///  action <code>ImportOrderDistributionConfigFromExcel</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,string)> ActionImportOrderDistributionConfigFromExcel(IRequestContext requestContext,byte[] inParamFileContent,CancellationToken cancellationToken) {
bool outParamHasSuccess = default;
string outParamErrorMessage = default;
lcoImportOrderDistributionConfigFromExcel result = new lcoImportOrderDistributionConfigFromExcel();
lcvImportOrderDistributionConfigFromExcel localVars = new lcvImportOrderDistributionConfigFromExcel(inParamFileContent);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ImportOrderDistributionConfigFromExcel", "77826a58-9dc2-45fd-90f2-f27c67c7fb07"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ImportOrderDistributionConfigFromExcel", "77826a58-9dc2-45fd-90f2-f27c67c7fb07", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ExcelToRecordList ExcelToRLImportOrderDistributionConfigFromExcelExcelToRecordList1
FuncActionImportOrderDistributionConfigFromExcel.ExcelToRLImportOrderDistributionConfigFromExcelExcelToRecordList1(requestContext,localVars.inParamFileContent,"",out localVars.resExcelToRecordList1_outParamOut);
if((localVars.resExcelToRecordList1_outParamOut.Empty)) {
// HasSuccess = False
result.outParamHasSuccess=false;

// ErrorMessage = "Excel is empty"
result.outParamErrorMessage=AppUtils.GetStringResource("FHI4lbLYJkGqVbdUErFx2g#Value.-1731258816.1", "Excel is empty");
} else {
// Query QueryDeleteAll
cancellationToken.ThrowIfCancellationRequested();
int QueryDeleteAll_maxRecords = 0;
int QueryDeleteAll_startIndex = 0;(localVars.queryResDeleteAll_outParamList,localVars.queryResDeleteAll_outParamCount) = await FuncActionImportOrderDistributionConfigFromExcel.QueryDeleteAll(requestContext,QueryDeleteAll_maxRecords,QueryDeleteAll_startIndex,IterationMultiplicity.Never,cancellationToken);

// CreatePositionFirstContacts
localVars.resCreatePositionFirstContacts.outParamLastPositionContractId = await Actions.ActionCreatePositionContacts(requestContext,(await BasicTypeList<string>.ConvertAsync(localVars.resExcelToRecordList1_outParamOut, new BasicTypeList<string>(), async (RC_0e8dad36985178676a96cdacdf6f5259 source, string target, CancellationToken cancellationToken) => {
target = BuiltInFunction.Trim (source.ssSTOrderDistributionImportStruc.ssFirstContact);
return target;
}, cancellationToken)),cancellationToken);

// CreatePositionSecondContacts
localVars.resCreatePositionSecondContacts.outParamLastPositionContractId = await Actions.ActionCreatePositionContacts(requestContext,(await BasicTypeList<string>.ConvertAsync(localVars.resExcelToRecordList1_outParamOut, new BasicTypeList<string>(), async (RC_0e8dad36985178676a96cdacdf6f5259 source, string target, CancellationToken cancellationToken) => {
target = BuiltInFunction.Trim (source.ssSTOrderDistributionImportStruc.ssSecondContact);
return target;
}, cancellationToken)),cancellationToken);

// CreatePositionSecondContactValids
localVars.resCreatePositionSecondContactValids.outParamLastPositionContractId = await Actions.ActionCreatePositionContacts(requestContext,(await BasicTypeList<string>.ConvertAsync(localVars.resExcelToRecordList1_outParamOut, new BasicTypeList<string>(), async (RC_0e8dad36985178676a96cdacdf6f5259 source, string target, CancellationToken cancellationToken) => {
target = BuiltInFunction.Trim (source.ssSTOrderDistributionImportStruc.ssFirstApprover);
return target;
}, cancellationToken)),cancellationToken);

// CreatePositionThirdContacts
localVars.resCreatePositionThirdContacts.outParamLastPositionContractId = await Actions.ActionCreatePositionContacts(requestContext,(await BasicTypeList<string>.ConvertAsync(localVars.resExcelToRecordList1_outParamOut, new BasicTypeList<string>(), async (RC_0e8dad36985178676a96cdacdf6f5259 source, string target, CancellationToken cancellationToken) => {
target = BuiltInFunction.Trim (source.ssSTOrderDistributionImportStruc.ssSecondApprover);
return target;
}, cancellationToken)),cancellationToken);

// CreateDirections
localVars.resCreateDirections.outParamLastDirectionsId = await Actions.ActionCreateDirections(requestContext,(await BasicTypeList<string>.ConvertAsync(localVars.resExcelToRecordList1_outParamOut, new BasicTypeList<string>(), async (RC_0e8dad36985178676a96cdacdf6f5259 source, string target, CancellationToken cancellationToken) => {
target = BuiltInFunction.Trim (source.ssSTOrderDistributionImportStruc.ssDirection);
return target;
}, cancellationToken)),cancellationToken);

// Query datasetGetEntraRoles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetEntraRoles_maxRecords = 0;
int datasetGetEntraRoles_startIndex = 0;(localVars.queryResGetEntraRoles_outParamList,localVars.queryResGetEntraRoles_outParamCount) = await FuncActionImportOrderDistributionConfigFromExcel.datasetGetEntraRoles(requestContext,datasetGetEntraRoles_maxRecords,datasetGetEntraRoles_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// Query datasetGetRegions
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegions_maxRecords = 0;
int datasetGetRegions_startIndex = 0;(localVars.queryResGetRegions_outParamList,localVars.queryResGetRegions_outParamCount) = await FuncActionImportOrderDistributionConfigFromExcel.datasetGetRegions(requestContext,datasetGetRegions_maxRecords,datasetGetRegions_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// Query datasetGetOrderDistributionConfigs
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderDistributionConfigs_maxRecords = 0;
int datasetGetOrderDistributionConfigs_startIndex = 0;(localVars.queryResGetOrderDistributionConfigs_outParamList,localVars.queryResGetOrderDistributionConfigs_outParamCount) = await FuncActionImportOrderDistributionConfigFromExcel.datasetGetOrderDistributionConfigs(requestContext,datasetGetOrderDistributionConfigs_maxRecords,datasetGetOrderDistributionConfigs_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// Query datasetGetTelcelDirections
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTelcelDirections_maxRecords = 0;
int datasetGetTelcelDirections_startIndex = 0;(localVars.queryResGetTelcelDirections_outParamList,localVars.queryResGetTelcelDirections_outParamCount) = await FuncActionImportOrderDistributionConfigFromExcel.datasetGetTelcelDirections(requestContext,datasetGetTelcelDirections_maxRecords,datasetGetTelcelDirections_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// Foreach ExcelToRecordList1
localVars.resExcelToRecordList1_outParamOut.StartIteration();
try {while (!((localVars.resExcelToRecordList1_outParamOut.Eof))) {
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_f1511df7dc3042c2ebd8fe2fdc783908)await  localVars.queryResGetOrderDistributionConfigs_outParamList.FilterAsync(async (p, cancellationToken) => ((((BuiltInFunction.TextToInteger (BuiltInFunction.SubstrSC (p.ssENRegion.ssDivisionFI, 2, 2))==BuiltInFunction.TextToInteger (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssDivision))&&(p.ssENOrderDistributionConfig.ssApplicant==localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssApplicant))&&(p.ssENOrderDistributionConfig.ssApplicantDescription==localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssApplicantDescription))&&(p.ssENTelcelDirection.ssName==localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssDirection)), cancellationToken)));

// Exists?
if((!((!localVars.resListFilter_outParamFilteredList.Empty)))) {
// ListFilter2
localVars.resListFilter2_outParamFilteredList = (((RL_e5599d6b39ff4d762401f24c2e9326ab)await  localVars.varLcAlreadyAdded.FilterAsync(async (p, cancellationToken) => (((p.ssDivision==localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssDivision)&&(p.ssApplicant==localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssApplicant))&&(p.ssDirection==localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssDirection)), cancellationToken)));

if((!((!localVars.resListFilter2_outParamFilteredList.Empty)))) {
// getPositionFirstContactId
localVars.resgetPositionFirstContactId_outParamFilteredList = (((RL_084ec93001d810170970c8007b50b58f)await  localVars.queryResGetEntraRoles_outParamList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.ToUpper (p.ssENEntraRole.ssRoleName)==BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssFirstContact))), cancellationToken)));

// getPositionSecondContactId
localVars.resgetPositionSecondContactId_outParamFilteredList = (((RL_084ec93001d810170970c8007b50b58f)await  localVars.queryResGetEntraRoles_outParamList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.ToUpper (p.ssENEntraRole.ssRoleName)==BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssSecondContact))), cancellationToken)));

// getPositionFirstApproverValidId
localVars.resgetPositionFirstApproverValidId_outParamFilteredList = (((RL_084ec93001d810170970c8007b50b58f)await  localVars.queryResGetEntraRoles_outParamList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.ToUpper (p.ssENEntraRole.ssRoleName)==BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssFirstApprover))), cancellationToken)));

// getPositionSecondApproverId
localVars.resgetPositionSecondApproverId_outParamFilteredList = (((RL_084ec93001d810170970c8007b50b58f)await  localVars.queryResGetEntraRoles_outParamList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.ToUpper (p.ssENEntraRole.ssRoleName)==BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssSecondApprover))), cancellationToken)));

// getDirectionId
localVars.resgetDirectionId_outParamFilteredList = (((RL_9895159eebcdcdaed80fbd832f52d838)await  localVars.queryResGetTelcelDirections_outParamList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.ToUpper (p.ssENTelcelDirection.ssName)==BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssDirection))), cancellationToken)));

// getRegionId
localVars.resgetRegionId_outParamFilteredList = (((RL_5d3a02aa993c7474297e33d992f39ad0)await  localVars.queryResGetRegions_outParamList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.TextToInteger (BuiltInFunction.SubstrSC (p.ssENRegion.ssDivisionFI, 2, 2))==BuiltInFunction.TextToInteger (BuiltInFunction.Trim (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssDivision))), cancellationToken)));

// Source.Id = NullIdentifier
localVars.varLcSource.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// Source.RegionId = getRegionId.FilteredList.Current.Region.Id
localVars.varLcSource.ssRegionId = localVars.resgetRegionId_outParamFilteredList.CurrentRec.ssENRegion.ssId;

// Source.Applicant = ExcelToRecordList1.Current.OrderDistributionImportStruc.Applicant
localVars.varLcSource.ssApplicant = localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssApplicant;

// Source.ApplicantDescription = ExcelToRecordList1.Current.OrderDistributionImportStruc.ApplicantDescription
localVars.varLcSource.ssApplicantDescription = localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssApplicantDescription;

// Source.DirectionId = getDirectionId.FilteredList.Current.TelcelDirection.Id
localVars.varLcSource.ssDirectionId = localVars.resgetDirectionId_outParamFilteredList.CurrentRec.ssENTelcelDirection.ssId;

// Source.FirstContact_EntraRoleId = If
localVars.varLcSource.ssFirstContact_EntraRoleId = Convert.ToInt64((((BuiltInFunction.Trim (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssFirstContact)=="")) ? (BuiltInFunction.NullIdentifier ()) : (Convert.ToInt32(localVars.resgetPositionFirstContactId_outParamFilteredList.CurrentRec.ssENEntraRole.ssId))));

// Source.SecondContact_EntraRoleId = If
localVars.varLcSource.ssSecondContact_EntraRoleId = Convert.ToInt64((((BuiltInFunction.Trim (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssSecondContact)=="")) ? (BuiltInFunction.NullIdentifier ()) : (Convert.ToInt32(localVars.resgetPositionSecondContactId_outParamFilteredList.CurrentRec.ssENEntraRole.ssId))));

// Source.FirstApprover_EntraRoleId = If
localVars.varLcSource.ssFirstApprover_EntraRoleId = Convert.ToInt64((((BuiltInFunction.Trim (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssFirstApprover)=="")) ? (BuiltInFunction.NullIdentifier ()) : (Convert.ToInt32(localVars.resgetPositionFirstApproverValidId_outParamFilteredList.CurrentRec.ssENEntraRole.ssId))));

// Source.SecondApprover_EntraRoleId = If
localVars.varLcSource.ssSecondApprover_EntraRoleId = Convert.ToInt64((((BuiltInFunction.Trim (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc.ssSecondApprover)=="")) ? (BuiltInFunction.NullIdentifier ()) : (Convert.ToInt32(localVars.resgetPositionSecondApproverId_outParamFilteredList.CurrentRec.ssENEntraRole.ssId))));

// Source.CreatedBy = GetUserId
localVars.varLcSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.varLcSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();

// Source.UpdatedBy = GetUserId
localVars.varLcSource.ssUpdatedBy = BuiltInFunction.GetUserId ();

// Source.UpdatedOn = CurrDateTime
localVars.varLcSource.ssUpdatedOn = BuiltInFunction.CurrDateTime ();
// JSON Serialize JsonSerializeImportOrderDistributionConfigFromExcelJSONSerialize1
FuncActionImportOrderDistributionConfigFromExcel.JsonSerializeImportOrderDistributionConfigFromExcelJSONSerialize1(localVars.varLcSource, out localVars.resJSONSerialize1_outParamJSON);
// CreateOrUpdateOrderDistribution
localVars.resCreateOrUpdateOrderDistribution.outParamId = await Actions.ActionCreateOrUpdateOrderDistribution(requestContext,localVars.varLcSource,cancellationToken);

// AuditCreateWrapper
await Actions.ActionAuditCreateWrapper(requestContext,new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrigin = 2, ssIdentifier = localVars.resCreateOrUpdateOrderDistribution.outParamId, ssMessage = "Import Process Execution", ssChangeJSON = localVars.resJSONSerialize1_outParamJSON, ssOccurrenceRoleName = "" },cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcAlreadyAdded,localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTOrderDistributionImportStruc,cancellationToken);

}

}

localVars.resExcelToRecordList1_outParamOut.Advance();
}

} finally {
localVars.resExcelToRecordList1_outParamOut.EndIteration();
}

// HasSuccess = True
result.outParamHasSuccess=true;
}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// HasSuccess = False
result.outParamHasSuccess=false;

// ErrorMessage = AllExceptions.ExceptionMessage
result.outParamErrorMessage=ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamHasSuccess = result.outParamHasSuccess;
outParamErrorMessage = result.outParamErrorMessage;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamHasSuccess,outParamErrorMessage);
}

public static class FuncActionImportOrderDistributionConfigFromExcel {

// Query Function "GetRegions" kzgwMGvhUkefpeyAo1UghA of Action "ImportOrderDistributionConfigFromExcel"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ImportOrderDistributionConfigFromExcel.GetRegions", "30303893-e16b-4752-9fa5-ec80a3552084");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ImportOrderDistributionConfigFromExcel.GetRegions", "30303893-e16b-4752-9fa5-ec80a3552084", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.WGqCd8Kd_UWQ8vJ8Z8f7Bw/NodesNotShownInESpaceTree.kzgwMGvhUkefpeyAo1UghA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion33\".\"id\" o0, NULL o1, NULL o2, \"enregion33\".\"divisionfi\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion33\"");
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
opt[0] = new BitArray(new bool[] {false, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ImportOrderDistributionConfigFromExcel.GetRegions.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ImportOrderDistributionConfigFromExcel.GetRegions.List", cancellationToken: cancellationToken);
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

// Query Function "DeleteAll" aodEMULewkaADV0vWmfgbw of Action "ImportOrderDistributionConfigFromExcel"
public static async Task<(RLAIItemRecordList,long)> QueryDeleteAll(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("ImportOrderDistributionConfigFromExcel.DeleteAll", "3144876a-de42-46c2-800d-5d2f5a67e06f");
using var queryActivity = activitySource.CreateSqlQueryActivity("ImportOrderDistributionConfigFromExcel.DeleteAll", "3144876a-de42-46c2-800d-5d2f5a67e06f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderDistributionConfig = AppUtils.Instance.RuntimeEntityReplace("OrderDistributionConfig");
string sql = "";
string advSql = "DELETE FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDistributionConfig,"") + "";
string[] entitiesToCheck = new[] {"OrderDistributionConfig"};
AppUtils.Instance.RuntimeCheckReadOnlyEntity(entitiesToCheck);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RLAIItemRecordList outParamList = new RLAIItemRecordList();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ImportOrderDistributionConfigFromExcel.DeleteAll.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RLAIItemRecordList _tmp = new RLAIItemRecordList();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ImportOrderDistributionConfigFromExcel.DeleteAll.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RLAIItemRecordList)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("DeleteAll in ImportOrderDistributionConfigFromExcel in ConectaProveedores (DELETE FROM {OrderDistributionConfig}): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("DeleteAll in ImportOrderDistributionConfigFromExcel in ConectaProveedores (DELETE FROM {OrderDistributionConfig}): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("DeleteAll in ImportOrderDistributionConfigFromExcel in ConectaProveedores (DELETE FROM {OrderDistributionConfig}): " + aqExcep.Message));
}
}
}

private static async Task<RC_c8d5cf7b74d96976f36c31131cf6e264> datasetGetOrderDistributionConfigsReadDbAsync(RC_c8d5cf7b74d96976f36c31131cf6e264 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderDistributionConfig.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENTelcelDirection.Read( r, ref index);
return rec;
}
// Query Function "GetOrderDistributionConfigs" QG0qmyGObkif_DtAco3FAw of Action "ImportOrderDistributionConfigFromExcel"
public static async Task<(RL_f1511df7dc3042c2ebd8fe2fdc783908,long)> datasetGetOrderDistributionConfigs(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ImportOrderDistributionConfigFromExcel.GetOrderDistributionConfigs", "9b2a6d40-8e21-486e-9ffc-3b40728dc503");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ImportOrderDistributionConfigFromExcel.GetOrderDistributionConfigs", "9b2a6d40-8e21-486e-9ffc-3b40728dc503", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.WGqCd8Kd_UWQ8vJ8Z8f7Bw/NodesNotShownInESpaceTree.QG0qmyGObkif_DtAco3FAw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enorderdistributionconfig2\".\"applicant\" o2, \"enorderdistributionconfig2\".\"applicantdescription\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enregion34\".\"divisionfi\" o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"entelceldirection7\".\"name\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32");
fromBuilder.Append(" FROM (({OrderDistributionConfig} \"enorderdistributionconfig2\" Left JOIN {Region} \"enregion34\" ON (\"enorderdistributionconfig2\".\"regionid\" = \"enregion34\".\"id\"))  Left JOIN {TelcelDirection} \"entelceldirection7\" ON (\"enorderdistributionconfig2\".\"directionid\" = \"entelceldirection7\".\"id\")) ");
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
RL_f1511df7dc3042c2ebd8fe2fdc783908 outParamList = new RL_f1511df7dc3042c2ebd8fe2fdc783908();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderDistributionConfigsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ImportOrderDistributionConfigFromExcel.GetOrderDistributionConfigs.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f1511df7dc3042c2ebd8fe2fdc783908 _tmp = new RL_f1511df7dc3042c2ebd8fe2fdc783908();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderDistributionConfigsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ImportOrderDistributionConfigFromExcel.GetOrderDistributionConfigs.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f1511df7dc3042c2ebd8fe2fdc783908)_tmp;
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

// Query Function "GetEntraRoles" 9Q7IwrUmYk2u_iHpYMyJ9Q of Action "ImportOrderDistributionConfigFromExcel"
public static async Task<(RL_084ec93001d810170970c8007b50b58f,long)> datasetGetEntraRoles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ImportOrderDistributionConfigFromExcel.GetEntraRoles", "c2c80ef5-26b5-4d62-aefe-21e960cc89f5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ImportOrderDistributionConfigFromExcel.GetEntraRoles", "c2c80ef5-26b5-4d62-aefe-21e960cc89f5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.WGqCd8Kd_UWQ8vJ8Z8f7Bw/NodesNotShownInESpaceTree.9Q7IwrUmYk2u_iHpYMyJ9Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enentrarole20\".\"id\" o0, \"enentrarole20\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {EntraRole} \"enentrarole20\"");
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
RL_084ec93001d810170970c8007b50b58f outParamList = new RL_084ec93001d810170970c8007b50b58f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ImportOrderDistributionConfigFromExcel.GetEntraRoles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_084ec93001d810170970c8007b50b58f _tmp = new RL_084ec93001d810170970c8007b50b58f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ImportOrderDistributionConfigFromExcel.GetEntraRoles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_084ec93001d810170970c8007b50b58f)_tmp;
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

// Query Function "GetTelcelDirections" R5eKzEx_SUyTpDJbok9kpQ of Action "ImportOrderDistributionConfigFromExcel"
public static async Task<(RL_9895159eebcdcdaed80fbd832f52d838,long)> datasetGetTelcelDirections(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ImportOrderDistributionConfigFromExcel.GetTelcelDirections", "cc8a9747-7f4c-4c49-93a4-325ba24f64a5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ImportOrderDistributionConfigFromExcel.GetTelcelDirections", "cc8a9747-7f4c-4c49-93a4-325ba24f64a5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.WGqCd8Kd_UWQ8vJ8Z8f7Bw/NodesNotShownInESpaceTree.R5eKzEx_SUyTpDJbok9kpQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"entelceldirection8\".\"id\" o0, \"entelceldirection8\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {TelcelDirection} \"entelceldirection8\"");
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
RL_9895159eebcdcdaed80fbd832f52d838 outParamList = new RL_9895159eebcdcdaed80fbd832f52d838();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ImportOrderDistributionConfigFromExcel.GetTelcelDirections.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9895159eebcdcdaed80fbd832f52d838 _tmp = new RL_9895159eebcdcdaed80fbd832f52d838();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ImportOrderDistributionConfigFromExcel.GetTelcelDirections.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9895159eebcdcdaed80fbd832f52d838)_tmp;
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
/// Excel To RecordList: ExcelToRLImportOrderDistributionConfigFromExcelExcelToRecordList1
///  (KrgrWmjCJCUGPGlOfzokSzg) of Action "ImportOrderDistributionConfigFromExcel"
/// </summary>
public static void ExcelToRLImportOrderDistributionConfigFromExcelExcelToRecordList1(IRequestContext requestContext,byte[] excelContent,string tableName,out RL_24a7f9997087be4da8bf09ab1b655746 outParamOut) {

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
typeof(string)
    },
    new string[] {
        "Division", 
"Applicant", 
"ApplicantDescription", 
"Direction", 
"FirstContact", 
"SecondContact", 
"FirstApprover", 
"SecondApprover"
    },
    new string[] {
        "División", 
"Solicitante", 
"Descripción de la solicitante", 
"Dirección", 
"Primer contacto", 
"Segundo contacto", 
"Primer aprobador", 
"Segundo aprobador"
    },
    new string[] {
        "Division", 
"Applicant", 
"ApplicantDescription", 
"Direction", 
"FirstContact", 
"SecondContact", 
"FirstApprover", 
"SecondApprover"
    },
    new string[] {
        "División", 
"Solicitante", 
"Descripción de la solicitante", 
"Dirección", 
"Primer contacto", 
"Segundo contacto", 
"Primer aprobador", 
"Segundo aprobador"
    });

RL_24a7f9997087be4da8bf09ab1b655746 tmp = new();
tmp.Reader = reader;

outParamOut = (RL_24a7f9997087be4da8bf09ab1b655746)tmp.Duplicate();
}


/// <summary>
/// JSONSerialize: JsonSerializeImportOrderDistributionConfigFromExcelJSONSerialize1
///  (K4ynj5pbWx0WM1vYTfu4JIg)  of Action "ImportOrderDistributionConfigFromExcel"
/// </summary>
public static void JsonSerializeImportOrderDistributionConfigFromExcelJSONSerialize1 (EN_4ad0cdb13562998fda111463f2af9c31EntityRecord inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.Send,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

}


}
