using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENFolioExtendedEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFolioExtendedEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@Id, "id") ?? "id"},
{"isadvpayment", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsAdvPayment, "isadvpayment") ?? "isadvpayment"},
{"advpaymentvalue", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@AdvPaymentValue, "advpaymentvalue") ?? "advpaymentvalue"},
{"iscreditnote", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsCreditNote, "iscreditnote") ?? "iscreditnote"},
{"creditnotevalue", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@CreditNoteValue, "creditnotevalue") ?? "creditnotevalue"},
{"isvoucher", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsVoucher, "isvoucher") ?? "isvoucher"},
{"vouchervalue", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@VoucherValue, "vouchervalue") ?? "vouchervalue"},
{"isna", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsNa, "isna") ?? "isna"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, "folio_u8aqr95gpfe_svdfq715p5x0"));
}
} // ENFolioExtendedEntity

}

