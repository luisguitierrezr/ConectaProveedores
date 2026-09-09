using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_ScreenModel).Namespace);

    public long inParamInvoiceId;
public string inParamInvoiceName;
public bool varLcIsAllSelected;
public int varLcStartIndex;
public string varLcTableSort;
public ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Model varLcGetInvoiceFiles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_ScreenModel() {
}



    public ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_ScreenModel(long inParamInvoiceId, string inParamInvoiceName, bool varLcIsAllSelected, int varLcStartIndex, string varLcTableSort, ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Model varLcGetInvoiceFiles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"InvoiceId", "InvoiceName", "IsAllSelected", "StartIndex", "TableSort", "GetInvoiceFiles", "ClientVars"}, new string[] {"inParamInvoiceId", "inParamInvoiceName", "varLcIsAllSelected", "varLcStartIndex", "varLcTableSort", "varLcGetInvoiceFiles", "clientVariables"});
this.inParamInvoiceId = inParamInvoiceId;
this.inParamInvoiceName = inParamInvoiceName;
this.varLcIsAllSelected = varLcIsAllSelected;
this.varLcStartIndex = varLcStartIndex;
this.varLcTableSort = varLcTableSort;
this.varLcGetInvoiceFiles = varLcGetInvoiceFiles;
this.clientVariables = clientVariables;
}



    

    public class lcvGetInvoiceFiles : VarsBag {
public RL_84cc39d051e090dd6414685c3f484137 queryResSQL1_outParamList = new RL_84cc39d051e090dd6414685c3f484137();
public long queryResSQL1_outParamCount = 0L;

public lcvGetInvoiceFiles() {
}
}
public class lcoGetInvoiceFiles : VarsBag {
public RL_5582607f6208069586dcaff23f9c5144 outParamList = new RL_5582607f6208069586dcaff23f9c5144();

public lcoGetInvoiceFiles() {
}
}
/// <summary>
/// Action <code>GetInvoiceFiles</code> that represents the Service Studio action
///  <code>GetInvoiceFiles</code> <p> Description: </p>
/// </summary>
public async Task<RL_5582607f6208069586dcaff23f9c5144> DataActionGetInvoiceFiles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_5582607f6208069586dcaff23f9c5144 outParamList = default;
lcoGetInvoiceFiles result = new lcoGetInvoiceFiles();
lcvGetInvoiceFiles localVars = new lcvGetInvoiceFiles();
ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInvoiceFiles", "03685abf-dd64-474e-aa80-8867b9ce5360"))
using (activitySource.CreateScreenDataActionActivity("Wb_InvoiceFilesList", "GetInvoiceFiles")){
// Query QuerySQL1
cancellationToken.ThrowIfCancellationRequested();
int QuerySQL1_maxRecords = 0;
int QuerySQL1_startIndex = 0;(localVars.queryResSQL1_outParamList,localVars.queryResSQL1_outParamCount) = await FuncDataActionGetInvoiceFiles.QuerySQL1(requestContext,QuerySQL1_maxRecords,QuerySQL1_startIndex,IterationMultiplicity.Multiple,inParamInvoiceId,varLcTableSort,cancellationToken);

// List = SQL1.List
result.outParamList=(await RL_5582607f6208069586dcaff23f9c5144.ConvertAsync(localVars.queryResSQL1_outParamList, new RL_5582607f6208069586dcaff23f9c5144(), async (RC_43d13231e92dc315679ee8f8afa7a620 source, ST_15467825cb087ac1591b96b0d1989badStructure target, CancellationToken cancellationToken) => {
target = source;
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


    public static class FuncDataActionGetInvoiceFiles {

// Query Function "SQL1" D_iUGoBpIUaCDFJ00Hx9Mw of Action "GetInvoiceFiles"
public static async Task<(RL_84cc39d051e090dd6414685c3f484137,long)> QuerySQL1(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,string qpteSortByClause,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("d_InvoiceAudit.Wb_InvoiceFilesList.GetInvoiceFiles.SQL1", "1a94f80f-6980-4621-820c-5274d07c7d33");
using var queryActivity = activitySource.CreateSqlQueryActivity("d_InvoiceAudit.Wb_InvoiceFilesList.GetInvoiceFiles.SQL1", "1a94f80f-6980-4621-820c-5274d07c7d33", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityInvoiceFile = AppUtils.Instance.RuntimeEntityReplace("InvoiceFile");
string entityStorage = AppUtils.Instance.RuntimeEntityReplace("Storage");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityInvoice = AppUtils.Instance.RuntimeEntityReplace("Invoice");
string entityFolio = AppUtils.Instance.RuntimeEntityReplace("Folio");
string entityFolioFiles = AppUtils.Instance.RuntimeEntityReplace("FolioFiles");
sqlCmd.CreateParameter("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
string sql = "";
string advSql = "(SELECT \n    0                   AS IsSelected, \n    IFL.FileName        AS Filename, \n    IFL.IsExtra         AS IsExtra, \n    IFL.CreatedBy       AS CreatedBy, \n    IFL.CreatedOn       AS CreatedOn, \n    IFL.StorageId       AS StorageId, \n    S.Size              AS StorageSize, \n    COALESCE(U.Name, 'System') AS UserName \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,"") + " IFL \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityStorage,"") + " S \n    ON S.Id = IFL.StorageId \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " U \n    ON U.Id = IFL.CreatedBy \n \nWHERE IFL.InvoiceId = @qpinInvoiceId \n \n \n \n \nUNION ALL \n \n \n \n \nSELECT \n    0                   AS IsSelected, \n    FF.FileName         AS Filename, \n    FF.IsExtra          AS IsExtra, \n    FF.CreatedBy        AS CreatedBy, \n    FF.CreatedOn        AS CreatedOn, \n    FF.StorageId        AS StorageId, \n    S.Size              AS StorageSize, \n    COALESCE(U.Name, 'System') AS UserName \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,"") + " I \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " F \n    ON F.Id = I.FolioId \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioFiles,"") + " FF \n    ON FF.FolioId = F.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityStorage,"") + " S \n    ON S.Id = FF.StorageId \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " U \n    ON U.Id = FF.CreatedBy \n \nWHERE I.Id = @qpinInvoiceId) \n \n \nORDER BY  " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qpteSortByClause)) + "";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_84cc39d051e090dd6414685c3f484137 outParamList = new RL_84cc39d051e090dd6414685c3f484137();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoiceAudit.Wb_InvoiceFilesList.GetInvoiceFiles.SQL1.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_84cc39d051e090dd6414685c3f484137 _tmp = new RL_84cc39d051e090dd6414685c3f484137();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoiceAudit.Wb_InvoiceFilesList.GetInvoiceFiles.SQL1.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_84cc39d051e090dd6414685c3f484137)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("SQL1 in GetInvoiceFiles in Wb_InvoiceFilesList in d_InvoiceAudit in ConectaProveedores ((SELECT      0                   AS IsSelected,      IFL.FileName        AS Filename,      IFL.IsExtra         AS IsExtra,      IFL.CreatedBy       AS CreatedBy,      IFL.CreatedOn       AS CreatedOn,      IFL.StorageId       AS StorageId,      S.Size              AS StorageSize,      COALESCE(U.Name, 'System') AS UserName    FROM {InvoiceFile} IFL  INNER JOIN {Storage} S      ON S.Id = IFL.StorageId  LEFT JOIN {User} U      ON U.Id = IFL.CreatedBy    WHERE IFL.InvoiceId = @InvoiceId          UNION ALL          SELECT      0                   AS IsSelected,      FF.FileName         AS Filename,      FF.IsExtra          AS IsExtra,      FF.CreatedBy        AS CreatedBy,      FF.CreatedOn        AS CreatedOn,      FF.StorageId        AS StorageId,      S.Size              AS StorageSize,      COALESCE(U.Name, 'System') AS UserName    FROM {Invoice} I  INNER JOIN {Folio} F      ON F.Id = I.FolioId  INNER JOIN {FolioFiles} FF      ON FF.FolioId = F.Id  INNER JOIN {Storage} S      ON S.Id = ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("SQL1 in GetInvoiceFiles in Wb_InvoiceFilesList in d_InvoiceAudit in ConectaProveedores ((SELECT      0                   AS IsSelected,      IFL.FileName        AS Filename,      IFL.IsExtra         AS IsExtra,      IFL.CreatedBy       AS CreatedBy,      IFL.CreatedOn       AS CreatedOn,      IFL.StorageId       AS StorageId,      S.Size              AS StorageSize,      COALESCE(U.Name, 'System') AS UserName    FROM {InvoiceFile} IFL  INNER JOIN {Storage} S      ON S.Id = IFL.StorageId  LEFT JOIN {User} U      ON U.Id = IFL.CreatedBy    WHERE IFL.InvoiceId = @InvoiceId          UNION ALL          SELECT      0                   AS IsSelected,      FF.FileName         AS Filename,      FF.IsExtra          AS IsExtra,      FF.CreatedBy        AS CreatedBy,      FF.CreatedOn        AS CreatedOn,      FF.StorageId        AS StorageId,      S.Size              AS StorageSize,      COALESCE(U.Name, 'System') AS UserName    FROM {Invoice} I  INNER JOIN {Folio} F      ON F.Id = I.FolioId  INNER JOIN {FolioFiles} FF      ON FF.FolioId = F.Id  INNER JOIN {Storage} S      ON S.Id = ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("SQL1 in GetInvoiceFiles in Wb_InvoiceFilesList in d_InvoiceAudit in ConectaProveedores ((SELECT      0                   AS IsSelected,      IFL.FileName        AS Filename,      IFL.IsExtra         AS IsExtra,      IFL.CreatedBy       AS CreatedBy,      IFL.CreatedOn       AS CreatedOn,      IFL.StorageId       AS StorageId,      S.Size              AS StorageSize,      COALESCE(U.Name, 'System') AS UserName    FROM {InvoiceFile} IFL  INNER JOIN {Storage} S      ON S.Id = IFL.StorageId  LEFT JOIN {User} U      ON U.Id = IFL.CreatedBy    WHERE IFL.InvoiceId = @InvoiceId          UNION ALL          SELECT      0                   AS IsSelected,      FF.FileName         AS Filename,      FF.IsExtra          AS IsExtra,      FF.CreatedBy        AS CreatedBy,      FF.CreatedOn        AS CreatedOn,      FF.StorageId        AS StorageId,      S.Size              AS StorageSize,      COALESCE(U.Name, 'System') AS UserName    FROM {Invoice} I  INNER JOIN {Folio} F      ON F.Id = I.FolioId  INNER JOIN {FolioFiles} FF      ON FF.FolioId = F.Id  INNER JOIN {Storage} S      ON S.Id = ...): " + aqExcep.Message));
}
}
}
}


}
