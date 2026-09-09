using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel).Namespace);

    public long inParami_OrderId;
public long inParamApplicantId;
public RL_123aa03224ec08dab8cbe26021987012 inParamLocalSelectedLines;
public bool varLcl_IsApplyToAll;
public DateTime varLcDeliveryDate;
public RC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec;
public bool varLcMaxAmountError;
public bool varLcDatesQuantityPEPError;
public bool varLcWithFilesError;
public bool varLcWithDatesError;
public bool varLcWithQuantityError;
public bool varLcWithPaymentError;
public bool varLcWithConceptMinutesError;
public bool varLcWithApprovalProcessError;
public bool varLcWithprorata;
public string varLcComments;
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoiceToCreate;
public ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeignToCreate;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra;
public int varLcMinuteSelected;
public RC_1c2482ce6cd4b83ca44ec0510b231d44 varLcConstructionStruct;
public RL_f4c5cb6ef02fae333513cbd4dafd500c varLcMinuteDocumentTypeList;
public long varLcl_ApprovalProcessId;
public AggregateRecord<RL_4d304652a66e6de5c7b4ce65fcc7c50b> ScreenDataSetGetApprovalList;
public AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce> ScreenDataSetGetOrderDetail;
public ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutes_Model varLcGetMinutes;
public ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetSummary_Model varLcGetSummary;
public ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Model varLcGetMinutesDocuments;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel(long inParami_OrderId, long inParamApplicantId, RL_123aa03224ec08dab8cbe26021987012 inParamLocalSelectedLines, bool varLcl_IsApplyToAll, DateTime varLcDeliveryDate, RC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec, bool varLcMaxAmountError, bool varLcDatesQuantityPEPError, bool varLcWithFilesError, bool varLcWithDatesError, bool varLcWithQuantityError, bool varLcWithPaymentError, bool varLcWithConceptMinutesError, bool varLcWithApprovalProcessError, bool varLcWithprorata, string varLcComments, EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoiceToCreate, ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeignToCreate, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra, int varLcMinuteSelected, RC_1c2482ce6cd4b83ca44ec0510b231d44 varLcConstructionStruct, RL_f4c5cb6ef02fae333513cbd4dafd500c varLcMinuteDocumentTypeList, long varLcl_ApprovalProcessId, AggregateRecord<RL_4d304652a66e6de5c7b4ce65fcc7c50b> ScreenDataSetGetApprovalList, AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce> ScreenDataSetGetOrderDetail, ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutes_Model varLcGetMinutes, ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetSummary_Model varLcGetSummary, ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Model varLcGetMinutesDocuments, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderId", "ApplicantId", "LocalSelectedLines", "l_IsApplyToAll", "DeliveryDate", "l_SummaryRec", "MaxAmountError", "DatesQuantityPEPError", "WithFilesError", "WithDatesError", "WithQuantityError", "WithPaymentError", "WithConceptMinutesError", "WithApprovalProcessError", "Withprorata", "Comments", "InvoiceToCreate", "InvoiceForeignToCreate", "FilesList", "FilesListExtra", "MinuteSelected", "ConstructionStruct", "MinuteDocumentTypeList", "l_ApprovalProcessId", "GetApprovalList", "GetOrderDetail", "GetMinutes", "GetSettings", "GetSummary", "GetMinutesDocuments", "ClientVars"}, new string[] {"inParami_OrderId", "inParamApplicantId", "inParamLocalSelectedLines", "varLcl_IsApplyToAll", "varLcDeliveryDate", "varLcl_SummaryRec", "varLcMaxAmountError", "varLcDatesQuantityPEPError", "varLcWithFilesError", "varLcWithDatesError", "varLcWithQuantityError", "varLcWithPaymentError", "varLcWithConceptMinutesError", "varLcWithApprovalProcessError", "varLcWithprorata", "varLcComments", "varLcInvoiceToCreate", "varLcInvoiceForeignToCreate", "varLcFilesList", "varLcFilesListExtra", "varLcMinuteSelected", "varLcConstructionStruct", "varLcMinuteDocumentTypeList", "varLcl_ApprovalProcessId", "ScreenDataSetGetApprovalList", "ScreenDataSetGetOrderDetail", "varLcGetMinutes", "varLcGetSettings", "varLcGetSummary", "varLcGetMinutesDocuments", "clientVariables"});
this.inParami_OrderId = inParami_OrderId;
this.inParamApplicantId = inParamApplicantId;
this.inParamLocalSelectedLines = inParamLocalSelectedLines;
this.varLcl_IsApplyToAll = varLcl_IsApplyToAll;
this.varLcDeliveryDate = varLcDeliveryDate;
this.varLcl_SummaryRec = varLcl_SummaryRec;
this.varLcMaxAmountError = varLcMaxAmountError;
this.varLcDatesQuantityPEPError = varLcDatesQuantityPEPError;
this.varLcWithFilesError = varLcWithFilesError;
this.varLcWithDatesError = varLcWithDatesError;
this.varLcWithQuantityError = varLcWithQuantityError;
this.varLcWithPaymentError = varLcWithPaymentError;
this.varLcWithConceptMinutesError = varLcWithConceptMinutesError;
this.varLcWithApprovalProcessError = varLcWithApprovalProcessError;
this.varLcWithprorata = varLcWithprorata;
this.varLcComments = varLcComments;
this.varLcInvoiceToCreate = varLcInvoiceToCreate;
this.varLcInvoiceForeignToCreate = varLcInvoiceForeignToCreate;
this.varLcFilesList = varLcFilesList;
this.varLcFilesListExtra = varLcFilesListExtra;
this.varLcMinuteSelected = varLcMinuteSelected;
this.varLcConstructionStruct = varLcConstructionStruct;
this.varLcMinuteDocumentTypeList = varLcMinuteDocumentTypeList;
this.varLcl_ApprovalProcessId = varLcl_ApprovalProcessId;
this.ScreenDataSetGetApprovalList = ScreenDataSetGetApprovalList;
this.ScreenDataSetGetOrderDetail = ScreenDataSetGetOrderDetail;
this.varLcGetMinutes = varLcGetMinutes;
this.varLcGetSettings = varLcGetSettings;
this.varLcGetSummary = varLcGetSummary;
this.varLcGetMinutesDocuments = varLcGetMinutesDocuments;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_79a64780c4264a7ff3588d1347b5f259> datasetGetApprovalListReadDbAsync(RC_79a64780c4264a7ff3588d1347b5f259 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENTelcelDirection.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalList" N_BysYwTHEGXqcWxeJ9pAA of Action "Wb_FolioCreateConstruction"
public static async Task<(RL_4d304652a66e6de5c7b4ce65fcc7c50b,long)> datasetGetApprovalList(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpteTelcelDirection_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioCreateConstruction.GetApprovalList", "b172f037-138c-411c-97a9-c5b1789f6900");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioCreateConstruction","j_FoliosSAE.Wb_FolioCreateConstruction.GetApprovalList");
// Query Iterations: Never
// Refresh Query MG+4FVD1OUaFnj8w+CLPBg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.84EZ_b8daESKUPT4OkRC1w/ScreenDataSets.N_BysYwTHEGXqcWxeJ9pAA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37");
fromBuilder.Append(" FROM ((({TelcelDirection} \"entelceldirection21\" Inner JOIN {User_Extended_Internal} \"enuser_extended_internal149\" ON (\"entelceldirection21\".\"id\" = \"enuser_extended_internal149\".\"telceldirectionid\"))  Left JOIN {User} \"enuser254\" ON (\"enuser_extended_internal149\".\"id\" = \"enuser254\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole94\" ON (\"enuser_extended_internal149\".\"entraroleid\" = \"enentrarole94\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpteTelcelDirection_Id != 0) {
whereBuilder.Append("((\"entelceldirection21\".\"id\" = @qpteTelcelDirection_Id) AND (\"entelceldirection21\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirection_Id", DbType.Int64, qpteTelcelDirection_Id);
} else {
whereBuilder.Append("(\"entelceldirection21\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enentrarole94\".\"isareausuaria\" = 1)");
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
RL_4d304652a66e6de5c7b4ce65fcc7c50b outParamList = new RL_4d304652a66e6de5c7b4ce65fcc7c50b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalListReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioCreateConstruction.GetApprovalList.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4d304652a66e6de5c7b4ce65fcc7c50b _tmp = new RL_4d304652a66e6de5c7b4ce65fcc7c50b();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalListReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioCreateConstruction.GetApprovalList.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4d304652a66e6de5c7b4ce65fcc7c50b)_tmp;
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

private static async Task<RC_03b2a2565369f3088e5267bce38cfba9> datasetGetOrderDetailReadDbAsync(RC_03b2a2565369f3088e5267bce38cfba9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENPaymentMethods.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrderDetail" TogMt37x_0GGFhqmFxUWdQ of Action "Wb_FolioCreateConstruction"
public static async Task<(RL_398a2e7b47dcd31617b8f6499aea0bce,long)> datasetGetOrderDetail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioCreateConstruction.GetOrderDetail", "b70c884e-f17e-41ff-8616-1aa617151675");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioCreateConstruction","j_FoliosSAE.Wb_FolioCreateConstruction.GetOrderDetail");
// Query Iterations: Never
// Refresh Query UMcb46UlU0aLIt0hN8JoNA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.84EZ_b8daESKUPT4OkRC1w/ScreenDataSets.TogMt37x_0GGFhqmFxUWdQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, \"enordermain160\".\"ordernumber\" o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, \"enordermain160\".\"telceldirectionid\" o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128");
fromBuilder.Append(" FROM ((((({OrderMain} \"enordermain160\" Inner JOIN {Supplier} \"ensupplier159\" ON (\"enordermain160\".\"supplierid\" = \"ensupplier159\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail27\" ON (\"enordermain160\".\"id\" = \"enorderdetail27\".\"orderid\"))  Left JOIN {PaymentMethods} \"enpaymentmethods17\" ON (\"enorderdetail27\".\"paymentmethodid\" = \"enpaymentmethods17\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms37\" ON (\"enorderdetail27\".\"paymenttermsid\" = \"enpaymentterms37\".\"id\"))  Left JOIN {Region} \"enregion206\" ON (\"enordermain160\".\"regionid\" = \"enregion206\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain160\".\"id\" = @qporOrderMain_Id) AND (\"enordermain160\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain160\".\"id\" IS NULL)");
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
RL_398a2e7b47dcd31617b8f6499aea0bce outParamList = new RL_398a2e7b47dcd31617b8f6499aea0bce();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderDetailReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioCreateConstruction.GetOrderDetail.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_398a2e7b47dcd31617b8f6499aea0bce _tmp = new RL_398a2e7b47dcd31617b8f6499aea0bce();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderDetailReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioCreateConstruction.GetOrderDetail.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_398a2e7b47dcd31617b8f6499aea0bce)_tmp;
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


    public class lcvGetMinutes : VarsBag {
public Actions.lcoGetMinuteType resGetMinuteType =  new Actions.lcoGetMinuteType();
public lcvGetMinutes() {
}
}
public class lcoGetMinutes : VarsBag {
public RL_a579a1a05eaaba551100ea61f4cb3f6b outParamKeyValueList = new RL_a579a1a05eaaba551100ea61f4cb3f6b();

public lcoGetMinutes() {
}
}
/// <summary>
/// Action <code>GetMinutes</code> that represents the Service Studio action <code>GetMinutes</code>
///  <p> Description: </p>
/// </summary>
public async Task<RL_a579a1a05eaaba551100ea61f4cb3f6b> DataActionGetMinutes(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_a579a1a05eaaba551100ea61f4cb3f6b outParamKeyValueList = default;
lcoGetMinutes result = new lcoGetMinutes();
lcvGetMinutes localVars = new lcvGetMinutes();
ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetMinutes", "00314119-99e1-47d3-9991-a235d72a1690"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioCreateConstruction", "GetMinutes")){
// GetMinuteType
localVars.resGetMinuteType.outParamList = await Actions.ActionGetMinuteType(requestContext,cancellationToken);

// KeyValueList = GetMinuteType.List
result.outParamKeyValueList=localVars.resGetMinuteType.outParamList;
} //close CreateActionActivity using block
} // try

finally {
outParamKeyValueList = result.outParamKeyValueList;
} // inner-finally
RETURN_STATEMENT:
return outParamKeyValueList;
}
public class lcoGetSettings : VarsBag {
public bool outParamo_IsActiveDEV_HU13008_Complement = false;

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: </p>
/// </summary>
public async Task<bool> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_IsActiveDEV_HU13008_Complement = default;
lcoGetSettings result = new lcoGetSettings();
ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "2c7fa6a0-961e-4790-bf2e-68fd2ba3548e"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioCreateConstruction", "GetSettings")){
// o_IsActiveDEV_HU13008_Complement = IsActiveDEV_HU13008_Complement
result.outParamo_IsActiveDEV_HU13008_Complement=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13008_Complement])));
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsActiveDEV_HU13008_Complement = result.outParamo_IsActiveDEV_HU13008_Complement;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsActiveDEV_HU13008_Complement;
}
public class lcvGetSummary : VarsBag {
public RL_d3c140b81b16482eac14fd0448f33de5 queryResGetTotalAmountDelivered_outParamList = new RL_d3c140b81b16482eac14fd0448f33de5();
public long queryResGetTotalAmountDelivered_outParamCount = 0L;

public RL_ecf075efbdf79b05fa564fa6ba80a9c6 queryResGetOrderItemEntries_outParamList = new RL_ecf075efbdf79b05fa564fa6ba80a9c6();
public long queryResGetOrderItemEntries_outParamCount = 0L;

public RL_164e5439119ae8b31002cd319dbe8413 queryResGetOrderMainById_outParamList = new RL_164e5439119ae8b31002cd319dbe8413();
public long queryResGetOrderMainById_outParamCount = 0L;

public RL_312927afcf3eb9d5fa3bc02bbc91d978 queryResGetTotalFromOriginal_outParamList = new RL_312927afcf3eb9d5fa3bc02bbc91d978();
public long queryResGetTotalFromOriginal_outParamCount = 0L;

public lcvGetSummary() {
}
}
public class lcoGetSummary : VarsBag {
public RC_0b2176705fa164c9531eb643caf0e9d4 outParamo_SummaryRec = new RC_0b2176705fa164c9531eb643caf0e9d4();

public lcoGetSummary() {
}
}
/// <summary>
/// Action <code>GetSummary</code> that represents the Service Studio action <code>GetSummary</code>
///  <p> Description: </p>
/// </summary>
public async Task<RC_0b2176705fa164c9531eb643caf0e9d4> DataActionGetSummary(IRequestContext requestContext,CancellationToken cancellationToken) {
RC_0b2176705fa164c9531eb643caf0e9d4 outParamo_SummaryRec = default;
lcoGetSummary result = new lcoGetSummary();
lcvGetSummary localVars = new lcvGetSummary();
ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSummary", "3496a11a-09f4-43f5-a396-a22002220bce"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioCreateConstruction", "GetSummary")){
// Query datasetGetOrderMainById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainById_maxRecords = 0;
int datasetGetOrderMainById_startIndex = 0;(localVars.queryResGetOrderMainById_outParamList,localVars.queryResGetOrderMainById_outParamCount) = await FuncDataActionGetSummary.datasetGetOrderMainById(requestContext,datasetGetOrderMainById_maxRecords,datasetGetOrderMainById_startIndex,IterationMultiplicity.Never,inParami_OrderId,cancellationToken);

// Query datasetGetTotalAmountDelivered
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTotalAmountDelivered_maxRecords = 0;
int datasetGetTotalAmountDelivered_startIndex = 0;(localVars.queryResGetTotalAmountDelivered_outParamList,localVars.queryResGetTotalAmountDelivered_outParamCount) = await FuncDataActionGetSummary.datasetGetTotalAmountDelivered(requestContext,datasetGetTotalAmountDelivered_maxRecords,datasetGetTotalAmountDelivered_startIndex,IterationMultiplicity.Never,inParami_OrderId,cancellationToken);

// Query datasetGetTotalFromOriginal
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTotalFromOriginal_maxRecords = 0;
int datasetGetTotalFromOriginal_startIndex = 0;(localVars.queryResGetTotalFromOriginal_outParamList,localVars.queryResGetTotalFromOriginal_outParamCount) = await FuncDataActionGetSummary.datasetGetTotalFromOriginal(requestContext,datasetGetTotalFromOriginal_maxRecords,datasetGetTotalFromOriginal_startIndex,IterationMultiplicity.Never,inParami_OrderId,cancellationToken);

// Query datasetGetOrderItemEntries
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderItemEntries_maxRecords = 0;
int datasetGetOrderItemEntries_startIndex = 0;(localVars.queryResGetOrderItemEntries_outParamList,localVars.queryResGetOrderItemEntries_outParamCount) = await FuncDataActionGetSummary.datasetGetOrderItemEntries(requestContext,datasetGetOrderItemEntries_maxRecords,datasetGetOrderItemEntries_startIndex,IterationMultiplicity.Never,inParami_OrderId,cancellationToken);

// Foreach LocalSelectedLines
inParamLocalSelectedLines.StartIteration();
try {while (!((inParamLocalSelectedLines.Eof))) {
// o_SummaryRec.MaxAlowed = o_SummaryRec.MaxAlowed + LocalSelectedLines.Current.RemainingQttTotal / LocalSelectedLines.Current.BaseQuantity * LocalSelectedLines.Current.UnitPrice
result.outParamo_SummaryRec.ssMaxAlowed = (result.outParamo_SummaryRec.ssMaxAlowed+(((decimal)inParamLocalSelectedLines.CurrentRec.ssRemainingQttTotal/
(decimal)(((decimal)inParamLocalSelectedLines.CurrentRec.ssBaseQuantity)))*inParamLocalSelectedLines.CurrentRec.ssUnitPrice));
inParamLocalSelectedLines.Advance();
}

} finally {
inParamLocalSelectedLines.EndIteration();
}

// o_SummaryRec.TotalAmount = TextToDecimal
result.outParamo_SummaryRec.ssTotalAmount = BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal (localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount, 2, ".", ""));

// o_SummaryRec.PercentageDelivered = TextToDecimal
result.outParamo_SummaryRec.ssPercentageDelivered = BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal ((((((localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount+localVars.queryResGetTotalFromOriginal_outParamList.CurrentRec.ssTotalSAPSum)+localVars.queryResGetOrderItemEntries_outParamList.CurrentRec.ssTotalSum)==(((decimal)0)))) ? ((((decimal)0))) : ((((decimal)((localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum+localVars.queryResGetTotalFromOriginal_outParamList.CurrentRec.ssTotalSAPSum)+localVars.queryResGetOrderItemEntries_outParamList.CurrentRec.ssTotalSum)/
(decimal)localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount)*(((decimal)100))))), 2, ".", ","));

// o_SummaryRec.AmountLeft = GetOrderMainById.List.Current.OrderMain.TotalAmount - GetTotalAmountDelivered.List.Current.TotalPriceSum - GetTotalFromOriginal.List.Current.TotalSAPSum - GetOrderItemEntries.List.Current.TotalSum
result.outParamo_SummaryRec.ssAmountLeft = (((localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount-localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum)-localVars.queryResGetTotalFromOriginal_outParamList.CurrentRec.ssTotalSAPSum)-localVars.queryResGetOrderItemEntries_outParamList.CurrentRec.ssTotalSum);

// o_SummaryRec.Currency = GetOrderMainById.List.Current.Currency.Code
result.outParamo_SummaryRec.ssCurrency = localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENCurrency.ssCode;

// o_SummaryRec.AmountDelivered = GetTotalAmountDelivered.List.Current.TotalPriceSum + GetTotalFromOriginal.List.Current.TotalSAPSum + GetOrderItemEntries.List.Current.TotalSum
result.outParamo_SummaryRec.ssAmountDelivered = ((localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum+localVars.queryResGetTotalFromOriginal_outParamList.CurrentRec.ssTotalSAPSum)+localVars.queryResGetOrderItemEntries_outParamList.CurrentRec.ssTotalSum);

// o_SummaryRec.InvoicingAmount = InvoiceToCreate.TotalAmount
result.outParamo_SummaryRec.ssInvoicingAmount = varLcInvoiceToCreate.ssTotalAmount;

// o_SummaryRec.Difference_FormSAE_Invoice_Percent = If
result.outParamo_SummaryRec.ssDifference_FormSAE_Invoice_Percent = ((((localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount-localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum)!=(((decimal)0)))) ? ((((decimal)result.outParamo_SummaryRec.ssInvoicingAmount/
(decimal)(localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount-localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum))*(((decimal)100)))) : ((((decimal)0))));
// Set 2 decimals
// o_SummaryRec.AmountDelivered = TextToDecimal
result.outParamo_SummaryRec.ssAmountDelivered = BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal (result.outParamo_SummaryRec.ssAmountDelivered, 2, ".", ""));

// o_SummaryRec.AmountLeft = TextToDecimal
result.outParamo_SummaryRec.ssAmountLeft = BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal (result.outParamo_SummaryRec.ssAmountLeft, 2, ".", ""));

// o_SummaryRec.MaxAlowed = TextToDecimal
result.outParamo_SummaryRec.ssMaxAlowed = BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal (result.outParamo_SummaryRec.ssMaxAlowed, 2, ".", ""));
} //close CreateActionActivity using block
} // try

finally {
outParamo_SummaryRec = result.outParamo_SummaryRec;
} // inner-finally
RETURN_STATEMENT:
return outParamo_SummaryRec;
}
public class lcvGetMinutesDocuments : VarsBag {
public Actions.lcoGetDocumentsListByMinuteType resGetDocumentsListByMinuteType =  new Actions.lcoGetDocumentsListByMinuteType();
public lcvGetMinutesDocuments() {
}
}
public class lcoGetMinutesDocuments : VarsBag {
public RL_f4c5cb6ef02fae333513cbd4dafd500c outParamList = new RL_f4c5cb6ef02fae333513cbd4dafd500c();

public lcoGetMinutesDocuments() {
}
}
/// <summary>
/// Action <code>GetMinutesDocuments</code> that represents the Service Studio action
///  <code>GetMinutesDocuments</code> <p> Description: </p>
/// </summary>
public async Task<RL_f4c5cb6ef02fae333513cbd4dafd500c> DataActionGetMinutesDocuments(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_f4c5cb6ef02fae333513cbd4dafd500c outParamList = default;
lcoGetMinutesDocuments result = new lcoGetMinutesDocuments();
lcvGetMinutesDocuments localVars = new lcvGetMinutesDocuments();
ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetMinutesDocuments", "add3865e-ef59-48cd-b129-4dfefe689ba0"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioCreateConstruction", "GetMinutesDocuments")){
// GetDocumentsListByMinuteType
localVars.resGetDocumentsListByMinuteType.outParamList = await Actions.ActionGetDocumentsListByMinuteType(requestContext,varLcMinuteSelected,cancellationToken);

// List = GetDocumentsListByMinuteType.List
result.outParamList=(await RL_f4c5cb6ef02fae333513cbd4dafd500c.ConvertAsync(localVars.resGetDocumentsListByMinuteType.outParamList, new RL_f4c5cb6ef02fae333513cbd4dafd500c(), async (ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure source, ST_b2fd0f57faec93f17ef861f417f1cd5cStructure target, CancellationToken cancellationToken) => {
target.ssKey = source.ssKey;
target.ssValue = source.ssValue;
target.ssFileName = source.ssFileName;
target.ssMandatory = source.ssMandatory;
target.ssWithDocument = source.ssWithDocument;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
} // inner-finally
RETURN_STATEMENT:
return outParamList;
}


    public static class FuncDataActionGetMinutes {
}
public static class FuncDataActionGetSettings {
}
public static class FuncDataActionGetSummary {

// Query Function "GetTotalAmountDelivered" 2G6BDNOmP0aG6TRaiy5J5Q of Action "GetSummary"
public static async Task<(RL_d3c140b81b16482eac14fd0448f33de5,long)> datasetGetTotalAmountDelivered(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporFolio_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetTotalAmountDelivered", "0c816ed8-a6d3-463f-86e9-345a8b2e49e5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetTotalAmountDelivered", "0c816ed8-a6d3-463f-86e9-345a8b2e49e5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.84EZ_b8daESKUPT4OkRC1w/DataActions.GqGWNPQJ9UOjlqIgAiILzg/NodesNotShownInESpaceTree.2G6BDNOmP0aG6TRaiy5J5Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"enfolioitems23\".\"totalprice\") \"totalpricesum\"");
fromBuilder.Append(" FROM ({Folio} \"enfolio120\" Left JOIN {FolioItems} \"enfolioitems23\" ON (\"enfolio120\".\"id\" = \"enfolioitems23\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qporFolio_OrderId != 0) {
whereBuilder.Append("((\"enfolio120\".\"orderid\" = @qporFolio_OrderId) AND (\"enfolio120\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporFolio_OrderId", DbType.Int64, qporFolio_OrderId);
} else {
whereBuilder.Append("(\"enfolio120\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND ((\"enfolio120\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId);
whereBuilder.Append(") AND (\"enfolio120\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId);
whereBuilder.Append("))");
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
RL_d3c140b81b16482eac14fd0448f33de5 outParamList = new RL_d3c140b81b16482eac14fd0448f33de5();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetTotalAmountDelivered.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d3c140b81b16482eac14fd0448f33de5 _tmp = new RL_d3c140b81b16482eac14fd0448f33de5();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetTotalAmountDelivered.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d3c140b81b16482eac14fd0448f33de5)_tmp;
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

// Query Function "GetOrderItemEntries" bOKQJGcPiEK6dRqNEV5EUA of Action "GetSummary"
public static async Task<(RL_ecf075efbdf79b05fa564fa6ba80a9c6,long)> datasetGetOrderItemEntries(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetOrderItemEntries", "2490e26c-0f67-4288-ba75-1a8d115e4450");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetOrderItemEntries", "2490e26c-0f67-4288-ba75-1a8d115e4450", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.84EZ_b8daESKUPT4OkRC1w/DataActions.GqGWNPQJ9UOjlqIgAiILzg/NodesNotShownInESpaceTree.bOKQJGcPiEK6dRqNEV5EUA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum((\"enorderitementries10\".\"quantity_\" * \"enordermainitem41\".\"unitprice\")) \"totalsum\"");
fromBuilder.Append(" FROM (({OrderItemEntries} \"enorderitementries10\" Inner JOIN {OrderMainItem} \"enordermainitem41\" ON (\"enorderitementries10\".\"ordermainitemid\" = \"enordermainitem41\".\"id\"))  Inner JOIN {OrderMain} \"enordermain161\" ON (\"enordermainitem41\".\"ordermainid\" = \"enordermain161\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enorderitementries10\".\"quantity_\" > cast(0 as decimal)) AND ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain161\".\"id\" = @qporOrderMain_Id) AND (\"enordermain161\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain161\".\"id\" IS NULL)");
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
RL_ecf075efbdf79b05fa564fa6ba80a9c6 outParamList = new RL_ecf075efbdf79b05fa564fa6ba80a9c6();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetOrderItemEntries.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ecf075efbdf79b05fa564fa6ba80a9c6 _tmp = new RL_ecf075efbdf79b05fa564fa6ba80a9c6();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetOrderItemEntries.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ecf075efbdf79b05fa564fa6ba80a9c6)_tmp;
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

private static async Task<RC_a074711a91fd2441798a860685e4898b> datasetGetOrderMainByIdReadDbAsync(RC_a074711a91fd2441798a860685e4898b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCurrency.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainById" L68aQchyrESYjjZVdK2zgg of Action "GetSummary"
public static async Task<(RL_164e5439119ae8b31002cd319dbe8413,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetOrderMainById", "411aaf2f-72c8-44ac-988e-365574adb382");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetOrderMainById", "411aaf2f-72c8-44ac-988e-365574adb382", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.84EZ_b8daESKUPT4OkRC1w/DataActions.GqGWNPQJ9UOjlqIgAiILzg/NodesNotShownInESpaceTree.L68aQchyrESYjjZVdK2zgg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency54\".\"code\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, trim_scale(\"enordermain162\".\"totalamount\"::numeric) o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33");
fromBuilder.Append(" FROM ({OrderMain} \"enordermain162\" Left JOIN {Currency} \"encurrency54\" ON (\"enordermain162\".\"currencyid\" = \"encurrency54\".\"code\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain162\".\"id\" = @qporOrderMain_Id) AND (\"enordermain162\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain162\".\"id\" IS NULL)");
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
RL_164e5439119ae8b31002cd319dbe8413 outParamList = new RL_164e5439119ae8b31002cd319dbe8413();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetOrderMainById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_164e5439119ae8b31002cd319dbe8413 _tmp = new RL_164e5439119ae8b31002cd319dbe8413();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetOrderMainById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_164e5439119ae8b31002cd319dbe8413)_tmp;
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

// Query Function "GetTotalFromOriginal" HBMdj+d+lEGljhppcsKItA of Action "GetSummary"
public static async Task<(RL_312927afcf3eb9d5fa3bc02bbc91d978,long)> datasetGetTotalFromOriginal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetTotalFromOriginal", "8f1d131c-7ee7-4194-a58e-1a6972c288b4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetTotalFromOriginal", "8f1d131c-7ee7-4194-a58e-1a6972c288b4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.84EZ_b8daESKUPT4OkRC1w/DataActions.GqGWNPQJ9UOjlqIgAiILzg/NodesNotShownInESpaceTree.HBMdj+d+lEGljhppcsKItA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum((\"enordermainitem42\".\"quantitydelivered\" * \"enordermainitem42\".\"unitprice\")) \"totalsapsum\"");
fromBuilder.Append(" FROM {OrderMainItem} \"enordermainitem42\"");
whereBuilder.Append(" WHERE ");
if (qporOrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem42\".\"ordermainid\" = @qporOrderMainId) AND (\"enordermainitem42\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainId", DbType.Int64, qporOrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem42\".\"ordermainid\" IS NULL)");
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
RL_312927afcf3eb9d5fa3bc02bbc91d978 outParamList = new RL_312927afcf3eb9d5fa3bc02bbc91d978();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetTotalFromOriginal.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_312927afcf3eb9d5fa3bc02bbc91d978 _tmp = new RL_312927afcf3eb9d5fa3bc02bbc91d978();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioCreateConstruction.GetSummary.GetTotalFromOriginal.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_312927afcf3eb9d5fa3bc02bbc91d978)_tmp;
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
public static class FuncDataActionGetMinutesDocuments {
}


}
