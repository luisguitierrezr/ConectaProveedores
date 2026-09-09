using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_Invoices_Detail_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_Invoices_Detail_ScreenModel).Namespace);

    public long inParami_InvoiceId;
public long inParami_RequisitionId;
public DateTime varLcRefreshInvoiceDetailsHistory;
public ConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Model varLcGetInitializationData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_Invoices_Detail_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_Invoices_Detail_ScreenModel(long inParami_InvoiceId, long inParami_RequisitionId, DateTime varLcRefreshInvoiceDetailsHistory, ConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Model varLcGetInitializationData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_InvoiceId", "i_RequisitionId", "RefreshInvoiceDetailsHistory", "GetUserApplicationRoles", "GetInitializationData", "ClientVars"}, new string[] {"inParami_InvoiceId", "inParami_RequisitionId", "varLcRefreshInvoiceDetailsHistory", "varLcGetUserApplicationRoles", "varLcGetInitializationData", "clientVariables"});
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_RequisitionId = inParami_RequisitionId;
this.varLcRefreshInvoiceDetailsHistory = varLcRefreshInvoiceDetailsHistory;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.varLcGetInitializationData = varLcGetInitializationData;
this.clientVariables = clientVariables;
}



    

    public class lcvGetUserApplicationRoles : VarsBag {
public RL_a628f44fbe3d61a818adba8c3d848715 queryResGetUserRoles_outParamList = new RL_a628f44fbe3d61a818adba8c3d848715();
public long queryResGetUserRoles_outParamCount = 0L;

public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public int resListIndexOf_outParamPosition = 0;

public int resFindIsCorporativoCxP_outParamPosition = 0;

public lcvGetUserApplicationRoles() {
}
}
public class lcoGetUserApplicationRoles : VarsBag {
public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public string outParamListText = "";

public bool outParamIsCorporativoCxP = false;

public lcoGetUserApplicationRoles() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRoles</code> that represents the Service Studio action
///  <code>GetUserApplicationRoles</code> <p> Description: </p>
/// </summary>
public async Task<(RL_97ac86b141c7934fd96d3cf71793066e,string,bool)> DataActionGetUserApplicationRoles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
string outParamListText = default;
bool outParamIsCorporativoCxP = default;
lcoGetUserApplicationRoles result = new lcoGetUserApplicationRoles();
lcvGetUserApplicationRoles localVars = new lcvGetUserApplicationRoles();
ConectaProveedores_d_Invoices_Invoices_Detail_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "847ee600-92f0-400a-8d7e-be4e99b87da1"))
using (activitySource.CreateScreenDataActionActivity("Invoices_Detail", "GetUserApplicationRoles")){
// Query QueryGetUserRoles
cancellationToken.ThrowIfCancellationRequested();
int QueryGetUserRoles_maxRecords = 0;
int QueryGetUserRoles_startIndex = 0;(localVars.queryResGetUserRoles_outParamList,localVars.queryResGetUserRoles_outParamCount) = await FuncDataActionGetUserApplicationRoles.QueryGetUserRoles(requestContext,QueryGetUserRoles_maxRecords,QueryGetUserRoles_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),2,3,cancellationToken);

// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetUserRoles_outParamList,async (p, cancellationToken) => (!p.ssSTUserRoleCode.ssIsSubstitute),cancellationToken);

if(((localVars.resListIndexOf_outParamPosition!=(-1)))) {
// UserRolesList = GetUserRoles.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetUserRoles_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_0a3f9d90df8bd7c726f88030e3651410 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
// IsCorporativoCxP = GetIsCorporativoCxPFromUAR(FsP)
result.outParamIsCorporativoCxP=(await Functions.ActionGetIsCorporativoCxPFromUAR(requestContext,3,"",cancellationToken));
} else {
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

// UserRolesList = GetRoleConcept.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken));
// FindIsCorporativoCxP
localVars.resFindIsCorporativoCxP_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => ((p.ssENRegion.ssCommissionRegion=="R0")&&p.ssENApplicationRole.ssIsAreaCxP),cancellationToken);

// IsCorporativoCxP = FindIsCorporativoCxP.Position <> -1
result.outParamIsCorporativoCxP=(localVars.resFindIsCorporativoCxP_outParamPosition!=(-1));
}

// Foreach UserRolesList
result.outParamUserRolesList.StartIteration();
try {while (!((result.outParamUserRolesList.Eof))) {
// ListText = ListText + "," + UserRolesList.Current.ApplicationRoleId
result.outParamListText=((result.outParamListText+",")+BuiltInFunction.LongIntegerToText(result.outParamUserRolesList.CurrentRec.ssApplicationRoleId));
result.outParamUserRolesList.Advance();
}

} finally {
result.outParamUserRolesList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
outParamListText = result.outParamListText;
outParamIsCorporativoCxP = result.outParamIsCorporativoCxP;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamListText,outParamIsCorporativoCxP);
}
public class lcvGetInitializationData : VarsBag {
public RL_0b30b3b9fcfe7f048af0b62a4d7aca76 queryResGetInvoiceApprovalsCurrent_outParamList = new RL_0b30b3b9fcfe7f048af0b62a4d7aca76();
public long queryResGetInvoiceApprovalsCurrent_outParamCount = 0L;

public RL_1f3e9ea72dc7b010c56ee9146ee277c5 queryResGetAnApprovalLevelFromInv_outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
public long queryResGetAnApprovalLevelFromInv_outParamCount = 0L;

public RL_e6ad6603ac07123d4d7c5f1b4a760912 queryResGetInvoiceById_outParamList = new RL_e6ad6603ac07123d4d7c5f1b4a760912();
public long queryResGetInvoiceById_outParamCount = 0L;

public lcvGetInitializationData() {
}
}
public class lcoGetInitializationData : VarsBag {
public RL_e6ad6603ac07123d4d7c5f1b4a760912 outParamInvoiceById = new RL_e6ad6603ac07123d4d7c5f1b4a760912();

public bool outParamIsUserCxp = false;

public bool outParamIsActiveUser = false;

public bool outParamIsAllowed = false;

public bool outParamIsProveedor = false;

public bool outParamIsDEV = false;

public bool outParamIsActiveDEV_AccountingCeBe = false;

public lcoGetInitializationData() {
}
}
/// <summary>
/// Action <code>GetInitializationData</code> that represents the Service Studio action
///  <code>GetInitializationData</code> <p> Description: Returns data necessary for user interface.</p>
/// </summary>
public async Task<(RL_e6ad6603ac07123d4d7c5f1b4a760912,bool,bool,bool,bool,bool,bool)> DataActionGetInitializationData(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_e6ad6603ac07123d4d7c5f1b4a760912 outParamInvoiceById = default;
bool outParamIsUserCxp = default;
bool outParamIsActiveUser = default;
bool outParamIsAllowed = default;
bool outParamIsProveedor = default;
bool outParamIsDEV = default;
bool outParamIsActiveDEV_AccountingCeBe = default;
lcoGetInitializationData result = new lcoGetInitializationData();
lcvGetInitializationData localVars = new lcvGetInitializationData();
ConectaProveedores_d_Invoices_Invoices_Detail_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInitializationData", "d708a165-7f4f-44d5-bd38-ed7f9dfe70bb"))
using (activitySource.CreateScreenDataActionActivity("Invoices_Detail", "GetInitializationData")){
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncDataActionGetInitializationData.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),inParami_InvoiceId,cancellationToken);

// Query datasetGetInvoiceApprovalsCurrent
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceApprovalsCurrent_maxRecords = 1;
if (datasetGetInvoiceApprovalsCurrent_maxRecords < 1) datasetGetInvoiceApprovalsCurrent_maxRecords = 1;
int datasetGetInvoiceApprovalsCurrent_startIndex = 0;(localVars.queryResGetInvoiceApprovalsCurrent_outParamList,localVars.queryResGetInvoiceApprovalsCurrent_outParamCount) = await FuncDataActionGetInitializationData.datasetGetInvoiceApprovalsCurrent(requestContext,datasetGetInvoiceApprovalsCurrent_maxRecords,datasetGetInvoiceApprovalsCurrent_startIndex,IterationMultiplicity.Never,varLcGetUserApplicationRoles.outParamListText,BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),inParami_InvoiceId,cancellationToken);

// Query datasetGetAnApprovalLevelFromInv
cancellationToken.ThrowIfCancellationRequested();
int datasetGetAnApprovalLevelFromInv_maxRecords = 1;
if (datasetGetAnApprovalLevelFromInv_maxRecords < 1) datasetGetAnApprovalLevelFromInv_maxRecords = 1;
int datasetGetAnApprovalLevelFromInv_startIndex = 0;(localVars.queryResGetAnApprovalLevelFromInv_outParamList,localVars.queryResGetAnApprovalLevelFromInv_outParamCount) = await FuncDataActionGetInitializationData.datasetGetAnApprovalLevelFromInv(requestContext,datasetGetAnApprovalLevelFromInv_maxRecords,datasetGetAnApprovalLevelFromInv_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssRequisitionId,BuiltInFunction.GetUserId (),cancellationToken);

// InvoiceById = GetInvoiceById.List
result.outParamInvoiceById=localVars.queryResGetInvoiceById_outParamList;

// IsActiveUser = GetInvoiceApprovalsCurrent.List.Current.InvoiceApprovalLevel.ApprovalStatusId = NotApproved and If and GetInvoiceById.List.Current.Invoice.InvoiceStatusId <> Accounting
result.outParamIsActiveUser=(((localVars.queryResGetInvoiceApprovalsCurrent_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId==(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId)&&(((localVars.queryResGetInvoiceApprovalsCurrent_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? ((localVars.queryResGetInvoiceApprovalsCurrent_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo==BuiltInFunction.GetUserId ())) : (localVars.queryResGetInvoiceApprovalsCurrent_outParamList.CurrentRec.ssIsAllowedFromRoleAndRegion)))&&(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId!=(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Tfj332sYfU6orP6hWpZ2sg"))).ssId));

// IsUserCxp = GetInvoiceApprovalsCurrent.List.Current.InvoiceApproval.HasStartedAccounting and GetInvoiceApprovalsCurrent.List.Current.InvoiceApprovalLevel.IsAccounting or GetUserApplicationRoles.IsCorporativoCxP and notCheckProveedorRole()
result.outParamIsUserCxp=((localVars.queryResGetInvoiceApprovalsCurrent_outParamList.CurrentRec.ssENInvoiceApproval.ssHasStartedAccounting&&(localVars.queryResGetInvoiceApprovalsCurrent_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssIsAccounting||varLcGetUserApplicationRoles.outParamIsCorporativoCxP))&&(!(await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken))));

// IsAllowed = notGetInvoiceApprovalsCurrent.List.Empty or GetUserApplicationRoles.IsCorporativoCxP or CheckProveedorRole() or notGetAnApprovalLevelFromInv.List.Empty
result.outParamIsAllowed=((((!localVars.queryResGetInvoiceApprovalsCurrent_outParamList.Empty)||varLcGetUserApplicationRoles.outParamIsCorporativoCxP)||(await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken)))||(!localVars.queryResGetAnApprovalLevelFromInv_outParamList.Empty));

// IsProveedor = CheckProveedorRole()
result.outParamIsProveedor=(await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken));

// IsDEV = Environment = "DEV"
result.outParamIsDEV=(((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="DEV");

// IsActiveDEV_AccountingCeBe = IsActiveDEV_TK88
result.outParamIsActiveDEV_AccountingCeBe=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_TK88])));
} //close CreateActionActivity using block
} // try

finally {
outParamInvoiceById = result.outParamInvoiceById;
outParamIsUserCxp = result.outParamIsUserCxp;
outParamIsActiveUser = result.outParamIsActiveUser;
outParamIsAllowed = result.outParamIsAllowed;
outParamIsProveedor = result.outParamIsProveedor;
outParamIsDEV = result.outParamIsDEV;
outParamIsActiveDEV_AccountingCeBe = result.outParamIsActiveDEV_AccountingCeBe;
} // inner-finally
RETURN_STATEMENT:
return (outParamInvoiceById,outParamIsUserCxp,outParamIsActiveUser,outParamIsAllowed,outParamIsProveedor,outParamIsDEV,outParamIsActiveDEV_AccountingCeBe);
}


    public static class FuncDataActionGetUserApplicationRoles {

// Query Function "GetUserRoles" 1vvyOS0FQE++yVg6U+YtyQ of Action "GetUserApplicationRoles"
public static async Task<(RL_a628f44fbe3d61a818adba8c3d848715,long)> QueryGetUserRoles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,int qproRoleStatusActiveId,int qpcoConceptFsP,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("d_Invoices.Invoices_Detail.GetUserApplicationRoles.GetUserRoles", "39f2fbd6-052d-4f40-bec9-583a53e62dc9");
using var queryActivity = activitySource.CreateSqlQueryActivity("d_Invoices.Invoices_Detail.GetUserApplicationRoles.GetUserRoles", "39f2fbd6-052d-4f40-bec9-583a53e62dc9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityUserApplicationRole = AppUtils.Instance.RuntimeEntityReplace("UserApplicationRole");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
string entityRoleConcept = AppUtils.Instance.RuntimeEntityReplace("RoleConcept");
string entityUserApplicationRoleTemp = AppUtils.Instance.RuntimeEntityReplace("UserApplicationRoleTemp");
sqlCmd.CreateParameter("@qpusUserId", DbType.String, qpusUserId);
sqlCmd.CreateParameter("@qproRoleStatusActiveId", DbType.Int32, qproRoleStatusActiveId);
sqlCmd.CreateParameter("@qpcoConceptFsP", DbType.Int32, qpcoConceptFsP);
string sql = "";
string advSql = "SELECT  \n    uar.ApplicationRoleId, \n    ar.Name, \n    ar.Code, \n    0 \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUserApplicationRole,"") + " uar \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ar ON uar.ApplicationRoleId = ar.Id \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRoleConcept,"") + " rc ON rc.ApplicationRoleId = ar.Id \nWHERE uar.UserId = @qpusUserId \n  AND uar.RoleStatusId = @qproRoleStatusActiveId \n  AND uar.ConceptId = @qpcoConceptFsP \n \nUNION \n \nSELECT  \n    uat.ApplicationRoleId, \n    ar.Name, \n    ar.Code, \n    1 \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUserApplicationRoleTemp,"") + " uat \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ar ON uat.ApplicationRoleId = ar.Id \nWHERE uat.UserId = @qpusUserId \n  AND uat.RoleStatusId = @qproRoleStatusActiveId \n  AND uat.ConceptId = @qpcoConceptFsP";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_a628f44fbe3d61a818adba8c3d848715 outParamList = new RL_a628f44fbe3d61a818adba8c3d848715();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices_Detail.GetUserApplicationRoles.GetUserRoles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a628f44fbe3d61a818adba8c3d848715 _tmp = new RL_a628f44fbe3d61a818adba8c3d848715();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices_Detail.GetUserApplicationRoles.GetUserRoles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a628f44fbe3d61a818adba8c3d848715)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetUserRoles in GetUserApplicationRoles in Invoices_Detail in d_Invoices in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  JOIN {RoleConcept} rc ON rc.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    AND uar.ConceptId = @ConceptFsP    UNION    SELECT       uat.ApplicationRoleId,      ar.Name,      ar.Code,      1  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId    AND uat.ConceptId = @ConceptFsP): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetUserRoles in GetUserApplicationRoles in Invoices_Detail in d_Invoices in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  JOIN {RoleConcept} rc ON rc.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    AND uar.ConceptId = @ConceptFsP    UNION    SELECT       uat.ApplicationRoleId,      ar.Name,      ar.Code,      1  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId    AND uat.ConceptId = @ConceptFsP): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetUserRoles in GetUserApplicationRoles in Invoices_Detail in d_Invoices in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  JOIN {RoleConcept} rc ON rc.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    AND uar.ConceptId = @ConceptFsP    UNION    SELECT       uat.ApplicationRoleId,      ar.Name,      ar.Code,      1  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId    AND uat.ConceptId = @ConceptFsP): " + aqExcep.Message));
}
}
}

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
// Query Function "GetRoleConcept" wOY0O19FQECAYQOuLnK40g of Action "GetUserApplicationRoles"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Invoices_Detail.GetUserApplicationRoles.GetRoleConcept", "3b34e6c0-455f-4040-8061-03ae2e72b8d2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Invoices_Detail.GetUserApplicationRoles.GetRoleConcept", "3b34e6c0-455f-4040-8061-03ae2e72b8d2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.+9+n0rMEeEqVQkr43mv1dQ/DataActions.AOZ+hPCSCkCNfr5Ombh9oQ/NodesNotShownInESpaceTree.wOY0O19FQECAYQOuLnK40g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole59\".\"code\" o1, \"enapplicationrole59\".\"name\" o2, NULL o3, NULL o4, \"enapplicationrole59\".\"isareacxp\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enregion113\".\"commissionregion\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept21\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal105\" Inner JOIN {User} \"enuser174\" ON (\"enuser_extended_internal105\".\"id\" = \"enuser174\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole52\" ON (\"enuser_extended_internal105\".\"jobtitle\" = \"enentrarole52\".\"rolename\"))  Left JOIN {Region} \"enregion113\" ON (\"enuser_extended_internal105\".\"regionid\" = \"enregion113\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept21\" ON (\"enentrarole52\".\"id\" = \"enroleconcept21\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole59\" ON (\"enroleconcept21\".\"applicationroleid\" = \"enapplicationrole59\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser174\".\"id\" = @qpusUser_Id) AND (\"enuser174\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser174\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept21\".\"conceptid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices_Detail.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices_Detail.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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
}
public static class FuncDataActionGetInitializationData {

private static async Task<RC_ada25812cfab5c5db1ea84d416297bbf> datasetGetInvoiceApprovalsCurrentReadDbAsync(RC_ada25812cfab5c5db1ea84d416297bbf rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssIsAllowedFromRoleAndRegion = r.ReadBoolean(index++, "InvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelApplicationRoleIsAllowedFromRoleAndRegionRecord.IsAllowedFromRoleAndRegion", false);
return rec;
}
// Query Function "GetInvoiceApprovalsCurrent" eijpH2q+0ESJzeUpQgf3bw of Action "GetInitializationData"
public static async Task<(RL_0b30b3b9fcfe7f048af0b62a4d7aca76,long)> datasetGetInvoiceApprovalsCurrent(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteListText,string qpusGetUserId,long qpreRequisition_RegionId,long qpsuRequisition_SupplierId,long qpinInvoiceApproval_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Invoices_Detail.GetInitializationData.GetInvoiceApprovalsCurrent", "1fe9287a-be6a-44d0-89cd-e5294207f76f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Invoices_Detail.GetInitializationData.GetInvoiceApprovalsCurrent", "1fe9287a-be6a-44d0-89cd-e5294207f76f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.+9+n0rMEeEqVQkr43mv1dQ/DataActions.ZaEI109_1US9OO1_nf5wuw/NodesNotShownInESpaceTree.eijpH2q+0ESJzeUpQgf3bw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, \"eninvoiceapproval39\".\"hasstartedaccounting\" o40, NULL o41, NULL o42, NULL o43, \"eninvoiceapprovallevel38\".\"assignedto\" o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, \"eninvoiceapprovallevel38\".\"approvalstatusid\" o51, NULL o52, NULL o53, NULL o54, \"eninvoiceapprovallevel38\".\"isaccounting\" o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, (CASE WHEN (((\"eninvoiceapprovallevel38\".\"assignedto\" IS NULL) AND (((CASE WHEN char_length(caseaccent_normalize(cast(\"enapplicationrole60\".\"id\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enapplicationrole60\".\"id\" as text) collate \"default\") in caseaccent_normalize(@qpteListText collate \"default\"))-1) END)) <> (-1))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteListText", DbType.String, qpteListText);
if (qpreRequisition_RegionId != 0) {
selectBuilder.Append("((\"enrequisition100\".\"regionid\" = @qpreRequisition_RegionId) AND (\"enrequisition100\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
} else {
selectBuilder.Append("(\"enrequisition100\".\"regionid\" IS NULL)");
}
selectBuilder.Append(") THEN 1 ELSE 0 END) \"isallowedfromroleandregion\"");
fromBuilder.Append(" FROM (((({Invoice} \"eninvoice125\" Left JOIN {InvoiceApproval} \"eninvoiceapproval39\" ON (\"eninvoiceapproval39\".\"invoiceid\" = \"eninvoice125\".\"id\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel38\" ON (\"eninvoiceapproval39\".\"id\" = \"eninvoiceapprovallevel38\".\"invoiceapprovalid\"))  Left JOIN {ApplicationRole} \"enapplicationrole60\" ON (\"eninvoiceapprovallevel38\".\"applicationroleid\" = \"enapplicationrole60\".\"id\"))  Left JOIN {Requisition} \"enrequisition100\" ON (\"eninvoice125\".\"requisitionid\" = \"enrequisition100\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApproval_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceapproval39\".\"invoiceid\" = @qpinInvoiceApproval_InvoiceId) AND (\"eninvoiceapproval39\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApproval_InvoiceId", DbType.Int64, qpinInvoiceApproval_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceapproval39\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND ((");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoice125\".\"createdby\" = @qpusGetUserId) AND (\"eninvoice125\".\"createdby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoice125\".\"createdby\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpsuRequisition_SupplierId != 0) {
whereBuilder.Append("((\"enrequisition100\".\"supplierid\" = @qpsuRequisition_SupplierId) AND (\"enrequisition100\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
} else {
whereBuilder.Append("(\"enrequisition100\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(") OR ((\"eninvoiceapprovallevel38\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND ((((");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel38\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel38\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel38\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" OR ((\"eninvoiceapprovallevel38\".\"assignedto\" IS NULL) AND (((CASE WHEN char_length(caseaccent_normalize(cast(\"enapplicationrole60\".\"id\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enapplicationrole60\".\"id\" as text) collate \"default\") in caseaccent_normalize(@qpteListText collate \"default\"))-1) END)) <> (-1)))) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteListText", DbType.String, qpteListText);
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel38\".\"approvedby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel38\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel38\".\"approvedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel38\".\"requesttomodifyby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel38\".\"requesttomodifyby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel38\".\"requesttomodifyby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel38\".\"canceledby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel38\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel38\".\"canceledby\" IS NULL)");
}
whereBuilder.Append(")))");
orderByBuilder.Append(" ORDER BY \"eninvoiceapprovallevel38\".\"levelnumber\" DESC ");
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
RL_0b30b3b9fcfe7f048af0b62a4d7aca76 outParamList = new RL_0b30b3b9fcfe7f048af0b62a4d7aca76();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalsCurrentReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices_Detail.GetInitializationData.GetInvoiceApprovalsCurrent.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0b30b3b9fcfe7f048af0b62a4d7aca76 _tmp = new RL_0b30b3b9fcfe7f048af0b62a4d7aca76();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalsCurrentReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices_Detail.GetInitializationData.GetInvoiceApprovalsCurrent.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0b30b3b9fcfe7f048af0b62a4d7aca76)_tmp;
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

private static async Task<RC_11c2ac4c5bdce01960ee8371ad40d262> datasetGetAnApprovalLevelFromInvReadDbAsync(RC_11c2ac4c5bdce01960ee8371ad40d262 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetAnApprovalLevelFromInv" 8lxhhcLuEEmr4eMtmDB_vQ of Action "GetInitializationData"
public static async Task<(RL_1f3e9ea72dc7b010c56ee9146ee277c5,long)> datasetGetAnApprovalLevelFromInv(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,string qpusRequisitionApprovalLevel_ApprovedBy,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Invoices_Detail.GetInitializationData.GetAnApprovalLevelFromInv", "85615cf2-eec2-4910-abe1-e32d98307fbd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Invoices_Detail.GetInitializationData.GetAnApprovalLevelFromInv", "85615cf2-eec2-4910-abe1-e32d98307fbd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.+9+n0rMEeEqVQkr43mv1dQ/DataActions.ZaEI109_1US9OO1_nf5wuw/NodesNotShownInESpaceTree.8lxhhcLuEEmr4eMtmDB_vQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition101\" Left JOIN {RequisitionApproval} \"enrequisitionapproval26\" ON (\"enrequisition101\".\"id\" = \"enrequisitionapproval26\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel23\" ON (\"enrequisitionapproval26\".\"id\" = \"enrequisitionapprovallevel23\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition101\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition101\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition101\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if ((qpusRequisitionApprovalLevel_ApprovedBy.Trim()!="")) {
whereBuilder.Append("((\"enrequisitionapprovallevel23\".\"approvedby\" = @qpusRequisitionApprovalLevel_ApprovedBy) AND (\"enrequisitionapprovallevel23\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusRequisitionApprovalLevel_ApprovedBy", DbType.String, qpusRequisitionApprovalLevel_ApprovedBy);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel23\".\"approvedby\" IS NULL)");
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
RL_1f3e9ea72dc7b010c56ee9146ee277c5 outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetAnApprovalLevelFromInvReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices_Detail.GetInitializationData.GetAnApprovalLevelFromInv.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f3e9ea72dc7b010c56ee9146ee277c5 _tmp = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
_tmp.AlternateReadDbMethodAsync = datasetGetAnApprovalLevelFromInvReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices_Detail.GetInitializationData.GetAnApprovalLevelFromInv.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1f3e9ea72dc7b010c56ee9146ee277c5)_tmp;
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

private static async Task<RC_42a47f09e8ab03d8e9c2d1f2f5aa06af> datasetGetInvoiceByIdReadDbAsync(RC_42a47f09e8ab03d8e9c2d1f2f5aa06af rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" fFe3wARshEiHL5Nc2mFILQ of Action "GetInitializationData"
public static async Task<(RL_e6ad6603ac07123d4d7c5f1b4a760912,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Invoices_Detail.GetInitializationData.GetInvoiceById", "c0b7577c-6c04-4884-872f-935cda61482d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Invoices_Detail.GetInitializationData.GetInvoiceById", "c0b7577c-6c04-4884-872f-935cda61482d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.+9+n0rMEeEqVQkr43mv1dQ/DataActions.ZaEI109_1US9OO1_nf5wuw/NodesNotShownInESpaceTree.fFe3wARshEiHL5Nc2mFILQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice126\".\"name\" o1, \"eninvoice126\".\"requisitionid\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"eninvoice126\".\"invoicestatusid\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, \"eninvoicestatus12\".\"label\" o25, \"eninvoicestatus12\".\"class\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"enregion114\".\"code\" o32, NULL o33, \"enregion114\".\"divisionfi\" o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, \"ensupplier86\".\"name\" o104, \"ensupplier86\".\"number\" o105, NULL o106, NULL o107, NULL o108, NULL o109, \"ensupplier86\".\"pais\" o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, \"ensupplier86\".\"n_ident_fis_1\" o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129");
fromBuilder.Append(" FROM (((({Invoice} \"eninvoice126\" Left JOIN {InvoiceStatus} \"eninvoicestatus12\" ON (\"eninvoice126\".\"invoicestatusid\" = \"eninvoicestatus12\".\"id\"))  Left JOIN {Requisition} \"enrequisition102\" ON (\"eninvoice126\".\"requisitionid\" = \"enrequisition102\".\"id\"))  Left JOIN {Supplier} \"ensupplier86\" ON (\"enrequisition102\".\"supplierid\" = \"ensupplier86\".\"id\"))  Left JOIN {Region} \"enregion114\" ON (\"enrequisition102\".\"regionid\" = \"enregion114\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice126\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice126\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice126\".\"id\" IS NULL)");
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
RL_e6ad6603ac07123d4d7c5f1b4a760912 outParamList = new RL_e6ad6603ac07123d4d7c5f1b4a760912();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Invoices_Detail.GetInitializationData.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e6ad6603ac07123d4d7c5f1b4a760912 _tmp = new RL_e6ad6603ac07123d4d7c5f1b4a760912();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Invoices_Detail.GetInitializationData.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e6ad6603ac07123d4d7c5f1b4a760912)_tmp;
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
