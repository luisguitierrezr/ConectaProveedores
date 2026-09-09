using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_ScreenModel).Namespace);

    public long inParami_FolioId;
public string varLcTextVar;
public string varLcTextVar2;
public AggregateRecord<RL_06a48d30ec1735b8ae6350ea4dbe82c6> ScreenDataSetGetFolioById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_ScreenModel(long inParami_FolioId, string varLcTextVar, string varLcTextVar2, AggregateRecord<RL_06a48d30ec1735b8ae6350ea4dbe82c6> ScreenDataSetGetFolioById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_FolioId", "TextVar", "TextVar2", "GetFolioById", "ClientVars"}, new string[] {"inParami_FolioId", "varLcTextVar", "varLcTextVar2", "ScreenDataSetGetFolioById", "clientVariables"});
this.inParami_FolioId = inParami_FolioId;
this.varLcTextVar = varLcTextVar;
this.varLcTextVar2 = varLcTextVar2;
this.ScreenDataSetGetFolioById = ScreenDataSetGetFolioById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_0d7cf510ad0e091abdf9a2eb501fc0e9> datasetGetFolioByIdReadDbAsync(RC_0d7cf510ad0e091abdf9a2eb501fc0e9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCurrency.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceExtendedForeigner.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" +H1x04X1okGZ41Eil2oZUQ of Action "Wb_ForeignSupplierInvoiceDetails"
public static async Task<(RL_06a48d30ec1735b8ae6350ea4dbe82c6,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_ForeignSupplierInvoiceDetails.GetFolioById", "d3717df8-f585-41a2-99e3-5122976a1951");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_ForeignSupplierInvoiceDetails","j_FoliosSAE.Wb_ForeignSupplierInvoiceDetails.GetFolioById");
// Query Iterations: Never
// Refresh Query tGMaG5Vnw0+Gqnsa89Kn7w Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.dR15qgivMkeNKKOvKPukGQ/ScreenDataSets.+H1x04X1okGZ41Eil2oZUQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, \"eninvoiceextendedforeigner2\".\"invoicenumber\" o50, \"eninvoiceextendedforeigner2\".\"direction\" o51, \"eninvoiceextendedforeigner2\".\"receiversocialreason\" o52, \"eninvoiceextendedforeigner2\".\"receiverrfc\" o53, \"eninvoiceextendedforeigner2\".\"issuersocialreason\" o54, \"eninvoiceextendedforeigner2\".\"issuertaxid\" o55, \"eninvoiceextendedforeigner2\".\"invoicedate\" o56, trim_scale(\"eninvoiceextendedforeigner2\".\"totalamount\"::numeric) o57, \"eninvoiceextendedforeigner2\".\"currency\" o58");
fromBuilder.Append(" FROM ((({Folio} \"enfolio114\" Left JOIN {Invoice} \"eninvoice159\" ON (\"enfolio114\".\"id\" = \"eninvoice159\".\"folioid\"))  Left JOIN {InvoiceExtendedForeigner} \"eninvoiceextendedforeigner2\" ON (\"eninvoice159\".\"id\" = \"eninvoiceextendedforeigner2\".\"id\"))  Left JOIN {Currency} \"encurrency52\" ON (\"enfolio114\".\"currencyid\" = \"encurrency52\".\"code\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio114\".\"id\" = @qpfoFolio_Id) AND (\"enfolio114\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio114\".\"id\" IS NULL)");
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
RL_06a48d30ec1735b8ae6350ea4dbe82c6 outParamList = new RL_06a48d30ec1735b8ae6350ea4dbe82c6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_ForeignSupplierInvoiceDetails.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_06a48d30ec1735b8ae6350ea4dbe82c6 _tmp = new RL_06a48d30ec1735b8ae6350ea4dbe82c6();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_ForeignSupplierInvoiceDetails.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_06a48d30ec1735b8ae6350ea4dbe82c6)_tmp;
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
