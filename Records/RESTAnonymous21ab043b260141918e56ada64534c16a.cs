using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// StorageFileStructRecord
public class RESTRC_72174731c5fd0896036e84e89a92eae9 : AbstractRESTStructure<RC_72174731c5fd0896036e84e89a92eae9> {
[JsonProperty("StorageFileStruct")]
public ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure AttrStorageFileStruct;

public RESTRC_72174731c5fd0896036e84e89a92eae9() { }

public RESTRC_72174731c5fd0896036e84e89a92eae9 (RC_72174731c5fd0896036e84e89a92eae9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStorageFileStruct = ConvertToRestWithoutDefaults(s.ssSTStorageFileStruct, new ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure(), ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure.FromStructure, config);
  } else {
AttrStorageFileStruct = ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure.FromStructure(s.ssSTStorageFileStruct, config);
  }
}

public static RC_72174731c5fd0896036e84e89a92eae9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_72174731c5fd0896036e84e89a92eae9 obj) { 
  RC_72174731c5fd0896036e84e89a92eae9 s = new RC_72174731c5fd0896036e84e89a92eae9();
  if(obj != null) {
  s.ssSTStorageFileStruct = ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure.ToStructure(obj.AttrStorageFileStruct);
  }
  return s;
}

public static Func<RC_72174731c5fd0896036e84e89a92eae9, ssConectaProveedores.RestRecords.RESTRC_72174731c5fd0896036e84e89a92eae9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_72174731c5fd0896036e84e89a92eae9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_72174731c5fd0896036e84e89a92eae9 FromStructure(RC_72174731c5fd0896036e84e89a92eae9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_72174731c5fd0896036e84e89a92eae9(s, config);
}

}


