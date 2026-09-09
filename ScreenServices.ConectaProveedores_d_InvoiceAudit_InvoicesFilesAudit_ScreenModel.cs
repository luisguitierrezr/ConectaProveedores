using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_ScreenModel).Namespace);

    public bool varLci_IsSaveAllFiles;
public bool varLci_IsSaveSelectedFiles;
public ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Model varLcGetInvoices;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_ScreenModel() {
}



    public ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_ScreenModel(bool varLci_IsSaveAllFiles, bool varLci_IsSaveSelectedFiles, ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Model varLcGetInvoices, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_IsSaveAllFiles", "i_IsSaveSelectedFiles", "GetInvoices", "ClientVars"}, new string[] {"varLci_IsSaveAllFiles", "varLci_IsSaveSelectedFiles", "varLcGetInvoices", "clientVariables"});
this.varLci_IsSaveAllFiles = varLci_IsSaveAllFiles;
this.varLci_IsSaveSelectedFiles = varLci_IsSaveSelectedFiles;
this.varLcGetInvoices = varLcGetInvoices;
this.clientVariables = clientVariables;
}



    

    public class lcvGetInvoices : VarsBag {
public RL_22eb8cf271ae44a42b277c2841218ca1 queryResSQL1_outParamList = new RL_22eb8cf271ae44a42b277c2841218ca1();
public long queryResSQL1_outParamCount = 0L;

public lcvGetInvoices() {
}
}
public class lcoGetInvoices : VarsBag {
public RL_6da8ac1538224c0a012cd86c7222fe91 outParamInvoices = new RL_6da8ac1538224c0a012cd86c7222fe91();

public lcoGetInvoices() {
}
}
/// <summary>
/// Action <code>GetInvoices</code> that represents the Service Studio action <code>GetInvoices</code>
///  <p> Description: </p>
/// </summary>
public async Task<RL_6da8ac1538224c0a012cd86c7222fe91> DataActionGetInvoices(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_6da8ac1538224c0a012cd86c7222fe91 outParamInvoices = default;
lcoGetInvoices result = new lcoGetInvoices();
lcvGetInvoices localVars = new lcvGetInvoices();
ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInvoices", "b6753069-3cba-45c0-bbb6-e613c9a940e3"))
using (activitySource.CreateScreenDataActionActivity("InvoicesFilesAudit", "GetInvoices")){
// Query QuerySQL1
cancellationToken.ThrowIfCancellationRequested();
int QuerySQL1_maxRecords = 0;
int QuerySQL1_startIndex = 0;(localVars.queryResSQL1_outParamList,localVars.queryResSQL1_outParamCount) = await FuncDataActionGetInvoices.QuerySQL1(requestContext,QuerySQL1_maxRecords,QuerySQL1_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// Invoices = SQL1.List
result.outParamInvoices=(await RL_6da8ac1538224c0a012cd86c7222fe91.ConvertAsync(localVars.queryResSQL1_outParamList, new RL_6da8ac1538224c0a012cd86c7222fe91(), async (RC_1a5b8cd0ef1115d2fdd242fac41124bc source, ST_29dc80a5deae2388e31181e1082143cfStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamInvoices = result.outParamInvoices;
} // inner-finally
RETURN_STATEMENT:
return outParamInvoices;
}


    public static class FuncDataActionGetInvoices {

// Query Function "SQL1" 0PR8JBvGwkab5N+_WUc4uw of Action "GetInvoices"
public static async Task<(RL_22eb8cf271ae44a42b277c2841218ca1,long)> QuerySQL1(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("d_InvoiceAudit.InvoicesFilesAudit.GetInvoices.SQL1", "247cf4d0-c61b-46c2-9be4-dfbf594738bb");
using var queryActivity = activitySource.CreateSqlQueryActivity("d_InvoiceAudit.InvoicesFilesAudit.GetInvoices.SQL1", "247cf4d0-c61b-46c2-9be4-dfbf594738bb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityInvoice = AppUtils.Instance.RuntimeEntityReplace("Invoice");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityRequisition = AppUtils.Instance.RuntimeEntityReplace("Requisition");
string entityFolio = AppUtils.Instance.RuntimeEntityReplace("Folio");
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string sql = "";
string advSql = "SELECT  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"id\"") + ",  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"name\"") + ",  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + ",  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"updatedon\"") + " \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"requisitionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"folioid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"ordermainid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " =  \n        COALESCE( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + ", \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"supplierid\"") + ", \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " \n        )";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_22eb8cf271ae44a42b277c2841218ca1 outParamList = new RL_22eb8cf271ae44a42b277c2841218ca1();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoiceAudit.InvoicesFilesAudit.GetInvoices.SQL1.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_22eb8cf271ae44a42b277c2841218ca1 _tmp = new RL_22eb8cf271ae44a42b277c2841218ca1();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoiceAudit.InvoicesFilesAudit.GetInvoices.SQL1.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_22eb8cf271ae44a42b277c2841218ca1)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("SQL1 in GetInvoices in InvoicesFilesAudit in d_InvoiceAudit in ConectaProveedores (SELECT       {Invoice}.[Id],       {Invoice}.[Name],       {Supplier}.[Number],       {Invoice}.[UpdatedOn]  FROM {Invoice}  LEFT JOIN {Requisition} ON {Requisition}.[Id] = {Invoice}.[RequisitionId]  LEFT JOIN {Folio} ON {Folio}.[Id] = {Invoice}.[FolioId]  LEFT JOIN {OrderMain} ON {OrderMain}.[Id] = {Invoice}.[OrderMainId]  LEFT JOIN {Supplier} ON {Supplier}.[Id] =           COALESCE(              {Requisition}.[SupplierId],              {Folio}.[SupplierId],              {OrderMain}.[SupplierId]          )): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("SQL1 in GetInvoices in InvoicesFilesAudit in d_InvoiceAudit in ConectaProveedores (SELECT       {Invoice}.[Id],       {Invoice}.[Name],       {Supplier}.[Number],       {Invoice}.[UpdatedOn]  FROM {Invoice}  LEFT JOIN {Requisition} ON {Requisition}.[Id] = {Invoice}.[RequisitionId]  LEFT JOIN {Folio} ON {Folio}.[Id] = {Invoice}.[FolioId]  LEFT JOIN {OrderMain} ON {OrderMain}.[Id] = {Invoice}.[OrderMainId]  LEFT JOIN {Supplier} ON {Supplier}.[Id] =           COALESCE(              {Requisition}.[SupplierId],              {Folio}.[SupplierId],              {OrderMain}.[SupplierId]          )): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("SQL1 in GetInvoices in InvoicesFilesAudit in d_InvoiceAudit in ConectaProveedores (SELECT       {Invoice}.[Id],       {Invoice}.[Name],       {Supplier}.[Number],       {Invoice}.[UpdatedOn]  FROM {Invoice}  LEFT JOIN {Requisition} ON {Requisition}.[Id] = {Invoice}.[RequisitionId]  LEFT JOIN {Folio} ON {Folio}.[Id] = {Invoice}.[FolioId]  LEFT JOIN {OrderMain} ON {OrderMain}.[Id] = {Invoice}.[OrderMainId]  LEFT JOIN {Supplier} ON {Supplier}.[Id] =           COALESCE(              {Requisition}.[SupplierId],              {Folio}.[SupplierId],              {OrderMain}.[SupplierId]          )): " + aqExcep.Message));
}
}
}
}


}
