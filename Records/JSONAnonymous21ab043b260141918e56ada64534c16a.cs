using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// StorageFileStructRecord
public class JSONRC_72174731c5fd0896036e84e89a92eae9 : AbstractRESTStructure<RC_72174731c5fd0896036e84e89a92eae9> {
[JsonProperty("StorageFileStruct")]
[JsonPropertyName("StorageFileStruct")]
public ssConectaProveedores.RestRecords.JSONST_8917d167cfa0f31ec1ed2a0d24e80bccStructure AttrStorageFileStruct;

public JSONRC_72174731c5fd0896036e84e89a92eae9() { }

public JSONRC_72174731c5fd0896036e84e89a92eae9 (RC_72174731c5fd0896036e84e89a92eae9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStorageFileStruct = ConvertToRestWithoutDefaults(s.ssSTStorageFileStruct, new ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure(), ssConectaProveedores.RestRecords.JSONST_8917d167cfa0f31ec1ed2a0d24e80bccStructure.FromStructure, config);
  } else {
AttrStorageFileStruct = ssConectaProveedores.RestRecords.JSONST_8917d167cfa0f31ec1ed2a0d24e80bccStructure.FromStructure(s.ssSTStorageFileStruct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_72174731c5fd0896036e84e89a92eae9, RC_72174731c5fd0896036e84e89a92eae9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_72174731c5fd0896036e84e89a92eae9 s) => ToStructure(s, config);
}
public static RC_72174731c5fd0896036e84e89a92eae9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_72174731c5fd0896036e84e89a92eae9 obj, IBehaviorsConfiguration config) { 
  RC_72174731c5fd0896036e84e89a92eae9 s = new RC_72174731c5fd0896036e84e89a92eae9();
  if(obj != null) {
  s.ssSTStorageFileStruct = ssConectaProveedores.RestRecords.JSONST_8917d167cfa0f31ec1ed2a0d24e80bccStructure.ToStructure(obj.AttrStorageFileStruct, config);
  }
  return s;
}

public static Func<RC_72174731c5fd0896036e84e89a92eae9, ssConectaProveedores.RestRecords.JSONRC_72174731c5fd0896036e84e89a92eae9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_72174731c5fd0896036e84e89a92eae9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_72174731c5fd0896036e84e89a92eae9 FromStructure(RC_72174731c5fd0896036e84e89a92eae9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_72174731c5fd0896036e84e89a92eae9(s, config);
}

}


