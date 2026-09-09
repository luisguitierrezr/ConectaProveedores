using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_FCP_InvoicesFCP_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_FCP_InvoicesFCP_ScreenModel).Namespace);

    public long varLcl_ApplicationRoleIdForAggregate;
public string varLcl_ColumnJSONVar;
public int varLcl_CountAfterFetch;
public bool varLcl_IsAllowSelectApplicationRoles;
public bool varLcl_ReInvokeToggler;
public int varLcl_StartIndex;
public string varLcl_TableSort;
public bool varLcl_IsOpenPopupAccounting;
public string varLcl_ID_POLIZA_SAP;
public string varLcl_ID_POLIZA_SAP_CN;
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcl_Invoice_Popup;
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcl_Invoice_CN_Popup;
public AggregateRecord<RL_a9ef13a7afdd5c93ea6dfe986c3c8b78> ScreenDataSetGetInvoicesFCP;
public ConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Model varLcGetUserApplicationRolesAndMore;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_FCP_InvoicesFCP_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_FCP_InvoicesFCP_ScreenModel(long varLcl_ApplicationRoleIdForAggregate, string varLcl_ColumnJSONVar, int varLcl_CountAfterFetch, bool varLcl_IsAllowSelectApplicationRoles, bool varLcl_ReInvokeToggler, int varLcl_StartIndex, string varLcl_TableSort, bool varLcl_IsOpenPopupAccounting, string varLcl_ID_POLIZA_SAP, string varLcl_ID_POLIZA_SAP_CN, EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcl_Invoice_Popup, EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcl_Invoice_CN_Popup, AggregateRecord<RL_a9ef13a7afdd5c93ea6dfe986c3c8b78> ScreenDataSetGetInvoicesFCP, ConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Model varLcGetUserApplicationRolesAndMore, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ApplicationRoleIdForAggregate", "l_ColumnJSONVar", "l_CountAfterFetch", "l_IsAllowSelectApplicationRoles", "l_ReInvokeToggler", "l_StartIndex", "l_TableSort", "l_IsOpenPopupAccounting", "l_ID_POLIZA_SAP", "l_ID_POLIZA_SAP_CN", "l_Invoice_Popup", "l_Invoice_CN_Popup", "GetInvoicesFCP", "GetUserApplicationRolesAndMore", "ClientVars"}, new string[] {"varLcl_ApplicationRoleIdForAggregate", "varLcl_ColumnJSONVar", "varLcl_CountAfterFetch", "varLcl_IsAllowSelectApplicationRoles", "varLcl_ReInvokeToggler", "varLcl_StartIndex", "varLcl_TableSort", "varLcl_IsOpenPopupAccounting", "varLcl_ID_POLIZA_SAP", "varLcl_ID_POLIZA_SAP_CN", "varLcl_Invoice_Popup", "varLcl_Invoice_CN_Popup", "ScreenDataSetGetInvoicesFCP", "varLcGetUserApplicationRolesAndMore", "clientVariables"});
this.varLcl_ApplicationRoleIdForAggregate = varLcl_ApplicationRoleIdForAggregate;
this.varLcl_ColumnJSONVar = varLcl_ColumnJSONVar;
this.varLcl_CountAfterFetch = varLcl_CountAfterFetch;
this.varLcl_IsAllowSelectApplicationRoles = varLcl_IsAllowSelectApplicationRoles;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_IsOpenPopupAccounting = varLcl_IsOpenPopupAccounting;
this.varLcl_ID_POLIZA_SAP = varLcl_ID_POLIZA_SAP;
this.varLcl_ID_POLIZA_SAP_CN = varLcl_ID_POLIZA_SAP_CN;
this.varLcl_Invoice_Popup = varLcl_Invoice_Popup;
this.varLcl_Invoice_CN_Popup = varLcl_Invoice_CN_Popup;
this.ScreenDataSetGetInvoicesFCP = ScreenDataSetGetInvoicesFCP;
this.varLcGetUserApplicationRolesAndMore = varLcGetUserApplicationRolesAndMore;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_306956f424b25ba445c85694148eaa7a> datasetGetInvoicesFCPReadDbAsync(RC_306956f424b25ba445c85694148eaa7a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoice_CN.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesFCP" odkByddfMUWJ_2FApW5lmQ of Action "InvoicesFCP"
public static async Task<(RL_a9ef13a7afdd5c93ea6dfe986c3c8b78,long)> datasetGetInvoicesFCP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,string qpteInvoicesFCP_FolioNumber,string qpteInvoicesFCP_Name,bool qpboIsCorporativoCxP,long qpreOrderMain_DivisionId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices_FCP.InvoicesFCP.GetInvoicesFCP", "c901d9a1-5fd7-4531-89ff-6140a56e6599");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("InvoicesFCP","d_Invoices_FCP.InvoicesFCP.GetInvoicesFCP");
// Query Iterations: Multiple
// Refresh Query iESFly4Xgk68ZUPNxACk+Q Iterations: Multiple
// Refresh Query uaSUmzXVik+qTb6GQBIVJQ Iterations: Multiple
// Refresh Query jZZSACr8HEqprjfHGOEukQ Iterations: Multiple
// Refresh Query DVMOr2nQZkKrPdBwbJSqfg Iterations: Multiple
// Refresh Query yNt5eYIaDUexI5LSjduLgg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.yMZm1Qw+eEmQzpKKn1e5VQ/NodesShownInESpaceTree.Ko3EUi+Hi0K_y4IVKQloOQ/ScreenDataSets.odkByddfMUWJ_2FApW5lmQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio77\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, \"eninvoice142\".\"id\" o20, \"eninvoice142\".\"name\" o21, \"eninvoice142\".\"requisitionid\" o22, \"eninvoice142\".\"folioid\" o23, \"eninvoice142\".\"ordermainid\" o24, \"eninvoice142\".\"cfditypeid\" o25, trim_scale(\"eninvoice142\".\"totalamount\"::numeric) o26, \"eninvoice142\".\"currency\" o27, \"eninvoice142\".\"invoicestatusid\" o28, \"eninvoice142\".\"accountingdatetime\" o29, \"eninvoice142\".\"paymentdatetime\" o30, \"eninvoice142\".\"createdon\" o31, \"eninvoice142\".\"createdby\" o32, \"eninvoice142\".\"updatedon\" o33, \"eninvoice142\".\"updatedby\" o34, \"eninvoice142\".\"submittedon\" o35, \"eninvoice142\".\"isnewversion\" o36, \"eninvoice142\".\"id_poliza\" o37, \"eninvoice142\".\"id_poliza_sap\" o38, \"eninvoice142\".\"doc51\" o39, \"eninvoice142\".\"accountingerror\" o40, \"eninvoice142\".\"orderaccconceptsid\" o41, trim_scale(\"eninvoice142\".\"amortization\"::numeric) o42, \"eninvoice142\".\"creditnoteinvoiceid\" o43, \"eninvoice_cn1\".\"id\" o44, \"eninvoice_cn1\".\"name\" o45, \"eninvoice_cn1\".\"requisitionid\" o46, \"eninvoice_cn1\".\"folioid\" o47, \"eninvoice_cn1\".\"ordermainid\" o48, \"eninvoice_cn1\".\"cfditypeid\" o49, trim_scale(\"eninvoice_cn1\".\"totalamount\"::numeric) o50, \"eninvoice_cn1\".\"currency\" o51, \"eninvoice_cn1\".\"invoicestatusid\" o52, \"eninvoice_cn1\".\"accountingdatetime\" o53, \"eninvoice_cn1\".\"paymentdatetime\" o54, \"eninvoice_cn1\".\"createdon\" o55, \"eninvoice_cn1\".\"createdby\" o56, \"eninvoice_cn1\".\"updatedon\" o57, \"eninvoice_cn1\".\"updatedby\" o58, \"eninvoice_cn1\".\"submittedon\" o59, \"eninvoice_cn1\".\"isnewversion\" o60, \"eninvoice_cn1\".\"id_poliza\" o61, \"eninvoice_cn1\".\"id_poliza_sap\" o62, \"eninvoice_cn1\".\"doc51\" o63, \"eninvoice_cn1\".\"accountingerror\" o64, \"eninvoice_cn1\".\"orderaccconceptsid\" o65, trim_scale(\"eninvoice_cn1\".\"amortization\"::numeric) o66, \"eninvoice_cn1\".\"creditnoteinvoiceid\" o67, NULL o68, \"eninvoicestatus20\".\"label\" o69, \"eninvoicestatus20\".\"class\" o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, \"enordermain121\".\"ordernumber\" o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, \"ensupplier126\".\"name\" o119, \"ensupplier126\".\"number\" o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, \"ensupplier126\".\"n_ident_fis_1\" o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144");
fromBuilder.Append(" FROM (((((({Invoice} \"eninvoice142\" Left JOIN {InvoiceStatus} \"eninvoicestatus20\" ON (\"eninvoice142\".\"invoicestatusid\" = \"eninvoicestatus20\".\"id\"))  Left JOIN {OrderMain} \"enordermain121\" ON (\"eninvoice142\".\"ordermainid\" = \"enordermain121\".\"id\"))  Left JOIN {Folio} \"enfolio77\" ON (\"eninvoice142\".\"folioid\" = \"enfolio77\".\"id\"))  Left JOIN {Supplier} \"ensupplier126\" ON (\"enfolio77\".\"supplierid\" = \"ensupplier126\".\"id\"))  Left JOIN {Region} \"enregion168\" ON (\"enordermain121\".\"regionid\" = \"enregion168\".\"id\"))  Left JOIN {Invoice} \"eninvoice_cn1\" ON (\"eninvoice142\".\"creditnoteinvoiceid\" = \"eninvoice_cn1\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (\"eninvoice142\".\"invoicestatusid\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("q0tYi3ZiTEKjRg2gCsYIDA"))).ssId);
whereBuilder.Append(") AND ((@qpboIsCorporativoCxP = 1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
if (qpreOrderMain_DivisionId != 0) {
whereBuilder.Append("((\"enordermain121\".\"divisionid\" = @qpreOrderMain_DivisionId) AND (\"enordermain121\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
} else {
whereBuilder.Append("(\"enordermain121\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(") AND ");
if (qpteInvoicesFCP_Name != "" && qpteInvoicesFCP_Name != "") {
whereBuilder.Append("(caseaccent_normalize(\"eninvoice142\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteInvoicesFCP_Name) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoicesFCP_Name", DbType.String, qpteInvoicesFCP_Name);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteInvoicesFCP_Name", DbType.String, qpteInvoicesFCP_Name);
}
if (qpteInvoicesFCP_FolioNumber != "" && qpteInvoicesFCP_FolioNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enfolio77\".\"folionumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteInvoicesFCP_FolioNumber) || '%') collate \"default\"))");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoicesFCP_FolioNumber", DbType.String, qpteInvoicesFCP_FolioNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteInvoicesFCP_FolioNumber", DbType.String, qpteInvoicesFCP_FolioNumber);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
if ((qptel_TableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "InvoiceStatus", "OrderMain", "Supplier", "Folio", "Region", "Invoice", "Invoice_CN" }, new string[] { "ENInvoiceStatus20", "ENOrderMain121", "ENSupplier126", "ENFolio77", "ENRegion168", "ENInvoice142", "ENInvoice_CN1" }, new System.Collections.Generic.Dictionary<string, string>[] { ENInvoiceStatusEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
} else {
orderByBuilder.Append(" ORDER BY 1 ASC");
}
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
sqlCount = "SELECT COUNT(1) " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString();
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_a9ef13a7afdd5c93ea6dfe986c3c8b78 outParamList = new RL_a9ef13a7afdd5c93ea6dfe986c3c8b78();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesFCPReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query d_Invoices_FCP.InvoicesFCP.GetInvoicesFCP.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices_FCP.InvoicesFCP.GetInvoicesFCP.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a9ef13a7afdd5c93ea6dfe986c3c8b78 _tmp = new RL_a9ef13a7afdd5c93ea6dfe986c3c8b78();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesFCPReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices_FCP.InvoicesFCP.GetInvoicesFCP.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a9ef13a7afdd5c93ea6dfe986c3c8b78)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query d_Invoices_FCP.InvoicesFCP.GetInvoicesFCP.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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


    public class lcvGetUserApplicationRolesAndMore : VarsBag {
public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public RL_4b6f9359ce9887bc6f37c96ecf62266d queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
public long queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount = 0L;

public int resFindIsCorporativoCxP_outParamPosition = 0;

public int resFindIsSupervisor_outParamPosition = 0;

public lcvGetUserApplicationRolesAndMore() {
}
}
public class lcoGetUserApplicationRolesAndMore : VarsBag {
public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public bool outParamIsCorporativoCxP = false;

public string outParamAppRolesListText = "";

public string outParamTelcelDirectionsListText = "";

public bool outParamIsSupervisor = false;

public long outParamCorporativoRegionId = 0L;

public string outParamTelcelDirectionsListTextForQuery = "";

public bool outParamIsCxP = false;

public lcoGetUserApplicationRolesAndMore() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRolesAndMore</code> that represents the Service Studio action
///  <code>GetUserApplicationRolesAndMore</code> <p> Description: </p>
/// </summary>
public async Task<(RL_97ac86b141c7934fd96d3cf71793066e,bool,string,string,bool,long,string,bool)> DataActionGetUserApplicationRolesAndMore(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
bool outParamIsCorporativoCxP = default;
string outParamAppRolesListText = default;
string outParamTelcelDirectionsListText = default;
bool outParamIsSupervisor = default;
long outParamCorporativoRegionId = default;
string outParamTelcelDirectionsListTextForQuery = default;
bool outParamIsCxP = default;
lcoGetUserApplicationRolesAndMore result = new lcoGetUserApplicationRolesAndMore();
lcvGetUserApplicationRolesAndMore localVars = new lcvGetUserApplicationRolesAndMore();
ConectaProveedores_d_Invoices_FCP_InvoicesFCP_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRolesAndMore", "fa8f4a75-7d5a-49a7-aa4b-6d5262b294bd"))
using (activitySource.CreateScreenDataActionActivity("InvoicesFCP", "GetUserApplicationRolesAndMore")){
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncDataActionGetUserApplicationRolesAndMore.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

// UserRolesList = GetRoleConcept.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken));
// IsCxP = GetRoleConcept.List.Current.ApplicationRole.IsAreaCxP
result.outParamIsCxP=localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENApplicationRole.ssIsAreaCxP;
// FindIsCorporativoCxP
localVars.resFindIsCorporativoCxP_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => ((p.ssENRegion.ssCommissionRegion=="R0")&&p.ssENApplicationRole.ssIsAreaCxP),cancellationToken);

// FindIsSupervisor
localVars.resFindIsSupervisor_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => (((p.ssENRegion.ssCommissionRegion=="R0")||(p.ssENRegion.ssCommissionRegion=="R9"))&&(BuiltInFunction.IndexSC (p.ssENApplicationRole.ssCode, "SUPERVISOR", 0, false, true)!=(-1))),cancellationToken);

// IsCorporativoCxP = FindIsCorporativoCxP.Position <> -1
result.outParamIsCorporativoCxP=(localVars.resFindIsCorporativoCxP_outParamPosition!=(-1));

// IsSupervisor = FindIsSupervisor.Position <> -1
result.outParamIsSupervisor=(localVars.resFindIsSupervisor_outParamPosition!=(-1));

// CorporativoRegionId = GetMR00RegionId()
result.outParamCorporativoRegionId=(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken));
// Foreach UserRolesList
result.outParamUserRolesList.StartIteration();
try {while (!((result.outParamUserRolesList.Eof))) {
// AppRolesListText = AppRolesListText + "," + UserRolesList.Current.ApplicationRoleId
result.outParamAppRolesListText=((result.outParamAppRolesListText+",")+BuiltInFunction.LongIntegerToText(result.outParamUserRolesList.CurrentRec.ssApplicationRoleId));
result.outParamUserRolesList.Advance();
}

} finally {
result.outParamUserRolesList.EndIteration();
}

if((result.outParamIsCorporativoCxP)) {
// Query datasetGetSegmentAccGroupTelcelDirectionsByDepartment
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords = 0;
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex = 0;(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList,localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount) = await FuncDataActionGetUserApplicationRolesAndMore.datasetGetSegmentAccGroupTelcelDirectionsByDepartment(requestContext,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex,IterationMultiplicity.Single,(await Functions.ActionGetUserDepartmentName(requestContext,"",cancellationToken)),cancellationToken);

// Foreach GetSegmentAccGroupTelcelDirectionsByDepartment.List
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.StartIteration();
try {while (!((localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.Eof))) {
// TelcelDirectionsListText = TelcelDirectionsListText + "," + GetSegmentAccGroupTelcelDirectionsByDepartment.List.Current.SegmentAccGroupTelcelDir.TelcelDirectionId + ","
result.outParamTelcelDirectionsListText=(((result.outParamTelcelDirectionsListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.CurrentRec.ssENSegmentAccGroupTelcelDir.ssTelcelDirectionId))+",");

// TelcelDirectionsListTextForQuery = TelcelDirectionsListTextForQuery + ", " + GetSegmentAccGroupTelcelDirectionsByDepartment.List.Current.SegmentAccGroupTelcelDir.TelcelDirectionId
result.outParamTelcelDirectionsListTextForQuery=((result.outParamTelcelDirectionsListTextForQuery+", ")+BuiltInFunction.LongIntegerToText(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.CurrentRec.ssENSegmentAccGroupTelcelDir.ssTelcelDirectionId));
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.Advance();
}

} finally {
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.EndIteration();
}

// TelcelDirectionsListTextForQuery = Substr
result.outParamTelcelDirectionsListTextForQuery=BuiltInFunction.SubstrSC (result.outParamTelcelDirectionsListTextForQuery, 1, BuiltInFunction.LengthSC (result.outParamTelcelDirectionsListTextForQuery));
}

} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
outParamIsCorporativoCxP = result.outParamIsCorporativoCxP;
outParamAppRolesListText = result.outParamAppRolesListText;
outParamTelcelDirectionsListText = result.outParamTelcelDirectionsListText;
outParamIsSupervisor = result.outParamIsSupervisor;
outParamCorporativoRegionId = result.outParamCorporativoRegionId;
outParamTelcelDirectionsListTextForQuery = result.outParamTelcelDirectionsListTextForQuery;
outParamIsCxP = result.outParamIsCxP;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamIsCorporativoCxP,outParamAppRolesListText,outParamTelcelDirectionsListText,outParamIsSupervisor,outParamCorporativoRegionId,outParamTelcelDirectionsListTextForQuery,outParamIsCxP);
}


    public static class FuncDataActionGetUserApplicationRolesAndMore {

private static async Task<RC_6d4a92ad9e5239e9c12dd070f5b17d69> datasetGetRoleConceptReadDbAsync(RC_6d4a92ad9e5239e9c12dd070f5b17d69 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetRoleConcept" x0aYDwQiPEKo+wqn2yhCIg of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices_FCP.InvoicesFCP.GetUserApplicationRolesAndMore.GetRoleConcept", "0f9846c7-2204-423c-a8fb-0aa7db284222");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices_FCP.InvoicesFCP.GetUserApplicationRolesAndMore.GetRoleConcept", "0f9846c7-2204-423c-a8fb-0aa7db284222", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.yMZm1Qw+eEmQzpKKn1e5VQ/NodesShownInESpaceTree.Ko3EUi+Hi0K_y4IVKQloOQ/DataActions.dUqP+lp9p0mqS21SYrKUvQ/NodesNotShownInESpaceTree.x0aYDwQiPEKo+wqn2yhCIg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole77\".\"code\" o1, \"enapplicationrole77\".\"name\" o2, NULL o3, NULL o4, \"enapplicationrole77\".\"isareacxp\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enregion169\".\"commissionregion\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept27\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal125\" Inner JOIN {User} \"enuser213\" ON (\"enuser_extended_internal125\".\"id\" = \"enuser213\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole72\" ON (\"enuser_extended_internal125\".\"jobtitle\" = \"enentrarole72\".\"rolename\"))  Left JOIN {Region} \"enregion169\" ON (\"enuser_extended_internal125\".\"regionid\" = \"enregion169\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept27\" ON (\"enentrarole72\".\"id\" = \"enroleconcept27\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole77\" ON (\"enroleconcept27\".\"applicationroleid\" = \"enapplicationrole77\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser213\".\"id\" = @qpusUser_Id) AND (\"enuser213\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser213\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept27\".\"conceptid\" = ");
whereBuilder.Append(3
);
whereBuilder.Append(")");
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
RL_721bdfcca4a4edbce82baece8dfe837b outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, false, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices_FCP.InvoicesFCP.GetUserApplicationRolesAndMore.GetRoleConcept.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_721bdfcca4a4edbce82baece8dfe837b _tmp = new RL_721bdfcca4a4edbce82baece8dfe837b();
_tmp.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices_FCP.InvoicesFCP.GetUserApplicationRolesAndMore.GetRoleConcept.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_721bdfcca4a4edbce82baece8dfe837b)_tmp;
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

private static async Task<RC_dbac6e35b37e102dd601262a956066d2> datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync(RC_dbac6e35b37e102dd601262a956066d2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENSegmentAccGroup.Read( r, ref index);
rec.ssENSegmentAccGroupTelcelDir.Read( r, ref index);
return rec;
}
// Query Function "GetSegmentAccGroupTelcelDirectionsByDepartment" Nu38MCRhVU6Qu85GwHA7FA of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_4b6f9359ce9887bc6f37c96ecf62266d,long)> datasetGetSegmentAccGroupTelcelDirectionsByDepartment(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteSegmentAccGroup_GroupName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices_FCP.InvoicesFCP.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment", "30fced36-6124-4e55-90bb-ce46c0703b14");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices_FCP.InvoicesFCP.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment", "30fced36-6124-4e55-90bb-ce46c0703b14", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.yMZm1Qw+eEmQzpKKn1e5VQ/NodesShownInESpaceTree.Ko3EUi+Hi0K_y4IVKQloOQ/DataActions.dUqP+lp9p0mqS21SYrKUvQ/NodesNotShownInESpaceTree.Nu38MCRhVU6Qu85GwHA7FA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"ensegmentaccgrouptelceldir12\".\"telceldirectionid\" o9, NULL o10, NULL o11");
fromBuilder.Append(" FROM ({SegmentAccGroup} \"ensegmentaccgroup12\" Left JOIN {SegmentAccGroupTelcelDir} \"ensegmentaccgrouptelceldir12\" ON (\"ensegmentaccgroup12\".\"id\" = \"ensegmentaccgrouptelceldir12\".\"segmentaccgroupid\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize((trim(\"ensegmentaccgroup12\".\"groupname\")) collate \"default\") like caseaccent_normalize(@qpteSegmentAccGroup_GroupName collate \"default\")) AND (\"ensegmentaccgroup12\".\"isactive\" = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpteSegmentAccGroup_GroupName", DbType.String, qpteSegmentAccGroup_GroupName);
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
RL_4b6f9359ce9887bc6f37c96ecf62266d outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices_FCP.InvoicesFCP.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4b6f9359ce9887bc6f37c96ecf62266d _tmp = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
_tmp.AlternateReadDbMethodAsync = datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices_FCP.InvoicesFCP.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4b6f9359ce9887bc6f37c96ecf62266d)_tmp;
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
