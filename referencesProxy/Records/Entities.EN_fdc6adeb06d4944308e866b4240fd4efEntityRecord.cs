using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENAuditEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAuditEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@Id, "id") ?? "id"},
{"origin", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@Origin, "origin") ?? "origin"},
{"identifier", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@Identifier, "identifier") ?? "identifier"},
{"message", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@Message, "message") ?? "message"},
{"screen", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@Screen, "screen") ?? "screen"},
{"functionality", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@Functionality, "functionality") ?? "functionality"},
{"originaljson", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@OriginalJSON, "originaljson") ?? "originaljson"},
{"changejson", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@ChangeJSON, "changejson") ?? "changejson"},
{"occurrencedatetime", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@OccurrenceDateTime, "occurrencedatetime") ?? "occurrencedatetime"},
{"occurrenceuser", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@OccurrenceUser, "occurrenceuser") ?? "occurrenceuser"},
{"occurrencerolename", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@OccurrenceRoleName, "occurrencerolename") ?? "occurrencerolename"},
{"accessip", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@AccessIP, "accessip") ?? "accessip"},
{"iserror", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@IsError, "iserror") ?? "iserror"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, "audit_9j9tk7mvvctqktpzi7zi_og0"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("8aa2689a-6d7f-45a1-9c5a-5206a69f8877");
} // ENAuditEntity

}

