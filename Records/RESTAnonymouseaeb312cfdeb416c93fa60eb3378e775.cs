using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderContractFileOrderFileRecord
public class RESTRC_8171c5e0188443e9384b8f5492517b0e : AbstractRESTStructure<RC_8171c5e0188443e9384b8f5492517b0e> {
[JsonProperty("OrderContractFile")]
public ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord AttrOrderContractFile;

[JsonProperty("OrderFile")]
public ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord AttrOrderFile;

public RESTRC_8171c5e0188443e9384b8f5492517b0e() { }

public RESTRC_8171c5e0188443e9384b8f5492517b0e (RC_8171c5e0188443e9384b8f5492517b0e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderContractFile = ConvertToRestWithoutDefaults(s.ssENOrderContractFile, new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure, config);
AttrOrderFile = ConvertToRestWithoutDefaults(s.ssENOrderFile, new EN_096339be3ef098b3762e8897e3a1c095EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure, config);
  } else {
AttrOrderContractFile = ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure(s.ssENOrderContractFile, config);
AttrOrderFile = ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure(s.ssENOrderFile, config);
  }
}

public static RC_8171c5e0188443e9384b8f5492517b0e ToStructure(ssConectaProveedores.RestRecords.RESTRC_8171c5e0188443e9384b8f5492517b0e obj) { 
  RC_8171c5e0188443e9384b8f5492517b0e s = new RC_8171c5e0188443e9384b8f5492517b0e();
  if(obj != null) {
  s.ssENOrderContractFile = ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.ToStructure(obj.AttrOrderContractFile);
  s.ssENOrderFile = ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.ToStructure(obj.AttrOrderFile);
  }
  return s;
}

public static Func<RC_8171c5e0188443e9384b8f5492517b0e, ssConectaProveedores.RestRecords.RESTRC_8171c5e0188443e9384b8f5492517b0e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8171c5e0188443e9384b8f5492517b0e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8171c5e0188443e9384b8f5492517b0e FromStructure(RC_8171c5e0188443e9384b8f5492517b0e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8171c5e0188443e9384b8f5492517b0e(s, config);
}

}


