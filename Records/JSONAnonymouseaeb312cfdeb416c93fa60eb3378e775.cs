using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderContractFileOrderFileRecord
public class JSONRC_8171c5e0188443e9384b8f5492517b0e : AbstractRESTStructure<RC_8171c5e0188443e9384b8f5492517b0e> {
[JsonProperty("OrderContractFile")]
[JsonPropertyName("OrderContractFile")]
public ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord AttrOrderContractFile;

[JsonProperty("OrderFile")]
[JsonPropertyName("OrderFile")]
public ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord AttrOrderFile;

public JSONRC_8171c5e0188443e9384b8f5492517b0e() { }

public JSONRC_8171c5e0188443e9384b8f5492517b0e (RC_8171c5e0188443e9384b8f5492517b0e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderContractFile = ConvertToRestWithoutDefaults(s.ssENOrderContractFile, new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure, config);
AttrOrderFile = ConvertToRestWithoutDefaults(s.ssENOrderFile, new EN_096339be3ef098b3762e8897e3a1c095EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure, config);
  } else {
AttrOrderContractFile = ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure(s.ssENOrderContractFile, config);
AttrOrderFile = ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure(s.ssENOrderFile, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8171c5e0188443e9384b8f5492517b0e, RC_8171c5e0188443e9384b8f5492517b0e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8171c5e0188443e9384b8f5492517b0e s) => ToStructure(s, config);
}
public static RC_8171c5e0188443e9384b8f5492517b0e ToStructure(ssConectaProveedores.RestRecords.JSONRC_8171c5e0188443e9384b8f5492517b0e obj, IBehaviorsConfiguration config) { 
  RC_8171c5e0188443e9384b8f5492517b0e s = new RC_8171c5e0188443e9384b8f5492517b0e();
  if(obj != null) {
  s.ssENOrderContractFile = ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.ToStructure(obj.AttrOrderContractFile, config);
  s.ssENOrderFile = ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.ToStructure(obj.AttrOrderFile, config);
  }
  return s;
}

public static Func<RC_8171c5e0188443e9384b8f5492517b0e, ssConectaProveedores.RestRecords.JSONRC_8171c5e0188443e9384b8f5492517b0e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8171c5e0188443e9384b8f5492517b0e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8171c5e0188443e9384b8f5492517b0e FromStructure(RC_8171c5e0188443e9384b8f5492517b0e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8171c5e0188443e9384b8f5492517b0e(s, config);
}

}


