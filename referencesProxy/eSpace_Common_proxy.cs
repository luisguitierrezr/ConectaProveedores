// Proxy for reference eSpace with name Common and key VwUFjS+w6kiypMwmo16VTQ
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RsseSpaceCommon
/// </summary>
public partial class RsseSpaceCommon {
private static readonly ActivitySource source = new("ssConectaProveedores.RsseSpaceCommon");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("4067e3bf-602b-47d4-ac39-3fb42a4cfde1");
       }
   }
public static async Task<int> ServiceGetUploadContractDateLimit(IRequestContext requestContext,CancellationToken cancellationToken) {
int outParamo_Value = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("4067e3bf-602b-47d4-ac39-3fb42a4cfde1");
outParamo_Value = await CommonServiceAPIClients.ServiceGetUploadContractDateLimit(requestContext,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamo_Value;
}


public sealed partial class ENOperatorEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Operator, "opera_woucc4dity1ad003chrs7bd1"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("4067e3bf-602b-47d4-ac39-3fb42a4cfde1");
} // ENOperatorEntity
public sealed partial class ENCurrencyEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, "curre_woucc4dity19rkmuz8h0gv15"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("4067e3bf-602b-47d4-ac39-3fb42a4cfde1");
} // ENCurrencyEntity
public sealed partial class ENDayOfWeekEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@DayOfWeek, "dayof_woucc4dity1bvqaltlkiu3b5"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("4067e3bf-602b-47d4-ac39-3fb42a4cfde1");
} // ENDayOfWeekEntity
public sealed partial class ENBankEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Bank, "bank_woucc4dity14wg1xnrs18960"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("4067e3bf-602b-47d4-ac39-3fb42a4cfde1");
} // ENBankEntity

public class DefaultValues {
}
}
}
