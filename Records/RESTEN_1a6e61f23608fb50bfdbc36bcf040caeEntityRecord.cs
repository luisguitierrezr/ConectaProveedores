using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AccountingDataType
public class RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord : AbstractRESTStructure<EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

[JsonProperty("IsEstim_Equal_Agreed")]
public bool? AttrIsEstim_Equal_Agreed;

public RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord() { }

public RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord (EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrIsEstim_Equal_Agreed = ConvertToRestWithoutDefaults(s.ssIsEstim_Equal_Agreed, false);
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrIsEstim_Equal_Agreed = (bool?) s.ssIsEstim_Equal_Agreed;
  }
}

public static EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord obj) { 
  EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord s = new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  s.ssIsEstim_Equal_Agreed = obj.AttrIsEstim_Equal_Agreed == null ? false : obj.AttrIsEstim_Equal_Agreed.Value;
  }
  return s;
}

public static Func<EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord, ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord FromStructure(EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord(s, config);
}

}


