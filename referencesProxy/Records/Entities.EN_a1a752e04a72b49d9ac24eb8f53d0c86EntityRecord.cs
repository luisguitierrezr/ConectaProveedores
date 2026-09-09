using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENCostCenterSAPEntity {
private static readonly ActivitySource activitySource = new(typeof(ENCostCenterSAPEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Id, "id") ?? "id"},
{"regionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@RegionId, "regionid") ?? "regionid"},
{"companyid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@CompanyId, "companyid") ?? "companyid"},
{"soc_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Soc_, "soc_") ?? "soc_"},
{"div_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Div_, "div_") ?? "div_"},
{"area", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Area, "area") ?? "area"},
{"ce_coste", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Ce_coste, "ce_coste") ?? "ce_coste"},
{"cebe", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@CeBe, "cebe") ?? "cebe"},
{"denominacion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Denominacion, "denominacion") ?? "denominacion"},
{"descripcion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Descripcion, "descripcion") ?? "descripcion"},
{"responsable", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Responsable, "responsable") ?? "responsable"},
{"ceco", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@CeCo, "ceco") ?? "ceco"},
{"costesprim_reales_ind_debloq", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Costesprim_reales_Ind_debloq, "costesprim_reales_ind_debloq") ?? "costesprim_reales_ind_debloq"},
{"costessecund_reales_ind_debl", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Costessecund_reales_Ind_debl, "costessecund_reales_ind_debl") ?? "costessecund_reales_ind_debl"},
{"ingresosreales_ind_debloqueo", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Ingresosreales_Ind_debloqueo, "ingresosreales_ind_debloqueo") ?? "ingresosreales_ind_debloqueo"},
{"actualiz_comprom__ind_debloq", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Actualiz_comprom__Ind_debloq, "actualiz_comprom__ind_debloq") ?? "actualiz_comprom__ind_debloq"},
{"costesprimariosplan_ind_debl", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Costesprimariosplan_Ind_debl, "costesprimariosplan_ind_debl") ?? "costesprimariosplan_ind_debl"},
{"costessecund_plan_ind_debloq", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Costessecund_plan_Ind_debloq, "costessecund_plan_ind_debloq") ?? "costessecund_plan_ind_debloq"},
{"ingresosplan_ind_debloqueo_", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Ingresosplan_Ind_debloqueo_, "ingresosplan_ind_debloqueo_") ?? "ingresosplan_ind_debloqueo_"},
{"autor", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@Autor, "autor") ?? "autor"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, _EntityKeyConstants._OrganizationEntityKeys._CostCenterSAPAttributeKeys.@IsActive, "isactive") ?? "isactive"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, "costc_ok7ot05vqror6mk6om5dtb20"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENCostCenterSAPEntity

}

