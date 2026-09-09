using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// GutterSize
public class RESTEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord : AbstractRESTStructure<EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord> {
[JsonProperty("GutterSize")]
public string AttrGutterSize;

[JsonProperty("Order")]
public int? AttrOrder;

public RESTEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord() { }

public RESTEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord (EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGutterSize = s.ssGutterSize;
AttrOrder = (int?) s.ssOrder;
  } else {
AttrGutterSize = s.ssGutterSize;
AttrOrder = (int?) s.ssOrder;
  }
}

public static EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord obj) { 
  EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord s = new EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord();
  if(obj != null) {
  s.ssGutterSize = obj.AttrGutterSize == null ? "" : obj.AttrGutterSize;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  }
  return s;
}

public static Func<EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord, ssConectaProveedores.RestRecords.RESTEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord FromStructure(EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord(s, config);
}

}


