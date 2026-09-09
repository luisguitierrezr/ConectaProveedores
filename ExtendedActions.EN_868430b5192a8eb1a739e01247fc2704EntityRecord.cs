using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateFolioItems
/// </summary>

public static async Task<long> CreateFolioItems(IRequestContext requestContext,RC_f861f2b559524d098e0981156af9b7ab inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateFolioItems", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateFolioItems", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_868430b5192a8eb1a739e01247fc2704EntityRecord ssENFolioItems = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENFolioItemsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@FolioId, "folioid") ?? "folioid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderMainItemId, "ordermainitemid") ?? "ordermainitemid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@ArticleNumber, "articlenumber") ?? "articlenumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Description, "description") ?? "description") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InputationCode, "inputationcode") ?? "inputationcode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@RemainingQtt, "remainingqtt") ?? "remainingqtt") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@TotalPrice, "totalprice") ?? "totalprice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Quantity, "quantity") ?? "quantity") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryQtt, "deliveryqtt") ?? "deliveryqtt") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Importdelivery, "importdelivery") ?? "importdelivery") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PEP, "pep") ?? "pep") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceId, "placeid") ?? "placeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceName, "placename") ?? "placename") + "" +
" ) VALUES (" +
" @ssFolioId" +
", @ssOrderMainItemId" +
", @ssOrderNumber" +
", @ssArticleNumber" +
", @ssDescription" +
", @ssInputationCode" +
", @ssDeliveryDate" +
", @ssInvoiceQtt" +
", @ssRemainingQtt" +
", @ssUnitPrice" +
", @ssTotalPrice" +
", @ssQuantity" +
", @ssDeliveryQtt" +
", @ssImportdelivery" +
", @ssPEP" +
", @ssPlaceId" +
", @ssPlaceName" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENFolioItems.ssFolioId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioItems.ssFolioId);

}
if ((ssENFolioItems.ssOrderMainItemId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderMainItemId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderMainItemId", DbType.Int64, ssENFolioItems.ssOrderMainItemId);

}
insertSqlCmd.CreateParameter("@ssOrderNumber", DbType.String, ssENFolioItems.ssOrderNumber);
insertSqlCmd.CreateParameter("@ssArticleNumber", DbType.String, ssENFolioItems.ssArticleNumber);
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENFolioItems.ssDescription);
insertSqlCmd.CreateParameter("@ssInputationCode", DbType.String, ssENFolioItems.ssInputationCode);
insertSqlCmd.CreateParameter("@ssDeliveryDate", DbType.DateTime, ssENFolioItems.ssDeliveryDate);
var InvoiceQttParameter = insertSqlCmd.CreateParameter("@ssInvoiceQtt", DbType.Decimal, ssENFolioItems.ssInvoiceQtt);
{
    string decimalAsStr = ssENFolioItems.ssInvoiceQtt.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {InvoiceQttParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var RemainingQttParameter = insertSqlCmd.CreateParameter("@ssRemainingQtt", DbType.Decimal, ssENFolioItems.ssRemainingQtt);
{
    string decimalAsStr = ssENFolioItems.ssRemainingQtt.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RemainingQttParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var UnitPriceParameter = insertSqlCmd.CreateParameter("@ssUnitPrice", DbType.Decimal, ssENFolioItems.ssUnitPrice);
{
    string decimalAsStr = ssENFolioItems.ssUnitPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {UnitPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TotalPriceParameter = insertSqlCmd.CreateParameter("@ssTotalPrice", DbType.Decimal, ssENFolioItems.ssTotalPrice);
{
    string decimalAsStr = ssENFolioItems.ssTotalPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var QuantityParameter = insertSqlCmd.CreateParameter("@ssQuantity", DbType.Decimal, ssENFolioItems.ssQuantity);
{
    string decimalAsStr = ssENFolioItems.ssQuantity.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {QuantityParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssDeliveryQtt", DbType.String, ssENFolioItems.ssDeliveryQtt);
insertSqlCmd.CreateParameter("@ssImportdelivery", DbType.String, ssENFolioItems.ssImportdelivery);
insertSqlCmd.CreateParameter("@ssPEP", DbType.String, ssENFolioItems.ssPEP);
insertSqlCmd.CreateParameter("@ssPlaceId", DbType.String, ssENFolioItems.ssPlaceId);
insertSqlCmd.CreateParameter("@ssPlaceName", DbType.String, ssENFolioItems.ssPlaceName);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateFolioItems", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateFolioItems
/// </summary>

public static async Task<long> CreateOrUpdateFolioItems(IRequestContext requestContext,BitArray usedFields,RC_f861f2b559524d098e0981156af9b7ab inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateFolioItems", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateFolioItems", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_868430b5192a8eb1a739e01247fc2704EntityRecord ssENFolioItems = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(18,true);
}
string updateSet = "UPDATE " + ENFolioItemsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = @ssFolioId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderMainItemId, "ordermainitemid") ?? "ordermainitemid") + " = @ssOrderMainItemId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + " = @ssOrderNumber"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@ArticleNumber, "articlenumber") ?? "articlenumber") + " = @ssArticleNumber"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Description, "description") ?? "description") + " = @ssDescription"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InputationCode, "inputationcode") ?? "inputationcode") + " = @ssInputationCode"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + " = @ssDeliveryDate"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt") + " = @ssInvoiceQtt"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@RemainingQtt, "remainingqtt") ?? "remainingqtt") + " = @ssRemainingQtt"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + " = @ssUnitPrice"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@TotalPrice, "totalprice") ?? "totalprice") + " = @ssTotalPrice"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Quantity, "quantity") ?? "quantity") + " = @ssQuantity"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryQtt, "deliveryqtt") ?? "deliveryqtt") + " = @ssDeliveryQtt"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Importdelivery, "importdelivery") ?? "importdelivery") + " = @ssImportdelivery"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PEP, "pep") ?? "pep") + " = @ssPEP"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceId, "placeid") ?? "placeid") + " = @ssPlaceId"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceName, "placename") ?? "placename") + " = @ssPlaceName"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFolioItems_ssId_FolioItems";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENFolioItems.ssFolioId==0L)) {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioItems.ssFolioId);

}
}
if(usedFields[2]) {
if ((ssENFolioItems.ssOrderMainItemId==0L)) {
sqlCmd.CreateParameter("@ssOrderMainItemId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderMainItemId", DbType.Int64, ssENFolioItems.ssOrderMainItemId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssOrderNumber", DbType.String, ssENFolioItems.ssOrderNumber);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssArticleNumber", DbType.String, ssENFolioItems.ssArticleNumber);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENFolioItems.ssDescription);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssInputationCode", DbType.String, ssENFolioItems.ssInputationCode);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssDeliveryDate", DbType.DateTime, ssENFolioItems.ssDeliveryDate);
}
if(usedFields[8]) {
var InvoiceQttParameter = sqlCmd.CreateParameter("@ssInvoiceQtt", DbType.Decimal, ssENFolioItems.ssInvoiceQtt);
{
    string decimalAsStr = ssENFolioItems.ssInvoiceQtt.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {InvoiceQttParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[9]) {
var RemainingQttParameter = sqlCmd.CreateParameter("@ssRemainingQtt", DbType.Decimal, ssENFolioItems.ssRemainingQtt);
{
    string decimalAsStr = ssENFolioItems.ssRemainingQtt.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RemainingQttParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[10]) {
var UnitPriceParameter = sqlCmd.CreateParameter("@ssUnitPrice", DbType.Decimal, ssENFolioItems.ssUnitPrice);
{
    string decimalAsStr = ssENFolioItems.ssUnitPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {UnitPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[11]) {
var TotalPriceParameter = sqlCmd.CreateParameter("@ssTotalPrice", DbType.Decimal, ssENFolioItems.ssTotalPrice);
{
    string decimalAsStr = ssENFolioItems.ssTotalPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[12]) {
var QuantityParameter = sqlCmd.CreateParameter("@ssQuantity", DbType.Decimal, ssENFolioItems.ssQuantity);
{
    string decimalAsStr = ssENFolioItems.ssQuantity.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {QuantityParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssDeliveryQtt", DbType.String, ssENFolioItems.ssDeliveryQtt);
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssImportdelivery", DbType.String, ssENFolioItems.ssImportdelivery);
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssPEP", DbType.String, ssENFolioItems.ssPEP);
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssPlaceId", DbType.String, ssENFolioItems.ssPlaceId);
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssPlaceName", DbType.String, ssENFolioItems.ssPlaceName);
}
sqlCmd.CreateParameter("@idparam_ssENFolioItems_ssId_FolioItems", DbType.Int64, ssENFolioItems.ssId);
int counter = 0;
if(ssENFolioItems.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFolioItems (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENFolioItemsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@FolioId, "folioid") ?? "folioid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderMainItemId, "ordermainitemid") ?? "ordermainitemid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@ArticleNumber, "articlenumber") ?? "articlenumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Description, "description") ?? "description") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InputationCode, "inputationcode") ?? "inputationcode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@RemainingQtt, "remainingqtt") ?? "remainingqtt") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@TotalPrice, "totalprice") ?? "totalprice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Quantity, "quantity") ?? "quantity") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryQtt, "deliveryqtt") ?? "deliveryqtt") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Importdelivery, "importdelivery") ?? "importdelivery") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PEP, "pep") ?? "pep") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceId, "placeid") ?? "placeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceName, "placename") ?? "placename") + "" +
" ) VALUES (" +
" @ssFolioId" +
", @ssOrderMainItemId" +
", @ssOrderNumber" +
", @ssArticleNumber" +
", @ssDescription" +
", @ssInputationCode" +
", @ssDeliveryDate" +
", @ssInvoiceQtt" +
", @ssRemainingQtt" +
", @ssUnitPrice" +
", @ssTotalPrice" +
", @ssQuantity" +
", @ssDeliveryQtt" +
", @ssImportdelivery" +
", @ssPEP" +
", @ssPlaceId" +
", @ssPlaceName" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENFolioItems.ssFolioId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioItems.ssFolioId);

}
if ((ssENFolioItems.ssOrderMainItemId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderMainItemId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderMainItemId", DbType.Int64, ssENFolioItems.ssOrderMainItemId);

}
insertSqlCmd.CreateParameter("@ssOrderNumber", DbType.String, ssENFolioItems.ssOrderNumber);
insertSqlCmd.CreateParameter("@ssArticleNumber", DbType.String, ssENFolioItems.ssArticleNumber);
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENFolioItems.ssDescription);
insertSqlCmd.CreateParameter("@ssInputationCode", DbType.String, ssENFolioItems.ssInputationCode);
insertSqlCmd.CreateParameter("@ssDeliveryDate", DbType.DateTime, ssENFolioItems.ssDeliveryDate);
var InvoiceQttParameter = insertSqlCmd.CreateParameter("@ssInvoiceQtt", DbType.Decimal, ssENFolioItems.ssInvoiceQtt);
{
    string decimalAsStr = ssENFolioItems.ssInvoiceQtt.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {InvoiceQttParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var RemainingQttParameter = insertSqlCmd.CreateParameter("@ssRemainingQtt", DbType.Decimal, ssENFolioItems.ssRemainingQtt);
{
    string decimalAsStr = ssENFolioItems.ssRemainingQtt.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RemainingQttParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var UnitPriceParameter = insertSqlCmd.CreateParameter("@ssUnitPrice", DbType.Decimal, ssENFolioItems.ssUnitPrice);
{
    string decimalAsStr = ssENFolioItems.ssUnitPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {UnitPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TotalPriceParameter = insertSqlCmd.CreateParameter("@ssTotalPrice", DbType.Decimal, ssENFolioItems.ssTotalPrice);
{
    string decimalAsStr = ssENFolioItems.ssTotalPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var QuantityParameter = insertSqlCmd.CreateParameter("@ssQuantity", DbType.Decimal, ssENFolioItems.ssQuantity);
{
    string decimalAsStr = ssENFolioItems.ssQuantity.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {QuantityParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssDeliveryQtt", DbType.String, ssENFolioItems.ssDeliveryQtt);
insertSqlCmd.CreateParameter("@ssImportdelivery", DbType.String, ssENFolioItems.ssImportdelivery);
insertSqlCmd.CreateParameter("@ssPEP", DbType.String, ssENFolioItems.ssPEP);
insertSqlCmd.CreateParameter("@ssPlaceId", DbType.String, ssENFolioItems.ssPlaceId);
insertSqlCmd.CreateParameter("@ssPlaceName", DbType.String, ssENFolioItems.ssPlaceName);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFolioItems", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENFolioItems.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeFolioItems
/// </summary>

public static async Task CreateOrUpdateSomeFolioItems(IRequestContext requestContext,RL_20398ad87fe6d4946bb9511e3c38754f inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeFolioItems", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeFolioItems", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENFolioItemsEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@FolioId, "folioid") ?? "folioid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderMainItemId, "ordermainitemid") ?? "ordermainitemid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@ArticleNumber, "articlenumber") ?? "articlenumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Description, "description") ?? "description") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InputationCode, "inputationcode") ?? "inputationcode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@RemainingQtt, "remainingqtt") ?? "remainingqtt") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@TotalPrice, "totalprice") ?? "totalprice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Quantity, "quantity") ?? "quantity") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryQtt, "deliveryqtt") ?? "deliveryqtt") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Importdelivery, "importdelivery") ?? "importdelivery") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PEP, "pep") ?? "pep") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceId, "placeid") ?? "placeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceName, "placename") ?? "placename") + ") VALUES ( unnest(@ssFolioId),  unnest(@ssOrderMainItemId),  unnest(@ssOrderNumber),  unnest(@ssArticleNumber),  unnest(@ssDescription),  unnest(@ssInputationCode),  unnest(@ssDeliveryDate),  unnest(@ssInvoiceQtt),  unnest(@ssRemainingQtt),  unnest(@ssUnitPrice),  unnest(@ssTotalPrice),  unnest(@ssQuantity),  unnest(@ssDeliveryQtt),  unnest(@ssImportdelivery),  unnest(@ssPEP),  unnest(@ssPlaceId),  unnest(@ssPlaceName)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@FolioId, "folioid") ?? "folioid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderMainItemId, "ordermainitemid") ?? "ordermainitemid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderMainItemId, "ordermainitemid") ?? "ordermainitemid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@ArticleNumber, "articlenumber") ?? "articlenumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@ArticleNumber, "articlenumber") ?? "articlenumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Description, "description") ?? "description") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Description, "description") ?? "description") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InputationCode, "inputationcode") ?? "inputationcode") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InputationCode, "inputationcode") ?? "inputationcode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@RemainingQtt, "remainingqtt") ?? "remainingqtt") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@RemainingQtt, "remainingqtt") ?? "remainingqtt") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@TotalPrice, "totalprice") ?? "totalprice") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@TotalPrice, "totalprice") ?? "totalprice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Quantity, "quantity") ?? "quantity") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Quantity, "quantity") ?? "quantity") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryQtt, "deliveryqtt") ?? "deliveryqtt") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryQtt, "deliveryqtt") ?? "deliveryqtt") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Importdelivery, "importdelivery") ?? "importdelivery") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Importdelivery, "importdelivery") ?? "importdelivery") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PEP, "pep") ?? "pep") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PEP, "pep") ?? "pep") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceId, "placeid") ?? "placeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceId, "placeid") ?? "placeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceName, "placename") ?? "placename") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceName, "placename") ?? "placename") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssFolioId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@FolioId, "folioid") ?? "folioid") + ",  unnest(@ssOrderMainItemId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderMainItemId, "ordermainitemid") ?? "ordermainitemid") + ",  unnest(@ssOrderNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + ",  unnest(@ssArticleNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@ArticleNumber, "articlenumber") ?? "articlenumber") + ",  unnest(@ssDescription) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Description, "description") ?? "description") + ",  unnest(@ssInputationCode) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InputationCode, "inputationcode") ?? "inputationcode") + ",  unnest(@ssDeliveryDate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + ",  unnest(@ssInvoiceQtt) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt") + ",  unnest(@ssRemainingQtt) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@RemainingQtt, "remainingqtt") ?? "remainingqtt") + ",  unnest(@ssUnitPrice) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + ",  unnest(@ssTotalPrice) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@TotalPrice, "totalprice") ?? "totalprice") + ",  unnest(@ssQuantity) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Quantity, "quantity") ?? "quantity") + ",  unnest(@ssDeliveryQtt) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryQtt, "deliveryqtt") ?? "deliveryqtt") + ",  unnest(@ssImportdelivery) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Importdelivery, "importdelivery") ?? "importdelivery") + ",  unnest(@ssPEP) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PEP, "pep") ?? "pep") + ",  unnest(@ssPlaceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceId, "placeid") ?? "placeid") + ",  unnest(@ssPlaceName) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceName, "placename") ?? "placename") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertFolioIdList = new List<object>();
List<object> insertOrderMainItemIdList = new List<object>();
List<string> insertOrderNumberList = new List<string>();
List<string> insertArticleNumberList = new List<string>();
List<string> insertDescriptionList = new List<string>();
List<string> insertInputationCodeList = new List<string>();
List<DateTime> insertDeliveryDateList = new List<DateTime>();
List<decimal> insertInvoiceQttList = new List<decimal>();
List<decimal> insertRemainingQttList = new List<decimal>();
List<decimal> insertUnitPriceList = new List<decimal>();
List<decimal> insertTotalPriceList = new List<decimal>();
List<decimal> insertQuantityList = new List<decimal>();
List<string> insertDeliveryQttList = new List<string>();
List<string> insertImportdeliveryList = new List<string>();
List<string> insertPEPList = new List<string>();
List<string> insertPlaceIdList = new List<string>();
List<string> insertPlaceNameList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateFolioIdList = new List<object>();
List<object> updateOrderMainItemIdList = new List<object>();
List<string> updateOrderNumberList = new List<string>();
List<string> updateArticleNumberList = new List<string>();
List<string> updateDescriptionList = new List<string>();
List<string> updateInputationCodeList = new List<string>();
List<DateTime> updateDeliveryDateList = new List<DateTime>();
List<decimal> updateInvoiceQttList = new List<decimal>();
List<decimal> updateRemainingQttList = new List<decimal>();
List<decimal> updateUnitPriceList = new List<decimal>();
List<decimal> updateTotalPriceList = new List<decimal>();
List<decimal> updateQuantityList = new List<decimal>();
List<string> updateDeliveryQttList = new List<string>();
List<string> updateImportdeliveryList = new List<string>();
List<string> updatePEPList = new List<string>();
List<string> updatePlaceIdList = new List<string>();
List<string> updatePlaceNameList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_f861f2b559524d098e0981156af9b7ab)inParamSourceList.Current).ssENFolioItems;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssFolioId==0L)) {
updateFolioIdList.Add(null);
} else {
updateFolioIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioId));
}
if ((record.ssOrderMainItemId==0L)) {
updateOrderMainItemIdList.Add(null);
} else {
updateOrderMainItemIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderMainItemId));
}
updateOrderNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOrderNumber));
updateArticleNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssArticleNumber));
updateDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
updateInputationCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssInputationCode));
updateDeliveryDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssDeliveryDate));
updateInvoiceQttList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssInvoiceQtt));
updateRemainingQttList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssRemainingQtt));
updateUnitPriceList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssUnitPrice));
updateTotalPriceList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalPrice));
updateQuantityList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssQuantity));
updateDeliveryQttList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDeliveryQtt));
updateImportdeliveryList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssImportdelivery));
updatePEPList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPEP));
updatePlaceIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPlaceId));
updatePlaceNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPlaceName));
} else {
if ((record.ssFolioId==0L)) {
insertFolioIdList.Add(null);
} else {
insertFolioIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioId));
}
if ((record.ssOrderMainItemId==0L)) {
insertOrderMainItemIdList.Add(null);
} else {
insertOrderMainItemIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderMainItemId));
}
insertOrderNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOrderNumber));
insertArticleNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssArticleNumber));
insertDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
insertInputationCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssInputationCode));
insertDeliveryDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssDeliveryDate));
insertInvoiceQttList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssInvoiceQtt));
insertRemainingQttList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssRemainingQtt));
insertUnitPriceList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssUnitPrice));
insertTotalPriceList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalPrice));
insertQuantityList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssQuantity));
insertDeliveryQttList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDeliveryQtt));
insertImportdeliveryList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssImportdelivery));
insertPEPList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPEP));
insertPlaceIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPlaceId));
insertPlaceNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPlaceName));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertFolioIdList.IsEmpty() || !insertOrderMainItemIdList.IsEmpty() || !insertOrderNumberList.IsEmpty() || !insertArticleNumberList.IsEmpty() || !insertDescriptionList.IsEmpty() || !insertInputationCodeList.IsEmpty() || !insertDeliveryDateList.IsEmpty() || !insertInvoiceQttList.IsEmpty() || !insertRemainingQttList.IsEmpty() || !insertUnitPriceList.IsEmpty() || !insertTotalPriceList.IsEmpty() || !insertQuantityList.IsEmpty() || !insertDeliveryQttList.IsEmpty() || !insertImportdeliveryList.IsEmpty() || !insertPEPList.IsEmpty() || !insertPlaceIdList.IsEmpty() || !insertPlaceNameList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssFolioId",DbType.Int64,insertFolioIdList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderMainItemId",DbType.Int64,insertOrderMainItemIdList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderNumber",DbType.String,insertOrderNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssArticleNumber",DbType.String,insertArticleNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssDescription",DbType.String,insertDescriptionList);
executionService.CreateParameter(insertSqlCmd,"@ssInputationCode",DbType.String,insertInputationCodeList);
executionService.CreateParameter(insertSqlCmd,"@ssDeliveryDate",DbType.DateTime,insertDeliveryDateList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceQtt",DbType.Decimal,insertInvoiceQttList);
executionService.CreateParameter(insertSqlCmd,"@ssRemainingQtt",DbType.Decimal,insertRemainingQttList);
executionService.CreateParameter(insertSqlCmd,"@ssUnitPrice",DbType.Decimal,insertUnitPriceList);
executionService.CreateParameter(insertSqlCmd,"@ssTotalPrice",DbType.Decimal,insertTotalPriceList);
executionService.CreateParameter(insertSqlCmd,"@ssQuantity",DbType.Decimal,insertQuantityList);
executionService.CreateParameter(insertSqlCmd,"@ssDeliveryQtt",DbType.String,insertDeliveryQttList);
executionService.CreateParameter(insertSqlCmd,"@ssImportdelivery",DbType.String,insertImportdeliveryList);
executionService.CreateParameter(insertSqlCmd,"@ssPEP",DbType.String,insertPEPList);
executionService.CreateParameter(insertSqlCmd,"@ssPlaceId",DbType.String,insertPlaceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssPlaceName",DbType.String,insertPlaceNameList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFolioItems (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateFolioIdList.IsEmpty() || !updateOrderMainItemIdList.IsEmpty() || !updateOrderNumberList.IsEmpty() || !updateArticleNumberList.IsEmpty() || !updateDescriptionList.IsEmpty() || !updateInputationCodeList.IsEmpty() || !updateDeliveryDateList.IsEmpty() || !updateInvoiceQttList.IsEmpty() || !updateRemainingQttList.IsEmpty() || !updateUnitPriceList.IsEmpty() || !updateTotalPriceList.IsEmpty() || !updateQuantityList.IsEmpty() || !updateDeliveryQttList.IsEmpty() || !updateImportdeliveryList.IsEmpty() || !updatePEPList.IsEmpty() || !updatePlaceIdList.IsEmpty() || !updatePlaceNameList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFolioId",DbType.Int64,updateFolioIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderMainItemId",DbType.Int64,updateOrderMainItemIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderNumber",DbType.String,updateOrderNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssArticleNumber",DbType.String,updateArticleNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssDescription",DbType.String,updateDescriptionList);
executionService.CreateParameter(updateSqlCmd,"@ssInputationCode",DbType.String,updateInputationCodeList);
executionService.CreateParameter(updateSqlCmd,"@ssDeliveryDate",DbType.DateTime,updateDeliveryDateList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceQtt",DbType.Decimal,updateInvoiceQttList);
executionService.CreateParameter(updateSqlCmd,"@ssRemainingQtt",DbType.Decimal,updateRemainingQttList);
executionService.CreateParameter(updateSqlCmd,"@ssUnitPrice",DbType.Decimal,updateUnitPriceList);
executionService.CreateParameter(updateSqlCmd,"@ssTotalPrice",DbType.Decimal,updateTotalPriceList);
executionService.CreateParameter(updateSqlCmd,"@ssQuantity",DbType.Decimal,updateQuantityList);
executionService.CreateParameter(updateSqlCmd,"@ssDeliveryQtt",DbType.String,updateDeliveryQttList);
executionService.CreateParameter(updateSqlCmd,"@ssImportdelivery",DbType.String,updateImportdeliveryList);
executionService.CreateParameter(updateSqlCmd,"@ssPEP",DbType.String,updatePEPList);
executionService.CreateParameter(updateSqlCmd,"@ssPlaceId",DbType.String,updatePlaceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssPlaceName",DbType.String,updatePlaceNameList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFolioItems (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteFolioItems
/// </summary>

public static async Task DeleteFolioItems(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteFolioItems", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteFolioItems", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFolioItemsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFolioItems", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllFolioItems
/// </summary>

public static async Task DeleteAllFolioItems(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllFolioItems", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllFolioItems", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFolioItemsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFolioItems", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetFolioItems
/// </summary>

public static async Task<RC_f861f2b559524d098e0981156af9b7ab> GetFolioItems(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_f861f2b559524d098e0981156af9b7ab outParamRecord = default;
outParamRecord = new RC_f861f2b559524d098e0981156af9b7ab();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFolioItems", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFolioItems", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@FolioId, "folioid") ?? "folioid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderMainItemId, "ordermainitemid") ?? "ordermainitemid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@ArticleNumber, "articlenumber") ?? "articlenumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InputationCode, "inputationcode") ?? "inputationcode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@RemainingQtt, "remainingqtt") ?? "remainingqtt", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@TotalPrice, "totalprice") ?? "totalprice", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Quantity, "quantity") ?? "quantity", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryQtt, "deliveryqtt") ?? "deliveryqtt", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Importdelivery, "importdelivery") ?? "importdelivery", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PEP, "pep") ?? "pep", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceId, "placeid") ?? "placeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceName, "placename") ?? "placename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENFolioItemsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFolioItems", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(18,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFolioItemsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetFolioItemsForUpdate
/// </summary>

public static async Task<RC_f861f2b559524d098e0981156af9b7ab> GetFolioItemsForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_f861f2b559524d098e0981156af9b7ab outParamRecord = default;
outParamRecord = new RC_f861f2b559524d098e0981156af9b7ab();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFolioItemsForUpdate", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFolioItemsForUpdate", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@FolioId, "folioid") ?? "folioid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderMainItemId, "ordermainitemid") ?? "ordermainitemid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@ArticleNumber, "articlenumber") ?? "articlenumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InputationCode, "inputationcode") ?? "inputationcode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@RemainingQtt, "remainingqtt") ?? "remainingqtt", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@TotalPrice, "totalprice") ?? "totalprice", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Quantity, "quantity") ?? "quantity", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryQtt, "deliveryqtt") ?? "deliveryqtt", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Importdelivery, "importdelivery") ?? "importdelivery", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PEP, "pep") ?? "pep", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceId, "placeid") ?? "placeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceName, "placename") ?? "placename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENFolioItemsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFolioItemsForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(18,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFolioItemsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateFolioItems
/// </summary>

public static async Task UpdateFolioItems(IRequestContext requestContext,BitArray usedFields,RC_f861f2b559524d098e0981156af9b7ab inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateFolioItems", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateFolioItems", "8acedb99-e6b9-4ba4-9415-4d3ddf0e0e8c.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_868430b5192a8eb1a739e01247fc2704EntityRecord ssENFolioItems = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(18,true);
}
string updateSet = "UPDATE " + ENFolioItemsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = @ssFolioId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderMainItemId, "ordermainitemid") ?? "ordermainitemid") + " = @ssOrderMainItemId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + " = @ssOrderNumber"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@ArticleNumber, "articlenumber") ?? "articlenumber") + " = @ssArticleNumber"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Description, "description") ?? "description") + " = @ssDescription"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InputationCode, "inputationcode") ?? "inputationcode") + " = @ssInputationCode"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + " = @ssDeliveryDate"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt") + " = @ssInvoiceQtt"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@RemainingQtt, "remainingqtt") ?? "remainingqtt") + " = @ssRemainingQtt"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + " = @ssUnitPrice"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@TotalPrice, "totalprice") ?? "totalprice") + " = @ssTotalPrice"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Quantity, "quantity") ?? "quantity") + " = @ssQuantity"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@DeliveryQtt, "deliveryqtt") ?? "deliveryqtt") + " = @ssDeliveryQtt"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Importdelivery, "importdelivery") ?? "importdelivery") + " = @ssImportdelivery"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PEP, "pep") ?? "pep") + " = @ssPEP"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceId, "placeid") ?? "placeid") + " = @ssPlaceId"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@PlaceName, "placename") ?? "placename") + " = @ssPlaceName"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFolioItems_ssId_FolioItems";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioItems, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioItemsAttributeKeys.@InvoiceQtt, "invoiceqtt") ?? "invoiceqtt") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENFolioItems.ssFolioId==0L)) {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioItems.ssFolioId);

}
}
if(usedFields[2]) {
if ((ssENFolioItems.ssOrderMainItemId==0L)) {
sqlCmd.CreateParameter("@ssOrderMainItemId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderMainItemId", DbType.Int64, ssENFolioItems.ssOrderMainItemId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssOrderNumber", DbType.String, ssENFolioItems.ssOrderNumber);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssArticleNumber", DbType.String, ssENFolioItems.ssArticleNumber);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENFolioItems.ssDescription);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssInputationCode", DbType.String, ssENFolioItems.ssInputationCode);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssDeliveryDate", DbType.DateTime, ssENFolioItems.ssDeliveryDate);
}
if(usedFields[8]) {
var InvoiceQttParameter = sqlCmd.CreateParameter("@ssInvoiceQtt", DbType.Decimal, ssENFolioItems.ssInvoiceQtt);
{
    string decimalAsStr = ssENFolioItems.ssInvoiceQtt.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {InvoiceQttParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[9]) {
var RemainingQttParameter = sqlCmd.CreateParameter("@ssRemainingQtt", DbType.Decimal, ssENFolioItems.ssRemainingQtt);
{
    string decimalAsStr = ssENFolioItems.ssRemainingQtt.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RemainingQttParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[10]) {
var UnitPriceParameter = sqlCmd.CreateParameter("@ssUnitPrice", DbType.Decimal, ssENFolioItems.ssUnitPrice);
{
    string decimalAsStr = ssENFolioItems.ssUnitPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {UnitPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[11]) {
var TotalPriceParameter = sqlCmd.CreateParameter("@ssTotalPrice", DbType.Decimal, ssENFolioItems.ssTotalPrice);
{
    string decimalAsStr = ssENFolioItems.ssTotalPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[12]) {
var QuantityParameter = sqlCmd.CreateParameter("@ssQuantity", DbType.Decimal, ssENFolioItems.ssQuantity);
{
    string decimalAsStr = ssENFolioItems.ssQuantity.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {QuantityParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssDeliveryQtt", DbType.String, ssENFolioItems.ssDeliveryQtt);
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssImportdelivery", DbType.String, ssENFolioItems.ssImportdelivery);
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssPEP", DbType.String, ssENFolioItems.ssPEP);
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssPlaceId", DbType.String, ssENFolioItems.ssPlaceId);
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssPlaceName", DbType.String, ssENFolioItems.ssPlaceName);
}
sqlCmd.CreateParameter("@idparam_ssENFolioItems_ssId_FolioItems", DbType.Int64, ssENFolioItems.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateFolioItems", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("FolioItems", ssENFolioItems.ssId.ToString()); }}
}
return;
}

}
}
