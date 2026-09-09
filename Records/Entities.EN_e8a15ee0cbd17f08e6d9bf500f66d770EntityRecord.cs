using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENLogsAccountingSubjectEntity {
private static readonly ActivitySource activitySource = new(typeof(ENLogsAccountingSubjectEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccountingSubject, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingSubjectAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccountingSubject, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingSubjectAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccountingSubject, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingSubjectAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccountingSubject, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingSubjectAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccountingSubject, "logsa_u8aqr95gpfersxw41lfjfls4") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccountingSubject, "logsa_u8aqr95gpfersxw41lfjfls4") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccountingSubject, "logsa_u8aqr95gpfersxw41lfjfls4"));
}
}
} // ENLogsAccountingSubjectEntity
partial class ENLogsAccountingSubjectEntity : InMemoryStaticEntityRuntime<EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord, int> {
    

    private static ENLogsAccountingSubjectEntity instance = new();
    public static ENLogsAccountingSubjectEntity GetInstance() => instance;

    public static EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("kIHkICg1hEmLRBFb0mHx0g"), 13 },
{ ObjectKey.Parse("aLSmUDKuY0yTX3RQe5p3KQ"), 7 },
{ ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"), 2 },
{ ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"), 1 },
{ ObjectKey.Parse("q6_YoL3bg0GiY7Qo3Po32Q"), 8 },
{ ObjectKey.Parse("V2dQp85GNEa+KvoKF26LPw"), 12 },
{ ObjectKey.Parse("D2owrMPiwEiolOK12zfaJg"), 9 },
{ ObjectKey.Parse("p5v2rxHHU0us2h+De0gQag"), 10 },
{ ObjectKey.Parse("UOnmtrX+_EqAdgnL3cVagQ"), 11 },
{ ObjectKey.Parse("QFMEycHUcEK7AmrqKizZBw"), 4 },
{ ObjectKey.Parse("DfEszJhTpUmVCxUNPRuFWg"), 6 },
{ ObjectKey.Parse("0s8s1whzKkOypjdeQvl1RQ"), 5 },
{ ObjectKey.Parse("KTnl+i02eUSozHPzTg81rA"), 3 },

    };

    protected override Dictionary<int, EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord> RecordIdToRecordMap { get; } = new() {
        {13, new() {
ssId = 13,
ssLabel = "Offset",
ssOrder = 13,
ssIs_Active = true,
}},
{7, new() {
ssId = 7,
ssLabel = "Order Request",
ssOrder = 7,
ssIs_Active = true,
}},
{2, new() {
ssId = 2,
ssLabel = "Retentions",
ssOrder = 2,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "XMLValidations",
ssOrder = 1,
ssIs_Active = true,
}},
{8, new() {
ssId = 8,
ssLabel = "Conta Faturas",
ssOrder = 8,
ssIs_Active = true,
}},
{12, new() {
ssId = 12,
ssLabel = "ErrorEntry06May",
ssOrder = 12,
ssIs_Active = true,
}},
{9, new() {
ssId = 9,
ssLabel = "APINotify",
ssOrder = 9,
ssIs_Active = true,
}},
{10, new() {
ssId = 10,
ssLabel = "APIUpdate",
ssOrder = 10,
ssIs_Active = true,
}},
{11, new() {
ssId = 11,
ssLabel = "Amount Requisitions",
ssOrder = 11,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "PAC",
ssOrder = 4,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "TipoCambio",
ssOrder = 6,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Entries",
ssOrder = 5,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Accounting",
ssOrder = 3,
ssIs_Active = true,
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{13, new() {
ssId = 13,
ssLabel = "Desfase",
ssOrder = 13,
ssIs_Active = true,
}},
{7, new() {
ssId = 7,
ssLabel = "Solicitud de Pedido",
ssOrder = 7,
ssIs_Active = true,
}},
{2, new() {
ssId = 2,
ssLabel = "Retenciones",
ssOrder = 2,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Validaciones XML",
ssOrder = 1,
ssIs_Active = true,
}},
{8, new() {
ssId = 8,
ssLabel = "Conta Faturas",
ssOrder = 8,
ssIs_Active = true,
}},
{12, new() {
ssId = 12,
ssLabel = "ErrorEntry06May",
ssOrder = 12,
ssIs_Active = true,
}},
{9, new() {
ssId = 9,
ssLabel = "APINotify",
ssOrder = 9,
ssIs_Active = true,
}},
{10, new() {
ssId = 10,
ssLabel = "APIUpdate",
ssOrder = 10,
ssIs_Active = true,
}},
{11, new() {
ssId = 11,
ssLabel = "Importe Requisiciones",
ssOrder = 11,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "PAC",
ssOrder = 4,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "TipoCambio",
ssOrder = 6,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Entradas",
ssOrder = 5,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Contabilidad",
ssOrder = 3,
ssIs_Active = true,
}},
}},
{"en-US", new() {
{13, new() {
ssId = 13,
ssLabel = "Offset",
ssOrder = 13,
ssIs_Active = true,
}},
{7, new() {
ssId = 7,
ssLabel = "Order Request",
ssOrder = 7,
ssIs_Active = true,
}},
{2, new() {
ssId = 2,
ssLabel = "Retentions",
ssOrder = 2,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "XMLValidations",
ssOrder = 1,
ssIs_Active = true,
}},
{8, new() {
ssId = 8,
ssLabel = "Conta Faturas",
ssOrder = 8,
ssIs_Active = true,
}},
{12, new() {
ssId = 12,
ssLabel = "ErrorEntry06May",
ssOrder = 12,
ssIs_Active = true,
}},
{9, new() {
ssId = 9,
ssLabel = "APINotify",
ssOrder = 9,
ssIs_Active = true,
}},
{10, new() {
ssId = 10,
ssLabel = "APIUpdate",
ssOrder = 10,
ssIs_Active = true,
}},
{11, new() {
ssId = 11,
ssLabel = "Amount Requisitions",
ssOrder = 11,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "PAC",
ssOrder = 4,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "TipoCambio",
ssOrder = 6,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Entries",
ssOrder = 5,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Accounting",
ssOrder = 3,
ssIs_Active = true,
}},
}},

    };
}
}

