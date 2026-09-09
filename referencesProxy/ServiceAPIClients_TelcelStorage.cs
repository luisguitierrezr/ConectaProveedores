using System.Collections.ObjectModel;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions;

using ssConectaProveedores.ReferencesProxy;

namespace ssConectaProveedores {
    public partial class RsseSpaceTelcelStorage {
        public class TelcelStorageServiceAPIClients : AbstractServiceApiClient {
            private static readonly TelcelStorageServiceAPIClients Instance = new();
            private TelcelStorageServiceAPIClients() : base(
                ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3"),
                "TelcelStorage",
                "ssConectaProveedores.TelcelStorageServiceAPIClients",
                ReadOnlyDictionary<string, Func<string, Exception>>.Empty
            ) { }

            public class S4PIDeleteCacheStorageFromListInput {
[JsonProperty("StorageList")]
public long[] inParamStorageList;
public S4PIDeleteCacheStorageFromListInput(long[] inParamStorageList) {
this.inParamStorageList = inParamStorageList;
}

}

public class S4PIDeleteCacheStorageFromListOutput {
public S4PIDeleteCacheStorageFromListOutput() {
}

}

/// <summary>
/// ReferenceServiceAPIMethod: DeleteCacheStorageFromList
/// </summary>
public static async Task DeleteCacheStorageFromList(IRequestContext requestContext,BasicTypeList<long> inParamStorageList,CancellationToken cancellationToken) {
var serviceActionName = "DeleteCacheStorageFromList";
var serviceActionKey = "0b3ddc8b-2b94-4f5e-8c08-3321d6d350e9";
var inputs = new S4PIDeleteCacheStorageFromListInput(inParamStorageList);
var outputs = await Instance.InvokeServiceActionAsync<S4PIDeleteCacheStorageFromListInput, S4PIDeleteCacheStorageFromListOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
await Task.Yield();

return;
}
public class S4PIServiceStorageGetFileByPartsInput {
[JsonProperty("i_StorageId")]
public long? inParami_StorageId;
[JsonProperty("i_ChunkNumber")]
public int? inParami_ChunkNumber;
[JsonProperty("i_TotalChunks")]
public int? inParami_TotalChunks;
[JsonProperty("i_Guid")]
public string inParami_Guid;
public S4PIServiceStorageGetFileByPartsInput(long? inParami_StorageId, int? inParami_ChunkNumber, int? inParami_TotalChunks, string inParami_Guid) {
this.inParami_StorageId = inParami_StorageId;
this.inParami_ChunkNumber = inParami_ChunkNumber;
this.inParami_TotalChunks = inParami_TotalChunks;
this.inParami_Guid = inParami_Guid;
}

}

public class S4PIServiceStorageGetFileByPartsOutput {
[JsonProperty("o_File")]
public byte[] outParamo_File;
[JsonProperty("o_filename")]
public string outParamo_filename;
[JsonProperty("o_fileInText")]
public string outParamo_fileInText;
[JsonProperty("IsBinary")]
public bool outParamIsBinary;
public S4PIServiceStorageGetFileByPartsOutput(byte[] outParamo_File, string outParamo_filename, string outParamo_fileInText, bool outParamIsBinary) {
this.outParamo_File = outParamo_File;
this.outParamo_filename = outParamo_filename;
this.outParamo_fileInText = outParamo_fileInText;
this.outParamIsBinary = outParamIsBinary;
}

public S4PIServiceStorageGetFileByPartsOutput() {
this.outParamIsBinary = false;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceStorageGetFileByParts
/// </summary>
public static async Task<(byte[],string,string,bool)> ServiceStorageGetFileByParts(IRequestContext requestContext,long? inParami_StorageId,int? inParami_ChunkNumber,int? inParami_TotalChunks,string inParami_Guid,CancellationToken cancellationToken) {
byte[] outParamo_File = default;
string outParamo_filename = default;
string outParamo_fileInText = default;
bool outParamIsBinary = default;
outParamo_File = new byte[] {};

outParamo_filename = "";

outParamo_fileInText = "";

outParamIsBinary = false;

var serviceActionName = "ServiceStorageGetFileByParts";
var serviceActionKey = "4ee4de09-ee59-43e8-906a-12f31bcd42d4";
var inputs = new S4PIServiceStorageGetFileByPartsInput(inParami_StorageId, inParami_ChunkNumber, inParami_TotalChunks, inParami_Guid);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceStorageGetFileByPartsInput, S4PIServiceStorageGetFileByPartsOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamo_File = outputs.outParamo_File;
outParamo_filename = outputs.outParamo_filename;
outParamo_fileInText = outputs.outParamo_fileInText;
outParamIsBinary = outputs.outParamIsBinary;
await Task.Yield();

return (outParamo_File,outParamo_filename,outParamo_fileInText,outParamIsBinary);
}
public class S4PIServiceStorageCreateOrUpdateBigFileInput {
[JsonProperty("Source")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord inParamSource;
[JsonProperty("DirectSave")]
public bool? inParamDirectSave;
[JsonProperty("FileId")]
public long? inParamFileId;
public S4PIServiceStorageCreateOrUpdateBigFileInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord inParamSource, bool? inParamDirectSave, long? inParamFileId) {
this.inParamSource = inParamSource;
this.inParamDirectSave = inParamDirectSave;
this.inParamFileId = inParamFileId;
}

}

public class S4PIServiceStorageCreateOrUpdateBigFileOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceStorageCreateOrUpdateBigFileOutput(long outParamId) {
this.outParamId = outParamId;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceStorageCreateOrUpdateBigFile
/// </summary>
public static async Task<long> ServiceStorageCreateOrUpdateBigFile(IRequestContext requestContext,EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord inParamSource,bool? inParamDirectSave,long? inParamFileId,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

var serviceActionName = "ServiceStorageCreateOrUpdateBigFile";
var serviceActionKey = "524ab090-d01f-4c8b-9efe-196a1e5978f2";
var inputs = new S4PIServiceStorageCreateOrUpdateBigFileInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(inParamSource, ServiceConfiguration), inParamDirectSave, inParamFileId);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceStorageCreateOrUpdateBigFileInput, S4PIServiceStorageCreateOrUpdateBigFileOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamId = outputs.outParamId;
await Task.Yield();

return outParamId;
}
public class S4PIServiceStorageCreateOrUpdateInput {
[JsonProperty("Source")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord inParamSource;
[JsonProperty("DirectSave")]
public bool? inParamDirectSave;
public S4PIServiceStorageCreateOrUpdateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord inParamSource, bool? inParamDirectSave) {
this.inParamSource = inParamSource;
this.inParamDirectSave = inParamDirectSave;
}

}

public class S4PIServiceStorageCreateOrUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceStorageCreateOrUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceStorageCreateOrUpdate
/// </summary>
public static async Task<long> ServiceStorageCreateOrUpdate(IRequestContext requestContext,EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord inParamSource,bool? inParamDirectSave,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

var serviceActionName = "ServiceStorageCreateOrUpdate";
var serviceActionKey = "6f957df8-1282-411a-89af-0bef37c52cc7";
var inputs = new S4PIServiceStorageCreateOrUpdateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(inParamSource, ServiceConfiguration), inParamDirectSave);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceStorageCreateOrUpdateInput, S4PIServiceStorageCreateOrUpdateOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamId = outputs.outParamId;
await Task.Yield();

return outParamId;
}
public class S4PIServiceStorageDeleteInput {
[JsonProperty("Id")]
public long? inParamId;
public S4PIServiceStorageDeleteInput(long? inParamId) {
this.inParamId = inParamId;
}

}

public class S4PIServiceStorageDeleteOutput {
public S4PIServiceStorageDeleteOutput() {
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceStorageDelete
/// </summary>
public static async Task ServiceStorageDelete(IRequestContext requestContext,long? inParamId,CancellationToken cancellationToken) {
var serviceActionName = "ServiceStorageDelete";
var serviceActionKey = "8bc056e9-46af-4bdd-8d2f-2e981859ea7a";
var inputs = new S4PIServiceStorageDeleteInput(inParamId);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceStorageDeleteInput, S4PIServiceStorageDeleteOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
await Task.Yield();

return;
}
public class S4PIServiceStorageCreateInput {
[JsonProperty("Source")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord inParamSource;
[JsonProperty("DirectSave")]
public bool? inParamDirectSave;
public S4PIServiceStorageCreateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord inParamSource, bool? inParamDirectSave) {
this.inParamSource = inParamSource;
this.inParamDirectSave = inParamDirectSave;
}

}

public class S4PIServiceStorageCreateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceStorageCreateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceStorageCreate
/// </summary>
public static async Task<long> ServiceStorageCreate(IRequestContext requestContext,EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord inParamSource,bool? inParamDirectSave,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

var serviceActionName = "ServiceStorageCreate";
var serviceActionKey = "a3770380-3226-4c7a-9014-4b9f56bf6fd5";
var inputs = new S4PIServiceStorageCreateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(inParamSource, ServiceConfiguration), inParamDirectSave);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceStorageCreateInput, S4PIServiceStorageCreateOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamId = outputs.outParamId;
await Task.Yield();

return outParamId;
}
public class S4PIServiceStorageGetFileInput {
[JsonProperty("i_StorageId")]
public long? inParami_StorageId;
public S4PIServiceStorageGetFileInput(long? inParami_StorageId) {
this.inParami_StorageId = inParami_StorageId;
}

}

public class S4PIServiceStorageGetFileOutput {
[JsonProperty("o_File")]
public byte[] outParamo_File;
[JsonProperty("o_filename")]
public string outParamo_filename;
public S4PIServiceStorageGetFileOutput(byte[] outParamo_File, string outParamo_filename) {
this.outParamo_File = outParamo_File;
this.outParamo_filename = outParamo_filename;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceStorageGetFile
/// </summary>
public static async Task<(byte[],string)> ServiceStorageGetFile(IRequestContext requestContext,long? inParami_StorageId,CancellationToken cancellationToken) {
byte[] outParamo_File = default;
string outParamo_filename = default;
outParamo_File = new byte[] {};

outParamo_filename = "";

var serviceActionName = "ServiceStorageGetFile";
var serviceActionKey = "de8f53e5-2ab8-4deb-aa51-2af01e6ec8a8";
var inputs = new S4PIServiceStorageGetFileInput(inParami_StorageId);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceStorageGetFileInput, S4PIServiceStorageGetFileOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamo_File = outputs.outParamo_File;
outParamo_filename = outputs.outParamo_filename;
await Task.Yield();

return (outParamo_File,outParamo_filename);
}
public class S4PIServiceGetDocumentsByListIdInput {
[JsonProperty("IdsList")]
public long[] inParamIdsList;
public S4PIServiceGetDocumentsByListIdInput(long[] inParamIdsList) {
this.inParamIdsList = inParamIdsList;
}

}

public class S4PIServiceGetDocumentsByListIdOutput {
[JsonProperty("BinaryZip")]
public byte[] outParamBinaryZip;
public S4PIServiceGetDocumentsByListIdOutput(byte[] outParamBinaryZip) {
this.outParamBinaryZip = outParamBinaryZip;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceGetDocumentsByListId
/// </summary>
public static async Task<byte[]> ServiceGetDocumentsByListId(IRequestContext requestContext,BasicTypeList<long> inParamIdsList,CancellationToken cancellationToken) {
byte[] outParamBinaryZip = default;
outParamBinaryZip = new byte[] {};

var serviceActionName = "ServiceGetDocumentsByListId";
var serviceActionKey = "fd19b13f-a821-43c9-ac57-4b7b3e1377e9";
var inputs = new S4PIServiceGetDocumentsByListIdInput(inParamIdsList);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceGetDocumentsByListIdInput, S4PIServiceGetDocumentsByListIdOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamBinaryZip = outputs.outParamBinaryZip;
await Task.Yield();

return outParamBinaryZip;
}
public class S4PIServiceResendFailedFileInput {
[JsonProperty("StorageId")]
public long? inParamStorageId;
public S4PIServiceResendFailedFileInput(long? inParamStorageId) {
this.inParamStorageId = inParamStorageId;
}

}

public class S4PIServiceResendFailedFileOutput {
public S4PIServiceResendFailedFileOutput() {
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceResendFailedFile
/// </summary>
public static async Task ServiceResendFailedFile(IRequestContext requestContext,long? inParamStorageId,CancellationToken cancellationToken) {
var serviceActionName = "ServiceResendFailedFile";
var serviceActionKey = "fd4be54e-0b7b-440c-a8dd-4e09d939f16e";
var inputs = new S4PIServiceResendFailedFileInput(inParamStorageId);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceResendFailedFileInput, S4PIServiceResendFailedFileOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
await Task.Yield();

return;
}

        }
    }
}
