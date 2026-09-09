using System.Collections.ObjectModel;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions;

using ssConectaProveedores.ReferencesProxy;

namespace ssConectaProveedores {
    public partial class RsseSpaceAuditEngine {
        public class AuditEngineServiceAPIClients : AbstractServiceApiClient {
            private static readonly AuditEngineServiceAPIClients Instance = new();
            private AuditEngineServiceAPIClients() : base(
                ObjectKey.Parse("8aa2689a-6d7f-45a1-9c5a-5206a69f8877"),
                "AuditEngine",
                "ssConectaProveedores.AuditEngineServiceAPIClients",
                ReadOnlyDictionary<string, Func<string, Exception>>.Empty
            ) { }

            public class S4PIServiceGetAuditsByOrigin4ListInput {
[JsonProperty("OriginId")]
public int? inParamOriginId;
[JsonProperty("PeriodInit")]
public DateTime? inParamPeriodInit;
[JsonProperty("PeriodEnd")]
public DateTime? inParamPeriodEnd;
[JsonProperty("ShowErrors")]
public bool? inParamShowErrors;
[JsonProperty("StartIndex")]
public int? inParamStartIndex;
[JsonProperty("MaxRecords")]
public int? inParamMaxRecords;
[JsonProperty("TableSort")]
public string inParamTableSort;
public S4PIServiceGetAuditsByOrigin4ListInput(int? inParamOriginId, DateTime? inParamPeriodInit, DateTime? inParamPeriodEnd, bool? inParamShowErrors, int? inParamStartIndex, int? inParamMaxRecords, string inParamTableSort) {
this.inParamOriginId = inParamOriginId;
this.inParamPeriodInit = inParamPeriodInit;
this.inParamPeriodEnd = inParamPeriodEnd;
this.inParamShowErrors = inParamShowErrors;
this.inParamStartIndex = inParamStartIndex;
this.inParamMaxRecords = inParamMaxRecords;
this.inParamTableSort = inParamTableSort;
}

}

public class S4PIServiceGetAuditsByOrigin4ListOutput {
[JsonProperty("AuditList")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure[] outParamAuditList;
[JsonProperty("TotalCount")]
public long outParamTotalCount;
public S4PIServiceGetAuditsByOrigin4ListOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure[] outParamAuditList, long outParamTotalCount) {
this.outParamAuditList = outParamAuditList;
this.outParamTotalCount = outParamTotalCount;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceGetAuditsByOrigin4List
/// </summary>
public static async Task<(RL_d271bd6e591b75c186c4ae8d222dee55,long)> ServiceGetAuditsByOrigin4List(IRequestContext requestContext,int? inParamOriginId,DateTime? inParamPeriodInit,DateTime? inParamPeriodEnd,bool? inParamShowErrors,int? inParamStartIndex,int? inParamMaxRecords,string inParamTableSort,CancellationToken cancellationToken) {
RL_d271bd6e591b75c186c4ae8d222dee55 outParamAuditList = default;
long outParamTotalCount = default;
outParamAuditList = new RL_d271bd6e591b75c186c4ae8d222dee55();

outParamTotalCount = 0L;

var serviceActionName = "ServiceGetAuditsByOrigin4List";
var serviceActionKey = "7c52c1ad-49b7-4f22-b8c0-d3f5dbe87dde";
var inputs = new S4PIServiceGetAuditsByOrigin4ListInput(inParamOriginId, inParamPeriodInit, inParamPeriodEnd, inParamShowErrors, inParamStartIndex, inParamMaxRecords, inParamTableSort);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceGetAuditsByOrigin4ListInput, S4PIServiceGetAuditsByOrigin4ListOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamAuditList = RL_d271bd6e591b75c186c4ae8d222dee55.ToList(outputs.outParamAuditList, (str) => ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure.ToStructure(str, ServiceConfiguration));
outParamTotalCount = outputs.outParamTotalCount;
await Task.Yield();

return (outParamAuditList,outParamTotalCount);
}
public class S4PIServiceAuditCreateInput {
[JsonProperty("Source")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure inParamSource;
[JsonProperty("IP")]
public string inParamIP;
public S4PIServiceAuditCreateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure inParamSource, string inParamIP) {
this.inParamSource = inParamSource;
this.inParamIP = inParamIP;
}

}

public class S4PIServiceAuditCreateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceAuditCreateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceAuditCreate
/// </summary>
public static async Task<long> ServiceAuditCreate(IRequestContext requestContext,ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure inParamSource,string inParamIP,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

var serviceActionName = "ServiceAuditCreate";
var serviceActionKey = "b97f0d00-0f50-4a59-8bd9-f82c2cd3c41e";
var inputs = new S4PIServiceAuditCreateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure.FromStructure(inParamSource, ServiceConfiguration), inParamIP);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceAuditCreateInput, S4PIServiceAuditCreateOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamId = outputs.outParamId;
await Task.Yield();

return outParamId;
}
public class S4PIServiceGetAuditsByIdentifier4ListInput {
[JsonProperty("OriginId")]
public int? inParamOriginId;
[JsonProperty("Identifier")]
public long? inParamIdentifier;
[JsonProperty("ShowErrors")]
public bool? inParamShowErrors;
[JsonProperty("StartIndex")]
public int? inParamStartIndex;
[JsonProperty("MaxRecords")]
public int? inParamMaxRecords;
[JsonProperty("TableSort")]
public string inParamTableSort;
public S4PIServiceGetAuditsByIdentifier4ListInput(int? inParamOriginId, long? inParamIdentifier, bool? inParamShowErrors, int? inParamStartIndex, int? inParamMaxRecords, string inParamTableSort) {
this.inParamOriginId = inParamOriginId;
this.inParamIdentifier = inParamIdentifier;
this.inParamShowErrors = inParamShowErrors;
this.inParamStartIndex = inParamStartIndex;
this.inParamMaxRecords = inParamMaxRecords;
this.inParamTableSort = inParamTableSort;
}

}

public class S4PIServiceGetAuditsByIdentifier4ListOutput {
[JsonProperty("AuditList")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure[] outParamAuditList;
[JsonProperty("TotalCount")]
public long outParamTotalCount;
public S4PIServiceGetAuditsByIdentifier4ListOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure[] outParamAuditList, long outParamTotalCount) {
this.outParamAuditList = outParamAuditList;
this.outParamTotalCount = outParamTotalCount;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceGetAuditsByIdentifier4List
/// </summary>
public static async Task<(RL_d271bd6e591b75c186c4ae8d222dee55,long)> ServiceGetAuditsByIdentifier4List(IRequestContext requestContext,int? inParamOriginId,long? inParamIdentifier,bool? inParamShowErrors,int? inParamStartIndex,int? inParamMaxRecords,string inParamTableSort,CancellationToken cancellationToken) {
RL_d271bd6e591b75c186c4ae8d222dee55 outParamAuditList = default;
long outParamTotalCount = default;
outParamAuditList = new RL_d271bd6e591b75c186c4ae8d222dee55();

outParamTotalCount = 0L;

var serviceActionName = "ServiceGetAuditsByIdentifier4List";
var serviceActionKey = "df9b961a-a379-4e04-86ab-aa83e94e4ed9";
var inputs = new S4PIServiceGetAuditsByIdentifier4ListInput(inParamOriginId, inParamIdentifier, inParamShowErrors, inParamStartIndex, inParamMaxRecords, inParamTableSort);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceGetAuditsByIdentifier4ListInput, S4PIServiceGetAuditsByIdentifier4ListOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamAuditList = RL_d271bd6e591b75c186c4ae8d222dee55.ToList(outputs.outParamAuditList, (str) => ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1786374c6f8a2661d92ccc7b7f0c7ec3Structure.ToStructure(str, ServiceConfiguration));
outParamTotalCount = outputs.outParamTotalCount;
await Task.Yield();

return (outParamAuditList,outParamTotalCount);
}

        }
    }
}
