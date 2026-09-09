using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOperatorEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOperatorEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"operator", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Operator, _EntityKeyConstants._CommonEntityKeys._OperatorAttributeKeys.@Operator, "operator") ?? "operator"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Operator, _EntityKeyConstants._CommonEntityKeys._OperatorAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Operator, _EntityKeyConstants._CommonEntityKeys._OperatorAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Operator, _EntityKeyConstants._CommonEntityKeys._OperatorAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Operator, "opera_woucc4dity1ad003chrs7bd1"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("4067e3bf-602b-47d4-ac39-3fb42a4cfde1");
} // ENOperatorEntity
partial class ENOperatorEntity : InMemoryStaticEntityRuntime<EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord, string> {
    

    private static ENOperatorEntity instance = new();
    public static ENOperatorEntity GetInstance() => instance;

    public static EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord GetRecordById(string id) {
return instance.GetRecord(id);
}

    public static async Task<EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Operator, _EntityKeyConstants._CommonEntityKeys._OperatorAttributeKeys.@Operator, "operator") ?? "operator"}\" \"Operator.Operator\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Operator, _EntityKeyConstants._CommonEntityKeys._OperatorAttributeKeys.@Label, "label") ?? "label"}\" \"Operator.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Operator, _EntityKeyConstants._CommonEntityKeys._OperatorAttributeKeys.@Order, "order") ?? "order"}\" \"Operator.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Operator, _EntityKeyConstants._CommonEntityKeys._OperatorAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"Operator.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Operator, "opera_woucc4dity1ad003chrs7bd1"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Operator, _EntityKeyConstants._CommonEntityKeys._OperatorAttributeKeys.@Operator, "operator") ?? "operator"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOperator", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("Operator", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, string> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("ctcxppZYnkSE9S56D2_rgg"), "<" },
{ ObjectKey.Parse("1tlr1kVq_Ea5XZxPBh6dUg"), "=" },
{ ObjectKey.Parse("iILK5M4VbkiMNjkJnr9u4A"), ">" },

    };

    protected override Dictionary<string, EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<string, EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

