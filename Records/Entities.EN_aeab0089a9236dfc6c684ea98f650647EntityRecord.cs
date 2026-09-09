using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENRequisitionContractFileEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRequisitionContractFileEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Id, "id") ?? "id"},
{"requisitionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid"},
{"requisitionfileid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionFileId, "requisitionfileid") ?? "requisitionfileid"},
{"contractfiletypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid"},
{"amount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Amount, "amount") ?? "amount"},
{"currencyid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid"},
{"deposittypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid"},
{"insurancetypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid"},
{"advancepaymenttypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, "requi_u8aqr95gpfeyomkyy1x3n7c4"));
}
} // ENRequisitionContractFileEntity

}

