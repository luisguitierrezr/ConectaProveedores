using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENRequisitionStatusEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRequisitionStatusEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusAttributeKeys.@Label, "label") ?? "label"},
{"class", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusAttributeKeys.@Class, "class") ?? "class"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusAttributeKeys.@Is_Active, "is_active") ?? "is_active"},
{"labeles", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusAttributeKeys.@LabelES, "labeles") ?? "labeles"}
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
switch (locale == null ? string.Empty : locale.ToLowerInvariant()) {
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatus, "requi_u8aqr95gpfe1u8i8xsabwsw7") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatus, "requi_u8aqr95gpfe1u8i8xsabwsw7") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatus, "requi_u8aqr95gpfe1u8i8xsabwsw7"));
}
}
} // ENRequisitionStatusEntity
partial class ENRequisitionStatusEntity : InMemoryStaticEntityRuntime<EN_0554a1252840ba4a5c4e6af5899608adEntityRecord, int> {
    

    private static ENRequisitionStatusEntity instance = new();
    public static ENRequisitionStatusEntity GetInstance() => instance;

    public static EN_0554a1252840ba4a5c4e6af5899608adEntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_0554a1252840ba4a5c4e6af5899608adEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"), 1 },
{ ObjectKey.Parse("1_RsQxcxokySProxyWT5mw"), 4 },
{ ObjectKey.Parse("jCOIXdyYhUKLqNTv4OsxNA"), 10 },
{ ObjectKey.Parse("Mh9oh8XO1EONnOOs1HKCZA"), 3 },
{ ObjectKey.Parse("GxzelG_MJUCC7GqpNLMaDw"), 2 },
{ ObjectKey.Parse("5K2SyCJmtU+vkuFEbRmA_g"), 7 },
{ ObjectKey.Parse("wpdx_Qw3wEmfndGLo0VZ+Q"), 6 },

    };

    protected override Dictionary<int, EN_0554a1252840ba4a5c4e6af5899608adEntityRecord> RecordIdToRecordMap { get; } = new() {
        {1, new() {
ssId = 1,
ssLabel = "Data Capture",
ssClass = "import",
ssOrder = 1,
ssIs_Active = true,
ssLabelES = "Captura de datos",
}},
{4, new() {
ssId = 4,
ssLabel = "Canceled",
ssClass = "canceled",
ssOrder = 4,
ssIs_Active = true,
ssLabelES = "Cancelada",
}},
{10, new() {
ssId = 10,
ssLabel = "Accounting",
ssClass = "modify",
ssOrder = 7,
ssIs_Active = false,
ssLabelES = "En contabilización",
}},
{3, new() {
ssId = 3,
ssLabel = "Approved",
ssClass = "approved",
ssOrder = 3,
ssIs_Active = true,
ssLabelES = "Aprobada",
}},
{2, new() {
ssId = 2,
ssLabel = "Approval Process",
ssClass = "inapproval",
ssOrder = 2,
ssIs_Active = true,
ssLabelES = "En Aprobación",
}},
{7, new() {
ssId = 7,
ssLabel = "Modify",
ssClass = "modify",
ssOrder = 6,
ssIs_Active = true,
ssLabelES = "Modificación",
}},
{6, new() {
ssId = 6,
ssLabel = "Expired",
ssClass = "rejected",
ssOrder = 5,
ssIs_Active = true,
ssLabelES = "Caducada",
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_0554a1252840ba4a5c4e6af5899608adEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{1, new() {
ssId = 1,
ssLabel = "Captura de datos",
ssClass = "import",
ssOrder = 1,
ssIs_Active = true,
ssLabelES = "Captura de datos",
}},
{4, new() {
ssId = 4,
ssLabel = "Cancelada",
ssClass = "canceled",
ssOrder = 4,
ssIs_Active = true,
ssLabelES = "Cancelada",
}},
{10, new() {
ssId = 10,
ssLabel = "En contabilización",
ssClass = "modify",
ssOrder = 7,
ssIs_Active = false,
ssLabelES = "En contabilización",
}},
{3, new() {
ssId = 3,
ssLabel = "Aprobada",
ssClass = "approved",
ssOrder = 3,
ssIs_Active = true,
ssLabelES = "Aprobada",
}},
{2, new() {
ssId = 2,
ssLabel = "Flujo de Aprobación",
ssClass = "inapproval",
ssOrder = 2,
ssIs_Active = true,
ssLabelES = "En Aprobación",
}},
{7, new() {
ssId = 7,
ssLabel = "Modificación",
ssClass = "modify",
ssOrder = 6,
ssIs_Active = true,
ssLabelES = "Modificación",
}},
{6, new() {
ssId = 6,
ssLabel = "Caducada",
ssClass = "rejected",
ssOrder = 5,
ssIs_Active = true,
ssLabelES = "Caducada",
}},
}},
{"en-US", new() {
{1, new() {
ssId = 1,
ssLabel = "Data Capture",
ssClass = "import",
ssOrder = 1,
ssIs_Active = true,
ssLabelES = "Captura de datos",
}},
{4, new() {
ssId = 4,
ssLabel = "Canceled",
ssClass = "canceled",
ssOrder = 4,
ssIs_Active = true,
ssLabelES = "Cancelada",
}},
{10, new() {
ssId = 10,
ssLabel = "Accounting",
ssClass = "modify",
ssOrder = 7,
ssIs_Active = false,
ssLabelES = "En contabilización",
}},
{3, new() {
ssId = 3,
ssLabel = "Approved",
ssClass = "approved",
ssOrder = 3,
ssIs_Active = true,
ssLabelES = "Aprobada",
}},
{2, new() {
ssId = 2,
ssLabel = "Approval Process",
ssClass = "inapproval",
ssOrder = 2,
ssIs_Active = true,
ssLabelES = "En Aprobación",
}},
{7, new() {
ssId = 7,
ssLabel = "Modify",
ssClass = "modify",
ssOrder = 6,
ssIs_Active = true,
ssLabelES = "Modificación",
}},
{6, new() {
ssId = 6,
ssLabel = "Expired",
ssClass = "rejected",
ssOrder = 5,
ssIs_Active = true,
ssLabelES = "Caducada",
}},
}},

    };
}
}

