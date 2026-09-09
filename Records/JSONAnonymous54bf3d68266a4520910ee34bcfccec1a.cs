using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderContractFileForeignResidenceOrderFileForeignResidenceRecord
public class JSONRC_55a4f62f090e92d07d40f0b63ffe2d16 : AbstractRESTStructure<RC_55a4f62f090e92d07d40f0b63ffe2d16> {
[JsonProperty("OrderContractFileForeignResidence")]
[JsonPropertyName("OrderContractFileForeignResidence")]
public ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord AttrOrderContractFileForeignResidence;

[JsonProperty("OrderFileForeignResidence")]
[JsonPropertyName("OrderFileForeignResidence")]
public ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord AttrOrderFileForeignResidence;

public JSONRC_55a4f62f090e92d07d40f0b63ffe2d16() { }

public JSONRC_55a4f62f090e92d07d40f0b63ffe2d16 (RC_55a4f62f090e92d07d40f0b63ffe2d16 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderContractFileForeignResidence = ConvertToRestWithoutDefaults(s.ssENOrderContractFileForeignResidence, new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure, config);
AttrOrderFileForeignResidence = ConvertToRestWithoutDefaults(s.ssENOrderFileForeignResidence, new EN_096339be3ef098b3762e8897e3a1c095EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure, config);
  } else {
AttrOrderContractFileForeignResidence = ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure(s.ssENOrderContractFileForeignResidence, config);
AttrOrderFileForeignResidence = ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure(s.ssENOrderFileForeignResidence, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_55a4f62f090e92d07d40f0b63ffe2d16, RC_55a4f62f090e92d07d40f0b63ffe2d16> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_55a4f62f090e92d07d40f0b63ffe2d16 s) => ToStructure(s, config);
}
public static RC_55a4f62f090e92d07d40f0b63ffe2d16 ToStructure(ssConectaProveedores.RestRecords.JSONRC_55a4f62f090e92d07d40f0b63ffe2d16 obj, IBehaviorsConfiguration config) { 
  RC_55a4f62f090e92d07d40f0b63ffe2d16 s = new RC_55a4f62f090e92d07d40f0b63ffe2d16();
  if(obj != null) {
  s.ssENOrderContractFileForeignResidence = ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.ToStructure(obj.AttrOrderContractFileForeignResidence, config);
  s.ssENOrderFileForeignResidence = ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.ToStructure(obj.AttrOrderFileForeignResidence, config);
  }
  return s;
}

public static Func<RC_55a4f62f090e92d07d40f0b63ffe2d16, ssConectaProveedores.RestRecords.JSONRC_55a4f62f090e92d07d40f0b63ffe2d16> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_55a4f62f090e92d07d40f0b63ffe2d16 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_55a4f62f090e92d07d40f0b63ffe2d16 FromStructure(RC_55a4f62f090e92d07d40f0b63ffe2d16 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_55a4f62f090e92d07d40f0b63ffe2d16(s, config);
}

}


