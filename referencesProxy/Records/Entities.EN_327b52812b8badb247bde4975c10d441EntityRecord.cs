using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENCurrencyEntity {
private static readonly ActivitySource activitySource = new(typeof(ENCurrencyEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"code", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@Code, "code") ?? "code"},
{"name", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@Name, "name") ?? "name"},
{"symbol", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@Symbol, "symbol") ?? "symbol"},
{"minorunitdecimals", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@MinorUnitDecimals, "minorunitdecimals") ?? "minorunitdecimals"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@IsActive, "isactive") ?? "isactive"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, "curre_woucc4dity19rkmuz8h0gv15"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("4067e3bf-602b-47d4-ac39-3fb42a4cfde1");
} // ENCurrencyEntity
partial class ENCurrencyEntity : InMemoryStaticEntityRuntime<EN_327b52812b8badb247bde4975c10d441EntityRecord, string> {
    

    private static ENCurrencyEntity instance = new();
    public static ENCurrencyEntity GetInstance() => instance;

    public static EN_327b52812b8badb247bde4975c10d441EntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static async Task<EN_327b52812b8badb247bde4975c10d441EntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@Code, "code") ?? "code"}\" \"Currency.Code\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@Name, "name") ?? "name"}\" \"Currency.Name\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@Symbol, "symbol") ?? "symbol"}\" \"Currency.Symbol\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@MinorUnitDecimals, "minorunitdecimals") ?? "minorunitdecimals"}\" \"Currency.MinorUnitDecimals\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@IsActive, "isactive") ?? "isactive"}\" \"Currency.IsActive\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, "curre_woucc4dity19rkmuz8h0gv15"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@Code, "code") ?? "code"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetCurrency", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("Currency", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("6GSHD1nXHUGBWjG1in0vLg"), "GBP" },
{ ObjectKey.Parse("9sebLa8eUkaeP61AMxqcCA"), "EUR" },
{ ObjectKey.Parse("W0ixO6KStk60_nw4aebIBg"), "MXN" },
{ ObjectKey.Parse("s01uTfn09kuh6gtON_jAUQ"), "USD" },

    };

    protected override Dictionary<string, EN_327b52812b8badb247bde4975c10d441EntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<string, EN_327b52812b8badb247bde4975c10d441EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

