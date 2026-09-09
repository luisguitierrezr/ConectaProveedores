using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderContractFileEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderContractFileEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Id, "id") ?? "id"},
{"orderid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderId, "orderid") ?? "orderid"},
{"orderfileid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderFileId, "orderfileid") ?? "orderfileid"},
{"contractfiletypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid"},
{"amount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Amount, "amount") ?? "amount"},
{"tarif", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Tarif, "tarif") ?? "tarif"},
{"currencyid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid"},
{"deposittypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid"},
{"insurancetypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid"},
{"advancepaymenttypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid"},
{"startbasedate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate"},
{"endbasedate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate"},
{"paymenttermsid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid"},
{"isforvendorupload", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload"}
};
}
public static System.Collections.Generic.Dictionary<string,string> AttributesToDatabaseNamesMap() {
return EntityAttributes;
}
public static string AttributeDatabaseName(string attributeName) {
string databaseName;
EntityAttributes.TryGetValue(attributeName, out databaseName);
return databaseName;
}
public static string LocalViewName(string locale) {
return ViewName(locale);
}
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, "order_u8aqr95gpfe1ys15vkfitki2"));
}
} // ENOrderContractFileEntity

}

