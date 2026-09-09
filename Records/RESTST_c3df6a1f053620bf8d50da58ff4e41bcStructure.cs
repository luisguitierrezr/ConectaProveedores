using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderFileTypesStruct
public class RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure : AbstractRESTStructure<ST_c3df6a1f053620bf8d50da58ff4e41bcStructure> {
[JsonProperty("OrderContractFile")]
public ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord AttrOrderContractFile;

[JsonProperty("OrderFile")]
public ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord AttrOrderFile;

[JsonProperty("Valid")]
public ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure AttrValid;

[JsonProperty("Binary")]
public byte[] AttrBinary;

public RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure() { }

public RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure (ST_c3df6a1f053620bf8d50da58ff4e41bcStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderContractFile = ConvertToRestWithoutDefaults(s.ssOrderContractFile, new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure, config);
AttrOrderFile = ConvertToRestWithoutDefaults(s.ssOrderFile, new EN_096339be3ef098b3762e8897e3a1c095EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure, config);
AttrValid = ConvertToRestWithoutDefaults(s.ssValid, new ST_b453bea0930035904f55a74692afd3a8Structure(), ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure.FromStructure, config);
AttrBinary = ConvertToRestWithoutDefaults(s.ssBinary);
  } else {
AttrOrderContractFile = ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure(s.ssOrderContractFile, config);
AttrOrderFile = ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure(s.ssOrderFile, config);
AttrValid = ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure.FromStructure(s.ssValid, config);
AttrBinary = s.ssBinary;
  }
}

public static ST_c3df6a1f053620bf8d50da58ff4e41bcStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure obj) { 
  ST_c3df6a1f053620bf8d50da58ff4e41bcStructure s = new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure();
  if(obj != null) {
  s.ssOrderContractFile = ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.ToStructure(obj.AttrOrderContractFile);
  s.ssOrderFile = ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.ToStructure(obj.AttrOrderFile);
  s.ssValid = ssConectaProveedores.RestRecords.RESTST_b453bea0930035904f55a74692afd3a8Structure.ToStructure(obj.AttrValid);
  s.ssBinary = obj.AttrBinary == null ? new byte[] {} : obj.AttrBinary;
  }
  return s;
}

public static Func<ST_c3df6a1f053620bf8d50da58ff4e41bcStructure, ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_c3df6a1f053620bf8d50da58ff4e41bcStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure FromStructure(ST_c3df6a1f053620bf8d50da58ff4e41bcStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure(s, config);
}

}


