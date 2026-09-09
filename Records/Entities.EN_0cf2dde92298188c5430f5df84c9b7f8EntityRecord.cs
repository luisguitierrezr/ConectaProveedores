using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENContractFileTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENContractFileTypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractFileType, _EntityKeyConstants._ConectaProveedoresEntityKeys._ContractFileTypeAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractFileType, _EntityKeyConstants._ConectaProveedoresEntityKeys._ContractFileTypeAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractFileType, _EntityKeyConstants._ConectaProveedoresEntityKeys._ContractFileTypeAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractFileType, _EntityKeyConstants._ConectaProveedoresEntityKeys._ContractFileTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractFileType, "contr_u8aqr95gpfe1rmrp3rec05e6") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractFileType, "contr_u8aqr95gpfe1rmrp3rec05e6") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractFileType, "contr_u8aqr95gpfe1rmrp3rec05e6"));
}
}
} // ENContractFileTypeEntity
partial class ENContractFileTypeEntity : InMemoryStaticEntityRuntime<EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord, int> {
    

    private static ENContractFileTypeEntity instance = new();
    public static ENContractFileTypeEntity GetInstance() => instance;

    public static EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("LL0EEo6QjEia4MHtbq4Wcg"), 2 },
{ ObjectKey.Parse("KQCdGM5P7k+IR4O+zSRfKA"), 7 },
{ ObjectKey.Parse("DmZNPQ718EWxmSQhfgzeiw"), 6 },
{ ObjectKey.Parse("r4jSUQNmxUqnB9v839cdug"), 3 },
{ ObjectKey.Parse("O7ktjb0qHUO1JVHd3pyUOA"), 4 },
{ ObjectKey.Parse("G8yzk1VC6kuuzlQ40OJi8Q"), 1 },
{ ObjectKey.Parse("LV+AsPZoqky6GANkYowNLQ"), 8 },
{ ObjectKey.Parse("V4MNsdNOWkel1Y9wcSEz8Q"), 5 },
{ ObjectKey.Parse("XZ874xvcQ0WEe9IcoUgjqw"), 9 },

    };

    protected override Dictionary<int, EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord> RecordIdToRecordMap { get; } = new() {
        {2, new() {
ssId = 2,
ssLabel = "Deposit",
ssOrder = 2,
ssIs_Active = true,
}},
{7, new() {
ssId = 7,
ssLabel = "Contract Pending Justification",
ssOrder = 7,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "Proof Of Foreign Residence",
ssOrder = 6,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Insurance",
ssOrder = 3,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "Advance Payment",
ssOrder = 4,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Contract",
ssOrder = 1,
ssIs_Active = true,
}},
{8, new() {
ssId = 8,
ssLabel = "REPSE",
ssOrder = 8,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Finance Authorization",
ssOrder = 5,
ssIs_Active = true,
}},
{9, new() {
ssId = 9,
ssLabel = "Exchange Rate Evidence",
ssOrder = 9,
ssIs_Active = true,
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{2, new() {
ssId = 2,
ssLabel = "Fianza",
ssOrder = 2,
ssIs_Active = true,
}},
{7, new() {
ssId = 7,
ssLabel = "Contrato Pendiente de Justificación",
ssOrder = 7,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "Constancia de Residencia Extranjera",
ssOrder = 6,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Seguro",
ssOrder = 3,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "Anticipo",
ssOrder = 4,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Contrato",
ssOrder = 1,
ssIs_Active = true,
}},
{8, new() {
ssId = 8,
ssLabel = "REPSE",
ssOrder = 8,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Autorización de Financiamiento",
ssOrder = 5,
ssIs_Active = true,
}},
{9, new() {
ssId = 9,
ssLabel = "Evidencia del Tipo de Cambio",
ssOrder = 9,
ssIs_Active = true,
}},
}},
{"en-US", new() {
{2, new() {
ssId = 2,
ssLabel = "Deposit",
ssOrder = 2,
ssIs_Active = true,
}},
{7, new() {
ssId = 7,
ssLabel = "Contract Pending Justification",
ssOrder = 7,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "Proof Of Foreign Residence",
ssOrder = 6,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Insurance",
ssOrder = 3,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "Advance Payment",
ssOrder = 4,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Contract",
ssOrder = 1,
ssIs_Active = true,
}},
{8, new() {
ssId = 8,
ssLabel = "REPSE",
ssOrder = 8,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Finance Authorization",
ssOrder = 5,
ssIs_Active = true,
}},
{9, new() {
ssId = 9,
ssLabel = "Exchange Rate Evidence",
ssOrder = 9,
ssIs_Active = true,
}},
}},

    };
}
}

