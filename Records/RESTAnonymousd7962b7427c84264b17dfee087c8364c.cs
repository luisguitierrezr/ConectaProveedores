using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderItemEntriesOrderMainItemOrderMainLineSumRecord
public class RESTRC_fab74841dcf4769bb7fe99529b7664cf : AbstractRESTStructure<RC_fab74841dcf4769bb7fe99529b7664cf> {
[JsonProperty("OrderItemEntries")]
public ssConectaProveedores.RestRecords.RESTEN_0eb2cf39b93366f50855e537f6b98500EntityRecord AttrOrderItemEntries;

[JsonProperty("OrderMainItem")]
public ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("LineSum")]
public decimal? AttrLineSum;

public RESTRC_fab74841dcf4769bb7fe99529b7664cf() { }

public RESTRC_fab74841dcf4769bb7fe99529b7664cf (RC_fab74841dcf4769bb7fe99529b7664cf s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderItemEntries = ConvertToRestWithoutDefaults(s.ssENOrderItemEntries, new EN_0eb2cf39b93366f50855e537f6b98500EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.FromStructure, config);
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrLineSum = ConvertToRestWithoutDefaults(s.ssLineSum, 0.0M);
  } else {
AttrOrderItemEntries = ssConectaProveedores.RestRecords.RESTEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.FromStructure(s.ssENOrderItemEntries, config);
AttrOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrLineSum = (decimal?) s.ssLineSum;
  }
}

public static RC_fab74841dcf4769bb7fe99529b7664cf ToStructure(ssConectaProveedores.RestRecords.RESTRC_fab74841dcf4769bb7fe99529b7664cf obj) { 
  RC_fab74841dcf4769bb7fe99529b7664cf s = new RC_fab74841dcf4769bb7fe99529b7664cf();
  if(obj != null) {
  s.ssENOrderItemEntries = ssConectaProveedores.RestRecords.RESTEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.ToStructure(obj.AttrOrderItemEntries);
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssLineSum = obj.AttrLineSum == null ? 0.0M : obj.AttrLineSum.Value;
  }
  return s;
}

public static Func<RC_fab74841dcf4769bb7fe99529b7664cf, ssConectaProveedores.RestRecords.RESTRC_fab74841dcf4769bb7fe99529b7664cf> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fab74841dcf4769bb7fe99529b7664cf s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_fab74841dcf4769bb7fe99529b7664cf FromStructure(RC_fab74841dcf4769bb7fe99529b7664cf s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_fab74841dcf4769bb7fe99529b7664cf(s, config);
}

}


