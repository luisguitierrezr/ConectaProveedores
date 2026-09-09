using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENFolioSAPDataEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFolioSAPDataEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Id, "id") ?? "id"},
{"folioid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@FolioId, "folioid") ?? "folioid"},
{"service", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Service, "service") ?? "service"},
{"po_documento_material_em", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_EM, "po_documento_material_em") ?? "po_documento_material_em"},
{"po_documento_material_sm", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_SM, "po_documento_material_sm") ?? "po_documento_material_sm"},
{"po_documento_material_221", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_221, "po_documento_material_221") ?? "po_documento_material_221"},
{"po_documento_material_415", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_415, "po_documento_material_415") ?? "po_documento_material_415"},
{"po_ejercicio_em", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_EM, "po_ejercicio_em") ?? "po_ejercicio_em"},
{"po_ejercicio_sm", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_SM, "po_ejercicio_sm") ?? "po_ejercicio_sm"},
{"po_ejercicio_221", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_221, "po_ejercicio_221") ?? "po_ejercicio_221"},
{"po_ejercicio_415", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_415, "po_ejercicio_415") ?? "po_ejercicio_415"},
{"po_folio_agrupados", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_FOLIO_AGRUPADOS, "po_folio_agrupados") ?? "po_folio_agrupados"},
{"po_resultado", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, "folio_u8aqr95gpfew7coekku1u_c3"));
}
} // ENFolioSAPDataEntity

}

