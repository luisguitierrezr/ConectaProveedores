// Proxy for reference eSpace with name TelcelStorage and key FMXUpVYs7UWwZQMrlEipdw
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RsseSpaceTelcelStorage
/// </summary>
public partial class RsseSpaceTelcelStorage {
private static readonly ActivitySource source = new("ssConectaProveedores.RsseSpaceTelcelStorage");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
       }
   }
public static async Task DeleteCacheStorageFromList(IRequestContext requestContext,BasicTypeList<long> inParamStorageList,CancellationToken cancellationToken) {
var _proxyinParamStorageList = new BasicTypeList<long>();
_proxyinParamStorageList.FillFromOther(inParamStorageList);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
await TelcelStorageServiceAPIClients.DeleteCacheStorageFromList(requestContext,_proxyinParamStorageList,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public static async Task<(byte[],string,string,bool)> ServiceStorageGetFileByParts(IRequestContext requestContext,long inParami_StorageId,int inParami_ChunkNumber,int inParami_TotalChunks,string inParami_Guid,CancellationToken cancellationToken) {
byte[] outParamo_File = default;
string outParamo_filename = default;
string outParamo_fileInText = default;
bool outParamIsBinary = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
(outParamo_File,outParamo_filename,outParamo_fileInText,outParamIsBinary) = await TelcelStorageServiceAPIClients.ServiceStorageGetFileByParts(requestContext,inParami_StorageId,inParami_ChunkNumber,inParami_TotalChunks,inParami_Guid,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return (outParamo_File,outParamo_filename,outParamo_fileInText,outParamIsBinary);
}


public static async Task<long> ServiceStorageCreateOrUpdateBigFile(IRequestContext requestContext,IRecord inParamSource,bool inParamDirectSave,long inParamFileId,CancellationToken cancellationToken) {
long outParamId = default;
var _proxyinParamSource = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
_proxyinParamSource.FillFromOther(inParamSource);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
outParamId = await TelcelStorageServiceAPIClients.ServiceStorageCreateOrUpdateBigFile(requestContext,_proxyinParamSource,inParamDirectSave,inParamFileId,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamId;
}


public static async Task<long> ServiceStorageCreateOrUpdate(IRequestContext requestContext,IRecord inParamSource,bool inParamDirectSave,CancellationToken cancellationToken) {
long outParamId = default;
var _proxyinParamSource = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
_proxyinParamSource.FillFromOther(inParamSource);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
outParamId = await TelcelStorageServiceAPIClients.ServiceStorageCreateOrUpdate(requestContext,_proxyinParamSource,inParamDirectSave,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamId;
}


public static async Task ServiceStorageDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
await TelcelStorageServiceAPIClients.ServiceStorageDelete(requestContext,inParamId,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public static async Task<long> ServiceStorageCreate(IRequestContext requestContext,IRecord inParamSource,bool inParamDirectSave,CancellationToken cancellationToken) {
long outParamId = default;
var _proxyinParamSource = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
_proxyinParamSource.FillFromOther(inParamSource);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
outParamId = await TelcelStorageServiceAPIClients.ServiceStorageCreate(requestContext,_proxyinParamSource,inParamDirectSave,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamId;
}


public static async Task<(byte[],string)> ServiceStorageGetFile(IRequestContext requestContext,long inParami_StorageId,CancellationToken cancellationToken) {
byte[] outParamo_File = default;
string outParamo_filename = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
(outParamo_File,outParamo_filename) = await TelcelStorageServiceAPIClients.ServiceStorageGetFile(requestContext,inParami_StorageId,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return (outParamo_File,outParamo_filename);
}


public static async Task<byte[]> ServiceGetDocumentsByListId(IRequestContext requestContext,BasicTypeList<long> inParamIdsList,CancellationToken cancellationToken) {
byte[] outParamBinaryZip = default;
var _proxyinParamIdsList = new BasicTypeList<long>();
_proxyinParamIdsList.FillFromOther(inParamIdsList);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
outParamBinaryZip = await TelcelStorageServiceAPIClients.ServiceGetDocumentsByListId(requestContext,_proxyinParamIdsList,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamBinaryZip;
}


public static async Task ServiceResendFailedFile(IRequestContext requestContext,long inParamStorageId,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
await TelcelStorageServiceAPIClients.ServiceResendFailedFile(requestContext,inParamStorageId,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public sealed partial class ENDeletedStorageEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@DeletedStorage, "delet_pqz6uvkp8y5e11p7jp7_u2x6"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
} // ENDeletedStorageEntity
public sealed partial class ENInternalConceptEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@InternalConcept, "inter_pqz6uvkp8y5jyquv2vka1hu2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
} // ENInternalConceptEntity
public sealed partial class ENStorageEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@Storage, "stora_pqz6uvkp8y5cqwh7fga051i4"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
} // ENStorageEntity

public class DefaultValues {
}
}
}
