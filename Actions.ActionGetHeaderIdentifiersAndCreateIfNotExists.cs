namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetHeaderIdentifiersAndCreateIfNotExists : VarsBag {
public ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data;
public bool inParamCreateIfNotExists;
public long resServiceDocumentTypeCreateOrUpdate_outParamId = 0L;

public RL_d369b356f77fe3a0c5803a2290f0d56b queryResGetIdentifiers_outParamList = new RL_d369b356f77fe3a0c5803a2290f0d56b();
public long queryResGetIdentifiers_outParamCount = 0L;

public long resServiceCompanyCreateOrUpdate_outParamId = 0L;

public lcvGetHeaderIdentifiersAndCreateIfNotExists(ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data, bool inParamCreateIfNotExists) {
this.inParami_Data = inParami_Data;
this.inParamCreateIfNotExists = inParamCreateIfNotExists;
}
}
public class lcoGetHeaderIdentifiersAndCreateIfNotExists : VarsBag {
public RC_06ae1f23d9c7cedfe36d2b236ac6d94c outParamResult = new RC_06ae1f23d9c7cedfe36d2b236ac6d94c();

public lcoGetHeaderIdentifiersAndCreateIfNotExists() {
}
}
/// <summary>
/// Action <code>GetHeaderIdentifiersAndCreateIfNotExists</code> that represents the Service Studio
///  action <code>GetHeaderIdentifiersAndCreateIfNotExists</code> <p> Description: </p>
/// </summary>
public static async Task<RC_06ae1f23d9c7cedfe36d2b236ac6d94c> ActionGetHeaderIdentifiersAndCreateIfNotExists(IRequestContext requestContext,ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data,bool inParamCreateIfNotExists,CancellationToken cancellationToken) {
RC_06ae1f23d9c7cedfe36d2b236ac6d94c outParamResult = default;
lcoGetHeaderIdentifiersAndCreateIfNotExists result = new lcoGetHeaderIdentifiersAndCreateIfNotExists();
lcvGetHeaderIdentifiersAndCreateIfNotExists localVars = new lcvGetHeaderIdentifiersAndCreateIfNotExists(inParami_Data, inParamCreateIfNotExists);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetHeaderIdentifiersAndCreateIfNotExists", "b54b209e-4ea1-4233-9883-f0b16d7421a8"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetHeaderIdentifiersAndCreateIfNotExists", "b54b209e-4ea1-4233-9883-f0b16d7421a8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query QueryGetIdentifiers
cancellationToken.ThrowIfCancellationRequested();
int QueryGetIdentifiers_maxRecords = 1;
if (QueryGetIdentifiers_maxRecords < 1) QueryGetIdentifiers_maxRecords = 1;
int QueryGetIdentifiers_startIndex = 0;(localVars.queryResGetIdentifiers_outParamList,localVars.queryResGetIdentifiers_outParamCount) = await FuncActionGetHeaderIdentifiersAndCreateIfNotExists.QueryGetIdentifiers(requestContext,QueryGetIdentifiers_maxRecords,QueryGetIdentifiers_startIndex,IterationMultiplicity.Never,localVars.inParami_Data.ssCompanyCode,localVars.inParami_Data.ssCurrencyCode,localVars.inParami_Data.ssClassDocument,localVars.inParami_Data.ssOrderNumber,localVars.inParami_Data.ssProcurementGroup,cancellationToken);

// Result.CompanyId = LongIntegerToIdentifier
result.outParamResult.ssCompanyId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTCompanyId.ssValue);

// Result.RegionId = LongIntegerToIdentifier
result.outParamResult.ssRegionId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTRegionId.ssValue);

// Result.OrderMainId = LongIntegerToIdentifier
result.outParamResult.ssOrderMainId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTOrderMainId.ssValue);

// Result.DocumentTypeId = LongIntegerToIdentifier
result.outParamResult.ssDocumentTypeId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTDocumentTypeId.ssValue);

// Result.CurrencyId = TextToIdentifier
result.outParamResult.ssCurrencyId = BuiltInFunction.TextToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTCurrencyId.ssValue);
if((((localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTCompanyId.ssValue==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))&&localVars.inParamCreateIfNotExists))) {
// ServiceCompanyCreateOrUpdate
localVars.resServiceCompanyCreateOrUpdate_outParamId = await ServiceAPIs.ServiceAPIServiceCompanyCreateOrUpdate(requestContext,new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssExternalId = localVars.inParami_Data.ssCompanyCode, ssDescription = localVars.inParami_Data.ssCompanyCode },cancellationToken);

// Result.CompanyId = ServiceCompanyCreateOrUpdate.Id
result.outParamResult.ssCompanyId = localVars.resServiceCompanyCreateOrUpdate_outParamId;
}

if((((localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTDocumentTypeId.ssValue==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))&&localVars.inParamCreateIfNotExists))) {
// ServiceDocumentTypeCreateOrUpdate
localVars.resServiceDocumentTypeCreateOrUpdate_outParamId = await ServiceAPIs.ServiceAPIServiceDocumentTypeCreateOrUpdate(requestContext,new EN_a70d553ce1458b3952d039852f258a76EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssClasse = localVars.inParami_Data.ssClassDocument, ssDescription = localVars.inParami_Data.ssClassDocument, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId (), ssUpdatedOn = BuiltInFunction.CurrDateTime (), ssUpdatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// Result.DocumentTypeId = ServiceDocumentTypeCreateOrUpdate.Id
result.outParamResult.ssDocumentTypeId = localVars.resServiceDocumentTypeCreateOrUpdate_outParamId;
}

} //close CreateActionActivity using block
} // try

finally {
outParamResult = result.outParamResult;
} // inner-finally
RETURN_STATEMENT:
return outParamResult;
}

public static class FuncActionGetHeaderIdentifiersAndCreateIfNotExists {

private static async Task<RC_f8d32413a09252891cf320a9f349aadb> QueryGetIdentifiersReadDbAsync(RC_f8d32413a09252891cf320a9f349aadb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssSTCompanyId.Read(r, ref index);
rec.ssSTCompanyId_c.Read(r, ref index);
rec.ssSTCurrencyId.Read(r, ref index);
rec.ssSTCurrencyId_c.Read(r, ref index);
rec.ssSTDocumentTypeId.Read(r, ref index);
rec.ssSTDocumentTypeId_c.Read(r, ref index);
rec.ssSTOrderMainId.Read(r, ref index);
rec.ssSTOrderMainId_c.Read(r, ref index);
rec.ssSTRegionId.Read(r, ref index);
rec.ssSTRegionId_c.Read(r, ref index);
return rec;
}
// Query Function "GetIdentifiers" UNmFc1k07kamg3Qd56JCJw of Action "GetHeaderIdentifiersAndCreateIfNotExists"
public static async Task<(RL_d369b356f77fe3a0c5803a2290f0d56b,long)> QueryGetIdentifiers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qptei_Company,string qptei_CurrencyCode,string qptei_DocumentClass,string qptei_OrderNumber,string qptei_PurchasingGroupCode,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("GetHeaderIdentifiersAndCreateIfNotExists.GetIdentifiers", "7385d950-3459-46ee-a683-741de7a24227");
using var queryActivity = activitySource.CreateSqlQueryActivity("GetHeaderIdentifiersAndCreateIfNotExists.GetIdentifiers", "7385d950-3459-46ee-a683-741de7a24227", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityDocumentType = AppUtils.Instance.RuntimeEntityReplace("DocumentType");
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityPurchasingGroup = AppUtils.Instance.RuntimeEntityReplace("PurchasingGroup");
sqlCmd.CreateParameter("@qptei_Company", DbType.String, qptei_Company);
sqlCmd.CreateParameter("@qptei_CurrencyCode", DbType.String, qptei_CurrencyCode);
sqlCmd.CreateParameter("@qptei_DocumentClass", DbType.String, qptei_DocumentClass);
sqlCmd.CreateParameter("@qptei_OrderNumber", DbType.String, qptei_OrderNumber);
sqlCmd.CreateParameter("@qptei_PurchasingGroupCode", DbType.String, qptei_PurchasingGroupCode);
string sql = "";
string advSql = "SELECT  \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"externalid\"") + ")) = UPPER(TRIM(@qptei_Company)) LIMIT 1)) \"companyid\", \n    ((SELECT count( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + ") FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"externalid\"") + ")) = UPPER(TRIM(@qptei_Company)) LIMIT 1)) \"companyid_c\", \n \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ")) = UPPER(TRIM(@qptei_CurrencyCode)) LIMIT 1)) \"currencyid\", \n    ((SELECT count( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ") FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ")) = UPPER(TRIM(@qptei_CurrencyCode)) LIMIT 1)) \"currencyid_c\", \n \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,".\"classe\"") + ")) = UPPER(TRIM(@qptei_DocumentClass)) LIMIT 1)) \"documenttypeid\", \n    ((SELECT count( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,".\"id\"") + ") FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,".\"classe\"") + ")) = UPPER(TRIM(@qptei_DocumentClass)) LIMIT 1)) \"documenttypeid_c\", \n \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + ")) = UPPER(TRIM(@qptei_OrderNumber)) LIMIT 1)) \"ordermainid\", \n    ((SELECT count( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + ") FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + ")) = UPPER(TRIM(@qptei_OrderNumber)) LIMIT 1)) \"ordermainid_c\", \n \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPurchasingGroup,".\"regionid\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPurchasingGroup,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPurchasingGroup,".\"code\"") + ")) = UPPER(TRIM(@qptei_PurchasingGroupCode)) LIMIT 1)) \"regionid\", \n    ((SELECT count( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPurchasingGroup,".\"regionid\"") + ") FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPurchasingGroup,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPurchasingGroup,".\"code\"") + ")) = UPPER(TRIM(@qptei_PurchasingGroupCode)) LIMIT 1)) \"regionid_c\"";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_d369b356f77fe3a0c5803a2290f0d56b outParamList = new RL_d369b356f77fe3a0c5803a2290f0d56b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = QueryGetIdentifiersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[10];
opt[0] = new BitArray(new bool[] {false});
opt[1] = new BitArray(new bool[] {false});
opt[2] = new BitArray(new bool[] {false});
opt[3] = new BitArray(new bool[] {false});
opt[4] = new BitArray(new bool[] {false});
opt[5] = new BitArray(new bool[] {false});
opt[6] = new BitArray(new bool[] {false});
opt[7] = new BitArray(new bool[] {false});
opt[8] = new BitArray(new bool[] {false});
opt[9] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetHeaderIdentifiersAndCreateIfNotExists.GetIdentifiers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d369b356f77fe3a0c5803a2290f0d56b _tmp = new RL_d369b356f77fe3a0c5803a2290f0d56b();
_tmp.AlternateReadDbMethodAsync = QueryGetIdentifiersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetHeaderIdentifiersAndCreateIfNotExists.GetIdentifiers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d369b356f77fe3a0c5803a2290f0d56b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetIdentifiers in GetHeaderIdentifiersAndCreateIfNotExists in ConectaProveedores (SELECT       ((SELECT {Company}.[Id] FROM {Company} WHERE UPPER(TRIM({Company}.[ExternalId])) = UPPER(TRIM(@i_Company)) LIMIT 1)) [CompanyId],      ((SELECT count({Company}.[Id]) FROM {Company} WHERE UPPER(TRIM({Company}.[ExternalId])) = UPPER(TRIM(@i_Company)) LIMIT 1)) [CompanyId_c],        ((SELECT {Currency}.[Code] FROM {Currency} WHERE UPPER(TRIM({Currency}.[Code])) = UPPER(TRIM(@i_CurrencyCode)) LIMIT 1)) [CurrencyId],      ((SELECT count({Currency}.[Code]) FROM {Currency} WHERE UPPER(TRIM({Currency}.[Code])) = UPPER(TRIM(@i_CurrencyCode)) LIMIT 1)) [CurrencyId_c],        ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE UPPER(TRIM({DocumentType}.[Classe])) = UPPER(TRIM(@i_DocumentClass)) LIMIT 1)) [DocumentTypeId],      ((SELECT count({DocumentType}.[Id]) FROM {DocumentType} WHERE UPPER(TRIM({DocumentType}.[Classe])) = UPPER(TRIM(@i_DocumentClass)) LIMIT 1)) [DocumentTypeId_c],        ((SELECT {OrderMain}.[Id] FROM {OrderMain} WHERE UPPER(TRIM({OrderMain}.[OrderNumber])) =  ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetIdentifiers in GetHeaderIdentifiersAndCreateIfNotExists in ConectaProveedores (SELECT       ((SELECT {Company}.[Id] FROM {Company} WHERE UPPER(TRIM({Company}.[ExternalId])) = UPPER(TRIM(@i_Company)) LIMIT 1)) [CompanyId],      ((SELECT count({Company}.[Id]) FROM {Company} WHERE UPPER(TRIM({Company}.[ExternalId])) = UPPER(TRIM(@i_Company)) LIMIT 1)) [CompanyId_c],        ((SELECT {Currency}.[Code] FROM {Currency} WHERE UPPER(TRIM({Currency}.[Code])) = UPPER(TRIM(@i_CurrencyCode)) LIMIT 1)) [CurrencyId],      ((SELECT count({Currency}.[Code]) FROM {Currency} WHERE UPPER(TRIM({Currency}.[Code])) = UPPER(TRIM(@i_CurrencyCode)) LIMIT 1)) [CurrencyId_c],        ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE UPPER(TRIM({DocumentType}.[Classe])) = UPPER(TRIM(@i_DocumentClass)) LIMIT 1)) [DocumentTypeId],      ((SELECT count({DocumentType}.[Id]) FROM {DocumentType} WHERE UPPER(TRIM({DocumentType}.[Classe])) = UPPER(TRIM(@i_DocumentClass)) LIMIT 1)) [DocumentTypeId_c],        ((SELECT {OrderMain}.[Id] FROM {OrderMain} WHERE UPPER(TRIM({OrderMain}.[OrderNumber])) =  ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetIdentifiers in GetHeaderIdentifiersAndCreateIfNotExists in ConectaProveedores (SELECT       ((SELECT {Company}.[Id] FROM {Company} WHERE UPPER(TRIM({Company}.[ExternalId])) = UPPER(TRIM(@i_Company)) LIMIT 1)) [CompanyId],      ((SELECT count({Company}.[Id]) FROM {Company} WHERE UPPER(TRIM({Company}.[ExternalId])) = UPPER(TRIM(@i_Company)) LIMIT 1)) [CompanyId_c],        ((SELECT {Currency}.[Code] FROM {Currency} WHERE UPPER(TRIM({Currency}.[Code])) = UPPER(TRIM(@i_CurrencyCode)) LIMIT 1)) [CurrencyId],      ((SELECT count({Currency}.[Code]) FROM {Currency} WHERE UPPER(TRIM({Currency}.[Code])) = UPPER(TRIM(@i_CurrencyCode)) LIMIT 1)) [CurrencyId_c],        ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE UPPER(TRIM({DocumentType}.[Classe])) = UPPER(TRIM(@i_DocumentClass)) LIMIT 1)) [DocumentTypeId],      ((SELECT count({DocumentType}.[Id]) FROM {DocumentType} WHERE UPPER(TRIM({DocumentType}.[Classe])) = UPPER(TRIM(@i_DocumentClass)) LIMIT 1)) [DocumentTypeId_c],        ((SELECT {OrderMain}.[Id] FROM {OrderMain} WHERE UPPER(TRIM({OrderMain}.[OrderNumber])) =  ...): " + aqExcep.Message));
}
}
}



}


}
