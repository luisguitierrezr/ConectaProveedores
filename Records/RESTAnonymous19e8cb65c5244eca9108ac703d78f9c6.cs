using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyOrderMainItemOrderMainRecord
public class RESTRC_f8f8f0b7fba136e61b433a9935152136 : AbstractRESTStructure<RC_f8f8f0b7fba136e61b433a9935152136> {
[JsonProperty("Currency")]
public ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("OrderMainItem")]
public ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public RESTRC_f8f8f0b7fba136e61b433a9935152136() { }

public RESTRC_f8f8f0b7fba136e61b433a9935152136 (RC_f8f8f0b7fba136e61b433a9935152136 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static RC_f8f8f0b7fba136e61b433a9935152136 ToStructure(ssConectaProveedores.RestRecords.RESTRC_f8f8f0b7fba136e61b433a9935152136 obj) { 
  RC_f8f8f0b7fba136e61b433a9935152136 s = new RC_f8f8f0b7fba136e61b433a9935152136();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency);
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  }
  return s;
}

public static Func<RC_f8f8f0b7fba136e61b433a9935152136, ssConectaProveedores.RestRecords.RESTRC_f8f8f0b7fba136e61b433a9935152136> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f8f8f0b7fba136e61b433a9935152136 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f8f8f0b7fba136e61b433a9935152136 FromStructure(RC_f8f8f0b7fba136e61b433a9935152136 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f8f8f0b7fba136e61b433a9935152136(s, config);
}

}


