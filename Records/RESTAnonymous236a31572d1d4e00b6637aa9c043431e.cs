using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileOrderContractFileOrderFileRecord
public class RESTRC_b644f30294f981dde9a2d54c91ae805a : AbstractRESTStructure<RC_b644f30294f981dde9a2d54c91ae805a> {
[JsonProperty("OrderRequestFile")]
public ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord AttrOrderRequestFile;

[JsonProperty("OrderContractFile")]
public ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord AttrOrderContractFile;

[JsonProperty("OrderFile")]
public ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord AttrOrderFile;

public RESTRC_b644f30294f981dde9a2d54c91ae805a() { }

public RESTRC_b644f30294f981dde9a2d54c91ae805a (RC_b644f30294f981dde9a2d54c91ae805a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFile = ConvertToRestWithoutDefaults(s.ssENOrderRequestFile, new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure, config);
AttrOrderContractFile = ConvertToRestWithoutDefaults(s.ssENOrderContractFile, new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure, config);
AttrOrderFile = ConvertToRestWithoutDefaults(s.ssENOrderFile, new EN_096339be3ef098b3762e8897e3a1c095EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure, config);
  } else {
AttrOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure(s.ssENOrderRequestFile, config);
AttrOrderContractFile = ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure(s.ssENOrderContractFile, config);
AttrOrderFile = ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure(s.ssENOrderFile, config);
  }
}

public static RC_b644f30294f981dde9a2d54c91ae805a ToStructure(ssConectaProveedores.RestRecords.RESTRC_b644f30294f981dde9a2d54c91ae805a obj) { 
  RC_b644f30294f981dde9a2d54c91ae805a s = new RC_b644f30294f981dde9a2d54c91ae805a();
  if(obj != null) {
  s.ssENOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.ToStructure(obj.AttrOrderRequestFile);
  s.ssENOrderContractFile = ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.ToStructure(obj.AttrOrderContractFile);
  s.ssENOrderFile = ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.ToStructure(obj.AttrOrderFile);
  }
  return s;
}

public static Func<RC_b644f30294f981dde9a2d54c91ae805a, ssConectaProveedores.RestRecords.RESTRC_b644f30294f981dde9a2d54c91ae805a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b644f30294f981dde9a2d54c91ae805a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b644f30294f981dde9a2d54c91ae805a FromStructure(RC_b644f30294f981dde9a2d54c91ae805a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b644f30294f981dde9a2d54c91ae805a(s, config);
}

}


