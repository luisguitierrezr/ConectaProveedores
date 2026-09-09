using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENEntraDomainEntity {
private static readonly ActivitySource activitySource = new(typeof(ENEntraDomainEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", "id"},
{"label", "label"},
{"order", "order"},
{"is_active", "is_active"},
{"sufix", "sufix"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "");
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("e640e17c-9497-4b8d-927c-ea245aad4d59");
} // ENEntraDomainEntity
/// <summary>
/// Static Entity <code>ENEntraDomainEntity</code> gets the values for this static entity records in
///  runtime <code>EntraDomain</code>
/// </summary>
    partial class ENEntraDomainEntity {
        

        public static EN_635849dd879ffe94511aeebfcff26dbcEntityRecord GetRecordById(int id) {
return (EN_635849dd879ffe94511aeebfcff26dbcEntityRecord) RsseSpaceIS_EntraIDGraphConnector.ENEntraDomainEntity.GetRecordById<EN_635849dd879ffe94511aeebfcff26dbcEntityRecord>(id);
}


        public static EN_635849dd879ffe94511aeebfcff26dbcEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_635849dd879ffe94511aeebfcff26dbcEntityRecord) RsseSpaceIS_EntraIDGraphConnector.ENEntraDomainEntity.GetRecordByKey<EN_635849dd879ffe94511aeebfcff26dbcEntityRecord>(key);
}

    } // ENEntraDomainEntity;

}

