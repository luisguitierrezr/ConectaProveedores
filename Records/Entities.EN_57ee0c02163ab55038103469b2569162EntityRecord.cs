using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENSupplierDetailEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSupplierDetailEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Id, "id") ?? "id"},
{"supplierid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@SupplierId, "supplierid") ?? "supplierid"},
{"sociedadeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@SociedadeId, "sociedadeid") ?? "sociedadeid"},
{"bloqueocontabilidad", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Bloqueocontabilidad, "bloqueocontabilidad") ?? "bloqueocontabilidad"},
{"bloqueopedido", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Bloqueopedido, "bloqueopedido") ?? "bloqueopedido"},
{"pais2", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Pais2, "pais2") ?? "pais2"},
{"clavebanco", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Clavebanco, "clavebanco") ?? "clavebanco"},
{"cuentabancaria", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Cuentabancaria, "cuentabancaria") ?? "cuentabancaria"},
{"titular", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Titular, "titular") ?? "titular"},
{"tpbco", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@TpBco, "tpbco") ?? "tpbco"},
{"referencia", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Referencia, "referencia") ?? "referencia"},
{"autoriz_extraccion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Autoriz_Extraccion, "autoriz_extraccion") ?? "autoriz_extraccion"},
{"nombredelainstitucionfinanci", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Nombredelainstitucionfinanci, "nombredelainstitucionfinanci") ?? "nombredelainstitucionfinanci"},
{"cuentaasociada", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Cuentaasociada, "cuentaasociada") ?? "cuentaasociada"},
{"claveclasific_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Claveclasific_, "claveclasific_") ?? "claveclasific_"},
{"grupodetesoreria", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@GrupodeTesoreria, "grupodetesoreria") ?? "grupodetesoreria"},
{"n_cta_anterior", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@N_cta_anterior, "n_cta_anterior") ?? "n_cta_anterior"},
{"cond_pago", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Cond_pago, "cond_pago") ?? "cond_pago"},
{"viasdepago", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Viasdepago, "viasdepago") ?? "viasdepago"},
{"bloqueopago", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Bloqueopago, "bloqueopago") ?? "bloqueopago"},
{"paisderetencion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Paisderetencion, "paisderetencion") ?? "paisderetencion"},
{"tp_retenc_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Tp_retenc_, "tp_retenc_") ?? "tp_retenc_"},
{"inret", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@InRet, "inret") ?? "inret"},
{"sujeto", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Sujeto, "sujeto") ?? "sujeto"},
{"exen__", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Exen__, "exen__") ?? "exen__"},
{"descripcion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, _EntityKeyConstants._OrganizationEntityKeys._SupplierDetailAttributeKeys.@Descripcion, "descripcion") ?? "descripcion"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, "suppl_ok7ot05vqrojq50ug2o0ro04"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSupplierDetailEntity

}

