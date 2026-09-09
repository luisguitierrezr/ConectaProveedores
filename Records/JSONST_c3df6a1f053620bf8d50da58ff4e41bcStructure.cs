using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderFileTypesStruct
public class JSONST_c3df6a1f053620bf8d50da58ff4e41bcStructure : AbstractRESTStructure<ST_c3df6a1f053620bf8d50da58ff4e41bcStructure> {
[JsonProperty("OrderContractFile")]
[JsonPropertyName("OrderContractFile")]
public ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord AttrOrderContractFile;

[JsonProperty("OrderFile")]
[JsonPropertyName("OrderFile")]
public ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord AttrOrderFile;

[JsonProperty("Valid")]
[JsonPropertyName("Valid")]
public ssConectaProveedores.RestRecords.JSONST_b453bea0930035904f55a74692afd3a8Structure AttrValid;

[JsonProperty("Binary")]
[JsonPropertyName("Binary")]
public byte[] AttrBinary;

public JSONST_c3df6a1f053620bf8d50da58ff4e41bcStructure() { }

public JSONST_c3df6a1f053620bf8d50da58ff4e41bcStructure (ST_c3df6a1f053620bf8d50da58ff4e41bcStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderContractFile = ConvertToRestWithoutDefaults(s.ssOrderContractFile, new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure, config);
AttrOrderFile = ConvertToRestWithoutDefaults(s.ssOrderFile, new EN_096339be3ef098b3762e8897e3a1c095EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure, config);
AttrValid = ConvertToRestWithoutDefaults(s.ssValid, new ST_b453bea0930035904f55a74692afd3a8Structure(), ssConectaProveedores.RestRecords.JSONST_b453bea0930035904f55a74692afd3a8Structure.FromStructure, config);
AttrBinary = ConvertToRestWithoutDefaults(s.ssBinary);
  } else {
AttrOrderContractFile = ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure(s.ssOrderContractFile, config);
AttrOrderFile = ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure(s.ssOrderFile, config);
AttrValid = ssConectaProveedores.RestRecords.JSONST_b453bea0930035904f55a74692afd3a8Structure.FromStructure(s.ssValid, config);
AttrBinary = s.ssBinary;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_c3df6a1f053620bf8d50da58ff4e41bcStructure, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_c3df6a1f053620bf8d50da58ff4e41bcStructure s) => ToStructure(s, config);
}
public static ST_c3df6a1f053620bf8d50da58ff4e41bcStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_c3df6a1f053620bf8d50da58ff4e41bcStructure obj, IBehaviorsConfiguration config) { 
  ST_c3df6a1f053620bf8d50da58ff4e41bcStructure s = new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure();
  if(obj != null) {
  s.ssOrderContractFile = ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.ToStructure(obj.AttrOrderContractFile, config);
  s.ssOrderFile = ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.ToStructure(obj.AttrOrderFile, config);
  s.ssValid = ssConectaProveedores.RestRecords.JSONST_b453bea0930035904f55a74692afd3a8Structure.ToStructure(obj.AttrValid, config);
  s.ssBinary = obj.AttrBinary == null ? new byte[] {} : obj.AttrBinary;
  }
  return s;
}

public static Func<ST_c3df6a1f053620bf8d50da58ff4e41bcStructure, ssConectaProveedores.RestRecords.JSONST_c3df6a1f053620bf8d50da58ff4e41bcStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_c3df6a1f053620bf8d50da58ff4e41bcStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_c3df6a1f053620bf8d50da58ff4e41bcStructure FromStructure(ST_c3df6a1f053620bf8d50da58ff4e41bcStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_c3df6a1f053620bf8d50da58ff4e41bcStructure(s, config);
}

}


