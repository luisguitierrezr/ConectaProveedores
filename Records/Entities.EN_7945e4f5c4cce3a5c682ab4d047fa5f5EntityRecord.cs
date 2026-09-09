using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENConceptEntity {
private static readonly ActivitySource activitySource = new(typeof(ENConceptEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@Concept, _EntityKeyConstants._SecurityAuthEntityKeys._ConceptAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@Concept, _EntityKeyConstants._SecurityAuthEntityKeys._ConceptAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@Concept, _EntityKeyConstants._SecurityAuthEntityKeys._ConceptAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@Concept, _EntityKeyConstants._SecurityAuthEntityKeys._ConceptAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@Concept, "conce_e_ge42by2w4fd0xqvresv_p7"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENConceptEntity
partial class ENConceptEntity : InMemoryStaticEntityRuntime<EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord, int> {
    

    private static ENConceptEntity instance = new();
    public static ENConceptEntity GetInstance() => instance;

    public static EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@Concept, _EntityKeyConstants._SecurityAuthEntityKeys._ConceptAttributeKeys.@Id, "id") ?? "id"}\" \"Concept.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@Concept, _EntityKeyConstants._SecurityAuthEntityKeys._ConceptAttributeKeys.@Label, "label") ?? "label"}\" \"Concept.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@Concept, _EntityKeyConstants._SecurityAuthEntityKeys._ConceptAttributeKeys.@Order, "order") ?? "order"}\" \"Concept.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@Concept, _EntityKeyConstants._SecurityAuthEntityKeys._ConceptAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"Concept.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@Concept, "conce_e_ge42by2w4fd0xqvresv_p7"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@Concept, _EntityKeyConstants._SecurityAuthEntityKeys._ConceptAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetConcept", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("Concept", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("3i10EhCdREKWaP14+F_Ucg"), 2 },
{ ObjectKey.Parse("eOXpSzPyOkW6zalr2c0TjQ"), 3 },
{ ObjectKey.Parse("Bso695HFC0W6NDuDp_N9fw"), 1 },

    };

    protected override Dictionary<int, EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

