using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENSupplierEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSupplierEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Id, "id") ?? "id"},
{"tratamiento", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Tratamiento, "tratamiento") ?? "tratamiento"},
{"name", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Name, "name") ?? "name"},
{"number", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Number, "number") ?? "number"},
{"conceptobusq_1_2", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Conceptobusq_1_2, "conceptobusq_1_2") ?? "conceptobusq_1_2"},
{"calle_numero", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Calle_Numero, "calle_numero") ?? "calle_numero"},
{"distrito", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Distrito, "distrito") ?? "distrito"},
{"codigopostal_pobl_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Codigopostal_Pobl_, "codigopostal_pobl_") ?? "codigopostal_pobl_"},
{"pais", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Pais, "pais") ?? "pais"},
{"region_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Region_, "region_") ?? "region_"},
{"idioma", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Idioma, "idioma") ?? "idioma"},
{"telefono", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Telefono, "telefono") ?? "telefono"},
{"extension", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Extension, "extension") ?? "extension"},
{"fax", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Fax, "fax") ?? "fax"},
{"cliente", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Cliente, "cliente") ?? "cliente"},
{"soc_glasociada", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Soc_GLasociada, "soc_glasociada") ?? "soc_glasociada"},
{"clavedegrupo", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Clavedegrupo, "clavedegrupo") ?? "clavedegrupo"},
{"n_ident_fis_1", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@N_ident_fis_1, "n_ident_fis_1") ?? "n_ident_fis_1"},
{"personafisica", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Personafisica, "personafisica") ?? "personafisica"},
{"ramo", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Ramo, "ramo") ?? "ramo"},
{"grupodeporte", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Grupodeporte, "grupodeporte") ?? "grupodeporte"},
{"email", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@Email, "email") ?? "email"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"regionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, _EntityKeyConstants._OrganizationEntityKeys._SupplierAttributeKeys.@RegionId, "regionid") ?? "regionid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, "suppl_ok7ot05vqromvlyop842lwg2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSupplierEntity

}

