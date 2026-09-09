using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENProposalStatusEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProposalStatusEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusAttributeKeys.@Label, "label") ?? "label"},
{"class", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusAttributeKeys.@Class, "class") ?? "class"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatus, "reque_u8aqr95gpfeyx2hx568gl2g4") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatus, "reque_u8aqr95gpfeyx2hx568gl2g4") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatus, "reque_u8aqr95gpfeyx2hx568gl2g4"));
}
}
} // ENProposalStatusEntity
partial class ENProposalStatusEntity : InMemoryStaticEntityRuntime<EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord, int> {
    

    private static ENProposalStatusEntity instance = new();
    public static ENProposalStatusEntity GetInstance() => instance;

    public static EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"), 7 },
{ ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"), 6 },
{ ObjectKey.Parse("Ld4WSOtSaECFNAZ+2etxQA"), 1 },
{ ObjectKey.Parse("_E7iZT05VUKHIKtah6ZsmQ"), 9 },
{ ObjectKey.Parse("7agdijeyhUC3qdG5GpOcAg"), 3 },
{ ObjectKey.Parse("t1jXoCYmMkuMIabV4nC9iA"), 5 },
{ ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"), 10 },
{ ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"), 4 },

    };

    protected override Dictionary<int, EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord> RecordIdToRecordMap { get; } = new() {
        {7, new() {
ssId = 7,
ssLabel = "Error API",
ssClass = "errorAPI",
ssOrder = 8,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "Canceled",
ssClass = "canceled",
ssOrder = 4,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Approved",
ssClass = "approved",
ssOrder = 3,
ssIs_Active = true,
}},
{9, new() {
ssId = 9,
ssLabel = "Being Paid",
ssClass = "beingpaid",
ssOrder = 5,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "In Approval",
ssClass = "inapproval",
ssOrder = 1,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Paid",
ssClass = "paid",
ssOrder = 7,
ssIs_Active = true,
}},
{10, new() {
ssId = 10,
ssLabel = "Partially Paid",
ssClass = "payments",
ssOrder = 6,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "Rejected",
ssClass = "rejected",
ssOrder = 2,
ssIs_Active = true,
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{7, new() {
ssId = 7,
ssLabel = "Error API",
ssClass = "errorAPI",
ssOrder = 8,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "Cancelada",
ssClass = "canceled",
ssOrder = 4,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Aprobada",
ssClass = "approved",
ssOrder = 3,
ssIs_Active = true,
}},
{9, new() {
ssId = 9,
ssLabel = "En Proceso de Pago",
ssClass = "beingpaid",
ssOrder = 5,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "En aprobación",
ssClass = "inapproval",
ssOrder = 1,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Pagado",
ssClass = "paid",
ssOrder = 7,
ssIs_Active = true,
}},
{10, new() {
ssId = 10,
ssLabel = "Parcialmente Pagada",
ssClass = "payments",
ssOrder = 6,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "Rechazado",
ssClass = "rejected",
ssOrder = 2,
ssIs_Active = true,
}},
}},
{"en-US", new() {
{7, new() {
ssId = 7,
ssLabel = "Error API",
ssClass = "errorAPI",
ssOrder = 8,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "Canceled",
ssClass = "canceled",
ssOrder = 4,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Approved",
ssClass = "approved",
ssOrder = 3,
ssIs_Active = true,
}},
{9, new() {
ssId = 9,
ssLabel = "Being Paid",
ssClass = "beingpaid",
ssOrder = 5,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "In Approval",
ssClass = "inapproval",
ssOrder = 1,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Paid",
ssClass = "paid",
ssOrder = 7,
ssIs_Active = true,
}},
{10, new() {
ssId = 10,
ssLabel = "Partially Paid",
ssClass = "payments",
ssOrder = 6,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "Rechazado",
ssClass = "rejected",
ssOrder = 2,
ssIs_Active = true,
}},
}},

    };
}
}

