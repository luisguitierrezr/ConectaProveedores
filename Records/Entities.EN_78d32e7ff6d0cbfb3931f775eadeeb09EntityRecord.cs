using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENImportStatusEntity {
private static readonly ActivitySource activitySource = new(typeof(ENImportStatusEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ImportStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._ImportStatusAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ImportStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._ImportStatusAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ImportStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._ImportStatusAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ImportStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._ImportStatusAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ImportStatus, "impor_u8aqr95gpfe_asspch_723c7") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ImportStatus, "impor_u8aqr95gpfe_asspch_723c7") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ImportStatus, "impor_u8aqr95gpfe_asspch_723c7"));
}
}
} // ENImportStatusEntity
partial class ENImportStatusEntity : InMemoryStaticEntityRuntime<EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord, int> {
    

    private static ENImportStatusEntity instance = new();
    public static ENImportStatusEntity GetInstance() => instance;

    public static EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("oao0OfBC6EeEu3RhczS__A"), 2 },
{ ObjectKey.Parse("RHEbPl76h0mij_c4OsqnJA"), 3 },
{ ObjectKey.Parse("071tbgS1KEa8CNmBFtu49g"), 6 },
{ ObjectKey.Parse("RuCeyUnezECw7Jj4dcCBmA"), 5 },
{ ObjectKey.Parse("a_Cgy05KMEa+_erSCK6rCg"), 1 },
{ ObjectKey.Parse("F3Dz4ZMIg06wBPLdoUfwiw"), 4 },

    };

    protected override Dictionary<int, EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord> RecordIdToRecordMap { get; } = new() {
        {2, new() {
ssId = 2,
ssLabel = "Import",
ssOrder = 2,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Distribute",
ssOrder = 3,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "SendEmail",
ssOrder = 6,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Done",
ssOrder = 5,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "New",
ssOrder = 1,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "Error",
ssOrder = 4,
ssIs_Active = true,
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{2, new() {
ssId = 2,
ssLabel = "Importar",
ssOrder = 2,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Distribuir",
ssOrder = 3,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "Enviar Correo Electrónico",
ssOrder = 6,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Hecho",
ssOrder = 5,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Nuevo",
ssOrder = 1,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "Error",
ssOrder = 4,
ssIs_Active = true,
}},
}},
{"en-US", new() {
{2, new() {
ssId = 2,
ssLabel = "Import",
ssOrder = 2,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Distribute",
ssOrder = 3,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "SendEmail",
ssOrder = 6,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Done",
ssOrder = 5,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "New",
ssOrder = 1,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "Error",
ssOrder = 4,
ssIs_Active = true,
}},
}},

    };
}
}

