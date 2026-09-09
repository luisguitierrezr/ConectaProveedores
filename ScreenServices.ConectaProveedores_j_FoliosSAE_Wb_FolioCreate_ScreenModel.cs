using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel).Namespace);

    public long inParami_OrderId;
public RL_123aa03224ec08dab8cbe26021987012 inParamLocalSelectedLines;
public int inParamAprovalProcessTypeId;
public bool varLcl_IsApplyToAll;
public DateTime varLcDeliveryDate;
public RC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec;
public bool varLcWithDatesError;
public bool varLcWithQuantityError;
public bool varLcWithFilesError;
public bool varLcWithProrata;
public bool varLcApproverValid;
public string varLcApproverErrorMessage;
public string varLcfirstUserIdentifier;
public long varLcOrderAccConceptsIdToCreate;
public bool varLcDatesQuantityPEPError;
public bool varLcMaxAmountError;
public string varLcComments;
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoiceToCreate;
public ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeignToCreate;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcCreditNoteFilesList;
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcCreditNoteInvoiceToCreate;
public bool varLcCreditNote_IsNeeded;
public bool varLcL_IsNational;
public EN_f81a3d226103fd013068b8763798067aEntityRecord varLcInvoiceExtendedToCreate;
public decimal varLcl_ImportAnticipo;
public AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce> ScreenDataSetGetOrderDetail;
public ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetFirstApproverList_Model varLcGetFirstApproverList;
public ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSummary_Model varLcGetSummary;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel(long inParami_OrderId, RL_123aa03224ec08dab8cbe26021987012 inParamLocalSelectedLines, int inParamAprovalProcessTypeId, bool varLcl_IsApplyToAll, DateTime varLcDeliveryDate, RC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec, bool varLcWithDatesError, bool varLcWithQuantityError, bool varLcWithFilesError, bool varLcWithProrata, bool varLcApproverValid, string varLcApproverErrorMessage, string varLcfirstUserIdentifier, long varLcOrderAccConceptsIdToCreate, bool varLcDatesQuantityPEPError, bool varLcMaxAmountError, string varLcComments, EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoiceToCreate, ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeignToCreate, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra, RL_1501ee54ff868a67eff67465502ee3d9 varLcCreditNoteFilesList, EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcCreditNoteInvoiceToCreate, bool varLcCreditNote_IsNeeded, bool varLcL_IsNational, EN_f81a3d226103fd013068b8763798067aEntityRecord varLcInvoiceExtendedToCreate, decimal varLcl_ImportAnticipo, AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce> ScreenDataSetGetOrderDetail, ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetFirstApproverList_Model varLcGetFirstApproverList, ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_DataActionGetSummary_Model varLcGetSummary, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderId", "LocalSelectedLines", "AprovalProcessTypeId", "l_IsApplyToAll", "DeliveryDate", "l_SummaryRec", "WithDatesError", "WithQuantityError", "WithFilesError", "WithProrata", "ApproverValid", "ApproverErrorMessage", "firstUserIdentifier", "OrderAccConceptsIdToCreate", "DatesQuantityPEPError", "MaxAmountError", "Comments", "InvoiceToCreate", "InvoiceForeignToCreate", "FilesList", "FilesListExtra", "CreditNoteFilesList", "CreditNoteInvoiceToCreate", "CreditNote_IsNeeded", "L_IsNational", "InvoiceExtendedToCreate", "l_ImportAnticipo", "GetOrderDetail", "GetFirstApproverList", "GetSettings", "GetSummary", "ClientVars"}, new string[] {"inParami_OrderId", "inParamLocalSelectedLines", "inParamAprovalProcessTypeId", "varLcl_IsApplyToAll", "varLcDeliveryDate", "varLcl_SummaryRec", "varLcWithDatesError", "varLcWithQuantityError", "varLcWithFilesError", "varLcWithProrata", "varLcApproverValid", "varLcApproverErrorMessage", "varLcfirstUserIdentifier", "varLcOrderAccConceptsIdToCreate", "varLcDatesQuantityPEPError", "varLcMaxAmountError", "varLcComments", "varLcInvoiceToCreate", "varLcInvoiceForeignToCreate", "varLcFilesList", "varLcFilesListExtra", "varLcCreditNoteFilesList", "varLcCreditNoteInvoiceToCreate", "varLcCreditNote_IsNeeded", "varLcL_IsNational", "varLcInvoiceExtendedToCreate", "varLcl_ImportAnticipo", "ScreenDataSetGetOrderDetail", "varLcGetFirstApproverList", "varLcGetSettings", "varLcGetSummary", "clientVariables"});
this.inParami_OrderId = inParami_OrderId;
this.inParamLocalSelectedLines = inParamLocalSelectedLines;
this.inParamAprovalProcessTypeId = inParamAprovalProcessTypeId;
this.varLcl_IsApplyToAll = varLcl_IsApplyToAll;
this.varLcDeliveryDate = varLcDeliveryDate;
this.varLcl_SummaryRec = varLcl_SummaryRec;
this.varLcWithDatesError = varLcWithDatesError;
this.varLcWithQuantityError = varLcWithQuantityError;
this.varLcWithFilesError = varLcWithFilesError;
this.varLcWithProrata = varLcWithProrata;
this.varLcApproverValid = varLcApproverValid;
this.varLcApproverErrorMessage = varLcApproverErrorMessage;
this.varLcfirstUserIdentifier = varLcfirstUserIdentifier;
this.varLcOrderAccConceptsIdToCreate = varLcOrderAccConceptsIdToCreate;
this.varLcDatesQuantityPEPError = varLcDatesQuantityPEPError;
this.varLcMaxAmountError = varLcMaxAmountError;
this.varLcComments = varLcComments;
this.varLcInvoiceToCreate = varLcInvoiceToCreate;
this.varLcInvoiceForeignToCreate = varLcInvoiceForeignToCreate;
this.varLcFilesList = varLcFilesList;
this.varLcFilesListExtra = varLcFilesListExtra;
this.varLcCreditNoteFilesList = varLcCreditNoteFilesList;
this.varLcCreditNoteInvoiceToCreate = varLcCreditNoteInvoiceToCreate;
this.varLcCreditNote_IsNeeded = varLcCreditNote_IsNeeded;
this.varLcL_IsNational = varLcL_IsNational;
this.varLcInvoiceExtendedToCreate = varLcInvoiceExtendedToCreate;
this.varLcl_ImportAnticipo = varLcl_ImportAnticipo;
this.ScreenDataSetGetOrderDetail = ScreenDataSetGetOrderDetail;
this.varLcGetFirstApproverList = varLcGetFirstApproverList;
this.varLcGetSettings = varLcGetSettings;
this.varLcGetSummary = varLcGetSummary;
this.clientVariables = clientVariables;
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
// Query Function "GetOrderDetail" rM4BqZBGXkGl8RddlyWC3w of Action "Wb_FolioCreate"
public static async Task<(RL_398a2e7b47dcd31617b8f6499aea0bce,long)> datasetGetOrderDetail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioCreate.GetOrderDetail", "a901ceac-4690-415e-a5f1-175d972582df");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioCreate","j_FoliosSAE.Wb_FolioCreate.GetOrderDetail");
// Query Iterations: Never
// Refresh Query 1JioptxL8E+lzETzpBCX9Q Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.MqP0bz89b0KL_A5wodWoIg/ScreenDataSets.rM4BqZBGXkGl8RddlyWC3w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, \"enordermain143\".\"ordernumber\" o40, NULL o41, NULL o42, NULL o43, \"enordermain143\".\"assignmentcode\" o44, NULL o45, NULL o46, NULL o47, \"enordermain143\".\"currencyid\" o48, \"enordermain143\".\"telceldirectionid\" o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, \"enordermain143\".\"applicant\" o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, \"ensupplier145\".\"pais\" o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128");
fromBuilder.Append(" FROM ((((({OrderMain} \"enordermain143\" Inner JOIN {Supplier} \"ensupplier145\" ON (\"enordermain143\".\"supplierid\" = \"ensupplier145\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail24\" ON (\"enordermain143\".\"id\" = \"enorderdetail24\".\"orderid\"))  Left JOIN {PaymentMethods} \"enpaymentmethods15\" ON (\"enorderdetail24\".\"paymentmethodid\" = \"enpaymentmethods15\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms35\" ON (\"enorderdetail24\".\"paymenttermsid\" = \"enpaymentterms35\".\"id\"))  Left JOIN {Region} \"enregion191\" ON (\"enordermain143\".\"regionid\" = \"enregion191\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain143\".\"id\" = @qporOrderMain_Id) AND (\"enordermain143\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain143\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, false, true, true, true, false, true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioCreate.GetOrderDetail.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioCreate.GetOrderDetail.List", cancellationToken: cancellationToken);
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


    public class lcvGetFirstApproverList : VarsBag {
public RL_edd624fe5c8ecd3e4777bf56612edbf5 queryResGetApprovalList_outParamList = new RL_edd624fe5c8ecd3e4777bf56612edbf5();
public long queryResGetApprovalList_outParamCount = 0L;

public RL_b56721e24b85ff178b55a9b290c3bf31 queryResGetApplicantTelcelDirectionRelation_outParamList = new RL_b56721e24b85ff178b55a9b290c3bf31();
public long queryResGetApplicantTelcelDirectionRelation_outParamCount = 0L;

public RL_edd624fe5c8ecd3e4777bf56612edbf5 queryResGetApprovalList2_outParamList = new RL_edd624fe5c8ecd3e4777bf56612edbf5();
public long queryResGetApprovalList2_outParamCount = 0L;

public lcvGetFirstApproverList() {
}
}
public class lcoGetFirstApproverList : VarsBag {
public RL_648f5b7a91b58d2f6ade938e7f17a9f2 outParamFirstApproverList = new RL_648f5b7a91b58d2f6ade938e7f17a9f2();

public lcoGetFirstApproverList() {
}
}
/// <summary>
/// Action <code>GetFirstApproverList</code> that represents the Service Studio action
///  <code>GetFirstApproverList</code> <p> Description: </p>
/// </summary>
public async Task<RL_648f5b7a91b58d2f6ade938e7f17a9f2> DataActionGetFirstApproverList(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_648f5b7a91b58d2f6ade938e7f17a9f2 outParamFirstApproverList = default;
lcoGetFirstApproverList result = new lcoGetFirstApproverList();
lcvGetFirstApproverList localVars = new lcvGetFirstApproverList();
ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetFirstApproverList", "0fdc4444-4411-4281-a06e-6c00a43d78ee"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioCreate", "GetFirstApproverList")){
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_TK494]))))) {
// Query datasetGetApplicantTelcelDirectionRelation
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApplicantTelcelDirectionRelation_maxRecords = 1;
if (datasetGetApplicantTelcelDirectionRelation_maxRecords < 1) datasetGetApplicantTelcelDirectionRelation_maxRecords = 1;
int datasetGetApplicantTelcelDirectionRelation_startIndex = 0;(localVars.queryResGetApplicantTelcelDirectionRelation_outParamList,localVars.queryResGetApplicantTelcelDirectionRelation_outParamCount) = await FuncDataActionGetFirstApproverList.datasetGetApplicantTelcelDirectionRelation(requestContext,datasetGetApplicantTelcelDirectionRelation_maxRecords,datasetGetApplicantTelcelDirectionRelation_startIndex,IterationMultiplicity.Never,ScreenDataSetGetOrderDetail.List.CurrentRec.ssENOrderMain.ssApplicant,cancellationToken);

// Empty?
if((!(localVars.queryResGetApplicantTelcelDirectionRelation_outParamList.Empty))) {
// Query datasetGetApprovalList2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalList2_maxRecords = 999999999;
if (datasetGetApprovalList2_maxRecords < 1) datasetGetApprovalList2_maxRecords = 1;
int datasetGetApprovalList2_startIndex = 0;(localVars.queryResGetApprovalList2_outParamList,localVars.queryResGetApprovalList2_outParamCount) = await FuncDataActionGetFirstApproverList.datasetGetApprovalList2(requestContext,datasetGetApprovalList2_maxRecords,datasetGetApprovalList2_startIndex,IterationMultiplicity.Single,localVars.queryResGetApplicantTelcelDirectionRelation_outParamList.CurrentRec.ssENApplicantTelcelDirection.ssTelcelDirectionId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment]))),cancellationToken);

// FirstApproverList = GetApprovalList2.List
result.outParamFirstApproverList=(await RL_648f5b7a91b58d2f6ade938e7f17a9f2.ConvertAsync(localVars.queryResGetApprovalList2_outParamList, new RL_648f5b7a91b58d2f6ade938e7f17a9f2(), async (RC_097150223bd4f9024b41b58833c5a636 source, RC_7170c97aaf61dfa14af07f5ef3cecd45 target, CancellationToken cancellationToken) => {
target.ssRolename = source.ssENEntraRole.ssRoleName;
target.ssUserId = source.ssENUser.ssId;
target.ssUserName = source.ssENUser.ssName;
return target;
}, cancellationToken));
goto RETURN_STATEMENT;

}

}

// Query datasetGetApprovalList
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalList_maxRecords = 999999999;
if (datasetGetApprovalList_maxRecords < 1) datasetGetApprovalList_maxRecords = 1;
int datasetGetApprovalList_startIndex = 0;(localVars.queryResGetApprovalList_outParamList,localVars.queryResGetApprovalList_outParamCount) = await FuncDataActionGetFirstApproverList.datasetGetApprovalList(requestContext,datasetGetApprovalList_maxRecords,datasetGetApprovalList_startIndex,IterationMultiplicity.Single,ScreenDataSetGetOrderDetail.List.CurrentRec.ssENOrderMain.ssTelcelDirectionId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment]))),cancellationToken);

// FirstApproverList = GetApprovalList.List
result.outParamFirstApproverList=(await RL_648f5b7a91b58d2f6ade938e7f17a9f2.ConvertAsync(localVars.queryResGetApprovalList_outParamList, new RL_648f5b7a91b58d2f6ade938e7f17a9f2(), async (RC_097150223bd4f9024b41b58833c5a636 source, RC_7170c97aaf61dfa14af07f5ef3cecd45 target, CancellationToken cancellationToken) => {
target.ssRolename = source.ssENEntraRole.ssRoleName;
target.ssUserId = source.ssENUser.ssId;
target.ssUserName = source.ssENUser.ssName;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamFirstApproverList = result.outParamFirstApproverList;
} // inner-finally
RETURN_STATEMENT:
return outParamFirstApproverList;
}
public class lcvGetSettings : VarsBag {
public Actions.lcoGetSettingsMargins resGetSettingsMargins =  new Actions.lcoGetSettingsMargins();
public lcvGetSettings() {
}
}
public class lcoGetSettings : VarsBag {
public bool outParamIsActiveAmountValidation = false;

public bool outParamIsForceForeigner = false;

public decimal outParamo_ForeignCurrencyMargin = (((decimal)10));

public decimal outParamo_NationalCurrencyMargin = (((decimal)10));

public bool outParamo_IsActiveDEV_HU13008_Complement = false;

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: </p>
/// </summary>
public async Task<(bool,bool,decimal,decimal,bool)> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsActiveAmountValidation = default;
bool outParamIsForceForeigner = default;
decimal outParamo_ForeignCurrencyMargin = default;
decimal outParamo_NationalCurrencyMargin = default;
bool outParamo_IsActiveDEV_HU13008_Complement = default;
lcoGetSettings result = new lcoGetSettings();
lcvGetSettings localVars = new lcvGetSettings();
ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "b3f3b8c8-4ff1-44f4-a245-bb6d99c22ea4"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioCreate", "GetSettings")){
// GetSettingsMargins
(localVars.resGetSettingsMargins.outParamNationalMargin,localVars.resGetSettingsMargins.outParamForeignMargin) = await Actions.ActionGetSettingsMargins(requestContext,cancellationToken);

// IsActiveAmountValidation = IsActiveXMLValidation_Amount
result.outParamIsActiveAmountValidation=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLValidation_Amount])));

// IsForceForeigner = IsActiveForceForeignerSupplier
result.outParamIsForceForeigner=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveForceForeignerSupplier])));

// o_ForeignCurrencyMargin = GetSettingsMargins.ForeignMargin
result.outParamo_ForeignCurrencyMargin=localVars.resGetSettingsMargins.outParamForeignMargin;

// o_NationalCurrencyMargin = GetSettingsMargins.NationalMargin
result.outParamo_NationalCurrencyMargin=localVars.resGetSettingsMargins.outParamNationalMargin;

// o_IsActiveDEV_HU13008_Complement = IsActiveDEV_HU13008_Complement
result.outParamo_IsActiveDEV_HU13008_Complement=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13008_Complement])));
} //close CreateActionActivity using block
} // try

finally {
outParamIsActiveAmountValidation = result.outParamIsActiveAmountValidation;
outParamIsForceForeigner = result.outParamIsForceForeigner;
outParamo_ForeignCurrencyMargin = result.outParamo_ForeignCurrencyMargin;
outParamo_NationalCurrencyMargin = result.outParamo_NationalCurrencyMargin;
outParamo_IsActiveDEV_HU13008_Complement = result.outParamo_IsActiveDEV_HU13008_Complement;
} // inner-finally
RETURN_STATEMENT:
return (outParamIsActiveAmountValidation,outParamIsForceForeigner,outParamo_ForeignCurrencyMargin,outParamo_NationalCurrencyMargin,outParamo_IsActiveDEV_HU13008_Complement);
}
public class lcvGetSummary : VarsBag {
public RL_164e5439119ae8b31002cd319dbe8413 queryResGetOrderMainById_outParamList = new RL_164e5439119ae8b31002cd319dbe8413();
public long queryResGetOrderMainById_outParamCount = 0L;

public RL_312927afcf3eb9d5fa3bc02bbc91d978 queryResGetTotalFromOriginal_outParamList = new RL_312927afcf3eb9d5fa3bc02bbc91d978();
public long queryResGetTotalFromOriginal_outParamCount = 0L;

public RL_ecf075efbdf79b05fa564fa6ba80a9c6 queryResGetOrderItemEntries_outParamList = new RL_ecf075efbdf79b05fa564fa6ba80a9c6();
public long queryResGetOrderItemEntries_outParamCount = 0L;

public RL_d3c140b81b16482eac14fd0448f33de5 queryResGetTotalAmountDelivered_outParamList = new RL_d3c140b81b16482eac14fd0448f33de5();
public long queryResGetTotalAmountDelivered_outParamCount = 0L;

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
ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSummary", "e9f22b66-0ade-41ad-9a52-93eeba53b7dd"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioCreate", "GetSummary")){
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

// LogMessage
await ExtendedActions.LogMessage(requestContext,((((((("GetTotalAmountDelivered: "+BuiltInFunction.DecimalToText(localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum))+" | ")+"GetTotalFromOriginal: ")+BuiltInFunction.DecimalToText(localVars.queryResGetTotalFromOriginal_outParamList.CurrentRec.ssTotalSAPSum))+" | ")+"GetOrderItemEntries: ")+BuiltInFunction.DecimalToText(localVars.queryResGetOrderItemEntries_outParamList.CurrentRec.ssTotalSum)),"GetSummary",cancellationToken);

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
result.outParamo_SummaryRec.ssPercentageDelivered = BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal ((((((localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum+localVars.queryResGetTotalFromOriginal_outParamList.CurrentRec.ssTotalSAPSum)+localVars.queryResGetOrderItemEntries_outParamList.CurrentRec.ssTotalSum)==(((decimal)0)))) ? ((((decimal)0))) : ((((decimal)((localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum+localVars.queryResGetTotalFromOriginal_outParamList.CurrentRec.ssTotalSAPSum)+localVars.queryResGetOrderItemEntries_outParamList.CurrentRec.ssTotalSum)/
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


    public static class FuncDataActionGetFirstApproverList {

private static async Task<RC_097150223bd4f9024b41b58833c5a636> datasetGetApprovalListReadDbAsync(RC_097150223bd4f9024b41b58833c5a636 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENTelcelDirection.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalList" QHKPH14_U0SnjZaMMHmWvA of Action "GetFirstApproverList"
public static async Task<(RL_edd624fe5c8ecd3e4777bf56612edbf5,long)> datasetGetApprovalList(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpteTelcelDirection_Id,bool qpboIsDevEnvironment,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioCreate.GetFirstApproverList.GetApprovalList", "1f8f7240-3f5e-4453-a78d-968c307996bc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioCreate.GetFirstApproverList.GetApprovalList", "1f8f7240-3f5e-4453-a78d-968c307996bc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.MqP0bz89b0KL_A5wodWoIg/DataActions.RETcDxFEgUKgbmwApD147g/NodesNotShownInESpaceTree.QHKPH14_U0SnjZaMMHmWvA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole85\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"enuser242\".\"id\" o13, \"enuser242\".\"name\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40");
fromBuilder.Append(" FROM (((({User} \"enuser242\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal140\" ON (\"enuser_extended_internal140\".\"id\" = \"enuser242\".\"id\"))  Inner JOIN {TelcelDirection} \"entelceldirection17\" ON (\"entelceldirection17\".\"id\" = \"enuser_extended_internal140\".\"telceldirectionid\"))  Inner JOIN {EntraRole} \"enentrarole85\" ON (\"enuser_extended_internal140\".\"entraroleid\" = \"enentrarole85\".\"id\"))  Left JOIN {UserExtension} \"enuserextension83\" ON (\"enuser242\".\"id\" = \"enuserextension83\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpteTelcelDirection_Id != 0) {
whereBuilder.Append("((\"entelceldirection17\".\"id\" = @qpteTelcelDirection_Id) AND (\"entelceldirection17\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirection_Id", DbType.Int64, qpteTelcelDirection_Id);
} else {
whereBuilder.Append("(\"entelceldirection17\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enentrarole85\".\"isareausuaria\" = 1) AND ((((CASE WHEN char_length(caseaccent_normalize('SUBDIRECTOR ' collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize('SUBDIRECTOR ' collate \"default\") in caseaccent_normalize(\"enentrarole85\".\"rolename\" collate \"default\"))-1) END)) = (-1)) AND (((CASE WHEN char_length(caseaccent_normalize('DIRECTOR ' collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize('DIRECTOR ' collate \"default\") in caseaccent_normalize(\"enentrarole85\".\"rolename\" collate \"default\"))-1) END)) = (-1))) AND ((CASE WHEN (@qpboIsDevEnvironment = 1) THEN (CASE WHEN (\"enuserextension83\".\"correspondentexternalemail\" <> '') THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsDevEnvironment", DbType.Boolean, qpboIsDevEnvironment);
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
RL_edd624fe5c8ecd3e4777bf56612edbf5 outParamList = new RL_edd624fe5c8ecd3e4777bf56612edbf5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalListReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioCreate.GetFirstApproverList.GetApprovalList.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_edd624fe5c8ecd3e4777bf56612edbf5 _tmp = new RL_edd624fe5c8ecd3e4777bf56612edbf5();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalListReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioCreate.GetFirstApproverList.GetApprovalList.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_edd624fe5c8ecd3e4777bf56612edbf5)_tmp;
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

private static async Task<RC_29a9641599166c3e50d86e7edc6e64aa> datasetGetApplicantTelcelDirectionRelationReadDbAsync(RC_29a9641599166c3e50d86e7edc6e64aa rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicant.Read( r, ref index);
rec.ssENApplicantTelcelDirection.Read( r, ref index);
return rec;
}
// Query Function "GetApplicantTelcelDirectionRelation" e3OsaI9eIUihsijwd_Hm7g of Action "GetFirstApproverList"
public static async Task<(RL_b56721e24b85ff178b55a9b290c3bf31,long)> datasetGetApplicantTelcelDirectionRelation(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteApplicant_Applicant,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioCreate.GetFirstApproverList.GetApplicantTelcelDirectionRelation", "68ac737b-5e8f-4821-a1b2-28f077f1e6ee");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioCreate.GetFirstApproverList.GetApplicantTelcelDirectionRelation", "68ac737b-5e8f-4821-a1b2-28f077f1e6ee", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.MqP0bz89b0KL_A5wodWoIg/DataActions.RETcDxFEgUKgbmwApD147g/NodesNotShownInESpaceTree.e3OsaI9eIUihsijwd_Hm7g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, \"enapplicanttelceldirection\".\"telceldirectionid\" o10, NULL o11, NULL o12, NULL o13, NULL o14");
fromBuilder.Append(" FROM ({ApplicantTelcelDirection} \"enapplicanttelceldirection\" Left JOIN {Applicant} \"enapplicant5\" ON (\"enapplicanttelceldirection\".\"applicantid\" = \"enapplicant5\".\"id\")) ");
whereBuilder.Append(" WHERE ((Upper((trim(\"enapplicant5\".\"applicant\")))) = (Upper((trim(@qpteApplicant_Applicant)))))");
sqlCmd.CreateParameterWithoutReplacements("@qpteApplicant_Applicant", DbType.String, qpteApplicant_Applicant);
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
RL_b56721e24b85ff178b55a9b290c3bf31 outParamList = new RL_b56721e24b85ff178b55a9b290c3bf31();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApplicantTelcelDirectionRelationReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioCreate.GetFirstApproverList.GetApplicantTelcelDirectionRelation.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b56721e24b85ff178b55a9b290c3bf31 _tmp = new RL_b56721e24b85ff178b55a9b290c3bf31();
_tmp.AlternateReadDbMethodAsync = datasetGetApplicantTelcelDirectionRelationReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioCreate.GetFirstApproverList.GetApplicantTelcelDirectionRelation.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b56721e24b85ff178b55a9b290c3bf31)_tmp;
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

private static async Task<RC_097150223bd4f9024b41b58833c5a636> datasetGetApprovalList2ReadDbAsync(RC_097150223bd4f9024b41b58833c5a636 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENTelcelDirection.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalList2" oMDI5GM0sUmU77MguD5Mdw of Action "GetFirstApproverList"
public static async Task<(RL_edd624fe5c8ecd3e4777bf56612edbf5,long)> datasetGetApprovalList2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpteTelcelDirection_Id,bool qpboIsDevEnvironment,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioCreate.GetFirstApproverList.GetApprovalList2", "e4c8c0a0-3463-49b1-94ef-b320b83e4c77");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioCreate.GetFirstApproverList.GetApprovalList2", "e4c8c0a0-3463-49b1-94ef-b320b83e4c77", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.MqP0bz89b0KL_A5wodWoIg/DataActions.RETcDxFEgUKgbmwApD147g/NodesNotShownInESpaceTree.oMDI5GM0sUmU77MguD5Mdw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole86\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"enuser243\".\"id\" o13, \"enuser243\".\"name\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40");
fromBuilder.Append(" FROM (((({User} \"enuser243\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal141\" ON (\"enuser_extended_internal141\".\"id\" = \"enuser243\".\"id\"))  Inner JOIN {TelcelDirection} \"entelceldirection18\" ON (\"entelceldirection18\".\"id\" = \"enuser_extended_internal141\".\"telceldirectionid\"))  Inner JOIN {EntraRole} \"enentrarole86\" ON (\"enuser_extended_internal141\".\"entraroleid\" = \"enentrarole86\".\"id\"))  Left JOIN {UserExtension} \"enuserextension84\" ON (\"enuser243\".\"id\" = \"enuserextension84\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpteTelcelDirection_Id != 0) {
whereBuilder.Append("((\"entelceldirection18\".\"id\" = @qpteTelcelDirection_Id) AND (\"entelceldirection18\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirection_Id", DbType.Int64, qpteTelcelDirection_Id);
} else {
whereBuilder.Append("(\"entelceldirection18\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enentrarole86\".\"isareausuaria\" = 1) AND ((((CASE WHEN char_length(caseaccent_normalize('SUBDIRECTOR ' collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize('SUBDIRECTOR ' collate \"default\") in caseaccent_normalize(\"enentrarole86\".\"rolename\" collate \"default\"))-1) END)) = (-1)) AND (((CASE WHEN char_length(caseaccent_normalize('DIRECTOR ' collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize('DIRECTOR ' collate \"default\") in caseaccent_normalize(\"enentrarole86\".\"rolename\" collate \"default\"))-1) END)) = (-1))) AND ((CASE WHEN (@qpboIsDevEnvironment = 1) THEN (CASE WHEN (\"enuserextension84\".\"correspondentexternalemail\" <> '') THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsDevEnvironment", DbType.Boolean, qpboIsDevEnvironment);
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
RL_edd624fe5c8ecd3e4777bf56612edbf5 outParamList = new RL_edd624fe5c8ecd3e4777bf56612edbf5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalList2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioCreate.GetFirstApproverList.GetApprovalList2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_edd624fe5c8ecd3e4777bf56612edbf5 _tmp = new RL_edd624fe5c8ecd3e4777bf56612edbf5();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalList2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioCreate.GetFirstApproverList.GetApprovalList2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_edd624fe5c8ecd3e4777bf56612edbf5)_tmp;
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
public static class FuncDataActionGetSettings {
}
public static class FuncDataActionGetSummary {

private static async Task<RC_a074711a91fd2441798a860685e4898b> datasetGetOrderMainByIdReadDbAsync(RC_a074711a91fd2441798a860685e4898b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCurrency.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainById" 1xxfFrb2ckiXRPDo43miUQ of Action "GetSummary"
public static async Task<(RL_164e5439119ae8b31002cd319dbe8413,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioCreate.GetSummary.GetOrderMainById", "165f1cd7-f6b6-4872-9744-f0e8e379a251");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioCreate.GetSummary.GetOrderMainById", "165f1cd7-f6b6-4872-9744-f0e8e379a251", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.MqP0bz89b0KL_A5wodWoIg/DataActions.Zivy6d4KrUGaUpPuulO33Q/NodesNotShownInESpaceTree.1xxfFrb2ckiXRPDo43miUQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency49\".\"code\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, trim_scale(\"enordermain144\".\"totalamount\"::numeric) o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33");
fromBuilder.Append(" FROM ({OrderMain} \"enordermain144\" Left JOIN {Currency} \"encurrency49\" ON (\"enordermain144\".\"currencyid\" = \"encurrency49\".\"code\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain144\".\"id\" = @qporOrderMain_Id) AND (\"enordermain144\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain144\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioCreate.GetSummary.GetOrderMainById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioCreate.GetSummary.GetOrderMainById.List", cancellationToken: cancellationToken);
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

// Query Function "GetTotalFromOriginal" IvNVVNaGtUWoHsAO0I6dDw of Action "GetSummary"
public static async Task<(RL_312927afcf3eb9d5fa3bc02bbc91d978,long)> datasetGetTotalFromOriginal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioCreate.GetSummary.GetTotalFromOriginal", "5455f322-86d6-45b5-a81e-c00ed08e9d0f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioCreate.GetSummary.GetTotalFromOriginal", "5455f322-86d6-45b5-a81e-c00ed08e9d0f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.MqP0bz89b0KL_A5wodWoIg/DataActions.Zivy6d4KrUGaUpPuulO33Q/NodesNotShownInESpaceTree.IvNVVNaGtUWoHsAO0I6dDw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum((\"enordermainitem34\".\"quantitydelivered\" * (\"enordermainitem34\".\"unitprice\" / cast(\"enordermainitem34\".\"basequantity\" as decimal)))) \"totalsapsum\"");
fromBuilder.Append(" FROM {OrderMainItem} \"enordermainitem34\"");
whereBuilder.Append(" WHERE ");
if (qporOrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem34\".\"ordermainid\" = @qporOrderMainId) AND (\"enordermainitem34\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainId", DbType.Int64, qporOrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem34\".\"ordermainid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioCreate.GetSummary.GetTotalFromOriginal.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioCreate.GetSummary.GetTotalFromOriginal.List", cancellationToken: cancellationToken);
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

// Query Function "GetOrderItemEntries" ZsoAdDKKo0ayWTxvYNFtEA of Action "GetSummary"
public static async Task<(RL_ecf075efbdf79b05fa564fa6ba80a9c6,long)> datasetGetOrderItemEntries(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioCreate.GetSummary.GetOrderItemEntries", "7400ca66-8a32-46a3-b259-3c6f60d16d10");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioCreate.GetSummary.GetOrderItemEntries", "7400ca66-8a32-46a3-b259-3c6f60d16d10", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.MqP0bz89b0KL_A5wodWoIg/DataActions.Zivy6d4KrUGaUpPuulO33Q/NodesNotShownInESpaceTree.ZsoAdDKKo0ayWTxvYNFtEA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum((\"enorderitementries8\".\"quantity_\" * (\"enordermainitem35\".\"unitprice\" / cast(\"enordermainitem35\".\"basequantity\" as decimal)))) \"totalsum\"");
fromBuilder.Append(" FROM (({OrderItemEntries} \"enorderitementries8\" Inner JOIN {OrderMainItem} \"enordermainitem35\" ON (\"enorderitementries8\".\"ordermainitemid\" = \"enordermainitem35\".\"id\"))  Inner JOIN {OrderMain} \"enordermain145\" ON (\"enordermainitem35\".\"ordermainid\" = \"enordermain145\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enorderitementries8\".\"quantity_\" > cast(0 as decimal)) AND ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain145\".\"id\" = @qporOrderMain_Id) AND (\"enordermain145\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain145\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioCreate.GetSummary.GetOrderItemEntries.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioCreate.GetSummary.GetOrderItemEntries.List", cancellationToken: cancellationToken);
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

// Query Function "GetTotalAmountDelivered" P2Z2jIfCZEqe1oZF700QtQ of Action "GetSummary"
public static async Task<(RL_d3c140b81b16482eac14fd0448f33de5,long)> datasetGetTotalAmountDelivered(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporFolio_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioCreate.GetSummary.GetTotalAmountDelivered", "8c76663f-c287-4a64-9ed6-8645ef4d10b5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioCreate.GetSummary.GetTotalAmountDelivered", "8c76663f-c287-4a64-9ed6-8645ef4d10b5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.MqP0bz89b0KL_A5wodWoIg/DataActions.Zivy6d4KrUGaUpPuulO33Q/NodesNotShownInESpaceTree.P2Z2jIfCZEqe1oZF700QtQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"enfolioitems18\".\"totalprice\") \"totalpricesum\"");
fromBuilder.Append(" FROM ({Folio} \"enfolio102\" Left JOIN {FolioItems} \"enfolioitems18\" ON (\"enfolio102\".\"id\" = \"enfolioitems18\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qporFolio_OrderId != 0) {
whereBuilder.Append("((\"enfolio102\".\"orderid\" = @qporFolio_OrderId) AND (\"enfolio102\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporFolio_OrderId", DbType.Int64, qporFolio_OrderId);
} else {
whereBuilder.Append("(\"enfolio102\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND ((\"enfolio102\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId);
whereBuilder.Append(") AND (\"enfolio102\".\"foliostatusid\" <> ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioCreate.GetSummary.GetTotalAmountDelivered.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioCreate.GetSummary.GetTotalAmountDelivered.List", cancellationToken: cancellationToken);
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
}


}
